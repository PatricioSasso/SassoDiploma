using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using Microsoft.VisualBasic;

namespace GUI
{
    public partial class GestionProduccionMenu : Form
    {
        public GestionProduccionMenu()
        {
            InitializeComponent();
        }

        public GestionProduccionMenu(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        Controller controller;

        private void GestionProduccionMenu_Load(object sender, EventArgs e)
        {
            IniciarControles();
            PedidoProduccionGestor pedidoProduccionGestor = new PedidoProduccionGestor();
            dgv_PedidoProduccion.DataSource = null;
            dgv_PedidoProduccion.DataSource = pedidoProduccionGestor.GetList();
            dgv_SolicitudProduccion.DataSource = null;
            dgv_SolicitudProduccion.DataSource = pedidoProduccionGestor.GetListSolicitud();
            txt_Info.Text = controller.ActualizarInfo(dgv_Recomendaciones, dgv_ItemRecomendacion);
        }

        public void IniciarControles()
        {
            dgv_PedidoProduccion.Columns.Add("Id", "Número de Pedido");
            dgv_PedidoProduccion.Columns["Id"].DataPropertyName = "Id";
            dgv_PedidoProduccion.Columns.Add("FechaProduccion", "Fecha de Produccion");
            dgv_PedidoProduccion.Columns["FechaProduccion"].DataPropertyName = "FechaProduccion";
            dgv_PedidoProduccion.Columns.Add("Estado", "Estado");
            dgv_PedidoProduccion.Columns["Estado"].DataPropertyName = "Estado";
            dgv_PedidoProduccion.AutoGenerateColumns = false;
            dgv_PedidoProduccion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_PedidoProduccion.MultiSelect = false;
            dgv_ItemPedidoProduccion.Columns.Add("Producto", "Producto");
            dgv_ItemPedidoProduccion.Columns["Producto"].DataPropertyName = "Producto";
            dgv_ItemPedidoProduccion.Columns["Producto"].Width = 220;
            dgv_ItemPedidoProduccion.Columns.Add("Cantidad", "Cantidad");
            dgv_ItemPedidoProduccion.Columns["Cantidad"].DataPropertyName = "Cantidad";
            dgv_ItemPedidoProduccion.AutoGenerateColumns = false;
            dgv_ItemPedidoProduccion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ItemPedidoProduccion.MultiSelect = false;
            dgv_SolicitudProduccion.Columns.Add("Id", "Número de Solicitud");
            dgv_SolicitudProduccion.Columns["Id"].DataPropertyName = "Id";
            dgv_SolicitudProduccion.Columns.Add("Estado", "Estado");
            dgv_SolicitudProduccion.Columns["Estado"].DataPropertyName = "Estado";
            dgv_SolicitudProduccion.AutoGenerateColumns = false;
            dgv_SolicitudProduccion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_SolicitudProduccion.MultiSelect = false;
            dgv_ItemSolicitudProduccion.Columns.Add("Producto", "Producto");
            dgv_ItemSolicitudProduccion.Columns["Producto"].Width = 220;
            dgv_ItemSolicitudProduccion.Columns["Producto"].DataPropertyName = "Producto";
            dgv_ItemSolicitudProduccion.Columns.Add("Cantidad", "Cantidad");
            dgv_ItemSolicitudProduccion.Columns["Cantidad"].DataPropertyName = "Cantidad";
            dgv_ItemSolicitudProduccion.AutoGenerateColumns = false;
            dgv_ItemSolicitudProduccion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ItemSolicitudProduccion.MultiSelect = false;
            dgv_Recomendaciones.Columns.Add("FechaProduccion", "Fecha de Produccion");
            dgv_Recomendaciones.Columns["FechaProduccion"].DataPropertyName = "FechaProduccion";
            dgv_Recomendaciones.Columns.Add("Estado", "Estado");
            dgv_Recomendaciones.Columns["Estado"].DataPropertyName = "Estado";
            dgv_Recomendaciones.AutoGenerateColumns = false;
            dgv_Recomendaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ItemRecomendacion.Columns.Add("Producto", "Producto");
            dgv_ItemRecomendacion.Columns["Producto"].DataPropertyName = "Producto";
            dgv_ItemRecomendacion.Columns["Producto"].Width = 220;
            dgv_ItemRecomendacion.Columns.Add("Cantidad", "Cantidad");
            dgv_ItemRecomendacion.Columns["Cantidad"].DataPropertyName = "Cantidad";
            dgv_ItemRecomendacion.AutoGenerateColumns = false;
            dgv_ItemRecomendacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ItemRecomendacion.MultiSelect = false;
        }

        private void dgv_PedidoProduccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PedidoProduccion selected = dgv_PedidoProduccion.SelectedRows[0].DataBoundItem as PedidoProduccion;
            ItemProductoGestor itemProductoGestor = new ItemProductoGestor();
            dgv_ItemPedidoProduccion.DataSource = null;
            dgv_ItemPedidoProduccion.DataSource = itemProductoGestor.GetList(selected);
        }

