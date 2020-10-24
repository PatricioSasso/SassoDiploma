﻿namespace GUI
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btn_AltaItemProducto = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_EliminarPedidoProduccion = new System.Windows.Forms.Button();
            this.btn_PedidoProduccionCompletado = new System.Windows.Forms.Button();
            this.btn_BajaItemProducto = new System.Windows.Forms.Button();
            this.gbx_PedidoProduccion = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_MenuPrincipal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PedidoProduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SolicitudProduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemPedidoProduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemSolicitudProduccion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_PedidoProduccion
            // 
            this.dgv_PedidoProduccion.AllowUserToAddRows = false;
            this.dgv_PedidoProduccion.AllowUserToDeleteRows = false;
            this.dgv_PedidoProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PedidoProduccion.Location = new System.Drawing.Point(313, 29);
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
            this.dgv_ItemPedidoProduccion.Location = new System.Drawing.Point(313, 185);
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
            this.dgv_ItemSolicitudProduccion.Location = new System.Drawing.Point(6, 177);
            this.dgv_ItemSolicitudProduccion.Name = "dgv_ItemSolicitudProduccion";
            this.dgv_ItemSolicitudProduccion.ReadOnly = true;
            this.dgv_ItemSolicitudProduccion.RowHeadersWidth = 51;
            this.dgv_ItemSolicitudProduccion.RowTemplate.Height = 24;
            this.dgv_ItemSolicitudProduccion.Size = new System.Drawing.Size(500, 150);
            this.dgv_ItemSolicitudProduccion.TabIndex = 3;
            // 
            // btn_CrearPedidoProduccion
            // 
            this.btn_CrearPedidoProduccion.Location = new System.Drawing.Point(31, 56);
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
            this.datePckr.Location = new System.Drawing.Point(184, 28);
            this.datePckr.Name = "datePckr";
            this.datePckr.Size = new System.Drawing.Size(123, 22);
            this.datePckr.TabIndex = 5;
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(28, 33);
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
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(58, 188);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(60, 17);
            this.lbl_Codigo.TabIndex = 8;
            this.lbl_Codigo.Text = "Código :";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(28, 217);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(90, 17);
            this.lbl_Descripcion.TabIndex = 9;
            this.lbl_Descripcion.Text = "Descripción :";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(46, 248);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(72, 17);
            this.lbl_Cantidad.TabIndex = 10;
            this.lbl_Cantidad.Text = "Cantidad :";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(124, 185);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(183, 22);
            this.txt_Codigo.TabIndex = 11;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(124, 217);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(183, 22);
            this.txt_Descripcion.TabIndex = 12;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(124, 245);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(183, 22);
            this.txt_Cantidad.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(355, 356);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(262, 203);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 356);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(262, 203);
            this.textBox5.TabIndex = 15;
            // 
            // btn_AltaItemProducto
            // 
            this.btn_AltaItemProducto.Location = new System.Drawing.Point(31, 273);
            this.btn_AltaItemProducto.Name = "btn_AltaItemProducto";
            this.btn_AltaItemProducto.Size = new System.Drawing.Size(276, 23);
            this.btn_AltaItemProducto.TabIndex = 16;
            this.btn_AltaItemProducto.Text = "Agregar Producto";
            this.btn_AltaItemProducto.UseVisualStyleBackColor = true;
            this.btn_AltaItemProducto.Click += new System.EventHandler(this.btn_AltaItemProducto_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(31, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(276, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Eliminar pedido de Producción";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_EliminarPedidoProduccion
            // 
            this.btn_EliminarPedidoProduccion.Location = new System.Drawing.Point(31, 85);
            this.btn_EliminarPedidoProduccion.Name = "btn_EliminarPedidoProduccion";
            this.btn_EliminarPedidoProduccion.Size = new System.Drawing.Size(276, 23);
            this.btn_EliminarPedidoProduccion.TabIndex = 17;
            this.btn_EliminarPedidoProduccion.Text = "Eliminar pedido de Producción";
            this.btn_EliminarPedidoProduccion.UseVisualStyleBackColor = true;
            this.btn_EliminarPedidoProduccion.Click += new System.EventHandler(this.btn_EliminarPedidoProduccion_Click);
            // 
            // btn_PedidoProduccionCompletado
            // 
            this.btn_PedidoProduccionCompletado.Location = new System.Drawing.Point(31, 114);
            this.btn_PedidoProduccionCompletado.Name = "btn_PedidoProduccionCompletado";
            this.btn_PedidoProduccionCompletado.Size = new System.Drawing.Size(276, 23);
            this.btn_PedidoProduccionCompletado.TabIndex = 18;
            this.btn_PedidoProduccionCompletado.Text = "Marcar como completado";
            this.btn_PedidoProduccionCompletado.UseVisualStyleBackColor = true;
            // 
            // btn_BajaItemProducto
            // 
            this.btn_BajaItemProducto.Location = new System.Drawing.Point(31, 302);
            this.btn_BajaItemProducto.Name = "btn_BajaItemProducto";
            this.btn_BajaItemProducto.Size = new System.Drawing.Size(276, 23);
            this.btn_BajaItemProducto.TabIndex = 19;
            this.btn_BajaItemProducto.Text = "Quitar Producto";
            this.btn_BajaItemProducto.UseVisualStyleBackColor = true;
            this.btn_BajaItemProducto.Click += new System.EventHandler(this.btn_BajaItemProducto_Click);
            // 
            // gbx_PedidoProduccion
            // 
            this.gbx_PedidoProduccion.Location = new System.Drawing.Point(12, 8);
            this.gbx_PedidoProduccion.Name = "gbx_PedidoProduccion";
            this.gbx_PedidoProduccion.Size = new System.Drawing.Size(817, 335);
            this.gbx_PedidoProduccion.TabIndex = 20;
            this.gbx_PedidoProduccion.TabStop = false;
            this.gbx_PedidoProduccion.Text = "Pedidos de Producción";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_SolicitudProduccion);
            this.groupBox1.Controls.Add(this.dgv_ItemSolicitudProduccion);
            this.groupBox1.Controls.Add(this.btn_SolicitudProduccionCompleta);
            this.groupBox1.Location = new System.Drawing.Point(835, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 365);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solicitud de Producción";
            // 
            // btn_MenuPrincipal
            // 
            this.btn_MenuPrincipal.Location = new System.Drawing.Point(835, 379);
            this.btn_MenuPrincipal.Name = "btn_MenuPrincipal";
            this.btn_MenuPrincipal.Size = new System.Drawing.Size(124, 74);
            this.btn_MenuPrincipal.TabIndex = 22;
            this.btn_MenuPrincipal.Text = "Volver al Menu Principal";
            this.btn_MenuPrincipal.UseVisualStyleBackColor = true;
            this.btn_MenuPrincipal.Click += new System.EventHandler(this.btn_MenuPrincipal_Click);
            // 
            // GestionProduccionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 571);
            this.Controls.Add(this.btn_MenuPrincipal);
            this.Controls.Add(this.btn_BajaItemProducto);
            this.Controls.Add(this.btn_PedidoProduccionCompletado);
            this.Controls.Add(this.btn_EliminarPedidoProduccion);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_AltaItemProducto);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
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
            this.Controls.Add(this.gbx_PedidoProduccion);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionProduccionMenu";
            this.Text = "GestionProduccionMenu";
            this.Load += new System.EventHandler(this.GestionProduccionMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PedidoProduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SolicitudProduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemPedidoProduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemSolicitudProduccion)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btn_AltaItemProducto;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_EliminarPedidoProduccion;
        private System.Windows.Forms.Button btn_PedidoProduccionCompletado;
        private System.Windows.Forms.Button btn_BajaItemProducto;
        private System.Windows.Forms.GroupBox gbx_PedidoProduccion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_MenuPrincipal;
    }
}