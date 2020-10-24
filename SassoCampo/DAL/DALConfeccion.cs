using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL
{
    public class DALConfeccion : DAL, IABMC<Confeccion> 
    {
        public DALConfeccion()
        {
        }

        public void Alta(Confeccion alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO Confeccion VALUES (@codigo, @cantidadPrenda, @tiempo, @fecha, @prendaId)", conexion);
            query.Parameters.AddWithValue("codigo", alta.Codigo);
            query.Parameters.AddWithValue("tiempo", alta.Tiempo);
            query.Parameters.AddWithValue("fecha", alta.Fecha);
            query.Parameters.AddWithValue("prendaId", alta.Prenda.Id);
            query.Parameters.AddWithValue("cantidadPrenda", alta.Cantidad);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Baja(Confeccion baja)
        {
            conexion.Open();
            query = new SqlCommand("DELETE FROM Confeccion WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", baja.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Modificar(Confeccion modificar)
        {

        }

        public Confeccion Get(Confeccion get)
        {
            conexion.Open();
            Confeccion confeccion = new Confeccion();
            query = new SqlCommand("SELECT * FROM Confeccion WHERE Id = @Id", conexion);
            query.Parameters.AddWithValue("Id", get.Id);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    confeccion.Id = reader.GetInt32(0);
                    confeccion.Codigo = reader.GetString(1);
                    confeccion.Cantidad = reader.GetInt32(2);
                    confeccion.Tiempo = reader.GetInt32(3);
                    confeccion.Fecha = reader.GetDateTime(4);
                    confeccion.Prenda.Id = reader.GetInt32(5);
                }
            }
            conexion.Close();
            DALPrenda dalPrenda = new DALPrenda();
            confeccion.Prenda = dalPrenda.Get(confeccion.Prenda);
            return confeccion;
        }

        public List<Confeccion> GetList()
        {
            conexion.Open();
            List<Confeccion> confecciones = new List<Confeccion>();
            query = new SqlCommand("Select * From Confeccion", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    confecciones.Add(new Confeccion(reader.GetInt32(0), 
                                                    reader.GetString(1), 
                                                    reader.GetInt32(2), 
                                                    reader.GetInt32(3), 
                                                    reader.GetDateTime(4), 
                                                    new Prenda(reader.GetInt32(5))));
                }
            }
            conexion.Close();
            DALPrenda dalPrenda = new DALPrenda();
            foreach (var confeccion in confecciones)
            {
                confeccion.Prenda = dalPrenda.Get(confeccion.Prenda);
            }
            return confecciones;
        }
    }
}
