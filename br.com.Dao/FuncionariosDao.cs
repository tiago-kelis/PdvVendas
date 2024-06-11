using MySql.Data.MySqlClient;
using PdvVendas.br.com.Conexao;
using PdvVendas.br.com.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdvVendas.br.com.Dao
{
    internal class FuncionariosDao
    {
        private MySqlConnection Cnx;

        public FuncionariosDao()
        {
            this.Cnx = new ConnectionFactory().GetConnection();

        }

        #region Cadastrar Funcionarios
        public void CadastrarFuncionarios(Fornecedores obj)
        {
            try
            {
                string mysql = @"insert into tb_funcionarios(nome, endereco, telefone, cpf, cargo)
                               values( @nome, @endereco, @telefone, @cpf, @cargo)";

                MySqlCommand exec = new MySqlCommand(mysql, Cnx);               
                exec.Parameters.AddWithValue("@nome", obj.Nome);
                exec.Parameters.AddWithValue("@endereco", obj.Endereco);
                exec.Parameters.AddWithValue("@telefone", obj.Telefone);
                exec.Parameters.AddWithValue("@cpf", obj.Cpf);
                exec.Parameters.AddWithValue("@cargo", obj.Cargo);
               
              

                Cnx.Open();
                exec.ExecuteNonQuery();

                MessageBox.Show("Funcionário Cadastrado com Sucesso:");
                Cnx.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um Erro: Cadastrar Funcionarios: " + erro);
            }

        }
        #endregion

        #region Editar Funcionarios
        public void EditarFuncionarios(Fornecedores obj)
        {
            try
            {
                string mysql = "update tb_funcionarios set nome=@nome, endereco=@endereco, telefone=@telefone, cpf=@cpf, cargo=@cargo where id=@id";

                MySqlCommand exec = new MySqlCommand(mysql, Cnx);
                exec.Parameters.AddWithValue("@nome", obj.Nome);
                exec.Parameters.AddWithValue("@endereco", obj.Endereco);
                exec.Parameters.AddWithValue("@telefone", obj.Telefone);
                exec.Parameters.AddWithValue("@cpf", obj.Cpf);
                exec.Parameters.AddWithValue("@cargo", obj.Cargo);
                exec.Parameters.AddWithValue("@id", obj.Id);
                Cnx.Open();
                exec.ExecuteNonQuery();

                MessageBox.Show("Funcionario Editado Com sucesso! ");
                Cnx.Clone();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um Erro: Editar Funcionarios" + erro);
            }
        }
        #endregion

        #region Mostrar Funcionarios
        public DataTable MostrarFuncionarios()
        {
            try
            {

                DataTable dt = new DataTable();
                string mysql = "select * from tb_funcionarios";

                MySqlCommand exec = new MySqlCommand(mysql, Cnx);
                Cnx.Open();
                exec.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(exec);
                da.Fill(dt);

                Cnx.Close();
                return dt;

            }
            catch (Exception erro)
            {
               
                MessageBox.Show("Aconteceu um  Erro: Mostar Funcionarios: " + erro);
                return null;
               
            }

        }
        #endregion

        #region Excluir Funcionarios
        public void ExcluirFuncionarios(Fornecedores obj)
        {       

            try
            {
                string mysql = "delete from tb_funcionarios where id=@id";

                MySqlCommand exec = new MySqlCommand(mysql, Cnx);
                exec.Parameters.AddWithValue("@id", obj.Id);

                Cnx.Open();
                exec.ExecuteNonQuery();
                

                MessageBox.Show("Funcionário Excluido com sucesso:");
                Cnx.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um Erro: Excluir Funcionarios" + erro);
            }

        }
        #endregion

        #region Buscar funcionario Por nome
        public DataTable BuscarFuncionarioPorNome(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string mysql = "select * from tb_funcionarios where nome like @nome '%'";
                MySqlCommand exec = new MySqlCommand( mysql, Cnx);
                exec.Parameters.AddWithValue("@nome", nome);
                Cnx.Open();
                exec.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(exec);
                da.Fill(dt);
                Cnx.Close();
                return dt;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um Erro: BuscarFuncionarioPorNome" + erro);
                return null;
            }
        }
        #endregion
    }
}
