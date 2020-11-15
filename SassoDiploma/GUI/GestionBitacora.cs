using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void btn_GenerarPdf_Click(object sender, EventArgs e)
        {
            saveFileDialogBitacora.Title = "Informe de Bitácora";
            saveFileDialogBitacora.FileName = DateTime.Now.ToShortDateString().Replace($"/","-") + "_Bitacora.pdf";
            saveFileDialogBitacora.Filter = "Backup Files (*.pdf)|*.pdf";
            if (saveFileDialogBitacora.ShowDialog() == DialogResult.OK)
            {
                BitacoraGestor bitacoraGestor = new BitacoraGestor();
                bitacoraGestor.GenerarPdf(Path.GetFullPath(saveFileDialogBitacora.FileName));
                MessageBox.Show("Informe de bitácora creado exitosamente.");
            }
        }
    }
}
