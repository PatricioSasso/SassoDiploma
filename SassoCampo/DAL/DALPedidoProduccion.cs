using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.SqlClient;

namespace DAL
{
    public class DALPedidoProduccion : DAL, IABMC<PedidoProduccion>
    {
        public void Alta(PedidoProduccion alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO PedidoProduccion VALUES (@id, @fechaProduccion)", conexion);
            query.Parameters.AddWithValue("id", alta.Id);
            query.Parameters.AddWithValue("fechaProduccion", alta.FechaProduccion);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Baja(PedidoProduccion baja) // Cuando se da de baja el PedidoProducción también se dan de baja los ItemProductosRelacionados.
        {
            conexion.Open();
            DALItemProducto dalItemProducto = new DALItemProducto();
            foreach (var i in baja.ItemProductos)
            {
                dalItemProducto.Baja(i);
            }
            query = new SqlCommand("DELETE FROM PedidoProduccion WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", baja.Id);
            query.ExecuteNonQuery();
        }

        public void Modificar(PedidoProduccion modificar)
        {
            conexion.Open();
            query = new SqlCommand("UPDATE PedidoProduccion SET FechaProduccion = @fechaProduccion WHERE Id = @pedidoId", conexion);
            query.Parameters.AddWithValue("id", modificar.Id);
            query.Parameters.AddWithValue("fechaProduccion", modificar.FechaProduccion);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public PedidoProduccion Get(PedidoProduccion get)
        {
            conexion.Open();
            PedidoProduccion pedidoProduccion = new PedidoProduccion();
            query = new SqlCommand("SELECT * FROM PedidoProduccion WHERE Id = @pedidoId", conexion);
            query.Parameters.AddWithValue("pedidoId", get.Id);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    pedidoProduccion.Id = reader.GetInt32(0);
                    pedidoProduccion.FechaProduccion = reader.GetDateTime(1);
                }
            }
            conexion.Close();
            DALItemProducto dalItemProducto = new DALItemProducto();
            pedidoProduccion.ItemProductos = dalItemProducto.GetList(pedidoProduccion);
            return pedidoProduccion;
        }

        public List<PedidoProduccion> GetList()
        {
            conexion.Open();
            List<PedidoProduccion> pedidoProduccion = new List<PedidoProduccion>();
            query = new SqlCommand("Select * from PedidoProducto", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    pedidoProduccion.Add(new PedidoProduccion(reader.GetInt32(0), reader.GetDateTime(1), new List<ItemProducto>()));
                }
            }
            conexion.Close();
            DALItemProducto dalItemProducto = new DALItemProducto();
            for (int i = 0; i < pedidoProduccion.Count; i++)
            {
                pedidoProduccion[i].ItemProductos = dalItemProducto.GetList(pedidoProduccion[i]);
            }
            return pedidoProduccion;
        }
    }
}
