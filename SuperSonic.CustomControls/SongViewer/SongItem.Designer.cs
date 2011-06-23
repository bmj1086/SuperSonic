namespace SuperSonic.CustomControls.SongViewer
{
    partial class SongItem
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
            this.track = new System.Windows.Forms.Label();
            this.songName = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // track
            // 
            this.track.AutoSize = true;
            this.track.Cursor = System.Windows.Forms.Cursors.Hand;
            this.track.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.track.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.track.Location = new System.Drawing.Point(5, 4);
            this.track.Name = "track";
            this.track.Size = new System.Drawing.Size(16, 13);
            this.track.TabIndex = 0;
            this.track.Text = "#";
            this.track.MouseEnter += new System.EventHandler(this.SongItemMouseEnter);
            this.track.MouseLeave += new System.EventHandler(this.SongItemMouseLeave);
            // 
            // songName
            // 
            this.songName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songName.AutoSize = true;
            this.songName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.songName.Location = new System.Drawing.Point(38, 4);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(88, 13);
            this.songName.TabIndex = 1;
            this.songName.Text = "Name of Song";
            this.songName.MouseEnter += new System.EventHandler(this.SongItemMouseEnter);
            this.songName.MouseLeave += new System.EventHandler(this.SongItemMouseLeave);
            // 
            // duration
            // 
            this.duration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.duration.AutoSize = true;
            this.duration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duration.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duration.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.duration.Location = new System.Drawing.Point(359, 4);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(33, 13);
            this.duration.TabIndex = 2;
            this.duration.Text = "0:00";
            this.duration.MouseEnter += new System.EventHandler(this.SongItemMouseEnter);
            this.duration.MouseLeave += new System.EventHandler(this.SongItemMouseLeave);
            // 
            // SongItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.duration);
            this.Controls.Add(this.songName);
            this.Controls.Add(this.track);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SongItem";
            this.Size = new System.Drawing.Size(400, 22);
            this.Load += new System.EventHandler(this.SongItemLoad);
            this.MouseEnter += new System.EventHandler(this.SongItemMouseEnter);
            this.MouseLeave += new System.EventHandler(this.SongItemMouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label track;
        private System.Windows.Forms.Label songName;
        private System.Windows.Forms.Label duration;
    }
}
