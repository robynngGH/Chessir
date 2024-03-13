using Chessir.dao;
using Chessir.dto;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Chessir.gui
{
    public partial class FormJugarInicio : Form
    {
        FormInicial fi = Application.OpenForms.OfType<FormInicial>().FirstOrDefault(); //para llamar a funciones del form que abarca todo
        bool cierre = false; //variable para comprobar si se ha cerrado el form
        public FormJugarInicio()
        {
            InitializeComponent();
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
            cierre = true;
            fi.abrirFormEnPanel(new FormInicio(fi.getUsername()));
            this.Close();
        }

        public bool getCierre()
        {
            return cierre;
        }

        private void buttonComenzar_Click(object sender, EventArgs e)
        {
            DTOUsuario dtoUsuario = new DTOUsuario();
            DAOUsuario daoUsuario = new DAOUsuario();
            DAOLog daoLog = new DAOLog(); //registra el acceso como jugador secundario
            DAOPartida daoPartida = new DAOPartida(); //para registrar la partida en la base de datos
            DTOPartida dtoPartida = null;
            DAOEstadistica daoEstadistica = new DAOEstadistica(); //para aumentar el número de partidas en las estadísticas de los jugadores

            int resultado = daoUsuario.comprobarLogin(textBoxUsername.Text, textBoxPassword.Text); //recibimos el tipo de login

            if ((resultado == 2 || resultado == 1) && textBoxUsername.Text != fi.getUsername()) //no comenzará partida tampoco si el usuario es el mismo que el que ha comenzado la aplicación
            {
                int tiempo = 0, incremento = 0;
                MessageBox.Show("¡Bienvenido/a, " + textBoxUsername.Text + "!");

                //se asegura de que FormJugar está abierto
                FormInicial formInicial = Application.OpenForms.OfType<FormInicial>().FirstOrDefault();
                int id_usuario = daoUsuario.recibirIDUsuario(textBoxUsername.Text); //recibimos el ID del usuario para uso en el FormJugar

                if (radioButton30_0.Checked) { tiempo = 30 * 60; incremento = 0; dtoPartida = new DTOPartida(fi.getId(), id_usuario, "Clásico"); } //clásico
                if (radioButton15_10.Checked) { tiempo = 15 * 60; incremento = 10; dtoPartida = new DTOPartida(fi.getId(), id_usuario, "Acelerado"); } //acelerado
                if (radioButton10_5.Checked) { tiempo = 10 * 60; incremento = 5; dtoPartida = new DTOPartida(fi.getId(), id_usuario, "Rápido"); } //rápido
                if (radioButton5_3.Checked) { tiempo = 5 * 60; incremento = 3; dtoPartida = new DTOPartida(fi.getId(), id_usuario, "Blitz"); } //blitz
                if (radioButton2_1.Checked) { tiempo = 2 * 60; incremento = 1; dtoPartida = new DTOPartida(fi.getId(), id_usuario, "Bullet"); } //bullet

                int id_partida = daoPartida.registrarPartida(dtoPartida);
                if (formInicial != null)
                {
                    formInicial.recibirDatosPartida(id_partida, textBoxUsername.Text, id_usuario, tiempo, incremento); //pasa los datos de login con admin al FormJugar
                }
                daoLog.registrarLog(id_usuario, false);
                daoEstadistica.incrementarPartidas(fi.getId());
                daoEstadistica.incrementarPartidas(id_usuario);

                cierre = false;
                this.Close(); //cierra el form de inicio de partida
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos, o es el mismo usuario. Por favor, inténtalo de nuevo.", "Login incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
