namespace Chessir.gui
{
    partial class FormSeleccionPieza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeleccionPieza));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.labelChessir = new System.Windows.Forms.Label();
            this.pictureBoxIcono = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.pictureBoxPieza = new System.Windows.Forms.PictureBox();
            this.buttonDerecha = new System.Windows.Forms.Button();
            this.buttonIzquierda = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPieza)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(206)))), ((int)(((byte)(178)))));
            this.panelSuperior.Controls.Add(this.labelChessir);
            this.panelSuperior.Controls.Add(this.pictureBoxIcono);
            this.panelSuperior.Controls.Add(this.pictureBoxCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(320, 35);
            this.panelSuperior.TabIndex = 1;
            // 
            // labelChessir
            // 
            this.labelChessir.AutoSize = true;
            this.labelChessir.Font = new System.Drawing.Font("Source Code Pro Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChessir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.labelChessir.Location = new System.Drawing.Point(43, 7);
            this.labelChessir.Name = "labelChessir";
            this.labelChessir.Size = new System.Drawing.Size(90, 22);
            this.labelChessir.TabIndex = 6;
            this.labelChessir.Text = "Chessir!";
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
            this.pictureBoxCerrar.Location = new System.Drawing.Point(283, 4);
            this.pictureBoxCerrar.Name = "pictureBoxCerrar";
            this.pictureBoxCerrar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCerrar.TabIndex = 1;
            this.pictureBoxCerrar.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(145)))), ((int)(((byte)(111)))));
            this.panelContenedor.Controls.Add(this.buttonIzquierda);
            this.panelContenedor.Controls.Add(this.buttonDerecha);
            this.panelContenedor.Controls.Add(this.pictureBoxPieza);
            this.panelContenedor.Controls.Add(this.buttonAceptar);
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(320, 285);
            this.panelContenedor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Code Pro Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecciona una pieza";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(105)))), ((int)(((byte)(81)))));
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.ForeColor = System.Drawing.Color.White;
            this.buttonAceptar.Location = new System.Drawing.Point(83, 215);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(152, 41);
            this.buttonAceptar.TabIndex = 12;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            // 
            // pictureBoxPieza
            // 
            this.pictureBoxPieza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(105)))), ((int)(((byte)(81)))));
            this.pictureBoxPieza.Location = new System.Drawing.Point(110, 81);
            this.pictureBoxPieza.Name = "pictureBoxPieza";
            this.pictureBoxPieza.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxPieza.TabIndex = 13;
            this.pictureBoxPieza.TabStop = false;
            // 
            // buttonDerecha
            // 
            this.buttonDerecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDerecha.Font = new System.Drawing.Font("Source Code Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDerecha.ForeColor = System.Drawing.Color.White;
            this.buttonDerecha.Location = new System.Drawing.Point(232, 110);
            this.buttonDerecha.Name = "buttonDerecha";
            this.buttonDerecha.Size = new System.Drawing.Size(40, 40);
            this.buttonDerecha.TabIndex = 14;
            this.buttonDerecha.Text = "->";
            this.buttonDerecha.UseVisualStyleBackColor = true;
            // 
            // buttonIzquierda
            // 
            this.buttonIzquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIzquierda.Font = new System.Drawing.Font("Source Code Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzquierda.ForeColor = System.Drawing.Color.White;
            this.buttonIzquierda.Location = new System.Drawing.Point(47, 110);
            this.buttonIzquierda.Name = "buttonIzquierda";
            this.buttonIzquierda.Size = new System.Drawing.Size(40, 40);
            this.buttonIzquierda.TabIndex = 15;
            this.buttonIzquierda.Text = "<-";
            this.buttonIzquierda.UseVisualStyleBackColor = true;
            // 
            // FormSeleccionPieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 320);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSeleccionPieza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSeleccionPieza";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPieza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label labelChessir;
        private System.Windows.Forms.PictureBox pictureBoxIcono;
        private System.Windows.Forms.PictureBox pictureBoxCerrar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.PictureBox pictureBoxPieza;
        private System.Windows.Forms.Button buttonDerecha;
        private System.Windows.Forms.Button buttonIzquierda;
    }
}