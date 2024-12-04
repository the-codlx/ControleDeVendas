using Controle_de_Vendas.br.com.projeto.dao;
using Controle_de_Vendas.br.com.projeto.model;
using Mysqlx.Resultset;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Controle_de_Vendas.br.com.projeto.view
{
    public partial class Frmclientes : Form
    {
        public Frmclientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {

            // receber os dados dentro de um objeto

            Cliente obj = new Cliente();

            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.endereco = txtendereco.Text;
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = txtuf.Text;
            obj.cep = txtcep.Text;
            if (!string.IsNullOrEmpty(txtnumero.Text))
                obj.numero = int.Parse(txtnumero.Text);
                
            //criar um objeto da classe clienteDAO e chamar o metodo cadastrar 
            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);

            tabelaCliente.DataSource = dao.listarClientes();

        }

        private void tabelaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {

            ClienteDAO dao = new ClienteDAO();

            tabelaCliente.DataSource = dao.listarClientes();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            obj.codigo = int.Parse(txtcodigo.Text);

            ClienteDAO dao = new ClienteDAO();

            dao.ExcluirCliente(obj);

            MessageBox.Show("Cliente excluído com sucesso!");

            tabelaCliente.DataSource = dao.listarClientes();


           

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            //cria um objeto Cliente e passa os atributos para ele
            Cliente obj = new Cliente();

            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = txtuf.Text;
            obj.cep = txtcep.Text;
            obj.codigo = int.Parse(txtcodigo.Text);

            //cria um objeto da classe ClienteDAO e chama o metodo alterarCliente
            ClienteDAO dao = new ClienteDAO();
            dao.alterarCliente(obj);

            //mostra uma mensagem na tela
            MessageBox.Show("Cliente alterado com sucesso!");

            //recarrega a tabelaCliente (DataGridView)
            tabelaCliente.DataSource = dao.listarClientes();

        }

        private void tabelaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pegar os dados da linha selecionada
            txtcodigo.Text = tabelaCliente.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelaCliente.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = tabelaCliente.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelaCliente.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = tabelaCliente.CurrentRow.Cells[4].Value.ToString();
            txttelefone.Text = tabelaCliente.CurrentRow.Cells[5].Value.ToString();
            txtcelular.Text = tabelaCliente.CurrentRow.Cells[6].Value.ToString();
            txtcep.Text = tabelaCliente.CurrentRow.Cells[7].Value.ToString();
            txtendereco.Text = tabelaCliente.CurrentRow.Cells[8].Value.ToString();
            txtnumero.Text = tabelaCliente.CurrentRow.Cells[9].Value.ToString();
            txtcomplemento.Text = tabelaCliente.CurrentRow.Cells[10].Value.ToString();
            txtbairro.Text = tabelaCliente.CurrentRow.Cells[11].Value.ToString();
            txtcidade.Text = tabelaCliente.CurrentRow.Cells[12].Value.ToString();
            txtuf.Text = tabelaCliente.CurrentRow.Cells[13].Value.ToString();


            //alterar para a guia Dados Pessoais
            tabClientes.SelectedTab = tabDadosPessoais;

        }

        private void txtrg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            //Botao pesquisar
            string nome = txtpesquisa.Text;

            ClienteDAO dao = new ClienteDAO();

            tabelaCliente.DataSource = dao.BuscarClientePorNome(nome);

            
            if (tabelaCliente.Rows.Count == 0)
            {

                MessageBox.Show("Cliente não encontrado!");
                tabelaCliente.DataSource = dao.listarClientes();

            }
                

        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void txtpesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtpesquisa.Text + "%";

            ClienteDAO dao = new ClienteDAO();

            tabelaCliente.DataSource = dao.ListarClientePorNome(nome);


        }

        private void btnpesquisarcep_Click(object sender, EventArgs e)
        {
            //Botao consultar cep
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

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

           

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tabConsulta_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
