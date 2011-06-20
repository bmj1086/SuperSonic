namespace SuperSonic.CustomControls.AlbumViewer
{
    partial class AlbumCoverAndText
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
            this.albumTitle = new System.Windows.Forms.Label();
            this.albumArtist = new System.Windows.Forms.Label();
            this.albumCoverArt = new SuperSonic.CustomControls.AlbumViewer.PictureBoxDS();
            ((System.ComponentModel.ISupportInitialize)(this.albumCoverArt)).BeginInit();
            this.SuspendLayout();
            // 
            // albumTitle
            // 
            this.albumTitle.AutoEllipsis = true;
            this.albumTitle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.albumTitle.Location = new System.Drawing.Point(-2, 103);
            this.albumTitle.MaximumSize = new System.Drawing.Size(125, 15);
            this.albumTitle.Name = "albumTitle";
            this.albumTitle.Size = new System.Drawing.Size(100, 15);
            this.albumTitle.TabIndex = 1;
            this.albumTitle.Text = "Album Title";
            // 
            // albumArtist
            // 
            this.albumArtist.AutoSize = true;
            this.albumArtist.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumArtist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.albumArtist.Location = new System.Drawing.Point(-2, 115);
            this.albumArtist.Name = "albumArtist";
            this.albumArtist.Size = new System.Drawing.Size(69, 12);
            this.albumArtist.TabIndex = 2;
            this.albumArtist.Text = "Album Artist";
            // 
            // albumCoverArt
            // 
            this.albumCoverArt.Album = null;
            this.albumCoverArt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.albumCoverArt.Location = new System.Drawing.Point(0, 0);
            this.albumCoverArt.Name = "albumCoverArt";
            this.albumCoverArt.Size = new System.Drawing.Size(100, 100);
            this.albumCoverArt.TabIndex = 0;
            this.albumCoverArt.TabStop = false;
            this.albumCoverArt.Click += new System.EventHandler(this.AlbumCoverArtClick);
            // 
            // AlbumCoverAndText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.albumArtist);
            this.Controls.Add(this.albumTitle);
            this.Controls.Add(this.albumCoverArt);
            this.Margin = new System.Windows.Forms.Padding(15);
            this.Name = "AlbumCoverAndText";
            this.Size = new System.Drawing.Size(100, 125);
            ((System.ComponentModel.ISupportInitialize)(this.albumCoverArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBoxDS albumCoverArt;
        private System.Windows.Forms.Label albumTitle;
        private System.Windows.Forms.Label albumArtist;
    }
}
