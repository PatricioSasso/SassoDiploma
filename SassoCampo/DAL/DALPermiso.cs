using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPermiso : DAL , IABMC<Permiso>
    {

        public Permiso Get(Permiso get)
        {
            conexion.Open();
            Permiso permiso = new Permiso();
            query = new SqlCommand("SELECT * FROM Permiso WHERE Nombre = @permisoNombre", conexion);
            query.Parameters.AddWithValue("permisoNombre", get.Nombre.ToLower());
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

        public List<Permiso> GetList()
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

        public List<Permiso> GetList(Rol rol)
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

        public void Alta(Permiso alta)
        {

        }

        public void Baja(Permiso baja)
        {

        }

        public void Modificar(Permiso modificar)
        {
            
        }
    }
}
