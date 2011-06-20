﻿using System.Windows.Forms;
using SharpSub.Data;

namespace SuperSonic.CustomControls.AlbumViewer
{
    internal partial class AlbumCoverAndText : UserControl
    {
        public AlbumCoverAndText(Album album)
        {
            InitializeComponent();
            albumCoverArt.BorderStyle = BorderStyle.FixedSingle;
            albumCoverArt.Album = album;
            albumCoverArt.Image = album.CoverArt(100);
            albumTitle.Text = album.Title;
            albumArtist.Text = album.Artist;
        }

        private void AlbumCoverArtClick(object sender, System.EventArgs e)
        {
            var albumInfo = (sender as PictureBoxDS).Album;
            //MessageBox.Show(string.Format("Artist: {1}\rTitle: {0} ",albumInfo.Title,albumInfo.Artist));
        }
    }

    internal class PictureBoxDS : PictureBox
    {
        public PictureBoxDS()
        {
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        public Album Album { get; set; }
    }
}
