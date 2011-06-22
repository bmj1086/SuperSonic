using System.Collections.Generic;
using System.Windows.Forms;
using SharpSub.Data;
using SuperSonic.CustomControls.AlbumViewer;

namespace SuperSonic.MainControls
{
    public class AlbumsControl : UserControl
    {
        public AlbumsControl(IList<Artist> artistList)
        {
            Init();
            Controls.Add(new AlbumViewer(artistList) {Dock = DockStyle.Fill});
        }

        public AlbumsControl(Artist artist)
        {
            Init();
            Controls.Add(new AlbumViewer(artist) { Dock = DockStyle.Fill });
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
