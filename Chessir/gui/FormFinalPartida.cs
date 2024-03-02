using Chessir.ajedrez;
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
    public partial class FormFinalPartida : Form
    {
        FormInicial fi = Application.OpenForms.OfType<FormInicial>().FirstOrDefault(); //para llamar a funciones del form que abarca todo
        FormJugar fj = Application.OpenForms.OfType<FormJugar>().FirstOrDefault(); //para llamar a funciones del form jugar abierto
        int id_victoria = 0;
        string motivo = ""; //motivo de final de partida
        public FormFinalPartida(int id_victoria, string user_victoria, string motivo, string imagenRey)
        {
            this.id_victoria=id_victoria;
            InitializeComponent();
            label1.Text = "¡Victoria para " + user_victoria + "!";
            label2.Text = "La partida ha finalizado por " + motivo.ToLower() + ".";
            pictureBoxRey.Image = Tile.ImagenesPiezas[imagenRey];
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
            fj = new FormJugar(fj.getId_Blanco(), fj.getUsername_Blanco(), fj.getId_Negro(), fj.getUsername_Negro(), fj.getTiempo(), fj.getIncremento());
            fi.abrirFormEnPanel(fj);
            this.Close();
        }
    }
}
