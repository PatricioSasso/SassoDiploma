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
    }
}
