using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Camadas.DAL
{
    public class Motos
    {
        private string Strcon = Conexao.getConexao();

        public List<MODEL.Motos> Select()
        {
            List<MODEL.Motos> lstMotos = new List<MODEL.Motos>();
            SqlConnection conexao = new SqlConnection(Strcon);
            string sql = "Select * from Motos";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Motos motos = new MODEL.Motos();
                    motos.codigoMoto = Convert.ToInt32(reader[0].ToString());
                    motos.motoMarca = reader["motoMarca"].ToString();
                    motos.situacao = reader["situacao"].ToString();
                    motos.idCliente = Convert.ToInt32(reader["idCliente"].ToString());                    
                    motos.motoModelo = reader["motoModelo"].ToString();
                    motos.anoMoto = reader["anoMoto"].ToString();
                    lstMotos.Add(motos);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Motos...");
            }
            finally
            {
                conexao.Close();
            }

            return lstMotos;
        }

        public List<MODEL.Motos> SelectById(int codigoMoto)
        {
            List<MODEL.Motos> lstMotos = new List<MODEL.Motos>();
            SqlConnection conexao = new SqlConnection(Strcon);
            string sql = "Select * from Motos where codigoMoto=@codigoMoto;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigoMoto", codigoMoto);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Motos motos = new MODEL.Motos();
                    motos.codigoMoto = Convert.ToInt32(reader[0].ToString());
                    motos.motoMarca = reader["motoMarca"].ToString();
                    motos.situacao = reader["situacao"].ToString();
                    motos.idCliente = Convert.ToInt32(reader["idCliente"].ToString());
                    motos.motoModelo = reader["motoModelo"].ToString();
                    motos.anoMoto = reader["anoMoto"].ToString();
                    lstMotos.Add(motos);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Motos por ID...");
            }
            finally
            {
                conexao.Close();
            }

            return lstMotos;
        }

        public void Insert (MODEL.Motos motos)
        {
            SqlConnection conexao = new SqlConnection(Strcon);
            string sql = "Insert into Motos values (@motoMarca, @situacao, @idCliente, @motoModelo, @anoMoto);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("motoMarca", motos.motoMarca);
            cmd.Parameters.AddWithValue("situacao", motos.situacao);
            cmd.Parameters.AddWithValue("idCliente", motos.idCliente);
            cmd.Parameters.AddWithValue("motoModelo", motos.motoModelo);
            cmd.Parameters.AddWithValue("anoMoto", motos.anoMoto);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch 
            {
                Console.WriteLine("Deu erro na inserção de Motos....");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void UpDate(MODEL.Motos motos)
        {
            SqlConnection conexao = new SqlConnection(Strcon);
            string sql = "Update Motos set motoMarca=@motoMarca,";
            sql += "situacao=@situacao, idCliente=@idCliente,";
            sql += "motoModelo=@motoModelo, anoMoto=@anoMoto";
            sql += "where codigoMoto=@codigoMoto;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigoMoto", motos.codigoMoto);
            cmd.Parameters.AddWithValue("@situacao", motos.motoMarca);
            cmd.Parameters.AddWithValue("@situacao", motos.situacao);
            cmd.Parameters.AddWithValue("@idCliente", motos.idCliente);
            cmd.Parameters.AddWithValue("@motoModelo", motos.motoModelo);
            cmd.Parameters.AddWithValue("@anoMoto", motos.anoMoto);
            conexao.Open();
            try
            {
                Console.WriteLine("Erro na atualização de Motos...");
            }
            catch
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Motos motos)
        {
            SqlConnection conexao = new SqlConnection(Strcon);
            string sql = "Delete from Motos where codigoMoto=@codigoMoto";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigoMoto", motos.codigoMoto);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remoção de Motos...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
