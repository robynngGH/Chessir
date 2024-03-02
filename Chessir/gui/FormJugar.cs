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
    public partial class FormJugar : Form
    {
        int tiempo = 0, incremento = 0;
        int id_Blanco = 0, id_Negro = 0;
        String username_Blanco = "", username_Negro = "";

        private void FormJugar_Load(object sender, EventArgs e)
        {
            tablero = new Tablero(this);
            Tablero.jugadorActual = ColorPieza.BLANCO;
        }
        public FormJugar() { }
        public FormJugar(int id_Blanco, string username_Blanco, int id_Negro, string username_Negro, int tiempo, int incremento) //recibe los valores del form inicial (quien usa la aplicación en primer plano)
        {
            this.id_Blanco=id_Blanco; this.id_Negro = id_Negro;
            this.username_Blanco=username_Blanco; this.username_Negro = username_Negro;
            this.tiempo=tiempo; this.incremento=incremento;
            InitializeComponent();
            labelJugadorBlanco.Text = username_Blanco;
            timerBlanco.tiempo = tiempo; timerNegro.tiempo = tiempo; //tiempo disponible para jugar e incremento de tiempo en segundos por jugada realizada
            timerBlanco.incremento = incremento; timerNegro.incremento = incremento;
            timerBlanco.Text = (tiempo / 60).ToString() + ":00"; timerNegro.Text = (tiempo / 60).ToString() + ":00"; //muestra minutos inicialmente
            labelJugadorNegro.Text = username_Negro;
            timerBlanco.codigoExt = new EventHandler(derrotaBlanco);
            timerNegro.codigoExt = new EventHandler(derrotaNegro);
            timerBlanco.Iniciar();
        }
        Tablero tablero;

        //función para acabar la partida por timeout del jugador blanco
        private void derrotaBlanco(object Sender, EventArgs e)
        {
            string motivo = "";
            if (labelEstadoPartida.Text.Equals("JAQUE MATE"))
                motivo = "Jaque mate";
            else if (labelEstadoPartida.Text.Equals("RENDICIÓN"))
                motivo = "Rendición";
            else motivo = "Timeout";
            FormFinalPartida formFinalPartida = new FormFinalPartida(id_Negro, username_Negro, motivo, "NRey");
            formFinalPartida.ShowDialog();
        }
        //función para acabar la partida por timeout del jugador blanco
        private void derrotaNegro(object Sender, EventArgs e)
        {
            string motivo = "";
            if (labelEstadoPartida.Text.Equals("JAQUE MATE"))
                motivo = "Jaque mate";
            else if (labelEstadoPartida.Text.Equals("RENDICIÓN"))
                motivo = "Rendición";
            else motivo = "Timeout";
            FormFinalPartida formFinalPartida = new FormFinalPartida(id_Blanco, username_Blanco, motivo, "BRey");
            formFinalPartida.ShowDialog();
        }

        private void buttonRendirseN_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea rendirse?",
                username_Negro, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resultado == DialogResult.Yes)
            {
                labelEstadoPartida.Text = "RENDICIÓN";
                Tablero.Window.labelEstadoPartida.ForeColor = System.Drawing.Color.Firebrick;
                timerNegro.Parar(); timerBlanco.Pausar(); //el reloj parado envía un mensaje de derrota para su jugador
            }
        }

        private void buttonRendirseB_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea rendirse?",
                username_Blanco, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                labelEstadoPartida.Text = "RENDICIÓN";
                Tablero.Window.labelEstadoPartida.ForeColor = System.Drawing.Color.Firebrick;
                timerBlanco.Parar(); timerNegro.Pausar();
            }           
        }

        public int getId_Blanco()
        {
            return id_Blanco;
        }
        public int getId_Negro()
        {
            return id_Negro;
        }
        public string getUsername_Blanco()
        {
            return username_Blanco;
        }
        public string getUsername_Negro()
        {
            return username_Negro;
        }
        public int getTiempo() { return tiempo; }
        public int getIncremento() { return incremento; }
    }
}
