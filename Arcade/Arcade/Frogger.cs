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
    public partial class Frogger : Form
    {
        public Frogger()
        {
            InitializeComponent();
            //Allow background without lag
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);

            //Set the frog image to a frog
            Frog.Image = Properties.Resources.froggy;
            Frog.SizeMode = PictureBoxSizeMode.StretchImage;
            pondFrog1.Image = Properties.Resources.froggy;
            pondFrog1.SizeMode = PictureBoxSizeMode.StretchImage;
            pondFrog2.Image = Properties.Resources.froggy;
            pondFrog2.SizeMode = PictureBoxSizeMode.StretchImage;
            pondFrog3.Image = Properties.Resources.froggy;
            pondFrog3.SizeMode = PictureBoxSizeMode.StretchImage;
            pondFrog4.Image = Properties.Resources.froggy;
            pondFrog4.SizeMode = PictureBoxSizeMode.StretchImage;
            pondFrog5.Image = Properties.Resources.froggy;
            pondFrog5.SizeMode = PictureBoxSizeMode.StretchImage;
            //Put the fly in a random place
            RandomFly();
        }

        //Set interval of timer for each set
        int pinkSpeed = 5;
        int greenSpeed = 30;
        int greySpeed = 1;
        int smallLogSpeed = 10;
        int bigLogSpeed = 10;
        int mixTreeSpeed = 7;
        int turtleSpeed = 5;
        int truckSpeed = 25;

        int lifeLeft = 4;
        int timeLeft = 3000;

        private void everythingMoves_Tick_1(object sender, EventArgs e)
        {

            label2.Text = Convert.ToString(Frog.Location);
            timeLeft -= 5;
            TimeBox.Size = new Size(timeLeft / 10, 25);

            
            foreach (var PB in this.Controls.OfType<PictureBox>())
            {
                //Loop the moving objects on the screen
                if (PB.Left < -50)
                {
                    PB.Location = new Point(1000, PB.Location.Y);
                }
                if (PB.Left > 1050)
                {
                    PB.Location = new Point(-45, PB.Location.Y);
                }
                if (PB.Location.Y < -10)
                    PB.Location = new Point(PB.Location.X, 0);
                if (PB.Location.Y > 700)
                    PB.Location = new Point(PB.Location.X, 600);


                //If the frog gets a fly give extra life
                if (Frog.Bounds.IntersectsWith(PB.Bounds) && PB.Name[0] == 'f')
                {
                    restartFrog();
                    lifeLeft++;
                    updateLife();
                    MessageBox.Show("MORE LIFE");
                }

                
                //Frog needs to land in pond
                if (Frog.Location.Y == 0)
                {
                    if (Frog.Location.X > 28 && Frog.Location.X < 128)
                    {
                        if (pondFrog1.Location.X == 57)
                        {
                            lifeLeft--;
                            softReset();
                        }
                        else
                        {
                            pondFrog1.Location = new Point(680, 4);
                            lifeLeft++;
                        }
                    }
                    else if (Frog.Location.X > 234 && Frog.Location.X < 338)
                    {
                        if (pondFrog2.Location.X == 266)
                        {             
                            lifeLeft--;
                            softReset();
                        }
                        else
                        {
                            pondFrog2.Location = new Point(680, 4);
                            lifeLeft++;
                        }
                    }
                    else if (Frog.Location.X > 442 && Frog.Location.X < 546)
                    {
                        if (pondFrog3.Location.X == 473)
                        {
                            lifeLeft--;
                            softReset();
                        }
                        else
                        {
                            pondFrog3.Location = new Point(680, 4);
                            lifeLeft++;
                        }
                    }
                    else if (Frog.Location.X > 651 && Frog.Location.X < 752)
                    {
                        if (pondFrog4.Location.X == 680)
                        {
                            lifeLeft--;
                            softReset();
                        }
                        else
                        {
                            pondFrog4.Location = new Point(680, 4);
                            lifeLeft++;
                        }
                    }
                    else if (Frog.Location.X > 857 && Frog.Location.X < 960)
                        {
                        if (pondFrog5.Location.X == 888)
                        {
                            lifeLeft--;
                            softReset();
                        }
                        else
                        {
                            pondFrog5.Location = new Point(680, 4);
                            lifeLeft++;
                        }
                    }
                    else
                    {
                        restartFrog();
                        lifeLeft--;
                        updateLife();
                    }
                }

                //If frog is hit by car it dies
                if (Frog.Bounds.IntersectsWith(PB.Bounds) && PB.Name != "Frog")
                {
                    if (Frog.Location.Y >= 300)
                    {
                        Frog.Location = new Point(450, 600);
                        lifeLeft--;
                        updateLife();
                        RandomFly();
                    }
                }
            }

            //Restart game when the user has no lives
            if (lifeLeft == 0)
            {
                lifeLeft = 4;
                softReset();
            }
            //Restart when time runs out
            if (timeLeft == 0)
            {
                lifeLeft--;
                softReset();
            }
        }

        //Sound sample
        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            simpleSound.Play();
        }

        private void greycar_Tick(object sender, EventArgs e)
        {
            greycar.Interval = greySpeed;
            //Move Grey Car
            grey1.Left +=3;
            grey2.Left +=3;
            grey3.Left +=3;
            grey4.Left +=3;
        }

        private void truck_Tick(object sender, EventArgs e)
        {
            truck.Interval = truckSpeed;
            //Move Truck
            truck1.Left --;
            truck2.Left --;
            truck3.Left --;
        }

        private void greenCar_Tick(object sender, EventArgs e)
        {
            greenCar.Interval = greenSpeed;
            //Move Green Car
            greenCar1.Left +=2;
            greenCar2.Left +=2;
            greenCar3.Left +=2;
            greenCar4.Left +=2;
        }

        private void pinkCarTimer_Tick(object sender, EventArgs e)
        {
            pinkCarTimer.Interval = pinkSpeed;
            //Move all Pink cars
            PinkCar1.Left --;
            PinkCar2.Left --;
            PinkCar3.Left --;
            PinkCar4.Left --;
            PinkCar5.Left --;
            PinkCar6.Left --;
        }

        private void smallLogTimer_Tick(object sender, EventArgs e)
        {
            smallLogTimer.Interval = smallLogSpeed;
            //move small log
            log1.Left ++;
            log2.Left ++;
            log3.Left ++;
            log4.Left ++;
            log5.Left ++;
            log6.Left ++;
        }

        private void bigLogTimer_Tick(object sender, EventArgs e)
        {
            bigLogTimer.Interval = bigLogSpeed;
            //Move large logs
            bigLog1.Left ++;
            bigLog2.Left ++;
            bigLog3.Left ++;
            bigLog4.Left ++;
        }

        private void mixTreeTimer_Tick(object sender, EventArgs e)
        {
            mixTreeTimer.Interval = mixTreeSpeed;
            //Move large and small logs in first row
            row1_1.Left ++;
            row1_2.Left ++;
            row1_3.Left ++;
            row1_4.Left ++;
            row1_5.Left ++;
        }

        private void turtles_Tick(object sender, EventArgs e)
        {
            turtles.Interval = turtleSpeed;
            foreach (var PB in this.Controls.OfType<PictureBox>())
            {
                //Move turtles
                if (PB.Name[0] == 't' && PB.Name[1] == 'u')
                    PB.Left --;
            }
        }

        private void Frogger_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Frog.Invalidate();

            //Moves the frog
            switch (e.KeyChar)
            {
                case 'w':
                    Frog.Location = new Point(Frog.Location.X, Frog.Location.Y - 50);
                    Frog.Image = Properties.Resources.froggy;
                    break;
                case 's':
                    Frog.Location = new Point(Frog.Location.X, Frog.Location.Y + 50);
                    Frog.Image = Properties.Resources.froggy_Down;
                    break;
                case 'a':
                    Frog.Location = new Point(Frog.Location.X - 25, Frog.Location.Y);
                    Frog.Image = Properties.Resources.froggy_Left;
                    break;
                case 'd':
                    Frog.Location = new Point(Frog.Location.X + 25, Frog.Location.Y);
                    Frog.Image = Properties.Resources.froggy_Right;
                    break;
            }
            Frog.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        private void moveFrog_Tick(object sender, EventArgs e)
        {
            bool inwater = true;
            foreach (var PB in this.Controls.OfType<PictureBox>()) {
                if (Frog.Bounds.IntersectsWith(PB.Bounds) && PB.Name != "Frog")
                {
                    //If the frog is on a log or turtle move with it
                    switch (Frog.Location.Y)
                    {
                        case 250:
                            Frog.Left++;
                            moveFrog.Interval = mixTreeSpeed;
                            break;
                        case 200:
                            Frog.Left--;
                            moveFrog.Interval = turtleSpeed;
                            break;
                        case 150:
                            Frog.Left++;
                            moveFrog.Interval = bigLogSpeed;
                            break;
                        case 100:
                            Frog.Left--;
                            moveFrog.Interval = turtleSpeed;
                            break;
                        case 50:
                            Frog.Left++;
                            moveFrog.Interval = smallLogSpeed;
                            break;
                    }
                    inwater = false;
                }
            }

            //Restart if the frog is in the water    
            if (Frog.Location.Y < 300 && Frog.Location.Y > 20 && inwater == true)
            {
                lifeLeft--;
                restartFrog();
                timeLeft = 3000;
                RandomFly();
                updateLife();
            }
        }

        //Put a fly in a random spot
        private void RandomFly()
        {
            Random r = new Random();

            //get random spot
            int choice = r.Next(0, 10);

            //Put fly in spot or have no fly
            switch (choice)
            {
                case 0:
                    fly1.Location = new Point(57, 4);
                    break;
                case 1:
                    fly1.Location = new Point(266, 4);
                    break;
                case 2:
                    fly1.Location = new Point(473, 4);
                    break;
                case 3:
                    fly1.Location = new Point(680, 4);
                    break;
                case 4:
                    fly1.Location = new Point(888, 4);
                    break;
                default:
                    fly1.Location = new Point(1500, 4);
                    break;
            }
        }
        private void restartFrog()
        {
            Frog.Location = new Point(450, 600);
        }
        private void updateLife()
        {
            label1.Text = $"Lives: {lifeLeft}";
        }
        private void softReset()
        {
            restartFrog();
            timeLeft = 3000;
            RandomFly();
            updateLife();
        }
    }
}
