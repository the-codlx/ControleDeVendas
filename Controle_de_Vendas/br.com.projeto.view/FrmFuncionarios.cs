using Controle_de_Vendas.br.com.projeto.dao;
using Controle_de_Vendas.br.com.projeto.model;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.projeto.view
{

    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            // receber os dados dentro de um objeto

            Funcionario obj = new Funcionario();

            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.nivel_acesso = cbnivel.SelectedItem.ToString();
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.endereco = txtendereco.Text;
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = txtuf.SelectedItem.ToString();
            obj.cargo = cbcargo.SelectedItem.ToString();
            obj.estado = txtuf.Text;
            obj.senha = txtsenha.Text;
            obj.cep = txtcep.Text;
            if (!string.IsNullOrEmpty(txtnumero.Text))
                obj.numero = int.Parse(txtnumero.Text);

            //criar o objeto funcionario
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.cadastrarFuncionario(obj);

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioDAO dao = new FuncionarioDAO();

                Funcionario funcionario = new Funcionario();

                funcionario.nome = txtnome.Text;
                funcionario.email = txtemail.Text;
                funcionario.rg = txtrg.Text;
                funcionario.endereco = txtendereco.Text;
                funcionario.estado = txtuf.Text;
                funcionario.bairro = txtbairro.Text;
                funcionario.cep = txtcep.Text;
                funcionario.cidade = txtcidade.Text;
                funcionario.complemento = txtcomplemento.Text;
                funcionario.estado = txtuf.Text;
                funcionario.senha = txtsenha.Text;
                funcionario.nivel_acesso = cbnivel.SelectedItem.ToString();
                funcionario.telefone = txttelefone.Text;
                funcionario.celular = txtcelular.Text;
                funcionario.cpf = txtcpf.Text;
                if (txtnumero != null)
                {

                    funcionario.numero = int.Parse(txtnumero.Text);

                }

                dao.cadastrarFuncionario(funcionario);

            }
            catch(NullReferenceException execao)
            {

                MessageBox.Show("Valores não informados.");

            }

      }

        private void button2_Click(object sender, EventArgs e)
        {
            Helpers limpatela = new Helpers();

            limpatela.LimparTela(this);
        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string cep = txtcep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);


                txtendereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtbairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtcidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtuf.Text = dados.Tables[0].Rows[0]["uf"].ToString();


            }
            catch (Exception)
            {

                MessageBox.Show("Endereço não encontrado, por favor digite manualmente!");

            }

        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {

            string nome = "%" + txtpesquisa.Text + "%";


            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

          
            tabelaFuncionario.DataSource = funcionarioDAO.listarFuncionariosPorNome(nome);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            FuncionarioDAO dao = new FuncionarioDAO();

            tabelaFuncionario.DataSource = dao.listarFuncionarios();

        }

        private void tabConsulta_Click(object sender, EventArgs e)
        {

        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Input input = new Input();

            input.Show();

            
        }

        private void tabelaFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            codigotxt.Text = tabelaFuncionario.CurrentRow.Cells[0].Value.ToString();

            tabFuncionarios.SelectedTab = tabDadosPessoais;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioDAO dao = new FuncionarioDAO();

                Funcionario funcionario = new Funcionario();

                funcionario.nome = txtnome.Text;
                funcionario.email = txtemail.Text;
                funcionario.rg = txtrg.Text;
                funcionario.endereco = txtendereco.Text;
                funcionario.estado = txtuf.Text;
                funcionario.bairro = txtbairro.Text;
                funcionario.cep = txtcep.Text;
                funcionario.cidade = txtcidade.Text;
                funcionario.complemento = txtcomplemento.Text;
                funcionario.estado = txtuf.Text;
                funcionario.senha = txtsenha.Text;
                funcionario.nivel_acesso = cbnivel.SelectedItem.ToString();
                funcionario.telefone = txttelefone.Text;
                funcionario.celular = txtcelular.Text;
                funcionario.cpf = txtcpf.Text;
                funcionario.codigo = int.Parse(codigotxt.Text);
                if (txtnumero != null)
                {

                    funcionario.numero = int.Parse(txtnumero.Text);

                }

                dao.alterarFuncionario(funcionario);

            }catch(FormatException exception)
            {

                MessageBox.Show("Tipo informado incorreto.");

            }
            catch (NullReferenceException excecao)
            {

                MessageBox.Show("Valores não informados.");

            }

    
        }
    }
}
