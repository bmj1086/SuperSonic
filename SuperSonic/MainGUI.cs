using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using SharpSub.Data;
using SuperSonic.CustomControls.AlbumViewer;

namespace SuperSonic.GUI
{
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();
            const string serverUrl = "bmjones.com:56565/music";
            const string username = "Guest";
            const string password = "notbrett";
            var loginResponse = SubsonicRequest.Login(serverUrl, username, password);

            if (!loginResponse.Successful)
                return;
            ThreadPool.QueueUserWorkItem(LoadArtistList, loginResponse.Successful);
            ThreadPool.QueueUserWorkItem(AddAlbumViewer, ArtistList);
        }

        private void LoadArtistList(object loginSuccessful)
        {
            if ((bool)loginSuccessful)
                ArtistList = SubsonicRequest.GetArtistList();
        }

        private readonly object lockObj = new object();
        private IList<Artist> artistList;
        public IList<Artist> ArtistList
        {
            get
            {
                lock (lockObj)
                {
                    if (artistList == null)
                        ArtistList = SubsonicRequest.GetArtistList();
                    return artistList;
                }
            }
            set { artistList = value; }
        }

        private void AddAlbumViewer(object newArtistList)
        {
            Invoke((MethodInvoker)(() => Controls.Add(new AlbumViewer((IList<Artist>) newArtistList) {Dock = DockStyle.Fill, BorderStyle = BorderStyle.FixedSingle})));
        }

        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
    }
}
