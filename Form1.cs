using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string op;
        double num1;


        private void Btn_click(object sender, EventArgs e)
        {
            txtBox1.Text += ((Button)sender).Text;
        }


        private void op_Btn(object sender, EventArgs e)
        {
            op = ((Button)sender).Text;
            num1 = Convert.ToDouble(txtBox1.Text);
            txtBox1.Text = "";
        }

        private void btnSum_MouseClick(object sender, MouseEventArgs e)
        {
            double num2 = Convert.ToDouble(txtBox1.Text);

            switch (op)
            {
                case "+":
                    num1 = num1 + num2;
                    break;

                case "-":
                    num1 = num1 - num2;
                    break;

                case "÷":
                    num1 = num1 / num2;
                    break;

                case "×":
                    num1 = num1 * num2;
                    break;

            }
            txtBox1.Text = num1.ToString();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox1.Text = "";
        }
    }

}
