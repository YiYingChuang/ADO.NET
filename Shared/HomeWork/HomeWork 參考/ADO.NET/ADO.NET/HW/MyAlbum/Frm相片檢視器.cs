using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADO.NET.HW;

namespace MyHomework._1128
{
    public partial class Frm相片檢視器 : Form
    {
        public Frm相片檢視器()
        {
            InitializeComponent();

        }
        private void Frm相片檢視器_Load(object sender, EventArgs e)
        {
            f_MyAlbum = (FrmMyAlbum)Application.OpenForms["FrmMyAlbum"];
            if (f_MyAlbum != null)
            {
                this.pictureBox1.Image = ((PictureBox)f_MyAlbum.flowLayoutPanel1.Controls[CurrentPictureIndex]).Image;
            }
            OriginalPicWith = this.Width;
            OriginalPicHeight = this.Height;
        }


        FrmMyAlbum f_MyAlbum;
        bool Flag = true;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Dock = DockStyle.Fill;
            if (Flag)
            {
                this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else
            {
                this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
   
            }
            Flag = !Flag;
        }
       internal int CurrentPictureIndex;
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = !this.timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (f_MyAlbum == null) return;
                CurrentPictureIndex += 1;
              
                if (CurrentPictureIndex > f_MyAlbum.flowLayoutPanel1.Controls.Count - 1)
                {
                    CurrentPictureIndex = 0;
                }
                this.pictureBox1.Image = ((PictureBox)f_MyAlbum.flowLayoutPanel1.Controls[CurrentPictureIndex]).Image;

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (f_MyAlbum == null) return;
            if (CurrentPictureIndex + 1 <= f_MyAlbum.flowLayoutPanel1.Controls.Count - 1)
            {
                CurrentPictureIndex += 1;
                this.pictureBox1.Image = ((PictureBox)f_MyAlbum.flowLayoutPanel1.Controls[CurrentPictureIndex]).Image;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (f_MyAlbum == null) return;
            if (CurrentPictureIndex - 1 >= 0)
            {
                CurrentPictureIndex -= 1;
                this.pictureBox1.Image = ((PictureBox)f_MyAlbum.flowLayoutPanel1.Controls[CurrentPictureIndex]).Image;
            }
        }

        int OriginalPicWith, OriginalPicHeight;

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.pictureBox1.Dock = DockStyle.None;
         
            this.pictureBox1.Width = this.OriginalPicWith * this.trackBar1.Value ;
            this.pictureBox1.Height = this.OriginalPicHeight * this.trackBar1.Value; 
            this.pictureBox1.Left = (this.ClientSize.Width - this.pictureBox1.Width) / 2;
        }

        private void Frm相片檢視器_Resize(object sender, EventArgs e)
        {
             OriginalPicWith = this.Width;
             OriginalPicHeight = this.Height;
        }

      
      
    }
}
