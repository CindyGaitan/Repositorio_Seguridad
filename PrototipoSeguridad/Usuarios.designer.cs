namespace PrototipoSeguridad
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.dgv_usuario = new System.Windows.Forms.DataGridView();
            this.gpb_usuario = new System.Windows.Forms.GroupBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.cmb_perfil = new System.Windows.Forms.ComboBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.lbl_perfil = new System.Windows.Forms.Label();
            this.txt_pApellido = new System.Windows.Forms.TextBox();
            this.txt_pNombre = new System.Windows.Forms.TextBox();
            this.lbl_pApellido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_pNombre = new System.Windows.Forms.Label();
            this.gpb_acciones_Usuario = new System.Windows.Forms.GroupBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).BeginInit();
            this.gpb_usuario.SuspendLayout();
            this.gpb_acciones_Usuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_usuario
            // 
            this.dgv_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuario.Location = new System.Drawing.Point(25, 243);
            this.dgv_usuario.Name = "dgv_usuario";
            this.dgv_usuario.Size = new System.Drawing.Size(585, 195);
            this.dgv_usuario.TabIndex = 6;
            this.dgv_usuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuario_CellContentClick);
            // 
            // gpb_usuario
            // 
            this.gpb_usuario.Controls.Add(this.txt_telefono);
            this.gpb_usuario.Controls.Add(this.txt_correo);
            this.gpb_usuario.Controls.Add(this.txt_contraseña);
            this.gpb_usuario.Controls.Add(this.cmb_perfil);
            this.gpb_usuario.Controls.Add(this.lbl_telefono);
            this.gpb_usuario.Controls.Add(this.lbl_correo);
            this.gpb_usuario.Controls.Add(this.lbl_contraseña);
            this.gpb_usuario.Controls.Add(this.lbl_perfil);
            this.gpb_usuario.Controls.Add(this.txt_pApellido);
            this.gpb_usuario.Controls.Add(this.txt_pNombre);
            this.gpb_usuario.Controls.Add(this.lbl_pApellido);
            this.gpb_usuario.Controls.Add(this.label3);
            this.gpb_usuario.Controls.Add(this.lbl_pNombre);
            this.gpb_usuario.Location = new System.Drawing.Point(25, 21);
            this.gpb_usuario.Name = "gpb_usuario";
            this.gpb_usuario.Size = new System.Drawing.Size(344, 204);
            this.gpb_usuario.TabIndex = 7;
            this.gpb_usuario.TabStop = false;
            this.gpb_usuario.Text = "DATOS USUARIO";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(147, 160);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(121, 20);
            this.txt_telefono.TabIndex = 31;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(147, 134);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(121, 20);
            this.txt_correo.TabIndex = 30;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(147, 108);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.txt_contraseña.Size = new System.Drawing.Size(121, 20);
            this.txt_contraseña.TabIndex = 29;
            // 
            // cmb_perfil
            // 
            this.cmb_perfil.FormattingEnabled = true;
            this.cmb_perfil.Location = new System.Drawing.Point(147, 81);
            this.cmb_perfil.Name = "cmb_perfil";
            this.cmb_perfil.Size = new System.Drawing.Size(121, 21);
            this.cmb_perfil.TabIndex = 28;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(60, 160);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefono.TabIndex = 27;
            this.lbl_telefono.Text = "Telefono";
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Location = new System.Drawing.Point(60, 134);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(38, 13);
            this.lbl_correo.TabIndex = 26;
            this.lbl_correo.Text = "Correo";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Location = new System.Drawing.Point(60, 108);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(55, 13);
            this.lbl_contraseña.TabIndex = 25;
            this.lbl_contraseña.Text = "Contrseña";
            // 
            // lbl_perfil
            // 
            this.lbl_perfil.AutoSize = true;
            this.lbl_perfil.Location = new System.Drawing.Point(60, 81);
            this.lbl_perfil.Name = "lbl_perfil";
            this.lbl_perfil.Size = new System.Drawing.Size(30, 13);
            this.lbl_perfil.TabIndex = 24;
            this.lbl_perfil.Text = "Perfil";
            // 
            // txt_pApellido
            // 
            this.txt_pApellido.Location = new System.Drawing.Point(147, 55);
            this.txt_pApellido.Name = "txt_pApellido";
            this.txt_pApellido.Size = new System.Drawing.Size(121, 20);
            this.txt_pApellido.TabIndex = 23;
            // 
            // txt_pNombre
            // 
            this.txt_pNombre.Location = new System.Drawing.Point(147, 29);
            this.txt_pNombre.Name = "txt_pNombre";
            this.txt_pNombre.Size = new System.Drawing.Size(121, 20);
            this.txt_pNombre.TabIndex = 22;
            // 
            // lbl_pApellido
            // 
            this.lbl_pApellido.AutoSize = true;
            this.lbl_pApellido.Location = new System.Drawing.Point(60, 55);
            this.lbl_pApellido.Name = "lbl_pApellido";
            this.lbl_pApellido.Size = new System.Drawing.Size(76, 13);
            this.lbl_pApellido.TabIndex = 21;
            this.lbl_pApellido.Text = "Primer Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 20;
            // 
            // lbl_pNombre
            // 
            this.lbl_pNombre.AutoSize = true;
            this.lbl_pNombre.Location = new System.Drawing.Point(60, 32);
            this.lbl_pNombre.Name = "lbl_pNombre";
            this.lbl_pNombre.Size = new System.Drawing.Size(76, 13);
            this.lbl_pNombre.TabIndex = 19;
            this.lbl_pNombre.Text = "Primer Nombre";
            // 
            // gpb_acciones_Usuario
            // 
            this.gpb_acciones_Usuario.Controls.Add(this.btn_modificar);
            this.gpb_acciones_Usuario.Controls.Add(this.btn_guardar);
            this.gpb_acciones_Usuario.Controls.Add(this.btn_eliminar);
            this.gpb_acciones_Usuario.Location = new System.Drawing.Point(375, 21);
            this.gpb_acciones_Usuario.Name = "gpb_acciones_Usuario";
            this.gpb_acciones_Usuario.Size = new System.Drawing.Size(235, 204);
            this.gpb_acciones_Usuario.TabIndex = 8;
            this.gpb_acciones_Usuario.TabStop = false;
            this.gpb_acciones_Usuario.Text = "ACCIONES";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificar.Image")));
            this.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificar.Location = new System.Drawing.Point(82, 79);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(89, 49);
            this.btn_modificar.TabIndex = 3;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(82, 24);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(89, 49);
            this.btn_guardar.TabIndex = 2;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(82, 134);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(89, 49);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.button4_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(643, 486);
            this.Controls.Add(this.gpb_acciones_Usuario);
            this.Controls.Add(this.gpb_usuario);
            this.Controls.Add(this.dgv_usuario);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).EndInit();
            this.gpb_usuario.ResumeLayout(false);
            this.gpb_usuario.PerformLayout();
            this.gpb_acciones_Usuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.DataGridView dgv_usuario;
        private System.Windows.Forms.GroupBox gpb_usuario;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.ComboBox cmb_perfil;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.Label lbl_perfil;
        private System.Windows.Forms.TextBox txt_pApellido;
        private System.Windows.Forms.TextBox txt_pNombre;
        private System.Windows.Forms.Label lbl_pApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_pNombre;
        private System.Windows.Forms.GroupBox gpb_acciones_Usuario;
    }
}

