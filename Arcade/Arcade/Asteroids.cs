﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// FOR SOUNDS AND GRAPHICS
// http://www.classicgaming.cc/classics/asteroids/
// https://clipartxtras.com/download/b15a10a58936140c8c2e3ae13f02a305d6e5da5c.html
// http://pixelartmaker.com/gallery?start=45900
//https://giphy.com/gifs/animation-fire-smoke-d4aVHC1HKnButuXC

namespace Arcade
{
    public partial class Asteroids : Form
    {
        
        System.Media.SoundPlayer asteroidHit = new System.Media.SoundPlayer(Properties.Resources.astHit);
        System.Media.SoundPlayer missleFire = new System.Media.SoundPlayer(Properties.Resources.firev2);
        System.Media.SoundPlayer deathSound = new System.Media.SoundPlayer(Properties.Resources.astDeathSound);
        System.Media.SoundPlayer menuSong = new System.Media.SoundPlayer(Properties.Resources.astMainMenuSong);
        System.Media.SoundPlayer playSound = new System.Media.SoundPlayer(Properties.Resources.astPlayButtonSound);
        int facingDirection, bulletDirection, score;
        PictureBox explosion = new PictureBox();
        PictureBox spaceShipImage = new PictureBox(); // test123
        PictureBox[] asteroidsImage = new PictureBox[5]; // setitng up array for asteroid images.
        PictureBox missleImage = new PictureBox();
        bool fire = false;
        int[,] coordAsteroids = { { -100, 950 }, { -100, -100 }, { 1500, 500 }, { 1300, -100 }, { 1300, 800 } }; // sets coordinated for each asteroids. Some are off screen to simulate the astoeroids flying in.



        //all sounds for the game
        private void playMenuSounds()
        {
            menuSong.Play();
        }
        private void playDeathSound()
        {
            deathSound.Play();
        }
        private void playAsteroidHit()
        {
            asteroidHit.Play();
        }
        private void playMissleFire()
        {
            missleFire.Play();
        }
        private void playButtonSound()
        {
            playSound.Play();
        }
        public Asteroids()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(ShipMoveEvent);
        }

        //once start button is clicked
        private void startButton_Click(object sender, EventArgs e)
        {
            menuSong.Stop();
            playButtonSound();

            startButton.Hide();
            MenuGraphic.Hide();
            astLogoPicBox.Hide();

            ammoIndicator.Show();
            AsteroidSetup();
            AsteroidMovement();
            ShipSetup();
            
        }
        private void ExitButton_Click(object sender, EventArgs e) // exit button
        {
            this.Close();
            menuSong.Stop();         
        }


        private void Asteroids_Load(object sender, EventArgs e) // menu form
        { 
            playMenuSounds();
            ammoIndicator.Hide();
        }

        void ShipSetup() // space ship spawn.
        {
            spaceShipImage.Image = Properties.Resources.ship4;
            spaceShipImage.Size = new Size(75, 75); //setting size
            spaceShipImage.SizeMode = PictureBoxSizeMode.StretchImage; // stretching image.
            facingDirection = 0;

            //position of image 
            spaceShipImage.Top = 350;
            spaceShipImage.Left = 600;
            Controls.Add(spaceShipImage); // adding image to form
        }


        void AsteroidSetup() // asteroids spawning
        {
            for (int i = 0; i < 5; i++)
            {
                asteroidsImage[i] = new PictureBox(); // creating new picture box.
                asteroidsImage[i].Image = Properties.Resources.asteroid2;
                asteroidsImage[i].Size = new Size(85, 85); //setting size
                asteroidsImage[i].SizeMode = PictureBoxSizeMode.StretchImage; // stretching image.

                //position of image relative to form coordinates.
                asteroidsImage[i].Left = coordAsteroids[i, 0];
                asteroidsImage[i].Top = coordAsteroids[i, 1];

                Controls.Add(asteroidsImage[i]); // adding image to form.
            }
        }


        void AsteroidMovement() // starts the asteroid movement.
        {
            asteroidTimer.Start();
        }


