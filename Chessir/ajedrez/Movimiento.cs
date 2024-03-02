using Chessir.gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chessir.ajedrez
{
    public class Movimiento
    {
        //FormJugar formJugar = Application.OpenForms.OfType<FormJugar>().FirstOrDefault();
        Tile piezaCasilla;
        public MovimientoDePieza?[] movimientosDisponibles;
        MovimientoDePieza? movimientoAnterior;
        int movimiento;
        int dir { get { return piezaCasilla.pieza.color == ColorPieza.NEGRO ? 1 : -1; } }

        public Movimiento()
        {
            movimientoAnterior = new MovimientoDePieza(1, 1);
        }

        public Movimiento(Tile piezaCasilla):this()
        {
            this.piezaCasilla = piezaCasilla;
            movimientosDisponibles = Movimientos();
        }

        public bool esMovimientoDisponible(Tile casillaPulsada)
        {
            interfazMovimientos(false);
            
            //recorremos los movimientos disponibles para encontrar la casilla pulsada
            for (int i = 0;i<movimientosDisponibles.Length;i++)
            {
                if (movimientosDisponibles[i] == null)
                    continue;
                if (movimientosDisponibles[i]?.x == casillaPulsada.localizacion.x && movimientosDisponibles[i]?.y == casillaPulsada.localizacion.y)
                {
                    if (!puedeHacerMovimientoEspecial(i, casillaPulsada))
                        continue;
                    Tablero.movimientosAnteriores.Add(new TableroAnterior(piezaCasilla.pieza, piezaCasilla.localizacion, (MovimientoDePieza)movimientosDisponibles[i], casillaPulsada.pieza, i));
                    piezaCasilla.pieza.primerMovimiento = false;
                    casillaPulsada.asignarPieza(piezaCasilla.pieza);
                    piezaCasilla.asignarPieza(new Pieza(TipoPieza.Vacio));
                    if (!FormSeleccionPieza.esperando)
                    {
                        if (Tablero.jugadorActual == ColorPieza.BLANCO) { Tablero.Window.timerBlanco.Pausar(); Tablero.Window.timerNegro.Iniciar(); Tablero.Window.buttonRendirseB.Enabled = false; Tablero.Window.buttonRendirseN.Enabled = true; }
                        else { Tablero.Window.timerNegro.Pausar(); Tablero.Window.timerBlanco.Iniciar(); Tablero.Window.buttonRendirseN.Enabled = false; Tablero.Window.buttonRendirseB.Enabled = true; }
                        Tablero.jugadorActual = Tablero.jugadorActual == ColorPieza.BLANCO ? ColorPieza.NEGRO : ColorPieza.BLANCO;
                        Pieza.actualizarAtaques();
                        if (reyAtacado())
                        {
                            Tablero.Window.labelEstadoPartida.Text = "JAQUE";
                            Tablero.Window.labelEstadoPartida.ForeColor = System.Drawing.Color.Firebrick;
                            jaqueMate();
                        }
                        else
                        {
                            Tablero.Window.labelEstadoPartida.Text = "Normal";
                            Tablero.Window.labelEstadoPartida.ForeColor = System.Drawing.Color.OliveDrab;
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        public void interfazMovimientos(bool mostrar)
        {
            for (int i = 0;i<movimientosDisponibles.Length;i++)
            {
                if (movimientosDisponibles[i] == null)
                    continue;
                if (piezaCasilla.pieza.tipopieza == TipoPieza.Peon && (i == 2 && noEstaOcupada(piezaCasilla.localizacion.y + dir, piezaCasilla.localizacion.x + 1)
                    || i == 3 && noEstaOcupada(piezaCasilla.localizacion.y + dir, piezaCasilla.localizacion.x - 1)))
                    continue;
                Tablero.casillas[(int)movimientosDisponibles[i]?.y, (int)movimientosDisponibles[i]?.x].movimientoPosible(mostrar);
            }
        }

        bool puedeHacerMovimiento(int y, int x)
        {
            Pieza piezaCasillaAnterior = Tablero.casillas[y, x].pieza;
            Tablero.casillas[y, x].pieza = piezaCasilla.pieza;
            piezaCasilla.pieza = new Pieza(TipoPieza.Vacio);
            Pieza.actualizarAtaques();

            if (!reyAtacado())
            {
                piezaCasilla.pieza = Tablero.casillas[y, x].pieza;
                Tablero.casillas[y, x].pieza = piezaCasillaAnterior;
            }
            else
            {
                piezaCasilla.pieza = Tablero.casillas[y, x].pieza;
                Tablero.casillas[y, x].pieza = piezaCasillaAnterior;
                Pieza.actualizarAtaques();
                return false;
            }
            return true;
        }

        //método para los peones moviéndose dos casillas, conversión a otra pieza o enroque para el rey
        bool puedeHacerMovimientoEspecial(int movimiento, Tile casillaPulsada)
        {
            switch (piezaCasilla.pieza.tipopieza)
            {
                case TipoPieza.Peon:
                    piezaCasilla.pieza.mueveDosCasillas = movimiento == 1 ? true : false; //podrá moverse dos casillas si movimiento es 1
                    if (movimiento == 2 && noEstaOcupada(piezaCasilla.localizacion.y + dir, piezaCasilla.localizacion.x + 1))
                        return false;
                    if (movimiento == 3 && noEstaOcupada(piezaCasilla.localizacion.y + dir, piezaCasilla.localizacion.x - 1))
                        return false;
                    if (movimiento == 4 || movimiento == 5)
                    {
                        int xdir = movimiento == 4 ? 1 : -1;
                        Tablero.casillas[piezaCasilla.getY, piezaCasilla.getX + xdir].asignarPieza(new Pieza(TipoPieza.Vacio));
                        return true;
                    }
                    if ((piezaCasilla.getY == 1 && piezaCasilla.pieza.color == ColorPieza.BLANCO) || (piezaCasilla.getY == 6 && piezaCasilla.pieza.color == ColorPieza.NEGRO))
                    {
                        FormSeleccionPieza seleccionPieza = new FormSeleccionPieza(casillaPulsada);
                        seleccionPieza.Show();
                    }
                    break;

                case TipoPieza.Rey:
                    int ydir = Tablero.jugadorActual == ColorPieza.BLANCO ? 7 : 0; //dependiendo del jugador, el rey se encuentra en una punta u otra
                    void enroque(int casillaX, int piezaX)
                    {
                        Tablero.casillas[ydir, casillaX].asignarPieza(Tablero.getPieza(ydir, piezaX));
                        Tablero.casillas[ydir, piezaX].asignarPieza(new Pieza(TipoPieza.Vacio));
                    }
                    if (movimiento == 8)
                        enroque(5, 7);
                    if (movimiento == 9)
                        enroque(3, 0);
                    break;

                default: break;
            }
            return true;
        }

        //recibe una posición de casilla y devuelve si es accesible
        bool esAccesible(int y, int x) => Tablero.esAccesible(y, x);
        //recibe una posición de casilla y devuelve si está ocupada
        bool estaOcupada(int y, int x) => Tablero.casillas[y, x].estaOcupada();
        bool noEstaOcupada(int y, int x)
        {
            if (esAccesible(y, x))
                return !estaOcupada(y, x);
            return false;
        }
        //recibe la posición del tablero y devuelve si tiene un peón rival, para ayudar a manejar movimientos contra peones
        bool esPeonRival(int y, int x)
        {
            if (esAccesible(y, x))
                return estaOcupada(y, x) && Tablero.getPieza(y, x).mueveDosCasillas && esColorRival(y, x);
            else return false;
        }
        //recibe la posición del tablero y devuelve si la pieza en su lugar es del color rival
        bool esColorRival(int y, int x) => piezaCasilla.pieza.color != colorRival(y, x) && colorRival(y, x) != ColorPieza.NINGUNO;
        //recibe la posición del tablero y devuelve el color del rival (tipo enum)
        ColorPieza colorRival(int y, int x) => Tablero.casillas[y, x].pieza.color;

        //métodos para comprobar si hay posibilidad de jaque
        public bool reyAtacado() => Tablero.getCasilla(TipoPieza.Rey, Tablero.jugadorActual).casillaAtaque != ColorPieza.NINGUNO;
        public bool jaqueMate()
        {
            List<Tile> piezaCasillas = Tablero.getCasillasConPiezas(Tablero.jugadorActual);

            for (int i = 0; i < piezaCasillas.Count;i++)
            {
                piezaCasilla = piezaCasillas[i];
                movimientosDisponibles = Movimientos();
                if (estaElReyASalvo())
                    return false;
            }
            Tablero.Window.labelEstadoPartida.Text = "JAQUE MATE";
            Tablero.Window.labelEstadoPartida.ForeColor = System.Drawing.Color.Firebrick;
            if (Tablero.jugadorActual == ColorPieza.BLANCO)
            {
                Tablero.Window.timerBlanco.Parar(); //lleva a la derrota
                Tablero.Window.timerNegro.Pausar();
            }                
            else
            {
                Tablero.Window.timerNegro.Parar(); //lleva a la derrota
                Tablero.Window.timerBlanco.Pausar();
            }
            /**if (Tablero.jugadorActual == ColorPieza.BLANCO)
            {
                FormFinalPartida formFP = new FormFinalPartida(formJugar.getId_Negro(), formJugar.getUsername_Negro(), "Jaque mate", "NRey");
                formFP.ShowDialog();
            }
            else
            {
                FormFinalPartida formFP = new FormFinalPartida(formJugar.getId_Blanco(), formJugar.getUsername_Blanco(), "Jaque mate", "BRey");
                formFP.ShowDialog();
            }*/
            return true;
        }
        public bool estaElReyASalvo()
        {
            for (int i = 0;i<movimientosDisponibles.Length;i++)
            {
                if (movimientosDisponibles[i] == null)
                    continue;
                if (!puedeHacerMovimiento((int)movimientosDisponibles[i]?.y, (int)movimientosDisponibles[i]?.x))
                    movimientosDisponibles[i] = null;
            }

            for (int i = 0; i < movimientosDisponibles.Length; i++)
                if (movimientosDisponibles[i].HasValue)
                    return true; //existe alguna forma de evitar el jaque mate
            return false;
        }

        MovimientoDePieza?[] Movimientos()
        {
            MovimientoDePieza?[] movimientos = new MovimientoDePieza?[8];
            movimiento = 0;

            //se ofrecen movimientos dependiendo del tipo de pieza
            switch (piezaCasilla.pieza.tipopieza)
            {
                case TipoPieza.Alfil:
                    movimientos = new MovimientoDePieza?[32];
                    movimientoLineal(movimientos, false); //con false se asignan movimientos diagonales únicamente
                    break;
                case TipoPieza.Caballo:
                    //movimientos en L
                    movimientos[0] = destino(2, -1);
                    movimientos[1] = destino(2, 1);
                    movimientos[2] = destino(-2, 1);
                    movimientos[3] = destino(-2, -1);
                    movimientos[4] = destino(1, -2);
                    movimientos[5] = destino(1, 2);
                    movimientos[6] = destino(-1, -2);
                    movimientos[7] = destino(-1, 2);
                    break;
                case TipoPieza.Torre:
                    movimientos = new MovimientoDePieza?[32];
                    movimientoLineal(movimientos, true); //se asignan solo movimientos rectos a la torre
                    break;
                case TipoPieza.Reina:
                    movimientos = new MovimientoDePieza?[64];
                    movimientoLineal(movimientos, false);
                    movimientoAnterior = new MovimientoDePieza(1, 1);
                    movimientoLineal(movimientos, true); //se asignan tanto movimientos diagonales como rectos para la reina
                    break;
                case TipoPieza.Rey:
                    //movimientos de una casilla hacia cualquier dirección
                    movimientos = new MovimientoDePieza?[10];
                    movimientos[0] = destino(1, -1);
                    movimientos[1] = destino(1, 1);
                    movimientos[2] = destino(-1, 1);
                    movimientos[3] = destino(-1, -1);
                    movimientos[4] = destino(1, 0);
                    movimientos[5] = destino(-1, 0);
                    movimientos[6] = destino(0, -1);
                    movimientos[7] = destino(0, 1);
                    bool puedeEnrocarse(int dir) //comprueba si el enroque es posible
                    {
                        int rango = dir == 1 ? 3 : 4;
                        for (int i = 1;i<rango;i++)
                        {
                            if (estaOcupada(piezaCasilla.getY, piezaCasilla.getX + i * dir) ||
                                (Tablero.casillas[piezaCasilla.getY, piezaCasilla.getX + i * dir].casillaAtaque != ColorPieza.NINGUNO))
                                return false;
                        }
                        return true;
                    }
                    if (piezaCasilla.pieza.primerMovimiento && Tablero.getPieza(piezaCasilla.getY, piezaCasilla.getX + 3).primerMovimiento)
                        movimientos[8] = puedeEnrocarse(1) ? destino(0, 2) : null; //para el enroque derecho
                    if (piezaCasilla.pieza.primerMovimiento && Tablero.getPieza(piezaCasilla.getY, piezaCasilla.getX - 4).primerMovimiento)
                        movimientos[9] = puedeEnrocarse(-1) ? destino(0, -2) : null; //para el enroque izquierdo
                    break;
                case TipoPieza.Peon:
                    movimientos = new MovimientoDePieza?[6];
                    movimientos[0] = noEstaOcupada(piezaCasilla.localizacion.y+1*dir, piezaCasilla.localizacion.x) ? destino(1 * dir, 0) : movimientoAnterior = null;
                    if (movimientoAnterior != null) //para el primer movimiento del peón
                        movimientos[1] = noEstaOcupada(piezaCasilla.getY + 2 * dir, piezaCasilla.getX) && piezaCasilla.pieza.primerMovimiento ? destino(2 * dir, 0) : null;
                    movimientos[2] = destino(dir, 1);
                    movimientos[3] = destino(dir, -1);
                    //para el caso de que se pueda comer una ficha
                    movimientos[4] = esPeonRival(piezaCasilla.getY, piezaCasilla.getX+1) && !estaOcupada(piezaCasilla.getY+dir, piezaCasilla.getX+1) ? destino(dir, 1) : null;
                    movimientos[5] = esPeonRival(piezaCasilla.getY, piezaCasilla.getX - 1) && !estaOcupada(piezaCasilla.getY+dir, piezaCasilla.getX-1) ? destino(dir, -1) : null;
                    break;
            }
            return movimientos;
        }

        MovimientoDePieza? destinoLineal(int y, int x)
        {
            if (movimientoAnterior == null)
                return null;
            return destino(y, x);
        }

        //método para asignar movimientos a piezas como el rey o el caballo
        MovimientoDePieza? destino(int y , int x)
        {
            int yLocalizacion = piezaCasilla.localizacion.y + y;
            int xLocalizacion = piezaCasilla.localizacion.x + x;
            movimiento++;

            if (esAccesible(yLocalizacion, xLocalizacion))
            {
                if (estaOcupada(yLocalizacion, xLocalizacion) && piezaCasilla.pieza.color != colorRival(yLocalizacion, xLocalizacion))
                {
                    movimientoAnterior = null;
                    return new MovimientoDePieza(yLocalizacion, xLocalizacion);
                }
                if (estaOcupada(yLocalizacion, xLocalizacion))
                    return movimientoAnterior = null;

                return movimientoAnterior = new MovimientoDePieza(yLocalizacion, xLocalizacion);
            }
            else return movimientoAnterior = null;
        }

        //método para asignar movimientos a piezas como la torre, la reina o el alfil
        void movimientoLineal(MovimientoDePieza?[] movimientos, bool lineaRecta)
        {
            int torreDir = lineaRecta ? 0 : 1;
            int alfilDir = lineaRecta ? 1 : -1;
            
            for (int i = 1;i<9;i++)
                movimientos[movimiento] = destinoLineal(-i, i*alfilDir*torreDir);

            movimientoAnterior = new MovimientoDePieza(1, 1);
            for (int i = 1; i < 9; i++)
                movimientos[movimiento] = destinoLineal(i, i * torreDir);

            movimientoAnterior = new MovimientoDePieza(1, 1);
            for (int i = 1; i < 9; i++)
                movimientos[movimiento] = destinoLineal(i * torreDir, -i);

            movimientoAnterior = new MovimientoDePieza(1, 1);
            for (int i = 1; i < 9; i++)
                movimientos[movimiento] = destinoLineal(i * alfilDir * torreDir, i);
        }

    }

    public struct MovimientoDePieza
    {
        public int y, x;
        public MovimientoDePieza(int y, int x) {
            this.y = y;
            this.x = x;
        }
    }
}
