namespace GUI
{
    partial class AreaTeñidoMenu
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
            this.lbl_Id = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.btn_AltaTela = new System.Windows.Forms.Button();
            this.btn_ModificarTela = new System.Windows.Forms.Button();
            this.btn_BajaTela = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_MenuPrincipal = new System.Windows.Forms.Button();
            this.btn_Teñir = new System.Windows.Forms.Button();
            this.gbx_Tela = new System.Windows.Forms.GroupBox();
            this.dgv_TelasTeñidas = new System.Windows.Forms.DataGridView();
            this.gbx_Tintes = new System.Windows.Forms.GroupBox();
            this.btn_BajaTinte = new System.Windows.Forms.Button();
            this.txt_ColorTinte = new System.Windows.Forms.TextBox();
            this.btn_ModificarTinte = new System.Windows.Forms.Button();
            this.lbl_ColorTinte = new System.Windows.Forms.Label();
            this.btn_AltaTinte = new System.Windows.Forms.Button();
            this.txt_CantidadTinte = new System.Windows.Forms.TextBox();
            this.lbl_CantidadTinte = new System.Windows.Forms.Label();
            this.txt_DescripcionTinte = new System.Windows.Forms.TextBox();
            this.lbl_DescripcionTinte = new System.Windows.Forms.Label();
            this.txt_CodigoTinte = new System.Windows.Forms.TextBox();
            this.lbl_CodigoTinte = new System.Windows.Forms.Label();
            this.txt_IdTinte = new System.Windows.Forms.TextBox();
            this.lbl_IdTinte = new System.Windows.Forms.Label();
            this.dgv_Tintes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Telas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbx_Tela.SuspendLayout();
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
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(95, 40);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(27, 17);
            this.lbl_Id.TabIndex = 1;
            this.lbl_Id.Text = "Id :";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(128, 37);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 22);
            this.txt_Id.TabIndex = 2;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(128, 65);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(100, 22);
            this.txt_Codigo.TabIndex = 3;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(128, 93);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(100, 22);
            this.txt_Descripcion.TabIndex = 4;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(128, 121);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 22);
            this.txt_Cantidad.TabIndex = 5;
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(64, 68);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(60, 17);
            this.lbl_Codigo.TabIndex = 8;
            this.lbl_Codigo.Text = "Código :";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(50, 124);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(72, 17);
            this.lbl_Cantidad.TabIndex = 9;
            this.lbl_Cantidad.Text = "Cantidad :";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(32, 98);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(90, 17);
            this.lbl_Descripcion.TabIndex = 10;
            this.lbl_Descripcion.Text = "Descripción :";
            // 
            // btn_AltaTela
            // 
            this.btn_AltaTela.Location = new System.Drawing.Point(23, 137);
            this.btn_AltaTela.Name = "btn_AltaTela";
            this.btn_AltaTela.Size = new System.Drawing.Size(193, 23);
            this.btn_AltaTela.TabIndex = 11;
            this.btn_AltaTela.Text = "Alta";
            this.btn_AltaTela.UseVisualStyleBackColor = true;
            this.btn_AltaTela.Click += new System.EventHandler(this.btn_AltaTela_Click);
            // 
            // btn_ModificarTela
            // 
            this.btn_ModificarTela.Location = new System.Drawing.Point(23, 166);
            this.btn_ModificarTela.Name = "btn_ModificarTela";
            this.btn_ModificarTela.Size = new System.Drawing.Size(193, 23);
            this.btn_ModificarTela.TabIndex = 12;
            this.btn_ModificarTela.Text = "Modificar";
            this.btn_ModificarTela.UseVisualStyleBackColor = true;
            this.btn_ModificarTela.Click += new System.EventHandler(this.btn_ModificarTela_Click);
            // 
            // btn_BajaTela
            // 
            this.btn_BajaTela.Location = new System.Drawing.Point(23, 195);
            this.btn_BajaTela.Name = "btn_BajaTela";
            this.btn_BajaTela.Size = new System.Drawing.Size(193, 23);
            this.btn_BajaTela.TabIndex = 13;
            this.btn_BajaTela.Text = "Baja";
            this.btn_BajaTela.UseVisualStyleBackColor = true;
            this.btn_BajaTela.Click += new System.EventHandler(this.btn_BajaTela_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Telas);
            this.groupBox1.Controls.Add(this.btn_AltaTela);
            this.groupBox1.Controls.Add(this.btn_ModificarTela);
            this.groupBox1.Controls.Add(this.btn_BajaTela);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 227);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestión de Telas";
            // 
            // btn_MenuPrincipal
            // 
            this.btn_MenuPrincipal.Location = new System.Drawing.Point(899, 12);
            this.btn_MenuPrincipal.Name = "btn_MenuPrincipal";
            this.btn_MenuPrincipal.Size = new System.Drawing.Size(75, 73);
            this.btn_MenuPrincipal.TabIndex = 15;
            this.btn_MenuPrincipal.Text = "Volver Al Menu Principal";
            this.btn_MenuPrincipal.UseVisualStyleBackColor = true;
            this.btn_MenuPrincipal.Click += new System.EventHandler(this.btn_MenuPrincipal_Click);
            // 
            // btn_Teñir
            // 
            this.btn_Teñir.Location = new System.Drawing.Point(776, 24);
            this.btn_Teñir.Name = "btn_Teñir";
            this.btn_Teñir.Size = new System.Drawing.Size(107, 206);
            this.btn_Teñir.TabIndex = 14;
            this.btn_Teñir.Text = "Teñir Tela";
            this.btn_Teñir.UseVisualStyleBackColor = true;
            this.btn_Teñir.Click += new System.EventHandler(this.btn_Teñir_Click);
            // 
            // gbx_Tela
            // 
            this.gbx_Tela.Controls.Add(this.dgv_TelasTeñidas);
            this.gbx_Tela.Location = new System.Drawing.Point(12, 504);
            this.gbx_Tela.Name = "gbx_Tela";
            this.gbx_Tela.Size = new System.Drawing.Size(822, 262);
            this.gbx_Tela.TabIndex = 16;
            this.gbx_Tela.TabStop = false;
            this.gbx_Tela.Text = "Telas teñidas en stock";
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
            this.gbx_Tintes.Controls.Add(this.btn_BajaTinte);
            this.gbx_Tintes.Controls.Add(this.txt_ColorTinte);
            this.gbx_Tintes.Controls.Add(this.btn_ModificarTinte);
            this.gbx_Tintes.Controls.Add(this.lbl_ColorTinte);
            this.gbx_Tintes.Controls.Add(this.btn_AltaTinte);
            this.gbx_Tintes.Controls.Add(this.txt_CantidadTinte);
            this.gbx_Tintes.Controls.Add(this.lbl_CantidadTinte);
            this.gbx_Tintes.Controls.Add(this.txt_DescripcionTinte);
            this.gbx_Tintes.Controls.Add(this.lbl_DescripcionTinte);
            this.gbx_Tintes.Controls.Add(this.txt_CodigoTinte);
            this.gbx_Tintes.Controls.Add(this.lbl_CodigoTinte);
            this.gbx_Tintes.Controls.Add(this.txt_IdTinte);
            this.gbx_Tintes.Controls.Add(this.lbl_IdTinte);
            this.gbx_Tintes.Controls.Add(this.dgv_Tintes);
            this.gbx_Tintes.Location = new System.Drawing.Point(12, 245);
            this.gbx_Tintes.Name = "gbx_Tintes";
            this.gbx_Tintes.Size = new System.Drawing.Size(877, 253);
            this.gbx_Tintes.TabIndex = 17;
            this.gbx_Tintes.TabStop = false;
            this.gbx_Tintes.Text = "Gestión de Tintes";
            // 
            // btn_BajaTinte
            // 
            this.btn_BajaTinte.Location = new System.Drawing.Point(23, 219);
            this.btn_BajaTinte.Name = "btn_BajaTinte";
            this.btn_BajaTinte.Size = new System.Drawing.Size(193, 23);
            this.btn_BajaTinte.TabIndex = 20;
            this.btn_BajaTinte.Text = "Baja";
            this.btn_BajaTinte.UseVisualStyleBackColor = true;
            this.btn_BajaTinte.Click += new System.EventHandler(this.btn_BajaTinte_Click);
            // 
            // txt_ColorTinte
            // 
            this.txt_ColorTinte.Location = new System.Drawing.Point(116, 133);
            this.txt_ColorTinte.Name = "txt_ColorTinte";
            this.txt_ColorTinte.Size = new System.Drawing.Size(100, 22);
            this.txt_ColorTinte.TabIndex = 24;
            // 
            // btn_ModificarTinte
            // 
            this.btn_ModificarTinte.Location = new System.Drawing.Point(23, 190);
            this.btn_ModificarTinte.Name = "btn_ModificarTinte";
            this.btn_ModificarTinte.Size = new System.Drawing.Size(193, 23);
            this.btn_ModificarTinte.TabIndex = 19;
            this.btn_ModificarTinte.Text = "Modificar";
            this.btn_ModificarTinte.UseVisualStyleBackColor = true;
            this.btn_ModificarTinte.Click += new System.EventHandler(this.btn_ModificarTinte_Click);
            // 
            // lbl_ColorTinte
            // 
            this.lbl_ColorTinte.AutoSize = true;
            this.lbl_ColorTinte.Location = new System.Drawing.Point(52, 136);
            this.lbl_ColorTinte.Name = "lbl_ColorTinte";
            this.lbl_ColorTinte.Size = new System.Drawing.Size(49, 17);
            this.lbl_ColorTinte.TabIndex = 23;
            this.lbl_ColorTinte.Text = "Color :";
            // 
            // btn_AltaTinte
            // 
            this.btn_AltaTinte.Location = new System.Drawing.Point(23, 161);
            this.btn_AltaTinte.Name = "btn_AltaTinte";
            this.btn_AltaTinte.Size = new System.Drawing.Size(193, 23);
            this.btn_AltaTinte.TabIndex = 18;
            this.btn_AltaTinte.Text = "Alta";
            this.btn_AltaTinte.UseVisualStyleBackColor = true;
            this.btn_AltaTinte.Click += new System.EventHandler(this.btn_AltaTinte_Click);
            // 
            // txt_CantidadTinte
            // 
            this.txt_CantidadTinte.Location = new System.Drawing.Point(116, 105);
            this.txt_CantidadTinte.Name = "txt_CantidadTinte";
            this.txt_CantidadTinte.Size = new System.Drawing.Size(100, 22);
            this.txt_CantidadTinte.TabIndex = 19;
            // 
            // lbl_CantidadTinte
            // 
            this.lbl_CantidadTinte.AutoSize = true;
            this.lbl_CantidadTinte.Location = new System.Drawing.Point(38, 108);
            this.lbl_CantidadTinte.Name = "lbl_CantidadTinte";
            this.lbl_CantidadTinte.Size = new System.Drawing.Size(72, 17);
            this.lbl_CantidadTinte.TabIndex = 21;
            this.lbl_CantidadTinte.Text = "Cantidad :";
            // 
            // txt_DescripcionTinte
            // 
            this.txt_DescripcionTinte.Location = new System.Drawing.Point(116, 77);
            this.txt_DescripcionTinte.Name = "txt_DescripcionTinte";
            this.txt_DescripcionTinte.Size = new System.Drawing.Size(100, 22);
            this.txt_DescripcionTinte.TabIndex = 18;
            // 
            // lbl_DescripcionTinte
            // 
            this.lbl_DescripcionTinte.AutoSize = true;
            this.lbl_DescripcionTinte.Location = new System.Drawing.Point(20, 82);
            this.lbl_DescripcionTinte.Name = "lbl_DescripcionTinte";
            this.lbl_DescripcionTinte.Size = new System.Drawing.Size(90, 17);
            this.lbl_DescripcionTinte.TabIndex = 22;
            this.lbl_DescripcionTinte.Text = "Descripción :";
            // 
            // txt_CodigoTinte
            // 
            this.txt_CodigoTinte.Location = new System.Drawing.Point(116, 49);
            this.txt_CodigoTinte.Name = "txt_CodigoTinte";
            this.txt_CodigoTinte.Size = new System.Drawing.Size(100, 22);
            this.txt_CodigoTinte.TabIndex = 17;
            // 
            // lbl_CodigoTinte
            // 
            this.lbl_CodigoTinte.AutoSize = true;
            this.lbl_CodigoTinte.Location = new System.Drawing.Point(52, 52);
            this.lbl_CodigoTinte.Name = "lbl_CodigoTinte";
            this.lbl_CodigoTinte.Size = new System.Drawing.Size(60, 17);
            this.lbl_CodigoTinte.TabIndex = 20;
            this.lbl_CodigoTinte.Text = "Código :";
            // 
            // txt_IdTinte
            // 
            this.txt_IdTinte.Location = new System.Drawing.Point(116, 21);
            this.txt_IdTinte.Name = "txt_IdTinte";
            this.txt_IdTinte.Size = new System.Drawing.Size(100, 22);
            this.txt_IdTinte.TabIndex = 16;
            // 
            // lbl_IdTinte
            // 
            this.lbl_IdTinte.AutoSize = true;
            this.lbl_IdTinte.Location = new System.Drawing.Point(83, 24);
            this.lbl_IdTinte.Name = "lbl_IdTinte";
            this.lbl_IdTinte.Size = new System.Drawing.Size(27, 17);
            this.lbl_IdTinte.TabIndex = 15;
            this.lbl_IdTinte.Text = "Id :";
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
            this.ClientSize = new System.Drawing.Size(986, 775);
            this.Controls.Add(this.btn_Teñir);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.lbl_Codigo);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.gbx_Tintes);
            this.Controls.Add(this.gbx_Tela);
            this.Controls.Add(this.btn_MenuPrincipal);
            this.Controls.Add(this.groupBox1);
            this.Name = "AreaTeñidoMenu";
            this.Text = "Area de Teñido";
            this.Load += new System.EventHandler(this.AreaTeñidoMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Telas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gbx_Tela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TelasTeñidas)).EndInit();
            this.gbx_Tintes.ResumeLayout(false);
            this.gbx_Tintes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tintes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Telas;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Button btn_AltaTela;
        private System.Windows.Forms.Button btn_ModificarTela;
        private System.Windows.Forms.Button btn_BajaTela;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_MenuPrincipal;
        private System.Windows.Forms.Button btn_Teñir;
        private System.Windows.Forms.GroupBox gbx_Tela;
        private System.Windows.Forms.DataGridView dgv_TelasTeñidas;
        private System.Windows.Forms.GroupBox gbx_Tintes;
        private System.Windows.Forms.Button btn_BajaTinte;
        private System.Windows.Forms.TextBox txt_ColorTinte;
        private System.Windows.Forms.Button btn_ModificarTinte;
        private System.Windows.Forms.Label lbl_ColorTinte;
        private System.Windows.Forms.Button btn_AltaTinte;
        private System.Windows.Forms.TextBox txt_CantidadTinte;
        private System.Windows.Forms.Label lbl_CantidadTinte;
        private System.Windows.Forms.TextBox txt_DescripcionTinte;
        private System.Windows.Forms.Label lbl_DescripcionTinte;
        private System.Windows.Forms.TextBox txt_CodigoTinte;
        private System.Windows.Forms.Label lbl_CodigoTinte;
        private System.Windows.Forms.TextBox txt_IdTinte;
        private System.Windows.Forms.Label lbl_IdTinte;
        private System.Windows.Forms.DataGridView dgv_Tintes;
    }
}