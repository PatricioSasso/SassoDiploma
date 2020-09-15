using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class DVVGestor
    {
        DALDVV bd;

        public DVVGestor()
        {
            bd = new DALDVV();
        }

        public void Alta(DVV dvv)
        {
            bd.Alta(dvv);
        }

        public void Modificar(DVV dvv)
        {
            dvv = bd.GetDVV(dvv);
            dvv.Hash = CalcularDVV(dvv);
            bd.Modificar(dvv);
        }

        public bool VerificarDVV(DVV dvv)
        {
            dvv = bd.GetDVV(dvv);
            if( dvv.Hash != CalcularDVV(dvv))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string CalcularDVV(DVV dvv)
        {
            ControlDeAccesoGestor controlDeAccesoGestor = new ControlDeAccesoGestor();
            string ParcialHash = "";
            foreach (var dvh in bd.GetTableDVV(dvv))
            {
                ParcialHash += dvh;
            }
            return controlDeAccesoGestor.GetHash(ParcialHash);
        }
    }
}
