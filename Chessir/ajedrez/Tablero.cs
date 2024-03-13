using Chessir.gui;
using System.Collections.Generic;

namespace Chessir.ajedrez
{
    class Tablero
    {
        public static FormJugar Window;
        public static Tile[,] casillas = new Tile[8, 8]; //se asignan las casillas del tablero
        public static ColorPieza jugadorActual = ColorPieza.BLANCO; //color del primer jugador
        public static List<TableroAnterior> movimientosAnteriores = new List<TableroAnterior>();
        public static Pieza getPieza(int y, int x) => casillas[y, x].pieza;

        public Tablero(FormJugar formJugar)
        {
            Window = formJugar;
            byte filas = 0;

            for (byte x = 0; x < 8; x++, filas++)
            {
                for (byte y = 0; y < 8; y++, filas++)
                {
                    //casilla par será blanca e impar negra
                    Tile casillaCorrecta() => filas % 2 == 0 ? new Tile(y, x, ColorPieza.BLANCO) : new Tile(y, x, ColorPieza.NEGRO);
                    casillas[y, x] = casillaCorrecta();
                    formJugar.Controls.Add(casillas[y, x]); //añade las casillas al formulario
                }
            }

            ponerPiezas(0, ColorPieza.NEGRO); //arriba estarán las piezas negras
            ponerPiezas(7, ColorPieza.BLANCO); //abajo las blancas

            for (int x = 0; x < 8; x++)
                for (int y = 0; y < 8; y++)
                {
                    if (casillas[y, x].pieza.tipopieza != TipoPieza.Vacio)
                        casillas[y, x].ImagenPieza.BackgroundImage = Tile.ImagenesPiezas[casillas[y, x].pieza.getNombreImagen()];
                }
        }

        public static Tile getCasilla(TipoPieza tipoPieza, ColorPieza color)
        {
            for (byte x = 0; x < 8; x++)
                for (byte y = 0; y < 8; y++)
                {
                    if (getPieza(y, x).tipopieza == tipoPieza && getPieza(y, x).color == color)
                        return casillas[y, x];
                }
            return null;
        }

        public static List<Tile> getCasillasConPiezas(ColorPieza color)
        {
            List<Tile> resultadoCasillas = new List<Tile>();
            for (int x = 0; x < 8; x++)
                for (int y = 0; y < 8; y++)
                    if (getPieza(y, x).color == color)
                        resultadoCasillas.Add(casillas[y, x]);
            return resultadoCasillas;
        }

        public static bool esAccesible(int y, int x) => y < 8 && x < 8 && y >= 0 && x >= 0;

        private void ponerPiezas(int fila, ColorPieza color) //recibe la fila inicial en la que se colocan las fichas y su color
        {
            //se colocan los tipos de piezas por orden de izquierda a derecha
            casillas[fila, 0].pieza = new Pieza(TipoPieza.Torre, color);
            casillas[fila, 1].pieza = new Pieza(TipoPieza.Caballo, color);
            casillas[fila, 2].pieza = new Pieza(TipoPieza.Alfil, color);
            casillas[fila, 3].pieza = new Pieza(TipoPieza.Reina, color);
            casillas[fila, 4].pieza = new Pieza(TipoPieza.Rey, color);
            casillas[fila, 5].pieza = new Pieza(TipoPieza.Alfil, color);
            casillas[fila, 6].pieza = new Pieza(TipoPieza.Caballo, color);
            casillas[fila, 7].pieza = new Pieza(TipoPieza.Torre, color);

            fila += fila == 0 ? 1 : -1; //si se empieza a rellenar por arriba se pasará a la siguiente fila, si es por abajo a la anterior
            //forma rápida de rellenar con todos los peones
            for (int x = 0; x < 8; x++)
                casillas[fila, x].pieza = new Pieza(TipoPieza.Peon, color);
        }
    }

    struct TableroAnterior
    {
        public Pieza piezaDerrotada { get; private set; }
        public MovimientoDePieza movimiento { get; private set; }
        public Pieza pieza { get; private set; }
        public Localizacion localizacionAnterior { get; private set; }
        public int movimientoIndex;
        public TableroAnterior(Pieza pieza, int movimientoIndex, Localizacion localizacionAnterior, MovimientoDePieza movimiento)
        {
            this.pieza = pieza;
            this.movimientoIndex = movimientoIndex;
            this.localizacionAnterior = localizacionAnterior;
            piezaDerrotada = new Pieza(TipoPieza.Vacio);
            this.movimiento = movimiento;
        }
        public TableroAnterior(Pieza pieza, Localizacion localizacion, MovimientoDePieza movimiento, Pieza piezaDerrotada, int movimientoIndex) : this(pieza, movimientoIndex, localizacion, movimiento)
        {
            this.piezaDerrotada = piezaDerrotada;
        }
    }
}
