using Interfaces;
using Microsoft.SqlServer.Server;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;

namespace DAL
{
    public class DALUsuario : DAL, IABMC<Usuario>
    {
        public DALUsuario()
        {
        }

        public bool LogIn(string nombreUsuario, string contraseña)
        {
            conexion.Open();
            query = new SqlCommand("Select * from Usuario where NombreUsuario = @nombreUsuario AND Contraseña = @contraseña", conexion);
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

        public void Alta(Usuario alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO Usuario VALUES (@nombreUsuario, @contraseña, @nombre, @apellido, @DVH, @rolId)", conexion);
            query.Parameters.AddWithValue("nombreUsuario", alta.NombreUsuario);
            query.Parameters.AddWithValue("contraseña", alta.Contraseña);
            query.Parameters.AddWithValue("nombre", alta.Nombre);
            query.Parameters.AddWithValue("apellido", alta.Apellido);
            query.Parameters.AddWithValue("rolId", alta.Rol.Id);
            query.Parameters.AddWithValue("DVH", alta.DVH);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Baja(Usuario baja)
        {
            conexion.Open();
            query = new SqlCommand("DELETE FROM Usuario WHERE NombreUsuario = @nombreUsuario", conexion);
            query.Parameters.AddWithValue("nombreUsuario", baja.NombreUsuario);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Modificar(Usuario modificar)
        {
            conexion.Open();
            query = new SqlCommand("UPDATE Usuario SET Nombre = @nombre, Apellido = @apellido, Rol_Id = @rolId, DVH = @DVH WHERE NombreUsuario = @nombreUsuario", conexion);
            query.Parameters.AddWithValue("nombreUsuario", modificar.NombreUsuario);
            query.Parameters.AddWithValue("nombre", modificar.Nombre);
            query.Parameters.AddWithValue("apellido", modificar.Apellido);
            query.Parameters.AddWithValue("rolId", modificar.Rol.Id);
            query.Parameters.AddWithValue("DVH", modificar.DVH);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public Usuario Get(Usuario get)
        {
            conexion.Open();
            query = new SqlCommand("Select * from Usuario where NombreUsuario = @nombreUsuario", conexion);
            query.Parameters.AddWithValue("nombreUsuario", get.NombreUsuario);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    get = new Usuario(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), new Rol(reader.GetInt32(5), "", new List<Permiso>()), reader.GetString(4));
                }
            }
            conexion.Close();
            DALRol dalRolPermiso = new DALRol();
            get.Rol = dalRolPermiso.Get(get.Rol);
            return get;
        }

        public List<Usuario> GetList()
        {
            conexion.Open();
            query = new SqlCommand("Select * from Usuario", conexion);
            List<Usuario> usuarios = new List<Usuario>();
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    usuarios.Add(new Usuario(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), new Rol(reader.GetInt32(5), "", new List<Permiso>()), reader.GetString(4)));
                }
            }
            conexion.Close();
            foreach (var usuario in usuarios)
            {
                DALRol dalRolPermiso = new DALRol();
                usuario.Rol = dalRolPermiso.Get(usuario.Rol);
            }
            return usuarios;
        }

    }
}
