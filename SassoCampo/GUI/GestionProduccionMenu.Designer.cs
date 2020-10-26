namespace GUI
{
    partial class GestionProduccionMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_PedidoProduccion = new System.Windows.Forms.DataGridView();
            this.dgv_SolicitudProduccion = new System.Windows.Forms.DataGridView();
            this.dgv_ItemPedidoProduccion = new System.Windows.Forms.DataGridView();
            this.dgv_ItemSolicitudProduccion = new System.Windows.Forms.DataGridView();
            this.btn_CrearPedidoProduccion = new System.Windows.Forms.Button();
            this.datePckr = new System.Windows.Forms.DateTimePicker();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.btn_SolicitudProduccionCompleta = new System.Windows.Forms.Button();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.btn_AltaItemProducto = new System.Windows.Forms.Button();
            this.btn_EliminarPedidoProduccion = new System.Windows.Forms.Button();
            this.btn_PedidoProduccionCompletado = new System.Windows.Forms.Button();
            this.btn_BajaItemProducto = new System.Windows.Forms.Button();
            this.gbx_Pedido = new System.Windows.Forms.GroupBox();
            this.gbx_Solicitud = new System.Windows.Forms.GroupBox();
            this.btn_MenuPrincipal = new System.Windows.Forms.Button();
            this.btn_ActualizarInfo = new System.Windows.Forms.Button();
            this.txt_Info = new System.Windows.Forms.RichTextBox();
            this.gbx_Info = new System.Windows.Forms.GroupBox();
            this.dgv_Recomendaciones = new System.Windows.Forms.DataGridView();
            this.btn_AplicarRecomendaciones = new System.Windows.Forms.Button();
            this.gbx_Recomendacion = new System.Windows.Forms.GroupBox();
            this.dgv_ItemRecomendacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PedidoProduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SolicitudProduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemPedidoProduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemSolicitudProduccion)).BeginInit();
            this.gbx_Pedido.SuspendLayout();
            this.gbx_Solicitud.SuspendLayout();
            this.gbx_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recomendaciones)).BeginInit();
            this.gbx_Recomendacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemRecomendacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PedidoProduccion
            // 
            this.dgv_PedidoProduccion.AllowUserToAddRows = false;
            this.dgv_PedidoProduccion.AllowUserToDeleteRows = false;
            this.dgv_PedidoProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PedidoProduccion.Location = new System.Drawing.Point(313, 368);
            this.dgv_PedidoProduccion.Name = "dgv_PedidoProduccion";
            this.dgv_PedidoProduccion.ReadOnly = true;
            this.dgv_PedidoProduccion.RowHeadersWidth = 51;
            this.dgv_PedidoProduccion.RowTemplate.Height = 24;
            this.dgv_PedidoProduccion.Size = new System.Drawing.Size(500, 150);
            this.dgv_PedidoProduccion.TabIndex = 0;
            this.dgv_PedidoProduccion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PedidoProduccion_CellClick);
            // 
            // dgv_SolicitudProduccion
            // 
            this.dgv_SolicitudProduccion.AllowUserToAddRows = false;
            this.dgv_SolicitudProduccion.AllowUserToDeleteRows = false;
            this.dgv_SolicitudProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SolicitudProduccion.Location = new System.Drawing.Point(6, 21);
            this.dgv_SolicitudProduccion.Name = "dgv_SolicitudProduccion";
            this.dgv_SolicitudProduccion.ReadOnly = true;
            this.dgv_SolicitudProduccion.RowHeadersWidth = 51;
            this.dgv_SolicitudProduccion.RowTemplate.Height = 24;
            this.dgv_SolicitudProduccion.Size = new System.Drawing.Size(500, 150);
            this.dgv_SolicitudProduccion.TabIndex = 1;
            this.dgv_SolicitudProduccion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SolicitudProduccion_CellClick);
            // 
            // dgv_ItemPedidoProduccion
            // 
            this.dgv_ItemPedidoProduccion.AllowUserToAddRows = false;
            this.dgv_ItemPedidoProduccion.AllowUserToDeleteRows = false;
            this.dgv_ItemPedidoProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ItemPedidoProduccion.Location = new System.Drawing.Point(313, 524);
            this.dgv_ItemPedidoProduccion.Name = "dgv_ItemPedidoProduccion";
            this.dgv_ItemPedidoProduccion.ReadOnly = true;
            this.dgv_ItemPedidoProduccion.RowHeadersWidth = 51;
            this.dgv_ItemPedidoProduccion.RowTemplate.Height = 24;
            this.dgv_ItemPedidoProduccion.Size = new System.Drawing.Size(500, 150);
            this.dgv_ItemPedidoProduccion.TabIndex = 2;
            this.dgv_ItemPedidoProduccion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ItemPedidoProduccion_CellClick);
            // 
            // dgv_ItemSolicitudProduccion
            // 
            this.dgv_ItemSolicitudProduccion.AllowUserToAddRows = false;
            this.dgv_ItemSolicitudProduccion.AllowUserToDeleteRows = false;
            this.dgv_ItemSolicitudProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ItemSolicitudProduccion.Location = new System.Drawing.Point(6, 180);
            this.dgv_ItemSolicitudProduccion.Name = "dgv_ItemSolicitudProduccion";
            this.dgv_ItemSolicitudProduccion.ReadOnly = true;
            this.dgv_ItemSolicitudProduccion.RowHeadersWidth = 51;
            this.dgv_ItemSolicitudProduccion.RowTemplate.Height = 24;
            this.dgv_ItemSolicitudProduccion.Size = new System.Drawing.Size(500, 150);
            this.dgv_ItemSolicitudProduccion.TabIndex = 3;
            // 
            // btn_CrearPedidoProduccion
            // 
            this.btn_CrearPedidoProduccion.Location = new System.Drawing.Point(31, 395);
            this.btn_CrearPedidoProduccion.Name = "btn_CrearPedidoProduccion";
            this.btn_CrearPedidoProduccion.Size = new System.Drawing.Size(276, 23);
            this.btn_CrearPedidoProduccion.TabIndex = 4;
            this.btn_CrearPedidoProduccion.Text = "Crear pedido de Producción";
            this.btn_CrearPedidoProduccion.UseVisualStyleBackColor = true;
            this.btn_CrearPedidoProduccion.Click += new System.EventHandler(this.btn_CrearPedidoProduccion_Click);
            // 
            // datePckr
            // 
            this.datePckr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePckr.Location = new System.Drawing.Point(184, 367);
            this.datePckr.Name = "datePckr";
            this.datePckr.Size = new System.Drawing.Size(123, 22);
            this.datePckr.TabIndex = 5;
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(28, 372);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(150, 17);
            this.lbl_Fecha.TabIndex = 6;
            this.lbl_Fecha.Text = "Fecha de Producción :";
            // 
            // btn_SolicitudProduccionCompleta
            // 
            this.btn_SolicitudProduccionCompleta.Location = new System.Drawing.Point(6, 336);
            this.btn_SolicitudProduccionCompleta.Name = "btn_SolicitudProduccionCompleta";
            this.btn_SolicitudProduccionCompleta.Size = new System.Drawing.Size(497, 23);
            this.btn_SolicitudProduccionCompleta.TabIndex = 7;
            this.btn_SolicitudProduccionCompleta.Text = "Solicitud Completa";
            this.btn_SolicitudProduccionCompleta.UseVisualStyleBackColor = true;
            this.btn_SolicitudProduccionCompleta.Click += new System.EventHandler(this.btn_SolicitudProduccionCompleta_Click);
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(58, 527);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(60, 17);
            this.lbl_Codigo.TabIndex = 8;
            this.lbl_Codigo.Text = "Código :";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(28, 556);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(90, 17);
            this.lbl_Descripcion.TabIndex = 9;
            this.lbl_Descripcion.Text = "Descripción :";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(46, 587);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(72, 17);
            this.lbl_Cantidad.TabIndex = 10;
            this.lbl_Cantidad.Text = "Cantidad :";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(124, 524);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(183, 22);
            this.txt_Codigo.TabIndex = 11;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(124, 556);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(183, 22);
            this.txt_Descripcion.TabIndex = 12;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(124, 584);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(183, 22);
            this.txt_Cantidad.TabIndex = 13;
            // 
            // btn_AltaItemProducto
            // 
            this.btn_AltaItemProducto.Location = new System.Drawing.Point(31, 612);
            this.btn_AltaItemProducto.Name = "btn_AltaItemProducto";
            this.btn_AltaItemProducto.Size = new System.Drawing.Size(276, 23);
            this.btn_AltaItemProducto.TabIndex = 16;
            this.btn_AltaItemProducto.Text = "Agregar Producto";
            this.btn_AltaItemProducto.UseVisualStyleBackColor = true;
            this.btn_AltaItemProducto.Click += new System.EventHandler(this.btn_AltaItemProducto_Click);
            // 
            // btn_EliminarPedidoProduccion
            // 
            this.btn_EliminarPedidoProduccion.Location = new System.Drawing.Point(19, 77);
            this.btn_EliminarPedidoProduccion.Name = "btn_EliminarPedidoProduccion";
            this.btn_EliminarPedidoProduccion.Size = new System.Drawing.Size(276, 23);
            this.btn_EliminarPedidoProduccion.TabIndex = 17;
            this.btn_EliminarPedidoProduccion.Text = "Eliminar pedido de Producción";
            this.btn_EliminarPedidoProduccion.UseVisualStyleBackColor = true;
            this.btn_EliminarPedidoProduccion.Click += new System.EventHandler(this.btn_EliminarPedidoProduccion_Click);
            // 
            // btn_PedidoProduccionCompletado
            // 
            this.btn_PedidoProduccionCompletado.Location = new System.Drawing.Point(31, 453);
            this.btn_PedidoProduccionCompletado.Name = "btn_PedidoProduccionCompletado";
            this.btn_PedidoProduccionCompletado.Size = new System.Drawing.Size(276, 23);
            this.btn_PedidoProduccionCompletado.TabIndex = 18;
            this.btn_PedidoProduccionCompletado.Text = "Marcar como completado";
            this.btn_PedidoProduccionCompletado.UseVisualStyleBackColor = true;
            this.btn_PedidoProduccionCompletado.Click += new System.EventHandler(this.btn_PedidoProduccionCompletado_Click);
            // 
            // btn_BajaItemProducto
            // 
            this.btn_BajaItemProducto.Location = new System.Drawing.Point(31, 641);
            this.btn_BajaItemProducto.Name = "btn_BajaItemProducto";
            this.btn_BajaItemProducto.Size = new System.Drawing.Size(276, 23);
            this.btn_BajaItemProducto.TabIndex = 19;
            this.btn_BajaItemProducto.Text = "Quitar Producto";
            this.btn_BajaItemProducto.UseVisualStyleBackColor = true;
            this.btn_BajaItemProducto.Click += new System.EventHandler(this.btn_BajaItemProducto_Click);
            // 
            // gbx_Pedido
            // 
            this.gbx_Pedido.Controls.Add(this.btn_EliminarPedidoProduccion);
            this.gbx_Pedido.Location = new System.Drawing.Point(12, 347);
            this.gbx_Pedido.Name = "gbx_Pedido";
            this.gbx_Pedido.Size = new System.Drawing.Size(817, 335);
            this.gbx_Pedido.TabIndex = 20;
            this.gbx_Pedido.TabStop = false;
            this.gbx_Pedido.Text = "Pedidos de Producción";
            // 
            // gbx_Solicitud
            // 
            this.gbx_Solicitud.Controls.Add(this.dgv_SolicitudProduccion);
            this.gbx_Solicitud.Controls.Add(this.dgv_ItemSolicitudProduccion);
            this.gbx_Solicitud.Controls.Add(this.btn_SolicitudProduccionCompleta);
            this.gbx_Solicitud.Location = new System.Drawing.Point(835, 347);
            this.gbx_Solicitud.Name = "gbx_Solicitud";
            this.gbx_Solicitud.Size = new System.Drawing.Size(512, 365);
            this.gbx_Solicitud.TabIndex = 21;
            this.gbx_Solicitud.TabStop = false;
            this.gbx_Solicitud.Text = "Solicitud de Producción";
            // 
            // btn_MenuPrincipal
            // 
            this.btn_MenuPrincipal.Location = new System.Drawing.Point(1037, 33);
            this.btn_MenuPrincipal.Name = "btn_MenuPrincipal";
            this.btn_MenuPrincipal.Size = new System.Drawing.Size(216, 106);
            this.btn_MenuPrincipal.TabIndex = 22;
            this.btn_MenuPrincipal.Text = "Volver al Menu Principal";
            this.btn_MenuPrincipal.UseVisualStyleBackColor = true;
            this.btn_MenuPrincipal.Click += new System.EventHandler(this.btn_MenuPrincipal_Click);
            // 
            // btn_ActualizarInfo
            // 
            this.btn_ActualizarInfo.Location = new System.Drawing.Point(6, 300);
            this.btn_ActualizarInfo.Name = "btn_ActualizarInfo";
            this.btn_ActualizarInfo.Size = new System.Drawing.Size(476, 23);
            this.btn_ActualizarInfo.TabIndex = 23;
            this.btn_ActualizarInfo.Text = "Actualizar Información";
            this.btn_ActualizarInfo.UseVisualStyleBackColor = true;
            this.btn_ActualizarInfo.Click += new System.EventHandler(this.btn_ActualizarInfo_Click);
            // 
            // txt_Info
            // 
            this.txt_Info.Location = new System.Drawing.Point(6, 21);
            this.txt_Info.Name = "txt_Info";
            this.txt_Info.ReadOnly = true;
            this.txt_Info.Size = new System.Drawing.Size(476, 273);
            this.txt_Info.TabIndex = 24;
            this.txt_Info.Text = "";
            // 
            // gbx_Info
            // 
            this.gbx_Info.Controls.Add(this.btn_ActualizarInfo);
            this.gbx_Info.Controls.Add(this.txt_Info);
            this.gbx_Info.Location = new System.Drawing.Point(6, 12);
            this.gbx_Info.Name = "gbx_Info";
            this.gbx_Info.Size = new System.Drawing.Size(491, 329);
            this.gbx_Info.TabIndex = 25;
            this.gbx_Info.TabStop = false;
            this.gbx_Info.Text = "Información de Producción";
            // 
            // dgv_Recomendaciones
            // 
            this.dgv_Recomendaciones.AllowUserToAddRows = false;
            this.dgv_Recomendaciones.AllowUserToDeleteRows = false;
            this.dgv_Recomendaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Recomendaciones.Location = new System.Drawing.Point(6, 21);
            this.dgv_Recomendaciones.Name = "dgv_Recomendaciones";
            this.dgv_Recomendaciones.ReadOnly = true;
            this.dgv_Recomendaciones.RowHeadersWidth = 51;
            this.dgv_Recomendaciones.RowTemplate.Height = 24;
            this.dgv_Recomendaciones.Size = new System.Drawing.Size(500, 132);
            this.dgv_Recomendaciones.TabIndex = 1;
            this.dgv_Recomendaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Recomendaciones_CellClick);
            // 
            // btn_AplicarRecomendaciones
            // 
            this.btn_AplicarRecomendaciones.Location = new System.Drawing.Point(9, 300);
            this.btn_AplicarRecomendaciones.Name = "btn_AplicarRecomendaciones";
            this.btn_AplicarRecomendaciones.Size = new System.Drawing.Size(497, 23);
            this.btn_AplicarRecomendaciones.TabIndex = 7;
            this.btn_AplicarRecomendaciones.Text = "Aplicar Recomendaciones";
            this.btn_AplicarRecomendaciones.UseVisualStyleBackColor = true;
            this.btn_AplicarRecomendaciones.Click += new System.EventHandler(this.btn_AplicarRecomendaciones_Click);
            // 
            // gbx_Recomendacion
            // 
            this.gbx_Recomendacion.Controls.Add(this.dgv_ItemRecomendacion);
            this.gbx_Recomendacion.Controls.Add(this.dgv_Recomendaciones);
            this.gbx_Recomendacion.Controls.Add(this.btn_AplicarRecomendaciones);
            this.gbx_Recomendacion.Location = new System.Drawing.Point(519, 12);
            this.gbx_Recomendacion.Name = "gbx_Recomendacion";
            this.gbx_Recomendacion.Size = new System.Drawing.Size(512, 329);
            this.gbx_Recomendacion.TabIndex = 26;
            this.gbx_Recomendacion.TabStop = false;
            this.gbx_Recomendacion.Text = "Recomendaciones para pedidos de producción";
            // 
            // dgv_ItemRecomendacion
            // 
            this.dgv_ItemRecomendacion.AllowUserToAddRows = false;
            this.dgv_ItemRecomendacion.AllowUserToDeleteRows = false;
            this.dgv_ItemRecomendacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ItemRecomendacion.Location = new System.Drawing.Point(6, 158);
            this.dgv_ItemRecomendacion.Name = "dgv_ItemRecomendacion";
            this.dgv_ItemRecomendacion.ReadOnly = true;
            this.dgv_ItemRecomendacion.RowHeadersWidth = 51;
            this.dgv_ItemRecomendacion.RowTemplate.Height = 24;
            this.dgv_ItemRecomendacion.Size = new System.Drawing.Size(500, 132);
            this.dgv_ItemRecomendacion.TabIndex = 27;
            // 
            // GestionProduccionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 714);
            this.Controls.Add(this.gbx_Recomendacion);
            this.Controls.Add(this.btn_MenuPrincipal);
            this.Controls.Add(this.btn_BajaItemProducto);
            this.Controls.Add(this.btn_PedidoProduccionCompletado);
            this.Controls.Add(this.btn_AltaItemProducto);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.lbl_Codigo);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.datePckr);
            this.Controls.Add(this.btn_CrearPedidoProduccion);
            this.Controls.Add(this.dgv_ItemPedidoProduccion);
            this.Controls.Add(this.dgv_PedidoProduccion);
            this.Controls.Add(this.gbx_Solicitud);
            this.Controls.Add(this.gbx_Info);
            this.Controls.Add(this.gbx_Pedido);
            this.Name = "GestionProduccionMenu";
            this.Text = "GestionProduccionMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionProduccionMenu_FormClosing);
            this.Load += new System.EventHandler(this.GestionProduccionMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PedidoProduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SolicitudProduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemPedidoProduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemSolicitudProduccion)).EndInit();
            this.gbx_Pedido.ResumeLayout(false);
            this.gbx_Solicitud.ResumeLayout(false);
            this.gbx_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recomendaciones)).EndInit();
            this.gbx_Recomendacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemRecomendacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PedidoProduccion;
        private System.Windows.Forms.DataGridView dgv_SolicitudProduccion;
        private System.Windows.Forms.DataGridView dgv_ItemPedidoProduccion;
        private System.Windows.Forms.DataGridView dgv_ItemSolicitudProduccion;
        private System.Windows.Forms.Button btn_CrearPedidoProduccion;
        private System.Windows.Forms.DateTimePicker datePckr;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Button btn_SolicitudProduccionCompleta;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Button btn_AltaItemProducto;
        private System.Windows.Forms.Button btn_EliminarPedidoProduccion;
        private System.Windows.Forms.Button btn_PedidoProduccionCompletado;
        private System.Windows.Forms.Button btn_BajaItemProducto;
        private System.Windows.Forms.GroupBox gbx_Pedido;
        private System.Windows.Forms.GroupBox gbx_Solicitud;
        private System.Windows.Forms.Button btn_MenuPrincipal;
        private System.Windows.Forms.Button btn_ActualizarInfo;
        private System.Windows.Forms.RichTextBox txt_Info;
        private System.Windows.Forms.GroupBox gbx_Info;
        private System.Windows.Forms.DataGridView dgv_Recomendaciones;
        private System.Windows.Forms.Button btn_AplicarRecomendaciones;
        private System.Windows.Forms.GroupBox gbx_Recomendacion;
        private System.Windows.Forms.DataGridView dgv_ItemRecomendacion;
    }
}