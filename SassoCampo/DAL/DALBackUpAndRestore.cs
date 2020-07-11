using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALBackUpAndRestore
    {
        string connectionString = @"Data Source=PC;Initial Catalog=SassoCampo;Integrated Security=True";
        SqlConnection conexion;
        SqlCommand query;

        public DALBackUpAndRestore()
        {
            conexion = new SqlConnection(connectionString);
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
    }
}
