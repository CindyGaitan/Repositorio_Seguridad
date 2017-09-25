namespace PrototipoSeguridad
{
    partial class CambioContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambioContraseña));
            this.gpb_acciones_Usuario = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.gpb_cambio = new System.Windows.Forms.GroupBox();
            this.txt_contraseñaN = new System.Windows.Forms.TextBox();
            this.txt_contraseñaA = new System.Windows.Forms.TextBox();
            this.cmb_usuario = new System.Windows.Forms.ComboBox();
            this.lbl_contraseñaN = new System.Windows.Forms.Label();
            this.lbl_contraseñaA = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.gpb_acciones_Usuario.SuspendLayout();
            this.gpb_cambio.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_acciones_Usuario
            // 
            this.gpb_acciones_Usuario.Controls.Add(this.btn_guardar);
            this.gpb_acciones_Usuario.Location = new System.Drawing.Point(439, 74);
            this.gpb_acciones_Usuario.Name = "gpb_acciones_Usuario";
            this.gpb_acciones_Usuario.Size = new System.Drawing.Size(235, 158);
            this.gpb_acciones_Usuario.TabIndex = 9;
            this.gpb_acciones_Usuario.TabStop = false;
            this.gpb_acciones_Usuario.Text = "ACCIONES";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(75, 53);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(89, 49);
            this.btn_guardar.TabIndex = 2;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // gpb_cambio
            // 
            this.gpb_cambio.Controls.Add(this.txt_contraseñaN);
            this.gpb_cambio.Controls.Add(this.txt_contraseñaA);
            this.gpb_cambio.Controls.Add(this.cmb_usuario);
            this.gpb_cambio.Controls.Add(this.lbl_contraseñaN);
            this.gpb_cambio.Controls.Add(this.lbl_contraseñaA);
            this.gpb_cambio.Controls.Add(this.lbl_usuario);
            this.gpb_cambio.Location = new System.Drawing.Point(42, 74);
            this.gpb_cambio.Name = "gpb_cambio";
            this.gpb_cambio.Size = new System.Drawing.Size(391, 158);
            this.gpb_cambio.TabIndex = 10;
            this.gpb_cambio.TabStop = false;
            this.gpb_cambio.Text = "DATOS";
            // 
            // txt_contraseñaN
            // 
            this.txt_contraseñaN.Location = new System.Drawing.Point(150, 95);
            this.txt_contraseñaN.Name = "txt_contraseñaN";
            this.txt_contraseñaN.PasswordChar = '*';
            this.txt_contraseñaN.Size = new System.Drawing.Size(158, 20);
            this.txt_contraseñaN.TabIndex = 6;
            // 
            // txt_contraseñaA
            // 
            this.txt_contraseñaA.Location = new System.Drawing.Point(150, 68);
            this.txt_contraseñaA.Name = "txt_contraseñaA";
            this.txt_contraseñaA.PasswordChar = '*';
            this.txt_contraseñaA.Size = new System.Drawing.Size(158, 20);
            this.txt_contraseñaA.TabIndex = 5;
            // 
            // cmb_usuario
            // 
            this.cmb_usuario.FormattingEnabled = true;
            this.cmb_usuario.Location = new System.Drawing.Point(150, 41);
            this.cmb_usuario.Name = "cmb_usuario";
            this.cmb_usuario.Size = new System.Drawing.Size(158, 21);
            this.cmb_usuario.TabIndex = 4;
            // 
            // lbl_contraseñaN
            // 
            this.lbl_contraseñaN.AutoSize = true;
            this.lbl_contraseñaN.Location = new System.Drawing.Point(45, 95);
            this.lbl_contraseñaN.Name = "lbl_contraseñaN";
            this.lbl_contraseñaN.Size = new System.Drawing.Size(96, 13);
            this.lbl_contraseñaN.TabIndex = 2;
            this.lbl_contraseñaN.Text = "Nueva Contraseña";
            // 
            // lbl_contraseñaA
            // 
            this.lbl_contraseñaA.AutoSize = true;
            this.lbl_contraseñaA.Location = new System.Drawing.Point(45, 68);
            this.lbl_contraseñaA.Name = "lbl_contraseñaA";
            this.lbl_contraseñaA.Size = new System.Drawing.Size(94, 13);
            this.lbl_contraseñaA.TabIndex = 1;
            this.lbl_contraseñaA.Text = "Contraseña Actual";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(45, 41);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Usuario";
            // 
            // CambioContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 319);
            this.Controls.Add(this.gpb_cambio);
            this.Controls.Add(this.gpb_acciones_Usuario);
            this.Name = "CambioContraseña";
            this.Text = "CambioContraseña";
            this.gpb_acciones_Usuario.ResumeLayout(false);
            this.gpb_cambio.ResumeLayout(false);
            this.gpb_cambio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_acciones_Usuario;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox gpb_cambio;
        private System.Windows.Forms.TextBox txt_contraseñaN;
        private System.Windows.Forms.TextBox txt_contraseñaA;
        private System.Windows.Forms.ComboBox cmb_usuario;
        private System.Windows.Forms.Label lbl_contraseñaN;
        private System.Windows.Forms.Label lbl_contraseñaA;
        private System.Windows.Forms.Label lbl_usuario;
    }
}