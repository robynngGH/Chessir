using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Chessir.gui
{
    public partial class FormInicio : Form
    {
        //variable recibida de FormInicial
        String username = "";
        public FormInicio(String username)
        {
            InitializeComponent();
            this.username = username;
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            labelDiaSemana.Text = DateTime.Now.ToString("dddd");
            labelDiaSemana.Text = textInfo.ToTitleCase(labelDiaSemana.Text);
            labelDiaActual.Text = DateTime.Now.ToString("dd 'de' MMMM");
            labelUsuario.Text = "Usuario:\n" + username;
        }

        private void buttonAyuda_Click(object sender, EventArgs e)
        {
            FormInicial fi = Application.OpenForms.OfType<FormInicial>().FirstOrDefault(); //para llamar a funciones del form que abarca todo
            fi.abrirFormEnPanel(new FormAyuda());
        }
    }
}
