using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_juros_compostos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ValorInicio = int.Parse(textBox1.Text);
            double TaxaJuro = int.Parse(textBox3.Text);
            double Periodo = int.Parse(textBox4.Text);
            double montante;
            double juros;
            if ((textBox1.Text == string.Empty) && (textBox2.Text == string.Empty) && (textBox3.Text == string.Empty) && (textBox4.Text == string.Empty))
            {
                MessageBox.Show("campo em branco, favor preencha todos os campos");
            }
            else {
             juros = TaxaJuro / 100;
                montante = ValorInicio * Math.Pow((1 + juros), Periodo);
                juros = montante - ValorInicio;
                MessageBox.Show("Seu valor total de juros é: " + juros);
                MessageBox.Show("Seu montante será de: " + montante);
            }
            
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
