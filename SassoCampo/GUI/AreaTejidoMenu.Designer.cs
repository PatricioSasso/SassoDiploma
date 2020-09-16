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
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Baja = new System.Windows.Forms.Button();
            this.lbl_HiladoId = new System.Windows.Forms.Label();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.lbl_Peso = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.txt_Peso = new System.Windows.Forms.TextBox();
            this.dgv_Hilados = new System.Windows.Forms.DataGridView();
            this.gbx_Hilados = new System.Windows.Forms.GroupBox();
            this.btn_Tejer = new System.Windows.Forms.Button();
            this.gbx_TelasStock = new System.Windows.Forms.GroupBox();
            this.dgv_Telas = new System.Windows.Forms.DataGridView();
            this.btn_MenuPrincipal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hilados)).BeginInit();
            this.gbx_Hilados.SuspendLayout();
            this.gbx_TelasStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Telas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(38, 183);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(187, 23);
            this.btn_Alta.TabIndex = 0;
            this.btn_Alta.Text = "Alta";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_AltaHilado_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(38, 212);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(187, 23);
            this.btn_Modificar.TabIndex = 1;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_ModificarHilado_Click);
            // 
            // btn_Baja
            // 
            this.btn_Baja.Location = new System.Drawing.Point(38, 241);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(187, 23);
            this.btn_Baja.TabIndex = 2;
            this.btn_Baja.Text = "Baja";
            this.btn_Baja.UseVisualStyleBackColor = true;
            this.btn_Baja.Click += new System.EventHandler(this.btn_BajaHilado_Click);
            // 
            // lbl_HiladoId
            // 
            this.lbl_HiladoId.AutoSize = true;
            this.lbl_HiladoId.Location = new System.Drawing.Point(76, 23);
            this.lbl_HiladoId.Name = "lbl_HiladoId";
            this.lbl_HiladoId.Size = new System.Drawing.Size(31, 17);
            this.lbl_HiladoId.TabIndex = 3;
            this.lbl_HiladoId.Text = "Id : ";
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(43, 55);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(64, 17);
            this.lbl_Codigo.TabIndex = 4;
            this.lbl_Codigo.Text = "Código : ";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(13, 84);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(94, 17);
            this.lbl_Descripcion.TabIndex = 5;
            this.lbl_Descripcion.Text = "Descripción : ";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(35, 115);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(72, 17);
            this.lbl_Cantidad.TabIndex = 6;
            this.lbl_Cantidad.Text = "Cantidad: ";
            // 
            // lbl_Peso
            // 
            this.lbl_Peso.AutoSize = true;
            this.lbl_Peso.Location = new System.Drawing.Point(55, 146);
            this.lbl_Peso.Name = "lbl_Peso";
            this.lbl_Peso.Size = new System.Drawing.Size(52, 17);
            this.lbl_Peso.TabIndex = 7;
            this.lbl_Peso.Text = "Peso : ";
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
            this.gbx_Hilados.Controls.Add(this.lbl_HiladoId);
            this.gbx_Hilados.Controls.Add(this.lbl_Codigo);
            this.gbx_Hilados.Controls.Add(this.lbl_Descripcion);
            this.gbx_Hilados.Controls.Add(this.lbl_Cantidad);
            this.gbx_Hilados.Controls.Add(this.lbl_Peso);
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
            // gbx_TelasStock
            // 
            this.gbx_TelasStock.Controls.Add(this.dgv_Telas);
            this.gbx_TelasStock.Location = new System.Drawing.Point(220, 307);
            this.gbx_TelasStock.Name = "gbx_TelasStock";
            this.gbx_TelasStock.Size = new System.Drawing.Size(657, 262);
            this.gbx_TelasStock.TabIndex = 15;
            this.gbx_TelasStock.TabStop = false;
            this.gbx_TelasStock.Text = "Telas en stock";
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
            this.Controls.Add(this.gbx_TelasStock);
            this.Controls.Add(this.txt_Peso);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.gbx_Hilados);
            this.Name = "AreaTejidoMenu";
            this.Text = "Área de Tejido";
            this.Load += new System.EventHandler(this.AreaTejidoMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hilados)).EndInit();
            this.gbx_Hilados.ResumeLayout(false);
            this.gbx_Hilados.PerformLayout();
            this.gbx_TelasStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Telas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Label lbl_HiladoId;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label lbl_Peso;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.TextBox txt_Peso;
        private System.Windows.Forms.DataGridView dgv_Hilados;
        private System.Windows.Forms.GroupBox gbx_Hilados;
        private System.Windows.Forms.GroupBox gbx_TelasStock;
        private System.Windows.Forms.DataGridView dgv_Telas;
        private System.Windows.Forms.Button btn_MenuPrincipal;
        private System.Windows.Forms.Button btn_Tejer;
    }
}