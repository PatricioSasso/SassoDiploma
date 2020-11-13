using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;
using Service;
using Interfaces;

namespace GUI
{
    public partial class MenuPrincipal : Form , IObservador<Idioma>
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public MenuPrincipal( Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        Controller controller;

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            lbl_NombreUsuario2.Text = controller.ControlDeAcceso.UsuarioActual.NombreUsuario;
            lbl_NombreYApellido.Text = controller.ControlDeAcceso.UsuarioActual.Nombre + " " + controller.ControlDeAcceso.UsuarioActual.Apellido;
            lbl_Rol.Text = (controller.ControlDeAcceso.UsuarioActual.Rol as Rol).Nombre;
            cmb_Idioma.Text = controller.TraduccionIdiomaGestor.Idioma.Nombre;
            cmb_Idioma.Items.AddRange(controller.TraduccionIdiomaGestor.GetAllNameIdioma().ToArray());
            controller.TraduccionIdiomaGestor.Suscribir(this);
        }

        private void btn_IrAreaTejido_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(new AreaTejidoMenu(controller));
        }

        private void btn_GestionarUsuarios_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(new GestionUsuarios(controller));
        }

        private void btn_GestionarRoles_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(new GestionRoles(controller));
        }

        private void btn_AreaTeñido_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(new AreaTenidoMenu(controller));
        }

        private void btn_AreaCortado_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(new AreaCortadoMenu(controller));
        }

        private void btn_AreaConfeccion_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(new AreaConfeccionadoMenu(controller));
        }

        private void btn_GestionarProduccion_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(new GestionProduccionMenu(controller));
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialogBackup.Title = "Backup File";
            saveFileDialogBackup.FileName = "SassoCampoBackup";
            saveFileDialogBackup.Filter = "Backup Files (*.bak)|*.bak";
            if (saveFileDialogBackup.ShowDialog() == DialogResult.OK)
            {
                BackupAndRestoreGestor backupAndRestoreGestor = new BackupAndRestoreGestor();
                backupAndRestoreGestor.Backup(saveFileDialogBackup.FileName);
                MessageBox.Show("Backup creado exitosamente.");
            }
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialogRestore.Title = "Restore File";
            openFileDialogRestore.Filter = "Restore Files (*bak)|*.bak";
            if(openFileDialogRestore.ShowDialog() == DialogResult.OK)
            {
                BackupAndRestoreGestor backupAndRestoreGestor = new BackupAndRestoreGestor();
                backupAndRestoreGestor.Restore(openFileDialogRestore.FileName);
                MessageBox.Show("Restore realizado exitosamente.");
            }
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(new GestionBitacora(controller));
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.LogOut();
        }

        public void UpdateObserver(Idioma idioma)
        {
            controller.Traducir(this, idioma);
        }

        private void cmb_Idioma_SelectedValueChanged(object sender, EventArgs e)
        {
            controller.TraduccionIdiomaGestor.CambiarIdioma(new Idioma(cmb_Idioma.SelectedItem.ToString()));
            if (cmb_Idioma.SelectedItem.ToString() == "Ingles") { menuStrip1.Items[3].Text = "Log Out"; }
            else { menuStrip1.Items[3].Text = "Cerrar Sesión"; }
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linklbl_Ayuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "https://drive.google.com/drive/folders/1JGYjagA2U3mixPNKgBE6RB7AfRKd-3FP?usp=sharing");  
        }
    }
}
