using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {
        string operation = "";
        double result_Value = 0;
        bool Is_Operation_Performed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {

            if ((tb_Result.Text == "0") || (Is_Operation_Performed))
            {
                tb_Result.Clear();
            }
            Button btn = (Button)sender;
            if (btn.Text == ".")
            {
                if (!tb_Result.Text.Contains("."))
                {
                    tb_Result.Text = tb_Result.Text + btn.Text;
                }

            }
            else
            {
                tb_Result.Text = tb_Result.Text + btn.Text;
            }

            Is_Operation_Performed = false;

        }

        private void Operation_Performed(object sender, EventArgs e)
        {
            if (result_Value != 0)
            {
                buttonEQ.PerformClick();
                Button btn = (Button)sender;
                operation = btn.Text;
                result_Value = double.Parse(tb_Result.Text);
                lb_Result.Text = result_Value + " " + operation;
                Is_Operation_Performed = true;

            }
            else
            {
                Button btn = (Button)sender;
                operation = btn.Text;
                result_Value = double.Parse(tb_Result.Text);
                lb_Result.Text = result_Value + " " + operation;
                Is_Operation_Performed = true;
                

            }



        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            tb_Result.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            tb_Result.Text = "0";
            lb_Result.Text = "";

        }

        private void buttonEQ_Click(object sender, EventArgs e)
        {
            lb_Result.Text = " ";
            switch (operation)
            {
                case "+":
                    tb_Result.Text = (result_Value + double.Parse(tb_Result.Text)).ToString();
                    break;
                case "-":
                    tb_Result.Text = (result_Value - double.Parse(tb_Result.Text)).ToString();
                    break;
                case "*":
                    tb_Result.Text = (result_Value * double.Parse(tb_Result.Text)).ToString();
                    break;
                case "/":
                    tb_Result.Text = (result_Value / double.Parse(tb_Result.Text)).ToString();
                    break;

                default:
                    break;
            }

          
        }


    }
}
