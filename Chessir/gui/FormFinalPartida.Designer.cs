namespace Chessir.gui
{
    partial class FormFinalPartida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinalPartida));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.labelFinalPartida = new System.Windows.Forms.Label();
            this.pictureBoxIcono = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.buttonNuevaPartida = new System.Windows.Forms.Button();
            this.buttonRevancha = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.pictureBoxRey = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRey)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(206)))), ((int)(((byte)(178)))));
            this.panelSuperior.Controls.Add(this.labelFinalPartida);
            this.panelSuperior.Controls.Add(this.pictureBoxIcono);
            this.panelSuperior.Controls.Add(this.pictureBoxCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(600, 35);
            this.panelSuperior.TabIndex = 2;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // labelFinalPartida
            // 
            this.labelFinalPartida.AutoSize = true;
            this.labelFinalPartida.Font = new System.Drawing.Font("Source Code Pro Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalPartida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.labelFinalPartida.Location = new System.Drawing.Point(43, 7);
            this.labelFinalPartida.Name = "labelFinalPartida";
            this.labelFinalPartida.Size = new System.Drawing.Size(190, 22);
            this.labelFinalPartida.TabIndex = 6;
            this.labelFinalPartida.Text = "Partida finalizada";
            // 
            // pictureBoxIcono
            // 
            this.pictureBoxIcono.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxIcono.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcono.Image")));
            this.pictureBoxIcono.Location = new System.Drawing.Point(12, 4);
            this.pictureBoxIcono.Name = "pictureBoxIcono";
            this.pictureBoxIcono.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcono.TabIndex = 5;
            this.pictureBoxIcono.TabStop = false;
            // 
            // pictureBoxCerrar
            // 
            this.pictureBoxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCerrar.Image")));
            this.pictureBoxCerrar.Location = new System.Drawing.Point(563, 4);
            this.pictureBoxCerrar.Name = "pictureBoxCerrar";
            this.pictureBoxCerrar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCerrar.TabIndex = 1;
            this.pictureBoxCerrar.TabStop = false;
            this.pictureBoxCerrar.Click += new System.EventHandler(this.pictureBoxCerrar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(145)))), ((int)(((byte)(111)))));
            this.panelContenedor.Controls.Add(this.buttonNuevaPartida);
            this.panelContenedor.Controls.Add(this.buttonRevancha);
            this.panelContenedor.Controls.Add(this.buttonAceptar);
            this.panelContenedor.Controls.Add(this.pictureBoxRey);
            this.panelContenedor.Controls.Add(this.label2);
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(600, 415);
            this.panelContenedor.TabIndex = 3;
            // 
            // buttonNuevaPartida
            // 
            this.buttonNuevaPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(105)))), ((int)(((byte)(81)))));
            this.buttonNuevaPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNuevaPartida.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevaPartida.ForeColor = System.Drawing.Color.White;
            this.buttonNuevaPartida.Location = new System.Drawing.Point(211, 303);
            this.buttonNuevaPartida.Name = "buttonNuevaPartida";
            this.buttonNuevaPartida.Size = new System.Drawing.Size(181, 52);
            this.buttonNuevaPartida.TabIndex = 17;
            this.buttonNuevaPartida.Text = "Nueva Partida";
            this.buttonNuevaPartida.UseVisualStyleBackColor = false;
            this.buttonNuevaPartida.Click += new System.EventHandler(this.buttonNuevaPartida_Click);
            // 
            // buttonRevancha
            // 
            this.buttonRevancha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(105)))), ((int)(((byte)(81)))));
            this.buttonRevancha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRevancha.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRevancha.ForeColor = System.Drawing.Color.White;
            this.buttonRevancha.Location = new System.Drawing.Point(34, 303);
            this.buttonRevancha.Name = "buttonRevancha";
            this.buttonRevancha.Size = new System.Drawing.Size(152, 52);
            this.buttonRevancha.TabIndex = 16;
            this.buttonRevancha.Text = "Revancha";
            this.buttonRevancha.UseVisualStyleBackColor = false;
            this.buttonRevancha.Click += new System.EventHandler(this.buttonRevancha_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(105)))), ((int)(((byte)(81)))));
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.ForeColor = System.Drawing.Color.White;
            this.buttonAceptar.Location = new System.Drawing.Point(415, 303);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(152, 52);
            this.buttonAceptar.TabIndex = 15;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // pictureBoxRey
            // 
            this.pictureBoxRey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(105)))), ((int)(((byte)(81)))));
            this.pictureBoxRey.Location = new System.Drawing.Point(243, 89);
            this.pictureBoxRey.Name = "pictureBoxRey";
            this.pictureBoxRey.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxRey.TabIndex = 14;
            this.pictureBoxRey.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Motivo final";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Code Pro Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "¡Victoria para !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormFinalPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFinalPartida";
            this.Text = "FormFinalPartida";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRey)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label labelFinalPartida;
        private System.Windows.Forms.PictureBox pictureBoxIcono;
        private System.Windows.Forms.PictureBox pictureBoxCerrar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxRey;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonNuevaPartida;
        private System.Windows.Forms.Button buttonRevancha;
    }
}