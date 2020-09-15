using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALDVV : DAL
    {
        public DALDVV()
        {
        }

        public void Alta(BE.DVV alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO DVV VALUES (@nombre, @hash)", conexion);
            query.Parameters.AddWithValue("nombre", alta.Nombre);
            query.Parameters.AddWithValue("hash", alta.Hash);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Modificar(DVV modificar)
        {
            conexion.Open();
            query = new SqlCommand("UPDATE DVV SET Hash = @hash WHERE Nombre = @nombre", conexion);
            query.Parameters.AddWithValue("nombre", modificar.Nombre);
            query.Parameters.AddWithValue("hash", modificar.Hash);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public DVV GetDVV(DVV buscar)
        {
            conexion.Open();
            DVV dvv = new DVV();
            query = new SqlCommand("SELECT * FROM DVV WHERE Nombre = @nombre", conexion);
            query.Parameters.AddWithValue("nombre", buscar.Nombre);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    dvv.Nombre = reader.GetString(0);
                    dvv.Hash = reader.GetString(1);
                }
            }
            conexion.Close();
            return dvv;
        }

        public List<string> GetTableDVV(DVV buscar)
        {
            conexion.Open();
            List<string> dvhs = new List<string>();
            if (buscar.Nombre == null) { return dvhs; }
            query = new SqlCommand("SELECT DVH FROM " + buscar.Nombre, conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    dvhs.Add(reader.GetString(0));
                }
            }
            conexion.Close();
            return dvhs;
        }
    }
}
