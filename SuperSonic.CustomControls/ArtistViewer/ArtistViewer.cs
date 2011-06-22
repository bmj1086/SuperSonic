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
            ArtistList = artistList;
            mainContainer.AutoSize = false;
            ThreadPool.QueueUserWorkItem(CreateArtistViewer, ArtistList);
        }

        public IList<Artist> ArtistList { get; set; }

        private void CreateArtistViewer(object artistList)
        {
            foreach(var artist in (IList<Artist>)artistList)
            {
                var artistItem = new ArtistItem(artist) {Width = Parent.Width - 20};
                if (mainContainer.InvokeRequired)
                {
                    mainContainer.Invoke((MethodInvoker)delegate
                    {
                        mainContainer.Controls.Add(artistItem);
                        mainContainer.Refresh();
                    });
                }
                else
                {
                    mainContainer.Controls.Add(artistItem);
                    mainContainer.Refresh();
                }
            }
        }

        private void MainContainerResize(object sender, System.EventArgs e)
        {
            SuspendLayout();
            foreach(ArtistItem i in mainContainer.Controls)
            {
                i.Width = Width - 20;
            }
            ResumeLayout(true);
        }
    }
}
