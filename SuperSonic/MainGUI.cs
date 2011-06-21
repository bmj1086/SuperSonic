using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using SharpSub.Data;
using SuperSonic.MainControls;

namespace SuperSonic.GUI
{
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();
            const string serverUrl = "bmjones.com:56565";
            const string username = "Guest";
            const string password = "notbrett";
            var loginResponse = SubsonicRequest.Login(serverUrl, username, password);

            if (!loginResponse.Successful)
                return;
            ThreadPool.QueueUserWorkItem(LoadArtistList, loginResponse.Successful);
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
            if (mainContainer.Panel2.InvokeRequired)
            {
                mainContainer.Panel2.Invoke((MethodInvoker)delegate
                {
                    mainContainer.Panel2.Controls.Clear();
                    mainContainer.Panel2.Controls.Add(new AlbumsControl((IList<Artist>)newArtistList));
                });
            }
            else
            {
                mainContainer.Panel2.Controls.Clear();
                mainContainer.Panel2.Controls.Add(new AlbumsControl((IList<Artist>) newArtistList));
            }
        }

        private void AddArtistViewer(object newArtistList)
        {
            if (mainContainer.Panel2.InvokeRequired)
            {
                
                mainContainer.Panel2.Invoke((MethodInvoker)delegate
                {
                    mainContainer.Panel2.Controls.Clear();
                    mainContainer.Panel2.Controls.Add(new ArtistsControl((IList<Artist>) newArtistList));
                });
            }
            else
            {
                mainContainer.Panel2.Controls.Clear();
                mainContainer.Panel2.Controls.Add(new ArtistsControl((IList<Artist>)newArtistList));
            }
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

        private void MainGUI_Load(object sender, System.EventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(AddArtistViewer, ArtistList);
        }

        private void label2_Click(object sender, System.EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(AddAlbumViewer, ArtistList);
        }
    }
}
