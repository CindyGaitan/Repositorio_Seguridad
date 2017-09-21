using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PrototipoSeguridad
{
    public partial class Usuarios : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataAdapter da;
        DataTable dt;
        MySqlDataReader dr;

        public Usuarios()
        {

            InitializeComponent();
            try
            {
                con = new MySqlConnection("server = localhost; user id = root; password=1234; database = BD_seguridad");
                con.Open();
                MessageBox.Show("conectado");
                mostrar_usuario();
                llenado_cmb_perfil();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No conectado");
            }

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                string id_perfil;
                int id=0;
                com = new MySqlCommand("select id_perfil from perfil where nombre_perfil='"+ cmb_perfil.Text +"' ",con);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_perfil = dr["id_perfil"].ToString();
                    id = Convert.ToInt32(id_perfil);
                }
                dr.Close();

                com = new MySqlCommand("insert into usuario (nombre_usuario, apellido_usuario, id_perfil, contrasena, correo_usuario, telefono_usuario) values ('" + txt_pNombre.Text + "', '" + txt_pApellido.Text + "', " + id + ", '" + txt_contraseña.Text + "', '" + txt_correo.Text + "', " + Convert.ToInt32(txt_telefono.Text) + ")", con);
                com.ExecuteNonQuery();
                txt_contraseña.Text = "";
                txt_pNombre.Text = "";
                txt_pApellido.Text = "";
                txt_correo.Text = "";
                txt_telefono.Text = "";
                MessageBox.Show("Datos Ingresados");
                mostrar_usuario();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex);
            }
        }

        public void mostrar_usuario()
        {
            da = new MySqlDataAdapter("select *from usuario", con);
            dt = new DataTable();
            da.Fill(dt);
            dgv_usuario.DataSource = dt;           
        }

        public void llenado_cmb_perfil()
        {
            try
            {
                com = new MySqlCommand("select nombre_perfil from perfil", con);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cmb_perfil.Items.Add(dr["nombre_perfil"].ToString());
                }
                cmb_perfil.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

    }
}
