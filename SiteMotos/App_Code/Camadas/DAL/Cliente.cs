using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Camadas.DAL
{
    public class Cliente
    {
        private string Strcon = Conexao.getConexao();

        public List<MODEL.Cliente> Select()
        {
            List<MODEL.Cliente> lstCliente = new List<MODEL.Cliente>();
            SqlConnection conexao = new SqlConnection(Strcon);
            string sql = "Select * from Clientes";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    cliente.codigoCliente = Convert.ToInt32(reader[0].ToString());
                    cliente.nome = reader["nome"].ToString();
                    cliente.celular = reader["celular"].ToString();
                    cliente.email = reader["email"].ToString();
                    cliente.nascimento = reader["nascimento"].ToString();
                    cliente.cpf = reader["cpf"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            catch 
            {
                Console.WriteLine("Deu erro na Seleção de Clientes...");
            }
            finally
            {
                conexao.Close();
            }

            return lstCliente;
        }

        public List<MODEL.Cliente> SelectById(int codigoCliente)
        {
            List<MODEL.Cliente> lstCliente = new List<MODEL.Cliente>();
            SqlConnection conexao = new SqlConnection(Strcon);
            string sql = "Select * from Cliente where codigoCliente=@codigoCliente;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigoCliente", codigoCliente);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    cliente.codigoCliente = Convert.ToInt32(reader[0].ToString());
                    cliente.nome = reader["nome"].ToString();
                    cliente.celular = reader["celular"].ToString();
                    cliente.email = reader["email"].ToString();
                    cliente.nascimento = reader["nascimento"].ToString();
                    cliente.cpf = reader["cpf"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            catch 
            {
                Console.WriteLine("Deu erro na Seleção de Clientes por ID...");
            }
            finally
            {
                conexao.Close();
            }

            return lstCliente;
        }

        public List<MODEL.Cliente> SelectByNome(string nome)
        {
            List<MODEL.Cliente> lstCliente = new List<MODEL.Cliente>();
            SqlConnection conexao = new SqlConnection(Strcon);
            string sql = "Select * from Clientes where (nome like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nome.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    cliente.codigoCliente = Convert.ToInt32(reader[0].ToString());
                    cliente.nome = reader["nome"].ToString();
                    cliente.celular = reader["celular"].ToString();
                    cliente.nascimento = reader["nascimento"].ToString();
                    cliente.cpf = reader["cpf"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            catch 
            {
                Console.WriteLine("Deu erro na Seleção de Cliente por nome...");
            }
            finally
            {
                conexao.Close();
            }
            return lstCliente;
        }

        public void Insert (MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(Strcon);
            string sql = "Insert into Cliente values (@nome, @celular, @email, @nascimento, @cpf);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@celular", cliente.celular);
            cmd.Parameters.AddWithValue("@email", cliente.email);
            cmd.Parameters.AddWithValue("@nascimento", cliente.nascimento);
            cmd.Parameters.AddWithValue("@cpf", cliente.cpf);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch 
            {
                Console.WriteLine("Deu erro na inserção de Clietes...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void UpDate(MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(Strcon);
            string sql = "Update Cliente set nome=@nome, ";
            sql += " celular=@celular, email=@email, ";
            sql += " nascimento=@nascimento, cpf=@cpf ";
            sql += " where codigoCliente=@codigoCliente;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigoCliente", cliente.codigoCliente);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@celular", cliente.celular);
            cmd.Parameters.AddWithValue("@email", cliente.email);
            cmd.Parameters.AddWithValue("@nascimento", cliente.nascimento);
            cmd.Parameters.AddWithValue("@cpf", cliente.cpf);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch 
            {
                Console.WriteLine("Erro na atualização do Cliente");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(Strcon);
            string sql = "Delete from Cliente where codigoCliente=@codigoCliente";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigoCliente", cliente.codigoCliente);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch 
            {
                Console.WriteLine("Erro na remoção do Cliente...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
