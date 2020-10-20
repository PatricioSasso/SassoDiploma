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
    public class ItemProductoGestor : IABMC<ItemProducto>
    {
        DALItemProducto dal;

        public ItemProductoGestor()
        {
            dal = new DALItemProducto();
        }

        public void Alta(ItemProducto alta)
        {
            dal.Alta(alta);
        }

        public void Baja(ItemProducto baja)
        {
            throw new NotImplementedException();
        }

        public ItemProducto Get(ItemProducto get)
        {
            throw new NotImplementedException();
        }

        public List<ItemProducto> GetList()
        {
            throw new NotImplementedException();
        }

        public void Modificar(ItemProducto modificar)
        {
            throw new NotImplementedException();
        }
    }
}
