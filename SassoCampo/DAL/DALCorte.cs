using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCorte : DAL
    {
        public DALCorte()
        {
        }

        public void Alta(Corte alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO Corte VALUES (@id, @codigo, @talle, @tiempo, @fecha, @cantidadTela, @dimensiones, @telaId)", conexion);
            query.Parameters.AddWithValue("id", alta.Id);
            query.Parameters.AddWithValue("codigo", alta.Codigo);
            query.Parameters.AddWithValue("talle", alta.Talle);
            query.Parameters.AddWithValue("tiempo", alta.Tiempo);
            query.Parameters.AddWithValue("fecha", alta.Fecha);
            query.Parameters.AddWithValue("cantidadTela", alta.CantidadTela);
            query.Parameters.AddWithValue("dimensiones", alta.Dimensiones);
            query.Parameters.AddWithValue("telaId", alta.Tela.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Baja(Corte baja)
        {
            conexion.Open();
            query = new SqlCommand("DELETE FROM Corte WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", baja.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public Corte GetCorte(Corte buscar)
        {
            conexion.Open();
            Corte corte = new Corte();
            query = new SqlCommand("SELECT * FROM Corte WHERE Id = @Id", conexion);
            query.Parameters.AddWithValue("Id", buscar.Id);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    corte.Id = reader.GetInt32(0);
                    corte.Codigo = reader.GetString(1);
                    corte.Talle = reader.GetString(2);
                    corte.Tiempo = reader.GetInt32(3);
                    corte.Fecha = reader.GetDateTime(4);
                    corte.CantidadTela = reader.GetInt32(5);
                    corte.Dimensiones = reader.GetInt32(6);
                    corte.Tela.Id = reader.GetInt32(7);
                }
            }
            conexion.Close();
            DALTela dalTela = new DALTela();
            corte.Tela = dalTela.GetTela(corte.Tela);
            return corte;
        }

        public List<Corte> GetListCorte()
        {
            conexion.Open();
            List<Corte> cortes = new List<Corte>();
            query = new SqlCommand("Select * From Corte", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    cortes.Add(new Corte(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetDateTime(4), reader.GetInt32(5), reader.GetInt32(6), new Tela(reader.GetInt32(7))));
                }
            }
            conexion.Close();
            DALTela dalTela = new DALTela();
            foreach (var corte in cortes)
            {
                corte.Tela = dalTela.GetTela(corte.Tela);
            }
            return cortes;
        }
    }
}
