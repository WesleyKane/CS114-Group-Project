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
    public partial class Pacman : Form
    {
        public Pacman()
        {
            InitializeComponent();
        }
		int counter = 0;
		private void PushMe_Click(object sender, EventArgs e)
		{
			counter++;
			title.Text = $"You have clicked {counter} times";
		}
	}
}
