using System;
using System.Drawing;
using System.Windows.Forms;
using SharpSub.Data;

namespace SuperSonic.CustomControls.SongViewer
{
    public partial class SongItem : UserControl
    {
        public SongItem(Song song)
        {
            InitializeComponent();
            track.Text = song.Track.ToString();
            songName.Text = song.Title;
            duration.Text = string.Format("{0}:{1}", TimeSpan.FromSeconds((double)song.Duration).Minutes,TimeSpan.FromSeconds((double)song.Duration).Seconds.ToString("00"));
        }

        private Color DefaultColorRgb { get; set; }

        private void SongItemMouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(60, 60, 60);
        }

        private void SongItemMouseLeave(object sender, EventArgs e)
        {
            BackColor = DefaultColorRgb;
        }

        private void SongItemLoad(object sender, EventArgs e)
        {
            DefaultColorRgb = BackColor;
        }
    }
}
