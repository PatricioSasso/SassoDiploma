namespace GUI
{
    partial class AreaTenidoMenu
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
            this.dgv_Telas = new System.Windows.Forms.DataGridView();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Baja = new System.Windows.Forms.Button();
            this.gbx_Telas = new System.Windows.Forms.GroupBox();
            this.btn_Solicitar = new System.Windows.Forms.Button();
            this.btn_MenuPrincipal = new System.Windows.Forms.Button();
            this.btn_Tenir = new System.Windows.Forms.Button();
            this.gbx_TelasTenidasStock = new System.Windows.Forms.GroupBox();
            this.dgv_TelasTeñidas = new System.Windows.Forms.DataGridView();
            this.gbx_Tintes = new System.Windows.Forms.GroupBox();
            this.btn_Solicitar2 = new System.Windows.Forms.Button();
            this.btn_Baja2 = new System.Windows.Forms.Button();
            this.txt_ColorTinte = new System.Windows.Forms.TextBox();
            this.btn_Modificar2 = new System.Windows.Forms.Button();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.btn_Alta2 = new System.Windows.Forms.Button();
            this.txt_CantidadTinte = new System.Windows.Forms.TextBox();
            this.lbl_Cantidad2 = new System.Windows.Forms.Label();
            this.txt_DescripcionTinte = new System.Windows.Forms.TextBox();
            this.lbl_Descripcion2 = new System.Windows.Forms.Label();
            this.txt_CodigoTinte = new System.Windows.Forms.TextBox();
            this.lbl_Codigo2 = new System.Windows.Forms.Label();
            this.dgv_Tintes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Telas)).BeginInit();
            this.gbx_Telas.SuspendLayout();
            this.gbx_TelasTenidasStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TelasTeñidas)).BeginInit();
            this.gbx_Tintes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tintes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Telas
            // 
            this.dgv_Telas.AllowUserToAddRows = false;
            this.dgv_Telas.AllowUserToDeleteRows = false;
            this.dgv_Telas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Telas.Location = new System.Drawing.Point(222, 12);
            this.dgv_Telas.Name = "dgv_Telas";
            this.dgv_Telas.ReadOnly = true;
            this.dgv_Telas.RowHeadersWidth = 51;
            this.dgv_Telas.RowTemplate.Height = 24;
            this.dgv_Telas.Size = new System.Drawing.Size(530, 206);
            this.dgv_Telas.TabIndex = 0;
            this.dgv_Telas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Telas_CellClick);
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(116, 21);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(100, 22);
            this.txt_Codigo.TabIndex = 3;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(116, 49);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(100, 22);
            this.txt_Descripcion.TabIndex = 4;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(116, 77);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 22);
            this.txt_Cantidad.TabIndex = 5;
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(52, 24);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(60, 17);
            this.lbl_Codigo.TabIndex = 8;
            this.lbl_Codigo.Text = "Código :";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(38, 80);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(72, 17);
            this.lbl_Cantidad.TabIndex = 9;
            this.lbl_Cantidad.Text = "Cantidad :";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(20, 54);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(90, 17);
            this.lbl_Descripcion.TabIndex = 10;
            this.lbl_Descripcion.Text = "Descripción :";
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(23, 105);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(193, 23);
            this.btn_Alta.TabIndex = 11;
            this.btn_Alta.Text = "Alta";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_AltaTela_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(23, 134);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(193, 23);
            this.btn_Modificar.TabIndex = 12;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_ModificarTela_Click);
            // 
            // btn_Baja
            // 
            this.btn_Baja.Location = new System.Drawing.Point(23, 163);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(193, 23);
            this.btn_Baja.TabIndex = 13;
            this.btn_Baja.Text = "Baja";
            this.btn_Baja.UseVisualStyleBackColor = true;
            this.btn_Baja.Click += new System.EventHandler(this.btn_BajaTela_Click);
            // 
            // gbx_Telas
            // 
            this.gbx_Telas.Controls.Add(this.btn_Solicitar);
            this.gbx_Telas.Controls.Add(this.dgv_Telas);
            this.gbx_Telas.Controls.Add(this.txt_Cantidad);
            this.gbx_Telas.Controls.Add(this.btn_Alta);
            this.gbx_Telas.Controls.Add(this.lbl_Cantidad);
            this.gbx_Telas.Controls.Add(this.btn_Modificar);
            this.gbx_Telas.Controls.Add(this.txt_Descripcion);
            this.gbx_Telas.Controls.Add(this.btn_Baja);
            this.gbx_Telas.Controls.Add(this.lbl_Descripcion);
            this.gbx_Telas.Controls.Add(this.txt_Codigo);
            this.gbx_Telas.Controls.Add(this.lbl_Codigo);
            this.gbx_Telas.Location = new System.Drawing.Point(12, 12);
            this.gbx_Telas.Name = "gbx_Telas";
            this.gbx_Telas.Size = new System.Drawing.Size(758, 227);
            this.gbx_Telas.TabIndex = 14;
            this.gbx_Telas.TabStop = false;
            this.gbx_Telas.Text = "Gestión de Telas";
            // 
            // btn_Solicitar
            // 
            this.btn_Solicitar.Location = new System.Drawing.Point(23, 192);
            this.btn_Solicitar.Name = "btn_Solicitar";
            this.btn_Solicitar.Size = new System.Drawing.Size(193, 23);
            this.btn_Solicitar.TabIndex = 18;
            this.btn_Solicitar.Text = "Solicitar";
            this.btn_Solicitar.UseVisualStyleBackColor = true;
            this.btn_Solicitar.Click += new System.EventHandler(this.btn_Solicitar_Click);
            // 
            // btn_MenuPrincipal
            // 
            this.btn_MenuPrincipal.Location = new System.Drawing.Point(776, 12);
            this.btn_MenuPrincipal.Name = "btn_MenuPrincipal";
            this.btn_MenuPrincipal.Size = new System.Drawing.Size(113, 227);
            this.btn_MenuPrincipal.TabIndex = 15;
            this.btn_MenuPrincipal.Text = "Volver Al Menu Principal";
            this.btn_MenuPrincipal.UseVisualStyleBackColor = true;
            this.btn_MenuPrincipal.Click += new System.EventHandler(this.btn_MenuPrincipal_Click);
            // 
            // btn_Tenir
            // 
            this.btn_Tenir.Location = new System.Drawing.Point(12, 504);
            this.btn_Tenir.Name = "btn_Tenir";
            this.btn_Tenir.Size = new System.Drawing.Size(877, 30);
            this.btn_Tenir.TabIndex = 14;
            this.btn_Tenir.Text = "Teñir Tela";
            this.btn_Tenir.UseVisualStyleBackColor = true;
            this.btn_Tenir.Click += new System.EventHandler(this.btn_Tenir_Click);
            // 
            // gbx_TelasTenidasStock
            // 
            this.gbx_TelasTenidasStock.Controls.Add(this.dgv_TelasTeñidas);
            this.gbx_TelasTenidasStock.Location = new System.Drawing.Point(12, 535);
            this.gbx_TelasTenidasStock.Name = "gbx_TelasTenidasStock";
            this.gbx_TelasTenidasStock.Size = new System.Drawing.Size(822, 262);
            this.gbx_TelasTenidasStock.TabIndex = 16;
            this.gbx_TelasTenidasStock.TabStop = false;
            this.gbx_TelasTenidasStock.Text = "Telas teñidas en stock";
            // 
            // dgv_TelasTeñidas
            // 
            this.dgv_TelasTeñidas.AllowUserToAddRows = false;
            this.dgv_TelasTeñidas.AllowUserToDeleteRows = false;
            this.dgv_TelasTeñidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TelasTeñidas.Location = new System.Drawing.Point(20, 21);
            this.dgv_TelasTeñidas.MultiSelect = false;
            this.dgv_TelasTeñidas.Name = "dgv_TelasTeñidas";
            this.dgv_TelasTeñidas.ReadOnly = true;
            this.dgv_TelasTeñidas.RowHeadersWidth = 51;
            this.dgv_TelasTeñidas.RowTemplate.Height = 24;
            this.dgv_TelasTeñidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TelasTeñidas.Size = new System.Drawing.Size(787, 232);
            this.dgv_TelasTeñidas.TabIndex = 14;
            // 
            // gbx_Tintes
            // 
            this.gbx_Tintes.Controls.Add(this.btn_Solicitar2);
            this.gbx_Tintes.Controls.Add(this.btn_Baja2);
            this.gbx_Tintes.Controls.Add(this.txt_ColorTinte);
            this.gbx_Tintes.Controls.Add(this.btn_Modificar2);
            this.gbx_Tintes.Controls.Add(this.lbl_Color);
            this.gbx_Tintes.Controls.Add(this.btn_Alta2);
            this.gbx_Tintes.Controls.Add(this.txt_CantidadTinte);
            this.gbx_Tintes.Controls.Add(this.lbl_Cantidad2);
            this.gbx_Tintes.Controls.Add(this.txt_DescripcionTinte);
            this.gbx_Tintes.Controls.Add(this.lbl_Descripcion2);
            this.gbx_Tintes.Controls.Add(this.txt_CodigoTinte);
            this.gbx_Tintes.Controls.Add(this.lbl_Codigo2);
            this.gbx_Tintes.Controls.Add(this.dgv_Tintes);
            this.gbx_Tintes.Location = new System.Drawing.Point(12, 245);
            this.gbx_Tintes.Name = "gbx_Tintes";
            this.gbx_Tintes.Size = new System.Drawing.Size(877, 253);
            this.gbx_Tintes.TabIndex = 17;
            this.gbx_Tintes.TabStop = false;
            this.gbx_Tintes.Text = "Gestión de Tintes";
            // 
            // btn_Solicitar2
            // 
            this.btn_Solicitar2.Location = new System.Drawing.Point(23, 219);
            this.btn_Solicitar2.Name = "btn_Solicitar2";
            this.btn_Solicitar2.Size = new System.Drawing.Size(193, 23);
            this.btn_Solicitar2.TabIndex = 25;
            this.btn_Solicitar2.Text = "Solicitar";
            this.btn_Solicitar2.UseVisualStyleBackColor = true;
            this.btn_Solicitar2.Click += new System.EventHandler(this.bnt_Solicitar2_Click);
            // 
            // btn_Baja2
            // 
            this.btn_Baja2.Location = new System.Drawing.Point(23, 191);
            this.btn_Baja2.Name = "btn_Baja2";
            this.btn_Baja2.Size = new System.Drawing.Size(193, 23);
            this.btn_Baja2.TabIndex = 20;
            this.btn_Baja2.Text = "Baja";
            this.btn_Baja2.UseVisualStyleBackColor = true;
            this.btn_Baja2.Click += new System.EventHandler(this.btn_BajaTinte_Click);
            // 
            // txt_ColorTinte
            // 
            this.txt_ColorTinte.Location = new System.Drawing.Point(116, 105);
            this.txt_ColorTinte.Name = "txt_ColorTinte";
            this.txt_ColorTinte.Size = new System.Drawing.Size(100, 22);
            this.txt_ColorTinte.TabIndex = 24;
            // 
            // btn_Modificar2
            // 
            this.btn_Modificar2.Location = new System.Drawing.Point(23, 162);
            this.btn_Modificar2.Name = "btn_Modificar2";
            this.btn_Modificar2.Size = new System.Drawing.Size(193, 23);
            this.btn_Modificar2.TabIndex = 19;
            this.btn_Modificar2.Text = "Modificar";
            this.btn_Modificar2.UseVisualStyleBackColor = true;
            this.btn_Modificar2.Click += new System.EventHandler(this.btn_ModificarTinte_Click);
            // 
            // lbl_Color
            // 
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.Location = new System.Drawing.Point(52, 108);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(49, 17);
            this.lbl_Color.TabIndex = 23;
            this.lbl_Color.Text = "Color :";
            // 
            // btn_Alta2
            // 
            this.btn_Alta2.Location = new System.Drawing.Point(23, 133);
            this.btn_Alta2.Name = "btn_Alta2";
            this.btn_Alta2.Size = new System.Drawing.Size(193, 23);
            this.btn_Alta2.TabIndex = 18;
            this.btn_Alta2.Text = "Alta";
            this.btn_Alta2.UseVisualStyleBackColor = true;
            this.btn_Alta2.Click += new System.EventHandler(this.btn_AltaTinte_Click);
            // 
            // txt_CantidadTinte
            // 
            this.txt_CantidadTinte.Location = new System.Drawing.Point(116, 77);
            this.txt_CantidadTinte.Name = "txt_CantidadTinte";
            this.txt_CantidadTinte.Size = new System.Drawing.Size(100, 22);
            this.txt_CantidadTinte.TabIndex = 19;
            // 
            // lbl_Cantidad2
            // 
            this.lbl_Cantidad2.AutoSize = true;
            this.lbl_Cantidad2.Location = new System.Drawing.Point(38, 80);
            this.lbl_Cantidad2.Name = "lbl_Cantidad2";
            this.lbl_Cantidad2.Size = new System.Drawing.Size(72, 17);
            this.lbl_Cantidad2.TabIndex = 21;
            this.lbl_Cantidad2.Text = "Cantidad :";
            // 
            // txt_DescripcionTinte
            // 
            this.txt_DescripcionTinte.Location = new System.Drawing.Point(116, 49);
            this.txt_DescripcionTinte.Name = "txt_DescripcionTinte";
            this.txt_DescripcionTinte.Size = new System.Drawing.Size(100, 22);
            this.txt_DescripcionTinte.TabIndex = 18;
            // 
            // lbl_Descripcion2
            // 
            this.lbl_Descripcion2.AutoSize = true;
            this.lbl_Descripcion2.Location = new System.Drawing.Point(20, 54);
            this.lbl_Descripcion2.Name = "lbl_Descripcion2";
            this.lbl_Descripcion2.Size = new System.Drawing.Size(90, 17);
            this.lbl_Descripcion2.TabIndex = 22;
            this.lbl_Descripcion2.Text = "Descripción :";
            // 
            // txt_CodigoTinte
            // 
            this.txt_CodigoTinte.Location = new System.Drawing.Point(116, 21);
            this.txt_CodigoTinte.Name = "txt_CodigoTinte";
            this.txt_CodigoTinte.Size = new System.Drawing.Size(100, 22);
            this.txt_CodigoTinte.TabIndex = 17;
            // 
            // lbl_Codigo2
            // 
            this.lbl_Codigo2.AutoSize = true;
            this.lbl_Codigo2.Location = new System.Drawing.Point(52, 24);
            this.lbl_Codigo2.Name = "lbl_Codigo2";
            this.lbl_Codigo2.Size = new System.Drawing.Size(60, 17);
            this.lbl_Codigo2.TabIndex = 20;
            this.lbl_Codigo2.Text = "Código :";
            // 
            // dgv_Tintes
            // 
            this.dgv_Tintes.AllowUserToAddRows = false;
            this.dgv_Tintes.AllowUserToDeleteRows = false;
            this.dgv_Tintes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tintes.Location = new System.Drawing.Point(222, 12);
            this.dgv_Tintes.Name = "dgv_Tintes";
            this.dgv_Tintes.ReadOnly = true;
            this.dgv_Tintes.RowHeadersWidth = 51;
            this.dgv_Tintes.RowTemplate.Height = 24;
            this.dgv_Tintes.Size = new System.Drawing.Size(649, 230);
            this.dgv_Tintes.TabIndex = 0;
            this.dgv_Tintes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Tintes_CellClick);
            // 
            // AreaTeñidoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 809);
            this.Controls.Add(this.btn_Tenir);
            this.Controls.Add(this.gbx_Tintes);
            this.Controls.Add(this.gbx_TelasTenidasStock);
            this.Controls.Add(this.btn_MenuPrincipal);
            this.Controls.Add(this.gbx_Telas);
            this.Name = "AreaTeñidoMenu";
            this.Text = "Area de Teñido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AreaTeñidoMenu_FormClosing);
            this.Load += new System.EventHandler(this.AreaTeñidoMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Telas)).EndInit();
            this.gbx_Telas.ResumeLayout(false);
            this.gbx_Telas.PerformLayout();
            this.gbx_TelasTenidasStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TelasTeñidas)).EndInit();
            this.gbx_Tintes.ResumeLayout(false);
            this.gbx_Tintes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tintes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Telas;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.GroupBox gbx_Telas;
        private System.Windows.Forms.Button btn_MenuPrincipal;
        private System.Windows.Forms.Button btn_Tenir;
        private System.Windows.Forms.GroupBox gbx_TelasTenidasStock;
        private System.Windows.Forms.DataGridView dgv_TelasTeñidas;
        private System.Windows.Forms.GroupBox gbx_Tintes;
        private System.Windows.Forms.Button btn_Baja2;
        private System.Windows.Forms.TextBox txt_ColorTinte;
        private System.Windows.Forms.Button btn_Modificar2;
        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.Button btn_Alta2;
        private System.Windows.Forms.TextBox txt_CantidadTinte;
        private System.Windows.Forms.Label lbl_Cantidad2;
        private System.Windows.Forms.TextBox txt_DescripcionTinte;
        private System.Windows.Forms.Label lbl_Descripcion2;
        private System.Windows.Forms.TextBox txt_CodigoTinte;
        private System.Windows.Forms.Label lbl_Codigo2;
        private System.Windows.Forms.DataGridView dgv_Tintes;
        private System.Windows.Forms.Button btn_Solicitar;
        private System.Windows.Forms.Button btn_Solicitar2;
    }
}