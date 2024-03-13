namespace Chessir.gui
{
    partial class FormInformes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelAccesosUsuario = new System.Windows.Forms.Label();
            this.comboBoxAccesos = new System.Windows.Forms.ComboBox();
            this.buttonGenerarAccesos = new System.Windows.Forms.Button();
            this.buttonGenerarEstadisticas = new System.Windows.Forms.Button();
            this.comboBoxEstadisticas = new System.Windows.Forms.ComboBox();
            this.labelEstadisticas = new System.Windows.Forms.Label();
            this.buttonGenerarPartidasID = new System.Windows.Forms.Button();
            this.comboBoxPartidasID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGenerarPartidasUsuario = new System.Windows.Forms.Button();
            this.comboBoxPartidasUsuario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Code Pro Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Informes Chessir!™";
            // 
            // labelAccesosUsuario
            // 
            this.labelAccesosUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAccesosUsuario.AutoSize = true;
            this.labelAccesosUsuario.Font = new System.Drawing.Font("Nirmala UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccesosUsuario.ForeColor = System.Drawing.Color.White;
            this.labelAccesosUsuario.Location = new System.Drawing.Point(43, 401);
            this.labelAccesosUsuario.Name = "labelAccesosUsuario";
            this.labelAccesosUsuario.Size = new System.Drawing.Size(227, 31);
            this.labelAccesosUsuario.TabIndex = 12;
            this.labelAccesosUsuario.Text = "Accesos por usuario";
            this.labelAccesosUsuario.Visible = false;
            // 
            // comboBoxAccesos
            // 
            this.comboBoxAccesos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxAccesos.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccesos.FormattingEnabled = true;
            this.comboBoxAccesos.Items.AddRange(new object[] {
            "Todos"});
            this.comboBoxAccesos.Location = new System.Drawing.Point(48, 460);
            this.comboBoxAccesos.Name = "comboBoxAccesos";
            this.comboBoxAccesos.Size = new System.Drawing.Size(157, 30);
            this.comboBoxAccesos.TabIndex = 13;
            this.comboBoxAccesos.Text = "Todos";
            this.comboBoxAccesos.Visible = false;
            // 
            // buttonGenerarAccesos
            // 
            this.buttonGenerarAccesos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGenerarAccesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.buttonGenerarAccesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerarAccesos.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerarAccesos.ForeColor = System.Drawing.Color.White;
            this.buttonGenerarAccesos.Location = new System.Drawing.Point(228, 454);
            this.buttonGenerarAccesos.Name = "buttonGenerarAccesos";
            this.buttonGenerarAccesos.Size = new System.Drawing.Size(116, 41);
            this.buttonGenerarAccesos.TabIndex = 18;
            this.buttonGenerarAccesos.Text = "Generar";
            this.buttonGenerarAccesos.UseVisualStyleBackColor = false;
            this.buttonGenerarAccesos.Visible = false;
            this.buttonGenerarAccesos.Click += new System.EventHandler(this.buttonGenerarAccesos_Click);
            // 
            // buttonGenerarEstadisticas
            // 
            this.buttonGenerarEstadisticas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGenerarEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.buttonGenerarEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerarEstadisticas.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerarEstadisticas.ForeColor = System.Drawing.Color.White;
            this.buttonGenerarEstadisticas.Location = new System.Drawing.Point(228, 596);
            this.buttonGenerarEstadisticas.Name = "buttonGenerarEstadisticas";
            this.buttonGenerarEstadisticas.Size = new System.Drawing.Size(116, 41);
            this.buttonGenerarEstadisticas.TabIndex = 21;
            this.buttonGenerarEstadisticas.Text = "Generar";
            this.buttonGenerarEstadisticas.UseVisualStyleBackColor = false;
            this.buttonGenerarEstadisticas.Visible = false;
            this.buttonGenerarEstadisticas.Click += new System.EventHandler(this.buttonGenerarEstadisticas_Click);
            // 
            // comboBoxEstadisticas
            // 
            this.comboBoxEstadisticas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxEstadisticas.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstadisticas.FormattingEnabled = true;
            this.comboBoxEstadisticas.Items.AddRange(new object[] {
            "Todos"});
            this.comboBoxEstadisticas.Location = new System.Drawing.Point(48, 602);
            this.comboBoxEstadisticas.Name = "comboBoxEstadisticas";
            this.comboBoxEstadisticas.Size = new System.Drawing.Size(157, 30);
            this.comboBoxEstadisticas.TabIndex = 20;
            this.comboBoxEstadisticas.Text = "Todos";
            this.comboBoxEstadisticas.Visible = false;
            // 
            // labelEstadisticas
            // 
            this.labelEstadisticas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEstadisticas.AutoSize = true;
            this.labelEstadisticas.Font = new System.Drawing.Font("Nirmala UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadisticas.ForeColor = System.Drawing.Color.White;
            this.labelEstadisticas.Location = new System.Drawing.Point(43, 543);
            this.labelEstadisticas.Name = "labelEstadisticas";
            this.labelEstadisticas.Size = new System.Drawing.Size(294, 31);
            this.labelEstadisticas.TabIndex = 19;
            this.labelEstadisticas.Text = "Usuarios y sus estadísticas";
            this.labelEstadisticas.Visible = false;
            // 
            // buttonGenerarPartidasID
            // 
            this.buttonGenerarPartidasID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGenerarPartidasID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.buttonGenerarPartidasID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerarPartidasID.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerarPartidasID.ForeColor = System.Drawing.Color.White;
            this.buttonGenerarPartidasID.Location = new System.Drawing.Point(228, 173);
            this.buttonGenerarPartidasID.Name = "buttonGenerarPartidasID";
            this.buttonGenerarPartidasID.Size = new System.Drawing.Size(116, 41);
            this.buttonGenerarPartidasID.TabIndex = 24;
            this.buttonGenerarPartidasID.Text = "Generar";
            this.buttonGenerarPartidasID.UseVisualStyleBackColor = false;
            this.buttonGenerarPartidasID.Click += new System.EventHandler(this.buttonGenerarPartidasID_Click);
            // 
            // comboBoxPartidasID
            // 
            this.comboBoxPartidasID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxPartidasID.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPartidasID.FormattingEnabled = true;
            this.comboBoxPartidasID.Items.AddRange(new object[] {
            "Todos"});
            this.comboBoxPartidasID.Location = new System.Drawing.Point(48, 179);
            this.comboBoxPartidasID.Name = "comboBoxPartidasID";
            this.comboBoxPartidasID.Size = new System.Drawing.Size(157, 30);
            this.comboBoxPartidasID.TabIndex = 23;
            this.comboBoxPartidasID.Text = "Todos";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(43, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "Partidas por su ID";
            // 
            // buttonGenerarPartidasUsuario
            // 
            this.buttonGenerarPartidasUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGenerarPartidasUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.buttonGenerarPartidasUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerarPartidasUsuario.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerarPartidasUsuario.ForeColor = System.Drawing.Color.White;
            this.buttonGenerarPartidasUsuario.Location = new System.Drawing.Point(228, 317);
            this.buttonGenerarPartidasUsuario.Name = "buttonGenerarPartidasUsuario";
            this.buttonGenerarPartidasUsuario.Size = new System.Drawing.Size(116, 41);
            this.buttonGenerarPartidasUsuario.TabIndex = 27;
            this.buttonGenerarPartidasUsuario.Text = "Generar";
            this.buttonGenerarPartidasUsuario.UseVisualStyleBackColor = false;
            this.buttonGenerarPartidasUsuario.Click += new System.EventHandler(this.buttonGenerarPartidasUsuario_Click);
            // 
            // comboBoxPartidasUsuario
            // 
            this.comboBoxPartidasUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxPartidasUsuario.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPartidasUsuario.FormattingEnabled = true;
            this.comboBoxPartidasUsuario.Items.AddRange(new object[] {
            "Todos"});
            this.comboBoxPartidasUsuario.Location = new System.Drawing.Point(48, 323);
            this.comboBoxPartidasUsuario.Name = "comboBoxPartidasUsuario";
            this.comboBoxPartidasUsuario.Size = new System.Drawing.Size(157, 30);
            this.comboBoxPartidasUsuario.TabIndex = 26;
            this.comboBoxPartidasUsuario.Text = "Todos";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(43, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 31);
            this.label5.TabIndex = 25;
            this.label5.Text = "Partidas de un usuario";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(405, 30);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1140, 659);
            this.crystalReportViewer1.TabIndex = 28;
            this.crystalReportViewer1.Visible = false;
            // 
            // FormInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(106)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1600, 915);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.buttonGenerarPartidasUsuario);
            this.Controls.Add(this.comboBoxPartidasUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonGenerarPartidasID);
            this.Controls.Add(this.comboBoxPartidasID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonGenerarEstadisticas);
            this.Controls.Add(this.comboBoxEstadisticas);
            this.Controls.Add(this.labelEstadisticas);
            this.Controls.Add(this.buttonGenerarAccesos);
            this.Controls.Add(this.comboBoxAccesos);
            this.Controls.Add(this.labelAccesosUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInformes";
            this.Text = "FormInformes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAccesosUsuario;
        private System.Windows.Forms.ComboBox comboBoxAccesos;
        private System.Windows.Forms.Button buttonGenerarAccesos;
        private System.Windows.Forms.Button buttonGenerarEstadisticas;
        private System.Windows.Forms.ComboBox comboBoxEstadisticas;
        private System.Windows.Forms.Label labelEstadisticas;
        private System.Windows.Forms.Button buttonGenerarPartidasID;
        private System.Windows.Forms.ComboBox comboBoxPartidasID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonGenerarPartidasUsuario;
        private System.Windows.Forms.ComboBox comboBoxPartidasUsuario;
        private System.Windows.Forms.Label label5;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}