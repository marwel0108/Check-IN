using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Check_IN
{
    class Cobrador
    {
        Random r = new Random();
        Conexion con = new Conexion();

        public int validarLogin(string usr, string pass)
        {
            int res;
            try
            {
                if (usr.Equals("admin"))
                {
                    con.Conectar();
                    MySqlCommand consulta = new MySqlCommand("SELECT USERNAME, PASSWORD FROM Administrador WHERE USERNAME = @u AND PASSWORD = @p", con.conexion);
                    consulta.Parameters.Add(new MySqlParameter("@u", usr));
                    consulta.Parameters.Add(new MySqlParameter("@p", pass));
                    consulta.ExecuteNonQuery();
                    MySqlDataReader dr = consulta.ExecuteReader();
                    if (dr.Read())
                    {
                        res = 1;
                    }
                    else
                    {
                        res = 3;
                    }
                    con.cerrarCon();
                }
                else
                {
                    con.Conectar();
                    MySqlCommand consulta = new MySqlCommand("SELECT USERNAME, PASSWORD FROM Empleados WHERE USERNAME =  @u AND PASSWORD = @p", con.conexion);
                    consulta.Parameters.Add(new MySqlParameter("@u", usr));
                    consulta.Parameters.Add(new MySqlParameter("@p", pass));
                    consulta.ExecuteNonQuery();
                    MySqlDataReader dr = consulta.ExecuteReader();
                    if (dr.Read())
                    {
                        res = 2;
                    }
                    else
                    {
                        res = 3;
                    }
                    con.cerrarCon();
                }

            }
            catch (Exception a)
            {
                res = 4;
            }
            
            return res;
        }

        public DataTable mostrarPensionarios()
        {
            con.Conectar();
            string query = "SELECT *FROM Pension";
            MySqlDataAdapter consulta = new MySqlDataAdapter(query, con.conexion);
            DataTable dt = new DataTable();
            consulta.Fill(dt);
            return dt;
        }

        public DataTable mostrarEstacionamiento()
        {
            con.Conectar();
            string query = "SELECT *FROM Estacionamiento";
            MySqlDataAdapter consulta = new MySqlDataAdapter(query, con.conexion);
            DataTable dt = new DataTable();
            consulta.Fill(dt);
            return dt;
        }
        public double CobrarPension(string npension)
        {
            con.Conectar();
            string query = "SELECT * FROM Pension where NUM_PENSION = @npension";
            MySqlCommand consulta = new MySqlCommand(query, con.conexion);
            consulta.Parameters.Add(new MySqlParameter("@npension", npension));
            consulta.ExecuteNonQuery();
            MySqlDataReader dr = consulta.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                query = "SELECT FECHA FROM pension where NUM_PENSION = @npension";
                consulta = new MySqlCommand(query, con.conexion);
                consulta.Parameters.Add(new MySqlParameter("@npension", npension));
                DateTime fechaingreso = Convert.ToDateTime(consulta.ExecuteScalar());
                consulta.ExecuteNonQuery();
                DateTime fechaActual = DateTime.Now;
                TimeSpan diasTranscurridos = fechaActual - fechaingreso;
                if (diasTranscurridos.TotalDays <= 30)
                {
                    return -1;
                }
                else
                {
                    query = "UPDATE Pension set FECHA = @f WHERE NUM_PENSION = @pension";
                    consulta = new MySqlCommand(query, con.conexion);
                    consulta.Parameters.Add(new MySqlParameter("@f", fechaActual));
                    consulta.Parameters.Add(new MySqlParameter("@pension", npension));
                    consulta.ExecuteNonQuery();
                }
            } else
            {
                return 0;
            }
            
            con.cerrarCon();
            return 500;
            
        }

        public void cobrarEstacionamiento(string folio)
        {
            
            con.Conectar();
            string query = "SELECT HORA FROM ESTACIONAMIENTO WHERE FOLIO = @f";
            MySqlCommand consulta = new MySqlCommand(query, con.conexion);
            consulta.Parameters.Add(new MySqlParameter("@f", folio));
            DateTime hora = Convert.ToDateTime(consulta.ExecuteScalar());
            consulta.ExecuteNonQuery();
            DateTime hora2 = DateTime.Now;
            TimeSpan htranscurridas = hora2 - hora;
            query = "DELETE FROM ESTACIONAMIENTO WHERE FOLIO = @f";
            consulta = new MySqlCommand(query, con.conexion);
            consulta.Parameters.Add(new MySqlParameter("@f", folio));
            consulta.ExecuteNonQuery();
            con.cerrarCon();
            double importe = Math.Ceiling(htranscurridas.TotalHours) * 10;
            Boleto bo = new Boleto(folio, importe, hora, hora2);
            bo.Imprimirsalida();
            
        }

        public string generarPass()
        {
            int longitud = 5;

            StringBuilder consString = new StringBuilder();
            Random random = new Random();

            char letra;

            for (int i = 0; i < longitud; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letra = Convert.ToChar(shift + 65);
                consString.Append(letra);
            }
            return consString.ToString();
        }
    }
}
