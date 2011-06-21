using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using SharpSub.Data;

namespace SuperSonic.CustomControls.ArtistViewer
{
    public partial class ArtistViewer : UserControl
    {
        public ArtistViewer(IList<Artist> artistList)
        {
            InitializeComponent();
            mainContainer.HorizontalScroll.Enabled = false;
            ArtistList = artistList;
            ThreadPool.QueueUserWorkItem(CreateArtistViewer, ArtistList);
        }

        public IList<Artist> ArtistList { get; set; }

        private void CreateArtistViewer(object artistList)
        {
            foreach(var artist in (IList<Artist>)artistList)
            {
                if(mainContainer.InvokeRequired)
                    mainContainer.Invoke((MethodInvoker) (() => mainContainer.Controls.Add(new ArtistItem(artist) { Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right), Width = Parent.Width - 23 })));
                else
                    mainContainer.Controls.Add(new ArtistItem(artist) { Dock = DockStyle.Top });
            }
        }
    }
}
