using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Arcade
{
    public partial class Pong : Form
    {

        bool GoUp1;//Bool to determine whether the player wants to go up or not
        bool GoUp2;//Bool top determine whether player2 wants to go up or not
        bool GoDown1;//Bool to determine whether the player wants to go down or not
        bool GoDown2;//Bool to determine whether the player2 wants to go up or not
        int ballx = 5;//Horizontal X axis speed value for the ball object
        int bally = 5;//Vertical Y axis speed value for the ball object
        int Score1 = 0;//Score for player 1
        int Score2 = 0;//Score for player 2
        bool shoot1;//Allows player 1 to shoot a block
        int B1x = 15;//allow player one to shoot a block
        bool shoot2;
        int B2x = 15;
        int B2Position = 40;
        int B1Position = 40;
        public Pong()
        {
            InitializeComponent();
            GameTimer.Stop();//Sets it so that the game doesnt start until one of the players moves their bars
            
        }

        private void Player2_Click(object sender, EventArgs e)
        {
            
        }

        private void Pong_Load(object sender, EventArgs e)
        {
           
        }

        private void Player1_Click(object sender, EventArgs e)
        {

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)//Changes the up Bool to false if the player presses the up button
            {
                GoUp2 = false;
                GameTimer.Start();
            }
            else if (e.KeyCode == Keys.Down)//Changes the down bool to false if the player presses the down button
            {
                GoDown2 = false;
                GameTimer.Start();
            }
            if (e.KeyCode == Keys.W)//Changes the up Bool to false if player1 presses the W key
            {
                GoUp1 = false;
                GameTimer.Start();
            }

            else if (e.KeyCode == Keys.S)//Changes the down bool to false if the player presses the down button
            {
                GoDown1 = false;
                GameTimer.Start();
            }
           
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)//Changes the up Bool to true if the player1 presses the up button
            {
                GoUp1 = true;
                GameTimer.Start();
            }
            if (e.KeyCode == Keys.S)//Changes the down bool to true if the player2 presses the S button
            {
                GoDown1 = true;
                GameTimer.Start();
            }
            if (e.KeyCode == Keys.D)
            {
                shoot1 = true;
                GameTimer.Start();
            }
            if (e.KeyCode == Keys.Up )//Changes the up Bool to true if the player2 presses the up button
            {
                GoUp2 = true;
                GameTimer.Start();
            }
            if (e.KeyCode == Keys.Down)//Changes the down bool to true if the player1 presses the down button
            {
                GoDown2 = true;
                GameTimer.Start();
            }
            if (e.KeyCode == Keys.Left)
            {
                shoot2 = true;
                GameTimer.Start();
            }
        }
        
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Player1Score.Text = "" + Score1;//shows the score for player 1
            Player2Score.Text = "" + Score2;//shows the score for player 2

            //Allows the ball to move
            ball.Top -= bally;//Assigns the ball Top to bally integer
            ball.Left -= ballx;//Assigns the ball Left to the ballx integer
            
            //Allow player 1 to shoot a block at player2
            if (shoot1 == false)
            {
                B1.Location = new Point(Player1.Location.X ,Player1.Location.Y + B1Position);
            }
           
            if (shoot1 == true)
            {
                B1.Left += B1x;
            }
            if (B1.Left + B1.Width > ClientSize.Width)
            {
                B1.Location = new Point(Player1.Location.X , Player1.Location.Y + B1Position);
                shoot1 = false;
            }
            if (B1.Bounds.IntersectsWith(Player2.Bounds))
            {
                Player2.Height /= 2;
                B1.Location = new Point(Player1.Location.X , Player1.Location.Y + B1Position);
                B2Position /= 2;
                shoot1 = false;
            }
            
            //Allows player2 to shoot at player1
            if (shoot2 == false)
            {
                B2.Location = new Point(Player2.Location.X, Player2.Location.Y + B2Position);
            }

            if (shoot2 == true)
            {
                B2.Left -= B2x;
            }
            if (B2.Left<0)
            {
                B2.Location = new Point(Player2.Location.X, Player2.Location.Y + B2Position);
                shoot2 = false;
            }
            if (B2.Bounds.IntersectsWith(Player1.Bounds))
            {
                Player1.Height /= 2;
                B2.Location = new Point(Player2.Location.X, Player2.Location.Y + B2Position);
                B1Position /= 2;
                shoot2 = false;
            }

            if (ball.Left < 0)//Checks the score if the ball gets past the left through player 2
            {
                int CenterH = ClientSize.Height / 2;
                int CenterW = ClientSize.Width / 2;
                ball.Left = CenterW;//Resets the ball to the middle of the screen
                ball.Top = CenterH;//Resets the ball to the center of the screen height wise
                ballx = -ballx;//Changes the ball direction
                //ballx -= 2; // increases the speed of the ball
                Score2++;//adds one to player2 score
                GameTimer.Stop();//Pauses the game whenever a player scores
            }

            if (ball.Left + ball.Width > ClientSize.Width)//Checks the score if the ball gets past the right through player 1
            {
                int CenterH = ClientSize.Height / 2;
                int CenterW = ClientSize.Width / 2;
                ball.Left = CenterW;//Resets the ball to the middle of the screen width wise
                ball.Top = CenterH;//Resets the ball to the center of the screen height wise
                ballx = -ballx;//Changes the direction of the ball
                //ballx += 2; //Increases the speed of the ball
                Score1++;//adds one to player1 score
                GameTimer.Stop();//Pauses the game whenever a player scores
            }

            if (ball.Top < 0 | ball.Top + ball.Height > ClientSize.Height)//Sets the boundary for the top and bottom of the screen
            {
                bally = -bally;//Reverses the speed of the ball so that the ball stays within the screen
            }

            if (ball.Bounds.IntersectsWith(Player1.Bounds) | ball.Bounds.IntersectsWith(Player2.Bounds) | ball.Bounds.IntersectsWith(B1.Bounds) | ball.Bounds.IntersectsWith(B2.Bounds))//if the ball hits the player1 or player 2
            {
                ballx = -ballx;//The ball bounces in the other direction
            }

            if (GoUp1 == true & Player1.Top > 0)//allows player1 to move up
            {
                Player1.Top -= 8;
                GameTimer.Start();
            }
            if (GoUp2 == true & Player2.Top > 0)//allows player2 to move up
            {
                Player2.Top -= 8;
                GameTimer.Start();
            }

            if (GoDown2 == true & Player1.Top < Player1.Bottom)//allows player1 to move down
            {
                
                Player2.Top += 8;
                GameTimer.Start();
            }
            if (GoDown1 == true & Player2.Top < Player2.Bottom)//allows player2 to move down
            {
                Player1.Top += 8;
                GameTimer.Start();
            }

            if (Score1 == 10)//IF player 1 scores 10 points then player1 wins
            {
                GameTimer.Stop();
                MessageBox.Show("Player 1 wins!");
            }
            if (Score2 == 10)//If player 2 wins then player 2 wins
            {
                GameTimer.Stop();
                MessageBox.Show("Player 2 wins!");
            }
        }

        private void Player1Score_Click(object sender, EventArgs e)
        {

        }

        private void Player2Score_Click(object sender, EventArgs e)
        {

        }
        
    }
}
