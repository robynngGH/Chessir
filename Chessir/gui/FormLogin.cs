using Chessir.dao;
using Chessir.dto;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Chessir.gui
{
    public partial class FormLogin : Form
    {
        public FormLogin()
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
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DTOUsuario dtoUsuario = new DTOUsuario();
            DAOUsuario daoUsuario = new DAOUsuario();
            DAOLog daoLog = new DAOLog(); //para registrar el acceso

            int resultado = daoUsuario.comprobarLogin(textBoxUsername.Text, textBoxPassword.Text); //recibimos el tipo de login

            if (resultado == 2)
            {
                MessageBox.Show("¡Bienvenido/a, " + textBoxUsername.Text + "! (Admin)");

                //se asegura de que FormInicial está abierto
                FormInicial formInicial = Application.OpenForms.OfType<FormInicial>().FirstOrDefault();
                int id_usuario = daoUsuario.recibirIDUsuario(textBoxUsername.Text); //recibimos el ID del usuario para uso en el FormInicial

                if (formInicial != null)
                    formInicial.recibirDatosDeLogin(textBoxUsername.Text, true, id_usuario); //pasa los datos de login con admin al FormInicial

                daoLog.registrarLog(id_usuario, true); //registra el log

                this.Hide(); //cierra el form de login

            }
            else if (resultado == 1)
            {
                MessageBox.Show("¡Bienvenido/a, " + textBoxUsername.Text + "!");

                FormInicial formInicial = Application.OpenForms.OfType<FormInicial>().FirstOrDefault();
                int id_usuario = daoUsuario.recibirIDUsuario(textBoxUsername.Text);

                if (formInicial != null)
                    formInicial.recibirDatosDeLogin(textBoxUsername.Text, false, id_usuario); //pasa los datos de login sin privilegios al FormInicial

                daoLog.registrarLog(id_usuario, true);

                this.Hide(); //cierra el form de login
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos, o usuario inactivo. Por favor, inténtalo de nuevo.", "Login incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
