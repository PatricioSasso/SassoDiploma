using BE;
using DAL;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PedidoProduccionGestor
    {
        DALPedidoProduccion dal;

        public PedidoProduccionGestor()
        {
            dal = new DALPedidoProduccion();
        }

        public PedidoProduccion Alta(PedidoProduccion alta)
        {
            dal.Alta(alta);
            return dal.GetLast();
        }

        public void Baja(PedidoProduccion baja)
        {
            throw new NotImplementedException();
        }

        public List<PedidoProduccion> GetList()
        {
            return dal.GetList();
        }

        public void Modificar(PedidoProduccion modificar)
        {
            throw new NotImplementedException();
        }
    }
}
