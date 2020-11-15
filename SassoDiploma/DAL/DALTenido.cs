using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTenido : DAL, IABMC<Tenido>
    {
        public DALTenido()
        {
        }

        public void Alta(Tenido alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO Teñido VALUES (@codigo, @cantidadTela, @cantidadTinte, @tiempo, @fecha, @telaId, @tinteId)", conexion);
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

        public void Baja(Tenido baja)
        {
            conexion.Open();
            query = new SqlCommand("DELETE FROM Teñido WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", baja.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Modificar(Tenido modificar)
        {

        }

        public Tenido Get(Tenido get)
        {
            conexion.Open();
            Tenido teñido = new Tenido();
            query = new SqlCommand("SELECT * FROM Teñido WHERE Id = @Id", conexion);
            query.Parameters.AddWithValue("Id", get.Id);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    teñido.Id = reader.GetInt32(0);
                    teñido.Codigo = reader.GetString(1);
                    teñido.CantidadTelaUtilizada = reader.GetInt32(2);
                    teñido.CantidadTinteUtilizada = reader.GetInt32(3);
                    teñido.Tiempo = reader.GetInt32(4);
                    teñido.Fecha = reader.GetDateTime(5);
                    teñido.Tela.Id = reader.GetInt32(6);
                    teñido.Tinte.Id = reader.GetInt32(7);
                }
            }
            conexion.Close();
            DALTela dalTela = new DALTela();
            teñido.Tela = dalTela.Get(teñido.Tela);
            DALTinte dalTinte = new DALTinte();
            teñido.Tinte = dalTinte.Get(teñido.Tinte);
            return teñido;
        }

        public List<Tenido> GetList()
        {
            conexion.Open();
            List<Tenido> teñidos = new List<Tenido>();
            query = new SqlCommand("Select * From Teñido", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    teñidos.Add(new Tenido(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(3), reader.GetInt32(2), reader.GetInt32(4), reader.GetDateTime(5), new Tinte(reader.GetInt32(7)), new Tela(reader.GetInt32(6))));
                }
            }
            conexion.Close();
            DALTinte dalTinte = new DALTinte();
            DALTela dalTela = new DALTela();
            foreach (var teñido in teñidos)
            {
                teñido.Tinte = dalTinte.Get(teñido.Tinte);
                teñido.Tela = dalTela.Get(teñido.Tela);
            }
            return teñidos;
        }
    }
}
