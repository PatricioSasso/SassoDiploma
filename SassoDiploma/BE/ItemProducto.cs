using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ItemProducto
    {
        int cantidad;
        Producto producto;
        PedidoProduccion pedido;

        public ItemProducto()
        {

        }

        public ItemProducto(int cantidad, Producto producto)
        {
            Cantidad = cantidad;
            Producto = producto;
        }

        public ItemProducto(int cantidad, Producto producto, PedidoProduccion pedido)
        {
            Cantidad = cantidad;
            Producto = producto;
            Pedido = pedido;
        }

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public Producto Producto { get => producto; set => producto = value; }
        public PedidoProduccion Pedido { get => pedido; set => pedido = value; }
    }
}
