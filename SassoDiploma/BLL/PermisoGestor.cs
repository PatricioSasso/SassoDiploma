using DAL;
using System.Collections.Generic;

public class PermisoGestor
{
    DALPermiso bd;

    public PermisoGestor()
    {
        bd = new DALPermiso();
    }

    public Permiso GetPermiso(Permiso permiso)
    {
        return bd.Get(permiso);
    }

    public List<Permiso> GetListPermiso()
    {
        return bd.GetList();
    }

    public List<Permiso> GetListPermiso(Rol rol)
    {
        return bd.GetList(rol);
    }

}
