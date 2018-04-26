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
    public partial class NumberShuffle : Form
    {
        public NumberShuffle()
        {
            InitializeComponent();
        }
        Image[] images = new Image[17];

        int num;
        private void NumberShuffle_Load(object sender, EventArgs e)
        {
            Box1.BackColor = Color.Yellow;
            Box2.BackColor = Color.Yellow;
            Box3.BackColor = Color.Yellow;
            Box4.BackColor = Color.Yellow;
            Box5.BackColor = Color.Yellow;
            Box6.BackColor = Color.Yellow;
            Box7.BackColor = Color.Yellow;
            Box8.BackColor = Color.Yellow;
            Box9.BackColor = Color.Yellow;
            Box10.BackColor = Color.Yellow;
            Box11.BackColor = Color.Yellow;
            Box12.BackColor = Color.Yellow;
            Box13.BackColor = Color.Yellow;
            Box14.BackColor = Color.Yellow;
            Box15.BackColor = Color.Yellow;
            Box16.BackColor = Color.White;


            /*
            Box13.BackColor = Color.Yellow;
            Box14.BackColor = Color.Yellow;
            Box15.BackColor = Color.Yellow;
            Box16.BackColor = Color.White;
            */

            //assigns pictures to each of the picture boxes and streches each of the images 
            images[1] = Properties.Resources.thN128KJB9;
            Box1.SizeMode = PictureBoxSizeMode.StretchImage;
            images[2] = Properties.Resources.logro_19;
            Box2.SizeMode = PictureBoxSizeMode.StretchImage;
            images[3] = Properties.Resources._115192_hi;
            Box3.SizeMode = PictureBoxSizeMode.StretchImage;
            images[4] = Properties.Resources.logro_11;
            Box4.SizeMode = PictureBoxSizeMode.StretchImage;
            images[5] = Properties.Resources.fire1;
            Box5.SizeMode = PictureBoxSizeMode.StretchImage;
            images[6] = Properties.Resources._115191_hi;
            Box6.SizeMode = PictureBoxSizeMode.StretchImage;
            images[7] = Properties.Resources._115193_hi;
            Box7.SizeMode = PictureBoxSizeMode.StretchImage;
            images[8] = Properties.Resources._115194_hi;
            Box8.SizeMode = PictureBoxSizeMode.StretchImage;
            images[9] = Properties.Resources._115190_hi;
            Box9.SizeMode = PictureBoxSizeMode.StretchImage;
            images[10] = Properties.Resources.image;
            Box10.SizeMode = PictureBoxSizeMode.StretchImage;
            images[11] = Properties.Resources.key;
            Box11.SizeMode = PictureBoxSizeMode.StretchImage;
            images[12] = Properties.Resources.images;
            Box12.SizeMode = PictureBoxSizeMode.StretchImage;
            images[13] = Properties.Resources._115177_hi;
            Box12.SizeMode = PictureBoxSizeMode.StretchImage;
            images[14] = Properties.Resources._115175_hi;
            Box12.SizeMode = PictureBoxSizeMode.StretchImage;
            images[15] = Properties.Resources._115176_hi;
            Box12.SizeMode = PictureBoxSizeMode.StretchImage;
            images[16] = Properties.Resources.eating;
            Box12.SizeMode = PictureBoxSizeMode.StretchImage;


            /*
            
            Box13.Image = Properties.Resources.orange;
            Box13.SizeMode = PictureBoxSizeMode.StretchImage;
            Box14.Image = Properties.Resources._115191_hi;
            Box14.SizeMode = PictureBoxSizeMode.StretchImage;
            Box15.Image = Properties.Resources.blue;
            Box15.SizeMode = PictureBoxSizeMode.StretchImage;
            Box16.Image = Properties.Resources.eating;
            Box16.SizeMode = PictureBoxSizeMode.StretchImage;
            */
        }

        //checks to see if user has solved the puzzle by checking to see if all of the buttons went back to their original spot
        public void CheckSolve()
        {
            num = num + 1;
            label2.Text = num + " click";

            if (Box1.Image == images[1] && Box2.Image == images[2] && Box3.Image == images[3] && Box4.Image == images[4] && Box5.Image == images[5] && Box6.Image == images[6] && Box7.Image == images[7] && Box8.Image == images[8] && Box9.Image == images[9] && Box10.Image == images[10] && Box11.Image == images[11] && Box12.Image == images[12])
            {
                MessageBox.Show("You solved the puzzle in " + num + " clicks");
            }
        }

        //checks movement abilities of each of the picture boxes
        private void Box1_Click_1(object sender, EventArgs e)
        {
            if (Box2.Image == images[16])
            {
                Box2.Image = Box1.Image;
                //Box2.BackColor = Color.Yellow;
                Box1.Image = images[16];
                Box1.BackColor = Color.White;
            }

            if (Box5.Image == images[16])
            {
                Box5.Image = Box1.Image;
                Box5.BackColor = Color.Yellow;
                Box1.Image = images[12];
                Box1.BackColor = Color.White;
            }
            CheckSolve();
        }



        private void Box2_Click_1(object sender, EventArgs e)
        {

            if (Box1.Image == images[16])
            {
                Box1.Image = Box2.Image;
                Box1.BackColor = Color.Yellow;
                Box2.Image = images[16];
                Box2.BackColor = Color.White;
            }

            if (Box3.Image == images[16])
            {
                Box3.Image = Box2.Image;
                Box3.BackColor = Color.Yellow;
                Box2.Image = images[16];
                Box2.BackColor = Color.White;
            }

            if (Box6.Image == images[16])
            {
                Box6.Image = Box2.Image;
                Box6.BackColor = Color.Yellow;
                Box2.Image = images[16];
                Box2.BackColor = Color.White;
            }
            CheckSolve();
        }

        private void Box3_Click_1(object sender, EventArgs e)
        {
            if (Box2.Image == images[16])
            {
                Box2.Image = Box3.Image;
                Box2.BackColor = Color.Yellow;
                Box3.Image = images[12];
                Box3.BackColor = Color.White;
            }

            if (Box4.Image == images[16])
            {
                Box4.Image = Box3.Image;
                Box4.BackColor = Color.Yellow;
                Box3.Image = images[16];
                Box3.BackColor = Color.White;
            }

            if (Box7.Image == images[16])
            {
                Box7.Image = Box3.Image;
                Box7.BackColor = Color.Yellow;
                Box3.Image = images[16];
                Box3.BackColor = Color.White;
            }
            CheckSolve();
        }

        private void Box4_Click_1(object sender, EventArgs e)
        {
            if (Box3.Image == images[16])
            {
                Box3.Image = Box4.Image;
                Box3.BackColor = Color.Yellow;
                Box4.Image = images[16];
                Box4.BackColor = Color.White;
            }

            if (Box8.Image == images[16])
            {
                Box8.Image = Box4.Image;
                Box8.BackColor = Color.Yellow;
                Box4.Image = images[16];
                Box4.BackColor = Color.White;
            }

            CheckSolve();
        }

        private void Box5_Click_1(object sender, EventArgs e)
        {
            if (Box1.Image == images[16])
            {
                Box1.Image = Box5.Image;
                Box1.BackColor = Color.Yellow;
                Box5.Image = images[16];
                Box5.BackColor = Color.White;
            }

            if (Box6.Image == images[16])
            {
                Box6.Image = Box5.Image;
                Box6.BackColor = Color.Yellow;
                Box5.Image = images[16];
                Box5.BackColor = Color.White;
            }

            if (Box9.Image == images[16])
            {
                Box9.Image = Box5.Image;
                Box9.BackColor = Color.Yellow;
                Box5.Image = images[16];
                Box5.BackColor = Color.White;
            }
            CheckSolve();
        }

        private void Box6_Click_1(object sender, EventArgs e)
        {
            if (Box7.Image == images[16])
            {
                Box7.Image = Box6.Image;
                Box7.BackColor = Color.Yellow;
                Box6.Image = images[16];
                Box6.BackColor = Color.White;
            }

            if (Box2.Image == images[16])
            {
                Box2.Image = Box6.Image;
                Box2.BackColor = Color.Yellow;
                Box6.Image = images[16];
                Box6.BackColor = Color.White;
            }

            if (Box5.Image == images[16])
            {
                Box5.Image = Box6.Image;
                Box5.BackColor = Color.Yellow;
                Box6.Image = images[16];
                Box6.BackColor = Color.White;
            }

            if (Box10.Image == images[16])
            {
                Box10.Image = Box6.Image;
                Box10.BackColor = Color.Yellow;
                Box6.Image = images[16];
                Box6.BackColor = Color.White;
            }
            CheckSolve();
        }

        private void Box7_Click_1(object sender, EventArgs e)
        {
            if (Box6.Image == images[16])
            {
                Box6.Image = Box7.Image;
                Box6.BackColor = Color.Yellow;
                Box7.Image = images[16];
                Box7.BackColor = Color.White;
            }

            if (Box3.Image == images[16])
            {
                Box3.Image = Box7.Image;
                Box3.BackColor = Color.Yellow;
                Box7.Image = images[16];
                Box7.BackColor = Color.White;
            }

            if (Box8.Image == images[16])
            {
                Box8.Image = Box7.Image;
                Box8.BackColor = Color.Yellow;
                Box7.Image = images[16];
                Box7.BackColor = Color.White;
            }

            if (Box11.Image == images[16])
            {
                Box11.Image = Box7.Image;
                Box11.BackColor = Color.Yellow;
                Box7.Image = images[16];
                Box7.BackColor = Color.White;
            }
            CheckSolve();
        }

        private void Box8_Click_1(object sender, EventArgs e)
        {
            if (Box4.Image == images[16])
            {
                Box4.Image = Box8.Image;
                Box4.BackColor = Color.Yellow;
                Box8.Image = images[16];
                Box8.BackColor = Color.White;
            }

            if (Box7.Image == images[16])
            {
                Box7.Image = Box8.Image;
                Box7.BackColor = Color.Yellow;
                Box8.Image = images[16];
                Box8.BackColor = Color.White;
            }

            if (Box12.Image == images[16])
            {
                Box12.Image = Box8.Image;
                Box12.BackColor = Color.Yellow;
                Box8.Image = images[16];
                Box8.BackColor = Color.White;
            }
            CheckSolve();
        }

        private void Box9_Click_1(object sender, EventArgs e)
        {
            if (Box5.Image == images[16])
            {
                Box5.Image = Box9.Image;
                Box5.BackColor = Color.Yellow;
                Box9.Image = images[16];
                Box9.BackColor = Color.White;
            }

            if (Box10.Image == images[16])
            {
                Box10.Image = Box9.Image;
                Box10.BackColor = Color.Yellow;
                Box9.Image = images[16];
                Box9.BackColor = Color.White;
            }

            if (Box13.Image == images[16])
            {
                Box13.Image = Box9.Image;
                Box13.BackColor = Color.Yellow;
                Box9.Image = images[16];
                Box9.BackColor = Color.White;
            }

            CheckSolve();
        }

        private void Box10_Click_1(object sender, EventArgs e)
        {
            if (Box9.Image == images[16])
            {
                Box9.Image = Box10.Image;
                Box9.BackColor = Color.Yellow;
                Box10.Image = images[16];
                Box10.BackColor = Color.White;
            }

            if (Box6.Image == images[16])
            {
                Box6.Image = Box10.Image;
                Box6.BackColor = Color.Yellow;
                Box10.Image = images[16];
                Box10.BackColor = Color.White;
            }

            if (Box11.Image == images[16])
            {
                Box11.Image = Box10.Image;
                Box11.BackColor = Color.Yellow;
                Box10.Image = images[16];
                Box10.BackColor = Color.White;
            }

            if (Box14.Image == images[16])
            {
                Box14.Image = Box10.Image;
                Box14.BackColor = Color.Yellow;
                Box10.Image = images[16];
                Box10.BackColor = Color.White;
            }
            CheckSolve();
        }

        private void Box11_Click_1(object sender, EventArgs e)
        {
            if (Box10.Image == images[16])
            {
                Box10.Image = Box11.Image;
                Box10.BackColor = Color.Yellow;
                Box11.Image = images[16];
                Box11.BackColor = Color.White;
            }

            if (Box7.Image == images[16])
            {
                Box7.Image = Box11.Image;
                Box7.BackColor = Color.Yellow;
                Box11.Image = images[16];
                Box11.BackColor = Color.White;
            }

            if (Box12.Image == images[16])
            {
                Box12.Image = Box11.Image;
                Box12.BackColor = Color.Yellow;
                Box11.Image = images[16];
                Box11.BackColor = Color.White;
            }

            if (Box15.Image == images[16])
            {
                Box15.Image = Box11.Image;
                Box15.BackColor = Color.Yellow;
                Box11.Image = images[16];
                Box11.BackColor = Color.White;
            }

            CheckSolve();
        }

        private void Box12_Click_1(object sender, EventArgs e)
        {
            if (Box11.Image == images[16])
            {
                Box11.Image = Box12.Image;
                Box11.BackColor = Color.Yellow;
                Box12.Image = images[16];
                Box12.BackColor = Color.White;
            }

            if (Box8.Image == images[16])
            {
                Box8.Image = Box12.Image;
                Box8.BackColor = Color.Yellow;
                Box12.Image = images[16];
                Box12.BackColor = Color.White;
            }

            if (Box16.Image == images[16])
            {
                Box16.Image = Box12.Image;
                Box16.BackColor = Color.Yellow;
                Box12.Image = images[16];
                Box12.BackColor = Color.White;
            }
            CheckSolve();
        }

        private void Box13_Click(object sender, EventArgs e)
        {

        }

        private void Box14_Click(object sender, EventArgs e)
        {

        }

        private void Box15_Click_1(object sender, EventArgs e)
        {

        }

        private void Box16_Click(object sender, EventArgs e)
        {

        }

        public void Shuffle()
        {
            int i, j, Rn;
            int[] a = new int[16];
            Boolean flag = false;
            i = 1;

            do
            {
                Random rand = new Random();
                Rn = Convert.ToInt32((rand.Next(0, 15)) + 1);
                for (j = 1; j <= i; j++)
                {
                    if (a[j] == Rn)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    flag = false;
                }

                else
                {
                    a[i] = Rn;
                    i = i + 1;
                }




            } while (i <= 11);

            Box1.Image = (images[a[1]]);
            Box2.Image = (images[a[2]]);
            Box3.Image = (images[a[3]]);
            Box4.Image = (images[a[4]]);
            Box5.Image = (images[a[5]]);
            Box6.Image = (images[a[6]]);
            Box7.Image = (images[a[7]]);
            Box8.Image = (images[a[8]]);
            Box9.Image = (images[a[9]]);
            Box10.Image = (images[a[10]]);
            Box11.Image = (images[a[11]]);
            Box12.Image = (images[a[12]]);
            Box13.Image = (images[a[13]]);
            Box14.Image = (images[a[14]]);
            Box15.Image = (images[a[15]]);
            Box16.Image = (images[16]);


            //int num = 0;



        }


        private void button17_Click_1(object sender, EventArgs e)
        {
            Shuffle();
        }
        //exit button closes program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



       
    }
    
}
