using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using Chessir.gui;

namespace Chessir.ajedrez{
    public enum ColorPieza { BLANCO , NEGRO , NINGUNO }
    public partial class Tile : UserControl{
        public Pieza pieza = new Pieza(TipoPieza.Vacio); //pieza vacía
        public ColorPieza color = ColorPieza.BLANCO;
        public Localizacion localizacion = new Localizacion();
        public ColorPieza casillaAtaque = ColorPieza.NINGUNO;
        public void setAtaque(Pieza ataquePieza){ casillaAtaque = ataquePieza.color; }
        public void borrarAtaque() { casillaAtaque = ColorPieza.NINGUNO; }
        public void PrintTileInfo(){
            Debug.Print("Y:" + getY + " X:" + getX + " TileAttack:" + casillaAtaque.ToString());
        }
        public byte getY { get { return localizacion.y; } }
        public byte getX { get { return localizacion.x; } }
        public bool estaOcupada() => pieza.tipopieza != TipoPieza.Vacio;
        public Tile(byte y , byte x) {
            InitializeComponent();
            
            localizacion.y = y ; localizacion.x = x;

            //posición en la que empezará a dibujar casillas
            int comienzoX = 160;
            int comienzoY = 7;

            Location = new Point(comienzoX + localizacion.x * Size.Width, comienzoY + localizacion.y * Size.Height);
        }
        public Tile(byte y, byte x, ColorPieza color):this(y,x) { this.color = color; }
        public Color TileColor() => color != ColorPieza.BLANCO ? Color.FromArgb(111, 145, 111) : Color.FromArgb(214, 206, 178);
        public void asignarPieza(Pieza pieza){
            this.pieza = pieza;
            ImagenPieza.BackgroundImage = ImagenesPiezas[pieza.getNombreImagen()]; 
        }
        private void Tile_Load(object sender, EventArgs e){
            this.ImagenPieza.BackColor = TileColor();
            this.BackColor = TileColor();
            this.Click += TileClicked;
            this.ImagenPieza.Click += TileClicked;
        }
        static int click = 0;
        static Movimiento movimientosPieza;
        public void movimientoPosible(bool mostrar){
            if (!mostrar) ImagenPieza.Image = null;
            else ImagenPieza.Image = Properties.Resources.Movimiento_Posible;
        }
        private void TileClicked(object sender, EventArgs e){
            if (click == 0 && this.pieza.color != Tablero.jugadorActual) return;
            click++;
            if (click == 1){
                movimientosPieza = new Movimiento(this);
                movimientosPieza.estaElReyASalvo();
                movimientosPieza.interfazMovimientos(true);
            }
            else{
                movimientosPieza.esMovimientoDisponible(this);
                click = 0;
            }
        }
        public static Dictionary<string, Image> ImagenesPiezas = new Dictionary<string, Image> {
            { "NAlfil",Properties.Resources.Alfil_Negro},
            { "NCaballo",Properties.Resources.Caballo_Negro},
            { "NTorre",Properties.Resources.Torre_Negra},
            { "NRey",Properties.Resources.Rey_Negro},
            { "NReina",Properties.Resources.Reina_Negra},
            { "NPeon",Properties.Resources.Peon_Negro},
            { "BAlfil",Properties.Resources.Alfil_Blanco},
            { "BCaballo",Properties.Resources.Caballo_Blanco},
            { "BTorre",Properties.Resources.Torre_Blanca},
            { "BRey",Properties.Resources.Rey_Blanco},
            { "BReina",Properties.Resources.Reina_Blanca},
            { "BPeon",Properties.Resources.Peon_Blanco},
            { "Vacio",null }
        };
    }
    public struct Localizacion{
        public byte y, x;
    }
}