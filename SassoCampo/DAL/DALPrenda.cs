using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPrenda : DAL
    {
        public DALPrenda()
        {
        }

        public void Alta(Prenda alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO Prenda VALUES (@id, @codigo, @descripcion, @cantidad, @talle, @confeccionada)", conexion);
            query.Parameters.AddWithValue("id", alta.Id);
            query.Parameters.AddWithValue("codigo", alta.Codigo);
            query.Parameters.AddWithValue("descripcion", alta.Descripcion);
            query.Parameters.AddWithValue("cantidad", alta.Cantidad);
            query.Parameters.AddWithValue("talle", alta.Talle);
            query.Parameters.AddWithValue("confeccionada", alta.Confeccionada);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Modificar(Prenda modificar)
        {
            conexion.Open();
            query = new SqlCommand("UPDATE Prenda SET Descripcion = @descripcion, Cantidad = @cantidad, Talle = @talle, Confeccionada = @confeccionada WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", modificar.Id);
            query.Parameters.AddWithValue("descripcion", modificar.Descripcion);
            query.Parameters.AddWithValue("cantidad", modificar.Cantidad);
            query.Parameters.AddWithValue("talle", modificar.Talle);
            query.Parameters.AddWithValue("confeccionada", modificar.Confeccionada);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Baja(Prenda baja)
        {
            conexion.Open();
            query = new SqlCommand("DELETE FROM Prenda WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", baja.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public Prenda GetPrenda(Prenda buscar)
        {
            conexion.Open();
            Prenda prenda = new Prenda();
            query = new SqlCommand("SELECT * FROM Prenda WHERE Id = @Id", conexion);
            query.Parameters.AddWithValue("Id", buscar.Id);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    prenda.Id = reader.GetInt32(0);
                    prenda.Codigo = reader.GetString(1);
                    prenda.Descripcion = reader.GetString(2);
                    prenda.Cantidad = reader.GetInt32(3);
                    prenda.Talle = reader.GetString(4);
                    prenda.Confeccionada = reader.GetBoolean(5);
                }
            }
            conexion.Close();
            return prenda;
        }

        public List<Prenda> GetListPrenda()
        {
            conexion.Open();
            List<Prenda> prenda = new List<Prenda>();
            query = new SqlCommand("Select * From Prenda", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    prenda.Add(new Prenda(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4), reader.GetBoolean(5))); ;
                }
            }
            conexion.Close();
            return prenda;
        }
    }
}
