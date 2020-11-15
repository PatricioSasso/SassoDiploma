using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Traduccion
    {
        string nombre;
        string texto;

        public Traduccion(string nombre, string texto)
        {
            Nombre = nombre;
            Texto = texto;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Texto { get => texto; set => texto = value; }
    }
}
