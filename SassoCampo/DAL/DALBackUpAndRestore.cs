using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALBackUpAndRestore : DAL
    {
        public DALBackUpAndRestore()
        {
        }

        public void Backup(string ruta)
        {
            conexion.Open();
            query = new SqlCommand("backup database [SassoCampo] to disk=@ruta", conexion);
            query.Parameters.AddWithValue("ruta", ruta);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Restore(string ruta)
        {
            conexion.Open();
            query = new SqlCommand($"ALTER DATABASE [SassoCampo] SET SINGLE_USER WITH ROLLBACK IMMEDIATE USE MASTER RESTORE DATABASE [SassoCampo] FROM DISK = @ruta WITH REPLACE ALTER DATABASE [SassoCampo] SET MULTI_USER", conexion);
            query.Parameters.AddWithValue("ruta", ruta);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void CheckIfDataBaseExists()
        {
            if(!VerifyDataBase())
            {
                this.conexion.ConnectionString = "Data Source=(local);Initial Catalog=master;Integrated Security=True";
                conexion.Open();
                this.query = new SqlCommand("CREATE DATABASE SassoCampo;", conexion);
                query.ExecuteNonQuery();
                conexion.Close();
                Restore(Path.GetFullPath("BaseDatos.bak"));
                this.conexion.ConnectionString= "Data Source = (local); Initial Catalog = SassoCampo; Integrated Security = True";
            }
        }


        public bool VerifyDataBase()
        {
            try
            {
                conexion.Open();
                conexion.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
