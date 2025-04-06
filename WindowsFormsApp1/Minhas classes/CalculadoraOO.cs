using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Minhas_classes
{
    public partial class CalculadoraOO : Form
    {
        public CalculadoraOO()
        {
            InitializeComponent();
        }

        private void cmbOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsCalculadoraOO objCalc = new clsCalculadoraOO();
            switch (cmbOperacao.Text)
            {
                case "Somar":
                    try
                    {
                        objCalc.Num1 = decimal.Parse(txtN1.Text);
                        objCalc.Num2 = decimal.Parse(txtN2.Text);
                        objCalc.Somar();
                        lblResultado.Text = objCalc.Resultado.ToString();
                    }

                    catch (FormatException)
                    {
                        MessageBox.Show("Primeiro digite dois números!", "Janela Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Subtrair":
                    try
                    {
                        objCalc.Num1 = decimal.Parse(txtN1.Text);
                        objCalc.Num2 = decimal.Parse(txtN2.Text);
                        objCalc.Subtrair();
                        lblResultado.Text = objCalc.Resultado.ToString();
                    }

                    catch (FormatException)
                    {
                        MessageBox.Show("Primeiro digite dois números!", "Janela Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Multiplicar":
                    try
                    {
                        objCalc.Num1 = decimal.Parse(txtN1.Text);
                        objCalc.Num2 = decimal.Parse(txtN2.Text);
                        objCalc.Multiplicar();
                        lblResultado.Text = objCalc.Resultado.ToString();
                    }

                    catch (FormatException)
                    {
                        MessageBox.Show("Primeiro digite dois números!", "Janela Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Dividir":
                    try
                    {
                        objCalc.Num1 = decimal.Parse(txtN1.Text);
                        objCalc.Num2 = decimal.Parse(txtN2.Text);
                        objCalc.Dividir();
                        lblResultado.Text = objCalc.Resultado.ToString();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Primeiro digite dois números!", "Janela Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (DivideByZeroException)
                    {
                        MessageBox.Show("Não é possível dividir números por 0!", "Janela Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Potenciar":
                    try
                    {
                        objCalc.Num1 = decimal.Parse(txtN1.Text);
                        objCalc.Num2 = decimal.Parse(txtN2.Text);
                        objCalc.Potenciar();
                        lblResultado.Text = objCalc.Resultado.ToString();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Primeiro digite dois números!", "Janela Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN1.Focus();

            txtN2.Clear();
            txtN2.Focus();

            lblResultado.Text = "?";
        }
    }
}
