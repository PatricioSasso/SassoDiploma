using DAL;
using System.Collections.Generic;

public class PrendaGestor
{
    DALPrenda bd;

    public PrendaGestor()
    {
        bd = new DALPrenda();
    }

    public void Alta(Prenda prenda)
    {
        bd.Alta(prenda);
    }

    public void Modificar(Prenda prenda)
    {
        bd.Modificar(prenda);
    }

    public void Baja(Prenda prenda)
    {
        bd.Baja(prenda);
    }

    public Prenda GetPrenda(Prenda prenda)
    {
        return bd.Get(prenda);
    }

    public List<Prenda> GetListPrenda()
    {
        return bd.GetList();
    }

    public List<Prenda> GetListPrendaSinConfeccionar()
    {
        List<Prenda> sinConfeccionar = new List<Prenda>();
        foreach (var p in bd.GetList())
        {
            if (!p.Confeccionada) { sinConfeccionar.Add(p); }
        }
        return sinConfeccionar;
    }

    public List<Prenda> GetListPrendaConfeccionada()
    {
        List<Prenda> Confeccionada = new List<Prenda>();
        foreach (var p in bd.GetList())
        {
            if (p.Confeccionada) { Confeccionada.Add(p); }
        }
        return Confeccionada;
    }
}
