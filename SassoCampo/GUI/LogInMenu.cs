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
            controller = new Controller(this,"Español");
            controller.VerificarDVV();
            controller.TraduccionIdiomaGestor.Suscribir(this);
            cmb_Idioma.DataSource = controller.TraduccionIdiomaGestor.GetAllNameIdioma().ToArray();
            cmb_Idioma.SelectedItem = cmb_Idioma.Items[0];
        }

        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controller.LogIn(txt_NombreUsuario.Text, txt_Contraseña.Text));
        }

        private void cmb_Idioma_TextChanged(object sender, EventArgs e)
        {
            controller.TraduccionIdiomaGestor.CambiarIdioma(new Idioma(cmb_Idioma.SelectedItem.ToString()));
        }

        public void UpdateObserver(Idioma idioma)
        {
            controller.Traducir(this,idioma);
            controller.TraduccionIdiomaGestor.Idioma = idioma;
        }
    }
}
