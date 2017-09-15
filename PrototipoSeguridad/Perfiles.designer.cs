namespace PrototipoSeguridad
{
    partial class Perfiles
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfiles));
            this.Gpb_datos = new System.Windows.Forms.GroupBox();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Gpb_accion = new System.Windows.Forms.GroupBox();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_listo = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.dgv_perfil = new System.Windows.Forms.DataGridView();
            this.Gpb_datos.SuspendLayout();
            this.Gpb_accion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_perfil)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_datos
            // 
            this.Gpb_datos.Controls.Add(this.Lbl_descripcion);
            this.Gpb_datos.Controls.Add(this.Txt_descripcion);
            this.Gpb_datos.Controls.Add(this.Txt_nombre);
            this.Gpb_datos.Controls.Add(this.Lbl_nombre);
            this.Gpb_datos.Location = new System.Drawing.Point(52, 45);
            this.Gpb_datos.Name = "Gpb_datos";
            this.Gpb_datos.Size = new System.Drawing.Size(294, 202);
            this.Gpb_datos.TabIndex = 0;
            this.Gpb_datos.TabStop = false;
            this.Gpb_datos.Text = "DATOS DEL PERFIL";
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.Location = new System.Drawing.Point(13, 77);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(63, 13);
            this.Lbl_descripcion.TabIndex = 5;
            this.Lbl_descripcion.Text = "Descripción";
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Location = new System.Drawing.Point(97, 74);
            this.Txt_descripcion.Multiline = true;
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.Size = new System.Drawing.Size(182, 78);
            this.Txt_descripcion.TabIndex = 4;
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(97, 39);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(182, 20);
            this.Txt_nombre.TabIndex = 3;
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Location = new System.Drawing.Point(13, 42);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(70, 13);
            this.Lbl_nombre.TabIndex = 1;
            this.Lbl_nombre.Text = "Nombre Perfil";
            // 
            // Gpb_accion
            // 
            this.Gpb_accion.Controls.Add(this.Btn_eliminar);
            this.Gpb_accion.Controls.Add(this.Btn_listo);
            this.Gpb_accion.Controls.Add(this.Btn_modificar);
            this.Gpb_accion.Controls.Add(this.Btn_agregar);
            this.Gpb_accion.Location = new System.Drawing.Point(352, 45);
            this.Gpb_accion.Name = "Gpb_accion";
            this.Gpb_accion.Size = new System.Drawing.Size(287, 202);
            this.Gpb_accion.TabIndex = 1;
            this.Gpb_accion.TabStop = false;
            this.Gpb_accion.Text = "ACCIONES";
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar.Image")));
            this.Btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_eliminar.Location = new System.Drawing.Point(11, 115);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(130, 65);
            this.Btn_eliminar.TabIndex = 3;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_listo
            // 
            this.Btn_listo.FlatAppearance.BorderSize = 0;
            this.Btn_listo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_listo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_listo.Image")));
            this.Btn_listo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_listo.Location = new System.Drawing.Point(147, 118);
            this.Btn_listo.Name = "Btn_listo";
            this.Btn_listo.Size = new System.Drawing.Size(130, 65);
            this.Btn_listo.TabIndex = 2;
            this.Btn_listo.Text = "Aceptar";
            this.Btn_listo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_listo.UseVisualStyleBackColor = true;
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.FlatAppearance.BorderSize = 0;
            this.Btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_modificar.Image")));
            this.Btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_modificar.Location = new System.Drawing.Point(147, 19);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(130, 65);
            this.Btn_modificar.TabIndex = 1;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_modificar.UseVisualStyleBackColor = true;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.FlatAppearance.BorderSize = 0;
            this.Btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_agregar.Image")));
            this.Btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_agregar.Location = new System.Drawing.Point(11, 19);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(130, 65);
            this.Btn_agregar.TabIndex = 0;
            this.Btn_agregar.Text = "Agregar";
            this.Btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_agregar.UseVisualStyleBackColor = true;
            this.Btn_agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_perfil
            // 
            this.dgv_perfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_perfil.Location = new System.Drawing.Point(52, 265);
            this.dgv_perfil.Name = "dgv_perfil";
            this.dgv_perfil.Size = new System.Drawing.Size(587, 161);
            this.dgv_perfil.TabIndex = 2;
            // 
            // Perfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 438);
            this.Controls.Add(this.dgv_perfil);
            this.Controls.Add(this.Gpb_accion);
            this.Controls.Add(this.Gpb_datos);
            this.Name = "Perfiles";
            this.Text = "PERFILES";
            this.Gpb_datos.ResumeLayout(false);
            this.Gpb_datos.PerformLayout();
            this.Gpb_accion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_perfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_datos;
        private System.Windows.Forms.Label Lbl_descripcion;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.GroupBox Gpb_accion;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_listo;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.DataGridView dgv_perfil;
    }
}

