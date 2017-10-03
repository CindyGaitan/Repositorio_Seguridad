using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PrototipoSeguridad
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios us = new Usuarios();
            us.Show();
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfiles per = new Perfiles();
            per.Show(); 
        }

        private void asignacionPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerfilUsuario perU = new PerfilUsuario();
            perU.Show();
        }

        private void bitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitacora bt = new Bitacora();
            bt.Show();
        }

        private void aplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aplicaciones2 ap = new Aplicaciones2();
            ap.Show();
        }

        private void cambioContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambioContraseña camb = new CambioContraseña();
            camb.Show();
        }

        private void asignacionAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoApp maplicaciones = new Frm_MantenimientoApp();
            maplicaciones.Show();
        }

        private void asignaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignacionaPerfiles ap = new AsignacionaPerfiles();
            ap.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection formulariosApp = Application.OpenForms;
            foreach (Form f in formulariosApp)
            {
                if (f.Name != "frmLogin")
                {
                    f.Hide();
                }
            }
            Login login = new Login();
            login.Show();
        }
    }
}
