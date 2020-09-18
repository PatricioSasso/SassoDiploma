using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class DALControlCambios : DAL
    {
        public void AddMemento(Memento add)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO ControlCambios VALUES (@fecha, @id, @tipo, @serializado)", conexion);
            query.Parameters.AddWithValue("fecha", add.Fecha);
            query.Parameters.AddWithValue("id", add.Estado.Id);
            query.Parameters.AddWithValue("tipo", add.Estado.GetType().ToString());
            query.Parameters.AddWithValue("serializado", add.Serializado);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public List<Memento> GetMementos(Memento get)
        {
            conexion.Open();
            List<Memento> memento = new List<Memento>();
            query = new SqlCommand("SELECT * FROM ControlCambios WHERE Id = @id and Tipo = @tipo", conexion);
            query.Parameters.AddWithValue("id", get.Estado.Id);
            query.Parameters.AddWithValue("tipo", get.Estado.GetType().ToString());
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    memento.Add(new Memento(reader.GetDateTime(0), new Hilado(int.Parse(reader.GetString(1))), (byte[])reader["Serializado"]));
                }
            }
            return memento;
        }

        public void RestoreMemento(Hilado hilado)
        {
            DALHilado dalHilado = new DALHilado();
            dalHilado.Modificar(hilado);
        }

    }
}
