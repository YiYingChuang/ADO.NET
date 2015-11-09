using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ADO0NET.Properties;
using System.IO;

namespace ADO0NET.Homework
{
    public partial class FrmMyAlbum : Form
    {
        public FrmMyAlbum()
        {
            InitializeComponent();
            AddCategoryName();
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.DragEnter += flowLayoutPanel1_DragEnter;
            this.flowLayoutPanel1.DragDrop += flowLayoutPanel1_DragDrop;
        }

        void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
            PictureBox picturebox = new PictureBox();
            picturebox.BorderStyle = BorderStyle.FixedSingle;
            picturebox.Height = 120;
            picturebox.Width = 160;
            picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            picturebox.Image = Image.FromFile(filenames[0]);
            this.flowLayoutPanel1.Controls.Add(picturebox);
            byte[] bytes;
            MemoryStream ms = new MemoryStream();
           picturebox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            bytes = ms.GetBuffer();

        }

        void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        List<int> CategoryID = new List<int>();
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
                        while (datareader.Read())
                        {
                            LinkLabel newlink = new LinkLabel();
                            newlink.Text = datareader["CategoryName"].ToString();
                            int i = (int)datareader["CategoryID"]   ;
                            this.CategoryID.Add(i);
                            this.flowLayoutPanel2.Controls.Add(newlink);
                            newlink.Click += newlink_Click;
                        }
                    }
                }
            }
        }

        int i = 0;
        void newlink_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = Settings.Default.MyAlbumConnectionString;
                i = this.CategoryID[((LinkLabel)sender).TabIndex];
                using (SqlCommand comm = new SqlCommand("select * from Photos where CategoryID="+i, conn))
                {
                    conn.Open();
                    using (SqlDataReader datareader = comm.ExecuteReader())
                    {
                        this.flowLayoutPanel1.Controls.Clear();
                        while (datareader.Read())
                        {
                            this.flowLayoutPanel3.Controls.Clear();
                            PictureBox picturebox = new PictureBox();
                            picturebox.BorderStyle = BorderStyle.FixedSingle;
                            picturebox.Height = 120;
                            picturebox.Width = 160;
                            picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
                            
                            byte[] bytes = (byte[])datareader["Picture"];
                            MemoryStream ms = new MemoryStream(bytes);
                            picturebox.Image = Image.FromStream(ms); 

                            this.flowLayoutPanel1.Controls.Add(picturebox);
                        }
                    }
                }
            }
        }

        private void FrmMyAlbum_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'frmMyAlbumDataSet.PhotoCategory' 資料表。您可以視需要進行移動或移除。
            this.photoCategoryTableAdapter.Fill(this.frmMyAlbumDataSet.PhotoCategory);
            // TODO:  這行程式碼會將資料載入 'frmMyAlbumDataSet.Photos' 資料表。您可以視需要進行移動或移除。
            this.photosTableAdapter.Fill(this.frmMyAlbumDataSet.Photos);
        }
        private void photoCategoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.photoCategoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.frmMyAlbumDataSet);
        }
        private void photosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.photosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.frmMyAlbumDataSet);
        }

        private void Browser_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.picturePictureBox.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }
        void insertphotos(byte[]  x )
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumConnectionString))
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = "insert Photos(CategoryID,Picture) values(@CategoryID,@Picture)";

                        //TODO...
                        //comm.Parameters.Add("@CategoryID", SqlDbType.Int)
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       

    }
}
