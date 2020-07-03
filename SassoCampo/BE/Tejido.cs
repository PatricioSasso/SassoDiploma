using System;

public class Tejido
{
    int id;
    string codigo;
    int cantidadUtilizada;
    int tiempo;
    DateTime fecha;
    Hilado hilado;

    public Tejido()
    {

    }

    public Tejido(int id, string codigo, int cantidadUtilizada, int tiempo, DateTime fecha, Hilado hilado)
    {
        Id = id;
        Codigo = codigo;
        CantidadUtilizada = cantidadUtilizada;
        Tiempo = tiempo;
        Fecha = fecha;
        Hilado = hilado;
    }

    public int Id { get => id; set => id = value; }
    public string Codigo { get => codigo; set => codigo = value; }
    public int CantidadUtilizada { get => cantidadUtilizada; set => cantidadUtilizada = value; }
    public int Tiempo { get => tiempo; set => tiempo = value; }
    public Hilado Hilado { get => hilado; set => hilado = value; }
    public DateTime Fecha { get => fecha; set => fecha = value; }
}
