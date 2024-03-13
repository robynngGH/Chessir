using Chessir.dao;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Chessir.gui
{
    public partial class FormPerfil : Form
    {
        int id_usuario = 0; string username = "";
        DAOEstadistica daoEstadistica = new DAOEstadistica(); //para colocar sus stats en su perfil
        int num_partidas = 0, num_victorias = 0, num_derrotas = 0, num_tablas = 0;
        double winrate = 0;
        public FormPerfil(int id_usuario, string username)
        {
            this.id_usuario = id_usuario;
            this.username = username;
            InitializeComponent();
            labelUsername.Text = username;
            num_partidas = daoEstadistica.getNumPartidas(id_usuario);
            num_victorias = daoEstadistica.getVictorias(id_usuario);
            num_derrotas = daoEstadistica.getDerrotas(id_usuario);
            num_tablas = daoEstadistica.getTablas(id_usuario);
            labelNumPartidas.Text = num_partidas.ToString();
            labelVictorias.Text = num_victorias.ToString();
            labelDerrotas.Text = num_derrotas.ToString();
            labelTablas.Text = num_tablas.ToString();
            winrate = Math.Round(((double)num_victorias / (num_partidas - num_tablas)) * 100, 1);
            labelWinrate.Text = winrate.ToString() + "%";
            labelModoFavorito.Text = recibirModoJuegoFavorito();
        }

        private string recibirModoJuegoFavorito()
        {
            //array para recibir los COUNT de cada modo de juego
            int[] counts = new int[]
            {
                daoEstadistica.getCountModoJuego(id_usuario, "Clásico"),
                daoEstadistica.getCountModoJuego(id_usuario, "Acelerado"),
                daoEstadistica.getCountModoJuego(id_usuario, "Rápido"),
                daoEstadistica.getCountModoJuego(id_usuario, "Blitz"),
                daoEstadistica.getCountModoJuego(id_usuario, "Bullet")
            };
            int mayor = counts.Max();
            int indiceMayor = Array.IndexOf(counts, mayor);

            string[] modos_juego = new string[] { "Clásico", "Acelerado", "Rápido", "Blitz", "Bullet" };
            string modo_favorito = modos_juego[indiceMayor];

            return modo_favorito;
        }

        private void buttonAyuda_Click(object sender, EventArgs e)
        {
            FormInicial fi = Application.OpenForms.OfType<FormInicial>().FirstOrDefault(); //para llamar a funciones del form que abarca todo
            fi.abrirFormEnPanel(new FormAyuda());
        }
    }
}
