using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTeñido : DAL
    {
        public DALTeñido()
        {
        }

        public void Alta(Teñido alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO Teñido VALUES (@id, @codigo, @tiempo, @fecha, @telaId, @tinteId, @cantidadTela, @cantidadTinte)", conexion);
            query.Parameters.AddWithValue("id", alta.Id);
            query.Parameters.AddWithValue("codigo", alta.Codigo);
            query.Parameters.AddWithValue("tiempo", alta.Tiempo);
            query.Parameters.AddWithValue("fecha", alta.Fecha);
            query.Parameters.AddWithValue("telaId", alta.Tela.Id);
            query.Parameters.AddWithValue("tinteId", alta.Tinte.Id);
            query.Parameters.AddWithValue("cantidadTela", alta.CantidadTelaUtilizada);
            query.Parameters.AddWithValue("cantidadTinte", alta.CantidadTinteUtilizada);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Baja(Teñido baja)
        {
            conexion.Open();
            query = new SqlCommand("DELETE FROM Teñido WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", baja.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public Teñido GetTeñido(Teñido buscar)
        {
            conexion.Open();
            Teñido teñido = new Teñido();
            query = new SqlCommand("SELECT * FROM Teñido WHERE Id = @Id", conexion);
            query.Parameters.AddWithValue("Id", buscar.Id);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    teñido.Id = reader.GetInt32(0);
                    teñido.Codigo = reader.GetString(1);
                    teñido.Tiempo = reader.GetInt32(2);
                    teñido.Fecha = reader.GetDateTime(3);
                    teñido.Tela.Id = reader.GetInt32(4);
                    teñido.Tinte.Id = reader.GetInt32(5);
                    teñido.CantidadTelaUtilizada = reader.GetInt32(6);
                    teñido.CantidadTinteUtilizada = reader.GetInt32(7);
                }
            }
            conexion.Close();
            DALTela dalTela = new DALTela();
            teñido.Tela = dalTela.GetTela(teñido.Tela);
            DALTinte dalTinte = new DALTinte();
            teñido.Tinte = dalTinte.GetTinte(teñido.Tinte);
            return teñido;
        }

        public List<Teñido> GetListTeñido()
        {
            conexion.Open();
            List<Teñido> teñidos = new List<Teñido>();
            query = new SqlCommand("Select * From Teñido", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    teñidos.Add(new Teñido(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(7), reader.GetInt32(6), reader.GetInt32(2), reader.GetDateTime(3), new Tinte(reader.GetInt32(5)), new Tela(reader.GetInt32(4))));
                }
            }
            conexion.Close();
            DALTinte dalTinte = new DALTinte();
            DALTela dalTela = new DALTela();
            foreach (var teñido in teñidos)
            {
                teñido.Tinte = dalTinte.GetTinte(teñido.Tinte);
                teñido.Tela = dalTela.GetTela(teñido.Tela);
            }
            return teñidos;
        }
    }
}
