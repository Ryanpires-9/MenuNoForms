using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Minhas_classes;

namespace WindowsFormsApp1
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void comBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<formCalculadora>().Count() > 0)
            {
                Application.OpenForms.OfType<formCalculadora>().First().Focus();
            }

            else
            {
                formCalculadora objCalculadoraBotoes = new formCalculadora();
                objCalculadoraBotoes.MdiParent = this;
                objCalculadoraBotoes.Show();
            }
        }

        private void comRadioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CalculadoraRadioButton>().Count() > 0)
            {
                Application.OpenForms.OfType<CalculadoraRadioButton>().First().Focus();
            }

            else
            {
                CalculadoraRadioButton objCalculadoraRadioButton = new CalculadoraRadioButton();
                objCalculadoraRadioButton.MdiParent = this;
                objCalculadoraRadioButton.Show();
            }
        }

        private void visorÚnicoSuperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CalculadoraSuper>().Count() > 0)
            {
                Application.OpenForms.OfType<CalculadoraSuper>().First().Focus();
            }

            else
            {
                CalculadoraSuper objCalculadoraSuper = new CalculadoraSuper();
                objCalculadoraSuper.MdiParent = this;
                objCalculadoraSuper.Show();
            }
        }

        private void calculadoraOOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CalculadoraOO>().Count() > 0)
            {
                Application.OpenForms.OfType<CalculadoraOO>().First().Focus();
            }

            else
            {
                CalculadoraOO objCalculadoraOO = new CalculadoraOO();
                objCalculadoraOO.MdiParent = this;
                objCalculadoraOO.Show();
            }
        }

        private void MDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Você quer sair do menu?", "Menu", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stlDataHora.Text = "Hora: " + DateTime.Now.ToString();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
