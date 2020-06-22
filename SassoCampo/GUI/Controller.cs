using BLL;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System;

namespace GUI
{
    public class Controller
    {
        Form form;
        ControlDeAcceso controlDeAcceso = new ControlDeAcceso();

        public ControlDeAcceso ControlDeAcceso { get => controlDeAcceso; set => controlDeAcceso = value; }

        public Controller(Form formulario)
        {
            form = formulario;
        }

        #region Log in / out, gestion de perfiles y usuarios.

        public string LogIn(TextBox nombreUsuario, TextBox contraseña)
        {
            ControlDeAccesoGestor controlDeAccesoGestor = new ControlDeAccesoGestor();
            if (controlDeAccesoGestor.LogIn(GetTextBoxText(nombreUsuario), GetHashedTextBoxText(contraseña)))
            {
                ControlDeAcceso.UsuarioActual = controlDeAccesoGestor.GetUsuario(GetTextBoxText(nombreUsuario));
                if (ControlDeAcceso.UsuarioActual != null)
                {
                    ControlDeAcceso.GetInstance();
                }
                return "Inicio de sesión correcto";
            }
            return "Inicio de sesión fallido";
        }

        public void LogOut()
        {
            ControlDeAcceso.UsuarioActual = null;
            MessageBox.Show("Se ha cerrado la sesión correctamente");
        }

        public void AltaUsuario()
        {
            try
            {
                ControlDeAccesoGestor controlDeAccesoGestor = new ControlDeAccesoGestor();
                UsuarioGestor usuarioGestor = new UsuarioGestor();
                string nombreUsuario = Interaction.InputBox("Ingrese el nombre de usuario del nuevo usuario");
                string contraseña = controlDeAccesoGestor.GetHash(Interaction.InputBox("Ingrese la contraseña del nuevo usuario"));
                string nombre = Interaction.InputBox("Ingrese el nombre del nuevo usuario");
                string apellido = Interaction.InputBox("Ingrese el apellido del usuario del nuevo usuario");
                Rol rol = new Rol(0, Interaction.InputBox("Ingrese el rol del nuevo usuario (Admin, Gerente, Empleado)").ToLower(), new List<Permiso>());
                RolGestor rolGestor = new RolGestor();
                usuarioGestor.Alta(new Usuario(nombreUsuario, contraseña, nombre, apellido, rolGestor.GetRol(rol)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ModificarUsuario()
        {
            try
            {
                ControlDeAccesoGestor controlDeAccesoGestor = new ControlDeAccesoGestor();
                UsuarioGestor usuarioGestor = new UsuarioGestor();
                string nombreUsuario = Interaction.InputBox("Ingrese el nombre de usuario del usuario que desea modificar");
                string nombre = Interaction.InputBox("Ingrese el nombre del usuario a modificar");
                string apellido = Interaction.InputBox("Ingrese el apellido del usuario a modificar");
                Rol rol = new Rol(0, Interaction.InputBox("Ingrese el rol del usuario a modificar (Admin, Gerente, Empleado)").ToLower(), new List<Permiso>());
                RolGestor rolGestor = new RolGestor();
                usuarioGestor.Modificar(new Usuario(nombreUsuario, "", nombre, apellido, rolGestor.GetRol(rol)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BajaUsuario()
        {
            try
            {
                ControlDeAccesoGestor controlDeAccesoGestor = new ControlDeAccesoGestor();
                UsuarioGestor usuarioGestor = new UsuarioGestor();
                string nombreUsuario = Interaction.InputBox("Ingrese el nombre de usuario del usuario que desea eliminar");
                usuarioGestor.Baja(new Usuario(nombreUsuario, "", "", "", new Rol()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 

        public void DarPermiso()
        {
            RolGestor rolGestor = new RolGestor();
            Rol rol = new Rol(0, Interaction.InputBox("Ingrese el rol al que desea agregar el permiso (Admin, Gerente, Empleado)").ToLower(), new List<Permiso>());
            Permiso permiso = new Permiso(0, Interaction.InputBox("Ingrese el nombre del permiso que desea agregar"),"");
            rolGestor.AddPermiso(rol, permiso);
        }

        public void QuitarPermiso()
        {
            RolGestor rolGestor = new RolGestor();
            Rol rol = new Rol(0, Interaction.InputBox("Ingrese el rol al que desea agregar el permiso (Admin, Gerente, Empleado)").ToLower(), new List<Permiso>());
            Permiso permiso = new Permiso(0, Interaction.InputBox("Ingrese el nombre del permiso que desea agregar"), "");
            rolGestor.RemovePermiso(rol, permiso);
        }

        #endregion

        #region Productos

        public void AltaHilado(TextBox txtId, TextBox txtCodigo, TextBox txtDescripcion, TextBox txtCantidad, TextBox txtPeso)
        {
            try
            {
                HiladoGestor hiladoGestor = new HiladoGestor();
                int id = int.Parse(GetTextBoxText(txtId));
                string codigo = GetTextBoxText(txtCodigo);
                string descripcion = GetTextBoxText(txtDescripcion);
                int cantidad = int.Parse(GetTextBoxText(txtCantidad));
                int peso = int.Parse(GetTextBoxText(txtPeso));
                Usuario ultimaModificacion = controlDeAcceso.UsuarioActual;
                hiladoGestor.AltaHilado(new Hilado(id, codigo, descripcion, cantidad, peso, ultimaModificacion));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ModificarHilado(DataGridView dataGrid, TextBox txtDescripcion, TextBox txtCantidad, TextBox txtPeso)
        {
            try
            {
                HiladoGestor hiladoGestor = new HiladoGestor();
                int id = int.Parse(dataGrid.SelectedRows[0].Cells["Id"].Value.ToString());
                string codigo = dataGrid.SelectedRows[0].Cells["Codigo"].Value.ToString();
                string descripcion = GetTextBoxText(txtDescripcion);
                int cantidad = int.Parse(GetTextBoxText(txtCantidad));
                int peso = int.Parse(GetTextBoxText(txtPeso));
                Usuario ultimaModificacion = controlDeAcceso.UsuarioActual;
                hiladoGestor.ModificarHilado(new Hilado(id, codigo, descripcion, cantidad, peso, ultimaModificacion));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BajaHilado(DataGridView dataGrid)
        {
            try
            {
                HiladoGestor hiladoGestor = new HiladoGestor();
                int id = int.Parse(dataGrid.SelectedRows[0].Cells["Id"].Value.ToString());
                hiladoGestor.BajaHilado(new Hilado(id, "", "", 0, 0, null));
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

        public string GetTextBoxText(TextBox textBox)
        {
            return textBox.Text;
        }

        public string GetHashedTextBoxText(TextBox textBox)
        {
            ControlDeAccesoGestor controlDeAccesoGestor = new ControlDeAccesoGestor();
            return controlDeAccesoGestor.GetHash(textBox.Text);
        }
    }
}
