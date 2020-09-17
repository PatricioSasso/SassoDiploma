using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class DALBitacora : DAL
    {
        public void Registrar(Bitacora bitacora)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO Bitacora VALUES (@fecha, @descripcion, @tipoMensaje, @nombreUsuario)", conexion);
            query.Parameters.AddWithValue("fecha", bitacora.Fecha);
            query.Parameters.AddWithValue("descripcion", bitacora.Descripcion);
            query.Parameters.AddWithValue("tipoMensaje", bitacora.TipoMensaje.ToString());
            query.Parameters.AddWithValue("nombreUsuario", bitacora.Usuario.NombreUsuario);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public List<Bitacora> GetAll()
        {
            conexion.Open();
            List<Bitacora> bitacora = new List<Bitacora>();
            query = new SqlCommand("Select * From Bitacora", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                DALUsuario dalUsuario = new DALUsuario();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        bitacora.Add(new Bitacora(reader.GetDateTime(0), reader.GetString(1), (TipoMensaje) Enum.Parse(typeof(TipoMensaje), reader.GetString(2).ToString()) , dalUsuario.Get(new Usuario(reader.GetString(3)))));
                    }
                }
            }
            conexion.Close();
            return bitacora;
        }

        public List<Bitacora> BuscarNombreUsuario(string filtro)
        {
            conexion.Open();
            List<Bitacora> bitacora = new List<Bitacora>();
            filtro += "%";
            query = new SqlCommand($"Select * From Bitacora where NombreUsuario like @filtro", conexion);
            query.Parameters.AddWithValue("filtro", filtro);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                DALUsuario dalUsuario = new DALUsuario();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        bitacora.Add(new Bitacora(reader.GetDateTime(0), reader.GetString(1), (TipoMensaje)Enum.Parse(typeof(TipoMensaje), reader.GetString(2).ToString()), dalUsuario.Get(new Usuario(reader.GetString(3)))));
                    }
                }
            }
            conexion.Close();
            return bitacora;
        }

        public List<Bitacora> BuscarFecha(string filtro)
        {
            conexion.Open();
            List<Bitacora> bitacora = new List<Bitacora>();
            filtro += "%";
            query = new SqlCommand($"SELECT * FROM Bitacora WHERE CONVERT(VARCHAR(25), Fecha, 121) LIKE @filtro", conexion);
            query.Parameters.AddWithValue("filtro", filtro);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                DALUsuario dalUsuario = new DALUsuario();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        bitacora.Add(new Bitacora(reader.GetDateTime(0), reader.GetString(1), (TipoMensaje)Enum.Parse(typeof(TipoMensaje), reader.GetString(2).ToString()), dalUsuario.Get(new Usuario(reader.GetString(3)))));
                    }
                }
            }
            conexion.Close();
            return bitacora;
        }
    }
}
