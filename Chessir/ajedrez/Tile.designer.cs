namespace Chessir.ajedrez
{
    partial class Tile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImagenPieza = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPieza)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagenPieza
            // 
            this.ImagenPieza.BackColor = System.Drawing.Color.White;
            this.ImagenPieza.ErrorImage = null;
            this.ImagenPieza.InitialImage = null;
            this.ImagenPieza.Location = new System.Drawing.Point(0, 0);
            this.ImagenPieza.MaximumSize = new System.Drawing.Size(93, 85);
            this.ImagenPieza.MinimumSize = new System.Drawing.Size(93, 85);
            this.ImagenPieza.Name = "ImagenPieza";
            this.ImagenPieza.Size = new System.Drawing.Size(93, 85);
            this.ImagenPieza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImagenPieza.TabIndex = 0;
            this.ImagenPieza.TabStop = false;
            // 
            // Tile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ImagenPieza);
            this.Name = "Tile";
            this.Size = new System.Drawing.Size(93, 85);
            this.Load += new System.EventHandler(this.Tile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPieza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox ImagenPieza;
    }
}
