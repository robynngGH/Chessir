namespace Chessir.gui
{
    partial class FormPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerfil));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelNumPartidas = new System.Windows.Forms.Label();
            this.labelVictorias = new System.Windows.Forms.Label();
            this.labelDerrotas = new System.Windows.Forms.Label();
            this.labelWinrate = new System.Windows.Forms.Label();
            this.labelModoFavorito = new System.Windows.Forms.Label();
            this.buttonAyuda = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.labelTablas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Code Pro Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Perfil del usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Chessir.Properties.Resources.Rey_Blanco;
            this.pictureBox1.Location = new System.Drawing.Point(62, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Nirmala UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(149, 137);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(97, 31);
            this.labelUsername.TabIndex = 10;
            this.labelUsername.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nº de partidas:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Victorias:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Derrotas:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(57, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Winrate%:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(57, 549);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Modo favorito:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.Font = new System.Drawing.Font("Source Code Pro Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(542, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(956, 124);
            this.label7.TabIndex = 16;
            this.label7.Text = "Si quieres ganar más partidas, ¡no dudes en visitar nuestra sección de ayuda!";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumPartidas
            // 
            this.labelNumPartidas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNumPartidas.AutoSize = true;
            this.labelNumPartidas.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumPartidas.ForeColor = System.Drawing.Color.White;
            this.labelNumPartidas.Location = new System.Drawing.Point(227, 210);
            this.labelNumPartidas.Name = "labelNumPartidas";
            this.labelNumPartidas.Size = new System.Drawing.Size(24, 28);
            this.labelNumPartidas.TabIndex = 17;
            this.labelNumPartidas.Text = "0";
            // 
            // labelVictorias
            // 
            this.labelVictorias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelVictorias.AutoSize = true;
            this.labelVictorias.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVictorias.ForeColor = System.Drawing.Color.Lime;
            this.labelVictorias.Location = new System.Drawing.Point(227, 275);
            this.labelVictorias.Name = "labelVictorias";
            this.labelVictorias.Size = new System.Drawing.Size(24, 28);
            this.labelVictorias.TabIndex = 18;
            this.labelVictorias.Text = "0";
            // 
            // labelDerrotas
            // 
            this.labelDerrotas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDerrotas.AutoSize = true;
            this.labelDerrotas.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDerrotas.ForeColor = System.Drawing.Color.Firebrick;
            this.labelDerrotas.Location = new System.Drawing.Point(227, 342);
            this.labelDerrotas.Name = "labelDerrotas";
            this.labelDerrotas.Size = new System.Drawing.Size(24, 28);
            this.labelDerrotas.TabIndex = 19;
            this.labelDerrotas.Text = "0";
            // 
            // labelWinrate
            // 
            this.labelWinrate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelWinrate.AutoSize = true;
            this.labelWinrate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinrate.ForeColor = System.Drawing.Color.White;
            this.labelWinrate.Location = new System.Drawing.Point(227, 480);
            this.labelWinrate.Name = "labelWinrate";
            this.labelWinrate.Size = new System.Drawing.Size(41, 28);
            this.labelWinrate.TabIndex = 20;
            this.labelWinrate.Text = "0%";
            // 
            // labelModoFavorito
            // 
            this.labelModoFavorito.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelModoFavorito.AutoSize = true;
            this.labelModoFavorito.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModoFavorito.ForeColor = System.Drawing.Color.White;
            this.labelModoFavorito.Location = new System.Drawing.Point(227, 549);
            this.labelModoFavorito.Name = "labelModoFavorito";
            this.labelModoFavorito.Size = new System.Drawing.Size(78, 28);
            this.labelModoFavorito.TabIndex = 21;
            this.labelModoFavorito.Text = "Clásico";
            // 
            // buttonAyuda
            // 
            this.buttonAyuda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.buttonAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAyuda.Font = new System.Drawing.Font("Source Code Pro Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAyuda.ForeColor = System.Drawing.Color.White;
            this.buttonAyuda.Image = ((System.Drawing.Image)(resources.GetObject("buttonAyuda.Image")));
            this.buttonAyuda.Location = new System.Drawing.Point(862, 181);
            this.buttonAyuda.Name = "buttonAyuda";
            this.buttonAyuda.Size = new System.Drawing.Size(300, 122);
            this.buttonAyuda.TabIndex = 22;
            this.buttonAyuda.Text = "Ayuda";
            this.buttonAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAyuda.UseVisualStyleBackColor = false;
            this.buttonAyuda.Click += new System.EventHandler(this.buttonAyuda_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(57, 410);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 28);
            this.label13.TabIndex = 23;
            this.label13.Text = "Tablas:";
            // 
            // labelTablas
            // 
            this.labelTablas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTablas.AutoSize = true;
            this.labelTablas.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTablas.ForeColor = System.Drawing.Color.Cyan;
            this.labelTablas.Location = new System.Drawing.Point(227, 410);
            this.labelTablas.Name = "labelTablas";
            this.labelTablas.Size = new System.Drawing.Size(24, 28);
            this.labelTablas.TabIndex = 24;
            this.labelTablas.Text = "0";
            // 
            // FormPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(106)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1600, 915);
            this.Controls.Add(this.labelTablas);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonAyuda);
            this.Controls.Add(this.labelModoFavorito);
            this.Controls.Add(this.labelWinrate);
            this.Controls.Add(this.labelDerrotas);
            this.Controls.Add(this.labelVictorias);
            this.Controls.Add(this.labelNumPartidas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPerfil";
            this.Text = "FormPerfil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelNumPartidas;
        private System.Windows.Forms.Label labelVictorias;
        private System.Windows.Forms.Label labelDerrotas;
        private System.Windows.Forms.Label labelWinrate;
        private System.Windows.Forms.Label labelModoFavorito;
        private System.Windows.Forms.Button buttonAyuda;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelTablas;
    }
}