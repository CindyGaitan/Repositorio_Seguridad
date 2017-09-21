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


namespace aplicacionesdeusuario
{
    public partial class AsignacionaPerfiles : Form
    {
        public AsignacionaPerfiles()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=1234";
                //Display query  
                string Query = "select * from bd_seguridad.aplicacion ;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                   // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MySqlConnection conector = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;");
            conector.Open();
           
           
            try
            {



                MySqlCommand sentencia = new MySqlCommand();
                sentencia.Connection = conector;
                sentencia.CommandText = "SELECT * from bd_seguridad.perfil";

                MySqlDataAdapter da1 = new MySqlDataAdapter(sentencia);
                DataTable dt = new DataTable();
                da1.Fill(dt);


                comboBox1.ValueMember = "id_perfil";
                comboBox1.DisplayMember = "id_perfil";
               
                comboBox1.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("no encntrado. " + ex);
            }
            finally
            {
                conector.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;






            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=1234";

            string sql = "SELECT nombre_perfil from bd_seguridad.perfil where '" + selectedIndex.ToString() + "' = perfil.id_perfil; ";
            MySqlConnection conn = new MySqlConnection();
            conn = new MySqlConnection(MyConnection2);
            conn.Open();
           
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(selectedIndex.ToString()));
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["nombre_perfil"].ToString();
                

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            dataGridView2.Rows.Add(new string[] {
                Convert.ToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value)
            });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int counter = 0; counter < (dataGridView1.Rows.Count)-1;
         counter++)
            {
                dataGridView2.Rows.Add(new string[] {
                Convert.ToString(dataGridView1[1, counter].Value)
            });
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            AsignacionaPerfiles p1 = new AsignacionaPerfiles();
            p1.Close();
        }
    }
}



