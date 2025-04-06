namespace WindowsFormsApp1.Minhas_classes
{
    partial class CalculadoraOO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadoraOO));
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.lblIgual = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cmbOperacao = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtN1.Location = new System.Drawing.Point(50, 165);
            this.txtN1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(148, 38);
            this.txtN1.TabIndex = 0;
            // 
            // txtN2
            // 
            this.txtN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtN2.Location = new System.Drawing.Point(404, 165);
            this.txtN2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(148, 38);
            this.txtN2.TabIndex = 2;
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblIgual.Location = new System.Drawing.Point(562, 169);
            this.lblIgual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(28, 29);
            this.lblIgual.TabIndex = 4;
            this.lblIgual.Text = "=";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResultado);
            this.groupBox1.Location = new System.Drawing.Point(621, 151);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(230, 78);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblResultado.Location = new System.Drawing.Point(9, 25);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(27, 29);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "?";
            // 
            // cmbOperacao
            // 
            this.cmbOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbOperacao.FormattingEnabled = true;
            this.cmbOperacao.Items.AddRange(new object[] {
            "Somar",
            "Subtrair",
            "Multiplicar",
            "Dividir",
            "Potenciar"});
            this.cmbOperacao.Location = new System.Drawing.Point(222, 162);
            this.cmbOperacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbOperacao.Name = "cmbOperacao";
            this.cmbOperacao.Size = new System.Drawing.Size(157, 37);
            this.cmbOperacao.TabIndex = 6;
            this.cmbOperacao.SelectedIndexChanged += new System.EventHandler(this.cmbOperacao_SelectedIndexChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnLimpar.Location = new System.Drawing.Point(160, 289);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 40);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnFechar.Location = new System.Drawing.Point(51, 289);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(104, 40);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // CalculadoraOO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(927, 378);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.cmbOperacao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CalculadoraOO";
            this.Text = "CalculadoraOO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ComboBox cmbOperacao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
    }
}