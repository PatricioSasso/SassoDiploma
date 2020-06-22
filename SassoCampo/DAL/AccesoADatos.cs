using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;

namespace DAL
{
    public class AccesoADatos
    {
        string connectionString = @"Data Source=PC;Initial Catalog = SassoCampo; Integrated Security = True";
        SqlConnection conexion;
        SqlCommand query;

        public AccesoADatos()
        {
            conexion = new SqlConnection(connectionString);
        }

        #region gestion de usuario, roles y permisos
        public bool LogIn(string nombreUsuario, string contraseña)
        {
            conexion.Open();
            query = new SqlCommand("Select * from Usuario where Usuario_NombreUsuario = @nombreUsuario AND Usuario_Contraseña = @contraseña", conexion);
            query.Parameters.AddWithValue("nombreUsuario", nombreUsuario);
            query.Parameters.AddWithValue("contraseña", contraseña);
            var resultado = query.ExecuteScalar();
            conexion.Close();
            if (resultado != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Usuario GetUsuario(string nombreUsuario)
        {
            conexion.Open();
            query = new SqlCommand("Select * from Usuario where Usuario_NombreUsuario = @nombreUsuario", conexion);
            query.Parameters.AddWithValue("nombreUsuario", nombreUsuario);
            Usuario usuario = new Usuario();
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while(reader.Read())
                {
                    usuario = new Usuario(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), new Rol(reader.GetInt32(4),"", new List<Permiso>()));
                }
            }
            conexion.Close();
            usuario.Rol = GetRol(usuario.Rol.Id);
            return usuario;
        }

        public void AltaUsuario(Usuario alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO Usuario VALUES (@nombreUsuario, @contraseña, @nombre, @apellido, @rolId)", conexion);
            query.Parameters.AddWithValue("nombreUsuario", alta.NombreUsuario);
            query.Parameters.AddWithValue("contraseña", alta.Contraseña);
            query.Parameters.AddWithValue("nombre", alta.Nombre);
            query.Parameters.AddWithValue("apellido", alta.Apellido);
            query.Parameters.AddWithValue("rolId", alta.Rol.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarUsuario(Usuario modificar)
        {
            conexion.Open();
            query = new SqlCommand("UPDATE Usuario SET Usuario_Nombre = @nombre, Usuario_Apellido = @apellido, Rol_Id = @rolId WHERE Usuario_NombreUsuario = @nombreUsuario",conexion);
            query.Parameters.AddWithValue("nombreUsuario", modificar.NombreUsuario);
            query.Parameters.AddWithValue("nombre", modificar.Nombre);
            query.Parameters.AddWithValue("apellido", modificar.Apellido);
            query.Parameters.AddWithValue("rolId", modificar.Rol.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void BajaUsuario(Usuario baja)
        {
            conexion.Open();
            query = new SqlCommand("DELETE FROM Usuario WHERE Usuario_NombreUsuario = @nombreUsuario", conexion);
            query.Parameters.AddWithValue("nombreUsuario", baja.NombreUsuario);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public Rol GetRol(Rol buscar)
        {
            conexion.Open();
            Rol rol = new Rol();
            query = new SqlCommand("SELECT * FROM Rol WHERE Rol_Nombre = @rolNombre", conexion);
            query.Parameters.AddWithValue("rolNombre", buscar.Nombre.ToLower());
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    rol.Id = reader.GetInt32(0);
                    rol.Nombre = reader.GetString(1);
                }
            }
            conexion.Close();
            rol.Permisos = GetListPermiso(rol);
            return rol;
        }

        public Rol GetRol(int rolId)
        {
            conexion.Open();
            Rol rol = new Rol();
            query = new SqlCommand("SELECT * FROM Rol WHERE Rol_Id = @rolId", conexion);
            query.Parameters.AddWithValue("rolId", rolId);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    rol.Id = reader.GetInt32(0);
                    rol.Nombre = reader.GetString(1);
                }
            }
            conexion.Close();
            rol.Permisos = GetListPermiso(rol);
            return rol;
        }

        public List<Rol> GetListRol()
        {
            conexion.Open();
            List<Rol> roles = new List<Rol>();
            query = new SqlCommand("Select * From Rol", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    roles.Add(new Rol(int.Parse(reader.GetString(0)), reader.GetString(1), new List<Permiso>()));
                }
                foreach (var rol in roles)
                {
                    rol.Permisos = GetListPermiso(rol);
                }
            }
            conexion.Close();
            return roles;
        }

