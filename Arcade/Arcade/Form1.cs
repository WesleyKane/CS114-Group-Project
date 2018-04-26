using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//images used
//https://giphy.com/gifs/pong-aTGwuEFyg6d8c
//https://giphy.com/gifs/it-follows-dTQzKgfWqniuc
//https://giphy.com/gifs/street-c50uYGAqiRKp2
namespace Arcade
{
    public partial class MainMenu : Form
    {

        System.Media.SoundPlayer menuMusic = new System.Media.SoundPlayer(Properties.Resources.Mainmenumusic);
        public MainMenu()
        {
            InitializeComponent();     
        }

        private void playMenuMusic()
        {
            menuMusic.Play();
        }
        private void MainMenu_Load(object sender, EventArgs e) // main menu
        {
            playMenuMusic();
        }

        // Menu Buttons
        private void PongButton_Click(object sender, EventArgs e)
        {
            Pong pong = new Pong();
            menuMusic.Stop();
            pong.Show();
        }
        private void FroggerButton_Click(object sender, EventArgs e)
        {
            Frogger frogger = new Frogger();
            menuMusic.Stop();
            frogger.Show();
        }

        private void AsteroidsButton_Click(object sender, EventArgs e)
        {
            Asteroids asteroids = new Asteroids();
            menuMusic.Stop();
            asteroids.Show();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            NumberShuffle shuffle = new NumberShuffle();
            menuMusic.Stop();
            shuffle.Show();
        }
        private void Exit_Click(object sender, EventArgs e) // exit button
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
