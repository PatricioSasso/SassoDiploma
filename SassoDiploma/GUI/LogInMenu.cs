using BE;
using BLL;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Service;

namespace GUI
{
    public partial class LogInMenu : Form , IObservador<Idioma>
    {
        public LogInMenu()
        {
            InitializeComponent();
        }
        
        Controller controller;

        private void LogInMenu_Load(object sender, EventArgs e)
        {
            BackupAndRestoreGestor verificarBaseDatos = new BackupAndRestoreGestor();
            verificarBaseDatos.VerifyDataBase();
            controller = new Controller(this,"Español");
            controller.VerificarDVV();
            cmb_Idioma.Text = controller.TraduccionIdiomaGestor.Idioma.Nombre;
            cmb_Idioma.Items.AddRange(controller.TraduccionIdiomaGestor.GetAllNameIdioma().ToArray());
            controller.TraduccionIdiomaGestor.Suscribir(this);
        }

        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controller.LogIn(txt_NombreUsuario.Text, txt_Contraseña.Text));
        }

        public void UpdateObserver(Idioma idioma)
        {
            controller.Traducir(this,idioma);
        }

        private void cmb_Idioma_SelectedValueChanged(object sender, EventArgs e)
        {
            controller.TraduccionIdiomaGestor.CambiarIdioma(new Idioma(cmb_Idioma.SelectedItem.ToString()));
        }

        private void LogInMenu_TextChanged(object sender, EventArgs e)
        {
            cmb_Idioma.Text = controller.TraduccionIdiomaGestor.Idioma.Nombre;
        }

        private void LogInMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linklbl_Ayuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/1JGYjagA2U3mixPNKgBE6RB7AfRKd-3FP?usp=sharing");
        }
    }
}
