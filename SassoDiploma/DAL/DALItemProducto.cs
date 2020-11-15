using BE;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALItemProducto : DAL, IABMC<ItemProducto>
    {
        public void Alta(ItemProducto alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO ItemProducto VALUES (@pedidoId, @cantidad, @productoId, @tipo)", conexion);
            query.Parameters.AddWithValue("pedidoId", alta.Pedido.Id);
            query.Parameters.AddWithValue("cantidad", alta.Cantidad);
            query.Parameters.AddWithValue("productoId", alta.Producto.Id);
            query.Parameters.AddWithValue("tipo", alta.Producto.GetType().Name);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Baja(ItemProducto baja)
        {
            conexion.Open();
            query = new SqlCommand("DELETE FROM ItemProducto WHERE PedidoProduccion_Id = @pedidoId AND Producto_Id = @productoId", conexion);
            query.Parameters.AddWithValue("pedidoId", baja.Pedido.Id);
            query.Parameters.AddWithValue("productoId", baja.Producto.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Modificar(ItemProducto modificar)
        {
            conexion.Open();
            query = new SqlCommand("UPDATE ItemProducto SET Cantidad = @cantidad WHERE PedidoProduccion_Id = @pedidoId AND Producto_Id = @productoId", conexion);
            query.Parameters.AddWithValue("pedidoId", modificar.Pedido.Id);
            query.Parameters.AddWithValue("productoId", modificar.Producto.Id);
            query.Parameters.AddWithValue("cantidad", modificar.Cantidad);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public ItemProducto Get(ItemProducto get)
        {
            conexion.Open();
            ItemProducto itemProducto = new ItemProducto();
            query = new SqlCommand("SELECT * FROM ItemProducto WHERE PedidoProduccion_Id = @pedidoId AND Producto_Id = @productoId", conexion);
            query.Parameters.AddWithValue("pedidoId", get.Pedido.Id);
            query.Parameters.AddWithValue("productoId", get.Producto.Id);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    DALPedidoProduccion dalPedidoProduccion = new DALPedidoProduccion();
                    itemProducto.Pedido = dalPedidoProduccion.Get(new PedidoProduccion( reader.GetInt32(0)));
                    itemProducto.Cantidad = reader.GetInt32(1);
                    DALProducto dalProducto = new DALProducto();
                    itemProducto.Producto = dalProducto.Get(new Producto(reader.GetInt32(2)), reader.GetString(3));
                }
            }
            conexion.Close();
            return itemProducto;
        }
    

        public List<ItemProducto> GetList()
        {
            throw new NotImplementedException();
        }

        public List<ItemProducto> GetList(PedidoProduccion pedidoProduccion)
        {
            conexion.Open();
            List<ItemProducto> itemProducto = new List<ItemProducto>();
            List<string> tipos = new List<string>();
            query = new SqlCommand("Select * from ItemProducto where PedidoProduccion_Id = @pedidoId", conexion);
            query.Parameters.AddWithValue("pedidoId", pedidoProduccion.Id);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    itemProducto.Add(new ItemProducto(reader.GetInt32(1), new Producto(reader.GetInt32(2)), pedidoProduccion));
                    tipos.Add(reader.GetString(3));
                }
            }
            conexion.Close();
            int i = 0;
            foreach (var item in itemProducto)
            {
                DALProducto dalProducto = new DALProducto();
                item.Producto = dalProducto.Get(item.Producto, tipos[i]);
            }
            return itemProducto;
        }
    }
}
