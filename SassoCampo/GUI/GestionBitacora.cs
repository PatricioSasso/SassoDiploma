using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GestionBitacora : Form
    {
        public GestionBitacora()
        {
            InitializeComponent();
        }

        public GestionBitacora(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        Controller controller;

        private void GestionBitacora_Load(object sender, EventArgs e)
        {
            BitacoraGestor bitacoraGestor = new BitacoraGestor();
            Mostrar(bitacoraGestor.GetAll());
        }

        public void Mostrar(List<string> lista)
        {
            lbx_Bitacora.DataSource = null;
            lbx_Bitacora.DataSource = lista;
        }

        private void btn_MenuPrincipal_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(this.Owner);
        }

        private void GestionBitacora_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_FiltrarPorFecha_Click(object sender, EventArgs e)
        {
            BitacoraGestor bitacoraGestor = new BitacoraGestor();
            Mostrar(bitacoraGestor.BuscarFecha(txt_BuscarFecha.Text));
        }

        private void btn_FiltrarPorUsuario_Click(object sender, EventArgs e)
        {
            BitacoraGestor bitacoraGestor = new BitacoraGestor();
            Mostrar(bitacoraGestor.BuscarNombreUsuario(txt_BuscarNombreUsuario.Text));
        }
    }
}
