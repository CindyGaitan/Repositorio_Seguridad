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
    public partial class CambioContraseña : Form
    {
        MySqlConnection con;
        MySqlCommand com, com2;
        MySqlDataAdapter da;
        DataTable dt;
        MySqlDataReader dr,dr2;

        public CambioContraseña()
        {
            InitializeComponent();
            try
            {
                con = new MySqlConnection("server = localhost; user id = root; password=1234; database = BD_seguridad");
                con.Open();
                MessageBox.Show("conectado");
                llenado_cmb_usuario();
                mostrar_cambio();
                mostrar_usuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No conectado");
            }
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                string id_usuario;
                int id = 0;
                com = new MySqlCommand("select id_usuario from usuario where nombre_usuario='" + cmb_usuario.Text + "' ", con);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_usuario = dr["id_usuario"].ToString();
                    id = Convert.ToInt32(id_usuario);
                }
                dr.Close();

                string contraseña=null;
                com = new MySqlCommand("select contrasena from usuario where id_usuario ="+ id +" ", con);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    contraseña = dr["contrasena"].ToString();
                }
                dr.Close();

                if (txt_contraseñaA.Text == contraseña)
                {
                    com = new MySqlCommand("insert into cambio_contraseña (id_usuario, contraseña_actual, contraseña_nueva, fecha_cambio) values (" + id + ", '" + txt_contraseñaA.Text + "', '" + txt_contraseñaN.Text + "', @fecha_cambio)", con);
                    com.Parameters.AddWithValue("@fecha_cambio", dtp_fecha.Value);
                    com.ExecuteNonQuery();

                    com2 = new MySqlCommand("update usuario set contrasena = '"+ txt_contraseñaN.Text +"' where id_usuario = "+ id +"", con);
                    com2.ExecuteNonQuery();
                    MessageBox.Show("Datos Ingresados");
                }
                else
                {
                    MessageBox.Show("Contraseña no Corresponde");
                }
                mostrar_cambio();
                mostrar_usuarios();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            txt_contraseñaA.Text = "";
            txt_contraseñaN.Text = "";
        }
        public void llenado_cmb_usuario()
        {
            try
            {
                com = new MySqlCommand("select nombre_usuario from usuario", con);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cmb_usuario.Items.Add(dr["nombre_usuario"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        public void mostrar_cambio()
        {
            da = new MySqlDataAdapter("select *from cambio_contraseña", con);
            dt = new DataTable();
            da.Fill(dt);
            dgv_contraseña.DataSource = dt;
        }

        public void mostrar_usuarios()
        {
            da = new MySqlDataAdapter("select *from usuario", con);
            dt = new DataTable();
            da.Fill(dt);
            dgv_usuarios.DataSource = dt;
        }
    }
    }

