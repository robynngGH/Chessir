using Chessir.dao;
using Chessir.informes;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Chessir.gui
{
    public partial class FormInformes : Form
    {
        private bool es_admin = false; //para mostrar ciertos informes o no

        public FormInformes(bool es_admin)
        {
            InitializeComponent();
            //inicializa la lista completa de usernames en los combo box para modificar y eliminar
            ArrayList lista = new ArrayList();
            DAOUsuario daoUsuario = new DAOUsuario();
            lista = daoUsuario.usernamesDesplegable();
            for (int i = 0; i < lista.Count; i++)
            {
                comboBoxAccesos.Items.Add(lista[i]);
                comboBoxEstadisticas.Items.Add(lista[i]);
                comboBoxPartidasUsuario.Items.Add(lista[i]);
            }
            this.es_admin = es_admin;
            if (es_admin)
            {
                labelAccesosUsuario.Visible = true; comboBoxAccesos.Visible = true; buttonGenerarAccesos.Visible = true;
                labelEstadisticas.Visible = true; comboBoxEstadisticas.Visible = true; buttonGenerarEstadisticas.Visible = true;
            }
        }

        private void buttonGenerarAccesos_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = true;
            crystalReportViewer1.ReportSource = null;
            ReportDocument reportDocument = new informeAccesos();
            reportDocument.Load(@"informeAccesos.rep");
            if (comboBoxAccesos.Text.Equals("Todos")) reportDocument.SetParameterValue("USERNAME", "");
            else reportDocument.SetParameterValue("USERNAME", comboBoxAccesos.Text);
            //reportDocument.SetDatabaseLogon(username, password, server, db);
            crystalReportViewer1.ReportSource = reportDocument;
        }

        private void buttonGenerarEstadisticas_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = true;
            crystalReportViewer1.ReportSource = null;
            ReportDocument reportDocument = new informeEstadisticas();
            reportDocument.Load(@"informeEstadisticas.rep");
            if (comboBoxEstadisticas.Text.Equals("Todos")) reportDocument.SetParameterValue("USERNAME", "");
            else reportDocument.SetParameterValue("USERNAME", comboBoxEstadisticas.Text);
            //reportDocument.SetDatabaseLogon(username, password, server, db);
            crystalReportViewer1.ReportSource = reportDocument;
        }

        private void buttonGenerarPartidasID_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = true;
            crystalReportViewer1.ReportSource = null;
            ReportDocument reportDocument = new informePartidasID();
            reportDocument.Load(@"informePartidasID.rep");
            if (comboBoxEstadisticas.Text.Equals("Todos")) reportDocument.SetParameterValue("IDPARTIDA", 0);
            else reportDocument.SetParameterValue("IDPARTIDA", comboBoxEstadisticas.Text);
            crystalReportViewer1.ReportSource = reportDocument;
        }

        private void buttonGenerarPartidasUsuario_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = true;
            crystalReportViewer1.ReportSource = null;
            ReportDocument reportDocument = new informePartidasID();
            reportDocument.Load(@"informePartidasUsuario.rep");
            if (comboBoxEstadisticas.Text.Equals("Todos")) reportDocument.SetParameterValue("USERNAME", "");
            else reportDocument.SetParameterValue("USERNAME", comboBoxEstadisticas.Text);
            crystalReportViewer1.ReportSource = reportDocument;
        }
    }
}
