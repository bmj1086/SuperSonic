using System.Collections.Generic;
using System.Windows.Forms;
using SharpSub.Data;

namespace SuperSonic.CustomControls
{
    public class ArtistsControl : UserControl
    {
        public ArtistsControl(IList<Artist> artistList)
        {
            Init();
            Controls.Add(new ArtistViewer.ArtistViewer(artistList) { Dock = DockStyle.Fill });
        }

        public void Init()
        {
            SuspendLayout();
            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            ResumeLayout(false);
        }

        public object Owner { get; set; }
    }
}
