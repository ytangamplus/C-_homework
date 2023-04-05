using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._4homework_while_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = string.Empty;
            int num = 1;
            int sum = 1;
            while (true)
            {   
                
                this.txtResult.Text += (sum-num).ToString() + "+" + num.ToString()+ "=" + sum.ToString() + Environment.NewLine;
                num++;
                sum += num;
                if (sum > 500)
                {
                    this.txtAlert.Text = "もう一回足すと500に超えてしまう!" + Environment.NewLine + "合計:" + (sum-num).ToString();
                    break;
                }



            }

        }
    }
}
