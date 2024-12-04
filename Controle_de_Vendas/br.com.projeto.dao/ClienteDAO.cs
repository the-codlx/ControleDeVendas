using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle_de_Vendas.br.com.projeto.model;
using MySql.Data.MySqlClient;
using Controle_de_Vendas.br.com.projeto.conexao;
using System.Windows.Forms;
using System.Data;
using MySqlX.XDevAPI;

namespace Controle_de_Vendas.br.com.projeto.dao
{

    public class ClienteDAO
    {

        private MySqlConnection conexao;

        public ClienteDAO() {

            this.conexao = new ConnectionFactory().getconnection();

        }

       
        #region Cadastrar Cliente
        public void cadastrarCliente(Cliente cliente)
        {

            try
            {
                //definir o comando sql
                string sql = @"insert into tb_clientes (nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
                        values (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                //preparar o comando para ser executado
                MySqlCommand executacmd = new MySqlCommand(sql, this.conexao);
                executacmd.Parameters.AddWithValue("@nome", cliente.nome);
                executacmd.Parameters.AddWithValue("@rg", cliente.rg);
                executacmd.Parameters.AddWithValue("@cpf", cliente.cpf);
                executacmd.Parameters.AddWithValue("@email", cliente.email);
                executacmd.Parameters.AddWithValue("@telefone", cliente.telefone);
                executacmd.Parameters.AddWithValue("@celular", cliente.celular);
                executacmd.Parameters.AddWithValue("@cep", cliente.cep);
                executacmd.Parameters.AddWithValue("@endereco", cliente.endereco);
                executacmd.Parameters.AddWithValue("@numero", cliente.numero);
                executacmd.Parameters.AddWithValue("@complemento", cliente.complemento);
                executacmd.Parameters.AddWithValue("@bairro", cliente.bairro);
                executacmd.Parameters.AddWithValue("@cidade", cliente.cidade);
                executacmd.Parameters.AddWithValue("@estado", cliente.estado);

                //abrir a conexao e excutar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");

            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro.Message);
                
                throw;
            }
            finally
            {

                //fecha a conexao com o banco de dados
                conexao.Close();

            }

        }
        #endregion

        #region Alterar Cliente

        public void alterarCliente(Cliente cliente)
        {

            try
            {
                //definir o comando sql
                string sql = @"UPDATE tb_clientes 
                SET nome = @nome, 
                rg = @rg, 
                cpf = @cpf, 
                email = @email, 
                telefone = @telefone, 
                celular = @celular, 
                cep = @cep, 
                endereco = @endereco, 
                numero = @numero, 
                complemento = @complemento, 
                bairro = @bairro, 
                cidade = @cidade, 
                estado = @estado 
                WHERE id = @id;";
                        

                //preparar o comando para ser executado
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", cliente.nome);
                executacmd.Parameters.AddWithValue("@rg", cliente.rg);
                executacmd.Parameters.AddWithValue("@cpf", cliente.cpf);
                executacmd.Parameters.AddWithValue("@email", cliente.email);
                executacmd.Parameters.AddWithValue("@telefone", cliente.telefone);
                executacmd.Parameters.AddWithValue("@celular", cliente.celular);
                executacmd.Parameters.AddWithValue("@cep", cliente.cep);
                executacmd.Parameters.AddWithValue("@endereco", cliente.endereco);
                executacmd.Parameters.AddWithValue("@numero", cliente.numero);
                executacmd.Parameters.AddWithValue("@complemento", cliente.complemento);
                executacmd.Parameters.AddWithValue("@bairro", cliente.bairro);
                executacmd.Parameters.AddWithValue("@cidade", cliente.cidade);
                executacmd.Parameters.AddWithValue("@estado", cliente.estado);
                executacmd.Parameters.AddWithValue("@id", cliente.codigo);

                //abrir a conexao e excutar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente alterado com sucesso!");

            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro.Message);

                throw;
            }
            finally 
            {

                //fecha a conexao com o banco de dados
                conexao.Close();

            }


        }

        #endregion

        #region Excluir Cliente
        public void ExcluirCliente(Cliente cliente) 
        {

            try
            {
                //definir o comando sql
                string sql = @"delete from tb_clientes where id =@id";

                //preparar o comando para ser executado
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", cliente.codigo);

                //abrir a conexao e excutar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente excluído com sucesso!");

            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro.Message);

                throw;
            }
            finally
            {

                //fecha a conexao com o banco de dados
                conexao.Close();

            }

        }
        #endregion

        #region ListarClientes
        public DataTable listarClientes() 
        {

            try
            {
                //criar o data table e comando sql
                DataTable tabelacliente = new DataTable();
                string sql = @"select * from tb_clientes";

                //organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, this.conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //criar o MySqlDataAdapter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);

                return tabelacliente;

            }
            catch (Exception excecao)
            {
                MessageBox.Show("Ocorreu um erro: " + excecao.Message);
                throw;
            }
            finally
            {

                //fecha a conexao com o banco de dados
                conexao.Close();

            }

        }
        #endregion

        #region Buscar Cliente Por Nome

        public DataTable BuscarClientePorNome(string nome)
        {

            try
            {
                //criar o data table e comando sql
                DataTable tabelacliente = new DataTable();
                string sql = @"select * from tb_clientes where nome = @nome";

                //organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, this.conexao);

                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //criar o MySqlDataAdapter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);

                return tabelacliente;

            }
            catch (Exception excecao)
            {
                MessageBox.Show("Ocorreu um erro: " + excecao.Message);
                throw;
            }
            finally
            {

                //fecha a conexao com o banco de dados
                conexao.Close();

            }

        }

        #endregion

        #region Listar Cliente Por Nome

            public DataTable ListarClientePorNome(string nome)
            {

            try
            {
                //criar o data table e comando sql
                DataTable tabelacliente = new DataTable();
                string sql = @"select * from tb_clientes where nome like @nome";

                //organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, this.conexao);

                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //criar o MySqlDataAdapter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);

                return tabelacliente;

            }
            catch (Exception excecao)
            {
                MessageBox.Show("Ocorreu um erro: " + excecao.Message);
                throw;
            }
            finally
            {

                //fecha a conexao com o banco de dados
                conexao.Close();

            }

            }

        #endregion
        

    }
}
