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

namespace teste_2
{
    public partial class Form1 : Form
    {
        Funcionario model = new Funcionario();
        bool isNew = true; // Variavel para indicar se é um novo funcionario ou uma atualizaçao
        public Form1()
        {
            InitializeComponent();
        }
        void Clear()
        {
            txt_nome.Text = mtb_telefone.Text = mtb_rg.Text = txt_endereco.Text = txt_salario.Text = txt_horaExtra.Text = "";
            btn_salvar.Text = "salvar";
            btn_deletar.Enabled = true;
            model.idfuncionarios = 0;
            isNew = true;

        }

        private void Carregar_funcionarios()
        {
            cbo_funcionarios.DisplayMember = "nome";
            cbo_funcionarios.ValueMember = "idfuncionarios";
            
            using (EFDBEntities db = new EFDBEntities())
            {
                var ofuncionarios = db.Funcionario.ToList<Funcionario>();
                ofuncionarios.Insert(0, new Funcionario() { idfuncionarios = -1, nome = "" });
                cbo_funcionarios.DataSource = ofuncionarios;
            }

        }

        private void Buscar_funcionarios(int idfuncionario)
        {
            using (EFDBEntities db = new EFDBEntities())
            {
                var funcionario = db.Funcionario.FirstOrDefault(f => f.idfuncionarios == idfuncionario);
                if (funcionario != null)
                {
                    txt_nome.Text = funcionario.nome;
                    mtb_telefone.Text = funcionario.telefone;
                    mtb_rg.Text = funcionario.rg;
                    txt_endereco.Text = funcionario.endereco;
                    txt_salario.Text = funcionario.salario;
                    model.idfuncionarios = idfuncionario; // Atualizar o ID do funcionário no modelo
                    isNew = false; // Indicar que é uma atualização
                    btn_salvar.Text = "Atualizar"; // Alterar o texto do botão para "Atualizar"
                }
                else
                {
                    MessageBox.Show("Funcionário não encontrado");
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
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cbo_funcionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idfuncionario = (int)cbo_funcionarios.SelectedValue; // Extrair o ID do item selecionado no combobox
                if (idfuncionario > 0)
                    Buscar_funcionarios(idfuncionario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
    {
        model.nome = txt_nome.Text.Trim();
        model.telefone = mtb_telefone.Text.Trim();
        model.rg = mtb_rg.Text.Trim();
        model.endereco = txt_endereco.Text.Trim();
        model.salario = txt_salario.Text.Trim();

        using (EFDBEntities db = new EFDBEntities())
        {
            if (cbo_funcionarios.SelectedIndex != 0) // Se um funcionário estiver selecionado no combobox
            {
                // Atualizar o funcionário selecionado
                int idfuncionario = ((Funcionario)cbo_funcionarios.SelectedItem).idfuncionarios;
                var existingFuncionario = db.Funcionario.FirstOrDefault(f => f.idfuncionarios == idfuncionario);
                if (existingFuncionario != null)
                {
                    existingFuncionario.nome = model.nome;
                    existingFuncionario.telefone = model.telefone;
                    existingFuncionario.rg = model.rg;
                    existingFuncionario.endereco = model.endereco;
                    existingFuncionario.salario = model.salario;

                    db.Entry(existingFuncionario).State = System.Data.Entity.EntityState.Modified;
                    MessageBox.Show("Cadastro atualizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Funcionário não encontrado para atualização.");
                }
            }
            else
            {
                // Criar um novo funcionário
                db.Funcionario.Add(model);
                MessageBox.Show("Novo cadastro criado com sucesso");
            }

            db.SaveChanges();
            // Recarregar dados no combobox
            Carregar_funcionarios();
        }
        Clear();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                this.ActiveControl = txt_nome;
                Carregar_funcionarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo_funcionarios.SelectedIndex != 0) // Verifica se um funcionário foi selecionado
                {
                    int idfuncionario = ((Funcionario)cbo_funcionarios.SelectedItem).idfuncionarios;
                    using (EFDBEntities db = new EFDBEntities())
                    {
                        var funcionario = db.Funcionario.FirstOrDefault(f => f.idfuncionarios == idfuncionario);
                        if (funcionario != null)
                        {
                            db.Funcionario.Remove(funcionario);
                            db.SaveChanges();
                            Carregar_funcionarios();
                            Clear();
                            MessageBox.Show("Funcionário deletado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Funcionário não encontrado para exclusão.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um funcionário para excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir o funcionário: " + ex.Message, "Erro");
            }

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal salarioAtual = decimal.Parse(txt_salario.Text);
                int horasExtras = int.Parse(txt_horaExtra.Text);

                decimal valorHoraExtra = CalculadoraHoraExtra.Calcular(salarioAtual, horasExtras);

                txt_horaExtra.Text = valorHoraExtra.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, insira um valor válido para o salário e as horas extras.");
            }
        }
    }
}
