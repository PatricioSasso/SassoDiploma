using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTejido : DAL, IABMC<Tejido>
    {
        public DALTejido()
        {
        }

        public void Alta(Tejido alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO Tejido VALUES (@id, @codigo, @tiempo, @fecha, @hiladoId, @cantUtilizada, @areaTela )", conexion);
            query.Parameters.AddWithValue("id", alta.Id);
            query.Parameters.AddWithValue("codigo", alta.Codigo);
            query.Parameters.AddWithValue("tiempo", alta.Tiempo);
            query.Parameters.AddWithValue("fecha", alta.Fecha);
            query.Parameters.AddWithValue("hiladoId", alta.Hilado.Id);
            query.Parameters.AddWithValue("cantUtilizada", alta.CantidadUtilizada);
            query.Parameters.AddWithValue("areaTela", alta.AreaTela);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Baja(Tejido baja)
        {
            conexion.Open();
            query = new SqlCommand("DELETE FROM Tejido WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", baja.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Modificar(Tejido modificar)
        {

        }

        public Tejido Get(Tejido get)
        {
            conexion.Open();
            Tejido tejido = new Tejido();
            query = new SqlCommand("SELECT * FROM Tejido WHERE Id = @Id", conexion);
            query.Parameters.AddWithValue("Id", get.Id);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    tejido.Id = reader.GetInt32(0);
                    tejido.Codigo = reader.GetString(1);
                    tejido.Tiempo = reader.GetInt32(2);
                    tejido.Fecha = reader.GetDateTime(3);
                    tejido.Hilado.Id = reader.GetInt32(4);
                    tejido.CantidadUtilizada = reader.GetInt32(5);
                    tejido.AreaTela = reader.GetInt32(6);
                }
            }
            conexion.Close();
            DALHilado dalHilado = new DALHilado();
            tejido.Hilado = dalHilado.Get(tejido.Hilado);
            return tejido;
        }

        public List<Tejido> GetList()
        {
            conexion.Open();
            List<Tejido> tejidos = new List<Tejido>();
            query = new SqlCommand("Select * From Tejido", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    tejidos.Add(new Tejido(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(5), reader.GetInt32(2), reader.GetInt32(6), reader.GetDateTime(3), new Hilado(reader.GetInt32(4), "", "", 1, 1)));
                }
            }
            conexion.Close();
            DALHilado dalHilado = new DALHilado();
            foreach (var tejido in tejidos)
            {
                tejido.Hilado = dalHilado.Get(tejido.Hilado);
            }
            return tejidos;
        }
    }
}
