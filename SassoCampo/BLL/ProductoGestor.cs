using DAL;
using System.Collections.Generic;

public class ProductoGestor
{
    DALProducto bd;

    public ProductoGestor()
    {
        bd = new DALProducto();
    }

    public Producto Alta(Producto producto)
    {
        bd.Alta(producto);
        return bd.GetLast();
    }

    public void Modificar(Producto producto)
    {
        bd.Modificar(producto);
    }

    public void Baja(Producto producto)
    {
        bd.Baja(producto);
    }

    public Producto GetProducto(Producto producto, string tipo)
    {
        return bd.Get(producto, tipo);
    }

    public List<Producto> GetListProducto()
    {
        return bd.GetList();
    }

}
