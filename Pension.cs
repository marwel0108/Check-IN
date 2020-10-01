using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Check_IN
{
    class Pension
    {
        Conexion con = new Conexion();
        
        public int validarLogin(string usr, string pass)
        {
            int res;
            try
            {
                con.Conectar();
                MySqlCommand consulta = new MySqlCommand("SELECT USERNAME, PASSWORD FROM Pension WHERE USERNAME = '" + usr + "' AND PASSWORD = '" + pass + "'", con.conexion);
                MySqlDataReader dr = consulta.ExecuteReader();
                if (dr.Read())
                {
                    res = 1;
                }
                else
                {
                    res = 2;
                }
                con.cerrarCon();
            }
            catch (Exception a)
            {
                res = 3;
            }
            return res;
        }

        public void validarEntrada(string usr)
        {
            string query = "SELECT FECHA FROM pension where USERNAME = @u";
            con.Conectar();
            MySqlCommand consulta = new MySqlCommand(query, con.conexion);
            consulta.Parameters.Add(new MySqlParameter("@u", usr));
            DateTime fechaingreso = Convert.ToDateTime(consulta.ExecuteScalar());
            Console.WriteLine(fechaingreso.ToString());
            consulta.ExecuteNonQuery();
            con.cerrarCon();
            DateTime fechaActual = DateTime.Now;
            TimeSpan diasTranscurridos = fechaActual - fechaingreso;
            if (diasTranscurridos.TotalDays > 30)
            {
                Mensajes.mensaje("Debe pagar su mensualidad", 2000);
            }
            else
            {
                Mensajes.mensaje("Bienvenido!", 2000);
            }
        }
    }
}

