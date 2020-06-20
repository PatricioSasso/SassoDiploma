using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class AccesoADatos
    {
        string connectionString = @"Data Source=PC;Initial Catalog = SassoCampo; Integrated Security = True";
        SqlConnection conexion;
        SqlCommand query;

        public AccesoADatos()
        {
            conexion = new SqlConnection(connectionString);
        }

        public bool LogIn(string nombreUsuario, string contraseña)
        {
            conexion.Open();
            query = new SqlCommand("Select * from Usuario where Usuario_NombreUsuario = @nombreUsuario AND Usuario_Contraseña = @contraseña", conexion);
            query.Parameters.AddWithValue("nombreUsuario", nombreUsuario);
            query.Parameters.AddWithValue("contraseña", contraseña);
            var resultado = query.ExecuteScalar();
            conexion.Close();
            if (resultado != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Usuario GetUsuario(string nombreUsuario)
        {
            conexion.Open();
            query = new SqlCommand("Select * from Usuario where Usuario_NombreUsuario = @nombreUsuario", conexion);
            query.Parameters.AddWithValue("nombreUsuario", nombreUsuario);
            Usuario usuario = new Usuario();
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while(reader.Read())
                {
                    usuario = new Usuario(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), new List<Rol>());
                }
            }
            query = new SqlCommand("Select * from Rol inner Join Usuario on Rol.Rol_Id = Usuario.Rol_Id where Usuario_NombreUsuario = @nombreUsuario ", conexion);
            query.Parameters.AddWithValue("nombreUsuario", nombreUsuario);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    Rol rolAdd = new Rol(reader.GetInt32(0), reader.GetString(1), new List<Permiso>());
                    usuario.Roles.Add(rolAdd);
                }
            }
            foreach (var r in usuario.Roles)
            {
                query = new SqlCommand("Select * from Permiso inner join Rol on Permiso.Permiso_Id = Rol.Permiso_Id where Rol.Permiso_Id = @rol ", conexion);
                query.Parameters.AddWithValue("rol", r.Id);
                using (SqlDataReader readerPermiso = query.ExecuteReader())
                {
                    while (readerPermiso.Read())
                    {
                        r.Permisos.Add(new Permiso(readerPermiso.GetInt32(0), readerPermiso.GetString(1), readerPermiso.GetString(2)));
                    }
                }
            }
            return usuario;
        }
    }
}
