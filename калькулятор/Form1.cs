using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор
{
    public partial class MyCalculator : Form
    {
        double a, b;
        int count;
        bool znak = true;        
        public MyCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbBiBod.TextLength == 0 || tbBiBod.TextLength <= 8)
            {
                tbBiBod.Text = tbBiBod.Text + 3;
            }
            else if (tbBiBod.TextLength == 9)
            {
                tbBiBod.Text = tbBiBod.Text + "";
            }
            
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            if(tbBiBod.TextLength == 0 ||tbBiBod.TextLength <= 8)
            {
                tbBiBod.Text = tbBiBod.Text + 0;
            }
            else if(tbBiBod.TextLength == 9)
            {
                tbBiBod.Text = tbBiBod.Text + "";
            }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (tbBiBod.TextLength == 0 || tbBiBod.TextLength <= 8)
            {
                tbBiBod.Text = tbBiBod.Text + 1;
            }
            else if (tbBiBod.TextLength == 9)
            {
                tbBiBod.Text = tbBiBod.Text + "";
            }
            
            
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (tbBiBod.TextLength == 0 || tbBiBod.TextLength <= 8)
            {
                tbBiBod.Text = tbBiBod.Text + 2;
            }
            else if (tbBiBod.TextLength == 9)
            {
                tbBiBod.Text = tbBiBod.Text + "";
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (tbBiBod.TextLength == 0 || tbBiBod.TextLength <= 8)
            {
                tbBiBod.Text = tbBiBod.Text + 4;
            }
            else if (tbBiBod.TextLength == 9)
            {
                tbBiBod.Text = tbBiBod.Text + "";
            }
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (tbBiBod.TextLength == 0 || tbBiBod.TextLength <= 8)
            {
                tbBiBod.Text = tbBiBod.Text + 5;
            }
            else if (tbBiBod.TextLength == 9)
            {
                tbBiBod.Text = tbBiBod.Text + "";
            }
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (tbBiBod.TextLength == 0 || tbBiBod.TextLength <= 8)
            {
                tbBiBod.Text = tbBiBod.Text + 6;
            }
            else if (tbBiBod.TextLength == 9)
            {
                tbBiBod.Text = tbBiBod.Text + "";
            }
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (tbBiBod.TextLength == 0 || tbBiBod.TextLength <= 8)
            {
                tbBiBod.Text = tbBiBod.Text + 7;
            }
            else if (tbBiBod.TextLength == 9)
            {
                tbBiBod.Text = tbBiBod.Text + "";
            }
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (tbBiBod.TextLength == 0 || tbBiBod.TextLength <= 8)
            {
                tbBiBod.Text = tbBiBod.Text + 8;
            }
            else if (tbBiBod.TextLength == 9)
            {
                tbBiBod.Text = tbBiBod.Text + "";
            }
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (tbBiBod.TextLength == 0 || tbBiBod.TextLength <= 8)
            {
                tbBiBod.Text = tbBiBod.Text + 9;
            }
            else if (tbBiBod.TextLength == 9)
            {
                tbBiBod.Text = tbBiBod.Text + "";
            }
        }

        private void btplus_Click(object sender, EventArgs e)
        {
            try
            {
            a = double.Parse(tbBiBod.Text);
            tbBiBod.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
            }
            catch { }
        }

        private void tbBiBod_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btminus_Click(object sender, EventArgs e)
        {
            try
            {
            a = double.Parse(tbBiBod.Text);
            tbBiBod.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
            }
            catch { }
            
        }

        private void btumno_Click(object sender, EventArgs e)
        {
            try
            {
            a = double.Parse(tbBiBod.Text);
            tbBiBod.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
            }
            catch { }
        }

        private void btdel_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(tbBiBod.Text);
                tbBiBod.Clear();
                count = 4;
                label1.Text = a.ToString() + "/";
                znak = true;
            }
            catch { }
        }

        private void btRavno_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }        

        private void btSbros_Click(object sender, EventArgs e)
        {
            tbBiBod.Text = "";
            label1.Text = "";
        }

        private void btChang_Click(object sender, EventArgs e)
        {
            if(znak == true)
            {
                tbBiBod.Text = "-" + tbBiBod.Text;
                znak = false;
            }
            else if (znak == false)
            {
                tbBiBod.Text = tbBiBod.Text.Replace("-", "");
                znak = true;
            }
        }

        private void calculate()
        {            
            switch(count)
            {
                case 1:
                    b = a + double.Parse(tbBiBod.Text);                                                                                                                    
                    break;
                case 2:
                    b = a - double.Parse(tbBiBod.Text);                                                           
                    break;
                case 3:
                    b = a * double.Parse(tbBiBod.Text);                                                           
                    break;
                case 4:
                    b = a / double.Parse(tbBiBod.Text);
                    if(b == double.PositiveInfinity || b == double.NegativeInfinity)
                    {
                        tbBiBod.Text = "Not / 0";
                    }                                                          
                    else
                    {
                        tbBiBod.Text = b.ToString();
                    }
                    break;
                default:
                    break;
            }
            if (b > 999999999 || b < -999999999)
            {

                tbBiBod.Text = "EXCEEDED";

            }
            else
            {
                tbBiBod.Text = b.ToString();
            }
        }             
    }
}
