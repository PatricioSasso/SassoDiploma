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

        public Idioma GetIdioma(string idiomaSeleccionado)
        {
            conexion.Open();
            query = new SqlCommand("SELECT * FROM Idioma WHERE NombreIdioma = @idioma", conexion);
            query.Parameters.AddWithValue("idioma", idiomaSeleccionado);
            Idioma idioma = new Idioma(idiomaSeleccionado);
            List<Traduccion> traducciones = new List<Traduccion>();
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    traducciones.Add(new Traduccion(reader.GetString(1), reader.GetString(2)));
                }
                idioma.Traducciones = traducciones;
            }
            conexion.Close();
            return idioma;
        }
    }
}
