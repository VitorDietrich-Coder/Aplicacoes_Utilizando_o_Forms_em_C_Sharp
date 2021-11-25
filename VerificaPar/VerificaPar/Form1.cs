using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificaPar
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
            int Valor1 = int.Parse(textBox1.Text);
            
           
            if (Valor1 % 2 == 0)
            {
                MessageBox.Show("é par");
            }
            else {
                MessageBox.Show("antecessor é: " + Convert.ToString(Valor1 - 1));
                MessageBox.Show("é impar");
            }
           

        }
    }
}
