namespace GUI
{
    partial class LogInMenu
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
            this.lbl_NombreUsuario = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.txt_NombreUsuario = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.btn_IniciarSesion = new System.Windows.Forms.Button();
            this.gbox_LogIn = new System.Windows.Forms.GroupBox();
            this.lbl_Idioma = new System.Windows.Forms.Label();
            this.cmb_Idioma = new System.Windows.Forms.ComboBox();
            this.gbox_LogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_NombreUsuario
            // 
            this.lbl_NombreUsuario.AutoSize = true;
            this.lbl_NombreUsuario.Location = new System.Drawing.Point(6, 27);
            this.lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            this.lbl_NombreUsuario.Size = new System.Drawing.Size(131, 17);
            this.lbl_NombreUsuario.TabIndex = 0;
            this.lbl_NombreUsuario.Text = "Nombre de Usuario";
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Location = new System.Drawing.Point(6, 72);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(81, 17);
            this.lbl_Contraseña.TabIndex = 1;
            this.lbl_Contraseña.Text = "Contraseña";
            // 
            // txt_NombreUsuario
            // 
            this.txt_NombreUsuario.Location = new System.Drawing.Point(9, 47);
            this.txt_NombreUsuario.Name = "txt_NombreUsuario";
            this.txt_NombreUsuario.Size = new System.Drawing.Size(206, 22);
            this.txt_NombreUsuario.TabIndex = 2;
            this.txt_NombreUsuario.Text = "Pato";
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(9, 92);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(206, 22);
            this.txt_Contraseña.TabIndex = 3;
            this.txt_Contraseña.Text = "xAgunimon";
            // 
            // btn_IniciarSesion
            // 
            this.btn_IniciarSesion.Location = new System.Drawing.Point(9, 121);
            this.btn_IniciarSesion.Name = "btn_IniciarSesion";
            this.btn_IniciarSesion.Size = new System.Drawing.Size(206, 23);
            this.btn_IniciarSesion.TabIndex = 4;
            this.btn_IniciarSesion.Text = "Iniciar Sesión";
            this.btn_IniciarSesion.UseVisualStyleBackColor = true;
            this.btn_IniciarSesion.Click += new System.EventHandler(this.btn_IniciarSesion_Click);
            // 
            // gbox_LogIn
            // 
            this.gbox_LogIn.Controls.Add(this.btn_IniciarSesion);
            this.gbox_LogIn.Controls.Add(this.txt_Contraseña);
            this.gbox_LogIn.Controls.Add(this.txt_NombreUsuario);
            this.gbox_LogIn.Controls.Add(this.lbl_Contraseña);
            this.gbox_LogIn.Controls.Add(this.lbl_NombreUsuario);
            this.gbox_LogIn.Location = new System.Drawing.Point(43, 12);
            this.gbox_LogIn.Name = "gbox_LogIn";
            this.gbox_LogIn.Size = new System.Drawing.Size(221, 153);
            this.gbox_LogIn.TabIndex = 5;
            this.gbox_LogIn.TabStop = false;
            this.gbox_LogIn.Text = "Iniciar Sesión";
            // 
            // lbl_Idioma
            // 
            this.lbl_Idioma.AutoSize = true;
            this.lbl_Idioma.Location = new System.Drawing.Point(40, 308);
            this.lbl_Idioma.Name = "lbl_Idioma";
            this.lbl_Idioma.Size = new System.Drawing.Size(57, 17);
            this.lbl_Idioma.TabIndex = 6;
            this.lbl_Idioma.Text = "Idioma :";
            // 
            // cmb_Idioma
            // 
            this.cmb_Idioma.FormattingEnabled = true;
            this.cmb_Idioma.Location = new System.Drawing.Point(131, 305);
            this.cmb_Idioma.Name = "cmb_Idioma";
            this.cmb_Idioma.Size = new System.Drawing.Size(152, 24);
            this.cmb_Idioma.TabIndex = 7;
            this.cmb_Idioma.TextChanged += new System.EventHandler(this.cmb_Idioma_TextChanged);
            // 
            // LogInMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 190);
            this.Controls.Add(this.cmb_Idioma);
            this.Controls.Add(this.lbl_Idioma);
            this.Controls.Add(this.gbox_LogIn);
            this.Name = "LogInMenu";
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.LogInMenu_Load);
            this.gbox_LogIn.ResumeLayout(false);
            this.gbox_LogIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NombreUsuario;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.TextBox txt_NombreUsuario;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Button btn_IniciarSesion;
        private System.Windows.Forms.GroupBox gbox_LogIn;
        private System.Windows.Forms.Label lbl_Idioma;
        private System.Windows.Forms.ComboBox cmb_Idioma;
    }
}

