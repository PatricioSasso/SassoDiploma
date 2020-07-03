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
            dataGridView_Hilado.DataSource = null;
            dataGridView_Hilado.DataSource = controller.GetListHilado();
            dataGridView_Tela.DataSource = null;
            dataGridView_Tela.DataSource = controller.GetListTela();
        }

        private void btn_AltaHilado_Click(object sender, EventArgs e)
        {
            controller.AltaHilado(txt_Id.Text, txt_Codigo.Text, txt_Descripcion.Text, txt_Cantidad.Text, txt_Peso.Text);
            dataGridView_Hilado.DataSource = null;
            dataGridView_Hilado.DataSource = controller.GetListHilado();
        }

        private void btn_ModificarHilado_Click(object sender, EventArgs e)
        {
            Hilado hilado = dataGridView_Hilado.SelectedRows[0].DataBoundItem as Hilado;
            hilado.Descripcion = txt_Descripcion.Text;
            hilado.Cantidad = int.Parse(txt_Cantidad.Text);
            hilado.Peso = decimal.Parse(txt_Peso.Text);
            controller.ModificarHilado(hilado);
            dataGridView_Hilado.DataSource = null;
            dataGridView_Hilado.DataSource = controller.GetListHilado();
        }

        private void btn_BajaHilado_Click(object sender, EventArgs e)
        {
            Hilado hilado = dataGridView_Hilado.SelectedRows[0].DataBoundItem as Hilado;
            controller.BajaHilado(hilado);
            dataGridView_Hilado.DataSource = null;
            dataGridView_Hilado.DataSource = controller.GetListHilado();
        }

        private void dataGridView_Hilado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Hilado hilado = dataGridView_Hilado.SelectedRows[0].DataBoundItem as Hilado;
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
            dataGridView_Hilado.Columns.Add("Codigo", "Codigo");
            dataGridView_Hilado.Columns["Codigo"].DataPropertyName = "Codigo";
            dataGridView_Hilado.Columns.Add("Descripcion", "Descripción");
            dataGridView_Hilado.Columns["Descripcion"].DataPropertyName = "Descripcion";
            dataGridView_Hilado.Columns.Add("Cantidad", "Cantidad");
            dataGridView_Hilado.Columns["Cantidad"].DataPropertyName = "Cantidad";
            dataGridView_Hilado.Columns.Add("Peso", "Peso");
            dataGridView_Hilado.Columns["Peso"].DataPropertyName = "Peso";
            dataGridView_Hilado.AutoGenerateColumns = false;
            dataGridView_Tela.Columns.Add("Codigo", "Codigo");
            dataGridView_Tela.Columns["Codigo"].DataPropertyName = "Codigo";
            dataGridView_Tela.Columns.Add("Descripcion", "Descripción");
            dataGridView_Tela.Columns["Descripcion"].DataPropertyName = "Descripcion";
            dataGridView_Tela.Columns.Add("Cantidad", "Cantidad");
            dataGridView_Tela.Columns["Cantidad"].DataPropertyName = "Cantidad";
            dataGridView_Tela.Columns.Add("Color", "Color");
            dataGridView_Tela.Columns["Color"].DataPropertyName = "Color";
            dataGridView_Tela.AutoGenerateColumns = false;
        }
    }
}
