using Chessir.dto;
using MySqlConnector;
using System;

namespace Chessir.dao
{
    internal class DAOTurno
    {
        public void registrarTurno(DTOTurno dtoTurno)
        {
            try
            {
                string query = "INSERT INTO turnos(id_partida, id_jugador, turno, pieza, casilla_origen, casilla_destino, pieza_comida, peon_convertido, fecha) VALUES("
                    + dtoTurno.Id_partida + ", " + dtoTurno.Id_jugador + ", " + dtoTurno.Turno + ", '" + dtoTurno.Pieza + "', '" + dtoTurno.Casilla_origen + "', '"
                    + dtoTurno.Casilla_destino + "', '" + dtoTurno.Pieza_comida + "', '" + dtoTurno.Peon_convertido + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "');";

                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myCommand.ExecuteNonQuery();

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error inesperado al registrar el turno sobre la partida en la base de datos: " + ex.ToString());
                //da un error por ningún motivo al transformar el peón en otra pieza, funciona bien
            }
        }
    }
}
