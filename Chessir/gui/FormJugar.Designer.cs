namespace Chessir.gui
{
    partial class FormJugar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJugar));
            this.panelLateral = new System.Windows.Forms.Panel();
            this.buttonTablas = new System.Windows.Forms.Button();
            this.buttonRendirseN = new System.Windows.Forms.Button();
            this.buttonRendirseB = new System.Windows.Forms.Button();
            this.labelEstadoPartida = new System.Windows.Forms.Label();
            this.labelTurno = new System.Windows.Forms.Label();
            this.timerNegro = new CuentaAtras.CuentaAtras();
            this.timerBlanco = new CuentaAtras.CuentaAtras();
            this.pictureBoxTimerN = new System.Windows.Forms.PictureBox();
            this.pictureBoxTimerB = new System.Windows.Forms.PictureBox();
            this.groupBoxFichasDerrotadasB = new System.Windows.Forms.GroupBox();
            this.groupBoxFichasDerrotadasN = new System.Windows.Forms.GroupBox();
            this.labelJugadorBlanco = new System.Windows.Forms.Label();
            this.labelJugadorNegro = new System.Windows.Forms.Label();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimerN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimerB)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.panelLateral.Controls.Add(this.buttonTablas);
            this.panelLateral.Controls.Add(this.buttonRendirseN);
            this.panelLateral.Controls.Add(this.buttonRendirseB);
            this.panelLateral.Controls.Add(this.labelEstadoPartida);
            this.panelLateral.Controls.Add(this.labelTurno);
            this.panelLateral.Controls.Add(this.timerNegro);
            this.panelLateral.Controls.Add(this.timerBlanco);
            this.panelLateral.Controls.Add(this.pictureBoxTimerN);
            this.panelLateral.Controls.Add(this.pictureBoxTimerB);
            this.panelLateral.Controls.Add(this.groupBoxFichasDerrotadasB);
            this.panelLateral.Controls.Add(this.groupBoxFichasDerrotadasN);
            this.panelLateral.Controls.Add(this.labelJugadorBlanco);
            this.panelLateral.Controls.Add(this.labelJugadorNegro);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLateral.Location = new System.Drawing.Point(1260, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(340, 715);
            this.panelLateral.TabIndex = 0;
            // 
            // buttonTablas
            // 
            this.buttonTablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(106)))), ((int)(((byte)(122)))));
            this.buttonTablas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTablas.Font = new System.Drawing.Font("Nirmala UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTablas.ForeColor = System.Drawing.Color.White;
            this.buttonTablas.Location = new System.Drawing.Point(212, 332);
            this.buttonTablas.Name = "buttonTablas";
            this.buttonTablas.Size = new System.Drawing.Size(83, 41);
            this.buttonTablas.TabIndex = 18;
            this.buttonTablas.Text = "Tablas";
            this.buttonTablas.UseVisualStyleBackColor = false;
            this.buttonTablas.Click += new System.EventHandler(this.buttonTablas_Click);
            // 
            // buttonRendirseN
            // 
            this.buttonRendirseN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(106)))), ((int)(((byte)(122)))));
            this.buttonRendirseN.Enabled = false;
            this.buttonRendirseN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRendirseN.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRendirseN.ForeColor = System.Drawing.Color.White;
            this.buttonRendirseN.Location = new System.Drawing.Point(196, 230);
            this.buttonRendirseN.Name = "buttonRendirseN";
            this.buttonRendirseN.Size = new System.Drawing.Size(99, 45);
            this.buttonRendirseN.TabIndex = 17;
            this.buttonRendirseN.Text = "Rendirse";
            this.buttonRendirseN.UseVisualStyleBackColor = false;
            this.buttonRendirseN.Click += new System.EventHandler(this.buttonRendirseN_Click);
            // 
            // buttonRendirseB
            // 
            this.buttonRendirseB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(106)))), ((int)(((byte)(122)))));
            this.buttonRendirseB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRendirseB.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRendirseB.ForeColor = System.Drawing.Color.White;
            this.buttonRendirseB.Location = new System.Drawing.Point(196, 436);
            this.buttonRendirseB.Name = "buttonRendirseB";
            this.buttonRendirseB.Size = new System.Drawing.Size(99, 45);
            this.buttonRendirseB.TabIndex = 16;
            this.buttonRendirseB.Text = "Rendirse";
            this.buttonRendirseB.UseVisualStyleBackColor = false;
            this.buttonRendirseB.Click += new System.EventHandler(this.buttonRendirseB_Click);
            // 
            // labelEstadoPartida
            // 
            this.labelEstadoPartida.AutoSize = true;
            this.labelEstadoPartida.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoPartida.ForeColor = System.Drawing.Color.OliveDrab;
            this.labelEstadoPartida.Location = new System.Drawing.Point(50, 371);
            this.labelEstadoPartida.Name = "labelEstadoPartida";
            this.labelEstadoPartida.Size = new System.Drawing.Size(65, 19);
            this.labelEstadoPartida.TabIndex = 9;
            this.labelEstadoPartida.Text = "Normal";
            this.labelEstadoPartida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTurno
            // 
            this.labelTurno.AutoSize = true;
            this.labelTurno.Font = new System.Drawing.Font("Source Code Pro Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurno.ForeColor = System.Drawing.Color.White;
            this.labelTurno.Location = new System.Drawing.Point(48, 313);
            this.labelTurno.Name = "labelTurno";
            this.labelTurno.Size = new System.Drawing.Size(119, 32);
            this.labelTurno.TabIndex = 8;
            this.labelTurno.Text = "Turno 1";
            this.labelTurno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerNegro
            // 
            this.timerNegro.AutoSize = true;
            this.timerNegro.codigoExt = null;
            this.timerNegro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerNegro.ForeColor = System.Drawing.Color.White;
            this.timerNegro.incremento = 0;
            this.timerNegro.Location = new System.Drawing.Point(106, 241);
            this.timerNegro.Name = "timerNegro";
            this.timerNegro.Size = new System.Drawing.Size(61, 24);
            this.timerNegro.TabIndex = 7;
            this.timerNegro.Text = "00:00";
            this.timerNegro.tiempo = 0;
            // 
            // timerBlanco
            // 
            this.timerBlanco.AutoSize = true;
            this.timerBlanco.codigoExt = null;
            this.timerBlanco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerBlanco.ForeColor = System.Drawing.Color.White;
            this.timerBlanco.incremento = 0;
            this.timerBlanco.Location = new System.Drawing.Point(106, 445);
            this.timerBlanco.Name = "timerBlanco";
            this.timerBlanco.Size = new System.Drawing.Size(61, 24);
            this.timerBlanco.TabIndex = 6;
            this.timerBlanco.Text = "00:00";
            this.timerBlanco.tiempo = 0;
            // 
            // pictureBoxTimerN
            // 
            this.pictureBoxTimerN.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTimerN.Image")));
            this.pictureBoxTimerN.Location = new System.Drawing.Point(45, 230);
            this.pictureBoxTimerN.Name = "pictureBoxTimerN";
            this.pictureBoxTimerN.Size = new System.Drawing.Size(45, 45);
            this.pictureBoxTimerN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTimerN.TabIndex = 5;
            this.pictureBoxTimerN.TabStop = false;
            // 
            // pictureBoxTimerB
            // 
            this.pictureBoxTimerB.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTimerB.Image")));
            this.pictureBoxTimerB.Location = new System.Drawing.Point(45, 436);
            this.pictureBoxTimerB.Name = "pictureBoxTimerB";
            this.pictureBoxTimerB.Size = new System.Drawing.Size(45, 45);
            this.pictureBoxTimerB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTimerB.TabIndex = 4;
            this.pictureBoxTimerB.TabStop = false;
            // 
            // groupBoxFichasDerrotadasB
            // 
            this.groupBoxFichasDerrotadasB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFichasDerrotadasB.ForeColor = System.Drawing.Color.White;
            this.groupBoxFichasDerrotadasB.Location = new System.Drawing.Point(45, 496);
            this.groupBoxFichasDerrotadasB.Name = "groupBoxFichasDerrotadasB";
            this.groupBoxFichasDerrotadasB.Size = new System.Drawing.Size(250, 140);
            this.groupBoxFichasDerrotadasB.TabIndex = 3;
            this.groupBoxFichasDerrotadasB.TabStop = false;
            this.groupBoxFichasDerrotadasB.Text = "Fichas derrotadas";
            // 
            // groupBoxFichasDerrotadasN
            // 
            this.groupBoxFichasDerrotadasN.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFichasDerrotadasN.ForeColor = System.Drawing.Color.White;
            this.groupBoxFichasDerrotadasN.Location = new System.Drawing.Point(45, 73);
            this.groupBoxFichasDerrotadasN.Name = "groupBoxFichasDerrotadasN";
            this.groupBoxFichasDerrotadasN.Size = new System.Drawing.Size(250, 140);
            this.groupBoxFichasDerrotadasN.TabIndex = 2;
            this.groupBoxFichasDerrotadasN.TabStop = false;
            this.groupBoxFichasDerrotadasN.Text = "Fichas derrotadas";
            // 
            // labelJugadorBlanco
            // 
            this.labelJugadorBlanco.AutoSize = true;
            this.labelJugadorBlanco.Font = new System.Drawing.Font("Source Code Pro Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJugadorBlanco.ForeColor = System.Drawing.Color.White;
            this.labelJugadorBlanco.Location = new System.Drawing.Point(39, 654);
            this.labelJugadorBlanco.Name = "labelJugadorBlanco";
            this.labelJugadorBlanco.Size = new System.Drawing.Size(224, 32);
            this.labelJugadorBlanco.TabIndex = 1;
            this.labelJugadorBlanco.Text = "Jugador Blanco";
            // 
            // labelJugadorNegro
            // 
            this.labelJugadorNegro.AutoSize = true;
            this.labelJugadorNegro.Font = new System.Drawing.Font("Source Code Pro Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJugadorNegro.ForeColor = System.Drawing.Color.White;
            this.labelJugadorNegro.Location = new System.Drawing.Point(39, 24);
            this.labelJugadorNegro.Name = "labelJugadorNegro";
            this.labelJugadorNegro.Size = new System.Drawing.Size(209, 32);
            this.labelJugadorNegro.TabIndex = 0;
            this.labelJugadorNegro.Text = "Jugador Negro";
            // 
            // FormJugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(106)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1600, 715);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormJugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormJugar";
            this.Load += new System.EventHandler(this.FormJugar_Load);
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimerN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimerB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Label labelJugadorNegro;
        private System.Windows.Forms.Label labelJugadorBlanco;
        private System.Windows.Forms.GroupBox groupBoxFichasDerrotadasB;
        private System.Windows.Forms.GroupBox groupBoxFichasDerrotadasN;
        private System.Windows.Forms.PictureBox pictureBoxTimerN;
        private System.Windows.Forms.PictureBox pictureBoxTimerB;
        public System.Windows.Forms.Label labelEstadoPartida;
        public CuentaAtras.CuentaAtras timerNegro;
        public CuentaAtras.CuentaAtras timerBlanco;
        public System.Windows.Forms.Button buttonRendirseN;
        public System.Windows.Forms.Button buttonRendirseB;
        public System.Windows.Forms.Label labelTurno;
        public System.Windows.Forms.Button buttonTablas;
    }
}