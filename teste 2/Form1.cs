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
        bool isNew = true; //Variavel para indicar se é um novo funcionario ou uma atualizaçao
        public Form1()
        {
            InitializeComponent();
        }

        void Clear()
        {
            txt_nome.Text = mtb_telefone.Text = mtb_rg.Text = txt_endereco.Text = txt_salario.Text = txt_horaextra.Text = "";
            btn_salvar.Text = "Salvar";
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

        private void Buscar_funcionario(int idfuncionario)
        {
            using(EFDBEntities db = new EFDBEntities())
            {
                var funcionario = db.Funcionario.FirstOrDefault(f => f.idfuncionarios == idfuncionario);
                if (funcionario != null)
                {
                    txt_nome.Text = funcionario.nome;
                    mtb_telefone.Text = funcionario.telefone;
                    mtb_rg.Text = funcionario.rg;
                    txt_endereco.Text = funcionario.endereco;
                    txt_salario.Text = funcionario.salario;
                    model.idfuncionarios = idfuncionario; // Atualizar o ID do funcionario no modelo
                    isNew = false; // Indicar que é uma atualizaçao
                    btn_salvar.Text = "Atualizar"; // Alterar o texto do botao para "Atualizar"
                    
                }
                else
                {
                    MessageBox.Show("Funcionario não encontrado");
                }
            }
        } 

        public static class CalculadoraHoraExtra
        {
            public static decimal Calcular(decimal SalarioAtual, int horasExtras)
            {
                decimal percentualHoraExtra = 0.05m; //5%
                decimal valorHoraExtra = SalarioAtual * percentualHoraExtra;
                return valorHoraExtra * horasExtras;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Clear();
            cbo_funcionarios.SelectedIndex = 0;
        }

        private void cbo_funcionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idfuncionario = (int)cbo_funcionarios.SelectedValue; // Extrair o ID do item selecionado no combobox
                if (idfuncionario > 0)
                    Buscar_funcionario(idfuncionario);
                else
                    Clear(); //Limpar os campos se nenhum funcionario estiver selecionado
                txt_horaextra.Text = ""; // Limpar o campo txt_horaextra
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
                if(cbo_funcionarios.SelectedIndex != 0)//verifica se um funcionario foi selecionado 
                {
                    int idfuncionario = ((Funcionario)cbo_funcionarios.SelectedItem).idfuncionarios;
                    using(EFDBEntities db = new EFDBEntities())
                    {
                        var funcionario = db.Funcionario.FirstOrDefault(f => f.idfuncionarios == idfuncionario);
                        if (funcionario != null)
                        {
                            db.Funcionario.Remove(funcionario);
                            db.SaveChanges();
                            Carregar_funcionarios();
                            Clear();
                            MessageBox.Show("Funcionario deletado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Selecione um funcionario para Excluir.");
                        }
                    }
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir o funcionario: " + ex.Message, "Erro");
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal salarioAtual = decimal.Parse(txt_salario.Text);
                int horasExtras = int.Parse(txt_horaextra.Text);

                decimal valorHoraExtra = CalculadoraHoraExtra.Calcular(salarioAtual, horasExtras);
                decimal total = salarioAtual + valorHoraExtra; // soma do salario com a hora extra

                txt_horaextra.Text = total.ToString("C");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Por favor, insira um valor valido para o salario e as horas extras.");
            }
        }
    }
}

