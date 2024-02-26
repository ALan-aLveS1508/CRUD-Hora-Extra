namespace teste_2
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
            this.cbo_funcionarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_horaExtra = new System.Windows.Forms.TextBox();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.mtb_rg = new System.Windows.Forms.MaskedTextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbo_funcionarios
            // 
            this.cbo_funcionarios.FormattingEnabled = true;
            this.cbo_funcionarios.Location = new System.Drawing.Point(142, 23);
            this.cbo_funcionarios.Name = "cbo_funcionarios";
            this.cbo_funcionarios.Size = new System.Drawing.Size(121, 21);
            this.cbo_funcionarios.TabIndex = 0;
            this.cbo_funcionarios.SelectedIndexChanged += new System.EventHandler(this.cbo_funcionarios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o Funcionario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Rg:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Endereço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Salario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Horas Extras: ";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(142, 89);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 3;
            // 
            // txt_horaExtra
            // 
            this.txt_horaExtra.Location = new System.Drawing.Point(142, 268);
            this.txt_horaExtra.Name = "txt_horaExtra";
            this.txt_horaExtra.Size = new System.Drawing.Size(100, 20);
            this.txt_horaExtra.TabIndex = 3;
            // 
            // txt_salario
            // 
            this.txt_salario.Location = new System.Drawing.Point(142, 230);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(100, 20);
            this.txt_salario.TabIndex = 3;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(142, 196);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(100, 20);
            this.txt_endereco.TabIndex = 3;
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(142, 124);
            this.mtb_telefone.Mask = "(00) 00000-0000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(100, 20);
            this.mtb_telefone.TabIndex = 4;
            // 
            // mtb_rg
            // 
            this.mtb_rg.Location = new System.Drawing.Point(142, 162);
            this.mtb_rg.Mask = "000.000.000-00";
            this.mtb_rg.Name = "mtb_rg";
            this.mtb_rg.Size = new System.Drawing.Size(100, 20);
            this.mtb_rg.TabIndex = 4;
            this.mtb_rg.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(59, 325);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 5;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(142, 325);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_deletar.TabIndex = 5;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(223, 325);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(251, 266);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 6;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 450);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.mtb_rg);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.txt_salario);
            this.Controls.Add(this.txt_horaExtra);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_funcionarios);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_funcionarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_horaExtra;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.MaskedTextBox mtb_rg;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_calcular;
    }
}

