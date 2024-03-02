using Chessir.gui;
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

namespace Chessir
{
    public partial class FormInicial : Form
    {
        //variables que se reciben de la pantalla de login
        private string username;
        private Boolean es_admin = false; //determina si se tienen permisos especiales
        private int id_usuario = 0;

        public string getUsername() { return username; }

        //datos a enviar a formJugar
        private string username_Negro = "";
        private int id_Negro = 0, tiempo = 0, incremento = 0;
        public FormInicial()
        {
            InitializeComponent();
            this.Show();
            FormLogin formLogin =  new FormLogin();
            formLogin.ShowDialog();

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

        //función que asigna el usuario a la aplicación, si es admin o no y recibe su ID
        public void recibirDatosDeLogin(string nuevo_username, Boolean es_admin, int id_usuario)
        {
            this.username = nuevo_username;
            this.es_admin = es_admin;
            this.id_usuario = id_usuario;
            labelUsuarioSuperior.Text = "Usuario: " + nuevo_username;
            if (es_admin)
                mostrarBotonesAdmin();
            else
                mostrarBotonesUsuario();

            abrirFormEnPanel(new FormInicio(nuevo_username));
        }

        //función que asigna el usuario al jugador negro, si es admin o no y recibe su ID
        public void recibirDatosPartida(string username_Negro, int id_Negro, int tiempo, int incremento)
        {
            this.username_Negro = username_Negro;
            this.id_Negro = id_Negro;
            this.tiempo = tiempo; this.incremento = incremento;
        }

        //función que hace visibles las funciones para usuarios administradores
        private void mostrarBotonesAdmin()
        {
            buttonInicio.Visible = true; buttonGestion.Visible = true; buttonJugar.Visible = true;
            buttonRepeticiones.Visible = true; buttonSalir.Visible = true;
        }

        //función que hace visibles las funciones para usuarios normales
        private void mostrarBotonesUsuario()
        {
            buttonInicio.Visible = true; buttonPerfil.Visible = true; buttonJugar.Visible = true;
            buttonRepeticiones.Visible = true; buttonSalir.Visible = true;
        }

        //función que inicia un form en el panel contenedor
        public void abrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBoxMaximizar.Visible = false;
            pictureBoxRestaurar.Visible = true;
        }

        private void pictureBoxRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBoxMaximizar.Visible = true;
            pictureBoxRestaurar.Visible = false;
        }

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonGestion_Click(object sender, EventArgs e)
        {
            abrirFormEnPanel(new FormGestion(id_usuario));
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            abrirFormEnPanel(new FormInicio(username));
        }

        private void buttonRepeticiones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función por implementar.", "No disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir del programa?",
                "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
                Application.Exit();
        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            FormJugarInicio formJI = new FormJugarInicio();
            formJI.ShowDialog();
            if (!formJI.getCierre())
                abrirFormEnPanel(new FormJugar(id_usuario, username, id_Negro, username_Negro, tiempo, incremento));
        }
    }
}
