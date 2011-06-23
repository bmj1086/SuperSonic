using System.Collections.Generic;
using System.Windows.Forms;
using SharpSub.Data;

namespace SuperSonic.CustomControls
{
    public class AlbumsControl : UserControl
    {
        public AlbumsControl(IList<Artist> artistList)
        {
            Init();
            Controls.Add(new AlbumViewer.AlbumViewer(artistList) {Dock = DockStyle.Fill});
        }

        public AlbumsControl(Artist artist)
        {
            Init();
            Controls.Add(new AlbumViewer.AlbumViewer(artist) { Dock = DockStyle.Fill });
        }

        public void Init()
        {
            SuspendLayout();
            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            ResumeLayout(false);
        }
    }
}
