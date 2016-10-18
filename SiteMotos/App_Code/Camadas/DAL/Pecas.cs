using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Camadas.DAL
{
    public class Pecas
    {

        private string Strcon = Conexao.getConexao();

        public List<MODEL.Pecas> Select()
        {
            List<MODEL.Pecas> lstPecas = new List<MODEL.Pecas>();
            SqlConnection conexao = new SqlConnection(Strcon);
            string sql = "Select * from Pecas";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Pecas pecas = new MODEL.Pecas();
                    pecas.codigoPecas = Convert.ToInt32(reader[0].ToString());
                    pecas.nome = reader["nome"].ToString();
                    pecas.anoPeca = reader["anoPeca"].ToString();
                    pecas.quantidade = Convert.ToInt32(reader["quantidade"].ToString());
                    pecas.preco = Convert.ToSingle(reader["preco"].ToString());
                    lstPecas.Add(pecas);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Pecas...");
            }
            finally
            {
                conexao.Close();
            }

            return lstPecas;
        }

        public List<MODEL.Pecas> SelectById(int codigoPecas)
        {
            List<MODEL.Pecas> lstPecas = new List<MODEL.Pecas>();
            SqlConnection conexao = new SqlConnection(Strcon);
            string sql = "Select * from Pecas where codigoPecas=@codigoPecas;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigoPecas", codigoPecas);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Pecas pecas = new MODEL.Pecas();
                    pecas.codigoPecas = Convert.ToInt32(reader[0].ToString());
                    pecas.nome = reader["nome"].ToString();
                    pecas.anoPeca = reader["anoPeca"].ToString();
                    pecas.quantidade = Convert.ToInt32(reader["quantidade"].ToString());
                    pecas.preco = Convert.ToSingle(reader["preco"].ToString());
                    lstPecas.Add(pecas);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Peças por ID...");
            }
            finally
            {
                conexao.Close();
            }

            return lstPecas;
        }

        public void Insert(MODEL.Pecas pecas)
        {
            SqlConnection conexao = new SqlConnection(Strcon);
            string sql = "Insert into Pecas values (@nome, @anoPeca, @quantidade, @preco);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("nome", pecas.nome);
            cmd.Parameters.AddWithValue("anoPeca", pecas.anoPeca);
            cmd.Parameters.AddWithValue("quantidade", pecas.quantidade);
            cmd.Parameters.AddWithValue("preco", pecas.preco);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Peças....");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void UpDate(MODEL.Pecas pecas)
        {
            SqlConnection conexao = new SqlConnection(Strcon);
            string sql = "UpDate Pecas set nome=@nome";
            sql += "anoPeca=@anoPeca, qauntidade=@quantidade";
            sql += "preco=@preco";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigoPecas", pecas.codigoPecas);
            cmd.Parameters.AddWithValue("@nome", pecas.nome);
            cmd.Parameters.AddWithValue("@anoPeca", pecas.anoPeca);
            cmd.Parameters.AddWithValue("@quantidade", pecas.quantidade);
            cmd.Parameters.AddWithValue("@preco", pecas.preco);
            conexao.Open();
            try
            {
                Console.WriteLine("Erro na atualização de Peças...");
            }
            catch
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Pecas pecas)
        {
            SqlConnection conexao = new SqlConnection(Strcon);
            string sql = "Delete from Motos where codigoPecas=@codigoPecas";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigoPecas", pecas.codigoPecas);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remoção de Peças...");
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}