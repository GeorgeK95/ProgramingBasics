using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class ConverterForm : Form
    {
        public ConverterForm()
        {
            InitializeComponent();
        }

        private void BGNValue_ValueChanged(object sender, EventArgs e)
        {
            myFunc();
        }

        private void BGNValue_KeyUp(object sender, KeyEventArgs e)
        {
            myFunc();
        }
        private void myFunc()
        {
            decimal boxValue1 = 0;

            if (this.comboBox1.SelectedItem.Equals("EUR"))
            {
                boxValue1 = BGNValue.Value * 1.96m;
            }
            else if (this.comboBox1.SelectedItem.Equals("USD"))
            {
                boxValue1 = BGNValue.Value * 1.74m;
            }
            else if (this.comboBox1.SelectedItem.Equals("GBP"))
            {
                boxValue1 = BGNValue.Value * 2.30m;
            }

            this.ResultLabel.Text = BGNValue.Value.ToString() + " BGN" + "=" + boxValue1.ToString() + " " + this.comboBox1.SelectedItem;

        }

        private void ConverterForm_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedItem = "EUR";
            myFunc();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            myFunc();
        }
    }
}
