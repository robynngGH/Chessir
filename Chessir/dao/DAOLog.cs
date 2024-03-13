using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Chessir.dao
{
    internal class DAOLog
    {
        public void registrarLog(int id_usuario, bool es_jugador_principal)
        {
            try
            {
                //inserta el log en la base de datos
                string query = "INSERT INTO logs(id_usuario, fecha_acceso, es_jugador_principal) VALUES ("
                    + id_usuario + ", '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', " + es_jugador_principal + ");";

                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al registrar el acceso: " + ex.ToString());
            }
        }
    }
}
