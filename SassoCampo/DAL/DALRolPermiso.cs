using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALRolPermiso : DAL
    {
        public void AltaRolPermiso(Rol rol, Permiso permiso)
        {
            DALRol dalRol = new DALRol();
            Rol r = dalRol.Get(rol);
            DALPermiso dalPermiso = new DALPermiso();
            Permiso p = dalPermiso.Get(permiso);
            conexion.Open();
            query = new SqlCommand("INSERT INTO [Rol-Permiso] VALUES(@rolId,@permisoId)", conexion);
            query.Parameters.AddWithValue("rolId", r.Id);
            query.Parameters.AddWithValue("permisoId", p.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void BajaRolPermiso(Rol rol, Permiso permiso)
        {
            DALRol dalRol = new DALRol();
            Rol r = dalRol.Get(rol);
            DALPermiso dalPermiso = new DALPermiso();
            Permiso p = dalPermiso.Get(permiso);
            conexion.Open();
            query = new SqlCommand("DELETE FROM [Rol-Permiso] WHERE Rol_Id = @rolId AND Permiso_Id = @permisoId", conexion);
            query.Parameters.AddWithValue("rolId", r.Id);
            query.Parameters.AddWithValue("permisoId", p.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
