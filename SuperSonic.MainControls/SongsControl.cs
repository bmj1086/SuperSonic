using System.Windows.Forms;
using SharpSub.Data;

namespace SuperSonic.MainControls
{
    public class SongsControl : UserControl
    {
        public SongsControl(Artist artist)
        {
            Init();
        }
        public SongsControl(Album album)
        {
            Init();
        }

        public void Init()
        {
            SuspendLayout();
            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            ResumeLayout(false);
        }
    }
}
