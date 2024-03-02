namespace Chessir
{
    partial class FormInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.labelUsuarioSuperior = new System.Windows.Forms.Label();
            this.labelChessir = new System.Windows.Forms.Label();
            this.pictureBoxIcono = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxMaximizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBoxRestaurar = new System.Windows.Forms.PictureBox();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.buttonGestion = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonRepeticiones = new System.Windows.Forms.Button();
            this.buttonJugar = new System.Windows.Forms.Button();
            this.buttonPerfil = new System.Windows.Forms.Button();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestaurar)).BeginInit();
            this.panelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.panelSuperior.Controls.Add(this.labelUsuarioSuperior);
            this.panelSuperior.Controls.Add(this.labelChessir);
            this.panelSuperior.Controls.Add(this.pictureBoxIcono);
            this.panelSuperior.Controls.Add(this.pictureBoxMinimizar);
            this.panelSuperior.Controls.Add(this.pictureBoxMaximizar);
            this.panelSuperior.Controls.Add(this.pictureBoxCerrar);
            this.panelSuperior.Controls.Add(this.pictureBoxRestaurar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1600, 35);
            this.panelSuperior.TabIndex = 0;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // labelUsuarioSuperior
            // 
            this.labelUsuarioSuperior.AutoSize = true;
            this.labelUsuarioSuperior.Font = new System.Drawing.Font("Source Code Pro Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioSuperior.ForeColor = System.Drawing.Color.White;
            this.labelUsuarioSuperior.Location = new System.Drawing.Point(1066, 7);
            this.labelUsuarioSuperior.Name = "labelUsuarioSuperior";
            this.labelUsuarioSuperior.Size = new System.Drawing.Size(0, 22);
            this.labelUsuarioSuperior.TabIndex = 6;
            // 
            // labelChessir
            // 
            this.labelChessir.AutoSize = true;
            this.labelChessir.Font = new System.Drawing.Font("Source Code Pro Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChessir.ForeColor = System.Drawing.Color.White;
            this.labelChessir.Location = new System.Drawing.Point(43, 7);
            this.labelChessir.Name = "labelChessir";
            this.labelChessir.Size = new System.Drawing.Size(90, 22);
            this.labelChessir.TabIndex = 5;
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
            this.pictureBoxIcono.TabIndex = 4;
            this.pictureBoxIcono.TabStop = false;
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimizar.Image")));
            this.pictureBoxMinimizar.Location = new System.Drawing.Point(1501, 4);
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimizar.TabIndex = 2;
            this.pictureBoxMinimizar.TabStop = false;
            this.pictureBoxMinimizar.Click += new System.EventHandler(this.pictureBoxMinimizar_Click);
            // 
            // pictureBoxMaximizar
            // 
            this.pictureBoxMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMaximizar.Image")));
            this.pictureBoxMaximizar.Location = new System.Drawing.Point(1532, 4);
            this.pictureBoxMaximizar.Name = "pictureBoxMaximizar";
            this.pictureBoxMaximizar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMaximizar.TabIndex = 1;
            this.pictureBoxMaximizar.TabStop = false;
            this.pictureBoxMaximizar.Click += new System.EventHandler(this.pictureBoxMaximizar_Click);
            // 
            // pictureBoxCerrar
            // 
            this.pictureBoxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCerrar.Image")));
            this.pictureBoxCerrar.Location = new System.Drawing.Point(1563, 4);
            this.pictureBoxCerrar.Name = "pictureBoxCerrar";
            this.pictureBoxCerrar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCerrar.TabIndex = 0;
            this.pictureBoxCerrar.TabStop = false;
            this.pictureBoxCerrar.Click += new System.EventHandler(this.pictureBoxCerrar_Click);
            // 
            // pictureBoxRestaurar
            // 
            this.pictureBoxRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRestaurar.Image")));
            this.pictureBoxRestaurar.Location = new System.Drawing.Point(1532, 4);
            this.pictureBoxRestaurar.Name = "pictureBoxRestaurar";
            this.pictureBoxRestaurar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRestaurar.TabIndex = 3;
            this.pictureBoxRestaurar.TabStop = false;
            this.pictureBoxRestaurar.Click += new System.EventHandler(this.pictureBoxRestaurar_Click);
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.panelInferior.Controls.Add(this.buttonGestion);
            this.panelInferior.Controls.Add(this.buttonSalir);
            this.panelInferior.Controls.Add(this.buttonRepeticiones);
            this.panelInferior.Controls.Add(this.buttonJugar);
            this.panelInferior.Controls.Add(this.buttonPerfil);
            this.panelInferior.Controls.Add(this.buttonInicio);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 950);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1600, 150);
            this.panelInferior.TabIndex = 1;
            // 
            // buttonGestion
            // 
            this.buttonGestion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonGestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(106)))), ((int)(((byte)(122)))));
            this.buttonGestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestion.Font = new System.Drawing.Font("Source Code Pro Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestion.ForeColor = System.Drawing.Color.White;
            this.buttonGestion.Image = ((System.Drawing.Image)(resources.GetObject("buttonGestion.Image")));
            this.buttonGestion.Location = new System.Drawing.Point(331, 14);
            this.buttonGestion.Name = "buttonGestion";
            this.buttonGestion.Size = new System.Drawing.Size(300, 122);
            this.buttonGestion.TabIndex = 5;
            this.buttonGestion.Text = "Gestión usuarios";
            this.buttonGestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonGestion.UseVisualStyleBackColor = false;
            this.buttonGestion.Visible = false;
            this.buttonGestion.Click += new System.EventHandler(this.buttonGestion_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(106)))), ((int)(((byte)(122)))));
            this.buttonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Source Code Pro Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.White;
            this.buttonSalir.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalir.Image")));
            this.buttonSalir.Location = new System.Drawing.Point(1288, 14);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(300, 122);
            this.buttonSalir.TabIndex = 4;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Visible = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonRepeticiones
            // 
            this.buttonRepeticiones.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRepeticiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(106)))), ((int)(((byte)(122)))));
            this.buttonRepeticiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRepeticiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRepeticiones.Font = new System.Drawing.Font("Source Code Pro Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRepeticiones.ForeColor = System.Drawing.Color.White;
            this.buttonRepeticiones.Image = ((System.Drawing.Image)(resources.GetObject("buttonRepeticiones.Image")));
            this.buttonRepeticiones.Location = new System.Drawing.Point(968, 14);
            this.buttonRepeticiones.Name = "buttonRepeticiones";
            this.buttonRepeticiones.Size = new System.Drawing.Size(300, 122);
            this.buttonRepeticiones.TabIndex = 3;
            this.buttonRepeticiones.Text = "Repeticiones";
            this.buttonRepeticiones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRepeticiones.UseVisualStyleBackColor = false;
            this.buttonRepeticiones.Visible = false;
            this.buttonRepeticiones.Click += new System.EventHandler(this.buttonRepeticiones_Click);
            // 
            // buttonJugar
            // 
            this.buttonJugar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonJugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(106)))), ((int)(((byte)(122)))));
            this.buttonJugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJugar.Font = new System.Drawing.Font("Source Code Pro Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJugar.ForeColor = System.Drawing.Color.White;
            this.buttonJugar.Image = ((System.Drawing.Image)(resources.GetObject("buttonJugar.Image")));
            this.buttonJugar.Location = new System.Drawing.Point(650, 14);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(300, 122);
            this.buttonJugar.TabIndex = 2;
            this.buttonJugar.Text = "Jugar";
            this.buttonJugar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonJugar.UseVisualStyleBackColor = false;
            this.buttonJugar.Visible = false;
            this.buttonJugar.Click += new System.EventHandler(this.buttonJugar_Click);
            // 
            // buttonPerfil
            // 
            this.buttonPerfil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(106)))), ((int)(((byte)(122)))));
            this.buttonPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPerfil.Font = new System.Drawing.Font("Source Code Pro Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPerfil.ForeColor = System.Drawing.Color.White;
            this.buttonPerfil.Image = ((System.Drawing.Image)(resources.GetObject("buttonPerfil.Image")));
            this.buttonPerfil.Location = new System.Drawing.Point(331, 14);
            this.buttonPerfil.Name = "buttonPerfil";
            this.buttonPerfil.Size = new System.Drawing.Size(300, 122);
            this.buttonPerfil.TabIndex = 1;
            this.buttonPerfil.Text = "Perfil";
            this.buttonPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPerfil.UseVisualStyleBackColor = false;
            this.buttonPerfil.Visible = false;
            // 
            // buttonInicio
            // 
            this.buttonInicio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(106)))), ((int)(((byte)(122)))));
            this.buttonInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInicio.Font = new System.Drawing.Font("Source Code Pro Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInicio.ForeColor = System.Drawing.Color.White;
            this.buttonInicio.Image = ((System.Drawing.Image)(resources.GetObject("buttonInicio.Image")));
            this.buttonInicio.Location = new System.Drawing.Point(12, 14);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(300, 122);
            this.buttonInicio.TabIndex = 0;
            this.buttonInicio.Text = "Inicio";
            this.buttonInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonInicio.UseVisualStyleBackColor = false;
            this.buttonInicio.Visible = false;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(106)))), ((int)(((byte)(122)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1600, 915);
            this.panelContenedor.TabIndex = 2;
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 1100);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chessir!";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestaurar)).EndInit();
            this.panelInferior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBoxCerrar;
        private System.Windows.Forms.PictureBox pictureBoxRestaurar;
        private System.Windows.Forms.PictureBox pictureBoxMinimizar;
        private System.Windows.Forms.PictureBox pictureBoxMaximizar;
        private System.Windows.Forms.PictureBox pictureBoxIcono;
        private System.Windows.Forms.Label labelChessir;
        private System.Windows.Forms.Label labelUsuarioSuperior;
        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Button buttonJugar;
        private System.Windows.Forms.Button buttonPerfil;
        private System.Windows.Forms.Button buttonGestion;
        private System.Windows.Forms.Button buttonRepeticiones;
        private System.Windows.Forms.Button buttonSalir;
    }
}