        // checks position of each asteroid.
        private void asteroidTimer_Tick(object sender, EventArgs e) // asteroid timer.
        {
            if (asteroidsImage[0].Left > ClientSize.Width + 60 || asteroidsImage[0].Visible == false) // when timer ticks, it checks the distance from the screen to the asteroid and then relocate if it's our of bounds. 1st asteroid.
            {
                asteroidsImage[0].Visible = true;
                asteroidsImage[0].Left = coordAsteroids[0, 0]; // if it goes past the screen size, the asteroid is relocated.
                asteroidsImage[0].Top = coordAsteroids[0, 1];
            }
            else // if the asteroid is in bounds, continue moving the asteroid.
            {
                asteroidsImage[0].Left += 2;
                asteroidsImage[0].Top -= 2;
            }


            if (asteroidsImage[1].Left > ClientSize.Width + 60 || asteroidsImage[1].Visible == false) //2nd asteroid
            {
                asteroidsImage[1].Visible = true;
                asteroidsImage[1].Left = coordAsteroids[1, 0];
                asteroidsImage[1].Top = coordAsteroids[1, 1];
            }
            else
            {
                asteroidsImage[1].Left += 1; // direction of movement using coordinates
                asteroidsImage[1].Top += 1;
            }


            if (asteroidsImage[2].Left < -60 || asteroidsImage[2].Visible == false) //3rd asteroid.
            {
                asteroidsImage[2].Visible = true;
                asteroidsImage[2].Left = coordAsteroids[2, 0];
                asteroidsImage[2].Top = coordAsteroids[2, 1];
            }
            else
            {
                asteroidsImage[2].Left -= 2;
                asteroidsImage[2].Top -= 1;
            }


            if (asteroidsImage[3].Left < -60 || asteroidsImage[3].Visible == false) // 4th adteroid.
            {
                asteroidsImage[3].Visible = true;
                asteroidsImage[3].Left = coordAsteroids[3, 0];
                asteroidsImage[3].Top = coordAsteroids[3, 1];
            }
            else
            {
                asteroidsImage[3].Left -= 3;
                asteroidsImage[3].Top += 1;
            }


            if (asteroidsImage[4].Left < -60 || asteroidsImage[4].Visible == false) // 5th asteroid.
            {
                asteroidsImage[4].Visible = true;
                asteroidsImage[4].Left = coordAsteroids[4, 0];
                asteroidsImage[4].Top = coordAsteroids[4, 1];
            }
            else
            {
                asteroidsImage[4].Left -= 4;
                asteroidsImage[4].Top -= 2;
            }

            for (int i = 0; i < 5; i++) // if one of 5 asteroids hits the ship.
            {
                if (asteroidsImage[i].Bounds.IntersectsWith(spaceShipImage.Bounds) && asteroidsImage[i].Visible == true) // uses bounds/intersection.
                {
                    asteroidsImage[0].Visible = false;
                    asteroidsImage[1].Visible = false;
                    asteroidsImage[2].Visible = false;
                    asteroidsImage[3].Visible = false;
                    asteroidsImage[4].Visible = false;
                    spaceShipImage.Visible = false;
                    playDeathSound();
                    asteroidTimer.Stop();
                    missleTimer.Stop();
                    MessageBox.Show("Game over! Score: " + score + "");
                    this.Close();
                    Asteroids asteroids = new Asteroids();
                    asteroids.Show();

                }
            }
        }

        void missleTimer_Tick(object sender, EventArgs e)  // spawning in missle image.
        {
            
            if (!fire)
            {
                ammoIndicator.Hide();
                missleImage.BackColor = Color.Red;
                MissleStartPosition();
                missleImage.Size = new Size(10, 15);
                playMissleFire();
                Controls.Add(missleImage);
                fire = true;
                
            }           
            MissleMovement();
            MissleHitDetection();
        }


