using DAL;
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

    public void AddPermiso(Rol rol, Permiso permiso)
    {
        bd.AltaRolPermiso(rol, permiso);
        rol.Permisos.Add(bd.GetPermiso(permiso));
    }

    public void RemovePermiso(Rol rol, Permiso permiso)
    {
        bd.BajaRolPermiso(rol, permiso);
        rol.Permisos.Remove(bd.GetPermiso(permiso));
    }
}
