using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Memento
    {
        DateTime fecha;
        Hilado estado;
        byte[] serializado;

        public Memento()
        {

        }

        public Memento(Hilado hilado)
        {
            estado = hilado;
        }

        public Memento(DateTime fecha, Hilado estado, byte[] serializado)
        {
            Fecha = fecha;
            Estado = estado;
            Serializado = serializado;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Hilado Estado { get => estado; set => estado = value; }
        public byte[] Serializado { get => serializado; set => serializado = value; }
    }
}