        public void AltaRol(Rol alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO Rol VALUES(@id, @nombre)", conexion);
            query.Parameters.AddWithValue("id", alta.Id);
            query.Parameters.AddWithValue("nombre", alta.Nombre);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarRol(Rol modificar)
        {
            conexion.Open();
            query = new SqlCommand("UPDATE Rol SET Rol_Nombre = @nuevoNombre WHERE Rol_Id = @id",conexion);
            query.Parameters.AddWithValue("id", modificar.Id);
            query.Parameters.AddWithValue("nuevoNombre", modificar.Nombre);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void BajaRol(Rol baja)
        {
            conexion.Open();
            query = new SqlCommand("DELETE FROM Rol WHERE Rol_Id = @id", conexion);
            query.Parameters.AddWithValue("id", baja.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public Permiso GetPermiso(Permiso buscar)
        {
            conexion.Open();
            Permiso permiso = new Permiso();
            query = new SqlCommand("SELECT * FROM Permiso WHERE Permiso_Nombre = @permisoNombre", conexion);
            query.Parameters.AddWithValue("permisoNombre", buscar.Nombre.ToLower());
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    permiso.Id = reader.GetInt32(0);
                    permiso.Nombre = reader.GetString(1);
                    permiso.Descripcion = reader.GetString(2);
                }
            }
            conexion.Close();
            return permiso;
        }

        public List<Permiso> GetListPermiso()
        {
            conexion.Open();
            List<Permiso> permisos = new List<Permiso>();
            query = new SqlCommand("Select * From Permiso", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    permisos.Add(new Permiso(int.Parse(reader.GetString(0)), reader.GetString(1), reader.GetString(2)));
                }
            }
            conexion.Close();
            return permisos;
        }

        public List<Permiso> GetListPermiso(Rol rol)
        {
            conexion.Open();
            List<Permiso> permisos = new List<Permiso>();
            List<int> permisosId = new List<int>();
            query = new SqlCommand("Select Permiso_Id from [Rol-Permiso] where Rol_Id = 1", conexion);
            query.Parameters.AddWithValue("rolId", rol.Id);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    permisosId.Add(reader.GetInt32(0));
                }
            }
            foreach (var id in permisosId)
            {
                query = new SqlCommand("Select * from Permiso where Permiso_Id = @id", conexion);
                query.Parameters.AddWithValue("id", id);
                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        permisos.Add(new Permiso(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                    }
                }
            }
            conexion.Close();
            return permisos;
        }

