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
        string estado;

        public PedidoProduccion()
        {

        }

        public PedidoProduccion(int id)
        {
            Id = id;
        }

        public PedidoProduccion(DateTime fechaProduccion)
        {
            FechaProduccion = fechaProduccion;
            Estado = "Pendiente";
        }

        public PedidoProduccion(int id, DateTime fechaProduccion, List<ItemProducto> productos)
        {
            Id = id;
            FechaProduccion = fechaProduccion;
            itemProductos = productos;
            Estado = "Pendiente";
        }

        public int Id { get => id; set => id = value; }
        public DateTime FechaProduccion { get => fechaProduccion; set => fechaProduccion = value; }
        public List<ItemProducto> ItemProductos { get => itemProductos; set => itemProductos = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
