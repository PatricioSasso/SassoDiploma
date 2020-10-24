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
    public partial class AreaCortadoMenu : Form
    {
        public AreaCortadoMenu()
        {
            InitializeComponent();
        }

        public AreaCortadoMenu(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        Controller controller;

        private void AreaCortado_Load(object sender, EventArgs e)
        {
            IniciarControles();
            TelaGestor telaGestor = new TelaGestor();
            PrendaGestor prendaGestor = new PrendaGestor();
            dgv_Telas.DataSource = null;
            dgv_Telas.DataSource = telaGestor.GetListTela();
            dgv_Prendas.DataSource = null;
            dgv_Prendas.DataSource = prendaGestor.GetListPrenda();
        }

        public void IniciarControles()
        {
            dgv_Telas.Columns.Add("Codigo", "Codigo");
            dgv_Telas.Columns["Codigo"].DataPropertyName = "Codigo";
            dgv_Telas.Columns.Add("Descripcion", "Descripción");
            dgv_Telas.Columns["Descripcion"].DataPropertyName = "Descripcion";
            dgv_Telas.Columns.Add("Cantidad", "Cantidad");
            dgv_Telas.Columns["Cantidad"].DataPropertyName = "Cantidad";
            dgv_Telas.Columns.Add("Color", "Color");
            dgv_Telas.Columns["Color"].DataPropertyName = "Color";
            dgv_Telas.Columns.Add("Teñido", "Teñido");
            dgv_Telas.Columns["Teñido"].DataPropertyName = "Teñido";
            dgv_Telas.AutoGenerateColumns = false;
            dgv_Telas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Telas.MultiSelect = false;
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
        }

        private void btn_AltaTela_Click(object sender, EventArgs e)
        {
            controller.AltaTela(txt_Codigo.Text, txt_Descripcion.Text, int.Parse(txt_Cantidad.Text), txt_Color.Text, false);
            TelaGestor telaGestor = new TelaGestor();
            dgv_Telas.DataSource = null;
            dgv_Telas.DataSource = telaGestor.GetListTela();
        }

        private void btn_ModificarTela_Click(object sender, EventArgs e)
        {
            Tela tela = dgv_Telas.SelectedRows[0].DataBoundItem as Tela;
            tela.Descripcion = txt_Descripcion.Text;
            tela.Cantidad = int.Parse(txt_Cantidad.Text);
            tela.Color = txt_Color.Text;
            controller.ModificarTela(tela);
            TelaGestor telaGestor = new TelaGestor();
            dgv_Telas.DataSource = null;
            dgv_Telas.DataSource = telaGestor.GetListTela();
        }

        private void btn_BajaTela_Click(object sender, EventArgs e)
        {
            Tela tela = dgv_Telas.SelectedRows[0].DataBoundItem as Tela;
            controller.BajaTela(tela);
            TelaGestor telaGestor = new TelaGestor();
            dgv_Telas.DataSource = null;
            dgv_Telas.DataSource = telaGestor.GetListTela();
        }

        private void dgv_Telas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Tela tela = dgv_Telas.SelectedRows[0].DataBoundItem as Tela;
            txt_Codigo.Text = tela.Codigo;
            txt_Descripcion.Text = tela.Descripcion;
            txt_Cantidad.Text = tela.Cantidad.ToString();
            txt_Color.Text = tela.Color;
        }

        private void btn_MenuPrincipal_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(this.Owner);
        }

        private void btn_Cortar_Click(object sender, EventArgs e)
        {
            Tela tela = dgv_Telas.SelectedRows[0].DataBoundItem as Tela;
            int cantTela = int.Parse(Interaction.InputBox("¿Cuánta cantidad de la tela seleccionada desea utilizar?"));
            int dimensiones = int.Parse(Interaction.InputBox("Ingrese el área de la tela en m2"));
            string talle = Interaction.InputBox("Ingrese si el talle deseado es S, M o L");
            string codigoPrenda = Interaction.InputBox("Ingrese el código de las prendas resultantes");
            controller.Cortar(tela, cantTela, dimensiones, talle, codigoPrenda);
            TelaGestor telaGestor = new TelaGestor();
            PrendaGestor prendaGestor = new PrendaGestor();
            dgv_Telas.DataSource = null;
            dgv_Telas.DataSource = telaGestor.GetListTela();
            dgv_Prendas.DataSource = null;
            dgv_Prendas.DataSource = prendaGestor.GetListPrenda();
        }

        private void btn_Solicitar_Click(object sender, EventArgs e)
        {
            List<ItemProducto> productos = new List<ItemProducto>();
            foreach (DataGridViewRow prenda in dgv_Prendas.SelectedRows)
            {
                int cantidad = int.Parse(Interaction.InputBox("¿Cuánta cantidad de la prenda " + (prenda.DataBoundItem as Prenda).Codigo + " desea solicitar?"));
                productos.Add(new ItemProducto(cantidad, prenda.DataBoundItem as Prenda));
            }
            controller.SolicitarProducto(productos);
        }
    }
}
