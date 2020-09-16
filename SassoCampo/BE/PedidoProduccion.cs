using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PedidoProduccion
    {
        int id;
        DateTime fechaProduccion;
        List<ItemProducto> itemProductos;

        public PedidoProduccion(int id)
        {
            Id = id;
        }

        public PedidoProduccion(int id, DateTime fechaProduccion, List<ItemProducto> productos)
        {
            Id = id;
            FechaProduccion = fechaProduccion;
            itemProductos = productos;
        }

        public int Id { get => id; set => id = value; }
        public DateTime FechaProduccion { get => fechaProduccion; set => fechaProduccion = value; }
        public List<ItemProducto> ItemProductos { get => itemProductos; set => itemProductos = value; }
    }
}
