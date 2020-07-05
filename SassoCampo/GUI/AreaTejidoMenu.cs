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

        public AreaTejidoMenu(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        Controller controller;

        private void AreaTejidoMenu_Load(object sender, EventArgs e)
        {
            IniciarDataGrids();
            dgv_Hilados.DataSource = null;
            dgv_Hilados.DataSource = controller.GetListHilado();
            dgv_Telas.DataSource = null;
            dgv_Telas.DataSource = controller.GetListTela();
        }

        private void btn_AltaHilado_Click(object sender, EventArgs e)
        {
            controller.AltaHilado(txt_Id.Text, txt_Codigo.Text, txt_Descripcion.Text, txt_Cantidad.Text, txt_Peso.Text);
            dgv_Hilados.DataSource = null;
            dgv_Hilados.DataSource = controller.GetListHilado();
        }

        private void btn_ModificarHilado_Click(object sender, EventArgs e)
        {
            Hilado hilado = dgv_Hilados.SelectedRows[0].DataBoundItem as Hilado;
            hilado.Descripcion = txt_Descripcion.Text;
            hilado.Cantidad = int.Parse(txt_Cantidad.Text);
            hilado.Peso = decimal.Parse(txt_Peso.Text);
            controller.ModificarHilado(hilado);
            dgv_Hilados.DataSource = null;
            dgv_Hilados.DataSource = controller.GetListHilado();
        }

        private void btn_BajaHilado_Click(object sender, EventArgs e)
        {
            Hilado hilado = dgv_Hilados.SelectedRows[0].DataBoundItem as Hilado;
            controller.BajaHilado(hilado);
            dgv_Hilados.DataSource = null;
            dgv_Hilados.DataSource = controller.GetListHilado();
        }

        private void dataGridView_Hilado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Hilado hilado = dgv_Hilados.SelectedRows[0].DataBoundItem as Hilado;
            txt_Id.Text = hilado.Id.ToString();
            txt_Codigo.Text = hilado.Codigo;
            txt_Descripcion.Text = hilado.Descripcion;
            txt_Cantidad.Text = hilado.Cantidad.ToString();
            txt_Peso.Text = hilado.Peso.ToString();
        }

        private void btn_MenuPrincipal_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(this.Owner);
        }

        public void IniciarDataGrids()
        {
            dgv_Hilados.Columns.Add("Codigo", "Codigo");
            dgv_Hilados.Columns["Codigo"].DataPropertyName = "Codigo";
            dgv_Hilados.Columns.Add("Descripcion", "Descripción");
            dgv_Hilados.Columns["Descripcion"].DataPropertyName = "Descripcion";
            dgv_Hilados.Columns.Add("Cantidad", "Cantidad");
            dgv_Hilados.Columns["Cantidad"].DataPropertyName = "Cantidad";
            dgv_Hilados.Columns.Add("Peso", "Peso");
            dgv_Hilados.Columns["Peso"].DataPropertyName = "Peso";
            dgv_Hilados.AutoGenerateColumns = false;
            dgv_Hilados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Hilados.MultiSelect = false;
            dgv_Telas.Columns.Add("Codigo", "Codigo");
            dgv_Telas.Columns["Codigo"].DataPropertyName = "Codigo";
            dgv_Telas.Columns.Add("Descripcion", "Descripción");
            dgv_Telas.Columns["Descripcion"].DataPropertyName = "Descripcion";
            dgv_Telas.Columns.Add("Cantidad", "Cantidad");
            dgv_Telas.Columns["Cantidad"].DataPropertyName = "Cantidad";
            dgv_Telas.Columns.Add("Color", "Color");
            dgv_Telas.Columns["Color"].DataPropertyName = "Color";
            dgv_Telas.AutoGenerateColumns = false;
            dgv_Telas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Telas.MultiSelect = false;

        }

        private void btn_Tejer_Click(object sender, EventArgs e)
        {
            // TO DO: IMPLEMENT.
        }
    }
}
