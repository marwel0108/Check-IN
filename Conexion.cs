using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;



namespace Check_IN
{
    class Conexion
    {
        public MySqlConnection conexion;


       
        public void Conectar()
        {
            conexion = new MySqlConnection("server = 127.0.0.1; database = parkiteasy; uid = root; psw =;");
            if (conexion.State != System.Data.ConnectionState.Open)
            {
                conexion.Open();
            }
        }

        public void cerrarCon()
        {
            if (conexion.State != System.Data.ConnectionState.Closed)
            {
                conexion.Close();
            }
        }
               
    }
}
