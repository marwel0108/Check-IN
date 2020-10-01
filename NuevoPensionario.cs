using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Check_IN
{
    public partial class NuevoPensionario : Form
    {
        public NuevoPensionario()
        {
            InitializeComponent();
        }


        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Administrador ad = new Administrador();

            if (txt_tel.Text.Equals("") || txt_nom.Text.Equals("") || txt_ap.Text.Equals(""))
            {
                Mensajes.mensaje("Debes llenar todos los campos", 1500);
            } else
            {
                string password = ad.agregarPensionario(txt_nom.Text, txt_ap.Text, txt_tel.Text);
                txt_pass.Text = password;
                txt_nom.Text = "";
                txt_ap.Text = "";
                txt_tel.Text = "";
            }
            
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            txt_pass.Text = "";
        }
    }
}
