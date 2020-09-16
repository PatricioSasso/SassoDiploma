using BLL;
using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;

namespace GUI
{
    public partial class GestionUsuarios : Form
    {
        public GestionUsuarios()
        {
            InitializeComponent();
        }

        public GestionUsuarios( Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        Controller controller;

        private void Form1_Load(object sender, EventArgs e)
        {
            IniciarControles();
            UsuarioGestor usuarioGestor = new UsuarioGestor();
            dgv_Usuarios.DataSource = null;
            dgv_Usuarios.DataSource = usuarioGestor.GetListUsuario();
        }

        private void btn_AltaUsuario_Click(object sender, EventArgs e)
        {
            UsuarioGestor usuarioGestor = new UsuarioGestor();
            controller.AltaUsuario(txt_NombreUsuario.Text, txt_Contraseña.Text, txt_Nombre.Text, txt_Apellido.Text, (Rol)cmb_Rol.SelectedItem);
            dgv_Usuarios.DataSource = null;
            dgv_Usuarios.DataSource = usuarioGestor.GetListUsuario();
        }

        private void btn_ModificarUsuario_Click(object sender, EventArgs e)
        {
            UsuarioGestor usuarioGestor = new UsuarioGestor();
            Usuario usuario = dgv_Usuarios.SelectedRows[0].DataBoundItem as Usuario;
            usuario.Nombre = txt_Nombre.Text;
            usuario.Apellido = txt_Apellido.Text;
            usuario.Rol = (Rol)cmb_Rol.SelectedItem;
            controller.ModificarUsuario(usuario);
            dgv_Usuarios.DataSource = null;
            dgv_Usuarios.DataSource = usuarioGestor.GetListUsuario();
        }

        private void btn_BajaUsuario_Click(object sender, EventArgs e)
        {
            UsuarioGestor usuarioGestor = new UsuarioGestor();
            Usuario usuario = dgv_Usuarios.SelectedRows[0].DataBoundItem as Usuario;
            controller.BajaUsuario(usuario);
            dgv_Usuarios.DataSource = null;
            dgv_Usuarios.DataSource = usuarioGestor.GetListUsuario();
        }

        public void IniciarControles()
        {
            dgv_Usuarios.Columns.Add("NombreUsuario", "Nombre de Usuario");
            dgv_Usuarios.Columns["NombreUsuario"].DataPropertyName = "NombreUsuario";
            //dgv_Usuarios.Columns.Add("Contraseña", "Contraseña");
            //dgv_Usuarios.Columns["Contraseña"].DataPropertyName = "Contraseña";
            dgv_Usuarios.Columns.Add("Nombre", "Nombre");
            dgv_Usuarios.Columns["Nombre"].DataPropertyName = "Nombre";
            dgv_Usuarios.Columns.Add("Apellido", "Apellido");
            dgv_Usuarios.Columns["Apellido"].DataPropertyName = "Apellido";
            dgv_Usuarios.AutoGenerateColumns = false;
            dgv_Usuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Usuarios.MultiSelect = false;
            RolGestor rolGestor = new RolGestor();
            cmb_Rol.DataSource = rolGestor.GetListRol();
            cmb_Rol.DisplayMember = "Nombre";
        }

        private void dgv_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Usuario usuario = dgv_Usuarios.SelectedRows[0].DataBoundItem as Usuario;
            txt_NombreUsuario.Text = usuario.NombreUsuario;
            //txt_Contraseña.Text = usuario.Codigo;
            txt_Nombre.Text = usuario.Nombre;
            txt_Apellido.Text = usuario.Apellido;
        }

        private void btn_VolverAlMenu_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(this.Owner);
            DVVGestor dVVGestor = new DVVGestor();
            dVVGestor.Modificar(new DVV("Usuario", ""));
        }

        private void GestionUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            DVVGestor dVVGestor = new DVVGestor();
            dVVGestor.Modificar(new DVV("Usuario", ""));
        }
    }
}
