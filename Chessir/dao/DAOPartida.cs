using Chessir.dto;
using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Chessir.dao
{
    internal class DAOPartida
    {
        //almacena la partida en la base de datos y devuelve su ID para poder añadir el resto de sus datos si tiene ganador
        public int registrarPartida(DTOPartida dtoPartida)
        {
            int id_partida = -1; //id a devolver recibido tras insertar la partida
            try
            {
                string query = "INSERT INTO partidas(id_blanco, id_negro, modo_juego, fecha_creacion) VALUES("
                    + dtoPartida.Id_blanco + ", " + dtoPartida.Id_negro + ", '" + dtoPartida.Modo_juego + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "');";

                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myCommand.ExecuteNonQuery();

                myCommand.CommandText = "SELECT LAST_INSERT_ID()"; //devuelve el último ID añadido
                id_partida = Convert.ToInt32(myCommand.ExecuteScalar());

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al registrar la partida en la base de datos: " + ex.ToString());
            }
            return id_partida;
        }

        //añade los registros faltantes cuando gana algún jugador
        public void añadirGanador(int id_partida, int id_ganador, string motivo_victoria)
        {
            try
            {
                string query = "UPDATE partidas SET id_ganador = " + id_ganador + ", motivo_victoria = '" + motivo_victoria + "' WHERE id = " + id_partida + ";";

                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron actualizar los datos de la partida. Error: " + ex.ToString());
            }
        }

        //en caso de que no haya ganador
        public void tablas(int id_partida)
        {
            try
            {
                string query = "UPDATE partidas SET motivo_victoria = 'Tablas' WHERE id = " + id_partida + ";";

                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron actualizar los datos de la partida. Error: " + ex.ToString());
            }
        }
    }
}
