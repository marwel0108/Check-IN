using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_IN
{
    class Mensajes
    {
       public static void mensaje(string mensaje, int delay)
        {
            using (Timer t = new Timer())
            {
                Timer time = new Timer();
                time.Interval = delay;
                time.Tick += DetenerDelay;  /* Evento enlazado */

                time.Start();

                /* Muestras el texto en el MB */
                MessageBox.Show(mensaje);
            }
        }

        private static void DetenerDelay(object sender, EventArgs e)
        {
            (sender as Timer).Stop();  /* Detiene el Timer */
            SendKeys.Send("{ESC}"); /* Hace la simulación de la tecla Escape, también puedes usar {ENTER} */
        }
    }
}
