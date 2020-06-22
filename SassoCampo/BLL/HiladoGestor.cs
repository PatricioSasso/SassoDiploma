using DAL;
using System.Collections.Generic;

public class HiladoGestor
{
    AccesoADatos bd ;

    public HiladoGestor()
    {
        bd = new AccesoADatos();
    }

    public void AltaHilado(Hilado hilado)
    {
        bd.AltaHilado(hilado);
    }

    public void ModificarHilado(Hilado hilado)
    {
        bd.ModificarHilado(hilado);
    }

    public void BajaHilado(Hilado hilado)
    {
        bd.BajaHilado(hilado);
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
