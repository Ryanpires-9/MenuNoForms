namespace WindowsFormsApp1
{
    partial class CalculadoraRadioButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadoraRadioButton));
            this.btnCalcula = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnFecha = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.textNumero1 = new System.Windows.Forms.TextBox();
            this.textNumero2 = new System.Windows.Forms.TextBox();
            this.radioSoma = new System.Windows.Forms.RadioButton();
            this.radioSubtracao = new System.Windows.Forms.RadioButton();
            this.radioMultiplicacao = new System.Windows.Forms.RadioButton();
            this.radioPotenciacao = new System.Windows.Forms.RadioButton();
            this.radioDivisao = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBoxOperacao = new System.Windows.Forms.GroupBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpBoxOperacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(35, 328);
            this.btnCalcula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 35);
            this.btnCalcula.TabIndex = 5;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(280, 328);
            this.btnLimpa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(75, 35);
            this.btnLimpa.TabIndex = 6;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(363, 328);
            this.btnFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(75, 35);
            this.btnFecha.TabIndex = 7;
            this.btnFecha.Text = "Fechar";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblResultado.Location = new System.Drawing.Point(6, 11);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(25, 29);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "?";
            // 
            // textNumero1
            // 
            this.textNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textNumero1.Location = new System.Drawing.Point(280, 105);
            this.textNumero1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNumero1.Name = "textNumero1";
            this.textNumero1.Size = new System.Drawing.Size(100, 35);
            this.textNumero1.TabIndex = 9;
            // 
            // textNumero2
            // 
            this.textNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textNumero2.Location = new System.Drawing.Point(280, 149);
            this.textNumero2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNumero2.Name = "textNumero2";
            this.textNumero2.Size = new System.Drawing.Size(100, 35);
            this.textNumero2.TabIndex = 10;
            // 
            // radioSoma
            // 
            this.radioSoma.AutoSize = true;
            this.radioSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioSoma.Location = new System.Drawing.Point(39, 71);
            this.radioSoma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioSoma.Name = "radioSoma";
            this.radioSoma.Size = new System.Drawing.Size(89, 29);
            this.radioSoma.TabIndex = 12;
            this.radioSoma.TabStop = true;
            this.radioSoma.Text = "Soma";
            this.radioSoma.UseVisualStyleBackColor = true;
            // 
            // radioSubtracao
            // 
            this.radioSubtracao.AutoSize = true;
            this.radioSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioSubtracao.Location = new System.Drawing.Point(39, 105);
            this.radioSubtracao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioSubtracao.Name = "radioSubtracao";
            this.radioSubtracao.Size = new System.Drawing.Size(127, 29);
            this.radioSubtracao.TabIndex = 13;
            this.radioSubtracao.TabStop = true;
            this.radioSubtracao.Text = "Subtração";
            this.radioSubtracao.UseVisualStyleBackColor = true;
            // 
            // radioMultiplicacao
            // 
            this.radioMultiplicacao.AutoSize = true;
            this.radioMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioMultiplicacao.Location = new System.Drawing.Point(39, 140);
            this.radioMultiplicacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioMultiplicacao.Name = "radioMultiplicacao";
            this.radioMultiplicacao.Size = new System.Drawing.Size(150, 29);
            this.radioMultiplicacao.TabIndex = 14;
            this.radioMultiplicacao.TabStop = true;
            this.radioMultiplicacao.Text = "Multiplicação";
            this.radioMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // radioPotenciacao
            // 
            this.radioPotenciacao.AutoSize = true;
            this.radioPotenciacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioPotenciacao.Location = new System.Drawing.Point(39, 209);
            this.radioPotenciacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioPotenciacao.Name = "radioPotenciacao";
            this.radioPotenciacao.Size = new System.Drawing.Size(145, 29);
            this.radioPotenciacao.TabIndex = 15;
            this.radioPotenciacao.TabStop = true;
            this.radioPotenciacao.Text = "Potenciação";
            this.radioPotenciacao.UseVisualStyleBackColor = true;
            // 
            // radioDivisao
            // 
            this.radioDivisao.AutoSize = true;
            this.radioDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioDivisao.Location = new System.Drawing.Point(39, 175);
            this.radioDivisao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioDivisao.Name = "radioDivisao";
            this.radioDivisao.Size = new System.Drawing.Size(101, 29);
            this.radioDivisao.TabIndex = 16;
            this.radioDivisao.TabStop = true;
            this.radioDivisao.Text = "Divisão";
            this.radioDivisao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResultado);
            this.groupBox1.Location = new System.Drawing.Point(280, 198);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(102, 45);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // grpBoxOperacao
            // 
            this.grpBoxOperacao.Controls.Add(this.lblOperacao);
            this.grpBoxOperacao.Location = new System.Drawing.Point(229, 105);
            this.grpBoxOperacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxOperacao.Name = "grpBoxOperacao";
            this.grpBoxOperacao.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxOperacao.Size = new System.Drawing.Size(44, 65);
            this.grpBoxOperacao.TabIndex = 19;
            this.grpBoxOperacao.TabStop = false;
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOperacao.Location = new System.Drawing.Point(8, 23);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(25, 29);
            this.lblOperacao.TabIndex = 7;
            this.lblOperacao.Text = "?";
            // 
            // CalculadoraRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(451, 378);
            this.Controls.Add(this.grpBoxOperacao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioDivisao);
            this.Controls.Add(this.radioPotenciacao);
            this.Controls.Add(this.radioMultiplicacao);
            this.Controls.Add(this.radioSubtracao);
            this.Controls.Add(this.radioSoma);
            this.Controls.Add(this.textNumero2);
            this.Controls.Add(this.textNumero1);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnCalcula);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CalculadoraRadioButton";
            this.Text = "CalculadoraRadioButton";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxOperacao.ResumeLayout(false);
            this.grpBoxOperacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox textNumero1;
        private System.Windows.Forms.TextBox textNumero2;
        private System.Windows.Forms.RadioButton radioSoma;
        private System.Windows.Forms.RadioButton radioSubtracao;
        private System.Windows.Forms.RadioButton radioMultiplicacao;
        private System.Windows.Forms.RadioButton radioPotenciacao;
        private System.Windows.Forms.RadioButton radioDivisao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpBoxOperacao;
        private System.Windows.Forms.Label lblOperacao;
    }
}