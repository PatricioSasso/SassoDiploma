using DAL;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class RolGestor
{
    DALRol bd;

    public RolGestor()
    {
        bd = new DALRol();
    }

    public Rol GetRol(Rol rol)
    {
        return bd.Get(rol);
    }

    public List<Rol> GetListRol()
    {
        return bd.GetList();
    }

    public void Alta(Rol rol)
    {
        bd.Alta(rol);
    }

    public void Modificar(Rol rol)
    {
        bd.Modificar(rol);
    }

    public void Baja(Rol rol)
    {
        bd.Baja(rol);
    }

    public void AddPermiso(Rol rol, Permiso permiso)
    {
        DALRolPermiso dalRolPermiso = new DALRolPermiso();
        DALPermiso dalPermiso = new DALPermiso();
        dalRolPermiso.AltaRolPermiso(rol, permiso);
        rol.Permisos.Add(dalPermiso.Get(permiso));
    }

    public void RemovePermiso(Rol rol, Permiso permiso)
    {
        DALRolPermiso dalRolPermiso = new DALRolPermiso();
        dalRolPermiso.BajaRolPermiso(rol, permiso);
        rol.Permisos.Remove(permiso);
    }
}