        void ShipMoveEvent(object sender, KeyEventArgs e) // when keys are pressed to rotate ship.
        {
            switch (e.KeyCode) // gets key argument.
            {

                //WASD ship movement
                case Keys.W:
                    //spaceShipImage.Left -= 5;
                    spaceShipImage.Top -= 18;
                    break;
                case Keys.S:
                    spaceShipImage.Top += 18;
                    break;
                case Keys.A:
                    spaceShipImage.Left -= 18;
                    break;
                case Keys.D:
                    spaceShipImage.Left += 18;
                    break;

                case Keys.Space:
                    missleTimer.Interval = 1;
                    missleTimer.Start();
                    break;


                //Rotation ship movement
                case Keys.Left:

                    spaceShipImage.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    spaceShipImage.Refresh();
                    if (facingDirection == 0)
                    {
                        facingDirection = 3;
                    }
                    else
                    {
                        facingDirection = facingDirection - 1;
                    }
                    break;

                case Keys.Right:

                    spaceShipImage.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    spaceShipImage.Refresh();
                    if (facingDirection == 3)
                    {
                        facingDirection = 0;
                    }
                    else
                    {
                        facingDirection = facingDirection + 1;
                    }
                    break;

            }

        }
        void MissleMovement() // moves the missle once it is fired.
        {
            
            switch (bulletDirection)
            {
                case 0:
                    if (missleImage.Bottom >= 0)
                    {
                        missleImage.Top -= 14;
                    }
                    else
                    {
                        fire = false;
                        ammoIndicator.Show();
                        missleTimer.Enabled = false;
                        Controls.Remove(missleImage);
                    }
                    break;

                case 1: // firing right
                    if (missleImage.Right <= this.ClientSize.Width)
                    {
                        missleImage.Left += 14;
                    }
                    else
                    {
                        fire = false;
                        ammoIndicator.Show();
                        missleTimer.Enabled = false;
                        Controls.Remove(missleImage);
                    }
                    break;

                case 2: // firing down
                    if (missleImage.Top <= this.ClientSize.Height)
                    {
                        missleImage.Top += 14;
                    }
                    else
                    {
                        fire = false;
                        ammoIndicator.Show();
                        missleTimer.Enabled = false;
                        Controls.Remove(missleImage);
                    }
                    break;


                case 3: // firing left.
                    if (missleImage.Left >= -50)
                    {
                        missleImage.Left -= 14;
                    }
                    else
                    {
                        fire = false;
                        ammoIndicator.Show();
                        missleTimer.Enabled = false;
                        Controls.Remove(missleImage);
                    }
                    break;
            }


        }
        void MissleStartPosition() // start position for missle, making sure is spawns at the tip of the ship.
        {
            if (!fire)
            {
                bulletDirection = facingDirection;
                switch (bulletDirection) // sets the start position of missle depending on facing direction.
                {
                    case 0:
                        missleImage.Top = spaceShipImage.Top;
                        missleImage.Left = spaceShipImage.Left + 23;
                        break;
                    case 1:
                        missleImage.Top = spaceShipImage.Top + 23;
                        missleImage.Left = spaceShipImage.Left;
                        break;
                    case 2:
                        missleImage.Top = spaceShipImage.Top;
                        missleImage.Left = spaceShipImage.Left + 23;
                        break;
                    case 3:
                        missleImage.Top = spaceShipImage.Top + 25;
                        missleImage.Left = spaceShipImage.Left;
                        break;

                }
            }
        }
    
        
        void MissleHitDetection() // if the missle comes into intersection contact with an asteroid image...
        {
            if (fire) // if a missle fires..
            {

                for (int i = 0; i < 5; i++)
                {
                    
                    if (missleImage.Bounds.IntersectsWith(asteroidsImage[i].Bounds) && asteroidsImage[i].Visible == true)
                    {
                        explosion.Visible = true;
                        explosion.Image = Properties.Resources.explosion;
                        explosion.SizeMode = PictureBoxSizeMode.StretchImage;
                        explosion.Left = asteroidsImage[i].Left;
                        explosion.Top = asteroidsImage[i].Top;
                        Controls.Add(explosion);
                        explosionGif();
                        ammoIndicator.Show();

                        asteroidsImage[i].Visible = false;
                        fire = false;
                        missleTimer.Enabled = false;
                        Controls.Remove(missleImage);
                        score++;
                        playAsteroidHit();
                        ScoreTracker.Text = $"Score: {Convert.ToString(score)}";

                    }

                }
            }
        }
        private async void explosionGif() // function for playing the explosion gif for asteroid explosions.
        {
            await Task.Delay(1500);
            explosion.Visible = false;
            Controls.Remove(explosion);
        }



        private void MenuGraphic_Click(object sender, EventArgs e)
        {

        }

        private void ammoIndicator_Click(object sender, EventArgs e)
        {

        }

        private void astLogoPicBox_Click(object sender, EventArgs e)
        {

        }
        private void ScoreTracker_Click(object sender, EventArgs e)
        {

        }
    }

}