        private void dgv_SolicitudProduccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PedidoProduccion selected = dgv_SolicitudProduccion.SelectedRows[0].DataBoundItem as PedidoProduccion;
            ItemProductoGestor itemProductoGestor = new ItemProductoGestor();
            dgv_ItemSolicitudProduccion.DataSource = null;
            dgv_ItemSolicitudProduccion.DataSource = itemProductoGestor.GetList(selected);
        }

        private void dgv_Recomendaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PedidoProduccion selected = dgv_Recomendaciones.SelectedRows[0].DataBoundItem as PedidoProduccion;
            dgv_ItemRecomendacion.DataSource = null;
            dgv_ItemRecomendacion.DataSource = selected.ItemProductos;
        }

        private void dgv_ItemPedidoProduccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemProducto selected = dgv_ItemPedidoProduccion.SelectedRows[0].DataBoundItem as ItemProducto;
            txt_Codigo.Text = selected.Producto.Codigo;
            txt_Descripcion.Text = selected.Producto.Descripcion;
            txt_Cantidad.Text = selected.Cantidad.ToString();
        }

        private void btn_CrearPedidoProduccion_Click(object sender, EventArgs e)
        {
            DateTime fecha = datePckr.Value;
            controller.RegistrarPedido(fecha);
            PedidoProduccionGestor pedidoProduccionGestor = new PedidoProduccionGestor();
            dgv_PedidoProduccion.DataSource = null;
            dgv_PedidoProduccion.DataSource = pedidoProduccionGestor.GetList();
        }

        private void btn_AltaItemProducto_Click(object sender, EventArgs e)
        {
            PedidoProduccion selected = dgv_PedidoProduccion.SelectedRows[0].DataBoundItem as PedidoProduccion;
            Producto producto = new Producto(txt_Codigo.Text, txt_Descripcion.Text, int.Parse(txt_Cantidad.Text));
            controller.AltaItemProducto(selected, producto);
            ItemProductoGestor itemProductoGestor = new ItemProductoGestor();
            dgv_ItemPedidoProduccion.DataSource = null;
            dgv_ItemPedidoProduccion.DataSource = itemProductoGestor.GetList(selected);
        }

        private void btn_BajaItemProducto_Click(object sender, EventArgs e)
        {
            ItemProducto selected = dgv_ItemPedidoProduccion.SelectedRows[0].DataBoundItem as ItemProducto;
            PedidoProduccion pedido = selected.Pedido;
            pedido.ItemProductos.Remove(selected);
            ProductoGestor productoGestor = new ProductoGestor();
            productoGestor.Baja(selected.Producto);
            ItemProductoGestor itemProductoGestor = new ItemProductoGestor();
            itemProductoGestor.Baja(selected);
            dgv_ItemPedidoProduccion.DataSource = null;
            dgv_ItemPedidoProduccion.DataSource = itemProductoGestor.GetList(pedido);
        }

        private void btn_EliminarPedidoProduccion_Click(object sender, EventArgs e)
        {
            PedidoProduccion selected = dgv_PedidoProduccion.SelectedRows[0].DataBoundItem as PedidoProduccion;
            PedidoProduccionGestor pedidoProduccionGestor = new PedidoProduccionGestor();
            pedidoProduccionGestor.Baja(selected);
            dgv_PedidoProduccion.DataSource = null;
            dgv_PedidoProduccion.DataSource = pedidoProduccionGestor.GetList();
        }

        private void btn_PedidoProduccionCompletado_Click(object sender, EventArgs e)
        {
            PedidoProduccion selected = dgv_PedidoProduccion.SelectedRows[0].DataBoundItem as PedidoProduccion;
            controller.modificarPedidoProduccion(selected, "Completado");
            PedidoProduccionGestor pedidoProduccionGestor = new PedidoProduccionGestor();
            dgv_PedidoProduccion.DataSource = null;
            dgv_PedidoProduccion.DataSource = pedidoProduccionGestor.GetList();
        }

        private void btn_SolicitudProduccionCompleta_Click(object sender, EventArgs e)
        {
            PedidoProduccion selected = dgv_SolicitudProduccion.SelectedRows[0].DataBoundItem as PedidoProduccion;
            controller.modificarPedidoProduccion(selected, "Completado");
            PedidoProduccionGestor pedidoProduccionGestor = new PedidoProduccionGestor();
            dgv_SolicitudProduccion.DataSource = null;
            dgv_SolicitudProduccion.DataSource = pedidoProduccionGestor.GetListSolicitud();
        }

        private void btn_MenuPrincipal_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(this.Owner);
        }

        private void btn_ActualizarInfo_Click(object sender, EventArgs e)
        {
            txt_Info.Text = controller.ActualizarInfo(dgv_Recomendaciones, dgv_ItemRecomendacion);
        }

        private void btn_AplicarRecomendaciones_Click(object sender, EventArgs e)
        {
            controller.AplicarRecomendaciones(dgv_Recomendaciones);
            PedidoProduccionGestor pedidoProduccionGestor = new PedidoProduccionGestor();
            dgv_PedidoProduccion.DataSource = null;
            dgv_PedidoProduccion.DataSource = pedidoProduccionGestor.GetList();
            dgv_ItemRecomendacion.DataSource = null;
        }

        private void GestionProduccionMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
