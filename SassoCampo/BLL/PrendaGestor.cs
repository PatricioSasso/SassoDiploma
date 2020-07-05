using DAL;
using System.Collections.Generic;

public class PrendaGestor
{
    AccesoADatos bd;

    public PrendaGestor()
    {
        bd = new AccesoADatos();
    }

    public void Alta(Prenda prenda)
    {
        bd.AltaPrenda(prenda);
    }

    public void Modificar(Prenda prenda)
    {
        bd.ModificarPrenda(prenda);
    }

    public void Baja(Prenda prenda)
    {
        bd.BajaPrenda(prenda);
    }

    public Prenda GetPrenda(Prenda prenda)
    {
        return bd.GetPrenda(prenda);
    }

    public List<Prenda> GetListPrenda()
    {
        return bd.GetListPrenda();
    }

    public List<Prenda> GetListPrendaSinConfeccionar()
    {
        List<Prenda> sinConfeccionar = new List<Prenda>();
        foreach (var p in bd.GetListPrenda())
        {
            if (!p.Confeccionada) { sinConfeccionar.Add(p); }
        }
        return sinConfeccionar;
    }

    public List<Prenda> GetListPrendaConfeccionada()
    {
        List<Prenda> Confeccionada = new List<Prenda>();
        foreach (var p in bd.GetListPrenda())
        {
            if (p.Confeccionada) { Confeccionada.Add(p); }
        }
        return Confeccionada;
    }
}
