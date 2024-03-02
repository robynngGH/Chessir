using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chessir.dao
{
    internal class ConexionDB
    {
        MySqlConnection conexion = new MySqlConnection();
        static string servidor = ""; //data removed for security reasons (hi github)
        static string db = "";
        static string usuario = "";
        static string password = "";
        static string puerto = "";
        string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario
        + "; password=" + password + "; database=" + db + ";";
        public MySqlConnection establecerConexion()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                //MessageBox.Show("Se conectó a la base de datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos, error: " + ex.ToString());
            }
            return conexion;
        }
        public void cerrarConexion()
        {
            conexion.Close();
        }
    }
}
