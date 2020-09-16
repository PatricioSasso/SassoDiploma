using DAL;
using System.Collections.Generic;

public class ProductoGestor
{
    DALProducto bd;

    public ProductoGestor()
    {
        bd = new DALProducto();
    }

    public void Alta(Producto producto)
    {
        bd.Alta(producto);
    }

    public void Modificar(Producto producto)
    {
        bd.Modificar(producto);
    }

    public void Baja(Producto producto)
    {
        bd.Baja(producto);
    }

    public Producto GetProducto(Producto producto)
    {
        return bd.Get(producto);
    }

    public List<Producto> GetListProducto()
    {
        return bd.GetList();
    }

}
