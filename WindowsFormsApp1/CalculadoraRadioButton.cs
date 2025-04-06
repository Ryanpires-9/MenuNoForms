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
    public partial class CalculadoraRadioButton : Form
    {
        public CalculadoraRadioButton()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            decimal a = ' ', b = ' ';
            if (radioSoma.Checked)
            {
                radioSoma.Checked = true;
                decimal soma;

                try
                {
                    lblOperacao.Text = "+";
                    a = decimal.Parse(textNumero1.Text);
                    b = decimal.Parse(textNumero2.Text);
                    soma = a + b;
                    lblResultado.Text = soma.ToString();
                }

                catch (FormatException)
                {
                    lblOperacao.Text = "?";
                    MessageBox.Show("Informar apenas números!", "Janela Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (radioSubtracao.Checked)
            {
                radioSubtracao.Checked = true;
                decimal subtracao;
                try
                {
                    lblOperacao.Text = "-";
                    a = decimal.Parse(textNumero1.Text);
                    b = decimal.Parse(textNumero2.Text);
                    subtracao = a - b;
                    lblResultado.Text = subtracao.ToString();
                }

                catch (FormatException)
                {
                    lblOperacao.Text = "?";
                    MessageBox.Show("Informar apenas números!", "Janela Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (radioMultiplicacao.Checked)
            {
                radioMultiplicacao.Checked = true;
                decimal multiplicacao;

                try
                {
                    lblOperacao.Text = "x";
                    a = decimal.Parse(textNumero1.Text);
                    b = decimal.Parse(textNumero2.Text);
                    multiplicacao = a * b;
                    lblResultado.Text = multiplicacao.ToString();
                }

                catch (FormatException)
                {
                    lblOperacao.Text = "?";
                    MessageBox.Show("Informar apenas números!", "Janela Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        

            if (radioDivisao.Checked)
            {
                radioDivisao.Checked = true;
                decimal divisao;

                try
                {
                    lblOperacao.Text = "/";
                    a = decimal.Parse(textNumero1.Text);
                    b = decimal.Parse(textNumero2.Text);
                    divisao = a / b;
                    lblResultado.Text = divisao.ToString();
                }

                catch (FormatException)
                {
                    lblOperacao.Text = "?";
                    MessageBox.Show("Informar apenas números!", "Janela Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (DivideByZeroException)
                {
                    lblOperacao.Text = "?";
                    MessageBox.Show("Não é possível dividir números por 0!", "Janela Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (radioPotenciacao.Checked)
            {
                radioPotenciacao.Checked = true;
                double n1 = ' ', n2 = ' ';

                try
                {
                    lblOperacao.Text = "^";
                    n1 = double.Parse(textNumero1.Text);
                    n2 = double.Parse(textNumero2.Text);
                    double potenciacao = Math.Pow(n1, n2);
                    lblResultado.Text = potenciacao.ToString();
                }

                catch (FormatException)
                {
                    lblOperacao.Text = "?";
                    MessageBox.Show("Informar apenas números!", "Janela Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            textNumero1.Clear();
            textNumero1.Focus();

            textNumero2.Clear();
            textNumero2.Focus();

            lblResultado.Text = "?";
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
