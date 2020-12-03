using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabOOP_4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Value = numericUpDown1.Value + 1;
            progressBar1.Value = Convert.ToInt32(numericUpDown2.Value);
            trackBar1.Value = Convert.ToInt32(numericUpDown2.Value);
            lblProgress.Text = numericUpDown2.Value + "/100";
            textBox1.Text = (numericUpDown1.Value).ToString();
            textBox2.Text = (numericUpDown2.Value).ToString();
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = numericUpDown2.Value - 1;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            progressBar1.Value = trackBar1.Value;
            numericUpDown2.Value = trackBar1.Value;
            lblProgress.Text = trackBar1.Value.ToString() + "/100";
            textBox1.Text = (numericUpDown1.Value).ToString();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                numericUpDown1.Value = Convert.ToInt32(textBox1.Text);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                numericUpDown2.Value = Convert.ToInt32(textBox2.Text);
            }
        }
    }
}
//