namespace Chessir.gui
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDiaSemana = new System.Windows.Forms.Label();
            this.labelDiaActual = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(482, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 72);
            this.label1.TabIndex = 8;
            this.label1.Text = "¡Bienvenido/a a Chessir!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(494, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(577, 537);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // labelDiaSemana
            // 
            this.labelDiaSemana.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDiaSemana.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiaSemana.ForeColor = System.Drawing.Color.White;
            this.labelDiaSemana.Location = new System.Drawing.Point(189, 163);
            this.labelDiaSemana.Name = "labelDiaSemana";
            this.labelDiaSemana.Size = new System.Drawing.Size(299, 47);
            this.labelDiaSemana.TabIndex = 10;
            // 
            // labelDiaActual
            // 
            this.labelDiaActual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDiaActual.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiaActual.ForeColor = System.Drawing.Color.White;
            this.labelDiaActual.Location = new System.Drawing.Point(189, 210);
            this.labelDiaActual.Name = "labelDiaActual";
            this.labelDiaActual.Size = new System.Drawing.Size(299, 118);
            this.labelDiaActual.TabIndex = 11;
            // 
            // labelUsuario
            // 
            this.labelUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUsuario.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Location = new System.Drawing.Point(1077, 163);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(455, 281);
            this.labelUsuario.TabIndex = 12;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(106)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1600, 915);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelDiaActual);
            this.Controls.Add(this.labelDiaSemana);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicio";
            this.Text = "FormInicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDiaSemana;
        private System.Windows.Forms.Label labelDiaActual;
        private System.Windows.Forms.Label labelUsuario;
    }
}