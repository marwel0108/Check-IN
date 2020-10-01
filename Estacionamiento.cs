using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Check_IN
{
    class Estacionamiento
    {
        Conexion con = new Conexion();
        string folio;
        public void IngresarEstacionamiento()
        {
            string query = "SELECT COUNT(Folio) FROM Estacionamiento";
            DateTime hora = DateTime.Now;
            con.Conectar();
            MySqlCommand consulta = new MySqlCommand(query, con.conexion);
            consulta.ExecuteNonQuery();
            int lugares = Convert.ToInt32(consulta.ExecuteScalar());
            con.cerrarCon();
            if (lugares < 40)
            {

                try
                {
                    con.Conectar();
                    consulta = new MySqlCommand("INSERT INTO Estacionamiento(HORA)VALUES(@h)", con.conexion);
                    consulta.Parameters.Add(new MySqlParameter("@h", hora));
                    consulta.ExecuteNonQuery();
                    con.cerrarCon();
                    Mensajes.mensaje("Adelante, bienvenido a Check'IN parking", 1500);
                }
                catch (Exception e)
                {
                    MessageBox.Show("" + e);
                }


            } else
            {
                Mensajes.mensaje("Lo sentimos, no hay lugares disponibles.", 1500);
            }
            
        }
    }
}
