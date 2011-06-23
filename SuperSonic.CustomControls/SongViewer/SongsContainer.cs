using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using SharpSub.Data;

namespace SuperSonic.CustomControls.SongViewer
{
    public partial class SongsContainer : UserControl
    {
        public SongsContainer(Album album)
        {
            InitializeComponent();
            albumName.Text = album.Title;
            artistName.Text = album.Artist;
            ThreadPool.QueueUserWorkItem(SetupSongsContainer,album);
        }

        public void SetupSongsContainer(object album)
        {
            var cover = ((Album) album).CoverArt(100);
            coverArt.Invoke((MethodInvoker)delegate { coverArt.Image = cover; });
            var songList = SubsonicRequest.GetAlbumSongs(((Album)album).ID);
            for (var index = 0; index < songList.Count; index++)
            {
                var song = songList[index];
                var songItem = new SongItem(song)
                                   {
                                       Dock = DockStyle.Top,
                                       BackColor = index % 2 > 0 ? Color.FromArgb(30, 30, 30) : Color.FromArgb(25, 25, 25)
                                   };
                songListPanel.Invoke((MethodInvoker) (() => songListPanel.Controls.Add(songItem)));
            }
        }

        private void SongListPanelControlAdded(object sender, ControlEventArgs e)
        {
            var heightCheck = (22*songListPanel.Controls.Count);
            Height = heightCheck > Height ? heightCheck : Height;
        }
    }
}
