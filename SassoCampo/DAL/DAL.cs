using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class DAL
    {
        protected string connectionString = "Data Source=DESKTOP-VOPCEH3;Initial Catalog=SassoCampo;Integrated Security=True";
        protected SqlConnection conexion;
        protected SqlCommand query;

        public DAL()
        {
            conexion = new SqlConnection(connectionString);
        }
    }
}
