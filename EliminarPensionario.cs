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
    public partial class EliminarPensionario : Form
    {
        Administrador ad = new Administrador();
        public EliminarPensionario()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            ad.eliminarPensionario(textBox1.Text);
            DataTable dt = ad.mostrarPensionarios();
            this.dataGridView1.DataSource = dt;
            textBox1.Text = "";
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            DataTable dt = ad.mostrarPensionarios();
            this.dataGridView1.DataSource = dt;
        }
    }
}
