using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double acumula = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromName("ControlDark");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            display.Text += "1";
        }
        private void somar_Click(object sender, EventArgs e)
        {
            {

                if (operacao == "*" || operacao == "-" || operacao == "/")
                {
                    operacao = "+";
                }
                else
                {
                    acumula += double.Parse(display.Text);
                    display.Text = "";
                    operacao = "+";
                }
            }
        }

        private void Numero2_Click(object sender, EventArgs e)
        {
            display.Text += "2";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            if (operacao == "+")
            {
                acumula += double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "-")
            {
                acumula -= double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "*")
            {
                acumula *= double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "/")
            {
                if (double.Parse(display.Text) != 0)
                {
                    acumula /= double.Parse(display.Text);
                    display.Text = acumula.ToString();
                }
                else
                {
                    display.Text = "Dividindo por zero";
                }
            }
        }

        private void Numero3_Click(object sender, EventArgs e)
        {
            display.Text += "3";
        }

        private void Numero4_Click(object sender, EventArgs e)
        {
            display.Text += "4";
        }

        private void Numero5_Click(object sender, EventArgs e)
        {
            display.Text += "5";
        }

        private void Numero6_Click(object sender, EventArgs e)
        {
            display.Text += "6";
        }

        private void Numero7_Click(object sender, EventArgs e)
        {
            display.Text += "7";
        }

        private void Numero8_Click(object sender, EventArgs e)
        {
            display.Text += "8";
        }

        private void Numero9_Click(object sender, EventArgs e)
        {
            display.Text += "9";
        }

        private void diminuir_Click(object sender, EventArgs e)
        {
            {
                if (operacao == "*" || operacao == "+" || operacao == "/")
                {
                    operacao = "-";
                }
                else
                {
                    acumula = double.Parse(display.Text);
                    display.Text = "";
                    operacao = "-";
                }
            }
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            {
                if (operacao == "-" || operacao == "+" || operacao == "/")
                {
                    operacao = "*";
                }
                else
                {
                    acumula = double.Parse(display.Text);
                    display.Text = "";
                    operacao = "*";
                }
            }
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            {
                if (operacao == "*" || operacao == "+" || operacao == "-")
                {
                    operacao = "/";
                }
                else
                {
                    acumula = double.Parse(display.Text);
                    display.Text = "";
                    operacao = "/";
                }
            }
        }

        private void CE_Click(object sender, EventArgs e)
        {
            {
                display.Text = "";
                operacao = "";
            }

        }

        private void EXCLUIR_Click(object sender, EventArgs e)
        {

        }
    }
}