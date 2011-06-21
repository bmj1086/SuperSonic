using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Dock = DockStyle.Fill;
        }
    }
}
