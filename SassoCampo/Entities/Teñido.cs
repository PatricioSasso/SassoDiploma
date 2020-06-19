using System;
using System.Collections.Generic;

public class Teñido
{
    int id;
    string codigo;
    Tinte tinte;
    int cantidadTinteUtilizada;
    Tela tela;
    int cantidadTelaUtilizada;
    int tiempo;

    public Teñido(int id, string codigo, Tinte tinte, int cantidadUtilizada, Tela tela, int cantidadTelaUtilizada, int tiempo)
    {
        Id = id;
        Codigo = codigo;
        Tinte = tinte;
        CantidadUtilizada = cantidadUtilizada;
        Tela = tela;
        CantidadTelaUtilizada = cantidadTelaUtilizada;
        Tiempo = tiempo;
    }

    public int Id { get => id; set => id = value; }
    public string Codigo { get => codigo; set => codigo = value; }
    public Tinte Tinte { get => tinte; set => tinte = value; }
    public int CantidadUtilizada { get => cantidadTinteUtilizada; set => cantidadTinteUtilizada = value; }
    public Tela Tela { get => tela; set => tela = value; }
    public int CantidadTelaUtilizada { get => cantidadTelaUtilizada; set => cantidadTelaUtilizada = value; }
    public int Tiempo { get => tiempo; set => tiempo = value; }
}
