using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALProducto : DAL, IABMC<Producto>
    {
        public DALProducto()
        {
        }

        public void Alta(Producto alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO Producto VALUES (@codigo, @descripcion, @cantidad)", conexion);
            query.Parameters.AddWithValue("codigo", alta.Codigo);
            query.Parameters.AddWithValue("descripcion", alta.Descripcion);
            query.Parameters.AddWithValue("cantidad", alta.Cantidad);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Modificar(Producto modificar)
        {
            conexion.Open();
            query = new SqlCommand("UPDATE Producto SET Producto_Descripcion = @descripcion, Producto_Cantidad = @cantidad, WHERE Producto_Id = @id", conexion);
            query.Parameters.AddWithValue("id", modificar.Id);
            query.Parameters.AddWithValue("descripcion", modificar.Descripcion);
            query.Parameters.AddWithValue("cantidad", modificar.Cantidad);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Baja(Producto baja)
        {
            conexion.Open();
            query = new SqlCommand("DELETE FROM Producto WHERE Producto_Id = @id", conexion);
            query.Parameters.AddWithValue("id", baja.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public Producto Get(Producto get)
        {
            conexion.Open();
            Producto producto = new Producto();
            query = new SqlCommand("SELECT * FROM Producto WHERE Id = @Id", conexion);
            query.Parameters.AddWithValue("Id", get.Id);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    producto.Id = reader.GetInt32(0);
                    producto.Codigo = reader.GetString(1);
                    producto.Descripcion = reader.GetString(2);
                    producto.Cantidad = reader.GetInt32(3);
                }
            }
            conexion.Close();
            return producto;
        }

        public List<Producto> GetList()
        {
            conexion.Open();
            List<Producto> producto = new List<Producto>();
            query = new SqlCommand("Select * From Producto", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    producto.Add(new Producto(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3))); ;
                }
            }
            conexion.Close();
            return producto;
        }
    }
}
