using System;
using System.Collections.Generic;

public class Corte
{
    int id;
    string codigo;
    string talle;
    int tiempo;
    DateTime fecha;
    int cantidadTela;
    int dimensiones;
    Tela tela;

    public Corte()
    {

    }

    public Corte(string talle, DateTime fecha, int cantidadTela, int dimensiones, Tela tela)
    {
        Talle = talle;
        Fecha = fecha;
        CantidadTela = cantidadTela;
        Dimensiones = dimensiones;
        Tela = tela;
    }

    public Corte(int id, string codigo, string talle, int tiempo, DateTime fecha, int cantidadTela, int dimensiones, Tela tela)
    {
        Id = id;
        Codigo = codigo;
        Talle = talle;
        Tiempo = tiempo;
        Fecha = fecha;
        CantidadTela = cantidadTela;
        Dimensiones = dimensiones;
        Tela = tela;
    }

    public int Id { get => id; set => id = value; }
    public string Codigo { get => codigo; set => codigo = value; }
    public string Talle { get => talle; set => talle = value; }
    public int Tiempo { get => tiempo; set => tiempo = value; }
    public DateTime Fecha { get => fecha; set => fecha = value; }
    public Tela Tela { get => tela; set => tela = value; }
    public int CantidadTela { get => cantidadTela; set => cantidadTela = value; }
    public int Dimensiones { get => dimensiones; set => dimensiones = value; }
}
