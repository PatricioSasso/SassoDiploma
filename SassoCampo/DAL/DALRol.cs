using Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class DALRol : DAL, IABMC<Rol>
    {
        public DALRol()
        {
        }

        public void Alta(Rol alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO Rol VALUES(@id, @nombre)", conexion);
            query.Parameters.AddWithValue("id", alta.Id);
            query.Parameters.AddWithValue("nombre", alta.Nombre);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Modificar(Rol modificar)
        {
            conexion.Open();
            query = new SqlCommand("UPDATE Rol SET Nombre = @nuevoNombre WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", modificar.Id);
            query.Parameters.AddWithValue("nuevoNombre", modificar.Nombre);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Baja(Rol baja)
        {
            conexion.Open();
            query = new SqlCommand("DELETE FROM Rol WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", baja.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public Rol Get(Rol buscar)
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
            DALPermiso dalPermiso = new DALPermiso();
            rol.Permisos = dalPermiso.GetList(rol);
            return rol;
        }

        public List<Rol> GetList()
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
            DALPermiso dalPermiso = new DALPermiso();
            foreach (var rol in roles)
            {
                rol.Permisos = dalPermiso.GetList(rol);
            }
            return roles;
        }
    }
}
