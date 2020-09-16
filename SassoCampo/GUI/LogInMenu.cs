using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Service;

namespace GUI
{
    public partial class LogInMenu : Form
    {
        public LogInMenu()
        {
            InitializeComponent();
        }
        
        Controller controller;

        private void LogInMenu_Load(object sender, EventArgs e)
        {
            controller = new Controller(this);
            DVVGestor dVVGestor = new DVVGestor();
            cmb_Idioma.Items.AddRange(new string[] { "Español", "Ingles" });
            cmb_Idioma.SelectedItem = cmb_Idioma.Items[0];
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

        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controller.LogIn(txt_NombreUsuario.Text, txt_Contraseña.Text));
        }

        private void cmb_Idioma_TextChanged(object sender, EventArgs e)
        {
            controller.Traducir(this, cmb_Idioma.SelectedItem.ToString());
        }
    }
}
