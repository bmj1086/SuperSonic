using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using SharpSub.Data;
using SuperSonic.CustomControls;

namespace SuperSonic.GUI
{
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();
            MainGuiInstance = this;
            const string serverUrl = "bmjones.com:56565";
            const string username = "Guest";
            const string password = "notbrett";
            var loginResponse = SubsonicRequest.Login(serverUrl, username, password);

            if (!loginResponse.Successful)
                return;
            ThreadPool.QueueUserWorkItem(LoadArtistList, loginResponse.Successful);
        }

        public static object MainGuiInstance;

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
            if (controlPanel.InvokeRequired)
            {
                controlPanel.Invoke((MethodInvoker)delegate
                {
                    controlPanel.Controls.Clear();
                    controlPanel.Controls.Add(new AlbumsControl((IList<Artist>)newArtistList) { Dock = DockStyle.Fill, Parent = this });
                });
            }
            else
            {
                controlPanel.Controls.Clear();
                controlPanel.Controls.Add(new AlbumsControl((IList<Artist>)newArtistList) { Dock = DockStyle.Fill, Parent = this });
            }
        }

        private void AddArtistViewer(object newArtistList)
        {
            if (controlPanel.InvokeRequired)
            {

                controlPanel.Invoke((MethodInvoker)delegate
                {
                    controlPanel.Controls.Clear();
                    controlPanel.Controls.Add(new ArtistsControl((IList<Artist>)newArtistList) { Dock = DockStyle.Fill, Owner = controlPanel});
                });
            }
            else
            {
                controlPanel.Controls.Clear();
                controlPanel.Controls.Add(new ArtistsControl((IList<Artist>)newArtistList) { Dock = DockStyle.Fill, Owner = controlPanel });
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

        private void MainGUILoad(object sender, System.EventArgs e)
        {

        }

        private void Label1Click(object sender, System.EventArgs e)
        {
            breadCrumb.Controls.Clear();
            breadCrumb.Controls.Add(CreateBreadCrumb("Artists"));
            ThreadPool.QueueUserWorkItem(AddArtistViewer, ArtistList);
        }

        private void Label2Click(object sender, System.EventArgs e)
        {
            breadCrumb.Controls.Clear();
            breadCrumb.Controls.Add(CreateBreadCrumb("Albums"));
            ThreadPool.QueueUserWorkItem(AddAlbumViewer, ArtistList);
        }

        public static Label CreateBreadCrumb(string text)
        {
            return new Label
                       {
                           Text = text, 
                           Padding = new Padding(0, 5, 10, 5), 
                           ForeColor = Color.WhiteSmoke,
                           Font = new Font("Verdana", 8, FontStyle.Bold)
                       };
        }
    }
}
