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
    public partial class Perfiles : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataAdapter da;
        DataTable dt;

        public Perfiles()
        {          
            InitializeComponent();
            try
            {
                con = new MySqlConnection("server = localhost; user id = root; database = BD_seguridad");
                con.Open();
                MessageBox.Show("conectado");
                mostrar_perfil();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No conectado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            com = new MySqlCommand("insert into perfil (nombre_perfil, descripcion_perfil) values ('" + Txt_nombre.Text + "', '" + Txt_descripcion.Text + "')", con);
            com.ExecuteNonQuery();

            MessageBox.Show("Datos Ingresados");
            mostrar_perfil();
        }

        public void mostrar_perfil()
        {
            da = new MySqlDataAdapter("select *from perfil", con);
            dt = new DataTable();
            da.Fill(dt);
            dgv_perfil.DataSource = dt;
        }


        private void Btn_modificar_Click(object sender, EventArgs e)
        {

        }
    }
}
