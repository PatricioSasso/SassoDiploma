using DAL;
using System.Collections.Generic;

public class PermisoGestor
{
    AccesoADatos bd;

    public PermisoGestor()
    {
        bd = new AccesoADatos();
    }

    public Permiso GetPermiso(Permiso permiso)
    {
        return bd.GetPermiso(permiso);
    }

    public List<Permiso> GetListPermiso()
    {
        return bd.GetListPermiso();
    }

}
