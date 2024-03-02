using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessir.ajedrez
{
    public enum TipoPieza { Peon, Torre, Caballo, Alfil, Reina, Rey, Vacio }
    public struct Pieza
    {
        public bool primerMovimiento {  get; set; } //determina si es el primer movimiento de un peón
        public bool mueveDosCasillas;
        public TipoPieza tipopieza { get; private set; }
        public ColorPieza color;
        private Tile[] casillasAtaque;

        public Pieza(TipoPieza tipopieza = TipoPieza.Vacio, ColorPieza color = ColorPieza.NINGUNO,
            bool mueveDosCasillas = false, bool primerMovimiento = false)
        {
            casillasAtaque = new Tile[32];
            this.primerMovimiento = true;
            this.mueveDosCasillas = mueveDosCasillas;
            this.tipopieza = tipopieza;
            this.color = color;

            if (tipopieza == TipoPieza.Vacio)
                this.primerMovimiento = primerMovimiento;
        }

        //método para el cambio de pieza cuando el peon llega al final del tablero
        public Pieza(string pieza, Tile casilla):this(TipoPieza.Reina)
        {
            //dependiendo de la primera letra del archivo de imagen (N negro)
            color = pieza.First() == 'N' ? ColorPieza.NEGRO : ColorPieza.BLANCO;
            pieza = pieza.Remove(0, 1); //ignora la primera letra del archivo de imagen

            switch (pieza)
            {
                case "Reina":
                    tipopieza = TipoPieza.Reina; break;
                case "Alfil":
                    tipopieza = TipoPieza.Alfil; break;
                case "Caballo":
                    tipopieza = TipoPieza.Caballo; break;
                case "Torre":
                    tipopieza = TipoPieza.Torre; break;
            }
            casilla.ImagenPieza.BackgroundImage = Tile.ImagenesPiezas[getNombreImagen()];
        }

        void ataque(Tile piezaCasilla)
        {
            Movimiento movimiento = new Movimiento(piezaCasilla);
            casillasAtaque = new Tile[movimiento.movimientosDisponibles.Length];

            for (int i = 0;i<movimiento.movimientosDisponibles.Length;i++)
            {
                if (movimiento.movimientosDisponibles[i] == null)
                    continue;
                if (piezaCasilla.pieza.tipopieza == TipoPieza.Peon)
                    if (i == 0 || i == 1)
                        continue;
                Tablero.casillas[(int)movimiento.movimientosDisponibles[i]?.y, (int)movimiento.movimientosDisponibles[i]?.x].setAtaque(piezaCasilla.pieza);
                casillasAtaque[i] = Tablero.casillas[(int)movimiento.movimientosDisponibles[i]?.y, (int)movimiento.movimientosDisponibles[i]?.x];
            }
        }

        public static void borrarAtaqueAnterior()
        {
            for (int x = 0; x < 8; x++)
                for (int y = 0; y < 8; y++)
                    Tablero.casillas[y, x].borrarAtaque();
        }

        public static void actualizarAtaques()
        {
            borrarAtaqueAnterior();

            for (int x = 0; x < 8; x++)
                for (int y = 0; y < 8; y++)
                    if (Tablero.casillas[y, x].estaOcupada() && Tablero.casillas[y, x].pieza.color != Tablero.jugadorActual)
                        Tablero.casillas[y, x].pieza.ataque(Tablero.casillas[y, x]);
        }

        public string getNombreImagen()
        {
            string nombre = "";

            if (color != ColorPieza.NINGUNO)
                nombre = color == ColorPieza.NEGRO ? nombre = "N" : nombre = "B";

            return nombre + tipopieza.ToString(); //devuelve la pieza con la letra del color al principio
        }
    }
}
