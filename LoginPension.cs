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
    public partial class LoginPension : Form
    {
        Pension p = new Pension();
        public LoginPension()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int res = p.validarLogin(txt_usr.Text, txt_pass.Text);
            if (res == 1)
            {
                p.validarEntrada(txt_usr.Text);
                txt_usr.Text = "";
                txt_pass.Text = "";
                this.Hide();
            } else if (res == 2)
            {
                Mensajes.mensaje("Usuario no valido", 1500);
                txt_usr.Text = "";
                txt_pass.Text = "";
            } else
            {
                MessageBox.Show("Un error ocurrio");
            }
        }

    }
}
