namespace GUI
{
    partial class GestionRoles
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
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.dgv_Roles = new System.Windows.Forms.DataGridView();
            this.btn_AgregarPermiso = new System.Windows.Forms.Button();
            this.btn_EliminarPermiso = new System.Windows.Forms.Button();
            this.dgv_PermisosRol = new System.Windows.Forms.DataGridView();
            this.dgv_Permisos = new System.Windows.Forms.DataGridView();
            this.gbx_Roles = new System.Windows.Forms.GroupBox();
            this.gbx_Permisos = new System.Windows.Forms.GroupBox();
            this.btn_MenuPrincipal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Roles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PermisosRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Permisos)).BeginInit();
            this.gbx_Roles.SuspendLayout();
            this.gbx_Permisos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(9, 72);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(209, 23);
            this.btn_Alta.TabIndex = 0;
            this.btn_Alta.Text = "Alta";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_AltaRol_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(9, 101);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(209, 23);
            this.btn_Modificar.TabIndex = 1;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_ModificarRol_Click);
            // 
            // btn_Baja
            // 
            this.btn_Baja.Location = new System.Drawing.Point(9, 130);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(209, 23);
            this.btn_Baja.TabIndex = 2;
            this.btn_Baja.Text = "Baja";
            this.btn_Baja.UseVisualStyleBackColor = true;
            this.btn_Baja.Click += new System.EventHandler(this.btn_BajaRol_Click);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(69, 15);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(27, 17);
            this.lbl_Id.TabIndex = 3;
            this.lbl_Id.Text = "Id :";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(30, 47);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(66, 17);
            this.lbl_Nombre.TabIndex = 4;
            this.lbl_Nombre.Text = "Nombre :";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(102, 12);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(116, 22);
            this.txt_Id.TabIndex = 6;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(102, 44);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(116, 22);
            this.txt_Nombre.TabIndex = 7;
            // 
            // dgv_Roles
            // 
            this.dgv_Roles.AllowUserToAddRows = false;
            this.dgv_Roles.AllowUserToDeleteRows = false;
            this.dgv_Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Roles.Location = new System.Drawing.Point(224, 12);
            this.dgv_Roles.Name = "dgv_Roles";
            this.dgv_Roles.ReadOnly = true;
            this.dgv_Roles.RowHeadersWidth = 51;
            this.dgv_Roles.RowTemplate.Height = 24;
            this.dgv_Roles.Size = new System.Drawing.Size(204, 199);
            this.dgv_Roles.TabIndex = 9;
            this.dgv_Roles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Roles_CellClick);
            // 
            // btn_AgregarPermiso
            // 
            this.btn_AgregarPermiso.Location = new System.Drawing.Point(9, 159);
            this.btn_AgregarPermiso.Name = "btn_AgregarPermiso";
            this.btn_AgregarPermiso.Size = new System.Drawing.Size(209, 23);
            this.btn_AgregarPermiso.TabIndex = 10;
            this.btn_AgregarPermiso.Text = "Agregar Permiso";
            this.btn_AgregarPermiso.UseVisualStyleBackColor = true;
            this.btn_AgregarPermiso.Click += new System.EventHandler(this.btn_AgregarPermiso_Click);
            // 
            // btn_EliminarPermiso
            // 
            this.btn_EliminarPermiso.Location = new System.Drawing.Point(9, 188);
            this.btn_EliminarPermiso.Name = "btn_EliminarPermiso";
            this.btn_EliminarPermiso.Size = new System.Drawing.Size(209, 23);
            this.btn_EliminarPermiso.TabIndex = 11;
            this.btn_EliminarPermiso.Text = "Eliminar Permiso";
            this.btn_EliminarPermiso.UseVisualStyleBackColor = true;
            this.btn_EliminarPermiso.Click += new System.EventHandler(this.btn_EliminarPermiso_Click);
            // 
            // dgv_PermisosRol
            // 
            this.dgv_PermisosRol.AllowUserToAddRows = false;
            this.dgv_PermisosRol.AllowUserToDeleteRows = false;
            this.dgv_PermisosRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PermisosRol.Location = new System.Drawing.Point(434, 12);
            this.dgv_PermisosRol.Name = "dgv_PermisosRol";
            this.dgv_PermisosRol.ReadOnly = true;
            this.dgv_PermisosRol.RowHeadersWidth = 51;
            this.dgv_PermisosRol.RowTemplate.Height = 24;
            this.dgv_PermisosRol.Size = new System.Drawing.Size(378, 199);
            this.dgv_PermisosRol.TabIndex = 12;
            // 
            // dgv_Permisos
            // 
            this.dgv_Permisos.AllowUserToAddRows = false;
            this.dgv_Permisos.AllowUserToDeleteRows = false;
            this.dgv_Permisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Permisos.Location = new System.Drawing.Point(9, 21);
            this.dgv_Permisos.Name = "dgv_Permisos";
            this.dgv_Permisos.ReadOnly = true;
            this.dgv_Permisos.RowHeadersWidth = 51;
            this.dgv_Permisos.RowTemplate.Height = 24;
            this.dgv_Permisos.Size = new System.Drawing.Size(378, 199);
            this.dgv_Permisos.TabIndex = 13;
            // 
            // gbx_Roles
            // 
            this.gbx_Roles.Controls.Add(this.dgv_PermisosRol);
            this.gbx_Roles.Controls.Add(this.btn_EliminarPermiso);
            this.gbx_Roles.Controls.Add(this.dgv_Roles);
            this.gbx_Roles.Controls.Add(this.btn_AgregarPermiso);
            this.gbx_Roles.Controls.Add(this.txt_Id);
            this.gbx_Roles.Controls.Add(this.txt_Nombre);
            this.gbx_Roles.Controls.Add(this.btn_Alta);
            this.gbx_Roles.Controls.Add(this.btn_Modificar);
            this.gbx_Roles.Controls.Add(this.lbl_Nombre);
            this.gbx_Roles.Controls.Add(this.btn_Baja);
            this.gbx_Roles.Controls.Add(this.lbl_Id);
            this.gbx_Roles.Location = new System.Drawing.Point(12, 12);
            this.gbx_Roles.Name = "gbx_Roles";
            this.gbx_Roles.Size = new System.Drawing.Size(827, 222);
            this.gbx_Roles.TabIndex = 14;
            this.gbx_Roles.TabStop = false;
            this.gbx_Roles.Text = "Roles";
            // 
            // gbx_Permisos
            // 
            this.gbx_Permisos.Controls.Add(this.dgv_Permisos);
            this.gbx_Permisos.Location = new System.Drawing.Point(433, 240);
            this.gbx_Permisos.Name = "gbx_Permisos";
            this.gbx_Permisos.Size = new System.Drawing.Size(406, 234);
            this.gbx_Permisos.TabIndex = 15;
            this.gbx_Permisos.TabStop = false;
            this.gbx_Permisos.Text = "Permisos";
            // 
            // btn_MenuPrincipal
            // 
            this.btn_MenuPrincipal.Location = new System.Drawing.Point(845, 24);
            this.btn_MenuPrincipal.Name = "btn_MenuPrincipal";
            this.btn_MenuPrincipal.Size = new System.Drawing.Size(75, 73);
            this.btn_MenuPrincipal.TabIndex = 16;
            this.btn_MenuPrincipal.Text = "Volver Al Menu Principal";
            this.btn_MenuPrincipal.UseVisualStyleBackColor = true;
            this.btn_MenuPrincipal.Click += new System.EventHandler(this.btn_MenuPrincipal_Click);
            // 
            // GestionRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 490);
            this.Controls.Add(this.btn_MenuPrincipal);
            this.Controls.Add(this.gbx_Permisos);
            this.Controls.Add(this.gbx_Roles);
            this.Name = "GestionRoles";
            this.Text = "Gestión de Roles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionRoles_FormClosing);
            this.Load += new System.EventHandler(this.GestionRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Roles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PermisosRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Permisos)).EndInit();
            this.gbx_Roles.ResumeLayout(false);
            this.gbx_Roles.PerformLayout();
            this.gbx_Permisos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.DataGridView dgv_Roles;
        private System.Windows.Forms.Button btn_AgregarPermiso;
        private System.Windows.Forms.Button btn_EliminarPermiso;
        private System.Windows.Forms.DataGridView dgv_PermisosRol;
        private System.Windows.Forms.DataGridView dgv_Permisos;
        private System.Windows.Forms.GroupBox gbx_Roles;
        private System.Windows.Forms.GroupBox gbx_Permisos;
        private System.Windows.Forms.Button btn_MenuPrincipal;
    }
}