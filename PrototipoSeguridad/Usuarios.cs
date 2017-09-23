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
            try
            {
                com = new MySqlCommand("insert into usuario (nombre_usuario, apellido_usuario, id_perfil, contrasena, correo_usuario, telefono_usuario) values ('" + txt_pNombre.Text + "', '" + txt_pApellido.Text + "', " + id + ", '" + txt_contraseña.Text + "', '" + txt_correo.Text + "', " + Convert.ToInt32(txt_telefono.Text) + ")", con);
                com.ExecuteNonQuery();
                txt_contraseña.Text = "";
                txt_pNombre.Text = "";
                txt_pApellido.Text = "";
                txt_correo.Text = "";
                mostrar_usuario();
                MessageBox.Show("Datos Ingresados");
            }



            catch (Exception ex)
            {
                MessageBox.Show("Datos NO Ingresados, verifique la información. ");
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string eliminar = "delete from perfil where nombre_perfil = " + txt_pNombre.Text + " ";
                com = new MySqlCommand(eliminar, con);
                com.ExecuteNonQuery();
                mostrar_usuario();
                txt_contraseña.Text = "";
                txt_pNombre.Text = "";
                txt_pApellido.Text = "";
                txt_correo.Text = "";

                MessageBox.Show("Registro eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar, dato no puede ser eliminado");
            }
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

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                string contraseña = null;
                com = new MySqlCommand("select id_perfil from perfil where nombre_perfil =" + id + " ", con);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    contraseña = dr["contrasena"].ToString();
                }
                dr.Close();

                com = new MySqlCommand("update usuario set nombre_usuario=" + txt_pNombre.Text + "', apellido_usuario=" + txt_pApellido.Text + ", id_perfil='" + cmb_perfil.Text + "' contrasena = " + txt_contraseña.Text + "correo_usuario =" + txt_correo + "telefono_usuario =" + txt_telefono);
                com.ExecuteNonQuery();
                mostrar_usuario();
                txt_pNombre.Text = "";
                txt_pApellido.Text = "";
                cmb_perfil.Text = "SELECCIONE OPCION";
                txt_contraseña.Text = "";
                txt_correo.Text = "";
                txt_telefono.Text = "";
                MessageBox.Show("Datos actualizados");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos no actualizados");
            }
        }

        private void dgv_usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgv_usuario.Rows[e.RowIndex];

                txt_pNombre.Text = dgv.Cells[1].Value.ToString();
                txt_pApellido.Text = dgv.Cells[2].Value.ToString();
                cmb_perfil.Text = dgv.Cells[3].Value.ToString();
                txt_contraseña.Text = dgv.Cells[4].Value.ToString();
                txt_correo.Text = dgv.Cells[5].Value.ToString();
                txt_telefono.Text = dgv.Cells[6].Value.ToString();


                llenado_cmb_perfil();

            }
            catch (Exception ex)

            {
                MessageBox.Show("ERROR");
            }
        }
    
    }
    }

