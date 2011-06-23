namespace SuperSonic.GUI
{
    partial class MainGUI
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
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.breadCrumb = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Artist = new System.Windows.Forms.Label();
            this.songName = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainContainer.IsSplitterFixed = true;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.mainContainer.Panel1.Controls.Add(this.label4);
            this.mainContainer.Panel1.Controls.Add(this.label3);
            this.mainContainer.Panel1.Controls.Add(this.label2);
            this.mainContainer.Panel1.Controls.Add(this.label1);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.mainContainer.Panel2.Controls.Add(this.controlPanel);
            this.mainContainer.Panel2.Controls.Add(this.breadCrumb);
            this.mainContainer.Size = new System.Drawing.Size(727, 292);
            this.mainContainer.SplitterDistance = 145;
            this.mainContainer.SplitterWidth = 1;
            this.mainContainer.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "My Library";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Songs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Albums";
            this.label2.Click += new System.EventHandler(this.Label2Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artists";
            this.label1.Click += new System.EventHandler(this.Label1Click);
            // 
            // controlPanel
            // 
            this.controlPanel.AutoScroll = true;
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(0, 25);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(581, 267);
            this.controlPanel.TabIndex = 1;
            // 
            // breadCrumb
            // 
            this.breadCrumb.Dock = System.Windows.Forms.DockStyle.Top;
            this.breadCrumb.Location = new System.Drawing.Point(0, 0);
            this.breadCrumb.Name = "breadCrumb";
            this.breadCrumb.Size = new System.Drawing.Size(581, 25);
            this.breadCrumb.TabIndex = 0;
            this.breadCrumb.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.Artist);
            this.panel1.Controls.Add(this.songName);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 30);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::SuperSonic.GUI.Properties.Resources.repeatbutton;
            this.pictureBox7.Location = new System.Drawing.Point(663, 4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(24, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(146, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(27, 27);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // Artist
            // 
            this.Artist.AutoSize = true;
            this.Artist.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Artist.Location = new System.Drawing.Point(174, 15);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(66, 12);
            this.Artist.TabIndex = 7;
            this.Artist.Text = "Artist Name";
            // 
            // songName
            // 
            this.songName.AutoSize = true;
            this.songName.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.songName.Location = new System.Drawing.Point(174, 3);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(60, 12);
            this.songName.TabIndex = 6;
            this.songName.Text = "Song Name";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SuperSonic.GUI.Properties.Resources.shufflebutton;
            this.pictureBox5.Location = new System.Drawing.Point(632, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 19);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SuperSonic.GUI.Properties.Resources.soundbutton;
            this.pictureBox4.Location = new System.Drawing.Point(693, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SuperSonic.GUI.Properties.Resources.forwardbutton;
            this.pictureBox3.Location = new System.Drawing.Point(96, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SuperSonic.GUI.Properties.Resources.playbutton;
            this.pictureBox2.Location = new System.Drawing.Point(61, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SuperSonic.GUI.Properties.Resources.backwardbutton;
            this.pictureBox1.Location = new System.Drawing.Point(21, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(265, 5);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(361, 42);
            this.trackBar1.TabIndex = 0;
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(727, 323);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainContainer);
            this.MinimumSize = new System.Drawing.Size(735, 350);
            this.Name = "MainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperSonic";
            this.Load += new System.EventHandler(this.MainGUILoad);
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel1.PerformLayout();
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel breadCrumb;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label Artist;
        private System.Windows.Forms.Label songName;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

