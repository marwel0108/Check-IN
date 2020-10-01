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
    public partial class cobrarPension : Form
    {
        Administrador ad = new Administrador();
        Cobrador cb = new Cobrador();
        public cobrarPension()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            double resultado = cb.CobrarPension(textBox1.Text);
            if (resultado == -1)
            {
                Mensajes.mensaje("Aun no es tiempo de pagar su mensualidad", 2000);
            } else if (resultado == 0)
            {
                Mensajes.mensaje("Folio no existente", 1500);
            } else
            {
                Mensajes.mensaje("Fecha de mensualidad actualizada", 1500);
            }
            textBox1.Text = "";
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            DataTable dt = ad.mostrarPensionarios();
            this.dataGridView1.DataSource = dt;
        }

    }
}
