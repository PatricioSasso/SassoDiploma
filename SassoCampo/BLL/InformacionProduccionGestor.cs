using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class InformacionProduccionGestor
    {
        public InformacionProduccionGestor()
        {
        }

        public string ObtenerInformacionTejido(InformacionProduccion info)
        {
            string nl = Environment.NewLine;
            string show = "Tejidos:" + nl + nl;
            show += "Tiempo promedio: " + (info.Tejidos.Sum(t => t.Tiempo) / info.Tejidos.Count) + nl;
            show += "Tejidos realizados : " + info.Tejidos.Count + nl;
            var masUtilizado = productoMasUtilizado(info.Tejidos);
            show += "El hilado más utilizado para tejer fue: " + masUtilizado.Producto.Codigo + " " + masUtilizado.Producto.Descripcion + nl
                    + "Habiéndose utilizado : " + masUtilizado.Cantidad + nl;
            return show;
        }

        public string ObtenerInformacionTenido(InformacionProduccion info)
        {
            string nl = Environment.NewLine;
            string show = "Tenidos:" + nl + nl;
            show += "Tiempo promedio: " + (info.Teñidos.Sum(t => t.Tiempo) / info.Teñidos.Count) + nl;
            show += "Teñidos realizados : " + info.Teñidos.Count + nl;
            var masUtilizado = productoMasUtilizado(info.Teñidos, "Tela");
            show += "La tela más utilizada para teñir fue: " + masUtilizado.Producto.Codigo + " " + masUtilizado.Producto.Descripcion + nl
                    + "Habiéndose utilizado : " + masUtilizado.Cantidad + nl;
            masUtilizado = productoMasUtilizado(info.Teñidos, "");
            show += "El tinte más utilizado para teñir fue: " + masUtilizado.Producto.Codigo + " " + masUtilizado.Producto.Descripcion + nl
                    + "Habiéndose utilizado : " + masUtilizado.Cantidad + nl;
            return show;
        }

        public string ObtenerInformacionCorte(InformacionProduccion info)
        {
            string nl = Environment.NewLine;
            string show = "Cortes:" + nl + nl;
            show += "Tiempo promedio: " + (info.Cortes.Sum(t => t.Tiempo) / info.Cortes.Count) + nl;
            show += "Cortes realizados : " + info.Cortes.Count + nl;
            var masUtilizado = productoMasUtilizado(info.Cortes);
            show += "La tela más utilizada para cortar fue: " + masUtilizado.Producto.Codigo + " " + masUtilizado.Producto.Descripcion + nl
                    + "Habiéndose utilizado : " + masUtilizado.Cantidad + nl;
            return show;
        }

        public string ObtenerInformacionConfeccion(InformacionProduccion info)
        {
            string nl = Environment.NewLine;
            string show = "Confecciones:" + nl + nl;
            show += "Tiempo promedio: " + (info.Confecciones.Sum(t => t.Tiempo) / info.Confecciones.Count) + nl;
            show += "Confecciones realizadas : " + info.Confecciones.Count + nl;
            var masUtilizado = productoMasUtilizado(info.Confecciones);
            show += "La prenda más utilizada para cortar fue: " + masUtilizado.Producto.Codigo + " " + masUtilizado.Producto.Descripcion + nl
                    + "Habiéndose utilizado : " + masUtilizado.Cantidad + nl;
            return show;
        }

        public string tiempoPromedio(List<Tejido> lista)
        {
            decimal total = 0;
            foreach (var p in lista)
            {
                total += p.Tiempo;
            }
            return "Tiempo promedio: " + (total / lista.Count);
        }

        public ItemProducto productoMasUtilizado(List<Tejido> lista)
        {
            List<ItemProducto> hilados = new List<ItemProducto>();
            foreach (var p in lista)
            {
                if(hilados.Exists(x => x.Producto.Id == p.Hilado.Id))
                {
                    ItemProducto item = hilados.Find(x => x.Producto.Id == p.Hilado.Id);
                    item.Cantidad += p.CantidadUtilizada;
                }
                else
                {
                    hilados.Add(new ItemProducto(p.CantidadUtilizada, p.Hilado));
                }
            }
            ItemProducto max = new ItemProducto();
            max.Cantidad = 0;
            foreach (var p in hilados)
            {
                if(p.Cantidad > max.Cantidad)
                {
                    max = p;
                }
            }
            return max;
        }

        public ItemProducto productoMasUtilizado(List<Tenido> lista, string tipo)
        {
            List<ItemProducto> producto = new List<ItemProducto>();
            if ( tipo == "Tela")
            {
                foreach (var p in lista)
                {
                    if (producto.Exists(x => x.Producto.Id == p.Tela.Id))
                    {
                        ItemProducto item = producto.Find(x => x.Producto.Id == p.Tela.Id);
                        item.Cantidad += p.CantidadTelaUtilizada;
                    }
                    else
                    {
                        producto.Add(new ItemProducto(p.CantidadTelaUtilizada, p.Tela));
                    }
                }
            }
            else
            {
                foreach (var p in lista)
                {
                    if (producto.Exists(x => x.Producto.Id == p.Tinte.Id))
                    {
                        ItemProducto item = producto.Find(x => x.Producto.Id == p.Tinte.Id);
                        item.Cantidad += p.CantidadTinteUtilizada;
                    }
                    else
                    {
                        producto.Add(new ItemProducto(p.CantidadTinteUtilizada, p.Tinte));
                    }
                }
            }
            ItemProducto max = new ItemProducto();
            max.Cantidad = 0;
            foreach (var p in producto)
            {
                if (p.Cantidad > max.Cantidad)
                {
                    max = p;
                }
            }
            return max;
        }

        public ItemProducto productoMasUtilizado(List<Corte> lista)
        {
            List<ItemProducto> telas = new List<ItemProducto>();
            foreach (var p in lista)
            {
                if (telas.Exists(x => x.Producto.Id == p.Tela.Id))
                {
                    ItemProducto item = telas.Find(x => x.Producto.Id == p.Tela.Id);
                    item.Cantidad += p.Tela.Cantidad;
                }
                else
                {
                    telas.Add(new ItemProducto(p.CantidadTela, p.Tela));
                }
            }
            ItemProducto max = new ItemProducto();
            max.Cantidad = 0;
            foreach (var p in telas)
            {
                if (p.Cantidad > max.Cantidad)
                {
                    max = p;
                }
            }
            return max;
        }

        public ItemProducto productoMasUtilizado(List<Confeccion> lista)
        {
            List<ItemProducto> prendas = new List<ItemProducto>();
            foreach (var p in lista)
            {
                if (prendas.Exists(x => x.Producto.Id == p.Prenda.Id))
                {
                    ItemProducto item = prendas.Find(x => x.Producto.Id == p.Prenda.Id);
                    item.Cantidad += p.Prenda.Cantidad;
                }
                else
                {
                    prendas.Add(new ItemProducto(p.Cantidad, p.Prenda));
                }
            }
            ItemProducto max = new ItemProducto();
            max.Cantidad = 0;
            foreach (var p in prendas)
            {
                if (p.Cantidad > max.Cantidad)
                {
                    max = p;
                }
            }
            return max;
        }

        private List<ItemProducto> productoMasUtilizado(List<PedidoProduccion> lista)
        {
            List<ItemProducto> producto = new List<ItemProducto>();
            foreach (var pedido in lista)
            {
                foreach (var item in pedido.ItemProductos)
                {
                    if (producto.Exists(x => x.Producto.Id == item.Producto.Id))
                    {
                        ItemProducto prod = producto.Find(x => x.Producto.Id == item.Producto.Id);
                        prod.Cantidad += item.Cantidad;
                    }
                    else
                    {
                        producto.Add(new ItemProducto(item.Cantidad, item.Producto));
                    }
                }
            }
            producto = producto.OrderByDescending(x => x.Cantidad).Take(3).ToList<ItemProducto>();
            return producto;
        }

        public List<PedidoProduccion> CalcularRecomendaciones(InformacionProduccion info)
        {
            List<PedidoProduccion> recomendaciones = new List<PedidoProduccion>();
            PedidoProduccionGestor pedidoProduccionGestor = new PedidoProduccionGestor();
            List<PedidoProduccion> completados = pedidoProduccionGestor.GetList("Completado");
            Random r = new Random();
            foreach (var item in productoMasUtilizado(completados))
            {
                PedidoProduccion pedido = new PedidoProduccion(DateTime.Now.AddDays(r.Next(30,60)));
                pedido.ItemProductos = new List<ItemProducto>();
                item.Cantidad = (item.Cantidad * r.Next(60,95)) / 100;
                pedido.ItemProductos.Add(item);
                recomendaciones.Add(pedido);
            }
            return recomendaciones;
        }
    }
}
