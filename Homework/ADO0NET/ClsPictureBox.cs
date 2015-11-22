using ADO.NET._3._Connected_連線作業;
using ADO0NET.Homework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO0NET
{
    internal  class ClsPictureBox
    {
         internal PictureBox pictureBox;       
        internal static FrmMyAlbum Form1;

        internal  ClsPictureBox()
        {
            pictureBox = new PictureBox();
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Height = 120;
            pictureBox.Width = 160;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Margin = new System.Windows.Forms.Padding(5);
            pictureBox.Padding = new System.Windows.Forms.Padding(2);
            pictureBox.MouseEnter += picturebox_MouseEnter;
            pictureBox.MouseLeave += picturebox_MouseLeave;
            pictureBox.MouseClick += picturebox_MouseClick;
        }
        void picturebox_MouseClick(object sender, MouseEventArgs e)
        {
            FrmImage f = new FrmImage();
            f.Show();
        }

        void picturebox_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.White;
        }

        private void picturebox_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Salmon;
        }
    }
}
