using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcade
{
    public partial class BattleShip : Form
    {
        List<Button> playerPosition; //create a list for all the player position buttons
        List<Button> enemyPosition; //creates a list for all the enenmy position buttons
        Random rand = new Random(); //create a new instance for the random class called rand
        int totalShips = 3; //number of player ships
        int totalenemy = 3; //number of enemy ships
        int rounds = 32; //total rounds to play - each will play 16 rounds
        int playerTotalScore = 0; //default player score
        int enemyTotalScore = 0; //default enemy score


        public BattleShip()
        {
            InitializeComponent();
            loadbuttons(); //load the buttons for enemy and player to the system
            attackButton.Enabled = false; //disable the player attack button
            enemyLocationList.Text = null; //nullify the enemy location drop down box
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playerPicksPosition(object sender, EventArgs e)
        {
            //this function will let the player pick 3 places on the map
            //in the beginning of the game this is how i allow the player to pick 3 spots

            if (totalShips > 0)
            {
                var button = (Button)sender;

                button.Enabled = false;

                button.Tag = "playerShip";

                button.BackColor = System.Drawing.Color.Blue;

                totalShips--;
            }
            if (totalShips == 0)
            {
                attackButton.Enabled = true;

                attackButton.BackColor = System.Drawing.Color.Red;

                helpText.Top = 80
                    ;

                helpText.Left = 230;

                helpText.Text = "2) Now pick an attack position from the drop down menu";
            }



        }

        private void attackEnemyPosition(object sender, EventArgs e)
        {

            //this function will allow the player to make the moves on the enemy location
            //need to check if the player can choose a location from the drop down list

            if (enemyLocationList.Text != "")
            {

                var attackPos = enemyLocationList.Text;

                attackPos = attackPos.ToLower();

                int index = enemyPosition.FindIndex(a => a.Name == attackPos);

                if (enemyPosition[index].Enabled && rounds > 0)
                {
                    rounds--;

                    roundsText.Text = "Rounds " + rounds;

                    if (enemyPosition[index].Tag == "enemyship")
                    {
                        enemyPosition[index].Enabled = false;

                        enemyPosition[index].BackgroundImage = Properties.Resources.BattleShipFireIcon;
						enemyPosition[index].BackgroundImageLayout = ImageLayout.Stretch;


						enemyPosition[index].BackColor = System.Drawing.Color.DarkBlue;

                        playerTotalScore++;

                        playerScore.Text = "" + playerTotalScore;

                        enemyPlayTimer.Start();
                    }
                    else
                    {
                        enemyPosition[index].Enabled = false;

                        enemyPosition[index].BackgroundImage = Properties.Resources.BattleShipMissIcon;
						enemyPosition[index].BackgroundImageLayout = ImageLayout.Stretch;

						enemyPlayTimer.Start();
                    }
                }
            }
            else
            {
                //if player doesnt pick a location from the drop down listm alert them to do so
                MessageBox.Show("Choose a location from the drop down list. ");
            }

        }

        private void enemyAttackPlayer(object sender, EventArgs e)
        {

            //this function is for the CPU to make a move on the player

            //if the player position is more than 0 and there are more rounds to play
            // then the following will be donw inside this if statement

            if (playerPosition.Count > 0 && rounds > 0)
            {

                rounds--; //reduce the round from the total
                roundsText.Text = "Rounds " + rounds; //show the updated number of rounds on the label

                int index = rand.Next(playerPosition.Count);

                if (playerPosition[index].Tag == "playerShip")
                {
                    //if the index has a tag of playership then the following will be done

                    playerPosition[index].BackgroundImage = Properties.Resources.BattleShipFireIcon;
					enemyPosition[index].BackgroundImageLayout = ImageLayout.Stretch;

					enemyMoves.Text = "" + playerPosition[index].Text; //show which button was attacked

                    playerPosition[index].Enabled = false; //disable the button

                    playerPosition[index].BackColor = System.Drawing.Color.DarkBlue; //change the background color to dark blue

                    playerPosition.RemoveAt(index); ////removes this button form the player position list so it wont get attacked again by the CPU

                    enemyTotalScore++; //add 1 to enemy score

                    enemyScore.Text = "" + enemyTotalScore; //show the enemy score on the label

                    enemyPlayTimer.Stop(); //stop the time for the CPU

                }
                else
                {
                    // if the player tag isnt of playership then the following is done

                    playerPosition[index].BackgroundImage = Properties.Resources.BattleShipMissIcon;
					enemyPosition[index].BackgroundImageLayout = ImageLayout.Stretch;

					enemyMoves.Text = "" + playerPosition[index].Text; //update the enenmy attack location on label 2

                    playerPosition[index].Enabled = false; //disable the button cpu attacked

                    playerPosition[index].BackColor = System.Drawing.Color.DarkBlue; //change the background color to dark blue

                    playerPosition.RemoveAt(index); //remove this button from the list so it wont get attacked again by the CPU

                    enemyPlayTimer.Stop(); //stop the cpu time
                }
            }

            //if statemtn to check whether player won, tied, or lost

            if (rounds < 1 || playerTotalScore > 2 || enemyTotalScore > 2)
            {
                if (playerTotalScore > enemyTotalScore)
                {
                    MessageBox.Show("You Win!", "Winning");
                }
                if (playerTotalScore == enemyTotalScore)
                {
                    MessageBox.Show("Tie Game", "Draw");
                }
                if (enemyTotalScore > playerTotalScore)
                {
                    MessageBox.Show("I sunk your battle ships!", "Lost");
                }
            }
        }

        private void enemyPicksPosition(object sender, EventArgs e)
        {

            //this function will alloow the CPU to pick 3 spots on the map
            //need too make sure that the enemy CPU will pick 3 dif. spots on the map

            int index = rand.Next(enemyPosition.Count); //create a local variable index and choose a randokm button from the enemy position list

            if (enemyPosition[index].Enabled == true && enemyPosition[index].Tag == null)
            {
                //make sure buttons arent already chosen
                enemyPosition[index].Tag = "enemyship";

                totalenemy--;

                //Debug.WriteLine("Enemy Position  " + enemyPosition[index].Text);
                //the line above will show in the debug window which buttons the enemy chose
                //this can help figure out if the game is working as intended
            }
            else
            {
                //if the top condition dont match then it will run again and select 3 positions and tags
                index = rand.Next(enemyPosition.Count);
            }

            if (totalenemy < 1)
            {
                //if the cpu has chosen the 3 positions then we can stop the timer
                enemyPositionPicker.Stop();
            }

        }



        private void loadbuttons()
        {

            //this function will load all the buttons into the lists we declared above
            //we load all the player and enemy buttons first
            playerPosition = new List<Button> { w1, w2, w3, w4, x1, x2, x3, x4, y1, y2, y3, y4, z1, z2, z3, z4 };
            enemyPosition = new List<Button> { a1, a2, a3, a4, b1, b2, b3, b4, c1, c2, c3, c4, d1, d2, d3, d4 };

            //this loop will go through each of the enemy position buttons
            //then it will add them to the enemy location drop down list for me
            // it will also remove all tags from the enemy location buttons
            for (int i = 0; i < enemyPosition.Count; i++)
            {
                enemyPosition[i].Tag = null;
                enemyLocationList.Items.Add(enemyPosition[i].Text);
            }


        }
    }
}
