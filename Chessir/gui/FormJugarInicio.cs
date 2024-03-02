using Chessir.dao;
using Chessir.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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

            int resultado = daoUsuario.comprobarLogin(textBoxUsername.Text, textBoxPassword.Text); //recibimos el tipo de login

            if ((resultado == 2 || resultado == 1) && textBoxUsername.Text != fi.getUsername()) //no comenzará partida tampoco si el usuario es el mismo que el que ha comenzado la aplicación
            {
                int tiempo = 0, incremento = 0;
                MessageBox.Show("¡Bienvenido/a, " + textBoxUsername.Text + "!");

                //se asegura de que FormJugar está abierto
                FormInicial formInicial = Application.OpenForms.OfType<FormInicial>().FirstOrDefault();
                int id_usuario = daoUsuario.recibirIDUsuario(textBoxUsername.Text); //recibimos el ID del usuario para uso en el FormJugar

                if (radioButton30_0.Checked) { tiempo = 30 * 60; incremento = 0; } //clásico
                if (radioButton15_10.Checked) { tiempo = 15 * 60; incremento = 10; } //acelerado
                if (radioButton10_5.Checked) { tiempo = 10 * 60; incremento = 5; } //rápido
                if (radioButton5_3.Checked) { tiempo = 5 * 60; incremento = 3; } //blitz
                if (radioButton2_1.Checked) {  tiempo = 2 * 60; incremento = 1; } //bullet
                if (formInicial != null)
                {
                    formInicial.recibirDatosPartida(textBoxUsername.Text, id_usuario, tiempo, incremento); //pasa los datos de login con admin al FormJugar
                }
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
