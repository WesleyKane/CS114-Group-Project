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
    public partial class Pong : Form
    {

        bool GoUp1;//Bool to determine whether the player wants to go up or not
        bool GoUp2;//Bool top determine whether player2 wants to go up or not
        bool GoDown1;//Bool to determine whether the player wants to go down or not
        bool GoDown2;//Bool to determine whether the player2 wants to go up or not
        int ballx = 5;//Horizontal X xpeed value for the ball object
        int bally = 5;//Vertical Y speed value for the ball object
        int Score1 = 0;//Score for player 1
        int Score2 = 0;//Score for player 2

        public Pong()
        {
            InitializeComponent();
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
            }
            else if (e.KeyCode == Keys.Down)//Changes the down bool to false if the player presses the down button
            {
                GoDown2 = false;
            }
            if (e.KeyCode == Keys.W)//Changes the up Bool to false if player1 presses the W key
            {
                GoUp1 = false;
            }

            else if (e.KeyCode == Keys.S)//Changes the down bool to false if the player presses the down button
            {
                GoDown1 = false;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)//Changes the up Bool to true if the player1 presses the up button
            {
                GoUp1 = true;
            }
            if (e.KeyCode == Keys.S)//Changes the down bool to true if the player2 presses the S button
            {
                GoDown1 = true;
            }
            if (e.KeyCode == Keys.Up )//Changes the up Bool to true if the player2 presses the up button
            {
                GoUp2 = true;
            }
            if (e.KeyCode == Keys.Down)//Changes the down bool to true if the player1 presses the down button
            {
                GoDown2 = true;
            }
           
        }
        
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Player1Score.Text = "" + Score1;//shows the score for player 1
            Player2Score.Text = "" + Score2;//shows the score for player 2

            ball.Top -= bally;//Assigns the ball Top to bally integer
            ball.Left -= ballx;//Assigns the ball Left to the ballx integer

            if (ball.Left < 0)//Checks the score if the ball gets past the left through player one
            {
                ball.Left = 434;//Resets the ball to the middle of the screen
                ballx = -ballx;//Changes the ball direction
                ballx -= 2; // increases the speed of the ball
                Score2++;
            }

            if (ball.Left + ball.Width > ClientSize.Width)//Checks the score if the ball gets past the right through player 2
            {
                ball.Left = 434;//Resets the ball to the middle of the screen
                ballx = -ballx;//Changes the direction of the ball
               ballx += 2; //Increases the speed of the ball
                Score1++;//adds one to player1 score
            }

            if (ball.Top < 0 | ball.Top + ball.Height > ClientSize.Height)//Sets the boundary for the top and bottom of the screen
            {
                bally = -bally;//Reverses the speed of the ball so that the ball stays within the screen
            }

            if (ball.Bounds.IntersectsWith(Player1.Bounds) | ball.Bounds.IntersectsWith(Player2.Bounds))//if the ball hits the player1 opr player 2
            {
                ballx = -ballx;//The ball bounces in the other direction
            }

            if (GoUp1 == true & Player1.Top > 0)//allows player1 to move up
            {
                Player1.Top -= 8;
            }
            if (GoUp2 == true & Player2.Top > 0)//allows player2 to move up
            {
                Player2.Top -= 8;
            }

            if (GoDown2 == true & Player1.Top < 455)//allows player1 to move down
            {
                
                Player2.Top += 8;
            }
            if (GoDown1 == true & Player2.Top < 455)//allows player2 to move down
            {
                Player1.Top += 8;
            }

            if (Score1 > 10)//IF player 1 scores 10 points then player1 wins
            {
                GameTimer.Stop();
                MessageBox.Show("Player 1 wins!");
            }
            if (Score2 > 10)//If player 2 wins then player 2 wins
            {
                GameTimer.Stop();
                MessageBox.Show("Player 2 wins!");
            }
        }
    }
}
