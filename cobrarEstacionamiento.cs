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

namespace Check_IN
{
    public partial class cobrarEstacionamiento : Form
    {
        Administrador ad = new Administrador();
        Conexion con = new Conexion();
        public cobrarEstacionamiento()
        {
            InitializeComponent();
        }


        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            if (txt_Folio.Text == "")
            {
                lbl_folio.Text = "Introduzca un folio";
            }
            else
            {
                ad.cobrarEstacionamiento(txt_Folio.Text);
                DataTable dt = ad.mostrarEstacionamiento();
                this.dataGridView1.DataSource = dt;
            }
            txt_Folio.Text = "";
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            DataTable dt = ad.mostrarEstacionamiento();
            this.dataGridView1.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
