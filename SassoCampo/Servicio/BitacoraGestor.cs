using System;
using System.Collections.Generic;
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
    }
}
