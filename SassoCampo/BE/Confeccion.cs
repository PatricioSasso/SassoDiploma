using System;
using System.Collections.Generic;

public class Confeccion
{
    int id;
    string codigo;
    int cantidad;
    int tiempo;
    DateTime fecha;
    List<Prenda> prenda;

    public Confeccion()
    {

    }

    public Confeccion(int id, string codigo, int cantidad, int tiempo, DateTime fecha, List<Prenda> prenda)
    {
        Id = id;
        Codigo = codigo;
        Cantidad = cantidad;
        Tiempo = tiempo;
        Fecha = fecha;
        Prenda = prenda;
    }

    public int Id { get => id; set => id = value; }
    public string Codigo { get => codigo; set => codigo = value; }
    public int Cantidad { get => cantidad; set => cantidad = value; }
    public int Tiempo { get => tiempo; set => tiempo = value; }
    public DateTime Fecha { get => fecha; set => fecha = value; }
    public List<Prenda> Prenda { get => prenda; set => prenda = value; }
}
