using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace Service
{
    public class BitacoraGestor
    {
        DALBitacora dalBitacora;

        public BitacoraGestor()
        {
            dalBitacora = new DALBitacora();
        }

        public void Registrar(string descripcion, TipoMensaje tipoBitacora, Usuario usuario)
        {
            dalBitacora.Registrar(new Bitacora(DateTime.Now, descripcion, tipoBitacora, usuario));
        }

        public List<string> GetAll()
        {
            List<string> datos = new List<string>();
            foreach (var d in dalBitacora.GetAll())
            {
                datos.Add(d.Fecha + " , " + d.TipoMensaje.ToString() + " : " + d.Descripcion);
            }
            return datos;
        }

        public List<string> BuscarNombreUsuario(string filtro)
        {
            List<string> datos = new List<string>();
            foreach (var d in dalBitacora.BuscarNombreUsuario(filtro))
            {
                datos.Add(d.Fecha + " , " + d.TipoMensaje.ToString() + " : " + d.Descripcion);
            }
            return datos;
        }

        public List<string> BuscarFecha(string filtro)
        {
            List<string> datos = new List<string>();
            foreach (var d in dalBitacora.BuscarFecha(filtro))
            {
                datos.Add(d.Fecha + " , " + d.TipoMensaje.ToString() + " : " + d.Descripcion);
            }
            return datos;
        }
    }
}
