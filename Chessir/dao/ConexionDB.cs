using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Chessir.dao
{
    internal class ConexionDB
    {
        MySqlConnection conexion = new MySqlConnection(); //deleted info for security reasons (hi github)
        static string servidor = "";
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
