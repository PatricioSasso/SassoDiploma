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
    public partial class AreaTejidoMenu : Form
    {
        public AreaTejidoMenu()
        {
            InitializeComponent();
        }

        public AreaTejidoMenu(Form formulario, Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            menuPrincipal = formulario; 
        }

        Controller controller;
        Form menuPrincipal;

        private void AreaTejidoMenu_Load(object sender, EventArgs e)
        {
            dataGridView_Hilado.DataSource = null;
            dataGridView_Hilado.DataSource = controller.GetListHilado();
            dataGridView_Tela.DataSource = null;
            dataGridView_Tela.DataSource = controller.GetListTela();
        }

        private void btn_AltaHilado_Click(object sender, EventArgs e)
        {
            controller.AltaHilado(txt_Id, txt_Codigo, txt_Descripcion, txt_Cantidad, txt_Peso);
            dataGridView_Hilado.DataSource = null;
            dataGridView_Hilado.DataSource = controller.GetListHilado();
        }

        private void btn_ModificarHilado_Click(object sender, EventArgs e)
        {
            controller.ModificarHilado(dataGridView_Hilado, txt_Descripcion, txt_Cantidad, txt_Peso);
            dataGridView_Hilado.DataSource = null;
            dataGridView_Hilado.DataSource = controller.GetListHilado();
        }

        private void btn_BajaHilado_Click(object sender, EventArgs e)
        {
            controller.BajaHilado(dataGridView_Hilado);
            dataGridView_Hilado.DataSource = null;
            dataGridView_Hilado.DataSource = controller.GetListHilado();
        }
    }
}
