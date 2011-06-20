using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using SharpSub.Data;

namespace SuperSonic.CustomControls.AlbumViewer
{
    public partial class AlbumViewer : UserControl
    {
        public AlbumViewer(IList<Artist> artistList)
        {
            InitializeComponent();
            ArtistList = artistList;
            albumContainer.HorizontalScroll.Enabled = false;
            ThreadPool.QueueUserWorkItem(CreateAlbumView, ArtistList);
        }

        private IList<Artist> ArtistList { get; set; }
        private IList<Album> AlbumList { get; set; }
        private void CreateAlbumView(object artistList)
        {
            AlbumList = new List<Album>();

            foreach (var album in ((IList<Artist>) artistList).Select(SubsonicRequest.GetArtistAlbums).SelectMany(tempAlbumList => tempAlbumList))
                AlbumList.Add(album);

            foreach (var a in AlbumList)
            {
                albumContainer.Invoke((MethodInvoker)delegate
                {
                    albumContainer.Controls.Add(new AlbumCoverAndText(a));
                    albumContainer.Refresh();
                });

            }
        }

    }
}
