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
        MySqlCommand com, com2;
        MySqlDataAdapter da;
        DataTable dt;
        MySqlDataReader dr;

        public Aplicaciones()
        {
            InitializeComponent();
            mostrar_aplicacion();
            
        }

        private void Aplicaciones_Load(object sender, EventArgs e)
        {

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection("server = localhost; user id = root; database = BD_seguridad");
                con.Open();

                com = new MySqlCommand("insert into aplicacion (nombre_aplicacion, descripcion_aplicacion) values ('"+ txt_aplicacion.Text +"', '"+ txt_aplicacion_descripcion.Text +"')", con);
                com.ExecuteNonQuery();

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
            con = new MySqlConnection("server = localhost; user id = root; database = BD_seguridad");
            con.Open();

            da = new MySqlDataAdapter("select *from aplicacion", con);
            dt = new DataTable();
            da.Fill(dt);
            dgv_aplicacion.DataSource = dt;
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection("server = localhost; user id = root; database = BD_seguridad");
                con.Open();

                com = new MySqlCommand("update aplicacion set nombre_aplicacion='"+ txt_aplicacion.Text +"', descripcion_aplicacion='"+ txt_aplicacion_descripcion.Text +"' where id_aplicacion="+ Convert.ToInt32(this.var_aplicacion) +" ", con);
                com.ExecuteNonQuery();

                mostrar_aplicacion();
                txt_aplicacion.Text = "";
                txt_aplicacion_descripcion.Text = "";
                MessageBox.Show("Datos actualizados");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos no actualizados");
            }

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection("server = localhost; user id = root; database = BD_seguridad");
                con.Open();

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

                com = new MySqlCommand("delete from aplicacion where id_aplicacion=" + id + " ", con);
                com.ExecuteNonQuery();

                txt_aplicacion.Text = "";
                txt_aplicacion_descripcion.Text = "";
                mostrar_aplicacion();
                MessageBox.Show("Registro eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar, dato no puede ser eliminado");
            }
        }

        string var_aplicacion;
        private void dgv_aplicacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgv_aplicacion.Rows[e.RowIndex];

                this.var_aplicacion = dgv.Cells[0].Value.ToString();
                txt_aplicacion.Text = dgv.Cells[1].Value.ToString();
                txt_aplicacion_descripcion.Text = dgv.Cells[2].Value.ToString();
               
            }
            catch (Exception ex)

            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
