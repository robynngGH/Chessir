namespace Chessir.dto
{
    internal class DTOPartida
    {
        public int Id { get; set; }
        public int Id_blanco { get; set; }
        public int Id_negro { get; set; }
        public string Modo_juego { get; set; }
        public int Id_ganador { get; set; }
        public string Motivo_victoria { get; set; }
        public string Fecha_creacion { get; set; }

        //constructor para la creación inicial de partida (sin datos de victoria)
        public DTOPartida(int id_blanco, int id_negro, string modo_juego) { this.Id_blanco = id_blanco; this.Id_negro = id_negro; this.Modo_juego = modo_juego; }
    }
}
