namespace GUI
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_NombreUsuario = new System.Windows.Forms.Label();
            this.lbl_NombreUsuario2 = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_NombreYApellido = new System.Windows.Forms.Label();
            this.lbl_Cargo = new System.Windows.Forms.Label();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.gbox_InfoUsuario = new System.Windows.Forms.GroupBox();
            this.btn_AreaTejido = new System.Windows.Forms.Button();
            this.btn_GestionarUsuarios = new System.Windows.Forms.Button();
            this.btn_GestionarRoles = new System.Windows.Forms.Button();
            this.btn_AreaTeñido = new System.Windows.Forms.Button();
            this.btn_AreaCortado = new System.Windows.Forms.Button();
            this.btn_AreaConfeccion = new System.Windows.Forms.Button();
            this.saveFileDialogBackup = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogRestore = new System.Windows.Forms.OpenFileDialog();
            this.cmb_Idioma = new System.Windows.Forms.ComboBox();
            this.lbl_Idioma = new System.Windows.Forms.Label();
            this.btn_GestionarProduccion = new System.Windows.Forms.Button();
            this.linklbl_Ayuda = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.gbox_InfoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem,
            this.restoreToolStripMenuItem,
            this.bitacoraToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(605, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.bitacoraToolStripMenuItem.Text = "Bitácora";
            this.bitacoraToolStripMenuItem.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // lbl_NombreUsuario
            // 
            this.lbl_NombreUsuario.AutoSize = true;
            this.lbl_NombreUsuario.Location = new System.Drawing.Point(7, 18);
            this.lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            this.lbl_NombreUsuario.Size = new System.Drawing.Size(65, 17);
            this.lbl_NombreUsuario.TabIndex = 2;
            this.lbl_NombreUsuario.Text = "Usuario: ";
            // 
            // lbl_NombreUsuario2
            // 
            this.lbl_NombreUsuario2.AutoSize = true;
            this.lbl_NombreUsuario2.Location = new System.Drawing.Point(95, 18);
            this.lbl_NombreUsuario2.Name = "lbl_NombreUsuario2";
            this.lbl_NombreUsuario2.Size = new System.Drawing.Size(129, 17);
            this.lbl_NombreUsuario2.TabIndex = 3;
            this.lbl_NombreUsuario2.Text = "lbl_NombreUsuario";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(6, 35);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(66, 17);
            this.lbl_Nombre.TabIndex = 4;
            this.lbl_Nombre.Text = "Nombre: ";
            // 
            // lbl_NombreYApellido
            // 
            this.lbl_NombreYApellido.AutoSize = true;
            this.lbl_NombreYApellido.Location = new System.Drawing.Point(95, 35);
            this.lbl_NombreYApellido.Name = "lbl_NombreYApellido";
            this.lbl_NombreYApellido.Size = new System.Drawing.Size(139, 17);
            this.lbl_NombreYApellido.TabIndex = 5;
            this.lbl_NombreYApellido.Text = "lbl_NombreYApellido";
            // 
            // lbl_Cargo
            // 
            this.lbl_Cargo.AutoSize = true;
            this.lbl_Cargo.Location = new System.Drawing.Point(17, 52);
            this.lbl_Cargo.Name = "lbl_Cargo";
            this.lbl_Cargo.Size = new System.Drawing.Size(54, 17);
            this.lbl_Cargo.TabIndex = 6;
            this.lbl_Cargo.Text = "Cargo: ";
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.Location = new System.Drawing.Point(95, 52);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(51, 17);
            this.lbl_Rol.TabIndex = 7;
            this.lbl_Rol.Text = "lbl_Rol";
            // 
            // gbox_InfoUsuario
            // 
            this.gbox_InfoUsuario.Controls.Add(this.lbl_NombreUsuario);
            this.gbox_InfoUsuario.Controls.Add(this.lbl_Rol);
            this.gbox_InfoUsuario.Controls.Add(this.lbl_NombreUsuario2);
            this.gbox_InfoUsuario.Controls.Add(this.lbl_Cargo);
            this.gbox_InfoUsuario.Controls.Add(this.lbl_Nombre);
            this.gbox_InfoUsuario.Controls.Add(this.lbl_NombreYApellido);
            this.gbox_InfoUsuario.Location = new System.Drawing.Point(12, 31);
            this.gbox_InfoUsuario.Name = "gbox_InfoUsuario";
            this.gbox_InfoUsuario.Size = new System.Drawing.Size(314, 80);
            this.gbox_InfoUsuario.TabIndex = 8;
            this.gbox_InfoUsuario.TabStop = false;
            this.gbox_InfoUsuario.Text = "Información de Usuario";
            // 
            // btn_AreaTejido
            // 
            this.btn_AreaTejido.Location = new System.Drawing.Point(332, 33);
            this.btn_AreaTejido.Name = "btn_AreaTejido";
            this.btn_AreaTejido.Size = new System.Drawing.Size(265, 23);
            this.btn_AreaTejido.TabIndex = 9;
            this.btn_AreaTejido.Text = "Ir al Área de Tejido";
            this.btn_AreaTejido.UseVisualStyleBackColor = true;
            this.btn_AreaTejido.Click += new System.EventHandler(this.btn_IrAreaTejido_Click);
            // 
            // btn_GestionarUsuarios
            // 
            this.btn_GestionarUsuarios.Location = new System.Drawing.Point(12, 120);
            this.btn_GestionarUsuarios.Name = "btn_GestionarUsuarios";
            this.btn_GestionarUsuarios.Size = new System.Drawing.Size(314, 23);
            this.btn_GestionarUsuarios.TabIndex = 10;
            this.btn_GestionarUsuarios.Text = "Gestionar Usuarios";
            this.btn_GestionarUsuarios.UseVisualStyleBackColor = true;
            this.btn_GestionarUsuarios.Click += new System.EventHandler(this.btn_GestionarUsuarios_Click);
            // 
            // btn_GestionarRoles
            // 
            this.btn_GestionarRoles.Location = new System.Drawing.Point(12, 149);
            this.btn_GestionarRoles.Name = "btn_GestionarRoles";
            this.btn_GestionarRoles.Size = new System.Drawing.Size(314, 23);
            this.btn_GestionarRoles.TabIndex = 11;
            this.btn_GestionarRoles.Text = "Gestionar Roles";
            this.btn_GestionarRoles.UseVisualStyleBackColor = true;
            this.btn_GestionarRoles.Click += new System.EventHandler(this.btn_GestionarRoles_Click);
            // 
            // btn_AreaTeñido
            // 
            this.btn_AreaTeñido.Location = new System.Drawing.Point(332, 62);
            this.btn_AreaTeñido.Name = "btn_AreaTeñido";
            this.btn_AreaTeñido.Size = new System.Drawing.Size(265, 23);
            this.btn_AreaTeñido.TabIndex = 12;
            this.btn_AreaTeñido.Text = "Ir al Área de Teñido";
            this.btn_AreaTeñido.UseVisualStyleBackColor = true;
            this.btn_AreaTeñido.Click += new System.EventHandler(this.btn_AreaTeñido_Click);
            // 
            // btn_AreaCortado
            // 
            this.btn_AreaCortado.Location = new System.Drawing.Point(332, 91);
            this.btn_AreaCortado.Name = "btn_AreaCortado";
            this.btn_AreaCortado.Size = new System.Drawing.Size(265, 23);
            this.btn_AreaCortado.TabIndex = 13;
            this.btn_AreaCortado.Text = "Ir al Área de Cortado";
            this.btn_AreaCortado.UseVisualStyleBackColor = true;
            this.btn_AreaCortado.Click += new System.EventHandler(this.btn_AreaCortado_Click);
            // 
            // btn_AreaConfeccion
            // 
            this.btn_AreaConfeccion.Location = new System.Drawing.Point(332, 120);
            this.btn_AreaConfeccion.Name = "btn_AreaConfeccion";
            this.btn_AreaConfeccion.Size = new System.Drawing.Size(265, 23);
            this.btn_AreaConfeccion.TabIndex = 14;
            this.btn_AreaConfeccion.Text = "Ir al Área de Confección";
            this.btn_AreaConfeccion.UseVisualStyleBackColor = true;
            this.btn_AreaConfeccion.Click += new System.EventHandler(this.btn_AreaConfeccion_Click);
            // 
            // openFileDialogRestore
            // 
            this.openFileDialogRestore.FileName = "openFileDialog1";
            // 
            // cmb_Idioma
            // 
            this.cmb_Idioma.FormattingEnabled = true;
            this.cmb_Idioma.Location = new System.Drawing.Point(445, 3);
            this.cmb_Idioma.Name = "cmb_Idioma";
            this.cmb_Idioma.Size = new System.Drawing.Size(152, 24);
            this.cmb_Idioma.TabIndex = 16;
            this.cmb_Idioma.SelectedValueChanged += new System.EventHandler(this.cmb_Idioma_SelectedValueChanged);
            // 
            // lbl_Idioma
            // 
            this.lbl_Idioma.AutoSize = true;
            this.lbl_Idioma.Location = new System.Drawing.Point(365, 6);
            this.lbl_Idioma.Name = "lbl_Idioma";
            this.lbl_Idioma.Size = new System.Drawing.Size(57, 17);
            this.lbl_Idioma.TabIndex = 15;
            this.lbl_Idioma.Text = "Idioma :";
            // 
            // btn_GestionarProduccion
            // 
            this.btn_GestionarProduccion.Location = new System.Drawing.Point(12, 178);
            this.btn_GestionarProduccion.Name = "btn_GestionarProduccion";
            this.btn_GestionarProduccion.Size = new System.Drawing.Size(314, 23);
            this.btn_GestionarProduccion.TabIndex = 17;
            this.btn_GestionarProduccion.Text = "Gestionar Producción";
            this.btn_GestionarProduccion.UseVisualStyleBackColor = true;
            this.btn_GestionarProduccion.Click += new System.EventHandler(this.btn_GestionarProduccion_Click);
            // 
            // linklbl_Ayuda
            // 
            this.linklbl_Ayuda.AutoSize = true;
            this.linklbl_Ayuda.Location = new System.Drawing.Point(12, 213);
            this.linklbl_Ayuda.Name = "linklbl_Ayuda";
            this.linklbl_Ayuda.Size = new System.Drawing.Size(102, 17);
            this.linklbl_Ayuda.TabIndex = 18;
            this.linklbl_Ayuda.TabStop = true;
            this.linklbl_Ayuda.Text = "Ayuda en línea";
            this.linklbl_Ayuda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_Ayuda_LinkClicked);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 244);
            this.Controls.Add(this.linklbl_Ayuda);
            this.Controls.Add(this.btn_GestionarProduccion);
            this.Controls.Add(this.cmb_Idioma);
            this.Controls.Add(this.lbl_Idioma);
            this.Controls.Add(this.btn_AreaConfeccion);
            this.Controls.Add(this.btn_AreaCortado);
            this.Controls.Add(this.btn_AreaTeñido);
            this.Controls.Add(this.btn_GestionarRoles);
            this.Controls.Add(this.btn_GestionarUsuarios);
            this.Controls.Add(this.btn_AreaTejido);
            this.Controls.Add(this.gbox_InfoUsuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbox_InfoUsuario.ResumeLayout(false);
            this.gbox_InfoUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbl_NombreUsuario;
        private System.Windows.Forms.Label lbl_NombreUsuario2;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_NombreYApellido;
        private System.Windows.Forms.Label lbl_Cargo;
        private System.Windows.Forms.Label lbl_Rol;
        private System.Windows.Forms.GroupBox gbox_InfoUsuario;
        private System.Windows.Forms.Button btn_AreaTejido;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.Button btn_GestionarUsuarios;
        private System.Windows.Forms.Button btn_GestionarRoles;
        private System.Windows.Forms.Button btn_AreaTeñido;
        private System.Windows.Forms.Button btn_AreaCortado;
        private System.Windows.Forms.Button btn_AreaConfeccion;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogBackup;
        private System.Windows.Forms.OpenFileDialog openFileDialogRestore;
        private System.Windows.Forms.ComboBox cmb_Idioma;
        private System.Windows.Forms.Label lbl_Idioma;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.Button btn_GestionarProduccion;
        private System.Windows.Forms.LinkLabel linklbl_Ayuda;
    }
}