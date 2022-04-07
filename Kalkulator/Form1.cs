using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string num1 = "0";
        string num2 = "0";
        string oprator = "";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int text_len = textBox1.Text.Length;
            if (text_len>0)
            {
                
                textBox1.Text = textBox1.Text.Substring(0, (text_len - 1));
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "00";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            num1 = "0";
            num2 = "0";
            oprator = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (num1=="0")
            {
                oprator = "+";
                num1 = textBox1.Text;

                textBox2.Text = num1 +" "+oprator;
                textBox1.Text = "";
            }
            else
            {
                oprator = "+";
                textBox2.Text = num1 + " " + oprator;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num2 = textBox1.Text;
            }

            if(num1 != "0" && num2 != "0" && oprator != "")
            {
                switch (oprator)
                {
                    case "+":
                        int jumlah = Convert.ToInt32(num1) + Convert.ToInt32(num2);
                        num1 = Convert.ToString(jumlah);
                        textBox2.Text = num1;
                        oprator = "";
                        break;
                    case "-":
                        break;
                }
                textBox1.Text = "";
            }

            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Enter(object sender, EventArgs e)
        {

        }
    }
}
