namespace WindowsFormsApp1
{
    partial class formCalculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCalculadora));
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnPotenciar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.textNumero1 = new System.Windows.Forms.TextBox();
            this.textNumero2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblBarra = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSomar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSomar.Location = new System.Drawing.Point(656, 14);
            this.btnSomar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(172, 66);
            this.btnSomar.TabIndex = 0;
            this.btnSomar.Text = "SOMA";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMultiplicar.Location = new System.Drawing.Point(656, 158);
            this.btnMultiplicar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(172, 66);
            this.btnMultiplicar.TabIndex = 1;
            this.btnMultiplicar.Text = "MULTIPLICAÇÃO";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSubtrair.Location = new System.Drawing.Point(656, 86);
            this.btnSubtrair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(172, 66);
            this.btnSubtrair.TabIndex = 2;
            this.btnSubtrair.Text = "SUBTRAÇÃO";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(656, 229);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(172, 66);
            this.btnDividir.TabIndex = 3;
            this.btnDividir.Text = "DIVISÃO";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnPotenciar
            // 
            this.btnPotenciar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPotenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPotenciar.Location = new System.Drawing.Point(656, 300);
            this.btnPotenciar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPotenciar.Name = "btnPotenciar";
            this.btnPotenciar.Size = new System.Drawing.Size(172, 66);
            this.btnPotenciar.TabIndex = 4;
            this.btnPotenciar.Text = "POTENCIAÇÃO";
            this.btnPotenciar.UseVisualStyleBackColor = false;
            this.btnPotenciar.Click += new System.EventHandler(this.btnPotenciar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(12, 381);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(104, 58);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(122, 381);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 58);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.lblOperacao.Location = new System.Drawing.Point(11, 23);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(34, 37);
            this.lblOperacao.TabIndex = 7;
            this.lblOperacao.Text = "?";
            // 
            // textNumero1
            // 
            this.textNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textNumero1.Location = new System.Drawing.Point(325, 84);
            this.textNumero1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNumero1.Name = "textNumero1";
            this.textNumero1.Size = new System.Drawing.Size(163, 55);
            this.textNumero1.TabIndex = 8;
            // 
            // textNumero2
            // 
            this.textNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textNumero2.Location = new System.Drawing.Point(325, 158);
            this.textNumero2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNumero2.Name = "textNumero2";
            this.textNumero2.Size = new System.Drawing.Size(163, 55);
            this.textNumero2.TabIndex = 9;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.lblResultado.Location = new System.Drawing.Point(6, 22);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(34, 37);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "?";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBarra
            // 
            this.lblBarra.AutoSize = true;
            this.lblBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.lblBarra.Location = new System.Drawing.Point(322, 229);
            this.lblBarra.Name = "lblBarra";
            this.lblBarra.Size = new System.Drawing.Size(169, 13);
            this.lblBarra.TabIndex = 11;
            this.lblBarra.Text = "___________________________";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblResultado);
            this.groupBox1.Location = new System.Drawing.Point(325, 248);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(163, 75);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblOperacao);
            this.groupBox2.Location = new System.Drawing.Point(264, 112);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(55, 76);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // formCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBarra);
            this.Controls.Add(this.textNumero2);
            this.Controls.Add(this.textNumero1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnPotenciar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSomar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formCalculadora";
            this.Text = "Calculadora";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnPotenciar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.TextBox textNumero1;
        private System.Windows.Forms.TextBox textNumero2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblBarra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

