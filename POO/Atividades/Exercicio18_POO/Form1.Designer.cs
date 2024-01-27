
namespace Exercicio18_POO
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ContaCorrente = new System.Windows.Forms.TabPage();
            this.btnContaCorrente = new System.Windows.Forms.Button();
            this.numLimiteCredito = new System.Windows.Forms.NumericUpDown();
            this.numSaldoCorrente = new System.Windows.Forms.NumericUpDown();
            this.txtNumContaCor = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeCorrente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnContaPoupança = new System.Windows.Forms.Button();
            this.numDiaAniversario = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContaAtrelada = new System.Windows.Forms.MaskedTextBox();
            this.txtSaldo = new System.Windows.Forms.NumericUpDown();
            this.txtNConta = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtNconta2 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtListar = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.ContaCorrente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLimiteCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSaldoCorrente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiaAniversario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldo)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ContaCorrente);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(43, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(848, 244);
            this.tabControl1.TabIndex = 0;
            // 
            // ContaCorrente
            // 
            this.ContaCorrente.Controls.Add(this.btnContaCorrente);
            this.ContaCorrente.Controls.Add(this.numLimiteCredito);
            this.ContaCorrente.Controls.Add(this.numSaldoCorrente);
            this.ContaCorrente.Controls.Add(this.txtNumContaCor);
            this.ContaCorrente.Controls.Add(this.txtNomeCorrente);
            this.ContaCorrente.Controls.Add(this.label4);
            this.ContaCorrente.Controls.Add(this.label3);
            this.ContaCorrente.Controls.Add(this.label2);
            this.ContaCorrente.Controls.Add(this.label1);
            this.ContaCorrente.Controls.Add(this.groupBox1);
            this.ContaCorrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContaCorrente.Location = new System.Drawing.Point(4, 29);
            this.ContaCorrente.Name = "ContaCorrente";
            this.ContaCorrente.Padding = new System.Windows.Forms.Padding(3);
            this.ContaCorrente.Size = new System.Drawing.Size(840, 211);
            this.ContaCorrente.TabIndex = 0;
            this.ContaCorrente.Text = "Conta Corrente";
            this.ContaCorrente.UseVisualStyleBackColor = true;
            // 
            // btnContaCorrente
            // 
            this.btnContaCorrente.Location = new System.Drawing.Point(601, 165);
            this.btnContaCorrente.Name = "btnContaCorrente";
            this.btnContaCorrente.Size = new System.Drawing.Size(207, 40);
            this.btnContaCorrente.TabIndex = 13;
            this.btnContaCorrente.Text = "Cadastrar Conta";
            this.btnContaCorrente.UseVisualStyleBackColor = true;
            this.btnContaCorrente.Click += new System.EventHandler(this.btnContaCorrente_Click);
            // 
            // numLimiteCredito
            // 
            this.numLimiteCredito.DecimalPlaces = 2;
            this.numLimiteCredito.Location = new System.Drawing.Point(362, 150);
            this.numLimiteCredito.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.numLimiteCredito.Name = "numLimiteCredito";
            this.numLimiteCredito.Size = new System.Drawing.Size(175, 31);
            this.numLimiteCredito.TabIndex = 21;
            // 
            // numSaldoCorrente
            // 
            this.numSaldoCorrente.DecimalPlaces = 2;
            this.numSaldoCorrente.Location = new System.Drawing.Point(362, 61);
            this.numSaldoCorrente.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.numSaldoCorrente.Name = "numSaldoCorrente";
            this.numSaldoCorrente.Size = new System.Drawing.Size(175, 31);
            this.numSaldoCorrente.TabIndex = 20;
            // 
            // txtNumContaCor
            // 
            this.txtNumContaCor.Location = new System.Drawing.Point(24, 150);
            this.txtNumContaCor.Mask = "9999-9";
            this.txtNumContaCor.Name = "txtNumContaCor";
            this.txtNumContaCor.Size = new System.Drawing.Size(177, 31);
            this.txtNumContaCor.TabIndex = 16;
            // 
            // txtNomeCorrente
            // 
            this.txtNomeCorrente.Location = new System.Drawing.Point(24, 63);
            this.txtNomeCorrente.Name = "txtNomeCorrente";
            this.txtNomeCorrente.Size = new System.Drawing.Size(268, 31);
            this.txtNomeCorrente.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Limite de Credito:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Numero da conta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Saldo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.rbNao);
            this.groupBox1.Controls.Add(this.rbSim);
            this.groupBox1.Location = new System.Drawing.Point(601, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 124);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utiliza Talão";
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(13, 88);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(69, 29);
            this.rbNao.TabIndex = 10;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(13, 42);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(66, 29);
            this.rbSim.TabIndex = 9;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnContaPoupança);
            this.tabPage2.Controls.Add(this.numDiaAniversario);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtContaAtrelada);
            this.tabPage2.Controls.Add(this.txtSaldo);
            this.tabPage2.Controls.Add(this.txtNConta);
            this.tabPage2.Controls.Add(this.txtNome);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(840, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conta Poupança";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnContaPoupança
            // 
            this.btnContaPoupança.Location = new System.Drawing.Point(620, 147);
            this.btnContaPoupança.Name = "btnContaPoupança";
            this.btnContaPoupança.Size = new System.Drawing.Size(207, 40);
            this.btnContaPoupança.TabIndex = 31;
            this.btnContaPoupança.Text = "Cadastrar Conta";
            this.btnContaPoupança.UseVisualStyleBackColor = true;
            this.btnContaPoupança.Click += new System.EventHandler(this.btnContaPoupança_Click);
            // 
            // numDiaAniversario
            // 
            this.numDiaAniversario.Location = new System.Drawing.Point(620, 58);
            this.numDiaAniversario.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numDiaAniversario.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDiaAniversario.Name = "numDiaAniversario";
            this.numDiaAniversario.Size = new System.Drawing.Size(93, 31);
            this.numDiaAniversario.TabIndex = 16;
            this.numDiaAniversario.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(615, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "Dia do Aniversario:";
            // 
            // txtContaAtrelada
            // 
            this.txtContaAtrelada.Location = new System.Drawing.Point(367, 147);
            this.txtContaAtrelada.Mask = "9999-9";
            this.txtContaAtrelada.Name = "txtContaAtrelada";
            this.txtContaAtrelada.Size = new System.Drawing.Size(177, 31);
            this.txtContaAtrelada.TabIndex = 29;
            // 
            // txtSaldo
            // 
            this.txtSaldo.DecimalPlaces = 2;
            this.txtSaldo.Location = new System.Drawing.Point(367, 58);
            this.txtSaldo.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(175, 31);
            this.txtSaldo.TabIndex = 28;
            this.txtSaldo.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // txtNConta
            // 
            this.txtNConta.Location = new System.Drawing.Point(29, 147);
            this.txtNConta.Mask = "9999-9";
            this.txtNConta.Name = "txtNConta";
            this.txtNConta.Size = new System.Drawing.Size(177, 31);
            this.txtNConta.TabIndex = 22;
            this.txtNConta.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(29, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(268, 31);
            this.txtNome.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Numero da Conta Atrelada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Numero da conta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Saldo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Nome:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSacar);
            this.tabPage3.Controls.Add(this.btnDepositar);
            this.tabPage3.Controls.Add(this.txtValor);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.TxtNconta2);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(840, 211);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Saques e Depositos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(157, 137);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(192, 58);
            this.btnSacar.TabIndex = 20;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(426, 137);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(192, 58);
            this.btnDepositar.TabIndex = 19;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // txtValor
            // 
            this.txtValor.DecimalPlaces = 2;
            this.txtValor.Location = new System.Drawing.Point(474, 62);
            this.txtValor.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(126, 31);
            this.txtValor.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(469, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "Valor:";
            // 
            // TxtNconta2
            // 
            this.TxtNconta2.Location = new System.Drawing.Point(157, 62);
            this.TxtNconta2.Mask = "9999-9";
            this.TxtNconta2.Name = "TxtNconta2";
            this.TxtNconta2.Size = new System.Drawing.Size(177, 31);
            this.TxtNconta2.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(152, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "Numero da conta:";
            // 
            // txtListar
            // 
            this.txtListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListar.Location = new System.Drawing.Point(43, 262);
            this.txtListar.Multiline = true;
            this.txtListar.Name = "txtListar";
            this.txtListar.ReadOnly = true;
            this.txtListar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListar.Size = new System.Drawing.Size(848, 146);
            this.txtListar.TabIndex = 14;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(709, 414);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(182, 39);
            this.btnListar.TabIndex = 15;
            this.btnListar.Text = "Listar Contas Cadastradas";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(940, 463);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtListar);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ContaCorrente.ResumeLayout(false);
            this.ContaCorrente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLimiteCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSaldoCorrente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiaAniversario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ContaCorrente;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtListar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numLimiteCredito;
        private System.Windows.Forms.NumericUpDown numSaldoCorrente;
        private System.Windows.Forms.MaskedTextBox txtNumContaCor;
        private System.Windows.Forms.TextBox txtNomeCorrente;
        private System.Windows.Forms.Button btnContaCorrente;
        private System.Windows.Forms.NumericUpDown txtSaldo;
        private System.Windows.Forms.MaskedTextBox txtNConta;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtContaAtrelada;
        private System.Windows.Forms.Button btnContaPoupança;
        private System.Windows.Forms.NumericUpDown numDiaAniversario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox TxtNconta2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.NumericUpDown txtValor;
    }
}

