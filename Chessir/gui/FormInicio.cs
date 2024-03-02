using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
