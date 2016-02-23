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
            updown.Value = 1;
            updown.Maximum = 3;
            updown.Minimum = 1;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                result.Text = "0";

            }
            else if (radioButton3.Checked)
            {
                result.Text = "30";
            }
            else if (radioButton4.Checked)
            {
                result.Text = "60";
            }
            else if(radioButton2.Checked)
            {

                if (updown.Value == 1)
                {
                    result.Text = "4";
                }
                else if (updown.Value == 2)
                {
                    result.Text = "6";
                }
                else if (updown.Value == 3)
                {
                    result.Text = "12";
                }

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                updown.Visible = true;
            }
            else
            {
                updown.Visible = false;

            }
        }
    }
}
