using BLL;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Linq;
using BE;
using Interfaces;
using System.Windows.Forms.VisualStyles;
using System.Runtime.CompilerServices;
using Service;

namespace GUI
{
    public class Controller
    {
        Form form;

        ControlDeAcceso controlDeAcceso;
        TraduccionIdiomaGestor traduccionIdiomaGestor;

        public ControlDeAcceso ControlDeAcceso { get => controlDeAcceso; set => controlDeAcceso = value; }
        public TraduccionIdiomaGestor TraduccionIdiomaGestor { get => traduccionIdiomaGestor; set => traduccionIdiomaGestor = value; }

        public Controller(Form formulario, string idioma)
        {
            controlDeAcceso = new ControlDeAcceso();
            form = formulario;
            traduccionIdiomaGestor = new TraduccionIdiomaGestor(new Idioma(idioma));
        }

        #region Log in / out, gestion de perfiles y usuarios.

        public string LogIn(string nombreUsuario, string contraseña)
        {
            ControlDeAccesoGestor controlDeAccesoGestor = new ControlDeAccesoGestor();
            UsuarioGestor usuarioGestor = new UsuarioGestor();
            if (controlDeAccesoGestor.LogIn(nombreUsuario, controlDeAccesoGestor.GetHash(contraseña)))
            {
                Usuario user = new Usuario(nombreUsuario, contraseña, "", "", new Rol(0, "", new List<Permiso>()));
                user = usuarioGestor.GetUsuario(user);
                if (user.DVH == controlDeAccesoGestor.GetHash(user.NombreUsuario + user.Contraseña + user.Nombre + user.Apellido + user.Rol.Id))
                {
                    ControlDeAcceso.UsuarioActual = user;
                    if (ControlDeAcceso.UsuarioActual != null)
                    {
                        ControlDeAcceso.GetInstance();
                        cambiarForm(new MenuPrincipal(this));
                    }
                    return "Inicio de sesión correcto";
                }
                else
                {
                    MessageBox.Show("El usuario ha sido modificado sin permiso, verificar base de datos");
                }
            }
            return "Inicio de sesión fallido";
        }

