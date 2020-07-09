using DAL;
using System.Collections.Generic;

public class HiladoGestor
{
    DALHilado bd ;

    public HiladoGestor()
    {
        bd = new DALHilado();
    }

    public void Alta(Hilado hilado)
    {
        bd.Alta(hilado);
    }

    public void Modificar(Hilado hilado)
    {
        bd.Modificar(hilado);
    }

    public void Baja(Hilado hilado)
    {
        bd.Baja(hilado);
    }

    public Hilado GetHilado(Hilado hilado)
    {
        return bd.GetHilado(hilado);
    }

    public List<Hilado> GetListHilado()
    {
        return bd.GetListHilado();
    }
}
