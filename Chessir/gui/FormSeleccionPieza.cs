using Chessir.ajedrez;
using Chessir.dao;
using Chessir.dto;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Chessir.gui
{
    public partial class FormSeleccionPieza : Form
    {
        private FormSeleccionPieza()
        {
            InitializeComponent();
            buttonDerecha.Click += buttonClick;
            buttonIzquierda.Click += buttonClick;
            buttonAceptar.Click += buttonClick;
        }

        FormJugar fj = Application.OpenForms.OfType<FormJugar>().FirstOrDefault();

        Tile casillaPulsada; int posicion = 0; ColorPieza jugadorEnEspera;
        Tile piezaCasilla;
        public static bool esperando { get; private set; } = false;
        string[] piezas = { "NReina", "NAlfil", "NTorre", "NCaballo" };
        string pieza_seleccionada = null;
        int id_jugador_anterior;
        string pieza_comida = "";

        public string getPiezaSeleccionada() { return pieza_seleccionada; }

        //recibe la casilla pulsada como parámetro para saber qué color ha llegado a la otra punta del tablero
        public FormSeleccionPieza(Tile casillaPulsada) : this()
        {
            esperando = true;
            jugadorEnEspera = Tablero.jugadorActual == ColorPieza.BLANCO ? ColorPieza.NEGRO : ColorPieza.BLANCO;
            id_jugador_anterior = Tablero.jugadorActual == ColorPieza.BLANCO ? fj.getId_Blanco() : fj.getId_Negro();
            Tablero.jugadorActual = ColorPieza.NINGUNO;
            this.casillaPulsada = casillaPulsada;
            this.pieza_comida = casillaPulsada.pieza.tipopieza.ToString();

            //en el caso de que el jugador que selecciona pieza sea el blanco
            if (casillaPulsada.getY == 0)
                for (int i = 0; i < piezas.Length; i++)
                {
                    piezas[i] = piezas[i].Remove(0, 1);
                    piezas[i] = 'B' + piezas[i]; //elimina la primera letra (N) y pone B en su lugar (Blanco)
                }
            pictureBoxPieza.Image = Tile.ImagenesPiezas[piezas[posicion]]; //asigna la imagen desde el diccionario de recursos
        }

        public void recibeDeMovimiento(Tile piezaCasilla)
        {
            this.piezaCasilla = piezaCasilla;
        }

        //método para gestionar clicks de múltiples botones
        public void buttonClick(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "buttonDerecha":
                    posicion++; break;
                case "buttonIzquierda":
                    posicion--; break;
                default:
                    pieza_seleccionada = piezas[posicion];
                    DAOTurno daoTurno = new DAOTurno();
                    daoTurno.registrarTurno(haceDTO());
                    this.Close(); //botón de Aceptar cierra
                    break;
            }
            //resetea la posición del array piezas al llegar al principio o final
            if (posicion < 0)
                posicion = piezas.Length - 1;
            if (posicion > piezas.Length - 1)
                posicion = 0;
            pictureBoxPieza.Image = Tile.ImagenesPiezas[piezas[posicion]]; //asigna la imagen desde el diccionario de recursos
        }

        private DTOTurno haceDTO()
        {
            //caso especial DAO
            //para localizar la primera letra de casilla (A4, D6, C7...)
            string casilla_origen = "";
            switch (piezaCasilla.localizacion.x)
            {
                case 0: casilla_origen = "A"; break;
                case 1: casilla_origen = "B"; break;
                case 2: casilla_origen = "C"; break;
                case 3: casilla_origen = "D"; break;
                case 4: casilla_origen = "E"; break;
                case 5: casilla_origen = "F"; break;
                case 6: casilla_origen = "G"; break;
                case 7: casilla_origen = "H"; break;
                default: break;
            }
            switch (piezaCasilla.localizacion.y)
            {
                case 0: casilla_origen = casilla_origen + "8"; break;
                case 1: casilla_origen = casilla_origen + "7"; break;
                case 2: casilla_origen = casilla_origen + "6"; break;
                case 3: casilla_origen = casilla_origen + "5"; break;
                case 4: casilla_origen = casilla_origen + "4"; break;
                case 5: casilla_origen = casilla_origen + "3"; break;
                case 6: casilla_origen = casilla_origen + "2"; break;
                case 7: casilla_origen = casilla_origen + "1"; break;
                default: break;
            }

            string casilla_destino = "";
            switch (casillaPulsada.localizacion.x)
            {
                case 0: casilla_destino = "A"; break;
                case 1: casilla_destino = "B"; break;
                case 2: casilla_destino = "C"; break;
                case 3: casilla_destino = "D"; break;
                case 4: casilla_destino = "E"; break;
                case 5: casilla_destino = "F"; break;
                case 6: casilla_destino = "G"; break;
                case 7: casilla_destino = "H"; break;
                default: break;
            }
            switch (casillaPulsada.localizacion.y)
            {
                case 0: casilla_destino = casilla_destino + "8"; break;
                case 1: casilla_destino = casilla_destino + "7"; break;
                case 2: casilla_destino = casilla_destino + "6"; break;
                case 3: casilla_destino = casilla_destino + "5"; break;
                case 4: casilla_destino = casilla_destino + "4"; break;
                case 5: casilla_destino = casilla_destino + "3"; break;
                case 6: casilla_destino = casilla_destino + "2"; break;
                case 7: casilla_destino = casilla_destino + "1"; break;
                default: break;
            }
            string peon_convertido = pieza_seleccionada; peon_convertido = peon_convertido.Remove(0, 1);

            DTOTurno dtoTurno = new DTOTurno(fj.getIDPartida(), id_jugador_anterior, fj.getTurno(), "Peon", casilla_origen, casilla_destino, pieza_comida, peon_convertido);

            return dtoTurno;
        }

        protected override void OnClosed(EventArgs e)
        {
            esperando = false;
            casillaPulsada.pieza = new Pieza(piezas[posicion], casillaPulsada);
            Tablero.jugadorActual = jugadorEnEspera;
            Pieza.actualizarAtaques();
            Movimiento busqueda = new Movimiento();

            if (busqueda.reyAtacado())
            {
                Tablero.Window.labelEstadoPartida.Text = "JAQUE";
                Tablero.Window.labelEstadoPartida.ForeColor = System.Drawing.Color.Firebrick;
                Tablero.Window.labelEstadoPartida.Visible = true;
            }
            fj.setTurno(fj.getTurno() + 1);
            if (id_jugador_anterior == fj.getId_Blanco())
            {
                Tablero.Window.timerBlanco.Pausar(); Tablero.Window.timerNegro.Iniciar();
            }
            else { Tablero.Window.timerNegro.Pausar(); Tablero.Window.timerBlanco.Iniciar(); }
            busqueda.jaqueMate();
            base.OnClosed(e);
        }
    }
}