        public void LogOut()
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea cerrar sesión?", "Cerar Sesión", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ControlDeAcceso.UsuarioActual = null;
                cambiarForm(form.Owner);
                MessageBox.Show("Se ha cerrado la sesión correctamente.");
            }
            else
            {
                MessageBox.Show("Cerrado de sesión cancelado.");
            }
        }

        public void AltaUsuario(string nombreUsuario, string contraseña, string nombre, string apellido, Rol rol)
        {
            try
            {
                DVVGestor dvvGestor = new DVVGestor();
                UsuarioGestor usuarioGestor = new UsuarioGestor();
                RolGestor rolGestor = new RolGestor();
                List<Usuario> usuariosExistentes = usuarioGestor.GetListUsuario();
                foreach (var usuario in usuariosExistentes)
                {
                    if (usuario.NombreUsuario.ToLower() == nombreUsuario.ToLower())
                    {
                        throw new Exception("El nombre de usuario ingresado ya está en uso");
                    }
                }
                usuarioGestor.Alta(new Usuario(nombreUsuario, dvvGestor.GetHash(contraseña), nombre, apellido, rolGestor.GetRol(rol)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ModificarUsuario(Usuario usuario)
        {
            try
            {
                UsuarioGestor usuarioGestor = new UsuarioGestor();
                usuarioGestor.Modificar(usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BajaUsuario(Usuario usuario)
        {
            try
            {
                UsuarioGestor usuarioGestor = new UsuarioGestor();
                usuarioGestor.Baja(usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AltaRol(string nombre)
        {
            RolGestor rolGestor = new RolGestor();
            rolGestor.Alta(new Rol(nombre, new List<Permiso>()));
        }

        public void ModificarRol(Rol rol)
        {
            RolGestor rolGestor = new RolGestor();
            rolGestor.Modificar(rol);
        }

        public void BajaRol(Rol rol)
        {
            RolGestor rolGestor = new RolGestor();
            rolGestor.Baja(rol);
        }

        public void DarPermiso(Rol rol, Permiso permiso)
        {
            try
            {
                if (permiso == null) { throw new Exception("No se ha seleccionado ningún permiso"); }
                if (rol == null) { throw new Exception("No se ha seleccionado ningún rol"); }
                RolGestor rolGestor = new RolGestor();
                foreach (var p in rol.Permisos)
                {
                    if (permiso.Id == p.Id)
                    {
                        throw new Exception("El permiso que desea agregar ya está en dentro del rol");
                    }
                }
                rolGestor.AddPermiso(rol, permiso);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void QuitarPermiso(Rol rol, Permiso permiso)
        {
            try
            {
                if (permiso == null) { throw new Exception("No se ha seleccionado ningún permiso"); }
                if (rol == null) { throw new Exception("No se ha seleccionado ningún rol"); }
                RolGestor rolGestor = new RolGestor();
                rolGestor.RemovePermiso(rol, permiso);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        #endregion

        #region Productos

        public void AltaHilado(string Codigo, string Descripcion, string Cantidad, string Peso)
        {
            try
            {
                HiladoGestor hiladoGestor = new HiladoGestor();
                string codigo = Codigo;
                string descripcion = Descripcion;
                int cantidad = int.Parse(Cantidad);
                decimal peso = decimal.Parse(Peso);
                hiladoGestor.Alta(new Hilado(codigo, descripcion, cantidad, peso));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void ModificarHilado(Hilado hilado)
        {
            try
            {
                HiladoGestor hiladoGestor = new HiladoGestor();
                int id = hilado.Id;
                string codigo = hilado.Codigo;
                string descripcion = hilado.Descripcion;
                int cantidad = hilado.Cantidad;
                decimal peso = hilado.Peso;
                hiladoGestor.Modificar(new Hilado(id, codigo, descripcion, cantidad, peso));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void BajaHilado(Hilado hilado)
        {
            try
            {
                HiladoGestor hiladoGestor = new HiladoGestor();
                hiladoGestor.Baja(new Hilado(hilado.Id, hilado.Codigo, hilado.Descripcion, hilado.Cantidad, hilado.Peso));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public List<Hilado> GetListHilado()
        {
            HiladoGestor hiladoGestor = new HiladoGestor();
            return hiladoGestor.GetListHilado();
        }

        public void AltaTela(string codigo, string descripcion, int cantidad, string color, bool teñido)
        {
            try
            {
                TelaGestor telaGestor = new TelaGestor();
                telaGestor.Alta(new Tela(codigo, descripcion, cantidad, "", false));
                BitacoraGestor bitacoraGestor = new BitacoraGestor();
                bitacoraGestor.Registrar("El empleado con nombre de usuario " + controlDeAcceso.UsuarioActual.NombreUsuario + " ha creado una nueva tela :" + codigo + " " + descripcion + ".", TipoMensaje.MENSAJE, controlDeAcceso.UsuarioActual);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void ModificarTela(Tela tela)
        {
            try
            {
                TelaGestor telaGestor = new TelaGestor();
                telaGestor.Modificar(tela);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void BajaTela(Tela tela)
        {
            try
            {
                TelaGestor telaGestor = new TelaGestor();
                telaGestor.Baja(tela);
                BitacoraGestor bitacoraGestor = new BitacoraGestor();
                bitacoraGestor.Registrar("El empleado con nombre de usuario " + controlDeAcceso.UsuarioActual.NombreUsuario + " ha eliminado una tela :" + tela.Codigo + " " + tela.Descripcion + ".", TipoMensaje.ADVERTENCIA, controlDeAcceso.UsuarioActual);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        public List<Tela> GetListTela()
        {
            TelaGestor telaGestor = new TelaGestor();
            return telaGestor.GetListTela();
        }

        public void AltaTinte(string codigo, string descripcion, int cantidad, string color)
        {
            try
            {
                TinteGestor tinteGestor = new TinteGestor();
                tinteGestor.Alta(new Tinte(codigo, descripcion, cantidad, color));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void ModificarTinte(Tinte tinte)
        {
            try
            {
                TinteGestor tinteGestor = new TinteGestor();
                tinteGestor.Modificar(tinte);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void BajaTinte(Tinte tinte)
        {
            try
            {
                TinteGestor tinteGestor = new TinteGestor();
                tinteGestor.Baja(tinte);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        public List<Tinte> GetListTinte()
        {
            TinteGestor tinteGestor = new TinteGestor();
            return tinteGestor.GetListTinte();
        }

        public void AltaPrenda(string codigo, string descripcion, int cantidad, string talle)
        {
            try
            {
                PrendaGestor prendaGestor = new PrendaGestor();
                prendaGestor.Alta(new Prenda(codigo, descripcion, cantidad, talle, false));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void ModificarPrenda(Prenda prenda)
        {
            try
            {
                PrendaGestor prendaGestor = new PrendaGestor();
                prendaGestor.Modificar(prenda);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void BajaPrenda(Prenda prenda)
        {
            try
            {
                PrendaGestor prendaGestor = new PrendaGestor();
                prendaGestor.Baja(prenda);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public List<Prenda> GetListPrenda()
        {
            PrendaGestor prendaGestor = new PrendaGestor();
            return prendaGestor.GetListPrenda();
        }

        #endregion

        #region Procesos
        public void Tejer(int cantUtilizada, int areaTela, Hilado hilado, string codigoTela)
        {
            try
            {
                Tejido tejido = new Tejido(cantUtilizada, areaTela, DateTime.Now, hilado);
                TejidoGestor tejidoGestor = new TejidoGestor();
                if (tejido.CantidadUtilizada / tejido.AreaTela < 1) { throw new Exception("No hay suficiente tela en stock"); }
                tejidoGestor.Tejer(tejido, codigoTela);
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
        }

        public void Teñir(Tela tela, int cantTelaUtilizada, Tinte tinte, int cantTinteUtilizado, string codigoTela)
        {
            try
            {
                TeñidoGestor teñidoGestor = new TeñidoGestor();
                if (cantTinteUtilizado * 2 < cantTelaUtilizada) { throw new Exception("La cantidad de tinte ingresada no es suficiente para la cantidad de tela elegida."); }
                if (cantTinteUtilizado > tinte.Cantidad) { throw new Exception("No hay suciciente tinte en stock."); }
                if (cantTelaUtilizada > tela.Cantidad) { throw new Exception("No hay suciciente tela en stock."); }
                teñidoGestor.Teñir(new Teñido(cantTinteUtilizado, cantTelaUtilizada, DateTime.Now, tinte, tela), codigoTela);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void Cortar(Tela tela, int cantTela, int dimensiones, string talle, string codigoPrenda)
        {
            try
            {
                CorteGestor corteGestor = new CorteGestor();
                if(cantTela > tela.Cantidad) { throw new Exception("No hay suficiente tela en stock."); };
                if(talle.ToUpper() != "S" && talle.ToUpper() != "M" && talle.ToUpper() != "L") { throw new Exception("El talle seleccionado no es válido"); }
                corteGestor.Cortar(new Corte(talle.ToUpper(), DateTime.Now, cantTela, dimensiones, tela), codigoPrenda);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void Confeccionar(Prenda prenda, int cantidadPrenda, string codigoPrenda)
        {
            try
            {
                if (cantidadPrenda > prenda.Cantidad) { throw new Exception("No hay suficientes prendas en stock."); }
                ConfeccionGestor confeccionGestor = new ConfeccionGestor();
                confeccionGestor.Confeccionar(new Confeccion(cantidadPrenda, DateTime.Now, prenda), codigoPrenda);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region 2
        public void SolicitarProducto(List<ItemProducto> productos)
        {
            PedidoProduccionGestor pedidoProduccionGestor = new PedidoProduccionGestor();
            PedidoProduccion pedido = pedidoProduccionGestor.Alta(new PedidoProduccion(DateTime.MinValue));
            ItemProductoGestor itemProductoGestor = new ItemProductoGestor();
            foreach (var item in productos)
            {
                item.Pedido = pedido;
                itemProductoGestor.Alta(item);
            }
            MessageBox.Show("Se ha realizado el pedido correctamente");
        }

        public void RegistrarPedido(DateTime fecha)
        {
            PedidoProduccionGestor pedidoProduccionGestor = new PedidoProduccionGestor();
            pedidoProduccionGestor.Alta(new PedidoProduccion(fecha));
            MessageBox.Show("Se ha registrado el pedido correctamente");
        }
        #endregion

        public void cambiarForm(Form newForm)
        {
            if (newForm.Owner == null && newForm.GetType().Name != "LogInMenu")
            {
                form.AddOwnedForm(newForm);
            }
            form.Hide();
            TraduccionIdiomaGestor.Desuscribir(form as IObservador<Idioma>);
            TraduccionIdiomaGestor.Suscribir(newForm as IObservador<Idioma>);
            Traducir(newForm, TraduccionIdiomaGestor.Idioma);
            this.form = newForm;
            if(form.OwnedForms.Length > 0)
            {
                form.OwnedForms[0].Dispose();
            }
            if( form.Owner != null)
            {
                newForm.StartPosition = form.Owner.StartPosition;
            }

            newForm.Show();
        }

        public void VerificarDVV()
        {
            DVVGestor dVVGestor = new DVVGestor();
            try
            {
                if (!dVVGestor.VerificarDVV(new DVV("Usuario")))
                {
                    throw new Exception("La tabla Usuario de la base de datos fue modificada desde fuera de la aplicación");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Control> GetControlesContenidos(Control control)
        {
            var controls = control.Controls.Cast<Control>();
            return (controls.SelectMany(ctrl => GetControlesContenidos(ctrl)).Concat(controls).ToList());
        }

        public void Traducir(Control contenedor, Idioma idioma)
        {
            TraduccionIdiomaGestor.Traducir(contenedor);
            TraduccionIdiomaGestor.Traducir(GetControlesContenidos(contenedor));
        }
    }
}
