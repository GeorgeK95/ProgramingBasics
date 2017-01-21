using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void catchMeButton_MouseEnter(object sender, EventArgs e)
        {
            Random newRand = new Random();
            var maxWidth = this.ClientSize.Width - catchMeButton.ClientSize.Width;
            var maxHeight = this.ClientSize.Height - catchMeButton.ClientSize.Height;
            this.catchMeButton.Location = new Point(newRand.Next(maxWidth), newRand.Next(maxHeight));
        }

        private void catchMeButton_MouseClick_1(object sender, MouseEventArgs e)
        {
            MessageBox.Show("I caught Maria ! :*");
        }
    }
}
