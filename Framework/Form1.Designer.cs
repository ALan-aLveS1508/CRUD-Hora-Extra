using System;

namespace Framework
{
    partial class CRUD
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_daletar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.calcularHoraExtra = new System.Windows.Forms.Button();
            this.txt_HoraExtra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_employes = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Selecione_Profissional = new System.Windows.Forms.Label();
            this.dgIdfuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEndereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(110, 115);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(168, 20);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(50, 266);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 2;
            this.btn_salvar.Text = "salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgIdfuncionario,
            this.dgNome,
            this.dgTelefone,
            this.dgRg,
            this.dgEndereço,
            this.dgSalario});
            this.dataGridView1.Location = new System.Drawing.Point(323, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 437);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_daletar
            // 
            this.btn_daletar.Location = new System.Drawing.Point(131, 266);
            this.btn_daletar.Name = "btn_daletar";
            this.btn_daletar.Size = new System.Drawing.Size(75, 23);
            this.btn_daletar.TabIndex = 2;
            this.btn_daletar.Text = "deletar";
            this.btn_daletar.UseVisualStyleBackColor = true;
            this.btn_daletar.Click += new System.EventHandler(this.btn_daletar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(212, 266);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefone";
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(110, 141);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(168, 20);
            this.txt_telefone.TabIndex = 1;
            this.txt_telefone.TextChanged += new System.EventHandler(this.txt_telefone_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "RG";
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(110, 167);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(168, 20);
            this.txt_rg.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Endereço";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(110, 193);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(168, 20);
            this.txt_endereco.TabIndex = 1;
            this.txt_endereco.TextChanged += new System.EventHandler(this.txt_endereco_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Salario";
            // 
            // txt_salario
            // 
            this.txt_salario.Location = new System.Drawing.Point(110, 219);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(168, 20);
            this.txt_salario.TabIndex = 1;
            // 
            // calcularHoraExtra
            // 
            this.calcularHoraExtra.Location = new System.Drawing.Point(220, 409);
            this.calcularHoraExtra.Name = "calcularHoraExtra";
            this.calcularHoraExtra.Size = new System.Drawing.Size(78, 25);
            this.calcularHoraExtra.TabIndex = 4;
            this.calcularHoraExtra.Text = "Calcular";
            this.calcularHoraExtra.UseVisualStyleBackColor = true;
            this.calcularHoraExtra.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_HoraExtra
            // 
            this.txt_HoraExtra.Location = new System.Drawing.Point(102, 412);
            this.txt_HoraExtra.Name = "txt_HoraExtra";
            this.txt_HoraExtra.Size = new System.Drawing.Size(100, 20);
            this.txt_HoraExtra.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Horas Extras:";
            // 
            // cbo_employes
            // 
            this.cbo_employes.FormattingEnabled = true;
            this.cbo_employes.Location = new System.Drawing.Point(81, 36);
            this.cbo_employes.Name = "cbo_employes";
            this.cbo_employes.Size = new System.Drawing.Size(168, 21);
            this.cbo_employes.TabIndex = 7;
            this.cbo_employes.SelectedIndexChanged += new System.EventHandler(this.cbo_employes_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Selecione_Profissional);
            this.groupBox1.Controls.Add(this.cbo_employes);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 63);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "pesquisa";
            // 
            // lbl_Selecione_Profissional
            // 
            this.lbl_Selecione_Profissional.AutoSize = true;
            this.lbl_Selecione_Profissional.Location = new System.Drawing.Point(78, 16);
            this.lbl_Selecione_Profissional.Name = "lbl_Selecione_Profissional";
            this.lbl_Selecione_Profissional.Size = new System.Drawing.Size(123, 13);
            this.lbl_Selecione_Profissional.TabIndex = 8;
            this.lbl_Selecione_Profissional.Text = "Selecione o Empregado:";
            // 
            // dgIdfuncionario
            // 
            this.dgIdfuncionario.DataPropertyName = "Idfuncionario";
            this.dgIdfuncionario.HeaderText = "Idfuncionarios";
            this.dgIdfuncionario.Name = "dgIdfuncionario";
            this.dgIdfuncionario.ReadOnly = true;
            this.dgIdfuncionario.Visible = false;
            // 
            // dgNome
            // 
            this.dgNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgNome.DataPropertyName = "Nome";
            this.dgNome.HeaderText = "Nome";
            this.dgNome.Name = "dgNome";
            this.dgNome.ReadOnly = true;
            // 
            // dgTelefone
            // 
            this.dgTelefone.DataPropertyName = "Telefone";
            this.dgTelefone.HeaderText = "Telefone";
            this.dgTelefone.Name = "dgTelefone";
            this.dgTelefone.ReadOnly = true;
            // 
            // dgRg
            // 
            this.dgRg.DataPropertyName = "Rg";
            this.dgRg.HeaderText = "Rg";
            this.dgRg.Name = "dgRg";
            this.dgRg.ReadOnly = true;
            // 
            // dgEndereço
            // 
            this.dgEndereço.DataPropertyName = "Endereço";
            this.dgEndereço.HeaderText = "Endereço";
            this.dgEndereço.Name = "dgEndereço";
            this.dgEndereço.ReadOnly = true;
            // 
            // dgSalario
            // 
            this.dgSalario.DataPropertyName = "Salario";
            this.dgSalario.HeaderText = "Salario";
            this.dgSalario.Name = "dgSalario";
            this.dgSalario.ReadOnly = true;
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(982, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_HoraExtra);
            this.Controls.Add(this.calcularHoraExtra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_daletar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.txt_salario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_rg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Name = "CRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txt_endereco_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_daletar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_rg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.Button calcularHoraExtra;
        private System.Windows.Forms.TextBox txt_HoraExtra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_employes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Selecione_Profissional;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdfuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEndereço;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSalario;
    }
}

