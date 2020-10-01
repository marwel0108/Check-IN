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
    public partial class LoginEmp : Form
    {
        Cobrador cb = new Cobrador();
        Cobrador_Form cbf = new Cobrador_Form();
        Admin ad = new Admin();
        public LoginEmp()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int res = cb.validarLogin(txt_usr.Text, txt_pass.Text);
            if(res == 1)
            {
                ad.Show();
                this.Hide();
            } else if (res == 2)
            {
                cbf.Show();
                this.Hide();
            } else if (res == 3)
            {
                lbl_login.Text = "Usuario no valido";
            } else
            {
                MessageBox.Show("Un error ocurrio");
            }
        }   
    }
}
