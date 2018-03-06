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
    public partial class Asteroids : Form
    {
        int facingDirection;
        PictureBox spaceShipImage = new PictureBox();
        PictureBox[] asteroidsImage = new PictureBox[5]; // setitng up array for asteroid images.
        PictureBox missleImage = new PictureBox();
        bool fire = false;
        int[,] coordAsteroids = { { -100, 950 }, { -100, -100 }, { 1700, 500 }, { 1700, -100 }, { 1650, 1400 } }; // sets coordinated for each asteroids. Some are off screen to simulate the astoeroids flying in.



        public Asteroids()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(ShipMoveEvent);
        }

        private void Asteroids_Load(object sender, EventArgs e) // main form.
        {
            AsteroidSetup();
            AsteroidMovement();
            ShipSetup();
        }



        void ShipSetup() // space ship spawn.
        {
            spaceShipImage.Image = Properties.Resources.ship2;
            spaceShipImage.Size = new Size(50, 50); //setting size
            spaceShipImage.SizeMode = PictureBoxSizeMode.StretchImage; // stretching image.
            facingDirection = 0;

            //position of image 
            spaceShipImage.Left = 800;
            spaceShipImage.Top = 500;
            Controls.Add(spaceShipImage); // adding image to form
        }


        void AsteroidSetup() // asteroids spawning
        {
            for (int i = 0; i < 5; i++)
            {
                asteroidsImage[i] = new PictureBox(); // creating new picture box.
                asteroidsImage[i].Image = Properties.Resources.asteroid;
                asteroidsImage[i].Size = new Size(100, 100); //setting size
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
            if (asteroidsImage[0].Left > ClientSize.Width + 60) // when timer ticks, it checks the distance from the screen to the asteroid and then relocate if it's our of bounds. 1st asteroid.
            {
                asteroidsImage[0].Left = coordAsteroids[0, 0]; // if it goes past the screen size, the asteroid is relocated.
                asteroidsImage[0].Top = coordAsteroids[0, 1];
            }
            else // if the asteroid is in bounds, continue moving the asteroid.
            {
                asteroidsImage[0].Left += 4;
                asteroidsImage[0].Top -= 4;
            }


            if (asteroidsImage[1].Left > ClientSize.Width + 60) //2nd asteroid
            {
                asteroidsImage[1].Left = coordAsteroids[1, 0];
                asteroidsImage[1].Top = coordAsteroids[1, 1];
            }
            else
            {
                asteroidsImage[1].Left += 3; // direction of movement using coordinates
                asteroidsImage[1].Top += 2;
            }


            if (asteroidsImage[2].Left < -60) //3rd asteroid.
            {
                asteroidsImage[2].Left = coordAsteroids[2, 0];
                asteroidsImage[2].Top = coordAsteroids[2, 1];
            }
            else
            {
                asteroidsImage[2].Left -= 4;
                asteroidsImage[2].Top -= 1;
            }


            if (asteroidsImage[3].Left < -60) // 4th adteroid.
            {
                asteroidsImage[3].Left = coordAsteroids[3, 0];
                asteroidsImage[3].Top = coordAsteroids[3, 1];
            }
            else
            {
                asteroidsImage[3].Left -= 5;
                asteroidsImage[3].Top += 3;
            }


            if (asteroidsImage[4].Left < -60) // 5th asteroid.
            {
                asteroidsImage[4].Left = coordAsteroids[4, 0];
                asteroidsImage[4].Top = coordAsteroids[4, 1];
            }
            else
            {
                asteroidsImage[4].Left -= 7;
                asteroidsImage[4].Top -= 4;
            }
        }

        void missleTimer_Tick(object sender, EventArgs e)
        {
            if (!fire)
            {
                missleImage.BackColor = Color.Red;
                MissleStartPosition();
                missleImage.Size = new Size(10, 10);
                Controls.Add(missleImage);
                fire = true;
            }
            MissleMovement();
        }



        void ShipMoveEvent(object sender, KeyEventArgs e) // when keys are pressed to rotate ship.
        {
            this.Focus();
            switch (e.KeyCode) // gets key argument.
            {

                //WASD ship movement
                case Keys.W:
                    //spaceShipImage.Left -= 5;
                    spaceShipImage.Top -= 5;
                    break;
                case Keys.S:
                    spaceShipImage.Top += 5;
                    break;
                case Keys.A:
                    spaceShipImage.Left -= 5;
                    break;
                case Keys.D:
                    spaceShipImage.Left += 5;
                    break;

                case Keys.Space:
                    missleTimer.Interval = 1;
                    missleTimer.Start();
                    break;


                //Rotation ship movement
                case Keys.Left:


                    spaceShipImage.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    spaceShipImage.Refresh();
                    if (facingDirection <= 0)
                    {
                        facingDirection = 0;

                    }
                    else
                    {
                        facingDirection = facingDirection - 1;
                    }
                    break;

                case Keys.Right:

                    spaceShipImage.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    spaceShipImage.Refresh();
                    if (facingDirection >= 3)
                    {
                        facingDirection = 3;

                    }
                    else
                    {
                        facingDirection = facingDirection + 1;
                    }
                    break;


            }

        }
        void MissleMovement()
        {

            switch (facingDirection)
            {
                case 0:
                    if (missleImage.Bottom >= 0)
                    {
                        missleImage.Top -= 5;
                    }
                    else
                    {
                        fire = false;
                        missleTimer.Enabled = false;
                        Controls.Remove(missleImage);
                    }
                    break;


                case 1: // firing right
                    if (missleImage.Right <= this.ClientSize.Width)
                    {
                        missleImage.Left += 5;
                    }
                    else
                    {
                        fire = false;
                        missleTimer.Enabled = false;
                        Controls.Remove(missleImage);
                    }
                    break;


                case 2: // firing down
                    if (missleImage.Top <= this.ClientSize.Height)
                    {
                        missleImage.Top += 5;
                    }
                    else
                    {
                        fire = false;
                        missleTimer.Enabled = false;
                        Controls.Remove(missleImage);
                    }
                    break;


                case 3: // firing left.
                    if (missleImage.Left >= -50)
                    {
                        missleImage.Left -= 5;
                    }
                    else
                    {
                        fire = false;
                        missleTimer.Enabled = false;
                        Controls.Remove(missleImage);
                    }
                    break;
            }

        }
        void MissleStartPosition() // start position.
        {
            if (!fire)
            {
                switch (facingDirection)
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


    }
}
