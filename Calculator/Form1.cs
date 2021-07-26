using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        double firstnum = 0;
        double secondnum;
        int secim;

        public Form1()
        {
            InitializeComponent();
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (ResultLabel.Text.Equals("0"))
            {
                ResultLabel.Text = "7";
            }
            else
            {
                ResultLabel.Text += "7";
            }
            
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            if (ResultLabel.Text.Equals("0"))
            {
                ResultLabel.Text = "8";
            }
            else
            {
                ResultLabel.Text += "8";
            }
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            if (ResultLabel.Text.Equals("0"))
            {
                ResultLabel.Text = "9";
            }
            else
            {
                ResultLabel.Text += "9";
            }
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            if (ResultLabel.Text.Equals("0"))
            {
                ResultLabel.Text = "4";
            }
            else
            {
                ResultLabel.Text += "4";
            }
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (ResultLabel.Text.Equals("0"))
            {
                ResultLabel.Text = "5";
            }
            else
            {
                ResultLabel.Text += "5";
            }
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            if (ResultLabel.Text.Equals("0"))
            {
                ResultLabel.Text = "6";
            }
            else
            {
                ResultLabel.Text += "6";
            }
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            if (ResultLabel.Text.Equals("0"))
            {
                ResultLabel.Text = "1";
            }
            else
            {
                ResultLabel.Text += "1";
            }
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (ResultLabel.Text.Equals("0"))
            {
                ResultLabel.Text = "2";
            }
            else
            {
                ResultLabel.Text += "2";
            }
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            if (ResultLabel.Text.Equals("0"))
            {
                ResultLabel.Text = "3";
            }
            else
            {
                ResultLabel.Text += "3";
            }
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            ResultLabel.Text += "0";
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            ResultLabel.Text += ".";
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(ResultLabel.Text);
            ResultLabel.Text = "";
            secim = 1;
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(ResultLabel.Text);
            ResultLabel.Text = "";
            secim = 2;
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(ResultLabel.Text);
            ResultLabel.Text = "";
            secim = 3;
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(ResultLabel.Text);
            ResultLabel.Text = "";
            secim = 4;
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            secondnum = Convert.ToDouble(ResultLabel.Text);
            if (secim == 1)
            {
                ResultLabel.Text =Convert.ToString(firstnum + secondnum);
            }
            else if (secim == 2)
            {
                ResultLabel.Text = Convert.ToString(firstnum - secondnum);
            }
            else if (secim == 3)
            {
                ResultLabel.Text = Convert.ToString(firstnum * secondnum);
            }
            else if (secim == 4)
            {
                ResultLabel.Text = Convert.ToString(firstnum / secondnum);
            }
            else
            {
                ResultLabel.Text = ResultLabel.Text;
            }

        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            ResultLabel.Text = "0";
            firstnum = 0;
            secondnum = 0;
            secim = 0;
        }
    }
}
