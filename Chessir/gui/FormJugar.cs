using Chessir.ajedrez;
using System;
using System.Windows.Forms;

namespace Chessir.gui
{
    public partial class FormJugar : Form
    {
        private int turno = 1;
        int tiempo = 0, incremento = 0;
        int id_Blanco = 0, id_Negro = 0;
        String username_Blanco = "", username_Negro = "";
        int id_partida = 0; //lo recibirá del form de inicio de partida
        private string modo_juego = "";

        public void recibirIDPartida(int id_partida) { this.id_partida = id_partida; }

        private void FormJugar_Load(object sender, EventArgs e)
        {
            tablero = new Tablero(this);
            Tablero.jugadorActual = ColorPieza.BLANCO;
        }
        public FormJugar() { }
        public FormJugar(int id_partida, int id_Blanco, string username_Blanco, int id_Negro, string username_Negro, int tiempo, int incremento) //recibe los valores del form inicial (quien usa la aplicación en primer plano)
        {
            this.id_partida = id_partida;
            this.id_Blanco = id_Blanco; this.id_Negro = id_Negro;
            this.username_Blanco = username_Blanco; this.username_Negro = username_Negro;
            this.tiempo = tiempo; this.incremento = incremento;
            InitializeComponent();
            labelJugadorBlanco.Text = username_Blanco;
            timerBlanco.tiempo = tiempo; timerNegro.tiempo = tiempo; //tiempo disponible para jugar e incremento de tiempo en segundos por jugada realizada
            timerBlanco.incremento = incremento; timerNegro.incremento = incremento;
            timerBlanco.Text = (tiempo / 60).ToString() + ":00"; timerNegro.Text = (tiempo / 60).ToString() + ":00"; //muestra minutos inicialmente
            labelJugadorNegro.Text = username_Negro;
            timerBlanco.codigoExt = new EventHandler(derrotaBlanco);
            timerNegro.codigoExt = new EventHandler(derrotaNegro);
            timerBlanco.Iniciar();

            //para pasar el modo de juego en caso de revancha
            if (tiempo == 1800) modo_juego = "Clásico";
            else if (tiempo == 900) modo_juego = "Acelerado";
            else if (tiempo == 600) modo_juego = "Rápido";
            else if (tiempo == 300) modo_juego = "Blitz";
            else if (tiempo == 120) modo_juego = "Bullet";
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
            FormFinalPartida formFinalPartida = new FormFinalPartida(id_partida, id_Negro, username_Negro, motivo, "NRey");
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
            FormFinalPartida formFinalPartida = new FormFinalPartida(id_partida, id_Blanco, username_Blanco, motivo, "BRey");
            formFinalPartida.ShowDialog();
        }

        private void buttonRendirseN_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea rendirse?",
                username_Negro, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
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
        public int getTurno() { return turno; }

        //termina la partida sin ganador si no se encuentra una forma de ganar
        private void buttonTablas_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Aceptas la proposición de tablas?",
                "Tablas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                labelEstadoPartida.Text = "TABLAS";
                timerBlanco.Pausar(); timerNegro.Pausar(); //no causa la derrota de ninguno
                FormFinalPartida formFinalPartida = new FormFinalPartida(id_partida, 0, null, "Tablas", "Tablas");
                formFinalPartida.ShowDialog();
            }
        }

        public void setTurno(int turno) { this.turno = turno; }
        public int getIDPartida() { return id_partida; }
        public string getModoJuego() { return modo_juego; }
    }
}
