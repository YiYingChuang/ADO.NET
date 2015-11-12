using ADO.NET._3._Connected_連線作業;
using ADO0NET.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO0NET.Homework
{
    public partial class FrmMyAlbum : Form
    {
        public FrmMyAlbum()
        {
            InitializeComponent();
            
            this.flowLayoutPanel3.AllowDrop = true;
            this.flowLayoutPanel3.DragEnter += flowLayoutPanel_DragEnter;
            this.flowLayoutPanel3.DragDrop += flowLayoutPanel_DragDrop;
            this.flowLayoutPanel2.AllowDrop = true;
            this.flowLayoutPanel2.DragEnter += flowLayoutPanel_DragEnter;
            this.flowLayoutPanel2.DragDrop += flowLayoutPanel_DragDrop;
            ClsPictureBox.Form1 = this;

          
        }
        List<int> CategoryID = new List<int>();
        int photoCategoryID;

        void flowLayoutPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);

            //=====================
            PictureBox pictureBox = new PictureBox();
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Height = 120;
            pictureBox.Width = 160;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Margin = new System.Windows.Forms.Padding(5);
            pictureBox.Padding = new System.Windows.Forms.Padding(2);
            pictureBox.MouseEnter += picturebox_MouseEnter;
            pictureBox.MouseLeave += picturebox_MouseLeave;
            pictureBox.MouseClick += picturebox_MouseClick;
            //=====================

            pictureBox.Image = Image.FromFile(filenames[0]);
            this.flowLayoutPanel3.Controls.Add(pictureBox);
            byte[] bytes;
            MemoryStream ms = new MemoryStream();
            pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            bytes = ms.GetBuffer();
            this.insertphotos(bytes);
        }

        void flowLayoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'myAlbumDataSet.Photos' 資料表。您可以視需要進行移動或移除。
            this.photosTableAdapter.Fill(this.myAlbumDataSet.Photos);

            // TODO:  這行程式碼會將資料載入 'myAlbumDataSet.PhotoCategory' 資料表。您可以視需要進行移動或移除。
            this.photoCategoryTableAdapter.Fill(this.myAlbumDataSet.PhotoCategory);

            AddCategoryName();
            this.comboBox1.SelectedIndex = 0;
        }

        private void AddCategoryName()
        {
            using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumConnectionString))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand("select * from PhotoCategory", conn))
                {

                    using (SqlDataReader datareader = comm.ExecuteReader())
                    {
                        this.CategoryID.Clear();
                        this.flowLayoutPanel1.Controls.Clear();
                        while (datareader.Read())
                        {
                            
                            LinkLabel newlink = new LinkLabel();
                            string s = datareader["CategoryName"].ToString();
                            newlink.Text = s;
                            int i = (int)datareader["CategoryID"];
                            this.CategoryID.Add(i);
                            this.comboBox1.Items.Add(s);
                            this.flowLayoutPanel1.Controls.Add(newlink);
                            newlink.Click += newlink_Click;
                        }
                    }
                }
            }
        }

        void insertphotos(byte[] x)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumConnectionString))
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = "insert Photos(CategoryID,Picture) values(@CategoryID,@Picture)";
                        comm.Parameters.Add("@CategoryID", SqlDbType.Int).Value = photoCategoryID;
                        comm.Parameters.Add("@Picture", SqlDbType.VarBinary).Value = x;

                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        void newlink_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumConnectionString))
            {
               photoCategoryID = this.CategoryID[((LinkLabel)sender).TabIndex];
                using (SqlCommand comm = new SqlCommand("select * from Photos where CategoryID=" + photoCategoryID, conn))
                {
                    conn.Open();
                    using (SqlDataReader datareader = comm.ExecuteReader())
                    {
                        this.flowLayoutPanel2.Controls.Clear();
                        while (datareader.Read())
                        {
                            //============================
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.BorderStyle = BorderStyle.FixedSingle;
                            pictureBox.Height = 120;
                            pictureBox.Width = 160;
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox.Margin = new System.Windows.Forms.Padding(5);
                            pictureBox.Padding = new System.Windows.Forms.Padding(2);
                            pictureBox.MouseEnter += picturebox_MouseEnter;
                            pictureBox.MouseLeave += picturebox_MouseLeave;
                            pictureBox.MouseClick += picturebox_MouseClick;
                            //============================

                            byte[] bytes = (byte[])datareader["Picture"];
                            MemoryStream ms = new MemoryStream(bytes);
                            pictureBox.Image = Image.FromStream(ms);
                            
                            this.flowLayoutPanel2.Controls.Add(pictureBox);
                        }
                    }
                }
            }
        }

        void picturebox_MouseClick(object sender, MouseEventArgs e)
        {
            FrmImageFlags f = new FrmImageFlags();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumConnectionString))
            {
                 photoCategoryID = this.CategoryID[((ComboBox)sender).SelectedIndex];
                using (SqlCommand comm = new SqlCommand("select * from Photos where CategoryID=" + photoCategoryID, conn))
                {
                    conn.Open();
                    using (SqlDataReader datareader = comm.ExecuteReader())
                    {
                        this.flowLayoutPanel3.Controls.Clear();
                        while (datareader.Read())
                        {
                            ClsPictureBox box = new ClsPictureBox();
                            byte[] bytes = (byte[])datareader["Picture"];
                            MemoryStream ms = new MemoryStream(bytes);
                            box.pictureBox.Image = Image.FromStream(ms);
                            box.image = Image.FromStream(ms);

                            this.flowLayoutPanel3.Controls.Add(box.pictureBox);
                        }
                    }
                }
            }


        }

        private void photoCategoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.photoCategoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myAlbumDataSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.picturePictureBox.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }

      
    }
}
