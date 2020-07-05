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
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_NombreUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_NombreYApellido = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.gbox_InfoUsuario = new System.Windows.Forms.GroupBox();
            this.btn_AreaTejido = new System.Windows.Forms.Button();
            this.btn_GestionarUsuarios = new System.Windows.Forms.Button();
            this.btn_GestionarRoles = new System.Windows.Forms.Button();
            this.btn_AreaTeñido = new System.Windows.Forms.Button();
            this.btn_AreaCortado = new System.Windows.Forms.Button();
            this.btn_AreaConfeccion = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbox_InfoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
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
            this.label5.Location = new System.Drawing.Point(17, 52);
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
            // btn_AreaTejido
            // 
            this.btn_AreaTejido.Location = new System.Drawing.Point(10, 117);
            this.btn_AreaTejido.Name = "btn_AreaTejido";
            this.btn_AreaTejido.Size = new System.Drawing.Size(211, 23);
            this.btn_AreaTejido.TabIndex = 9;
            this.btn_AreaTejido.Text = "Ir al Área de Tejido";
            this.btn_AreaTejido.UseVisualStyleBackColor = true;
            this.btn_AreaTejido.Click += new System.EventHandler(this.btn_IrAreaTejido_Click);
            // 
            // btn_GestionarUsuarios
            // 
            this.btn_GestionarUsuarios.Location = new System.Drawing.Point(229, 43);
            this.btn_GestionarUsuarios.Name = "btn_GestionarUsuarios";
            this.btn_GestionarUsuarios.Size = new System.Drawing.Size(209, 23);
            this.btn_GestionarUsuarios.TabIndex = 10;
            this.btn_GestionarUsuarios.Text = "Gestionar Usuarios";
            this.btn_GestionarUsuarios.UseVisualStyleBackColor = true;
            this.btn_GestionarUsuarios.Click += new System.EventHandler(this.btn_GestionarUsuarios_Click);
            // 
            // btn_GestionarRoles
            // 
            this.btn_GestionarRoles.Location = new System.Drawing.Point(229, 72);
            this.btn_GestionarRoles.Name = "btn_GestionarRoles";
            this.btn_GestionarRoles.Size = new System.Drawing.Size(209, 23);
            this.btn_GestionarRoles.TabIndex = 11;
            this.btn_GestionarRoles.Text = "Gestionar Roles";
            this.btn_GestionarRoles.UseVisualStyleBackColor = true;
            this.btn_GestionarRoles.Click += new System.EventHandler(this.btn_GestionarRoles_Click);
            // 
            // btn_AreaTeñido
            // 
            this.btn_AreaTeñido.Location = new System.Drawing.Point(12, 146);
            this.btn_AreaTeñido.Name = "btn_AreaTeñido";
            this.btn_AreaTeñido.Size = new System.Drawing.Size(211, 23);
            this.btn_AreaTeñido.TabIndex = 12;
            this.btn_AreaTeñido.Text = "Ir al Área de Teñido";
            this.btn_AreaTeñido.UseVisualStyleBackColor = true;
            this.btn_AreaTeñido.Click += new System.EventHandler(this.btn_AreaTeñido_Click);
            // 
            // btn_AreaCortado
            // 
            this.btn_AreaCortado.Location = new System.Drawing.Point(10, 175);
            this.btn_AreaCortado.Name = "btn_AreaCortado";
            this.btn_AreaCortado.Size = new System.Drawing.Size(211, 23);
            this.btn_AreaCortado.TabIndex = 13;
            this.btn_AreaCortado.Text = "Ir al Área de Cortado";
            this.btn_AreaCortado.UseVisualStyleBackColor = true;
            this.btn_AreaCortado.Click += new System.EventHandler(this.btn_AreaCortado_Click);
            // 
            // btn_AreaConfeccion
            // 
            this.btn_AreaConfeccion.Location = new System.Drawing.Point(12, 204);
            this.btn_AreaConfeccion.Name = "btn_AreaConfeccion";
            this.btn_AreaConfeccion.Size = new System.Drawing.Size(211, 23);
            this.btn_AreaConfeccion.TabIndex = 14;
            this.btn_AreaConfeccion.Text = "Ir al Área de Confección";
            this.btn_AreaConfeccion.UseVisualStyleBackColor = true;
            this.btn_AreaConfeccion.Click += new System.EventHandler(this.btn_AreaConfeccion_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_NombreUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_NombreYApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Rol;
        private System.Windows.Forms.GroupBox gbox_InfoUsuario;
        private System.Windows.Forms.Button btn_AreaTejido;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.Button btn_GestionarUsuarios;
        private System.Windows.Forms.Button btn_GestionarRoles;
        private System.Windows.Forms.Button btn_AreaTeñido;
        private System.Windows.Forms.Button btn_AreaCortado;
        private System.Windows.Forms.Button btn_AreaConfeccion;
    }
}