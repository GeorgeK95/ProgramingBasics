using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConvertThat();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ConvertThat();
        }

        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertThat();
        }
        private void ConvertThat()
        {
            var BGNValue = this.numericUpDown1.Value;
            var EURValue = BGNValue * 1.95583m;
            decimal zakragleno = Math.Round(EURValue, 2);
            this.LabelResult.Text = zakragleno.ToString();
        }
    }
}
