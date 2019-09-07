using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Calculadora : Form
    {
        double valor1, valor2, resultado;
        string operacao;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + 9;
        }

        private void btnVigula_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + ".";
        }

        private void btnApagarTudo_Click(object sender, EventArgs e)
        {
            visor.Clear();
        }

        private void btnApagar1_Click(object sender, EventArgs e)
        {
            if (visor.Text.Length == 1)
            {
                visor.Text = "";
            }
            else
            {
                visor.Text = visor.Text.Substring(0, visor.Text.Length - 1);
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            operacao = "-";
            valor1 = double.Parse(visor.Text);
            visor.Clear();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operacao = "*";
            valor1 = double.Parse(visor.Text);
            visor.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operacao = "/";
            valor1 = double.Parse(visor.Text);
            visor.Clear();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            operacao = "+";
            valor1 = double.Parse(visor.Text);
            visor.Clear();
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(visor.Text);
            switch (operacao)
            {
                case "+":
                    resultado = valor1 + valor2;
                    visor.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    visor.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    visor.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = valor1 / valor2;
                    visor.Text = resultado.ToString();
                    break;
            }

        }

    }
}
