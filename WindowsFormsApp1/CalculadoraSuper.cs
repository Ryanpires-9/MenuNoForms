using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CalculadoraSuper : Form
    {
        public CalculadoraSuper()
        {
            InitializeComponent();
        }

        decimal vNumAnt;
        string vOperacao;
        bool vLimpa = false;

        private void f_Operacao(object sender, EventArgs e)
        {
            vNumAnt = decimal.Parse(lblVisor.Text);
            vOperacao = ((Button)sender).Text;
            vLimpa = true;
        }
        private void f_Numeros(object sender, EventArgs e)
        {
            string digito = ((Button)sender).Text;

            if (lblVisor.Text == "0" || vLimpa)
            {
                lblVisor.Text = "";
                vLimpa = false;
            }

            lblVisor.Text = lblVisor.Text == "" && digito == "," ? "0" : lblVisor.Text;
            if ((digito == "," && !lblVisor.Text.Contains(",") || digito != ","))
                lblVisor.Text += ((Button)sender).Text;
            lblVisor.Focus();
        }
        private void CalcModerna_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            string tecla = e.KeyCode.ToString();
            Button botao = new Button();
            if ((e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) || (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9))
            {
                botao.Text = tecla.Substring(tecla.Length - 1, 1);
                f_Numeros(botao, e);
            }
            if (e.KeyCode == Keys.Back)
            {
                lblVisor.Text = lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);
                if (lblVisor.Text.Length == 0)
                {
                    lblVisor.Text = "0";
                }
            }
            if (e.KeyCode == Keys.Delete)
            {
                lblVisor.Text = "";
                if (lblVisor.Text.Length == 0)
                {
                    lblVisor.Text = "0";
                }
            }
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            decimal vNumAtual = decimal.Parse(lblVisor.Text);
            switch (vOperacao)
            {
                case "+":
                    lblVisor.Text = (vNumAnt + vNumAtual).ToString();
                    break;
                case "-":
                    lblVisor.Text = (vNumAnt - vNumAtual).ToString();
                    break;
                case "/":
                    if (vNumAnt == 0 || vNumAtual == 0)
                    {
                        lblVisor.Text = "Indefinido";
                    }
                    else
                    {
                        lblVisor.Text = (vNumAnt / vNumAtual).ToString();
                    }
                    break;
                case "x":
                    lblVisor.Text = (vNumAnt * vNumAtual).ToString();
                    break;
                case "%":
                    lblVisor.Text = Convert.ToSingle(vNumAnt / 100).ToString();
                    break;
                case "√":
                    double raiz = Convert.ToDouble(Math.Sqrt((double)vNumAtual));
                    lblVisor.Text = raiz.ToString();
                    break;
                case "x^":
                    double potenciacao = Math.Pow((double)vNumAnt, (double)vNumAtual);
                    lblVisor.Text = potenciacao.ToString();
                    break;
                case "1/x":
                    if (vNumAnt == 0)
                    {
                        lblVisor.Text = "Indefinido";
                    }
                    else
                    {
                        lblVisor.Text = Convert.ToSingle(1 / vNumAnt).ToString();
                    }
                    break;
            }
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblVisor.Text = "";
            if (lblVisor.Text.Length == 0)
            {
                lblVisor.Text = "0";
            }
        }

        private void btnApa_Click(object sender, EventArgs e)
        {
            lblVisor.Text = lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);
            if (lblVisor.Text.Length == 0)
            {
                lblVisor.Text = "0";
            }

        }

        private void btnMaisoMenos_Click(object sender, EventArgs e)
        {
            if (lblVisor.Text.Length == 1)
            {
                lblVisor.Text = "-";
            }
        }
    }
}
