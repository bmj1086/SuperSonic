using System.Linq;
using System.Threading;
using System.Windows.Forms;
using SharpSub.Data;

namespace SuperSonic.CustomControls.SongViewer
{
    public partial class SongViewer : UserControl
    {
        public SongViewer(Artist artist)
        {
            InitializeComponent();
            ThreadPool.QueueUserWorkItem(CreateSongContainerArtist, artist);
        }

        public SongViewer(Album album)
        {
            InitializeComponent();
            ThreadPool.QueueUserWorkItem(CreateSongContainerAlbum, album);
        }

        public void CreateSongContainerArtist(object artist)
        {
            var albumList = SubsonicRequest.GetArtistAlbums((Artist)artist);
            var count = 0;
            var last = albumList.Count - 1;
            foreach (var album in albumList.Select(a => new SongsContainer(a)))
            {
                mainContainer.Invoke((MethodInvoker) delegate
                {
                    mainContainer.Controls.Add(album);
                    if(count < last)
                        mainContainer.Controls.Add(new Separator());
                });
                count++;
            }
        }

        public void CreateSongContainerAlbum(object album)
        {
            var newSongContainer = new SongsContainer((Album)album);
            mainContainer.Invoke((MethodInvoker)(() => mainContainer.Controls.Add(newSongContainer)));
        }

        private void MainContainerControlAdded(object sender, ControlEventArgs e)
        {
            
        }
    }
}
