using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALHilado
    {
        string connectionString = @"Data Source=PC;Initial Catalog=SassoCampo;Integrated Security=True";
        SqlConnection conexion;
        SqlCommand query;

        public DALHilado()
        {
            conexion = new SqlConnection(connectionString);
        }

        public void AltaHilado(Hilado alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO Hilado VALUES (@id, @codigo, @descripcion, @cantidad, @peso)", conexion);
            query.Parameters.AddWithValue("id", alta.Id);
            query.Parameters.AddWithValue("codigo", alta.Codigo);
            query.Parameters.AddWithValue("descripcion", alta.Descripcion);
            query.Parameters.AddWithValue("cantidad", alta.Cantidad);
            query.Parameters.AddWithValue("peso", alta.Peso);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarHilado(Hilado modificar)
        {
            conexion.Open();
            query = new SqlCommand("UPDATE Hilado SET Descripcion = @descripcion, Cantidad = @cantidad, Peso = @peso WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", modificar.Id);
            query.Parameters.AddWithValue("descripcion", modificar.Descripcion);
            query.Parameters.AddWithValue("cantidad", modificar.Cantidad);
            query.Parameters.AddWithValue("peso", modificar.Peso);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void BajaHilado(Hilado baja)
        {
            conexion.Open();
            query = new SqlCommand("DELETE FROM Hilado WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", baja.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public Hilado GetHilado(Hilado buscar)
        {
            conexion.Open();
            Hilado hilado = new Hilado();
            query = new SqlCommand("SELECT * FROM Hilado WHERE Id = @Id", conexion);
            query.Parameters.AddWithValue("Id", buscar.Id);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    hilado.Id = reader.GetInt32(0);
                    hilado.Codigo = reader.GetString(1);
                    hilado.Descripcion = reader.GetString(2);
                    hilado.Cantidad = reader.GetInt32(3);
                    hilado.Peso = reader.GetInt32(4);
                }
            }
            conexion.Close();
            return hilado;
        }

        public List<Hilado> GetListHilado()
        {
            conexion.Open();
            List<Hilado> hilado = new List<Hilado>();
            query = new SqlCommand("Select * From Hilado", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        hilado.Add(new Hilado(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetDecimal(4)));
                    }
                }
            }
            conexion.Close();
            return hilado;
        }
    }
}
