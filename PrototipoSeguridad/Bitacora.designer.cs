namespace PrototipoSeguridad
{
    partial class Bitacora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Gpb_acciones = new System.Windows.Forms.GroupBox();
            this.Gpb_datos = new System.Windows.Forms.GroupBox();
            this.Dgv_bitacora = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Objetoafectado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.Gpb_acciones.SuspendLayout();
            this.Gpb_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_bitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_acciones
            // 
            this.Gpb_acciones.Controls.Add(this.button1);
            this.Gpb_acciones.Location = new System.Drawing.Point(56, 29);
            this.Gpb_acciones.Margin = new System.Windows.Forms.Padding(2);
            this.Gpb_acciones.Name = "Gpb_acciones";
            this.Gpb_acciones.Padding = new System.Windows.Forms.Padding(2);
            this.Gpb_acciones.Size = new System.Drawing.Size(727, 102);
            this.Gpb_acciones.TabIndex = 0;
            this.Gpb_acciones.TabStop = false;
            this.Gpb_acciones.Text = "Acciones";
            // 
            // Gpb_datos
            // 
            this.Gpb_datos.Controls.Add(this.Dgv_bitacora);
            this.Gpb_datos.Location = new System.Drawing.Point(56, 176);
            this.Gpb_datos.Margin = new System.Windows.Forms.Padding(2);
            this.Gpb_datos.Name = "Gpb_datos";
            this.Gpb_datos.Padding = new System.Windows.Forms.Padding(2);
            this.Gpb_datos.Size = new System.Drawing.Size(727, 221);
            this.Gpb_datos.TabIndex = 1;
            this.Gpb_datos.TabStop = false;
            this.Gpb_datos.Text = "Datos";
            // 
            // Dgv_bitacora
            // 
            this.Dgv_bitacora.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.Dgv_bitacora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_bitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Hora,
            this.Usuario,
            this.Accion,
            this.Objetoafectado,
            this.Resultado});
            this.Dgv_bitacora.Location = new System.Drawing.Point(44, 31);
            this.Dgv_bitacora.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_bitacora.Name = "Dgv_bitacora";
            this.Dgv_bitacora.RowTemplate.Height = 24;
            this.Dgv_bitacora.Size = new System.Drawing.Size(639, 167);
            this.Dgv_bitacora.TabIndex = 0;
            // 
            // Fecha
            // 
            this.Fecha.Frozen = true;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.Frozen = true;
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.Frozen = true;
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Accion
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Accion.DefaultCellStyle = dataGridViewCellStyle2;
            this.Accion.Frozen = true;
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            // 
            // Objetoafectado
            // 
            this.Objetoafectado.Frozen = true;
            this.Objetoafectado.HeaderText = "Objeto Afectado";
            this.Objetoafectado.Name = "Objetoafectado";
            this.Objetoafectado.ReadOnly = true;
            // 
            // Resultado
            // 
            this.Resultado.Frozen = true;
            this.Resultado.HeaderText = "Resultado";
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Image = global::PrototipoSeguridad.Properties.Resources.Actualizar;
            this.button1.Location = new System.Drawing.Point(331, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Actualizar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(852, 432);
            this.Controls.Add(this.Gpb_datos);
            this.Controls.Add(this.Gpb_acciones);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bitacora";
            this.Text = "Bitacora";
            this.Gpb_acciones.ResumeLayout(false);
            this.Gpb_datos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_bitacora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_acciones;
        private System.Windows.Forms.GroupBox Gpb_datos;
        private System.Windows.Forms.DataGridView Dgv_bitacora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Objetoafectado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
        private System.Windows.Forms.Button button1;
    }
}

