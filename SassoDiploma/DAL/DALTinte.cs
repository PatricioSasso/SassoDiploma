using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL
{
    public class DALTinte : DAL, IABMC<Tinte>
    {
        public DALTinte()
        {
        }

        public void Alta(Tinte alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO Tinte VALUES (@codigo, @descripcion, @cantidad, @color, 0)", conexion);
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
            query = new SqlCommand("UPDATE Tinte SET borrado = 1 WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", baja.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public Tinte Get(Tinte get)
        {
            conexion.Open();
            Tinte tinte = new Tinte();
            query = new SqlCommand("SELECT * FROM Tinte WHERE Id = @Id", conexion);
            query.Parameters.AddWithValue("Id", get.Id);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    tinte.Id = reader.GetInt32(0);
                    tinte.Codigo = reader.GetString(1);
                    tinte.Descripcion = reader.GetString(2);
                    tinte.Cantidad = reader.GetInt32(3);
                    tinte.Color = reader.GetString(4);
                }
            }
            conexion.Close();
            return tinte;
        }

        public List<Tinte> GetList()
        {
            conexion.Open();
            List<Tinte> tintes = new List<Tinte>();
            query = new SqlCommand("Select * From Tinte WHERE borrado = 0", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    tintes.Add(new Tinte(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4)));
                }
            }
            conexion.Close();
            return tintes;
        }
    }
}
