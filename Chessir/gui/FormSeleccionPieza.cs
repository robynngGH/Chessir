using Chessir.ajedrez;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        Tile casillaPulsada; int posicion = 0; ColorPieza jugadorEnEspera;
        public static bool esperando { get; private set; } = false;
        string[] piezas = { "NReina", "NAlfil", "NTorre", "NCaballo" };

        //recibe la casilla pulsada como parámetro para saber qué color ha llegado a la otra punta del tablero
        public FormSeleccionPieza(Tile casillaPulsada):this()
        {
            esperando = true;
            jugadorEnEspera = Tablero.jugadorActual == ColorPieza.BLANCO ? ColorPieza.NEGRO : ColorPieza.BLANCO;
            Tablero.jugadorActual = ColorPieza.NINGUNO;
            this.casillaPulsada = casillaPulsada;
            
            //en el caso de que el jugador que selecciona pieza sea el blanco
            if (casillaPulsada.getY == 0)
                for (int i = 0; i < piezas.Length; i++)
                {
                    piezas[i] = piezas[i].Remove(0, 1);
                    piezas[i] = 'B' + piezas[i]; //elimina la primera letra (N) y pone B en su lugar (Blanco)
                }
            pictureBoxPieza.Image = Tile.ImagenesPiezas[piezas[posicion]]; //asigna la imagen desde el diccionario de recursos
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
            busqueda.jaqueMate();
            base.OnClosed(e);
        }
    }
}
