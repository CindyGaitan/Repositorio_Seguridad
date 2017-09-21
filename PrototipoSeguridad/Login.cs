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
    public partial class Login : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataAdapter da;
        DataTable dt;
        MySqlDataReader dr;

        public Login()
        {
            InitializeComponent();
            try
            {
                con = new MySqlConnection("server = localhost; user id = root; password=1234; database = BD_seguridad");
                con.Open();
                MessageBox.Show("conectado");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No conectado");
            }
        }

       
        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            try
            {
                string id_usuario;
                int id = 0;
                com = new MySqlCommand("select id_usuario from usuario where nombre_usuario='" + txt_usuario.Text + "' and contrasena='"+ txt_contraseña.Text +"' ", con);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_usuario = dr["id_usuario"].ToString();
                    id = Convert.ToInt32(id_usuario);
                }
                dr.Close();

                if (id != 0)
                {
                    Principal prin = new Principal();
                    prin.Show();
                    this.Hide();
                }
                else
                {
                    txt_usuario.Text = "";
                    txt_contraseña.Text = "";
                    MessageBox.Show("Usuario y/o Contraseña incorrecta.");
                }

            }
            catch (Exception ex)
            {
                txt_usuario.Text = "";
                txt_contraseña.Text = "";
                MessageBox.Show("Usuario y/o Contraseña incorrecta.");
            }
        }
    }
}
