using Chessir.ajedrez;
using Chessir.dao;
using Chessir.dto;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Chessir.gui
{
    public partial class FormFinalPartida : Form
    {
        FormInicial fi = Application.OpenForms.OfType<FormInicial>().FirstOrDefault(); //para llamar a funciones del form que abarca todo
        FormJugar fj = Application.OpenForms.OfType<FormJugar>().FirstOrDefault(); //para llamar a funciones del form jugar abierto
        int id_victoria = 0;
        string motivo = ""; //motivo de final de partida
        int id_partida = 0;
        public FormFinalPartida(int id_partida, int id_victoria, string user_victoria, string motivo, string imagenRey)
        {
            this.id_partida = id_partida;
            this.id_victoria = id_victoria;
            InitializeComponent();
            label1.Text = "¡Victoria para " + user_victoria + "!";
            label2.Text = "La partida ha finalizado por " + motivo.ToLower() + ".";
            pictureBoxRey.Image = Tile.ImagenesPiezas[imagenRey];

            //para añadir los datos del ganador a la partida
            DAOPartida daoPartida = new DAOPartida();
            if (motivo.Equals("Tablas"))
            {
                daoPartida.tablas(id_partida);
                label1.Text = "¡Se acabó en empate!";
            }
            else
                daoPartida.añadirGanador(id_partida, id_victoria, motivo);

            //para añadir estadísticas de victoria, derrota o tablas
            DAOEstadistica daoEstadistica = new DAOEstadistica();
            if (motivo.Equals("Tablas"))
            {
                daoEstadistica.incrementarTablas(fj.getId_Blanco());
                daoEstadistica.incrementarTablas(fj.getId_Negro());
            }
            else
            {
                if (id_victoria == fj.getId_Blanco())
                {
                    daoEstadistica.incrementarVictorias(fj.getId_Blanco());
                    daoEstadistica.incrementarDerrotas(fj.getId_Negro());
                }
                else
                {
                    daoEstadistica.incrementarVictorias(fj.getId_Negro());
                    daoEstadistica.incrementarDerrotas(fj.getId_Blanco());
                }
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            fi.abrirFormEnPanel(new FormInicio(fi.getUsername()));
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            fi.abrirFormEnPanel(new FormInicio(fi.getUsername()));
            this.Close();
        }

        //formJugar ya dispone de los datos de usuario anteriores y tiempo
        private void buttonRevancha_Click(object sender, EventArgs e)
        {
            DAOEstadistica daoEstadistica = new DAOEstadistica();
            daoEstadistica.incrementarPartidas(fj.getId_Blanco());
            daoEstadistica.incrementarPartidas(fj.getId_Negro());
            DAOPartida daoPartida = new DAOPartida();
            DTOPartida dtoPartida = new DTOPartida(fj.getId_Blanco(), fj.getId_Negro(), fj.getModoJuego());
            int idNuevaPartida = daoPartida.registrarPartida(dtoPartida);
            fj = new FormJugar(idNuevaPartida, fj.getId_Blanco(), fj.getUsername_Blanco(), fj.getId_Negro(), fj.getUsername_Negro(), fj.getTiempo(), fj.getIncremento());
            fi.abrirFormEnPanel(fj);
            this.Close();
        }
        private void buttonNuevaPartida_Click(object sender, EventArgs e)
        {
            this.Close();
            FormJugarInicio formJI = new FormJugarInicio();
            formJI.ShowDialog();
            if (!formJI.getCierre())
            {
                fi.abrirFormEnPanel(new FormJugar(fi.getIDPartida(), fi.getId(), fi.getUsername(), fi.getIdNegro(), fi.getUsernameNegro(), fi.getTiempo(), fi.getIncremento()));
            }
        }
    }
}
