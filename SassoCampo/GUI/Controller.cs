using BLL;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System;
using System.ComponentModel;

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
                ControlDeAcceso.UsuarioActual = controlDeAccesoGestor.GetUsuario(user);
                if (ControlDeAcceso.UsuarioActual != null)
                {
                    ControlDeAcceso.GetInstance();
                    cambiarForm(new MenuPrincipal(this));
                }
                return "Inicio de sesión correcto";
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
                    if(usuario.NombreUsuario.ToLower() == nombreUsuario.ToLower())
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
                hiladoGestor.AltaHilado(new Hilado(id, codigo, descripcion, cantidad, peso));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                hiladoGestor.ModificarHilado(new Hilado(id, codigo, descripcion, cantidad, peso));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BajaHilado(Hilado hilado)
        {
            try
            {
                HiladoGestor hiladoGestor = new HiladoGestor();
                hiladoGestor.BajaHilado(new Hilado(hilado.Id, hilado.Codigo, hilado.Descripcion, hilado.Cantidad, hilado.Peso));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Hilado> GetListHilado()
        {
            HiladoGestor hiladoGestor = new HiladoGestor();
            return hiladoGestor.GetListHilado();
        }

        public void AltaTela()
        {
            //TODO: Implementar.
        }

        public void ModificarTela()
        {
            //TODO: Implementar.
        }

        public void BajaTela()
        {
            //TODO: Implementar.
        }

        public List<Tela> GetListTela()
        {
            TelaGestor telaGestor = new TelaGestor();
            return telaGestor.GetListTela();
        }

        #endregion

        public void cambiarForm(Form newForm)
        {
            if(newForm.Owner == null)
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
