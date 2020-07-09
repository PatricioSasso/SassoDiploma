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
        bd.AltaProducto(producto);
    }

    public void Modificar(Producto producto)
    {
        bd.ModificarProducto(producto);
    }

    public void Baja(Producto producto)
    {
        bd.BajaProducto(producto);
    }

    public Producto GetProducto(Producto producto)
    {
        return bd.GetProducto(producto);
    }

    public List<Producto> GetListProducto()
    {
        return bd.GetListProducto();
    }

}
