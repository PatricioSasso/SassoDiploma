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
            query = new SqlCommand("INSERT INTO PedidoProduccion VALUES (@fechaProduccion, @estado)", conexion);
            if(alta.FechaProduccion == DateTime.MinValue)
            {
                query.Parameters.AddWithValue("fechaProduccion", DBNull.Value);
            }
            else
            {
                query.Parameters.AddWithValue("fechaProduccion", alta.FechaProduccion.Date);
            }
            query.Parameters.AddWithValue("estado", alta.Estado);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Baja(PedidoProduccion baja)
        {
            DALItemProducto dalItemProducto = new DALItemProducto();
            foreach (var i in baja.ItemProductos)
            {
                dalItemProducto.Baja(i);
            }
            conexion.Open();
            query = new SqlCommand("DELETE FROM PedidoProduccion WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", baja.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Modificar(PedidoProduccion modificar)
        {
            conexion.Open();
            query = new SqlCommand("UPDATE PedidoProduccion SET Estado = 'Completado' WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", modificar.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public PedidoProduccion GetLast()
        {
            conexion.Open();
            PedidoProduccion pedidoProduccion = new PedidoProduccion();
            query = new SqlCommand("SELECT * FROM PedidoProduccion WHERE Id = (SELECT Max(Id) FROM PedidoProduccion)", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    pedidoProduccion.Id = reader.GetInt32(0);
                    if( reader["FechaProduccion"] == DBNull.Value)
                    {
                        pedidoProduccion.FechaProduccion = DateTime.MinValue;
                    }
                    else
                    {
                        pedidoProduccion.FechaProduccion = reader.GetDateTime(1);
                    }
                }
            }
            conexion.Close();
            DALItemProducto dalItemProducto = new DALItemProducto();
            pedidoProduccion.ItemProductos = dalItemProducto.GetList(pedidoProduccion);
            return pedidoProduccion;
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
            query = new SqlCommand("Select * from PedidoProduccion where FechaProduccion IS NOT NULL", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    pedidoProduccion.Add(new PedidoProduccion(reader.GetInt32(0), reader.GetDateTime(1), new List<ItemProducto>(), reader.GetString(2)));
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

        public List<PedidoProduccion> GetListSolicitud()
        {
            conexion.Open();
            List<PedidoProduccion> pedidoProduccion = new List<PedidoProduccion>();
            query = new SqlCommand("Select * from PedidoProduccion where FechaProduccion IS NULL", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    pedidoProduccion.Add(new PedidoProduccion(reader.GetInt32(0), DateTime.MinValue , new List<ItemProducto>(), reader.GetString(2)));
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
