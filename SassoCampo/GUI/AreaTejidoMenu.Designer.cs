namespace GUI
{
    partial class AreaTejidoMenu
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
            this.btn_AltaHilado = new System.Windows.Forms.Button();
            this.btn_ModificarHilado = new System.Windows.Forms.Button();
            this.btn_BajaHilado = new System.Windows.Forms.Button();
            this.lbl_HiladoId = new System.Windows.Forms.Label();
            this.lbl_HiladoCodigo = new System.Windows.Forms.Label();
            this.lblHiladoDescripcion = new System.Windows.Forms.Label();
            this.lbl_HiladoCantidad = new System.Windows.Forms.Label();
            this.lbl_HiladoPeso = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.txt_Peso = new System.Windows.Forms.TextBox();
            this.dgv_Hilados = new System.Windows.Forms.DataGridView();
            this.gbx_Hilados = new System.Windows.Forms.GroupBox();
            this.btn_Tejer = new System.Windows.Forms.Button();
            this.gbx_Telas = new System.Windows.Forms.GroupBox();
            this.dgv_Telas = new System.Windows.Forms.DataGridView();
            this.btn_MenuPrincipal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hilados)).BeginInit();
            this.gbx_Hilados.SuspendLayout();
            this.gbx_Telas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Telas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AltaHilado
            // 
            this.btn_AltaHilado.Location = new System.Drawing.Point(38, 183);
            this.btn_AltaHilado.Name = "btn_AltaHilado";
            this.btn_AltaHilado.Size = new System.Drawing.Size(187, 23);
            this.btn_AltaHilado.TabIndex = 0;
            this.btn_AltaHilado.Text = "Alta";
            this.btn_AltaHilado.UseVisualStyleBackColor = true;
            this.btn_AltaHilado.Click += new System.EventHandler(this.btn_AltaHilado_Click);
            // 
            // btn_ModificarHilado
            // 
            this.btn_ModificarHilado.Location = new System.Drawing.Point(38, 212);
            this.btn_ModificarHilado.Name = "btn_ModificarHilado";
            this.btn_ModificarHilado.Size = new System.Drawing.Size(187, 23);
            this.btn_ModificarHilado.TabIndex = 1;
            this.btn_ModificarHilado.Text = "Modificar";
            this.btn_ModificarHilado.UseVisualStyleBackColor = true;
            this.btn_ModificarHilado.Click += new System.EventHandler(this.btn_ModificarHilado_Click);
            // 
            // btn_BajaHilado
            // 
            this.btn_BajaHilado.Location = new System.Drawing.Point(38, 241);
            this.btn_BajaHilado.Name = "btn_BajaHilado";
            this.btn_BajaHilado.Size = new System.Drawing.Size(187, 23);
            this.btn_BajaHilado.TabIndex = 2;
            this.btn_BajaHilado.Text = "Baja";
            this.btn_BajaHilado.UseVisualStyleBackColor = true;
            this.btn_BajaHilado.Click += new System.EventHandler(this.btn_BajaHilado_Click);
            // 
            // lbl_HiladoId
            // 
            this.lbl_HiladoId.AutoSize = true;
            this.lbl_HiladoId.Location = new System.Drawing.Point(92, 35);
            this.lbl_HiladoId.Name = "lbl_HiladoId";
            this.lbl_HiladoId.Size = new System.Drawing.Size(27, 17);
            this.lbl_HiladoId.TabIndex = 3;
            this.lbl_HiladoId.Text = "Id: ";
            // 
            // lbl_HiladoCodigo
            // 
            this.lbl_HiladoCodigo.AutoSize = true;
            this.lbl_HiladoCodigo.Location = new System.Drawing.Point(59, 67);
            this.lbl_HiladoCodigo.Name = "lbl_HiladoCodigo";
            this.lbl_HiladoCodigo.Size = new System.Drawing.Size(60, 17);
            this.lbl_HiladoCodigo.TabIndex = 4;
            this.lbl_HiladoCodigo.Text = "Código: ";
            // 
            // lblHiladoDescripcion
            // 
            this.lblHiladoDescripcion.AutoSize = true;
            this.lblHiladoDescripcion.Location = new System.Drawing.Point(29, 96);
            this.lblHiladoDescripcion.Name = "lblHiladoDescripcion";
            this.lblHiladoDescripcion.Size = new System.Drawing.Size(90, 17);
            this.lblHiladoDescripcion.TabIndex = 5;
            this.lblHiladoDescripcion.Text = "Descripción: ";
            // 
            // lbl_HiladoCantidad
            // 
            this.lbl_HiladoCantidad.AutoSize = true;
            this.lbl_HiladoCantidad.Location = new System.Drawing.Point(47, 127);
            this.lbl_HiladoCantidad.Name = "lbl_HiladoCantidad";
            this.lbl_HiladoCantidad.Size = new System.Drawing.Size(72, 17);
            this.lbl_HiladoCantidad.TabIndex = 6;
            this.lbl_HiladoCantidad.Text = "Cantidad: ";
            // 
            // lbl_HiladoPeso
            // 
            this.lbl_HiladoPeso.AutoSize = true;
            this.lbl_HiladoPeso.Location = new System.Drawing.Point(71, 158);
            this.lbl_HiladoPeso.Name = "lbl_HiladoPeso";
            this.lbl_HiladoPeso.Size = new System.Drawing.Size(48, 17);
            this.lbl_HiladoPeso.TabIndex = 7;
            this.lbl_HiladoPeso.Text = "Peso: ";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(125, 32);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 22);
            this.txt_Id.TabIndex = 8;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(125, 64);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(100, 22);
            this.txt_Codigo.TabIndex = 9;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(125, 96);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(100, 22);
            this.txt_Descripcion.TabIndex = 10;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(125, 127);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 22);
            this.txt_Cantidad.TabIndex = 11;
            // 
            // txt_Peso
            // 
            this.txt_Peso.Location = new System.Drawing.Point(125, 155);
            this.txt_Peso.Name = "txt_Peso";
            this.txt_Peso.Size = new System.Drawing.Size(100, 22);
            this.txt_Peso.TabIndex = 12;
            // 
            // dgv_Hilados
            // 
            this.dgv_Hilados.AllowUserToAddRows = false;
            this.dgv_Hilados.AllowUserToDeleteRows = false;
            this.dgv_Hilados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hilados.Location = new System.Drawing.Point(240, 20);
            this.dgv_Hilados.MultiSelect = false;
            this.dgv_Hilados.Name = "dgv_Hilados";
            this.dgv_Hilados.ReadOnly = true;
            this.dgv_Hilados.RowHeadersWidth = 51;
            this.dgv_Hilados.RowTemplate.Height = 24;
            this.dgv_Hilados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Hilados.Size = new System.Drawing.Size(608, 261);
            this.dgv_Hilados.TabIndex = 13;
            this.dgv_Hilados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Hilado_CellClick);
            // 
            // gbx_Hilados
            // 
            this.gbx_Hilados.Controls.Add(this.btn_Tejer);
            this.gbx_Hilados.Controls.Add(this.dgv_Hilados);
            this.gbx_Hilados.Location = new System.Drawing.Point(12, 12);
            this.gbx_Hilados.Name = "gbx_Hilados";
            this.gbx_Hilados.Size = new System.Drawing.Size(865, 289);
            this.gbx_Hilados.TabIndex = 14;
            this.gbx_Hilados.TabStop = false;
            this.gbx_Hilados.Text = "Gestion de Hilado";
            // 
            // btn_Tejer
            // 
            this.btn_Tejer.Location = new System.Drawing.Point(26, 258);
            this.btn_Tejer.Name = "btn_Tejer";
            this.btn_Tejer.Size = new System.Drawing.Size(187, 23);
            this.btn_Tejer.TabIndex = 14;
            this.btn_Tejer.Text = "Tejer";
            this.btn_Tejer.UseVisualStyleBackColor = true;
            this.btn_Tejer.Click += new System.EventHandler(this.btn_Tejer_Click);
            // 
            // gbx_Telas
            // 
            this.gbx_Telas.Controls.Add(this.dgv_Telas);
            this.gbx_Telas.Location = new System.Drawing.Point(220, 307);
            this.gbx_Telas.Name = "gbx_Telas";
            this.gbx_Telas.Size = new System.Drawing.Size(657, 262);
            this.gbx_Telas.TabIndex = 15;
            this.gbx_Telas.TabStop = false;
            this.gbx_Telas.Text = "Telas en stock";
            // 
            // dgv_Telas
            // 
            this.dgv_Telas.AllowUserToAddRows = false;
            this.dgv_Telas.AllowUserToDeleteRows = false;
            this.dgv_Telas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Telas.Location = new System.Drawing.Point(20, 21);
            this.dgv_Telas.MultiSelect = false;
            this.dgv_Telas.Name = "dgv_Telas";
            this.dgv_Telas.ReadOnly = true;
            this.dgv_Telas.RowHeadersWidth = 51;
            this.dgv_Telas.RowTemplate.Height = 24;
            this.dgv_Telas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Telas.Size = new System.Drawing.Size(621, 232);
            this.dgv_Telas.TabIndex = 14;
            // 
            // btn_MenuPrincipal
            // 
            this.btn_MenuPrincipal.Location = new System.Drawing.Point(883, 12);
            this.btn_MenuPrincipal.Name = "btn_MenuPrincipal";
            this.btn_MenuPrincipal.Size = new System.Drawing.Size(90, 74);
            this.btn_MenuPrincipal.TabIndex = 16;
            this.btn_MenuPrincipal.Text = "Volver al Menu Principal";
            this.btn_MenuPrincipal.UseVisualStyleBackColor = true;
            this.btn_MenuPrincipal.Click += new System.EventHandler(this.btn_MenuPrincipal_Click);
            // 
            // AreaTejidoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 577);
            this.Controls.Add(this.btn_MenuPrincipal);
            this.Controls.Add(this.gbx_Telas);
            this.Controls.Add(this.txt_Peso);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_HiladoPeso);
            this.Controls.Add(this.lbl_HiladoCantidad);
            this.Controls.Add(this.lblHiladoDescripcion);
            this.Controls.Add(this.lbl_HiladoCodigo);
            this.Controls.Add(this.lbl_HiladoId);
            this.Controls.Add(this.btn_BajaHilado);
            this.Controls.Add(this.btn_ModificarHilado);
            this.Controls.Add(this.btn_AltaHilado);
            this.Controls.Add(this.gbx_Hilados);
            this.Name = "AreaTejidoMenu";
            this.Text = "Área de Tejido";
            this.Load += new System.EventHandler(this.AreaTejidoMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hilados)).EndInit();
            this.gbx_Hilados.ResumeLayout(false);
            this.gbx_Telas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Telas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AltaHilado;
        private System.Windows.Forms.Button btn_ModificarHilado;
        private System.Windows.Forms.Button btn_BajaHilado;
        private System.Windows.Forms.Label lbl_HiladoId;
        private System.Windows.Forms.Label lbl_HiladoCodigo;
        private System.Windows.Forms.Label lblHiladoDescripcion;
        private System.Windows.Forms.Label lbl_HiladoCantidad;
        private System.Windows.Forms.Label lbl_HiladoPeso;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.TextBox txt_Peso;
        private System.Windows.Forms.DataGridView dgv_Hilados;
        private System.Windows.Forms.GroupBox gbx_Hilados;
        private System.Windows.Forms.GroupBox gbx_Telas;
        private System.Windows.Forms.DataGridView dgv_Telas;
        private System.Windows.Forms.Button btn_MenuPrincipal;
        private System.Windows.Forms.Button btn_Tejer;
    }
}