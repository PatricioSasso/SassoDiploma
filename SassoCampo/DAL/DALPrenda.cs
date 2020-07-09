﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPrenda
    {
        string connectionString = @"Data Source=PC;Initial Catalog=SassoCampo;Integrated Security=True";
        SqlConnection conexion;
        SqlCommand query;

        public DALPrenda()
        {
            conexion = new SqlConnection(connectionString);
        }

        public void Alta(Prenda alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO Prenda VALUES (@id, @codigo, @descripcion, @cantidad, @talle, @confeccionada, @tiempoConfeccion)", conexion);
            query.Parameters.AddWithValue("id", alta.Id);
            query.Parameters.AddWithValue("codigo", alta.Codigo);
            query.Parameters.AddWithValue("descripcion", alta.Descripcion);
            query.Parameters.AddWithValue("cantidad", alta.Cantidad);
            query.Parameters.AddWithValue("talle", alta.Talle);
            query.Parameters.AddWithValue("confeccionada", alta.Confeccionada);
            query.Parameters.AddWithValue("tiempoConfeccion", alta.TiempoConfeccion);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Modificar(Prenda modificar)
        {
            conexion.Open();
            query = new SqlCommand("UPDATE Prenda SET Descripcion = @descripcion, Cantidad = @cantidad, Talle = @talle, Confeccionada = @confeccionada, TiempoConfeccion = @tiempoConfeccion WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", modificar.Id);
            query.Parameters.AddWithValue("descripcion", modificar.Descripcion);
            query.Parameters.AddWithValue("cantidad", modificar.Cantidad);
            query.Parameters.AddWithValue("talle", modificar.Talle);
            query.Parameters.AddWithValue("confeccionada", modificar.Confeccionada);
            query.Parameters.AddWithValue("tiempoConfeccion", modificar.TiempoConfeccion);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void Baja(Prenda baja)
        {
            conexion.Open();
            query = new SqlCommand("DELETE FROM Prenda WHERE Id = @id", conexion);
            query.Parameters.AddWithValue("id", baja.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public Prenda GetPrenda(Prenda buscar)
        {
            conexion.Open();
            Prenda prenda = new Prenda();
            query = new SqlCommand("SELECT * FROM Prenda WHERE Id = @Id", conexion);
            query.Parameters.AddWithValue("Id", buscar.Id);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    prenda.Id = reader.GetInt32(0);
                    prenda.Codigo = reader.GetString(1);
                    prenda.Descripcion = reader.GetString(2);
                    prenda.Cantidad = reader.GetInt32(3);
                    prenda.Talle = reader.GetString(4);
                    prenda.Confeccionada = reader.GetBoolean(5);
                    prenda.TiempoConfeccion = reader.GetInt32(6);
                }
            }
            conexion.Close();
            return prenda;
        }

        public List<Prenda> GetListPrenda()
        {
            conexion.Open();
            List<Prenda> prenda = new List<Prenda>();
            query = new SqlCommand("Select * From Prenda", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    prenda.Add(new Prenda(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4), reader.GetBoolean(5), reader.GetInt32(6))); ;
                }
            }
            conexion.Close();
            return prenda;
        }
    }
}
