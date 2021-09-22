using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int sayi;
        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            dateTimePicker2.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            dateTimePicker2.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = System.DateTime.Now;
            dateTimePicker2.MinDate = System.DateTime.Now;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            label9.Text = sayi.ToString();
            label10.Text = sayi.ToString();
            label11.Text = sayi.ToString();

        }

        private  void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(label9.Text);
            if (sayi > 0)
            {
                sayi--;

                label9.Text = sayi.ToString();
            }
            else
            {
                sayi = 0;

                label9.Text = sayi.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayi++;
            label9.Text = sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(label10.Text);
            if (sayi > 0)
            {
                sayi--;

                label10.Text = sayi.ToString();
            }
            else
            {
                sayi = 0;

                label10.Text = sayi.ToString();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            sayi++;
            label10.Text = sayi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(label11.Text);
            if (sayi > 0)
            {
                sayi--;

                label11.Text = sayi.ToString();
            }
            else
            {
                sayi = 0;

                label11.Text = sayi.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sayi++;
            label11.Text = sayi.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The ticket has been booked, Thank you for choosing.");
        }
    }
}
