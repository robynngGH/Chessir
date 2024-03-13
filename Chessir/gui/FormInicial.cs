using Chessir.gui;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Chessir
{
    public partial class FormInicial : Form
    {
        //variables que se reciben de la pantalla de login
        private string username;
        private Boolean es_admin = false; //determina si se tienen permisos especiales
        private int id_usuario = 0; private int id_partida = 0;

        public string getUsername() { return username; }
        public int getId() { return id_usuario; }

        //datos a enviar a formJugar
        private string username_Negro = "";
        private int id_Negro = 0, tiempo = 0, incremento = 0;
        public string getUsernameNegro() { return username_Negro; }
        public int getIdNegro() { return id_Negro; }
        public int getTiempo() { return tiempo; }
        public int getIncremento() { return incremento; }
        public int getIDPartida() { return id_partida; }
        public FormInicial()
        {
            InitializeComponent();
            this.Show();
            FormLogin formLogin = new FormLogin();
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
        public void recibirDatosPartida(int id_partida, string username_Negro, int id_Negro, int tiempo, int incremento)
        {
            this.id_partida = id_partida;
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
            abrirFormEnPanel(new FormInformes(es_admin));
        }

        private void buttonPerfil_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            timerCargando.Start();
            abrirFormEnPanel(new FormPerfil(id_usuario, username));
        }

        private void timerCargando_Tick(object sender, EventArgs e)
        {
            timerCargando.Start();
            Cursor = Cursors.Default;
        }

        private void buttonGenerarPartidasID_Click(object sender, EventArgs e)
        {

        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cerrar sesión?",
                "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
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
                abrirFormEnPanel(new FormJugar(id_partida, id_usuario, username, id_Negro, username_Negro, tiempo, incremento));
        }
    }
}
