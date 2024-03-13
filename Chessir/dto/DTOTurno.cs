namespace Chessir.dto
{
    internal class DTOTurno
    {
        public int Id { get; set; }
        public int Id_partida { get; set; }
        public int Id_jugador { get; set; }
        public int Turno { get; set; }
        public string Pieza { get; set; }
        public string Casilla_origen { get; set; }
        public string Casilla_destino { get; set; }
        public string Pieza_comida { get; set; }
        public string Peon_convertido { get; set; }
        public string Fecha { get; set; }

        //constructor con todo menos el ID y fecha, que son automáticos. Pieza_comida y Peon_convertido se puede enviar null si es necesario
        public DTOTurno(int id_partida, int id_jugador, int turno, string pieza, string casilla_origen, string casilla_destino, string pieza_comida, string peon_convertido)
        {
            Id = id_partida;
            Id_partida = id_partida;
            Id_jugador = id_jugador;
            Turno = turno;
            Pieza = pieza;
            Casilla_origen = casilla_origen;
            Casilla_destino = casilla_destino;
            Pieza_comida = pieza_comida;
            Peon_convertido = peon_convertido;
        }
    }
}
