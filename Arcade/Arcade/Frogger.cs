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
        }

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
            timeLeft -= 5;
            TimeBox.Size = new Size(timeLeft / 10, 25);

            foreach (var PB in this.Controls.OfType<PictureBox>())
            {

                if (PB.Left < -50)
                {
                    PB.Location = new Point(1000, PB.Location.Y);
                }
                if (PB.Left > 1050)
                {
                    PB.Location = new Point(-45, PB.Location.Y);
                }

                if (Frog.Bounds.IntersectsWith(PB.Bounds) && PB.Name != "Frog")
                {
                    if (Frog.Location.Y >= 300)
                    {
                        //everythingMoves.Enabled = false;
                        Frog.Location = new Point(450, 600);
                        lifeLeft--;
                        label1.Text = $"Lives: {lifeLeft}";
                    }
                }
            }
            if (lifeLeft == 0)
            {
                lifeLeft = 4;
                Frog.Location = new Point(450, 600);
                timeLeft = 3000;
            }
            if (timeLeft == 0)
            {
                lifeLeft--;
                Frog.Location = new Point(450, 600);
                timeLeft = 3000;
                label1.Text = $"Lives: {lifeLeft}";
            }
        }

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
            switch (e.KeyChar)
            {
                case 'w':
                    Frog.Location = new Point(Frog.Location.X, Frog.Location.Y - 50);
                    break;
                case 's':
                    Frog.Location = new Point(Frog.Location.X, Frog.Location.Y + 50);
                    break;
                case 'a':
                    Frog.Location = new Point(Frog.Location.X - 25, Frog.Location.Y);
                    break;
                case 'd':
                    Frog.Location = new Point(Frog.Location.X + 25, Frog.Location.Y);
                    break;
            }
        }

        private void moveFrog_Tick(object sender, EventArgs e)
        {
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
                }
            }
        }
    }
}
