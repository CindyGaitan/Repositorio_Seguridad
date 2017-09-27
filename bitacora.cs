using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bitacora_dll;

namespace bitacora_dll
{
    public partial class bitacora : UserControl
    {

        [Description("Nombre de la tabla ")]
        [Category("Datos Nuevos")]
        public String NombreTabla { get; set; }


        public static String stringpad = "server=localhost;user id=root;database=BD_seguridad";
        bitacora_dll connection = new bitacora_dll(stringpad);

        public bitacora()
        {
            InitializeComponent();
        }

        private void bitacora_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.OpenConnection();
            Dgv_bitacora.DataSource = connection.llenarBitacora("select * from " + NombreTabla);
            connection.CloseConnection();
        }
    }
}
