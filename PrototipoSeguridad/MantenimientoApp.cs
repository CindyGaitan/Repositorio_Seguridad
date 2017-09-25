﻿using System;
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
    public partial class Frm_MantenimientoApp : Form
    {

        public Frm_MantenimientoApp()
        {
            InitializeComponent();
            //primer();
            //boton_ingresar();
            //boton_editar();
            //bloqueados();
            //desbloqueados();
            //comboBox_app();
            //aceptados();
            //contar_userapp();
        }

        MySqlConnection cn = new MySqlConnection("datasource = localhost; database=BD_seguridad;username=root;password=");
        int auxG = 1;
        int num;
        int I, M, Im, C, E, H, us;
        int edit, store;
        int id_user;
        int totalUser;
        int id_app;
        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Frm_MantenimientoApp_Load(object sender, EventArgs e)
        {
            bloqueados();

            string sql = "select count(U.id_usuario) as total from Usuario U ";
            MySqlCommand com = new MySqlCommand(sql, cn);

            cn.Open();
            MySqlDataReader Reader = com.ExecuteReader();

            if (Reader.Read())
            {

                Txt_user.Text = Reader["total"].ToString();
                num = Convert.ToInt32(Txt_user.Text);
            }
            cn.Close();
            primer();

        }


        public void primer() {

            string sql = "select  U.nombre_usuario, ap.nombre_aplicacion, D.ingresar, D.modificar, D.eliminar, D.imprimir,D.consultar,D.habilitar from Usuario U, Aplicacion ap, Detalle_aplicacion_derecho D where D.id_usuario = " + auxG + " and D.id_usuario = U.id_usuario and D.id_aplicacion = ap.id_aplicacion; ";
            MySqlCommand com = new MySqlCommand(sql, cn);


            cn.Open();
            MySqlDataReader Reader = com.ExecuteReader();

            if (Reader.Read())
            {
                Txt_user.Text = Reader["nombre_usuario"].ToString();
                Txt_aplicacion.Text = Reader["nombre_aplicacion"].ToString();
                I = Convert.ToInt32(Reader["ingresar"]);
                M = Convert.ToInt32(Reader["modificar"]);
                Im = Convert.ToInt32(Reader["imprimir"]);
                C = Convert.ToInt32(Reader["consultar"]);
                E = Convert.ToInt32(Reader["eliminar"]);
                H = Convert.ToInt32(Reader["habilitar"]);
            }

            if (I == 1) { Chb_insertar.Checked = true; } else { Chb_insertar.Checked = false; }
            if (M == 1) { Chb_editar.Checked = true; } else { Chb_editar.Checked = false; }
            if (Im == 1) { Chb_imprimir.Checked = true; } else { Chb_imprimir.Checked = false; }
            if (C == 1) { Chb_consultar.Checked = true; } else { Chb_consultar.Checked = false; }
            if (E == 1) { Chb_eliminar.Checked = true; } else { Chb_eliminar.Checked = false; }
            if (H == 1) { Rbtn_habilitado.Checked = true; Rbtn_deshabilitado.Checked = false; } else { Rbtn_deshabilitado.Checked = true; Rbtn_habilitado.Checked = false; }

            cn.Close();


        }

        private void Btn_siguiente_Click(object sender, EventArgs e)
        {

            if (store == 1)
            {
                auxG = auxG + 1;

                if (auxG > 0 && auxG <= num)
                {
                    call_users();
                    contar_userapp();
                    aceptados();
                }
                else
                {
                    auxG = 1;
                    call_users();
                    contar_userapp();
                    aceptados();
                }


            }
            else
            {

                auxG = auxG + 1;

                if (auxG > 0 && auxG <= num)
                {
                    primer();
                }
                else
                {
                    auxG = 1;
                    primer();
                }

            }
        }

        private void Btn_anterior_Click(object sender, EventArgs e)
        {

            if (store == 1)
            {
                auxG = auxG + 1;

                if (auxG > 0 && auxG <= num)
                {
                    call_users();
                    contar_userapp();
                    aceptados();
                }
                else
                {
                    auxG = 1;
                    call_users();
                    contar_userapp();
                    aceptados();
                }


            }
            else
            {


                auxG = auxG - 1;

                if (auxG > 0 && auxG <= num)
                {
                    primer();

                }
                else
                {
                    auxG = num;
                    primer();
                }
            }
        }

        private void Btn_primerElemento_Click(object sender, EventArgs e)
        {

            if (store == 1)
            {
                auxG = 1;
                call_users();
                contar_userapp();
                aceptados();
            }
            else
            {
                auxG = 1;
                primer();
            }
        }

        private void Btn_ultimoElemento_Click(object sender, EventArgs e)
        {
            if (store == 1)
            {
                auxG = num;
                call_users();
                contar_userapp();
                aceptados();
            }
            else
            {
                auxG = num;
                primer();
            }
        }

        private void Btn_refrescar_Click(object sender, EventArgs e)
        {
            primer();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            edit = 1;
            desbloqueados();


        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            store = 1;
            Cmb_aplicacion.Visible = true;
            Txt_aplicacion.Visible = false;
            call_users();
            comboBox_app();
            desbloqueados();
            Txt_aplicacion.Enabled = true;
            contar_userapp();
            aceptados();

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            bloqueados();
            edit = 0;
            store = 0;
            primer();
        }

        public void bloqueados() {
            Txt_aplicacion.Enabled = false;
            Txt_user.Enabled = false;
            Chb_editar.Enabled = false;
            Chb_eliminar.Enabled = false;
            Chb_imprimir.Enabled = false;
            Chb_insertar.Enabled = false;
            Chb_consultar.Enabled = false;
            Rbtn_deshabilitado.Enabled = false;
            Rbtn_habilitado.Enabled = false;
        }

        public void desbloqueados() {
            Chb_editar.Enabled = true;
            Chb_eliminar.Enabled = true;
            Chb_imprimir.Enabled = true;
            Chb_insertar.Enabled = true;
            Chb_consultar.Enabled = true;
            Rbtn_deshabilitado.Enabled = true;
            Rbtn_habilitado.Enabled = true;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Chb_editar.Enabled == false)
            {
                MessageBox.Show("Lo siento, no se a editado nada");
            }
            else { 

                if (edit == 1) {
                    boton_editar();
                    primer();
                }


                if (store == 1)
                {
                    boton_ingresar();
                    primer();
                    bloqueados();
                }

            }
        }


        public void boton_editar() {
            if (Chb_editar.Checked == true) { M = 1; } else { M = 0; }
            if (Chb_insertar.Checked == true) { I = 1; } else { I = 0; }
            if (Chb_eliminar.Checked == true) { E = 1; } else { E = 0; }
            if (Chb_consultar.Checked == true) { C = 1; } else { C = 0; }
            if (Chb_imprimir.Checked == true) { Im = 1; } else { Im = 0; }
            if (Rbtn_habilitado.Checked == true) { H = 1; } else { H = 0; }


            int o, p, q, r, s, t;

            cn.Open();
            MySqlCommand cmd1 = new MySqlCommand("update Detalle_aplicacion_derecho set ingresar = " + I + " where id_usuario = " + auxG, cn);
            MySqlCommand cmd2 = new MySqlCommand("update Detalle_aplicacion_derecho set modificar = " + M + " where id_usuario = " + auxG, cn);
            MySqlCommand cmd3 = new MySqlCommand("update Detalle_aplicacion_derecho set eliminar = " + E + " where id_usuario = " + auxG, cn);
            MySqlCommand cmd4 = new MySqlCommand("update Detalle_aplicacion_derecho set imprimir = " + Im + " where id_usuario = " + auxG, cn);
            MySqlCommand cmd5 = new MySqlCommand("update Detalle_aplicacion_derecho set consultar = " + C + " where id_usuario = " + auxG, cn);
            MySqlCommand cmd6 = new MySqlCommand("update Detalle_aplicacion_derecho set habilitar = " + H + " where id_usuario = " + auxG, cn);

            o = cmd1.ExecuteNonQuery();
            p = cmd2.ExecuteNonQuery();
            q = cmd3.ExecuteNonQuery();
            r = cmd4.ExecuteNonQuery();
            s = cmd5.ExecuteNonQuery();
            t = cmd6.ExecuteNonQuery();

            cn.Close();

            edit = 0;
            store = 0;
            bloqueados();
        }

        public void boton_ingresar() {

            if (Chb_editar.Checked == true) { M = 1; } else { M = 0; }
            if (Chb_insertar.Checked == true) { I = 1; } else { I = 0; }
            if (Chb_eliminar.Checked == true) { E = 1; } else { E = 0; }
            if (Chb_consultar.Checked == true) { C = 1; } else { C = 0; }
            if (Chb_imprimir.Checked == true) { Im = 1; } else { Im = 0; }
            if (Rbtn_habilitado.Checked == true) { H = 1; } else { H = 0; }

            cn.Open();
            MySqlCommand cmd0 = new MySqlCommand("select id_aplicacion from Aplicacion where nombre_aplicacion = '" + Cmb_aplicacion.Text + "'", cn);
            MySqlDataReader reader = cmd0.ExecuteReader();

            if (reader.Read()) {

                id_app = Convert.ToInt32(reader["id_aplicacion"]);
            }
            cn.Close();


            cn.Open();
            MySqlCommand cmd = new MySqlCommand("insert into Detalle_aplicacion_derecho(id_usuario,id_aplicacion,ingresar, modificar,eliminar, imprimir,consultar, habilitar ) values(" + id_user +", "+ id_app +" , "+ I + ", " + M + ", " + E + ", " + Im + ", " + C + ", " + H + ")", cn);
            int g;
            g = cmd.ExecuteNonQuery();
            MessageBox.Show("Se han Agregados los privilegios a "+Txt_user.Text);
            cn.Close();

            store = 0;
            edit = 0;
            Cmb_aplicacion.Visible = false;
            Picb_aceptar.Visible = false;
            Txt_aplicacion.Visible = true;

        }



        public void comboBox_app() {
            cn.Open();
            try
            {

                MySqlCommand sentencia = new MySqlCommand();
                sentencia.Connection = cn;
                sentencia.CommandText = "select a.nombre_aplicacion from aplicacion a inner join detalle_perfil_aplicacion dpa on  a.id_aplicacion = dpa.id_aplicacion inner join perfil p on dpa.id_perfil = p.id_perfil inner join usuario u on u.id_perfil = p.id_perfil where u.id_usuario = "+ auxG +" ";

                MySqlDataAdapter da1 = new MySqlDataAdapter(sentencia);
                DataTable dt = new DataTable();
                da1.Fill(dt);

                Cmb_aplicacion.ValueMember = "id_aplicacion";
                Cmb_aplicacion.DisplayMember = "nombre_aplicacion";

                Cmb_aplicacion.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("no encontrado. " + ex);
            }
            finally
            {
                cn.Close();
            }
        }


        public void call_users() {

            cn.Open();
            MySqlCommand cmd = new MySqlCommand("select id_usuario, nombre_usuario from Usuario where id_usuario = " + auxG, cn);

            MySqlDataReader Reader = cmd.ExecuteReader();

            if (Reader.Read())
            {
                id_user = Convert.ToInt32(Reader["id_usuario"]);
                Txt_user.Text = Reader["nombre_usuario"].ToString();

            }
            cn.Close();

        }


        public void aceptados()
        {
            if ((id_user <= totalUser) && (id_user >= 1))
            {
                Picb_aceptar.Visible = true;
            }
            else {
                Picb_aceptar.Visible = false;
            }


        }

        public void contar_userapp() {

            cn.Open();
            MySqlCommand cmd = new MySqlCommand("select count(id_usuario) as total from Detalle_aplicacion_derecho;", cn);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read()) {

                totalUser = Convert.ToInt32(reader["total"]);

            }

            cn.Close();


        }

        private void Chb_imprimir_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Chb_eliminar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Chb_editar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Chb_insertar_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
