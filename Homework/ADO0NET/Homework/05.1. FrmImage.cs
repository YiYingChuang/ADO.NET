using ADO0NET;
using ADO0NET.Homework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADO.NET._3._Connected_連線作業
{
    public partial class FrmImage : Form
    {
        public FrmImage()
        {
            InitializeComponent();  
        }
       internal int pictureboxIndex;
       int PictureHeight, PictureWidth;
       int FormHeight, FormWidth;

       private void FrmImageFlags_Load(object sender, EventArgs e)
       {
           this.PictureHeight = this.pictureBox1.Height;
           this.PictureWidth = this.pictureBox1.Width;
           this.FormHeight = this.Height;
           this.FormWidth = this.Width;
           this.pictureBox1.Image = ((PictureBox)ClsPictureBox.Form1.flowLayoutPanel3.Controls[pictureboxIndex]).Image;
       }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (pictureboxIndex < ClsPictureBox.Form1.flowLayoutPanel2.Controls.Count-1)
            pictureboxIndex -= 1;
            this.pictureBox1.Image = ((PictureBox)ClsPictureBox.Form1.flowLayoutPanel3.Controls[pictureboxIndex]).Image;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (pictureboxIndex < ClsPictureBox.Form1.flowLayoutPanel3.Controls.Count-1)
            pictureboxIndex += 1;
            this.pictureBox1.Image = ((PictureBox)ClsPictureBox.Form1.flowLayoutPanel3.Controls[pictureboxIndex]).Image;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = !this.timer1.Enabled;
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureboxIndex < ClsPictureBox.Form1.flowLayoutPanel3.Controls.Count - 1)
            {
                pictureboxIndex += 1;
                this.pictureBox1.Image = ((PictureBox)ClsPictureBox.Form1.flowLayoutPanel3.Controls[pictureboxIndex]).Image;
            }
            else
            {
                pictureboxIndex = 0;
                this.pictureBox1.Image = ((PictureBox)ClsPictureBox.Form1.flowLayoutPanel3.Controls[pictureboxIndex]).Image;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Height = pictureBox1.Height * 2;
            this.pictureBox1.Width = this.pictureBox1.Width * 2;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Height = pictureBox1.Height / 2;
            this.pictureBox1.Width = this.pictureBox1.Width / 2;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Height = PictureHeight;
            this.pictureBox1.Width = PictureWidth;
        }

       
    }
}