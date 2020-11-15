namespace GUI
{
    partial class GestionUsuarios
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
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Baja = new System.Windows.Forms.Button();
            this.lbl_NombreUsuario = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.txt_NombreUsuario = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.lbl_Cargo = new System.Windows.Forms.Label();
            this.cmb_Rol = new System.Windows.Forms.ComboBox();
            this.btn_MenuPrincipal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.AllowUserToAddRows = false;
            this.dgv_Usuarios.AllowUserToDeleteRows = false;
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuarios.Location = new System.Drawing.Point(208, 12);
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.ReadOnly = true;
            this.dgv_Usuarios.RowHeadersWidth = 51;
            this.dgv_Usuarios.RowTemplate.Height = 24;
            this.dgv_Usuarios.Size = new System.Drawing.Size(580, 231);
            this.dgv_Usuarios.TabIndex = 0;
            this.dgv_Usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Usuarios_CellClick);
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(12, 162);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(180, 23);
            this.btn_Alta.TabIndex = 1;
            this.btn_Alta.Text = "Alta";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_AltaUsuario_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(12, 191);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(180, 23);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_ModificarUsuario_Click);
            // 
            // btn_Baja
            // 
            this.btn_Baja.Location = new System.Drawing.Point(12, 220);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(180, 23);
            this.btn_Baja.TabIndex = 3;
            this.btn_Baja.Text = "Baja";
            this.btn_Baja.UseVisualStyleBackColor = true;
            this.btn_Baja.Click += new System.EventHandler(this.btn_BajaUsuario_Click);
            // 
            // lbl_NombreUsuario
            // 
            this.lbl_NombreUsuario.AutoSize = true;
            this.lbl_NombreUsuario.Location = new System.Drawing.Point(9, 18);
            this.lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            this.lbl_NombreUsuario.Size = new System.Drawing.Size(78, 34);
            this.lbl_NombreUsuario.TabIndex = 4;
            this.lbl_NombreUsuario.Text = "Nombre de\r\n Usuario :";
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Location = new System.Drawing.Point(9, 49);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(85, 17);
            this.lbl_Contraseña.TabIndex = 5;
            this.lbl_Contraseña.Text = "Contraseña:";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(28, 74);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(66, 17);
            this.lbl_Nombre.TabIndex = 6;
            this.lbl_Nombre.Text = "Nombre :";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(21, 105);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(66, 17);
            this.lbl_Apellido.TabIndex = 7;
            this.lbl_Apellido.Text = "Apellido :";
            // 
            // txt_NombreUsuario
            // 
            this.txt_NombreUsuario.Location = new System.Drawing.Point(102, 18);
            this.txt_NombreUsuario.Name = "txt_NombreUsuario";
            this.txt_NombreUsuario.Size = new System.Drawing.Size(100, 22);
            this.txt_NombreUsuario.TabIndex = 8;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(102, 46);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(100, 22);
            this.txt_Contraseña.TabIndex = 9;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(102, 74);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_Nombre.TabIndex = 10;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(102, 102);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 22);
            this.txt_Apellido.TabIndex = 11;
            // 
            // lbl_Cargo
            // 
            this.lbl_Cargo.AutoSize = true;
            this.lbl_Cargo.Location = new System.Drawing.Point(40, 135);
            this.lbl_Cargo.Name = "lbl_Cargo";
            this.lbl_Cargo.Size = new System.Drawing.Size(37, 17);
            this.lbl_Cargo.TabIndex = 13;
            this.lbl_Cargo.Text = "Rol :";
            // 
            // cmb_Rol
            // 
            this.cmb_Rol.FormattingEnabled = true;
            this.cmb_Rol.Location = new System.Drawing.Point(83, 132);
            this.cmb_Rol.Name = "cmb_Rol";
            this.cmb_Rol.Size = new System.Drawing.Size(121, 24);
            this.cmb_Rol.TabIndex = 14;
            // 
            // btn_MenuPrincipal
            // 
            this.btn_MenuPrincipal.Location = new System.Drawing.Point(12, 249);
            this.btn_MenuPrincipal.Name = "btn_MenuPrincipal";
            this.btn_MenuPrincipal.Size = new System.Drawing.Size(776, 23);
            this.btn_MenuPrincipal.TabIndex = 15;
            this.btn_MenuPrincipal.Text = "Volver al menu principal";
            this.btn_MenuPrincipal.UseVisualStyleBackColor = true;
            this.btn_MenuPrincipal.Click += new System.EventHandler(this.btn_VolverAlMenu_Click);
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 284);
            this.Controls.Add(this.btn_MenuPrincipal);
            this.Controls.Add(this.cmb_Rol);
            this.Controls.Add(this.lbl_Cargo);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_NombreUsuario);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Contraseña);
            this.Controls.Add(this.lbl_NombreUsuario);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.dgv_Usuarios);
            this.Name = "GestionUsuarios";
            this.Text = "Gestión de Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionUsuarios_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GestionUsuarios_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Usuarios;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Label lbl_NombreUsuario;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.TextBox txt_NombreUsuario;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Label lbl_Cargo;
        private System.Windows.Forms.ComboBox cmb_Rol;
        private System.Windows.Forms.Button btn_MenuPrincipal;
    }
}