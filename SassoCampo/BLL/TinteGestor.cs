using DAL;
using System.Collections.Generic;

public class TinteGestor
{
    DALTinte bd;

    public TinteGestor()
    {
        bd = new DALTinte();
    }

    public void Alta(Tinte tinte)
    {
        bd.Alta(tinte);
    }

    public void Modificar(Tinte tinte)
    {
        bd.Modificar(tinte);
    }

    public void Baja(Tinte tinte)
    {
        bd.Baja(tinte);
    }

    public Tinte GetHilado(Tinte tinte)
    {
        return bd.GetTinte(tinte);
    }

    public List<Tinte> GetListTinte()
    {
        return bd.GetListTinte();
    }
}
