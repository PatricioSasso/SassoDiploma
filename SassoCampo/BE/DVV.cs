using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DVV
    {
        string nombre;
        string hash;

        public DVV()
        {

        }

        public DVV(string nombre, string hash)
        {
            Nombre = nombre;
            Hash = hash;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Hash { get => hash; set => hash = value; }
    }
}
