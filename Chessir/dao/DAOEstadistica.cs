using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Chessir.dao
{
    internal class DAOEstadistica
    {
        //todas estos métodos aumentarán el número de partidas, victorias o derrotas de un determinado usuario
        public void incrementarPartidas(int id_usuario)
        {
            try
            {
                string query = "UPDATE estadisticas SET num_partidas = num_partidas + 1, fecha_actualizacion = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE id_usuario = " + id_usuario + ";";

                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo aumentar el número de partidas jugadas. Error: " + ex.ToString());
            }
        }

        public void incrementarVictorias(int id_usuario)
        {
            try
            {
                string query = "UPDATE estadisticas SET num_victorias = num_victorias + 1, fecha_actualizacion = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE id_usuario = " + id_usuario + ";";

                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo aumentar el número de victorias. Error: " + ex.ToString());
            }
        }

        public void incrementarDerrotas(int id_usuario)
        {
            try
            {
                string query = "UPDATE estadisticas SET num_derrotas = num_derrotas + 1, fecha_actualizacion = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE id_usuario = " + id_usuario + ";";

                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo aumentar el número de derrotas. Error: " + ex.ToString());
            }
        }

        public void incrementarTablas(int id_usuario)
        {
            try
            {
                string query = "UPDATE estadisticas SET num_tablas = num_tablas + 1, fecha_actualizacion = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE id_usuario = " + id_usuario + ";";

                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo aumentar el número de empates. Error: " + ex.ToString());
            }
        }

        //ahora, estos métodos devolverán las estadísticas de un usuario
        public int getNumPartidas(int id_usuario)
        {
            int num_partidas = 0;

            try
            {
                string query = "SELECT num_partidas FROM estadisticas WHERE id_usuario = " + id_usuario + ";";

                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        num_partidas = reader.GetInt32(0);
                    }
                }

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al conectar: " + ex.ToString());
            }
            return num_partidas;
        }

        public int getVictorias(int id_usuario)
        {
            int victorias = 0;

            try
            {
                string query = "SELECT num_victorias FROM estadisticas WHERE id_usuario = " + id_usuario + ";";

                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        victorias = reader.GetInt32(0);
                    }
                }

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al conectar: " + ex.ToString());
            }
            return victorias;
        }

        public int getDerrotas(int id_usuario)
        {
            int derrotas = 0;

            try
            {
                string query = "SELECT num_derrotas FROM estadisticas WHERE id_usuario = " + id_usuario + ";";

                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        derrotas = reader.GetInt32(0);
                    }
                }

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al conectar: " + ex.ToString());
            }
            return derrotas;
        }

        public int getTablas(int id_usuario)
        {
            int tablas = 0;

            try
            {
                string query = "SELECT num_tablas FROM estadisticas WHERE id_usuario = " + id_usuario + ";";

                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tablas = reader.GetInt32(0);
                    }
                }

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al conectar: " + ex.ToString());
            }
            return tablas;
        }

        //los siguientes métodos consultan de la tabla partidas, pero se usan aquí ya que serán parte del form de estadísticas
        //para saber el número de veces que un usuario ha jugado a un modo de juego determinado
        public int getCountModoJuego(int id_usuario, string modo_juego)
        {
            int count = 0;

            try
            {
                string query = "SELECT COUNT(*) FROM partidas WHERE modo_juego = '" + modo_juego + "' AND (id_blanco = " + id_usuario + " OR id_negro = " + id_usuario + ");";

                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al contar valores: " + ex.ToString());
            }
            return count;
        }
    }
}
