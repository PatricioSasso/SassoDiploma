namespace GUI
{
    partial class AreaConfeccionadoMenu
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
            this.btn_MenuPrincipal = new System.Windows.Forms.Button();
            this.gbx_PrendasConfeccionadas = new System.Windows.Forms.GroupBox();
            this.dgv_PrendasConfeccionadas = new System.Windows.Forms.DataGridView();
            this.gbx_Prendas = new System.Windows.Forms.GroupBox();
            this.btn_Confeccionar = new System.Windows.Forms.Button();
            this.btn_Baja = new System.Windows.Forms.Button();
            this.txt_Talle = new System.Windows.Forms.TextBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.lbl_Talle = new System.Windows.Forms.Label();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.dgv_Prendas = new System.Windows.Forms.DataGridView();
            this.btn_Solicitar = new System.Windows.Forms.Button();
            this.gbx_PrendasConfeccionadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PrendasConfeccionadas)).BeginInit();
            this.gbx_Prendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_MenuPrincipal
            // 
            this.btn_MenuPrincipal.Location = new System.Drawing.Point(12, 299);
            this.btn_MenuPrincipal.Name = "btn_MenuPrincipal";
            this.btn_MenuPrincipal.Size = new System.Drawing.Size(107, 104);
            this.btn_MenuPrincipal.TabIndex = 25;
            this.btn_MenuPrincipal.Text = "Volver Al Menu Principal";
            this.btn_MenuPrincipal.UseVisualStyleBackColor = true;
            this.btn_MenuPrincipal.Click += new System.EventHandler(this.btn_MenuPrincipal_Click);
            // 
            // gbx_PrendasConfeccionadas
            // 
            this.gbx_PrendasConfeccionadas.Controls.Add(this.dgv_PrendasConfeccionadas);
            this.gbx_PrendasConfeccionadas.Location = new System.Drawing.Point(125, 299);
            this.gbx_PrendasConfeccionadas.Name = "gbx_PrendasConfeccionadas";
            this.gbx_PrendasConfeccionadas.Size = new System.Drawing.Size(834, 262);
            this.gbx_PrendasConfeccionadas.TabIndex = 24;
            this.gbx_PrendasConfeccionadas.TabStop = false;
            this.gbx_PrendasConfeccionadas.Text = "Prendas confeccionadas en stock";
            // 
            // dgv_PrendasConfeccionadas
            // 
            this.dgv_PrendasConfeccionadas.AllowUserToAddRows = false;
            this.dgv_PrendasConfeccionadas.AllowUserToDeleteRows = false;
            this.dgv_PrendasConfeccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PrendasConfeccionadas.Location = new System.Drawing.Point(20, 21);
            this.dgv_PrendasConfeccionadas.MultiSelect = false;
            this.dgv_PrendasConfeccionadas.Name = "dgv_PrendasConfeccionadas";
            this.dgv_PrendasConfeccionadas.ReadOnly = true;
            this.dgv_PrendasConfeccionadas.RowHeadersWidth = 51;
            this.dgv_PrendasConfeccionadas.RowTemplate.Height = 24;
            this.dgv_PrendasConfeccionadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PrendasConfeccionadas.Size = new System.Drawing.Size(804, 232);
            this.dgv_PrendasConfeccionadas.TabIndex = 14;
            // 
            // gbx_Prendas
            // 
            this.gbx_Prendas.Controls.Add(this.btn_Solicitar);
            this.gbx_Prendas.Controls.Add(this.btn_Confeccionar);
            this.gbx_Prendas.Controls.Add(this.btn_Baja);
            this.gbx_Prendas.Controls.Add(this.txt_Talle);
            this.gbx_Prendas.Controls.Add(this.btn_Modificar);
            this.gbx_Prendas.Controls.Add(this.lbl_Talle);
            this.gbx_Prendas.Controls.Add(this.btn_Alta);
            this.gbx_Prendas.Controls.Add(this.txt_Cantidad);
            this.gbx_Prendas.Controls.Add(this.lbl_Cantidad);
            this.gbx_Prendas.Controls.Add(this.txt_Descripcion);
            this.gbx_Prendas.Controls.Add(this.lbl_Descripcion);
            this.gbx_Prendas.Controls.Add(this.txt_Codigo);
            this.gbx_Prendas.Controls.Add(this.lbl_Codigo);
            this.gbx_Prendas.Controls.Add(this.dgv_Prendas);
            this.gbx_Prendas.Location = new System.Drawing.Point(12, 12);
            this.gbx_Prendas.Name = "gbx_Prendas";
            this.gbx_Prendas.Size = new System.Drawing.Size(947, 281);
            this.gbx_Prendas.TabIndex = 23;
            this.gbx_Prendas.TabStop = false;
            this.gbx_Prendas.Text = "Gestión de Prendas";
            // 
            // btn_Confeccionar
            // 
            this.btn_Confeccionar.Location = new System.Drawing.Point(23, 220);
            this.btn_Confeccionar.Name = "btn_Confeccionar";
            this.btn_Confeccionar.Size = new System.Drawing.Size(193, 23);
            this.btn_Confeccionar.TabIndex = 21;
            this.btn_Confeccionar.Text = "Confeccionar";
            this.btn_Confeccionar.UseVisualStyleBackColor = true;
            this.btn_Confeccionar.Click += new System.EventHandler(this.btn_Confeccionar_Click);
            // 
            // btn_Baja
            // 
            this.btn_Baja.Location = new System.Drawing.Point(23, 191);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(193, 23);
            this.btn_Baja.TabIndex = 20;
            this.btn_Baja.Text = "Baja";
            this.btn_Baja.UseVisualStyleBackColor = true;
            this.btn_Baja.Click += new System.EventHandler(this.btn_BajaPrenda_Click);
            // 
            // txt_Talle
            // 
            this.txt_Talle.Location = new System.Drawing.Point(116, 105);
            this.txt_Talle.Name = "txt_Talle";
            this.txt_Talle.Size = new System.Drawing.Size(100, 22);
            this.txt_Talle.TabIndex = 24;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(23, 162);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(193, 23);
            this.btn_Modificar.TabIndex = 19;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_ModificarPrenda_Click);
            // 
            // lbl_Talle
            // 
            this.lbl_Talle.AutoSize = true;
            this.lbl_Talle.Location = new System.Drawing.Point(61, 108);
            this.lbl_Talle.Name = "lbl_Talle";
            this.lbl_Talle.Size = new System.Drawing.Size(47, 17);
            this.lbl_Talle.TabIndex = 23;
            this.lbl_Talle.Text = "Talle :";
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(23, 133);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(193, 23);
            this.btn_Alta.TabIndex = 18;
            this.btn_Alta.Text = "Alta";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_AltaPrenda_Click);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(116, 77);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 22);
            this.txt_Cantidad.TabIndex = 19;
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(38, 80);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(72, 17);
            this.lbl_Cantidad.TabIndex = 21;
            this.lbl_Cantidad.Text = "Cantidad :";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(116, 49);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(100, 22);
            this.txt_Descripcion.TabIndex = 18;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(20, 54);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(90, 17);
            this.lbl_Descripcion.TabIndex = 22;
            this.lbl_Descripcion.Text = "Descripción :";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(116, 21);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(100, 22);
            this.txt_Codigo.TabIndex = 17;
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(52, 24);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(60, 17);
            this.lbl_Codigo.TabIndex = 20;
            this.lbl_Codigo.Text = "Código :";
            // 
            // dgv_Prendas
            // 
            this.dgv_Prendas.AllowUserToAddRows = false;
            this.dgv_Prendas.AllowUserToDeleteRows = false;
            this.dgv_Prendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Prendas.Location = new System.Drawing.Point(222, 12);
            this.dgv_Prendas.Name = "dgv_Prendas";
            this.dgv_Prendas.ReadOnly = true;
            this.dgv_Prendas.RowHeadersWidth = 51;
            this.dgv_Prendas.RowTemplate.Height = 24;
            this.dgv_Prendas.Size = new System.Drawing.Size(719, 259);
            this.dgv_Prendas.TabIndex = 0;
            this.dgv_Prendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Prendas_CellClick);
            // 
            // btn_Solicitar
            // 
            this.btn_Solicitar.Location = new System.Drawing.Point(23, 248);
            this.btn_Solicitar.Name = "btn_Solicitar";
            this.btn_Solicitar.Size = new System.Drawing.Size(193, 23);
            this.btn_Solicitar.TabIndex = 27;
            this.btn_Solicitar.Text = "Solicitar";
            this.btn_Solicitar.UseVisualStyleBackColor = true;
            this.btn_Solicitar.Click += new System.EventHandler(this.btn_Solicitar_Click);
            // 
            // AreaConfeccionadoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 567);
            this.Controls.Add(this.btn_MenuPrincipal);
            this.Controls.Add(this.gbx_PrendasConfeccionadas);
            this.Controls.Add(this.gbx_Prendas);
            this.Name = "AreaConfeccionadoMenu";
            this.Text = "Área de Confeccionado";
            this.Load += new System.EventHandler(this.AreaConfeccionadoMenu_Load);
            this.gbx_PrendasConfeccionadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PrendasConfeccionadas)).EndInit();
            this.gbx_Prendas.ResumeLayout(false);
            this.gbx_Prendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_MenuPrincipal;
        private System.Windows.Forms.GroupBox gbx_PrendasConfeccionadas;
        private System.Windows.Forms.DataGridView dgv_PrendasConfeccionadas;
        private System.Windows.Forms.GroupBox gbx_Prendas;
        private System.Windows.Forms.Button btn_Confeccionar;
        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.TextBox txt_Talle;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label lbl_Talle;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.DataGridView dgv_Prendas;
        private System.Windows.Forms.Button btn_Solicitar;
    }
}