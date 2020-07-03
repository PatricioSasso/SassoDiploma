using DAL;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class RolGestor
{
    AccesoADatos bd;

    public RolGestor()
    {
        bd = new AccesoADatos();
    }

    public Rol GetRol(Rol rol)
    {
        return bd.GetRol(rol);
    }

    public List<Rol> GetListRol()
    {
        return bd.GetListRol();
    }

    public void Alta(Rol rol)
    {
        bd.AltaRol(rol);
    }

    public void Modificar(Rol rol)
    {
        bd.ModificarRol(rol);
    }

    public void Baja(Rol rol)
    {
        bd.BajaRol(rol);
    }

    public void AddPermiso(Rol rol, Permiso permiso)
    {
        bd.AltaRolPermiso(rol, permiso);
        rol.Permisos.Add(bd.GetPermiso(permiso));
    }

    public void RemovePermiso(Rol rol, Permiso permiso)
    {
        bd.BajaRolPermiso(rol, permiso);
        rol.Permisos.Remove(permiso);
    }
}
