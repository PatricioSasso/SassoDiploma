using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTinte : DAL
    {
        public DALTinte()
        {
        }

        public void Alta(Tinte alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO Tinte VALUES (@id, @codigo, @descripcion, @color, @cantidad)", conexion);
            query.Parameters.AddWithValue("id", alta.Id);
            query.Parameters.AddWithValue("codigo", alta.Codigo);
            query.Parameters.AddWithValue("descripcion", alta.Descripcion);
            query.Parameters.AddWithValue("cantidad", alta.Cantidad);
            query.Parameters.AddWithValue("color", alta.Color);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Modificar(Tinte modificar)
        {
            conexion.Open();
            query = new SqlCommand("UPDATE Tinte SET Descripcion = @descripcion, Cantidad = @cantidad, Color = @color WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", modificar.Id);
            query.Parameters.AddWithValue("descripcion", modificar.Descripcion);
            query.Parameters.AddWithValue("cantidad", modificar.Cantidad);
            query.Parameters.AddWithValue("color", modificar.Color);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Baja(Tinte baja)
        {
            conexion.Open();
            query = new SqlCommand("DELETE FROM Tinte WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", baja.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public Tinte GetTinte(Tinte buscar)
        {
            conexion.Open();
            Tinte tinte = new Tinte();
            query = new SqlCommand("SELECT * FROM Tinte WHERE Id = @Id", conexion);
            query.Parameters.AddWithValue("Id", buscar.Id);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    tinte.Id = reader.GetInt32(0);
                    tinte.Codigo = reader.GetString(1);
                    tinte.Descripcion = reader.GetString(2);
                    tinte.Cantidad = reader.GetInt32(4);
                    tinte.Color = reader.GetString(3);
                }
            }
            conexion.Close();
            return tinte;
        }

        public List<Tinte> GetListTinte()
        {
            conexion.Open();
            List<Tinte> tintes = new List<Tinte>();
            query = new SqlCommand("Select * From Tinte", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    tintes.Add(new Tinte(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(4), reader.GetString(3)));
                }
            }
            conexion.Close();
            return tintes;
        }
    }
}
