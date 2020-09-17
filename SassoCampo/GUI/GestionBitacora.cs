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

        private void txt_BuscarNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            BitacoraGestor bitacoraGestor = new BitacoraGestor();
            Mostrar(bitacoraGestor.BuscarNombreUsuario(txt_BuscarNombreUsuario.Text));
        }

        private void txt_BuscarFecha_TextChanged(object sender, EventArgs e)
        {
            BitacoraGestor bitacoraGestor = new BitacoraGestor();
            Mostrar(bitacoraGestor.BuscarFecha(txt_BuscarFecha.Text));
        }

        public void Mostrar(List<string> lista)
        {
            lbx_Bitacora.DataSource = null;
            lbx_Bitacora.DataSource = lista;
        }
    }
}
