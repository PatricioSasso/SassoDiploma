using BE;
using Microsoft.VisualBasic;
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
    public partial class AreaConfeccionadoMenu : Form
    {
        public AreaConfeccionadoMenu()
        {
            InitializeComponent();
        }

        public AreaConfeccionadoMenu(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        Controller controller;

        private void AreaConfeccionadoMenu_Load(object sender, EventArgs e)
        {
            IniciarControles();
            PrendaGestor prendaGestor = new PrendaGestor();
            dgv_Prendas.DataSource = null;
            dgv_Prendas.DataSource = prendaGestor.GetListPrendaSinConfeccionar();
            dgv_PrendasConfeccionadas.DataSource = null;
            dgv_PrendasConfeccionadas.DataSource = prendaGestor.GetListPrendaConfeccionada();
        }

        public void IniciarControles()
        {
            dgv_Prendas.Columns.Add("Codigo", "Codigo");
            dgv_Prendas.Columns["Codigo"].DataPropertyName = "Codigo";
            dgv_Prendas.Columns.Add("Descripcion", "Descripción");
            dgv_Prendas.Columns["Descripcion"].DataPropertyName = "Descripcion";
            dgv_Prendas.Columns.Add("Cantidad", "Cantidad");
            dgv_Prendas.Columns["Cantidad"].DataPropertyName = "Cantidad";
            dgv_Prendas.Columns.Add("Talle", "Talle");
            dgv_Prendas.Columns["Talle"].DataPropertyName = "Talle";
            dgv_Prendas.AutoGenerateColumns = false;
            dgv_Prendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_PrendasConfeccionadas.Columns.Add("Codigo", "Codigo");
            dgv_PrendasConfeccionadas.Columns["Codigo"].DataPropertyName = "Codigo";
            dgv_PrendasConfeccionadas.Columns.Add("Descripcion", "Descripción");
            dgv_PrendasConfeccionadas.Columns["Descripcion"].DataPropertyName = "Descripcion";
            dgv_PrendasConfeccionadas.Columns.Add("Cantidad", "Cantidad");
            dgv_PrendasConfeccionadas.Columns["Cantidad"].DataPropertyName = "Cantidad";
            dgv_PrendasConfeccionadas.Columns.Add("Talle", "Talle");
            dgv_PrendasConfeccionadas.Columns["Talle"].DataPropertyName = "Talle";
            dgv_PrendasConfeccionadas.Columns.Add("Confeccionada", "Confeccionada");
            dgv_PrendasConfeccionadas.Columns["Confeccionada"].DataPropertyName = "Confeccionada";
            dgv_PrendasConfeccionadas.AutoGenerateColumns = false;
            dgv_PrendasConfeccionadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_PrendasConfeccionadas.MultiSelect = false;
        }

        private void btn_AltaPrenda_Click(object sender, EventArgs e)
        {
            controller.AltaPrenda(txt_Codigo.Text, txt_Descripcion.Text, int.Parse(txt_Cantidad.Text), txt_Talle.Text);
            PrendaGestor prendaGestor = new PrendaGestor();
            dgv_Prendas.DataSource = null;
            dgv_Prendas.DataSource = prendaGestor.GetListPrendaSinConfeccionar();
        }

        private void btn_ModificarPrenda_Click(object sender, EventArgs e)
        {
            Prenda prenda = dgv_Prendas.SelectedRows[0].DataBoundItem as Prenda;
            prenda.Descripcion = txt_Descripcion.Text;
            prenda.Cantidad = int.Parse(txt_Cantidad.Text);
            prenda.Talle = txt_Talle.Text;
            controller.ModificarPrenda(prenda);
            dgv_Prendas.DataSource = null;
            dgv_Prendas.DataSource = controller.GetListPrenda();
        }

        private void btn_BajaPrenda_Click(object sender, EventArgs e)
        {
            Prenda prenda = dgv_Prendas.SelectedRows[0].DataBoundItem as Prenda;
            controller.BajaPrenda(prenda);
            dgv_Prendas.DataSource = null;
            dgv_Prendas.DataSource = controller.GetListPrenda();
        }

        private void btn_MenuPrincipal_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(this.Owner);
        }

        private void dgv_Prendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Prenda prenda = dgv_Prendas.SelectedRows[0].DataBoundItem as Prenda;
            txt_Codigo.Text = prenda.Codigo;
            txt_Descripcion.Text = prenda.Descripcion;
            txt_Cantidad.Text = prenda.Cantidad.ToString();
            txt_Talle.Text = prenda.Talle;
        }

        private void btn_Confeccionar_Click(object sender, EventArgs e)
        {
            Prenda prenda = dgv_Prendas.SelectedRows[0].DataBoundItem as Prenda;
            int cantidadPrenda = int.Parse(Interaction.InputBox("Ingrese la cantidad de prendas a confeccionar."));
            string codigoPrenda = Interaction.InputBox("Ingrese el código que tendrán las prendas resultantes.");
            controller.Confeccionar(prenda, cantidadPrenda, codigoPrenda);
            PrendaGestor prendaGestor = new PrendaGestor();
            dgv_Prendas.DataSource = null;
            dgv_Prendas.DataSource = prendaGestor.GetListPrendaSinConfeccionar();
            dgv_PrendasConfeccionadas.DataSource = null;
            dgv_PrendasConfeccionadas.DataSource = prendaGestor.GetListPrendaConfeccionada();
        }

        private void btn_Solicitar_Click(object sender, EventArgs e)
        {
            List<ItemProducto> productos = new List<ItemProducto>();
            foreach (DataGridViewRow prenda in dgv_Prendas.SelectedRows)
            {
                int cantidad = int.Parse(Interaction.InputBox("¿Cuánta cantidad de la tinte " + (prenda.DataBoundItem as Prenda).Codigo + " desea solicitar?"));
                productos.Add(new ItemProducto(cantidad, prenda.DataBoundItem as Prenda));
            }
            controller.SolicitarProducto(productos);
        }

        private void AreaConfeccionadoMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
