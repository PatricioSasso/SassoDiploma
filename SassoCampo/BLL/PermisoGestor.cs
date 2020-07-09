using DAL;
using System.Collections.Generic;

public class PermisoGestor
{
    DALRolPermiso bd;

    public PermisoGestor()
    {
        bd = new DALRolPermiso();
    }

    public Permiso GetPermiso(Permiso permiso)
    {
        return bd.GetPermiso(permiso);
    }

    public List<Permiso> GetListPermiso()
    {
        return bd.GetListPermiso();
    }

    public List<Permiso> GetListPermiso(Rol rol)
    {
        return bd.GetListPermiso(rol);
    }

}
