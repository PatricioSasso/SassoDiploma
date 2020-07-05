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
            dgv_Prendas.MultiSelect = false;
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
            dgv_PrendasConfeccionadas.Columns.Add("TiempoConfeccion", "tiempo de Confeccion");
            dgv_PrendasConfeccionadas.Columns["TiempoConfeccion"].DataPropertyName = "TiempoConfeccion";
            dgv_PrendasConfeccionadas.AutoGenerateColumns = false;
            dgv_PrendasConfeccionadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_PrendasConfeccionadas.MultiSelect = false;
        }

        private void btn_AltaTela_Click(object sender, EventArgs e)
        {
            controller.AltaPrenda(int.Parse(txt_Id.Text), txt_Codigo.Text, txt_Descripcion.Text, int.Parse(txt_Cantidad.Text), txt_Talle.Text);
            PrendaGestor prendaGestor = new PrendaGestor();
            dgv_Prendas.DataSource = null;
            dgv_Prendas.DataSource = prendaGestor.GetListPrendaSinConfeccionar();
        }

        private void btn_ModificarTela_Click(object sender, EventArgs e)
        {
            Prenda prenda = dgv_Prendas.SelectedRows[0].DataBoundItem as Prenda;
            prenda.Descripcion = txt_Descripcion.Text;
            prenda.Cantidad = int.Parse(txt_Cantidad.Text);
            prenda.Talle = txt_Talle.Text;
            controller.ModificarPrenda(prenda);
            PrendaGestor prendaGestor = new PrendaGestor();
            dgv_Prendas.DataSource = null;
            dgv_Prendas.DataSource = prendaGestor.GetListPrendaSinConfeccionar();
        }

        private void btn_BajaTela_Click(object sender, EventArgs e)
        {
            Prenda prenda = dgv_Prendas.SelectedRows[0].DataBoundItem as Prenda;
            controller.BajaPrenda(prenda);
            PrendaGestor prendaGestor = new PrendaGestor();
            dgv_Prendas.DataSource = null;
            dgv_Prendas.DataSource = prendaGestor.GetListPrendaSinConfeccionar();
        }

        private void btn_MenuPrincipal_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(this.Owner);
        }

        private void dgv_Prendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Prenda prenda = dgv_Prendas.SelectedRows[0].DataBoundItem as Prenda;
            txt_Id.Text = prenda.Id.ToString();
            txt_Codigo.Text = prenda.Codigo;
            txt_Descripcion.Text = prenda.Descripcion;
            txt_Cantidad.Text = prenda.Cantidad.ToString();
            txt_Talle.Text = prenda.Talle;
        }

        private void btn_Confeccionar_Click(object sender, EventArgs e)
        {
            //TO DO: Implement.
        }
    }
}