        public void AltaRolPermiso(Rol rol, Permiso permiso)
        {
            Rol r = GetRol(rol);
            Permiso p = GetPermiso(permiso);
            conexion.Open();
            query = new SqlCommand("INSERT INTO [Rol-Permiso] VALUES(@rolId,@permisoId)", conexion);
            query.Parameters.AddWithValue("rolId", r.Id);
            query.Parameters.AddWithValue("permisoId", p.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void BajaRolPermiso(Rol rol, Permiso permiso)
        {
            Rol r = GetRol(rol);
            Permiso p = GetPermiso(permiso);
            conexion.Open();
            query = new SqlCommand("DELETE FROM [Rol-Permiso] WHERE Rol_Id = @rolId AND Permiso_Id = @permisoId", conexion);
            query.Parameters.AddWithValue("rolId", r.Id);
            query.Parameters.AddWithValue("permisoId", p.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        #endregion

        #region productos
        public void AltaProducto(Producto alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO Producto VALUES (@id, @codigo, @descripcion, @cantidad, NULL)", conexion);
            query.Parameters.AddWithValue("id", alta.Id);
            query.Parameters.AddWithValue("codigo", alta.Codigo);
            query.Parameters.AddWithValue("descripcion", alta.Descripcion);
            query.Parameters.AddWithValue("cantidad", alta.Cantidad);
            query.Parameters.AddWithValue("usuarioId", alta.UltimaModificacion.NombreUsuario);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarProducto(Producto modificar)
        {
            conexion.Open();
            query = new SqlCommand("UPDATE Producto SET Producto_Descripcion = @descripcion, Producto_Cantidad = @cantidad, Usuario_NombreUsuario = NULL WHERE Producto_Id = @id", conexion);
            query.Parameters.AddWithValue("id", modificar.Id);
            query.Parameters.AddWithValue("descripcion", modificar.Descripcion);
            query.Parameters.AddWithValue("cantidad", modificar.Cantidad);
            query.Parameters.AddWithValue("usuarioId", modificar.UltimaModificacion.NombreUsuario);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void BajaProducto(Producto baja)
        {
            conexion.Open();
            query = new SqlCommand("DELETE FROM Producto WHERE Producto_Id = @id", conexion);
            query.Parameters.AddWithValue("id", baja.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public Producto GetProducto(Producto buscar)
        {
            conexion.Open();
            Producto producto = new Producto();
            query = new SqlCommand("SELECT * FROM Producto WHERE Producto_Codigo = @codigo", conexion);
            query.Parameters.AddWithValue("codigo", buscar.Codigo.ToLower());
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    producto.Id = reader.GetInt32(0);
                    producto.Codigo = reader.GetString(1);
                    producto.Descripcion = reader.GetString(2);
                    producto.Cantidad = reader.GetInt32(3);
                    producto.UltimaModificacion = null;//producto.UltimaModificacion.Nombre = reader.GetString(4);
                }
            }
            conexion.Close();
            return producto;
        }

        public List<Producto> GetListProducto()
        {
            conexion.Open();
            List<Producto> producto = new List<Producto>();
            query = new SqlCommand("Select * From Producto", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    producto.Add(new Producto(int.Parse(reader.GetString(0)), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), null /* Usuario*/)); ;
                    // Agregar el usuario creador del producto.
                }
            }
            conexion.Close();
            return producto;
        }

        public void AltaHilado(Hilado alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO Hilado VALUES (@id, @codigo, @descripcion, @cantidad, @peso, NULL)", conexion);
            query.Parameters.AddWithValue("id", alta.Id);
            query.Parameters.AddWithValue("codigo", alta.Codigo);
            query.Parameters.AddWithValue("descripcion", alta.Descripcion);
            query.Parameters.AddWithValue("cantidad", alta.Cantidad);
            query.Parameters.AddWithValue("peso", alta.Peso);
            query.Parameters.AddWithValue("usuarioId", alta.UltimaModificacion.NombreUsuario);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarHilado(Hilado modificar)
        {
            conexion.Open();
            query = new SqlCommand("UPDATE Hilado SET Hilado_Descripcion = @descripcion, Hilado_Cantidad = @cantidad, Hilado_Peso = @peso, Usuario_NombreUsuario = NULL WHERE Hilado_Id = @id", conexion);
            query.Parameters.AddWithValue("id", modificar.Id);
            query.Parameters.AddWithValue("descripcion", modificar.Descripcion);
            query.Parameters.AddWithValue("cantidad", modificar.Cantidad);
            query.Parameters.AddWithValue("peso", modificar.Peso);
            query.Parameters.AddWithValue("usuarioId", modificar.UltimaModificacion.NombreUsuario);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void BajaHilado(Hilado baja)
        {
            conexion.Open();
            query = new SqlCommand("DELETE FROM Hilado WHERE Hilado_Id = @id", conexion);
            query.Parameters.AddWithValue("id", baja.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public Hilado GetHilado(Hilado buscar)
        {
            conexion.Open();
            Hilado hilado = new Hilado();
            query = new SqlCommand("SELECT * FROM Hilado WHERE Hilado_Codigo = @codigo", conexion);
            query.Parameters.AddWithValue("codigo", buscar.Codigo.ToLower());
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    hilado.Id = reader.GetInt32(0);
                    hilado.Codigo = reader.GetString(1);
                    hilado.Descripcion = reader.GetString(2);
                    hilado.Cantidad = reader.GetInt32(3);
                    hilado.Peso = reader.GetInt32(4);
                    hilado.UltimaModificacion = null;//hilado.UltimaModificacion.Nombre = reader.GetString(5);
                }
            }
            conexion.Close();
            return hilado;
        }

        public List<Hilado> GetListHilado()
        {
            conexion.Open();
            List<Hilado> hilado = new List<Hilado>();
            query = new SqlCommand("Select * From Hilado", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    hilado.Add(new Hilado(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), null /* Usuario*/)); ;
                    // Agregar el usuario creador del producto.
                }
            }
            conexion.Close();
            return hilado;
        }

        public void AltaTela(Tela alta)
        {
            conexion.Open();
            query = new SqlCommand("INSERT INTO Hilado VALUES (@id, @codigo, @descripcion, @cantidad, @color, @teñido, NULL)", conexion);
            query.Parameters.AddWithValue("id", alta.Id);
            query.Parameters.AddWithValue("codigo", alta.Codigo);
            query.Parameters.AddWithValue("descripcion", alta.Descripcion);
            query.Parameters.AddWithValue("cantidad", alta.Cantidad);
            query.Parameters.AddWithValue("color", alta.Color);
            query.Parameters.AddWithValue("teñido", alta.Teñido);
            query.Parameters.AddWithValue("usuarioId", alta.UltimaModificacion.NombreUsuario);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarTela(Tela modificar)
        {
            conexion.Open();
            query = new SqlCommand("UPDATE Tela SET Tela_Descripcion = @descripcion, Tela_Cantidad = @cantidad, Tela_Color = @color, Tela_Teñido = @teñido, Usuario_NombreUsuario = NULL WHERE Tela_Id = @id", conexion);
            query.Parameters.AddWithValue("id", modificar.Id);
            query.Parameters.AddWithValue("descripcion", modificar.Descripcion);
            query.Parameters.AddWithValue("cantidad", modificar.Cantidad);
            query.Parameters.AddWithValue("color", modificar.Color);
            query.Parameters.AddWithValue("teñido", modificar.Teñido);
            query.Parameters.AddWithValue("usuarioId", modificar.UltimaModificacion.NombreUsuario);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public void BajaTela(Tela baja)
        {
            conexion.Open();
            query = new SqlCommand("DELETE FROM Tela WHERE Tela_Id = @id", conexion);
            query.Parameters.AddWithValue("id", baja.Id);
            query.ExecuteNonQuery();
            conexion.Close();
        }

        public Tela GetTela(Tela buscar)
        {
            conexion.Open();
            Tela tela = new Tela();
            query = new SqlCommand("SELECT * FROM Tela WHERE Tela_Codigo = @codigo", conexion);
            query.Parameters.AddWithValue("codigo", buscar.Codigo.ToLower());
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    tela.Id = reader.GetInt32(0);
                    tela.Codigo = reader.GetString(1);
                    tela.Descripcion = reader.GetString(2);
                    tela.Cantidad = reader.GetInt32(3);
                    tela.Color = reader.GetString(4);
                    tela.Teñido = reader.GetBoolean(5);
                    tela.UltimaModificacion = null;//tela.UltimaModificacion.Nombre = reader.GetString(6);
                }
            }
            conexion.Close();
            return tela;
        }

        public List<Tela> GetListTela()
        {
            conexion.Open();
            List<Tela> tela = new List<Tela>();
            query = new SqlCommand("Select * From Tela", conexion);
            using (SqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    tela.Add(new Tela(int.Parse(reader.GetString(0)), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4), reader.GetBoolean(5), null /* Usuario*/)); ;
                    // Agregar el usuario creador del producto.
                }
            }
            conexion.Close();
            return tela;
        }
        #endregion
    }
}
