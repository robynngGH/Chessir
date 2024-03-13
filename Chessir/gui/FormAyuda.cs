using System.IO;
using System.Windows.Forms;

namespace Chessir.gui
{
    public partial class FormAyuda : Form
    {
        public FormAyuda()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://es.wikipedia.org/wiki/Ajedrez");
        }

        private void onLoad(object sender, System.EventArgs e)
        {
            //base.OnLoad(e);
            var embed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            "</head><body>" +
            "<iframe width=\"680\" height=\"385\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";
            var url = "https://www.youtube.com/embed/zKwD0KTXPfg"; 
            this.webBrowser1.DocumentText = string.Format(embed, url);
        }
    }
}
