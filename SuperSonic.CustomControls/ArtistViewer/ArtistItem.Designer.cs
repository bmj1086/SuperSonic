namespace SuperSonic.CustomControls.ArtistViewer
{
    partial class ArtistItem
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
            this.randomCoverArt = new System.Windows.Forms.PictureBox();
            this.artistName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.randomCoverArt)).BeginInit();
            this.SuspendLayout();
            // 
            // randomCoverArt
            // 
            this.randomCoverArt.Location = new System.Drawing.Point(3, 3);
            this.randomCoverArt.Name = "randomCoverArt";
            this.randomCoverArt.Size = new System.Drawing.Size(45, 45);
            this.randomCoverArt.TabIndex = 0;
            this.randomCoverArt.TabStop = false;
            // 
            // artistName
            // 
            this.artistName.AutoSize = true;
            this.artistName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.artistName.Location = new System.Drawing.Point(54, 18);
            this.artistName.Name = "artistName";
            this.artistName.Size = new System.Drawing.Size(90, 16);
            this.artistName.TabIndex = 1;
            this.artistName.Text = "ArtistName";
            // 
            // ArtistItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.artistName);
            this.Controls.Add(this.randomCoverArt);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ArtistItem";
            this.Size = new System.Drawing.Size(398, 50);
            ((System.ComponentModel.ISupportInitialize)(this.randomCoverArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox randomCoverArt;
        private System.Windows.Forms.Label artistName;
    }
}
