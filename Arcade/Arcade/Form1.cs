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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e) // main menu
        {

        }







        //Main menu buttons
        private void Pacman_Click(object sender, EventArgs e) //Open pacman form (button)
        {
            Frogger frogger = new Frogger();
            frogger.Show();
        }

        private void Asteroids_Click(object sender, EventArgs e) // open steroids form (button)
        {
            Asteroids asteroids = new Asteroids();
            asteroids.Show();      
        }

        private void Pong_Click(object sender, EventArgs e)// open Pong form (button)
        {
            Pong pong = new Pong();
            pong.Show();
        }

        private void Battleship_Click(object sender, EventArgs e)// open Battleship form (button)
        {
            BattleShip battle = new BattleShip();
            battle.Show();
        }

        private void Exit_Click(object sender, EventArgs e) // exit button
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
