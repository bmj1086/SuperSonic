using System.Windows.Forms;
using SharpSub.Data;

namespace SuperSonic.CustomControls
{
    public class SongsControl : UserControl
    {
        public SongsControl(Artist artist)
        {
            Init();
            var panel = new Panel { AutoScroll = true, Dock = DockStyle.Fill };
            Controls.Add(panel);
            var viewer = new SongViewer.SongViewer(artist) { Dock = DockStyle.Fill };
            panel.Height = viewer.Height;
            panel.Controls.Add(viewer);
        }
        public SongsControl(Album album)
        {
            Init();
            var panel = new Panel { AutoScroll = true, Dock = DockStyle.Fill };
            Controls.Add(panel);
            var viewer = new SongViewer.SongViewer(album) { Dock = DockStyle.Fill };
            panel.Height = viewer.Height;
            panel.Controls.Add(viewer);
        }

        private void Init()
        {
            SuspendLayout();
            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            ResumeLayout(false);
        }
    }
}
