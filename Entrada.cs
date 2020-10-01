using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_IN
{
    public partial class Entrada : Form
    {
        Conexion con = new Conexion();
        Estacionamiento es = new Estacionamiento();
        LoginPension lp = new LoginPension();
        public Entrada()
        {
            InitializeComponent();
        }

        private void btn_Estacionam_Click(object sender, EventArgs e)
        {
            es.IngresarEstacionamiento();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lp.Show();
        }
    }
}
