using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using SharpSub.Data;

namespace SuperSonic.CustomControls.ArtistViewer
{
    public partial class ArtistItem : UserControl
    {
        public ArtistItem(Artist artist)
        {
            InitializeComponent();
            artistName.Text = artist.Name;
            randomCoverArt.Image = GetRandomAlbum(artist);
        }

        public Bitmap GetRandomAlbum(Artist artist)
        {
            var albums = SubsonicRequest.GetArtistAlbums(artist);
            var r = new Random(albums.Count);
            return albums[albums.Count - 1].CoverArt(45);
        }

        private Artist Artist { get; set; }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            var gradientBrush = new LinearGradientBrush(ClientRectangle, Color.FromArgb(40, 40, 40), Color.FromArgb(25, 25, 25), LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(gradientBrush, ClientRectangle);
        }
    }
}
