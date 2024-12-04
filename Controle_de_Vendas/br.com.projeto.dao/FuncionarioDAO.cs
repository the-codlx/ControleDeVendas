using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle_de_Vendas.br.com.projeto.conexao;


using System.Windows.Forms;
using Controle_de_Vendas.br.com.projeto.model;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.CompilerServices;
using System.Data.SqlTypes;
using MySqlX.XDevAPI.Common;

namespace Controle_de_Vendas.br.com.projeto.dao
{
    public class FuncionarioDAO
    {

        private MySqlConnection conexao;

        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();

        }

        #region Cadastrar Funcionario
        public void cadastrarFuncionario(Funcionario funcionario)
        {
            try
            {
                //1 passo criar o comando sql
                string sql = @"insert into tb_funcionarios (nome, rg, cpf, email, senha, cargo, nivel_acesso, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
                        values(@nome, @rg, @cpf, @email, @senha, @cargo, @nivel_acesso, @telefone, @celular, @cep, @endereco, @numero, complemento, @bairro, @cidade, @estado)";

                //2 organizar e executar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", funcionario.nome);
                executacmd.Parameters.AddWithValue("@rg", funcionario.rg);
                executacmd.Parameters.AddWithValue("@cpf", funcionario.cpf);
                executacmd.Parameters.AddWithValue("@senha", funcionario.senha);
                executacmd.Parameters.AddWithValue("@cargo", funcionario.cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", funcionario.nivel_acesso);
                executacmd.Parameters.AddWithValue("@email", funcionario.email);
                executacmd.Parameters.AddWithValue("@telefone", funcionario.telefone);
                executacmd.Parameters.AddWithValue("@celular", funcionario.celular);
                executacmd.Parameters.AddWithValue("@cep", funcionario.cep);
                executacmd.Parameters.AddWithValue("@endereco", funcionario.endereco);
                executacmd.Parameters.AddWithValue("@numero", funcionario.numero);
                executacmd.Parameters.AddWithValue("@complemento", funcionario.complemento);
                executacmd.Parameters.AddWithValue("@bairro", funcionario.bairro);
                executacmd.Parameters.AddWithValue("@cidade", funcionario.cidade);
                executacmd.Parameters.AddWithValue("@estado", funcionario.estado);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário cadastrado com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!" + erro);

            }
            conexao.Close();

        }

        #endregion


        #region listarFuncionario
        public DataTable listarFuncionarios()

        {

            try
            {
                //criar o data table e comando sql
                DataTable tabelaFuncionario = new DataTable();
                string sql = @"SELECT * FROM tb_funcionarios WHERE STATUS != 'INATIVO'";

                //organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, this.conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //criar o MySqlDataAdapter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFuncionario);

                return tabelaFuncionario;

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


        #region metodo que lista funcionarios por nome

        public DataTable listarFuncionariosPorNome(string nome)
        {

            DataTable dataTable = new DataTable();

            try
            {
                string sql = "SELECT * FROM TB_FUNCIONARIOS WHERE NOME LIKE @nome AND STATUS = 'ATIVO'";

                conexao.Open();

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", nome); 

                executacmd.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executacmd);

                dataAdapter.Fill(dataTable);

                conexao.Close();

            }


            catch (SqlException excecao)
            {

                Console.WriteLine(excecao);

            }

            return dataTable;

            #endregion

        }


        #region exclui funcionario

        public void excluiFuncionario(string id)
        {

            try
            {

                int idInteiro = int.Parse(id);

                string sql = "UPDATE tb_funcionarios SET STATUS = 'INATIVO' WHERE ID = @ID";

                MySqlCommand executacmd = new MySqlCommand(sql, this.conexao);

                conexao.Open();


                executacmd.Parameters.AddWithValue("@ID", idInteiro);

                int registrosAfetados = executacmd.ExecuteNonQuery();


                if (registrosAfetados > 0)
                {

                    MessageBox.Show("Funcionario excluido com sucesso.");

                }
                else
                {

                    MessageBox.Show("Nenhum funcionario encontrado.");

                }
            }
            catch(FormatException exception) { MessageBox.Show("Tipo informado não permitido."); }

            catch (Exception excecao)
            {
                Console.WriteLine(excecao);
            }

            conexao.Close();


        }

        #endregion

        #region alterar funcionario

        public void alterarFuncionario(Funcionario funcionario)
        {

            string sql = @"UPDATE tb_funcionarios nome= @nome, rg = @rg, cpf = @cpf, email = @email, senha = @senha, cargo = @cargo, nivel_acesso = @nivel_acesso, telefone = @telefone,
                            celular = @celular, cep = @cep, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado) where id = @id";

            //2 organizar e executar o comando sql
            MySqlCommand executacmd = new MySqlCommand(sql, conexao);

            executacmd.Parameters.AddWithValue("@nome", funcionario.nome);
            executacmd.Parameters.AddWithValue("@rg", funcionario.rg);
            executacmd.Parameters.AddWithValue("@cpf", funcionario.cpf);
            executacmd.Parameters.AddWithValue("@senha", funcionario.senha);
            executacmd.Parameters.AddWithValue("@cargo", funcionario.cargo);
            executacmd.Parameters.AddWithValue("@nivel_acesso", funcionario.nivel_acesso);
            executacmd.Parameters.AddWithValue("@email", funcionario.email);
            executacmd.Parameters.AddWithValue("@telefone", funcionario.telefone);
            executacmd.Parameters.AddWithValue("@celular", funcionario.celular);
            executacmd.Parameters.AddWithValue("@cep", funcionario.cep);
            executacmd.Parameters.AddWithValue("@endereco", funcionario.endereco);
            executacmd.Parameters.AddWithValue("@numero", funcionario.numero);
            executacmd.Parameters.AddWithValue("@complemento", funcionario.complemento);
            executacmd.Parameters.AddWithValue("@bairro", funcionario.bairro);
            executacmd.Parameters.AddWithValue("@cidade", funcionario.cidade);
            executacmd.Parameters.AddWithValue("@estado", funcionario.estado);
            executacmd.Parameters.AddWithValue("@id", funcionario.codigo);  

            conexao.Open();
            executacmd.ExecuteNonQuery();

            MessageBox.Show("Funcionário alterado com sucesso!");

        }

        #endregion

    }
}
