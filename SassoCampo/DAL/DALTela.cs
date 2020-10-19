using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTela : DAL, IABMC<Tela>
    {
        public DALTela()
        {
        }

        public void Alta(Tela alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO Tela VALUES (@codigo, @descripcion, @cantidad, @color, @teñido)", conexion);
            query.Parameters.AddWithValue("codigo", alta.Codigo);
            query.Parameters.AddWithValue("descripcion", alta.Descripcion);
            query.Parameters.AddWithValue("cantidad", alta.Cantidad);
            query.Parameters.AddWithValue("color", alta.Color);
            query.Parameters.AddWithValue("teñido", alta.Teñido);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Modificar(Tela modificar)
        {
            conexion.Open();
            query = new SqlCommand("UPDATE Tela SET Descripcion = @descripcion, Cantidad = @cantidad, Color = @color, Teñido = @teñido WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", modificar.Id);
            query.Parameters.AddWithValue("descripcion", modificar.Descripcion);
            query.Parameters.AddWithValue("cantidad", modificar.Cantidad);
            query.Parameters.AddWithValue("color", modificar.Color);
            query.Parameters.AddWithValue("teñido", modificar.Teñido);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Baja(Tela baja)
        {
            conexion.Open();
            query = new SqlCommand("DELETE FROM Tela WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", baja.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public Tela Get(Tela get)
        {
            conexion.Open();
            Tela tela = new Tela();
            query = new SqlCommand("SELECT * FROM Tela WHERE Id = @Id", conexion);
            query.Parameters.AddWithValue("Id", get.Id);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    tela.Id = reader.GetInt32(0);
                    tela.Codigo = reader.GetString(1);
                    tela.Descripcion = reader.GetString(2);
                    tela.Cantidad = reader.GetInt32(3);
                    tela.Color = reader.GetString(4);
                    tela.Teñido = reader.GetBoolean(5);
                }
            }
            conexion.Close();
            return tela;
        }

        public List<Tela> GetList()
        {
            conexion.Open();
            List<Tela> tela = new List<Tela>();
            query = new SqlCommand("Select * From Tela", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    tela.Add(new Tela(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4), reader.GetBoolean(5))); ;
                }
            }
            conexion.Close();
            return tela;
        }
    }
}
