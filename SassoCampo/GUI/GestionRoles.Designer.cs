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
            this.btn_AltaRol = new System.Windows.Forms.Button();
            this.btn_ModificarRol = new System.Windows.Forms.Button();
            this.btn_BajaRol = new System.Windows.Forms.Button();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.dgv_Roles = new System.Windows.Forms.DataGridView();
            this.btn_AgregarPermiso = new System.Windows.Forms.Button();
            this.btn_EliminarPermiso = new System.Windows.Forms.Button();
            this.dgv_PermisosRol = new System.Windows.Forms.DataGridView();
            this.dgv_Permisos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Roles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PermisosRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Permisos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AltaRol
            // 
            this.btn_AltaRol.Location = new System.Drawing.Point(12, 66);
            this.btn_AltaRol.Name = "btn_AltaRol";
            this.btn_AltaRol.Size = new System.Drawing.Size(209, 23);
            this.btn_AltaRol.TabIndex = 0;
            this.btn_AltaRol.Text = "Alta";
            this.btn_AltaRol.UseVisualStyleBackColor = true;
            this.btn_AltaRol.Click += new System.EventHandler(this.btn_AltaRol_Click);
            // 
            // btn_ModificarRol
            // 
            this.btn_ModificarRol.Location = new System.Drawing.Point(12, 95);
            this.btn_ModificarRol.Name = "btn_ModificarRol";
            this.btn_ModificarRol.Size = new System.Drawing.Size(209, 23);
            this.btn_ModificarRol.TabIndex = 1;
            this.btn_ModificarRol.Text = "Modificar";
            this.btn_ModificarRol.UseVisualStyleBackColor = true;
            this.btn_ModificarRol.Click += new System.EventHandler(this.btn_ModificarRol_Click);
            // 
            // btn_BajaRol
            // 
            this.btn_BajaRol.Location = new System.Drawing.Point(12, 124);
            this.btn_BajaRol.Name = "btn_BajaRol";
            this.btn_BajaRol.Size = new System.Drawing.Size(209, 23);
            this.btn_BajaRol.TabIndex = 2;
            this.btn_BajaRol.Text = "Baja";
            this.btn_BajaRol.UseVisualStyleBackColor = true;
            this.btn_BajaRol.Click += new System.EventHandler(this.btn_BajaRol_Click);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(72, 9);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(27, 17);
            this.lbl_Id.TabIndex = 3;
            this.lbl_Id.Text = "Id :";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(33, 41);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(66, 17);
            this.lbl_Nombre.TabIndex = 4;
            this.lbl_Nombre.Text = "Nombre :";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(105, 6);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(116, 22);
            this.txt_Id.TabIndex = 6;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(105, 38);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(116, 22);
            this.txt_Nombre.TabIndex = 7;
            // 
            // dgv_Roles
            // 
            this.dgv_Roles.AllowUserToAddRows = false;
            this.dgv_Roles.AllowUserToDeleteRows = false;
            this.dgv_Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Roles.Location = new System.Drawing.Point(227, 6);
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
            this.btn_AgregarPermiso.Location = new System.Drawing.Point(12, 153);
            this.btn_AgregarPermiso.Name = "btn_AgregarPermiso";
            this.btn_AgregarPermiso.Size = new System.Drawing.Size(209, 23);
            this.btn_AgregarPermiso.TabIndex = 10;
            this.btn_AgregarPermiso.Text = "Agregar Permiso";
            this.btn_AgregarPermiso.UseVisualStyleBackColor = true;
            this.btn_AgregarPermiso.Click += new System.EventHandler(this.btn_AgregarPermiso_Click);
            // 
            // btn_EliminarPermiso
            // 
            this.btn_EliminarPermiso.Location = new System.Drawing.Point(12, 182);
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
            this.dgv_PermisosRol.Location = new System.Drawing.Point(437, 6);
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
            this.dgv_Permisos.Location = new System.Drawing.Point(437, 233);
            this.dgv_Permisos.Name = "dgv_Permisos";
            this.dgv_Permisos.ReadOnly = true;
            this.dgv_Permisos.RowHeadersWidth = 51;
            this.dgv_Permisos.RowTemplate.Height = 24;
            this.dgv_Permisos.Size = new System.Drawing.Size(378, 199);
            this.dgv_Permisos.TabIndex = 13;
            // 
            // GestionRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.dgv_Permisos);
            this.Controls.Add(this.dgv_PermisosRol);
            this.Controls.Add(this.btn_EliminarPermiso);
            this.Controls.Add(this.btn_AgregarPermiso);
            this.Controls.Add(this.dgv_Roles);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.btn_BajaRol);
            this.Controls.Add(this.btn_ModificarRol);
            this.Controls.Add(this.btn_AltaRol);
            this.Name = "GestionRoles";
            this.Text = "Gestión de Roles";
            this.Load += new System.EventHandler(this.GestionRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Roles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PermisosRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Permisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AltaRol;
        private System.Windows.Forms.Button btn_ModificarRol;
        private System.Windows.Forms.Button btn_BajaRol;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.DataGridView dgv_Roles;
        private System.Windows.Forms.Button btn_AgregarPermiso;
        private System.Windows.Forms.Button btn_EliminarPermiso;
        private System.Windows.Forms.DataGridView dgv_PermisosRol;
        private System.Windows.Forms.DataGridView dgv_Permisos;
    }
}