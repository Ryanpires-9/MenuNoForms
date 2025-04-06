namespace WindowsFormsApp1
{
    partial class CalculadoraSuper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadoraSuper));
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnOFF = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.lblVisor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPotenciar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnApa = new System.Windows.Forms.Button();
            this.btnMaisoMenos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPorcentagem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.SteelBlue;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnIgual.Location = new System.Drawing.Point(429, 620);
            this.btnIgual.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(109, 75);
            this.btnIgual.TabIndex = 5;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnVirgula.Location = new System.Drawing.Point(272, 620);
            this.btnVirgula.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(109, 75);
            this.btnVirgula.TabIndex = 16;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.f_Numeros);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnLimpar.Location = new System.Drawing.Point(272, 214);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(109, 75);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "CE";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnOFF
            // 
            this.btnOFF.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnOFF.Location = new System.Drawing.Point(156, 214);
            this.btnOFF.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(109, 75);
            this.btnOFF.TabIndex = 18;
            this.btnOFF.Text = "OFF";
            this.btnOFF.UseVisualStyleBackColor = false;
            this.btnOFF.Click += new System.EventHandler(this.btnOFF_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn9.Location = new System.Drawing.Point(272, 376);
            this.btn9.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(109, 75);
            this.btn9.TabIndex = 28;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.f_Numeros);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn8.Location = new System.Drawing.Point(156, 376);
            this.btn8.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(109, 75);
            this.btn8.TabIndex = 27;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.f_Numeros);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn7.Location = new System.Drawing.Point(40, 376);
            this.btn7.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(109, 75);
            this.btn7.TabIndex = 26;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.f_Numeros);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn6.Location = new System.Drawing.Point(272, 458);
            this.btn6.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(109, 75);
            this.btn6.TabIndex = 25;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.f_Numeros);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn5.Location = new System.Drawing.Point(156, 458);
            this.btn5.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(109, 75);
            this.btn5.TabIndex = 24;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.f_Numeros);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn4.Location = new System.Drawing.Point(40, 458);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(109, 75);
            this.btn4.TabIndex = 23;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.f_Numeros);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn1.Location = new System.Drawing.Point(40, 538);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(109, 75);
            this.btn1.TabIndex = 22;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.f_Numeros);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn2.Location = new System.Drawing.Point(156, 538);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(109, 75);
            this.btn2.TabIndex = 21;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.f_Numeros);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn3.Location = new System.Drawing.Point(272, 538);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(109, 75);
            this.btn3.TabIndex = 20;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.f_Numeros);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn0.Location = new System.Drawing.Point(156, 620);
            this.btn0.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(109, 75);
            this.btn0.TabIndex = 29;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.f_Numeros);
            // 
            // lblVisor
            // 
            this.lblVisor.BackColor = System.Drawing.SystemColors.Control;
            this.lblVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.lblVisor.Location = new System.Drawing.Point(8, 18);
            this.lblVisor.Name = "lblVisor";
            this.lblVisor.Size = new System.Drawing.Size(480, 101);
            this.lblVisor.TabIndex = 30;
            this.lblVisor.Text = "0";
            this.lblVisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Controls.Add(this.lblVisor);
            this.groupBox1.Location = new System.Drawing.Point(40, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(496, 128);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // btnPotenciar
            // 
            this.btnPotenciar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPotenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPotenciar.Location = new System.Drawing.Point(156, 295);
            this.btnPotenciar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnPotenciar.Name = "btnPotenciar";
            this.btnPotenciar.Size = new System.Drawing.Size(109, 75);
            this.btnPotenciar.TabIndex = 36;
            this.btnPotenciar.Text = "x^";
            this.btnPotenciar.UseVisualStyleBackColor = false;
            this.btnPotenciar.Click += new System.EventHandler(this.f_Operacao);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnDividir.Location = new System.Drawing.Point(428, 538);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(109, 75);
            this.btnDividir.TabIndex = 35;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.f_Operacao);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnMultiplicar.Location = new System.Drawing.Point(428, 295);
            this.btnMultiplicar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(109, 75);
            this.btnMultiplicar.TabIndex = 34;
            this.btnMultiplicar.Text = "x";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.f_Operacao);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSubtrair.Location = new System.Drawing.Point(428, 376);
            this.btnSubtrair.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(109, 75);
            this.btnSubtrair.TabIndex = 33;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.f_Operacao);
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSomar.Location = new System.Drawing.Point(428, 458);
            this.btnSomar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(109, 75);
            this.btnSomar.TabIndex = 32;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.f_Operacao);
            // 
            // btnApa
            // 
            this.btnApa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnApa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnApa.Image = ((System.Drawing.Image)(resources.GetObject("btnApa.Image")));
            this.btnApa.Location = new System.Drawing.Point(428, 214);
            this.btnApa.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnApa.Name = "btnApa";
            this.btnApa.Size = new System.Drawing.Size(109, 75);
            this.btnApa.TabIndex = 37;
            this.btnApa.UseVisualStyleBackColor = false;
            this.btnApa.Click += new System.EventHandler(this.btnApa_Click);
            // 
            // btnMaisoMenos
            // 
            this.btnMaisoMenos.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMaisoMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnMaisoMenos.Location = new System.Drawing.Point(40, 620);
            this.btnMaisoMenos.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMaisoMenos.Name = "btnMaisoMenos";
            this.btnMaisoMenos.Size = new System.Drawing.Size(109, 75);
            this.btnMaisoMenos.TabIndex = 38;
            this.btnMaisoMenos.Text = "+/-";
            this.btnMaisoMenos.UseVisualStyleBackColor = false;
            this.btnMaisoMenos.Click += new System.EventHandler(this.btnMaisoMenos_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.button1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(273, 295);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 75);
            this.button1.TabIndex = 39;
            this.button1.Text = "√";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.f_Operacao);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.Location = new System.Drawing.Point(40, 295);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 75);
            this.button2.TabIndex = 40;
            this.button2.Text = "1/x";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.f_Operacao);
            // 
            // btnPorcentagem
            // 
            this.btnPorcentagem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPorcentagem.Location = new System.Drawing.Point(40, 214);
            this.btnPorcentagem.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnPorcentagem.Name = "btnPorcentagem";
            this.btnPorcentagem.Size = new System.Drawing.Size(109, 75);
            this.btnPorcentagem.TabIndex = 41;
            this.btnPorcentagem.Text = "%";
            this.btnPorcentagem.UseVisualStyleBackColor = false;
            this.btnPorcentagem.Click += new System.EventHandler(this.f_Operacao);
            // 
            // CalculadoraSuper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(579, 745);
            this.Controls.Add(this.btnPorcentagem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMaisoMenos);
            this.Controls.Add(this.btnApa);
            this.Controls.Add(this.btnPotenciar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnOFF);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnIgual);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "CalculadoraSuper";
            this.Text = "Calculadora";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalcModerna_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnOFF;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Label lblVisor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPotenciar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnApa;
        private System.Windows.Forms.Button btnMaisoMenos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPorcentagem;
    }
}

