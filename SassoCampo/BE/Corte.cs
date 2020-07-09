using System;
using System.Collections.Generic;

public class Corte
{
    int id;
    string codigo;
    string talle;
    int tiempo;
    DateTime fecha;
    List<Tela> telas;

    public Corte()
    {

    }


    public Corte(int id, string codigo, string talle, int tiempo, DateTime fecha, List<Tela> telas)
    {
        Id = id;
        Codigo = codigo;
        Talle = talle;
        Tiempo = tiempo;
        Fecha = fecha;
        Telas = telas;
    }

    public int Id { get => id; set => id = value; }
    public string Codigo { get => codigo; set => codigo = value; }
    public string Talle { get => talle; set => talle = value; }
    public int Tiempo { get => tiempo; set => tiempo = value; }
    public DateTime Fecha { get => fecha; set => fecha = value; }
    public List<Tela> Telas { get => telas; set => telas = value; }
}
