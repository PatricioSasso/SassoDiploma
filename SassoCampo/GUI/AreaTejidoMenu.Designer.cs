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
            this.dataGridView_Hilado = new System.Windows.Forms.DataGridView();
            this.gbox_Hilado = new System.Windows.Forms.GroupBox();
            this.gbox_Tela = new System.Windows.Forms.GroupBox();
            this.dataGridView_Tela = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Hilado)).BeginInit();
            this.gbox_Tela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tela)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AltaHilado
            // 
            this.btn_AltaHilado.Location = new System.Drawing.Point(38, 183);
            this.btn_AltaHilado.Name = "btn_AltaHilado";
            this.btn_AltaHilado.Size = new System.Drawing.Size(187, 23);
            this.btn_AltaHilado.TabIndex = 0;
            this.btn_AltaHilado.Text = "Alta Hilado";
            this.btn_AltaHilado.UseVisualStyleBackColor = true;
            this.btn_AltaHilado.Click += new System.EventHandler(this.btn_AltaHilado_Click);
            // 
            // btn_ModificarHilado
            // 
            this.btn_ModificarHilado.Location = new System.Drawing.Point(38, 212);
            this.btn_ModificarHilado.Name = "btn_ModificarHilado";
            this.btn_ModificarHilado.Size = new System.Drawing.Size(187, 23);
            this.btn_ModificarHilado.TabIndex = 1;
            this.btn_ModificarHilado.Text = "Modificar Hilado";
            this.btn_ModificarHilado.UseVisualStyleBackColor = true;
            this.btn_ModificarHilado.Click += new System.EventHandler(this.btn_ModificarHilado_Click);
            // 
            // btn_BajaHilado
            // 
            this.btn_BajaHilado.Location = new System.Drawing.Point(38, 241);
            this.btn_BajaHilado.Name = "btn_BajaHilado";
            this.btn_BajaHilado.Size = new System.Drawing.Size(187, 23);
            this.btn_BajaHilado.TabIndex = 2;
            this.btn_BajaHilado.Text = "Baja Hilado";
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
            // dataGridView_Hilado
            // 
            this.dataGridView_Hilado.AllowUserToAddRows = false;
            this.dataGridView_Hilado.AllowUserToDeleteRows = false;
            this.dataGridView_Hilado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Hilado.Location = new System.Drawing.Point(243, 32);
            this.dataGridView_Hilado.MultiSelect = false;
            this.dataGridView_Hilado.Name = "dataGridView_Hilado";
            this.dataGridView_Hilado.ReadOnly = true;
            this.dataGridView_Hilado.RowHeadersWidth = 51;
            this.dataGridView_Hilado.RowTemplate.Height = 24;
            this.dataGridView_Hilado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Hilado.Size = new System.Drawing.Size(814, 232);
            this.dataGridView_Hilado.TabIndex = 13;
            // 
            // gbox_Hilado
            // 
            this.gbox_Hilado.Location = new System.Drawing.Point(12, 12);
            this.gbox_Hilado.Name = "gbox_Hilado";
            this.gbox_Hilado.Size = new System.Drawing.Size(1051, 264);
            this.gbox_Hilado.TabIndex = 14;
            this.gbox_Hilado.TabStop = false;
            this.gbox_Hilado.Text = "Gestion de Hilado";
            // 
            // gbox_Tela
            // 
            this.gbox_Tela.Controls.Add(this.dataGridView_Tela);
            this.gbox_Tela.Location = new System.Drawing.Point(12, 282);
            this.gbox_Tela.Name = "gbox_Tela";
            this.gbox_Tela.Size = new System.Drawing.Size(1051, 262);
            this.gbox_Tela.TabIndex = 15;
            this.gbox_Tela.TabStop = false;
            this.gbox_Tela.Text = "Telas en stock";
            // 
            // dataGridView_Tela
            // 
            this.dataGridView_Tela.AllowUserToAddRows = false;
            this.dataGridView_Tela.AllowUserToDeleteRows = false;
            this.dataGridView_Tela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tela.Location = new System.Drawing.Point(20, 21);
            this.dataGridView_Tela.MultiSelect = false;
            this.dataGridView_Tela.Name = "dataGridView_Tela";
            this.dataGridView_Tela.ReadOnly = true;
            this.dataGridView_Tela.RowHeadersWidth = 51;
            this.dataGridView_Tela.RowTemplate.Height = 24;
            this.dataGridView_Tela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Tela.Size = new System.Drawing.Size(1025, 232);
            this.dataGridView_Tela.TabIndex = 14;
            // 
            // AreaTejidoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 556);
            this.Controls.Add(this.gbox_Tela);
            this.Controls.Add(this.dataGridView_Hilado);
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
            this.Controls.Add(this.gbox_Hilado);
            this.Name = "AreaTejidoMenu";
            this.Text = "AreaTejidoMenu";
            this.Load += new System.EventHandler(this.AreaTejidoMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Hilado)).EndInit();
            this.gbox_Tela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tela)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView_Hilado;
        private System.Windows.Forms.GroupBox gbox_Hilado;
        private System.Windows.Forms.GroupBox gbox_Tela;
        private System.Windows.Forms.DataGridView dataGridView_Tela;
    }
}