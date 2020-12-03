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

        Model model;
        public Form1()
        {
            InitializeComponent();
            model = new Model();
            model.observers += new System.EventHandler(this.UpdateFromModel);
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //numericUpDown2.Value = numericUpDown1.Value + 1;
            //progressBar1.Value = Convert.ToInt32(numericUpDown2.Value);
            //trackBar1.Value = Convert.ToInt32(numericUpDown2.Value);
            //lblProgress.Text = numericUpDown2.Value + "/100";
            //textBox1.Text = (numericUpDown1.Value).ToString();
            //textBox2.Text = (numericUpDown2.Value).ToString();

            model.setValue(Convert.ToInt32(numericUpDown1.Value));
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            //numericUpDown1.Value = numericUpDown2.Value - 1;

            model.setValue2(Convert.ToInt32(numericUpDown2.Value));
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //progressBar1.Value = trackBar1.Value;
            //numericUpDown2.Value = trackBar1.Value;
            //lblProgress.Text = trackBar1.Value.ToString() + "/100";
            //textBox1.Text = (numericUpDown1.Value).ToString();

            model.setValue2(Convert.ToInt32(trackBar1.Value));
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //    numericUpDown1.Value = Convert.ToInt32(textBox1.Text);

                model.setValue(Convert.ToInt32(textBox1.Text));
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //numericUpDown2.Value = Convert.ToInt32(textBox2.Text);

                model.setValue2(Convert.ToInt32(textBox2.Text));
            }
        }

        private void UpdateFromModel(object sender, EventArgs e)
        {
            numericUpDown1.Value = model.getValue();
            numericUpDown2.Value = model.getValue2();
            textBox1.Text = model.getValue().ToString();
            textBox2.Text = model.getValue2().ToString();
            progressBar1.Value = model.getValue2();
            trackBar1.Value = model.getValue2();
            lblProgress.Text = model.getValue2().ToString() + "/100";
        }
    }

    public class Model
    {
        private int value;
        private int value2;
        public System.EventHandler observers;
        public void setValue(int value)
        {
            this.value = value;
            value2 = value + 1;
            observers.Invoke(this, null);
        }

        public void setValue2(int value2)
        {
            this.value2 = value2;
            value = value2 - 1;
            observers.Invoke(this, null);
        }

        public int getValue()
        {
            return value;
        }
        public int getValue2()
        {
            return value2;
        }
    }

}