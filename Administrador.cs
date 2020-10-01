using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Check_IN
{
    class Administrador : Cobrador
    {
        Conexion con = new Conexion();
        public string agregarPensionario(string nombre, string apellido, string tel)
        {
            string query = "SELECT COUNT(Nombre) FROM Pension";
            DateTime fecha = DateTime.Now;
            string usr = nombre.Trim().Substring(0, 2).ToLower() + apellido.Trim().Substring(0, 2).ToLower();
            string pass = generarPass();
            con.Conectar();
            MySqlCommand consulta = new MySqlCommand(query, con.conexion);
            int lugares = Convert.ToInt32(consulta.ExecuteScalar());
            con.cerrarCon();
            if (lugares < 10)
            {

                try
                {
                    con.Conectar();
                    consulta = new MySqlCommand("INSERT INTO Pension(NOMBRE, APELLIDOS, FECHA, PASSWORD, USERNAME, TELEFONO)VALUES(@n, @a, @f, @p, @u, @t)", con.conexion);
                    consulta.Parameters.Add(new MySqlParameter("@n", nombre));
                    consulta.Parameters.Add(new MySqlParameter("@a", apellido));
                    consulta.Parameters.Add(new MySqlParameter("@f", fecha));
                    consulta.Parameters.Add(new MySqlParameter("@p", pass));
                    consulta.Parameters.Add(new MySqlParameter("@u", usr));
                    consulta.Parameters.Add(new MySqlParameter("@t", tel));
                    consulta.ExecuteNonQuery();
                    con.cerrarCon();
                    Mensajes.mensaje("Pensionario agregado a Check'IN parking", 1500);
                }
                catch (Exception e)
                {
                    Mensajes.mensaje("Un error ocurrio", 1500);
                }


            }
            else
            {
                MessageBox.Show("Lo sentimos, no hay lugares disponibles.");
            }
            return pass;
            
        }

        public void eliminarPensionario(string npension)
        {
            string query = "SELECT * FROM Pension WHERE NUM_PENSION = @npension";
            con.Conectar();
            MySqlCommand consulta= new MySqlCommand(query, con.conexion);
            consulta.Parameters.Add(new MySqlParameter("@npension", npension));
            consulta.ExecuteNonQuery();
            MySqlDataReader dr = consulta.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                query = "DELETE FROM Pension WHERE NUM_PENSION = @npension";
                consulta = new MySqlCommand(query, con.conexion);
                consulta.Parameters.Add(new MySqlParameter("@npension", npension));
                consulta.ExecuteNonQuery();
            } else
            {
                Mensajes.mensaje("Pensionario inexistente", 1500);
            }
        }
        
    }
}
