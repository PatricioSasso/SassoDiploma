using BLL;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System;
using System.ComponentModel;
using System.Security.Cryptography;

namespace GUI
{
    public class Controller
    {
        Form form;

        public ControlDeAcceso controlDeAcceso = new ControlDeAcceso();

        public ControlDeAcceso ControlDeAcceso { get => controlDeAcceso; set => controlDeAcceso = value; }

        public Controller(Form formulario)
        {
            form = formulario;
        }

        #region Log in / out, gestion de perfiles y usuarios.

        public string LogIn(string nombreUsuario, string contraseña)
        {
            ControlDeAccesoGestor controlDeAccesoGestor = new ControlDeAccesoGestor();
            UsuarioGestor usuarioGestor = new UsuarioGestor();
            if (controlDeAccesoGestor.LogIn(nombreUsuario, controlDeAccesoGestor.GetHash(contraseña)))
            {
                Usuario user = new Usuario(nombreUsuario, contraseña, "", "", new Rol(0, "", new List<Permiso>()));
                user = usuarioGestor.Buscar(user);
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
            ControlDeAcceso.UsuarioActual = null;
            MessageBox.Show("Se ha cerrado la sesión correctamente");
            form.Owner.Show();
            form.Close();
        }

        public void AltaUsuario(string nombreUsuario, string contraseña, string nombre, string apellido, Rol rol)
        {
            try
            {
                ControlDeAccesoGestor controlDeAccesoGestor = new ControlDeAccesoGestor();
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
                usuarioGestor.Alta(new Usuario(nombreUsuario, controlDeAccesoGestor.GetHash(contraseña), nombre, apellido, rolGestor.GetRol(rol)));
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
                ControlDeAccesoGestor controlDeAccesoGestor = new ControlDeAccesoGestor();
                UsuarioGestor usuarioGestor = new UsuarioGestor();
                usuarioGestor.Baja(usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AltaRol(int id, string nombre)
        {
            RolGestor rolGestor = new RolGestor();
            rolGestor.Alta(new Rol(id, nombre, new List<Permiso>()));
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

        public void AltaHilado(string Id, string Codigo, string Descripcion, string Cantidad, string Peso)
        {
            try
            {
                HiladoGestor hiladoGestor = new HiladoGestor();
                int id = int.Parse(Id);
                string codigo = Codigo;
                string descripcion = Descripcion;
                int cantidad = int.Parse(Cantidad);
                decimal peso = decimal.Parse(Peso);
                hiladoGestor.Alta(new Hilado(id, codigo, descripcion, cantidad, peso));
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

        public void AltaTela(int id, string codigo, string descripcion, int cantidad, string color, bool teñido)
        {
            try
            {
                TelaGestor telaGestor = new TelaGestor();
                telaGestor.Alta(new Tela(id, codigo, descripcion, cantidad, "", false));
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
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        public List<Tela> GetListTela()
        {
            TelaGestor telaGestor = new TelaGestor();
            return telaGestor.GetListTela();
        }

        public void AltaTinte(int id, string codigo, string descripcion, int cantidad, string color)
        {
            try
            {
                TinteGestor tinteGestor = new TinteGestor();
                tinteGestor.Alta(new Tinte(id, codigo, descripcion, cantidad, color));
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

        public void AltaPrenda(int id, string codigo, string descripcion, int cantidad, string talle)
        {
            try
            {
                PrendaGestor prendaGestor = new PrendaGestor();
                prendaGestor.Alta(new Prenda(id, codigo, descripcion, cantidad, talle, false, 0));
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
        #endregion

        public void cambiarForm(Form newForm)
        {
            if (newForm.Owner == null)
            {
                form.AddOwnedForm(newForm);
            }
            form.Hide();
            this.form = newForm;
            newForm.StartPosition = form.Owner.StartPosition;
            newForm.Show();
        }
    }
}
