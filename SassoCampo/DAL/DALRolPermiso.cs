using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class DALRolPermiso : DAL
    {
        public DALRolPermiso()
        {
        }

        public void AltaRol(Rol alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO Rol VALUES(@id, @nombre)", conexion);
            query.Parameters.AddWithValue("id", alta.Id);
            query.Parameters.AddWithValue("nombre", alta.Nombre);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarRol(Rol modificar)
        {
            conexion.Open();
            query = new SqlCommand("UPDATE Rol SET Nombre = @nuevoNombre WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", modificar.Id);
            query.Parameters.AddWithValue("nuevoNombre", modificar.Nombre);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void BajaRol(Rol baja)
        {
            conexion.Open();
            query = new SqlCommand("DELETE FROM Rol WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", baja.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public Rol GetRol(Rol buscar)
        {
            conexion.Open();
            Rol rol = new Rol();
            query = new SqlCommand("SELECT * FROM Rol WHERE Id = @Id", conexion);
            query.Parameters.AddWithValue("Id", buscar.Id);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    rol.Id = reader.GetInt32(0);
                    rol.Nombre = reader.GetString(1);
                }
            }
            conexion.Close();
            rol.Permisos = GetListPermiso(rol);
            return rol;
        }

        public List<Rol> GetListRol()
        {
            conexion.Open();
            List<Rol> roles = new List<Rol>();
            query = new SqlCommand("Select * From Rol", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    roles.Add(new Rol(reader.GetInt32(0), reader.GetString(1), new List<Permiso>()));
                }
            }
            conexion.Close();
            foreach (var rol in roles)
            {
                rol.Permisos = GetListPermiso(rol);
            }
            return roles;
        }

        public Permiso GetPermiso(Permiso buscar)
        {
            conexion.Open();
            Permiso permiso = new Permiso();
            query = new SqlCommand("SELECT * FROM Permiso WHERE Nombre = @permisoNombre", conexion);
            query.Parameters.AddWithValue("permisoNombre", buscar.Nombre.ToLower());
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    permiso.Id = reader.GetInt32(0);
                    permiso.Nombre = reader.GetString(1);
                    permiso.Descripcion = reader.GetString(2);
                }
            }
            conexion.Close();
            return permiso;
        }

        public List<Permiso> GetListPermiso()
        {
            conexion.Open();
            List<Permiso> permisos = new List<Permiso>();
            query = new SqlCommand("Select * From Permiso", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    permisos.Add(new Permiso(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                }
            }
            conexion.Close();
            return permisos;
        }

        public List<Permiso> GetListPermiso(Rol rol)
        {
            conexion.Open();
            List<Permiso> permisos = new List<Permiso>();
            List<int> permisosId = new List<int>();
            query = new SqlCommand("Select Permiso_Id from [Rol-Permiso] where Rol_Id = @rolId", conexion);
            query.Parameters.AddWithValue("rolId", rol.Id);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    permisosId.Add(reader.GetInt32(0));
                }
            }
            foreach (var id in permisosId)
            {
                query = new SqlCommand("Select * from Permiso where Id = @id", conexion);
                query.Parameters.AddWithValue("id", id);
                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        permisos.Add(new Permiso(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                    }
                }
            }
            conexion.Close();
            return permisos;
        }

        public void AltaRolPermiso(Rol rol, Permiso permiso)
        {
            Rol r = GetRol(rol);
            Permiso p = GetPermiso(permiso);
            conexion.Open();
            query = new SqlCommand("INSERT INTO [Rol-Permiso] VALUES(@rolId,@permisoId)", conexion);
            query.Parameters.AddWithValue("rolId", r.Id);
            query.Parameters.AddWithValue("permisoId", p.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void BajaRolPermiso(Rol rol, Permiso permiso)
        {
            Rol r = GetRol(rol);
            Permiso p = GetPermiso(permiso);
            conexion.Open();
            query = new SqlCommand("DELETE FROM [Rol-Permiso] WHERE Rol_Id = @rolId AND Permiso_Id = @permisoId", conexion);
            query.Parameters.AddWithValue("rolId", r.Id);
            query.Parameters.AddWithValue("permisoId", p.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
