using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Idioma
    {
        string nombre;
        List<Traduccion> traducciones;

        public Idioma(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Traduccion> Traducciones { get => traducciones; set => traducciones = value; }
    }
}
