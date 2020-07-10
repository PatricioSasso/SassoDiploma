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
    public partial class AreaTeñidoMenu : Form
    {
        public AreaTeñidoMenu()
        {
            InitializeComponent();
        }

        public AreaTeñidoMenu(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        Controller controller;

        private void AreaTeñidoMenu_Load(object sender, EventArgs e)
        {
            IniciarControles();
            TelaGestor telaGestor = new TelaGestor();
            TinteGestor tinteGestor = new TinteGestor();
            dgv_Telas.DataSource = null;
            dgv_Telas.DataSource = telaGestor.GetListTelaSinTeñir();
            dgv_TelasTeñidas.DataSource = null;
            dgv_TelasTeñidas.DataSource = telaGestor.GetListTelaTeñida();
            dgv_Tintes.DataSource = null;
            dgv_Tintes.DataSource = tinteGestor.GetListTinte();
        }

        private void IniciarControles()
        {
            dgv_Telas.Columns.Add("Codigo", "Codigo");
            dgv_Telas.Columns["Codigo"].DataPropertyName = "Codigo";
            dgv_Telas.Columns.Add("Descripcion", "Descripción");
            dgv_Telas.Columns["Descripcion"].DataPropertyName = "Descripcion";
            dgv_Telas.Columns.Add("Cantidad", "Cantidad");
            dgv_Telas.Columns["Cantidad"].DataPropertyName = "Cantidad";
            dgv_Telas.AutoGenerateColumns = false;
            dgv_Telas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Telas.MultiSelect = false;
            dgv_Tintes.Columns.Add("Codigo", "Codigo");
            dgv_Tintes.Columns["Codigo"].DataPropertyName = "Codigo";
            dgv_Tintes.Columns.Add("Descripcion", "Descripción");
            dgv_Tintes.Columns["Descripcion"].DataPropertyName = "Descripcion";
            dgv_Tintes.Columns.Add("Cantidad", "Cantidad");
            dgv_Tintes.Columns["Cantidad"].DataPropertyName = "Cantidad";
            dgv_Tintes.Columns.Add("Color", "Color");
            dgv_Tintes.Columns["Color"].DataPropertyName = "Color";
            dgv_Tintes.AutoGenerateColumns = false;
            dgv_Tintes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Tintes.MultiSelect = false;
            dgv_TelasTeñidas.Columns.Add("Codigo", "Codigo");
            dgv_TelasTeñidas.Columns["Codigo"].DataPropertyName = "Codigo";
            dgv_TelasTeñidas.Columns.Add("Descripcion", "Descripción");
            dgv_TelasTeñidas.Columns["Descripcion"].DataPropertyName = "Descripcion";
            dgv_TelasTeñidas.Columns.Add("Cantidad", "Cantidad");
            dgv_TelasTeñidas.Columns["Cantidad"].DataPropertyName = "Cantidad";
            dgv_TelasTeñidas.Columns.Add("Color", "Color");
            dgv_TelasTeñidas.Columns["Color"].DataPropertyName = "Color";
            dgv_TelasTeñidas.Columns.Add("Teñido", "Teñido");
            dgv_TelasTeñidas.Columns["Teñido"].DataPropertyName = "Teñido";
            dgv_TelasTeñidas.AutoGenerateColumns = false;
            dgv_TelasTeñidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_TelasTeñidas.MultiSelect = false;
        }

        private void btn_AltaTela_Click(object sender, EventArgs e)
        {
            TelaGestor telaGestor = new TelaGestor();
            controller.AltaTela(int.Parse(txt_Id.Text), txt_Codigo.Text, txt_Descripcion.Text, int.Parse(txt_Cantidad.Text), "", false);
            dgv_Telas.DataSource = null;
            dgv_Telas.DataSource = telaGestor.GetListTela();
        }

        private void btn_ModificarTela_Click(object sender, EventArgs e)
        {
            TelaGestor telaGestor = new TelaGestor();
            Tela tela = dgv_Telas.SelectedRows[0].DataBoundItem as Tela;
            tela.Descripcion = txt_Descripcion.Text;
            tela.Cantidad = int.Parse(txt_Cantidad.Text);
            controller.ModificarTela(tela);
            dgv_Telas.DataSource = null;
            dgv_Telas.DataSource = telaGestor.GetListTela();
        }

        private void btn_BajaTela_Click(object sender, EventArgs e)
        {
            TelaGestor telaGestor = new TelaGestor();
            Tela tela = dgv_Telas.SelectedRows[0].DataBoundItem as Tela;
            controller.BajaTela(tela);
            dgv_Telas.DataSource = null;
            dgv_Telas.DataSource = telaGestor.GetListTela();
        }

        private void dgv_Telas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Tela tela = dgv_Telas.SelectedRows[0].DataBoundItem as Tela;
            txt_Id.Text = tela.Id.ToString();
            txt_Codigo.Text = tela.Codigo;
            txt_Descripcion.Text = tela.Descripcion;
            txt_Cantidad.Text = tela.Cantidad.ToString();
        }

        private void btn_AltaTinte_Click(object sender, EventArgs e)
        {
            TinteGestor tinteGestor = new TinteGestor();
            controller.AltaTinte(int.Parse(txt_IdTinte.Text), txt_CodigoTinte.Text, txt_DescripcionTinte.Text, int.Parse(txt_CantidadTinte.Text), txt_ColorTinte.Text);
            dgv_Tintes.DataSource = null;
            dgv_Tintes.DataSource = tinteGestor.GetListTinte();
        }

        private void btn_ModificarTinte_Click(object sender, EventArgs e)
        {
            TinteGestor tinteGestor = new TinteGestor();
            Tinte tinte = dgv_Tintes.SelectedRows[0].DataBoundItem as Tinte;
            tinte.Descripcion = txt_DescripcionTinte.Text;
            tinte.Cantidad = int.Parse(txt_CantidadTinte.Text);
            tinte.Color = txt_ColorTinte.Text;
            controller.ModificarTinte(tinte);
            dgv_Tintes.DataSource = null;
            dgv_Tintes.DataSource = tinteGestor.GetListTinte();
        }

        private void btn_BajaTinte_Click(object sender, EventArgs e)
        {
            TinteGestor tinteGestor = new TinteGestor();
            Tinte tinte = dgv_Tintes.SelectedRows[0].DataBoundItem as Tinte;
            controller.BajaTinte(tinte);
            dgv_Tintes.DataSource = null;
            dgv_Tintes.DataSource = tinteGestor.GetListTinte();

        }

        private void dgv_Tintes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Tinte tinte = dgv_Tintes.SelectedRows[0].DataBoundItem as Tinte;
            txt_IdTinte.Text = tinte.Id.ToString();
            txt_CodigoTinte.Text = tinte.Codigo;
            txt_DescripcionTinte.Text = tinte.Descripcion;
            txt_CantidadTinte.Text = tinte.Cantidad.ToString();
            txt_ColorTinte.Text = tinte.Color;
        }

        private void btn_Teñir_Click(object sender, EventArgs e)
        {
            Tela tela = dgv_Telas.SelectedRows[0].DataBoundItem as Tela;
            Tinte tinte = dgv_Tintes.SelectedRows[0].DataBoundItem as Tinte;
            int cantTelaUtilizada = int.Parse(Interaction.InputBox("¿Cuánta cantidad de la tela seleccionada desea utilizar?"));
            int cantTinteUtilizado = int.Parse(Interaction.InputBox("¿Cuánta cantidad del tinte selecionado desea utilizar?"));
            string codigoTela = Interaction.InputBox("Ingrese el nombre de la tela tintada resultante");
            controller.Teñir(tela, cantTelaUtilizada, tinte, cantTinteUtilizado, codigoTela);
            TelaGestor telaGestor = new TelaGestor();
            TinteGestor tinteGestor = new TinteGestor();
            dgv_Telas.DataSource = null;
            dgv_Telas.DataSource = telaGestor.GetListTelaSinTeñir();
            dgv_TelasTeñidas.DataSource = null;
            dgv_TelasTeñidas.DataSource = telaGestor.GetListTelaTeñida();
            dgv_Tintes.DataSource = null;
            dgv_Tintes.DataSource = tinteGestor.GetListTinte();
        }

        private void btn_MenuPrincipal_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(this.Owner);
        }
    }
}
