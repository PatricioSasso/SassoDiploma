using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTraduccionIdioma : DAL
    {

        public DALTraduccionIdioma()
        {
        }

        public Idioma GetIdioma(Idioma idiomaSeleccionado)
        {
            conexion.Open();
            query = new SqlCommand("SELECT * FROM Idioma WHERE NombreIdioma = @idioma", conexion);
            query.Parameters.AddWithValue("idioma", idiomaSeleccionado.Nombre);
            List<Traduccion> traducciones = new List<Traduccion>();
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    traducciones.Add(new Traduccion(reader.GetString(1), reader.GetString(2)));
                }
                idiomaSeleccionado.Traducciones = traducciones;
            }
            conexion.Close();
            return idiomaSeleccionado;
        }

        public List<string> GetAllNameIdioma ()
        {
            conexion.Open();
            query = new SqlCommand("Select NombreIdioma From Idioma Group by NombreIdioma", conexion);
            List<string> idiomas = new List<string>();
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    idiomas.Add(reader.GetString(0));
                }
            }
            conexion.Close();
            return idiomas;
        }
    }
}
