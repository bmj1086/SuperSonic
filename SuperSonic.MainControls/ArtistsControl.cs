using System.Collections.Generic;
using System.Windows.Forms;
using SharpSub.Data;
using SuperSonic.CustomControls.ArtistViewer;

namespace SuperSonic.MainControls
{
    public class ArtistsControl : UserControl
    {
        public ArtistsControl(IList<Artist> artistList)
        {
            Init();
            Controls.Add(new ArtistViewer(artistList) { Dock = DockStyle.Fill });
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
