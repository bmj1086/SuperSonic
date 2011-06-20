namespace SuperSonic.CustomControls.AlbumViewer
{
    partial class AlbumViewer
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
            this.albumContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // albumContainer
            // 
            this.albumContainer.AutoScroll = true;
            this.albumContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.albumContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albumContainer.Location = new System.Drawing.Point(0, 0);
            this.albumContainer.Name = "albumContainer";
            this.albumContainer.Size = new System.Drawing.Size(376, 223);
            this.albumContainer.TabIndex = 0;
            // 
            // AlbumViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.albumContainer);
            this.Name = "AlbumViewer";
            this.Size = new System.Drawing.Size(376, 223);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel albumContainer;

    }
}
