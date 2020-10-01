using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace Check_IN
{
    public partial class Admin : Form
    {
        private IconButton btn_Actual;

        private Panel borde_Izquierdo;

        private Form formulario_Actual;

        Entrada ed = new Entrada();
        public Admin()
        {
            InitializeComponent();
            borde_Izquierdo = new Panel();
            borde_Izquierdo.Size = new Size(7, 60);
            Menu.Controls.Add(borde_Izquierdo);

        }

        private void boton_Activo(object boton, Color color)
        {
            if (boton != null)
            {
                desactivar_BotonActivo();
                btn_Actual = (IconButton)boton;
                btn_Actual.BackColor = Color.FromArgb(37, 36, 81);
                btn_Actual.ForeColor = color;
                btn_Actual.TextAlign = ContentAlignment.MiddleCenter;
                btn_Actual.IconColor = color;
                btn_Actual.TextImageRelation = TextImageRelation.TextBeforeImage;
                btn_Actual.ImageAlign = ContentAlignment.MiddleRight;

                borde_Izquierdo.BackColor = color;
                borde_Izquierdo.Location = new Point(0, btn_Actual.Location.Y);
                borde_Izquierdo.Visible = true;
                borde_Izquierdo.BringToFront();

                iconoLogo.IconChar = btn_Actual.IconChar;
                iconoLogo.IconColor = color;

            }

        }


        private void abrir_Forms(Form form)
        {
            if (formulario_Actual != null)
            {
                formulario_Actual.Close();
            }

            formulario_Actual = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(form);
            panelEscritorio.Tag = form;
            form.BringToFront();
            form.Show();
            lb_BtnActual.Text = form.Text;
        }

        private void desactivar_BotonActivo()
        {
            if (btn_Actual != null)
            {
                btn_Actual.BackColor = Color.FromArgb(31, 30, 68);
                btn_Actual.ForeColor = Color.Silver;
                btn_Actual.TextAlign = ContentAlignment.MiddleLeft;
                btn_Actual.IconColor = Color.White;
                btn_Actual.TextImageRelation = TextImageRelation.ImageBeforeText;
                btn_Actual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void setPension_Click(object sender, EventArgs e)
        {
            boton_Activo(sender, Color.FromArgb(172, 126, 241));
            abrir_Forms(new NuevoPensionario());
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            boton_Activo(sender, Color.FromArgb(172, 126, 241));
            abrir_Forms(new EliminarPensionario());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_CobrarP_Click(object sender, EventArgs e)
        {
            boton_Activo(sender, Color.FromArgb(172, 126, 241));
            abrir_Forms(new cobrarPension());
        }

        private void btn_CobrarE_Click(object sender, EventArgs e)
        {
            boton_Activo(sender, Color.FromArgb(172, 126, 241));
            abrir_Forms(new cobrarEstacionamiento());
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            desactivar_BotonActivo();
            borde_Izquierdo.Visible = false;

            iconoLogo.IconChar = IconChar.HouseDamage;
            iconoLogo.IconColor = Color.FromArgb(172, 126, 241);
            lb_BtnActual.Text = "Inicio";
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginEmp lg = new LoginEmp();
            lg.Show();
            ed.Close();
            
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            ed.Show();
        }
    }
}
