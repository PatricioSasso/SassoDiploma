using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GUI
{
    public partial class GestionRoles : Form
    {
        public GestionRoles()
        {
            InitializeComponent();
        }

        public GestionRoles(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        Controller controller;

        private void GestionRoles_Load(object sender, EventArgs e)
        {
            IniciarControles();
            RolGestor rolGestor = new RolGestor();
            PermisoGestor permisoGestor = new PermisoGestor();
            dgv_Roles.DataSource = null;
            dgv_Roles.DataSource = rolGestor.GetListRol();
            dgv_Permisos.DataSource = null;
            dgv_Permisos.DataSource = permisoGestor.GetListPermiso();
        }

        public void IniciarControles()
        {
            dgv_Roles.Columns.Add("Nombre", "Nombre");
            dgv_Roles.Columns["Nombre"].DataPropertyName = "Nombre";
            dgv_Roles.AutoGenerateColumns = false;
            dgv_Roles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Roles.MultiSelect = false;
            dgv_PermisosRol.Columns.Add("Nombre", "Nombre");
            dgv_PermisosRol.Columns["Nombre"].DataPropertyName = "Nombre";
            dgv_PermisosRol.Columns.Add("Descripcion", "Descripción");
            dgv_PermisosRol.Columns["Descripcion"].DataPropertyName = "Descripcion";
            dgv_PermisosRol.AutoGenerateColumns = false;
            dgv_PermisosRol.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_PermisosRol.MultiSelect = false;
            dgv_Permisos.Columns.Add("Nombre", "Nombre");
            dgv_Permisos.Columns["Nombre"].DataPropertyName = "Nombre";
            dgv_Permisos.Columns.Add("Descripcion", "Descripción");
            dgv_Permisos.Columns["Descripcion"].DataPropertyName = "Descripcion";
            dgv_Permisos.AutoGenerateColumns = false;
            dgv_Permisos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Permisos.MultiSelect = false;
        }

        private void btn_AltaRol_Click(object sender, EventArgs e)
        {
            RolGestor rolGestor = new RolGestor();
            string nombre = txt_Nombre.Text;
            controller.AltaRol(nombre);
            dgv_Roles.DataSource = null;
            dgv_Roles.DataSource = rolGestor.GetListRol();
        }

        private void btn_ModificarRol_Click(object sender, EventArgs e)
        {
            RolGestor rolGestor = new RolGestor();
            Rol rol = dgv_Roles.SelectedRows[0].DataBoundItem as Rol;
            rol.Nombre = txt_Nombre.Text;
            controller.ModificarRol(rol);
            dgv_Roles.DataSource = null;
            dgv_Roles.DataSource = rolGestor.GetListRol();
        }

        private void btn_BajaRol_Click(object sender, EventArgs e)
        {
            RolGestor rolGestor = new RolGestor();
            Rol rol = dgv_Roles.SelectedRows[0].DataBoundItem as Rol;
            controller.BajaRol(rol);
            dgv_Roles.DataSource = null;
            dgv_Roles.DataSource = rolGestor.GetListRol();
        }

        private void dgv_Roles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Rol rol = dgv_Roles.SelectedRows[0].DataBoundItem as Rol;
            txt_Nombre.Text = rol.Nombre;
            dgv_PermisosRol.DataSource = null;
            if (rol.Permisos != null)
            {
                dgv_PermisosRol.DataSource = rol.Permisos;
            }
        }

        private void btn_AgregarPermiso_Click(object sender, EventArgs e)
        {
            RolGestor rolGestor = new RolGestor();
            Rol rol = dgv_Roles.SelectedRows[0].DataBoundItem as Rol;
            Permiso permiso = dgv_Permisos.SelectedRows[0].DataBoundItem as Permiso;
            controller.DarPermiso(rol, permiso);
            dgv_PermisosRol.DataSource = null;
            dgv_PermisosRol.DataSource = rol.Permisos;
        }

        private void btn_EliminarPermiso_Click(object sender, EventArgs e)
        {
            RolGestor rolGestor = new RolGestor();
            Rol rol = dgv_Roles.SelectedRows[0].DataBoundItem as Rol;
            Permiso permiso = null;
            if (dgv_PermisosRol.SelectedRows != null) { permiso = dgv_PermisosRol.SelectedRows[0].DataBoundItem as Permiso; }
            controller.QuitarPermiso(rol, permiso);
            dgv_PermisosRol.DataSource = null;
            dgv_PermisosRol.DataSource = rol.Permisos;
        }

        private void btn_MenuPrincipal_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(this.Owner);
        }

        private void GestionRoles_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
