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
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darPermisoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarPermisoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_NombreUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_NombreYApellido = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.gbox_InfoUsuario = new System.Windows.Forms.GroupBox();
            this.btn_IrAreaTejido = new System.Windows.Forms.Button();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.gbox_InfoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.rolToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Gestion";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarUsuarioToolStripMenuItem,
            this.modificarUsuarioToolStripMenuItem,
            this.darDeBajaUsuarioToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // registrarUsuarioToolStripMenuItem
            // 
            this.registrarUsuarioToolStripMenuItem.Name = "registrarUsuarioToolStripMenuItem";
            this.registrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registrarUsuarioToolStripMenuItem.Text = "Dar de Alta Usuario";
            this.registrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registrarUsuarioToolStripMenuItem_Click);
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modificarUsuarioToolStripMenuItem.Text = "Modificar Usuario";
            this.modificarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuarioToolStripMenuItem_Click);
            // 
            // darDeBajaUsuarioToolStripMenuItem
            // 
            this.darDeBajaUsuarioToolStripMenuItem.Name = "darDeBajaUsuarioToolStripMenuItem";
            this.darDeBajaUsuarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.darDeBajaUsuarioToolStripMenuItem.Text = "Dar de Baja Usuario";
            this.darDeBajaUsuarioToolStripMenuItem.Click += new System.EventHandler(this.darDeBajaUsuarioToolStripMenuItem_Click);
            // 
            // rolToolStripMenuItem
            // 
            this.rolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darPermisoToolStripMenuItem,
            this.quitarPermisoToolStripMenuItem});
            this.rolToolStripMenuItem.Name = "rolToolStripMenuItem";
            this.rolToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.rolToolStripMenuItem.Text = "Rol";
            // 
            // darPermisoToolStripMenuItem
            // 
            this.darPermisoToolStripMenuItem.Name = "darPermisoToolStripMenuItem";
            this.darPermisoToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.darPermisoToolStripMenuItem.Text = "Dar Permiso";
            this.darPermisoToolStripMenuItem.Click += new System.EventHandler(this.darPermisoToolStripMenuItem_Click);
            // 
            // quitarPermisoToolStripMenuItem
            // 
            this.quitarPermisoToolStripMenuItem.Name = "quitarPermisoToolStripMenuItem";
            this.quitarPermisoToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.quitarPermisoToolStripMenuItem.Text = "Quitar Permiso";
            this.quitarPermisoToolStripMenuItem.Click += new System.EventHandler(this.quitarPermisoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario: ";
            // 
            // lbl_NombreUsuario
            // 
            this.lbl_NombreUsuario.AutoSize = true;
            this.lbl_NombreUsuario.Location = new System.Drawing.Point(70, 18);
            this.lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            this.lbl_NombreUsuario.Size = new System.Drawing.Size(129, 17);
            this.lbl_NombreUsuario.TabIndex = 3;
            this.lbl_NombreUsuario.Text = "lbl_NombreUsuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre: ";
            // 
            // lbl_NombreYApellido
            // 
            this.lbl_NombreYApellido.AutoSize = true;
            this.lbl_NombreYApellido.Location = new System.Drawing.Point(70, 35);
            this.lbl_NombreYApellido.Name = "lbl_NombreYApellido";
            this.lbl_NombreYApellido.Size = new System.Drawing.Size(139, 17);
            this.lbl_NombreYApellido.TabIndex = 5;
            this.lbl_NombreYApellido.Text = "lbl_NombreYApellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cargo: ";
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.Location = new System.Drawing.Point(70, 52);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(51, 17);
            this.lbl_Rol.TabIndex = 7;
            this.lbl_Rol.Text = "lbl_Rol";
            // 
            // gbox_InfoUsuario
            // 
            this.gbox_InfoUsuario.Controls.Add(this.label1);
            this.gbox_InfoUsuario.Controls.Add(this.lbl_Rol);
            this.gbox_InfoUsuario.Controls.Add(this.lbl_NombreUsuario);
            this.gbox_InfoUsuario.Controls.Add(this.label5);
            this.gbox_InfoUsuario.Controls.Add(this.label3);
            this.gbox_InfoUsuario.Controls.Add(this.lbl_NombreYApellido);
            this.gbox_InfoUsuario.Location = new System.Drawing.Point(12, 31);
            this.gbox_InfoUsuario.Name = "gbox_InfoUsuario";
            this.gbox_InfoUsuario.Size = new System.Drawing.Size(211, 80);
            this.gbox_InfoUsuario.TabIndex = 8;
            this.gbox_InfoUsuario.TabStop = false;
            this.gbox_InfoUsuario.Text = "Información de Usuario";
            // 
            // btn_IrAreaTejido
            // 
            this.btn_IrAreaTejido.Location = new System.Drawing.Point(12, 117);
            this.btn_IrAreaTejido.Name = "btn_IrAreaTejido";
            this.btn_IrAreaTejido.Size = new System.Drawing.Size(211, 23);
            this.btn_IrAreaTejido.TabIndex = 9;
            this.btn_IrAreaTejido.Text = "Ir al Área de Tejido";
            this.btn_IrAreaTejido.UseVisualStyleBackColor = true;
            this.btn_IrAreaTejido.Click += new System.EventHandler(this.btn_IrAreaTejido_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_IrAreaTejido);
            this.Controls.Add(this.gbox_InfoUsuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
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
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darPermisoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitarPermisoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_NombreUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_NombreYApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Rol;
        private System.Windows.Forms.GroupBox gbox_InfoUsuario;
        private System.Windows.Forms.Button btn_IrAreaTejido;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}