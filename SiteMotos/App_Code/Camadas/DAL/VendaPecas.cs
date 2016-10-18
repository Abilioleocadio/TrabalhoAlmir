using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Camadas.DAL
{
    public class VendaPecas
    {
        private string Strcon = Conexao.getConexao();

        public List<MODEL.VendaPecas> Select()
        {
            List<MODEL.VendaPecas> lstVendaPecas = new List<MODEL.VendaPecas>();
            SqlConnection conexao = new SqlConnection(Strcon);
            string sql = "Select * from VendaPecas";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.VendaPecas venpecas = new MODEL.VendaPecas();
                    venpecas.codigoVenda = Convert.ToInt32(reader[0].ToString());
                    venpecas.idCliente = Convert.ToInt32(reader["idCliente"].ToString());
                    venpecas.idPecas = Convert.ToInt32(reader["idPecas"].ToString());
                    venpecas.idMoto = Convert.ToInt32(reader["idMotos"].ToString());
                    lstVendaPecas.Add(venpecas);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Venda de Peças...");
            }
            finally
            {
                conexao.Close();
            }

            return lstVendaPecas;
        }

        public List<MODEL.VendaPecas> SelectById(int codigoVenda)
        {
            List<MODEL.VendaPecas> lstVendaPecas = new List<MODEL.VendaPecas>();
            SqlConnection conexao = new SqlConnection(Strcon);
            string sql = "Select * from VendaPecas where codigoVenda=@codigoVenda;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigoVenda", codigoVenda);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.VendaPecas venpecas = new MODEL.VendaPecas();
                    venpecas.codigoVenda = Convert.ToInt32(reader[0].ToString());
                    venpecas.idCliente = Convert.ToInt32(reader["idCliente"].ToString());
                    venpecas.idPecas = Convert.ToInt32(reader["idPecas"].ToString());
                    venpecas.idMoto = Convert.ToInt32(reader["idMoto"].ToString());
                    lstVendaPecas.Add(venpecas);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Vendas de Peças por ID...");
            }
            finally
            {
                conexao.Close();
            }

            return lstVendaPecas;
        }

        public void Insert(MODEL.VendaPecas venpecas)
        {
            SqlConnection conexao = new SqlConnection(Strcon);
            string sql = "Insert into VendaPecas values (@idCliente, @idPecas, @idMoto);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("idCliente", venpecas.idCliente);
            cmd.Parameters.AddWithValue("idPecas", venpecas.idPecas);
            cmd.Parameters.AddWithValue("idMoto", venpecas.idMoto);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Venda de Peças....");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void UpDate(MODEL.VendaPecas venpecas)
        {
            SqlConnection conexao = new SqlConnection(Strcon);
            string sql = "UpDate Pecas set idCliente=@idCliente";
            sql += "idPecas=@idPecas, idMoto=@idMoto";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigoVenda", venpecas.codigoVenda);
            cmd.Parameters.AddWithValue("@idCliente", venpecas.idCliente);
            cmd.Parameters.AddWithValue("@idPecas", venpecas.idPecas);
            cmd.Parameters.AddWithValue("@idMoto", venpecas.idMoto);
            conexao.Open();
            try
            {
                Console.WriteLine("Erro na atualização de Venda de Peças...");
            }
            catch
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.VendaPecas venpecas)
        {
            SqlConnection conexao = new SqlConnection(Strcon);
            string sql = "Delete from VendaPecas where codigoVenda=@codigoVenda";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigoVenda", venpecas.codigoVenda);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remoção de Venda de Peças...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}