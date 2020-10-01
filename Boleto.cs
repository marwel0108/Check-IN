using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Check_IN
{
    class Boleto
    {
        
        private Font fuente = new Font("Arial", 30);
        
        private string folio;
        private double importe;
        private DateTime hora;
        private DateTime hora2;

        public Boleto(string f, double i, DateTime h1, DateTime h2)
        {
            folio = f;
            importe = i;
            hora = h1;
            hora2 = h2;
        }


        public void Imprimirsalida()
        {
            PrintDocument ticket = new PrintDocument();
            ticket.PrintPage += new PrintPageEventHandler(DatosBoletoSalida);
            PrintDialog printDialog = new PrintDialog();
            ticket.Print();
        }

        public void DatosBoletoSalida(object obj, PrintPageEventArgs e)
        {
            StringFormat formato = new StringFormat() { Alignment = StringAlignment.Center };
            e.Graphics.DrawLine(new Pen(Brushes.Brown, 4), 10, 70, 860, 70);
            e.Graphics.DrawString("Folio: No. " + folio, fuente, Brushes.Black, 120, 200, new StringFormat());
            e.Graphics.DrawString("Importe: $ " + importe.ToString(), fuente, Brushes.Black, 120, 400, new StringFormat());
            e.Graphics.DrawString("Hora de entrada: " + hora.ToShortTimeString(), fuente, Brushes.Black, 120, 600, new StringFormat());
            e.Graphics.DrawString("Hora de salida: " + hora2.ToShortTimeString(), fuente, Brushes.Black, 120, 800, new StringFormat());
        }
    }
}
