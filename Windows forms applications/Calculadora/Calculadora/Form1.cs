using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = int.Parse(txtValor1.Text);
            valor2 = int.Parse(txtValor2.Text);
            resultado = valor1 + valor2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = int.Parse(txtValor1.Text);
            valor2 = int.Parse(txtValor2.Text);
            resultado = valor1 - valor2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = int.Parse(txtValor1.Text);
            valor2 = int.Parse(txtValor2.Text);
            resultado = valor1 * valor2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = double.Parse(txtValor1.Text);
            valor2 = double.Parse(txtValor2.Text);
            resultado = valor1 / valor2;
            txtResultado.Text = resultado.ToString();
        }
    }
}
