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
    public partial class Aplicaciones : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataAdapter da;
        DataTable dt;
        MySqlDataReader dr;

        public Aplicaciones()
        {
            InitializeComponent();
            try
            {
                con = new MySqlConnection("server = localhost; user id = root; database = BD_seguridad");
                con.Open();
                MessageBox.Show("conectado");
                mostrar_aplicacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No conectado");
            }
        }

        private void Aplicaciones_Load(object sender, EventArgs e)
        {

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int check1 = 1;
                int check2 = 2;
                int check3 = 3;

                com = new MySqlCommand("insert into aplicacion (nombre_aplicacion, descripcion_aplicacion) values ('"+ txt_aplicacion.Text +"', '"+ txt_aplicacion_descripcion.Text +"')", con);
               com.ExecuteNonQuery();
               MessageBox.Show("Datos Ingresados");

                string id_aplicacion;
                int id = 0;
                com = new MySqlCommand("select id_aplicacion from aplicacion where nombre_aplicacion='" + txt_aplicacion.Text + "' ", con);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_aplicacion = dr["id_aplicacion"].ToString();
                    id = Convert.ToInt32(id_aplicacion);
                }
                dr.Close();

                if (chb_insertar.Checked)
                {
                    com = new MySqlCommand("insert into detalle_aplicacion_derecho (id_aplicacion, id_derecho) values("+ id +", "+ check1 +")", con);
                    com.ExecuteNonQuery();
                }
                if (chb_eliminar.Checked)
                {
                    com = new MySqlCommand("insert into detalle_aplicacion_derecho (id_aplicacion, id_derecho) values(" + id + ", " + check2 + ")", con);
                    com.ExecuteNonQuery();
                }
                if (chb_modificar.Checked)
                {
                    com = new MySqlCommand("insert into detalle_aplicacion_derecho (id_aplicacion, id_derecho) values(" + id + ", " + check3 + ")", con);
                    com.ExecuteNonQuery();
                }

                MessageBox.Show("Datos Ingresados");
                mostrar_aplicacion();
                txt_aplicacion.Text = "";
                txt_aplicacion_descripcion.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        public void mostrar_aplicacion()
        {
            da = new MySqlDataAdapter("select *from aplicacion", con);
            dt = new DataTable();
            da.Fill(dt);
            dgv_aplicacion.DataSource = dt;
        }
    }
}
