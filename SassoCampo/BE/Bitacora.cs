using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Bitacora
    {
        DateTime fecha;
        string description;
        TipoMensaje tipoMensaje;
        Usuario usuario;

        public Bitacora(DateTime fecha, string descripcion, TipoMensaje tipoMensaje, Usuario usuario)
        {
            Fecha = fecha;
            Descripcion = descripcion;
            TipoMensaje = tipoMensaje;
            Usuario = usuario;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Descripcion { get => description; set => description = value; }
        public TipoMensaje TipoMensaje { get => tipoMensaje; set => tipoMensaje = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
    }
    public enum TipoMensaje
    {
        MENSAJE,
        ADVERTENCIA,
        ERROR
    }
}
