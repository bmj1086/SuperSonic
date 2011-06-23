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
            this.coverArt = new System.Windows.Forms.PictureBox();
            this.albumName = new System.Windows.Forms.Label();
            this.artistName = new System.Windows.Forms.Label();
            this.songListPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.coverArt)).BeginInit();
            this.SuspendLayout();
            // 
            // coverArt
            // 
            this.coverArt.Location = new System.Drawing.Point(3, 3);
            this.coverArt.Name = "coverArt";
            this.coverArt.Size = new System.Drawing.Size(100, 100);
            this.coverArt.TabIndex = 0;
            this.coverArt.TabStop = false;
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
            this.songListPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.songListPanel.Location = new System.Drawing.Point(150, 0);
            this.songListPanel.Name = "songListPanel";
            this.songListPanel.Size = new System.Drawing.Size(400, 146);
            this.songListPanel.TabIndex = 3;
            this.songListPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.SongListPanelControlAdded);
            // 
            // SongsContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.songListPanel);
            this.Controls.Add(this.artistName);
            this.Controls.Add(this.albumName);
            this.Controls.Add(this.coverArt);
            this.Name = "SongsContainer";
            this.Size = new System.Drawing.Size(550, 146);
            ((System.ComponentModel.ISupportInitialize)(this.coverArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coverArt;
        private System.Windows.Forms.Label albumName;
        private System.Windows.Forms.Label artistName;
        private System.Windows.Forms.FlowLayoutPanel songListPanel;
    }
}
