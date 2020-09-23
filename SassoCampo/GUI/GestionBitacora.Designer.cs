namespace GUI
{
    partial class GestionBitacora
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
            this.txt_BuscarNombreUsuario = new System.Windows.Forms.TextBox();
            this.lbl_BuscarPorNombreUsuario = new System.Windows.Forms.Label();
            this.lbl_BuscarPorFecha = new System.Windows.Forms.Label();
            this.txt_BuscarFecha = new System.Windows.Forms.TextBox();
            this.lbx_Bitacora = new System.Windows.Forms.ListBox();
            this.btn_MenuPrincipal = new System.Windows.Forms.Button();
            this.lbl_Formato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_BuscarNombreUsuario
            // 
            this.txt_BuscarNombreUsuario.Location = new System.Drawing.Point(218, 15);
            this.txt_BuscarNombreUsuario.Name = "txt_BuscarNombreUsuario";
            this.txt_BuscarNombreUsuario.Size = new System.Drawing.Size(364, 22);
            this.txt_BuscarNombreUsuario.TabIndex = 0;
            this.txt_BuscarNombreUsuario.TextChanged += new System.EventHandler(this.txt_BuscarNombreUsuario_TextChanged);
            // 
            // lbl_BuscarPorNombreUsuario
            // 
            this.lbl_BuscarPorNombreUsuario.AutoSize = true;
            this.lbl_BuscarPorNombreUsuario.Location = new System.Drawing.Point(12, 15);
            this.lbl_BuscarPorNombreUsuario.Name = "lbl_BuscarPorNombreUsuario";
            this.lbl_BuscarPorNombreUsuario.Size = new System.Drawing.Size(200, 17);
            this.lbl_BuscarPorNombreUsuario.TabIndex = 1;
            this.lbl_BuscarPorNombreUsuario.Text = "Buscar por nombre de usuario";
            // 
            // lbl_BuscarPorFecha
            // 
            this.lbl_BuscarPorFecha.AutoSize = true;
            this.lbl_BuscarPorFecha.Location = new System.Drawing.Point(12, 43);
            this.lbl_BuscarPorFecha.Name = "lbl_BuscarPorFecha";
            this.lbl_BuscarPorFecha.Size = new System.Drawing.Size(116, 17);
            this.lbl_BuscarPorFecha.TabIndex = 3;
            this.lbl_BuscarPorFecha.Text = "Buscar por fecha";
            // 
            // txt_BuscarFecha
            // 
            this.txt_BuscarFecha.Location = new System.Drawing.Point(134, 40);
            this.txt_BuscarFecha.Name = "txt_BuscarFecha";
            this.txt_BuscarFecha.Size = new System.Drawing.Size(448, 22);
            this.txt_BuscarFecha.TabIndex = 2;
            this.txt_BuscarFecha.TextChanged += new System.EventHandler(this.txt_BuscarFecha_TextChanged);
            // 
            // lbx_Bitacora
            // 
            this.lbx_Bitacora.FormattingEnabled = true;
            this.lbx_Bitacora.ItemHeight = 16;
            this.lbx_Bitacora.Location = new System.Drawing.Point(15, 68);
            this.lbx_Bitacora.Name = "lbx_Bitacora";
            this.lbx_Bitacora.Size = new System.Drawing.Size(790, 340);
            this.lbx_Bitacora.TabIndex = 4;
            // 
            // btn_MenuPrincipal
            // 
            this.btn_MenuPrincipal.Location = new System.Drawing.Point(15, 414);
            this.btn_MenuPrincipal.Name = "btn_MenuPrincipal";
            this.btn_MenuPrincipal.Size = new System.Drawing.Size(789, 23);
            this.btn_MenuPrincipal.TabIndex = 5;
            this.btn_MenuPrincipal.Text = "Volver al menu principal";
            this.btn_MenuPrincipal.UseVisualStyleBackColor = true;
            this.btn_MenuPrincipal.Click += new System.EventHandler(this.btn_MenuPrincipal_Click);
            // 
            // lbl_Formato
            // 
            this.lbl_Formato.AutoSize = true;
            this.lbl_Formato.Location = new System.Drawing.Point(588, 43);
            this.lbl_Formato.Name = "lbl_Formato";
            this.lbl_Formato.Size = new System.Drawing.Size(216, 17);
            this.lbl_Formato.TabIndex = 6;
            this.lbl_Formato.Text = "Formato :  yyyy-mm-dd hh:mm:ss";
            // 
            // GestionBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.lbl_Formato);
            this.Controls.Add(this.btn_MenuPrincipal);
            this.Controls.Add(this.lbx_Bitacora);
            this.Controls.Add(this.lbl_BuscarPorFecha);
            this.Controls.Add(this.txt_BuscarFecha);
            this.Controls.Add(this.lbl_BuscarPorNombreUsuario);
            this.Controls.Add(this.txt_BuscarNombreUsuario);
            this.Name = "GestionBitacora";
            this.Text = "Gestion de Bitácora";
            this.Load += new System.EventHandler(this.GestionBitacora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_BuscarNombreUsuario;
        private System.Windows.Forms.Label lbl_BuscarPorNombreUsuario;
        private System.Windows.Forms.Label lbl_BuscarPorFecha;
        private System.Windows.Forms.TextBox txt_BuscarFecha;
        private System.Windows.Forms.ListBox lbx_Bitacora;
        private System.Windows.Forms.Button btn_MenuPrincipal;
        private System.Windows.Forms.Label lbl_Formato;
    }
}