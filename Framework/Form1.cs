using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework
{
    public partial class CRUD : Form
    {
        Employes model = new Employes();

        public EntityState Entitystate { get; private set; }

        public CRUD()
        {
            InitializeComponent();
           
            // Limitar o campo de telefone a 11 caracteres
            txt_telefone.MaxLength = 11;

            // Limitar o campo de RG a 9 caracteres
            txt_rg.MaxLength = 9;
        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            try
            {
                clear();
                this.ActiveControl = txt_nome;
                Carregar_Funcionarios();
                
            }
            catch(Exception ex)
           
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
        private void clear()
        {
            txt_nome.Text = txt_endereco.Text = txt_rg.Text = txt_salario.Text = txt_endereco.Text = txt_telefone.Text = "";
            btn_salvar.Text = "salvar";
            btn_daletar.Enabled = false;
            model.idfuncionario = 0;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txt_telefone_TextChanged(object sender, EventArgs e)
        {

        }
        private void Carregar_Funcionarios()
        {
            cbo_employes.DisplayMember = "nome";
            cbo_employes.ValueMember = "idfuncionario";

            using (EFDBEntities db = new EFDBEntities())
            {
                var oEmployes = db.Employes.ToList<Employes>();
                oEmployes.Insert(0, new Employes() { idfuncionario = -1, nome = "" });
                cbo_employes.DataSource = oEmployes;
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Preencher os dados do modelo
                model.nome = txt_nome.Text.Trim();
                model.telefone = int.Parse(txt_telefone.Text.Trim());
                model.rg = int.Parse(txt_rg.Text.Trim());
                model.endereço = txt_endereco.Text.Trim();
                model.salario = float.Parse(txt_salario.Text.Trim());

                // Verificar se o campo de horas extras está vazio
                if (!string.IsNullOrEmpty(txt_HoraExtra.Text.Trim()))
                {
                    // Se não estiver vazio, calcular o valor das horas extras
                    int horasExtras = int.Parse(txt_HoraExtra.Text.Trim());
                    decimal valorHoraExtra = CalculadoraHoraExtra.Calcular((decimal)model.salario, horasExtras);
                    model.salario += (float)valorHoraExtra;
                }

                using (EFDBEntities db = new EFDBEntities())
                {
                    if (model.idfuncionario == 0) // Insert
                        db.Employes.Add(model);
                    else
                        db.Entry(model).State = EntityState.Modified;

                    db.SaveChanges();

                    // Recarregar os dados do ComboBox
                    Carregar_Funcionarios();
                }

                // Atualizar o DataGridView para refletir o novo cálculo
                Buscar_Funcionarios(model.idfuncionario);

                // Limpar os campos e exiba uma mensagem de sucesso
                clear();
                MessageBox.Show("Cadastro completo");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, verifique se os valores numéricos estão em um formato válido.", "Erro");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar o cadastro: " + ex.Message, "Erro");
            }
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                model.idfuncionario = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgIdfuncionario"].Value);

                using (EFDBEntities db = new EFDBEntities())
                {
                    model = db.Employes.Where(x => x.idfuncionario == model.idfuncionario).FirstOrDefault();
                    txt_nome.Text = model.nome;
                    txt_telefone.Text = model.telefone.ToString();
                    txt_rg.Text = model.rg.ToString();
                    txt_endereco.Text = model.endereço;
                    txt_salario.Text = model.salario.ToString();
                    
                }
                btn_salvar.Text = "update";
                btn_daletar.Enabled = true;
            }
        }

        private void btn_daletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("tem certeza que quer apagar este funcionario?", "message", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                using (EFDBEntities db = new EFDBEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                    {
                        db.Employes.Attach(model);
                        db.Employes.Remove(model);
                        db.SaveChanges();
                        Carregar_Funcionarios();
                        clear();
                        MessageBox.Show("funcionario deletado com sucesso!");
                    }
                }
            }
            // Depois de excluir, atualize o DataGridView
            Buscar_Funcionarios(model.idfuncionario);

            // Exiba uma mensagem de sucesso
            MessageBox.Show("Funcionário deletado com sucesso!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal salarioAtual = decimal.Parse(txt_salario.Text);
                int horasExtras = int.Parse(txt_HoraExtra.Text);

                decimal valorHoraExtra = CalculadoraHoraExtra.Calcular(salarioAtual, horasExtras);

                model.valorHoraExtra = salarioAtual + valorHoraExtra;

                MessageBox.Show($"O valor das horas extras é: {valorHoraExtra.ToString("C")}");

                // Atualizar o DataGridView para refletir o novo cálculo
                Buscar_Funcionarios(model.idfuncionario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, insira um valor válido para o salário e as horas extras.");
            }

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            // Nada a ser feito aqui neste momento
            // Este método pode ser removido caso não seja necessário no futuro
        }

        private void cbo_employes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                int idfuncionario = ((Employes)cbo_employes.SelectedItem).idfuncionario;
                if (idfuncionario > -1)
                    Buscar_Funcionarios(idfuncionario);
                
                   
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Buscar_Funcionarios(int pCodigo_Funcionario)
        {
            using (EFDBEntities db = new EFDBEntities())
            {
                var oEmployes = db.Employes.Where(w => w.idfuncionario == pCodigo_Funcionario).ToList();
                dataGridView1.DataSource = oEmployes;

                // Adicionar o resultado do cálculo do salário com horas extras à coluna valorHoraExtra
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    decimal salario = decimal.Parse(row.Cells["dgSalario"].Value.ToString());
                    int horasExtras = int.Parse(txt_HoraExtra.Text);
                    decimal salarioComHoraExtra = CalculadoraHoraExtra.Calcular(salario, horasExtras);

                    // Verificar se a célula já possui um valor
                    if (row.Cells["valorHoraExtra"].Value != null)
                    {
                        // Se já tiver um valor, substituir pelo novo valor calculado
                        row.Cells["valorHoraExtra"].Value = salarioComHoraExtra;
                    }
                    else
                    {
                        // Se não tiver um valor, adicionar o novo valor calculado à célula
                        row.Cells["valorHoraExtra"].Value = salarioComHoraExtra;
                    }
                }
            }
        }
        public static class CalculadoraHoraExtra
    {
        public static decimal Calcular(decimal salarioAtual, int horasExtras)
        {
            decimal percentualHoraExtra = 0.05m; // 5%
            decimal valorHoraExtra = salarioAtual * percentualHoraExtra;
            return valorHoraExtra * horasExtras;
        }
    }
        
    }
}
