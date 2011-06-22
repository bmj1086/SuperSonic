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
            Init(artistList);
        }

        public AlbumViewer(Artist artist)
        {
            Init(new List<Artist> {artist});
        }

        public void Init(IList<Artist> artistList)
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

            foreach (var albumCoverAndText in AlbumList.Select(a => new AlbumCoverAndText(a)))
            {
                if(albumContainer.InvokeRequired)
                {
                    albumContainer.Invoke((MethodInvoker)delegate
                    {
                        albumContainer.Controls.Add(albumCoverAndText);
                        albumContainer.Refresh();
                    });
                }
                else
                {
                    albumContainer.Controls.Add(albumCoverAndText);
                    albumContainer.Refresh();
                }
            }
        }

    }
}
