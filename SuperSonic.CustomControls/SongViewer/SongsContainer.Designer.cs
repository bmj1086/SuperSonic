namespace SuperSonic.CustomControls.SongViewer
{
    partial class SongsContainer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.albumName = new System.Windows.Forms.Label();
            this.artistName = new System.Windows.Forms.Label();
            this.songListPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // albumName
            // 
            this.albumName.AutoSize = true;
            this.albumName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.albumName.Location = new System.Drawing.Point(3, 106);
            this.albumName.Name = "albumName";
            this.albumName.Size = new System.Drawing.Size(89, 13);
            this.albumName.TabIndex = 1;
            this.albumName.Text = "Album Name";
            // 
            // artistName
            // 
            this.artistName.AutoSize = true;
            this.artistName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.artistName.Location = new System.Drawing.Point(3, 121);
            this.artistName.Name = "artistName";
            this.artistName.Size = new System.Drawing.Size(74, 13);
            this.artistName.TabIndex = 2;
            this.artistName.Text = "Artist Name";
            // 
            // songListPanel
            // 
            this.songListPanel.Location = new System.Drawing.Point(153, 3);
            this.songListPanel.Name = "songListPanel";
            this.songListPanel.Size = new System.Drawing.Size(367, 140);
            this.songListPanel.TabIndex = 3;
            // 
            // SongsContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.songListPanel);
            this.Controls.Add(this.artistName);
            this.Controls.Add(this.albumName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SongsContainer";
            this.Size = new System.Drawing.Size(523, 146);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label albumName;
        private System.Windows.Forms.Label artistName;
        private System.Windows.Forms.FlowLayoutPanel songListPanel;
    }
}
