using ADO.NET.Properties;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MyHomework;
using MyHomework._1128;

namespace ADO.NET.HW
{
    public partial class FrmMyAlbum : Form
    {
        public FrmMyAlbum()
        {
            InitializeComponent();

            this.photosTableAdapter1.Connection.ConnectionString = Settings.Default.MyAlbumConnectionString;
                  

            GetPhotoCategories();
            this.flowLayoutPanel3.AllowDrop = true;
           
        }

        class MyPhotoCategory
        {
            public int CategoryID;
            public string CategoryName;
            public override string ToString()
            {
                return this.CategoryName;
            }
        }
        private void GetPhotoCategories()
        {
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.WrapContents = false;
            this.flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;


            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("Select * from  PhotoCategory", conn))
                    {
                        conn.Open();
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            this.comboBox1.Items.Clear();
                            this.flowLayoutPanel2.Controls.Clear();
                            while (dataReader.Read())
                            {
                                this.comboBox1.Items.Add(new  MyPhotoCategory { CategoryID = (int)dataReader["CategoryID"], CategoryName = dataReader["CategoryName"].ToString() });
                                LinkLabel x = new LinkLabel();
                                x.AutoSize = true;
                                x.Font = new System.Drawing.Font("Arial", 17, FontStyle.Bold | FontStyle.Italic| FontStyle.Underline);
                                x.Text = dataReader["CategoryName"].ToString(); ;
                                x.Tag = dataReader["CategoryID"];
                                x.LinkClicked += x_LinkClicked;
                                x.Margin = new Padding(7);
                                this.flowLayoutPanel2.Controls.Add(x);
                                Application.DoEvents();
                            }
                            this.comboBox1.SelectedIndex = 0;
                        }
                    } 
                } 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          
        }



        LinkLabel prev_LinkLabel=null;
        void x_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (prev_LinkLabel != null)
            {
                prev_LinkLabel.BorderStyle = BorderStyle.None;
                prev_LinkLabel.BackColor = ((LinkLabel)sender).Parent.BackColor;

            }
            ((LinkLabel)sender).BorderStyle = BorderStyle.Fixed3D;
            ((LinkLabel)sender).BackColor = Color.DarkGray;
            prev_LinkLabel =(LinkLabel) sender;

            int categoryID =(int)((LinkLabel)sender).Tag;
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("Select * from  Photos where CategoryID=" + categoryID, conn))
                    {
                        conn.Open();
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            this.flowLayoutPanel1.Controls.Clear();
                            while (dataReader.Read())
                            {
                                PictureBox p = new PictureBox();
                                p.BorderStyle = BorderStyle.Fixed3D;
                                p.BackColor = Color.White;
                                p.Width = 200;
                                p.Height = 150;
                                try
                                {
                                    using (MemoryStream ms = new MemoryStream((byte[])dataReader["Picture"]))
                                    {
                                        p.Image = Image.FromStream(ms);
                                    }
                                }
                                catch
                                {
                                    p.Image = p.ErrorImage;
                                }
                                p.SizeMode = PictureBoxSizeMode.StretchImage;

                                p.Padding = new System.Windows.Forms.Padding(6);
                                p.Margin = new System.Windows.Forms.Padding(6);

                                p.MouseEnter += p_MouseEnter;
                                p.MouseLeave += p_MouseLeave;
                                p.Click += p_Click;

                                this.flowLayoutPanel1.Controls.Add(p);
                                Application.DoEvents();
                            }

                        }//Auto dataReader.Dispose()
                    } // Auto command.Dispose();
                } // Auto  conn.Dispose() =>conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void p_Click(object sender, EventArgs e)
        {
            try
            {
                Frm相片檢視器 f = new Frm相片檢視器();
                f.CurrentPictureIndex = this.flowLayoutPanel1.Controls.GetChildIndex((PictureBox)sender);

                f.Show();
            }
            catch
            { }
    
           
        }

        void p_MouseEnter(object sender, EventArgs e)
        {

            ((PictureBox)sender).BackColor = Color.Red;

        }

        void p_MouseLeave(object sender, EventArgs e)
        {

            ((PictureBox)sender).BackColor = Color.White;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMyAlbumManagement f = new FrmMyAlbumManagement();
         
            f.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.tabControl1.SelectedIndex)
            {
                case 0:
                case 1:
                    GetPhotoCategories();
                    break;
                case 2:
                    FrmMyAlbumManagement f = new FrmMyAlbumManagement();
                    f.Dock = DockStyle.Fill;
                    f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    f.TopLevel = false;
                    f.Show();
                    this.tabControl1.TabPages[this.tabControl1.SelectedIndex].Controls.Add(f);
                    break;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int categoryID = ((MyPhotoCategory)this.comboBox1.SelectedItem).CategoryID;
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("Select * from  Photos where CategoryID=" + categoryID, conn))
                    {
                        conn.Open();
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            this.flowLayoutPanel3.Controls.Clear();
                            while (dataReader.Read())
                            {
                                PictureBox p = new PictureBox();
                                p.BorderStyle = BorderStyle.Fixed3D;
                                p.BackColor = Color.White;
                                p.Width = 200;
                                p.Height = 150;
                                try
                                {
                                    using (MemoryStream ms = new MemoryStream((byte[])dataReader["Picture"]))
                                    {
                                        p.Image = Image.FromStream(ms);
                                    }
                                }
                                catch
                                {
                                    p.Image = p.ErrorImage;
                                }
                                p.SizeMode = PictureBoxSizeMode.StretchImage;

                                p.Padding = new System.Windows.Forms.Padding(6);
                                p.Margin = new System.Windows.Forms.Padding(6);

                                p.MouseEnter += p_MouseEnter;
                                p.MouseLeave += p_MouseLeave;
                                p.Click += p_Click;

                                this.flowLayoutPanel3.Controls.Add(p);
                                Application.DoEvents();
                            }

                        }//Auto dataReader.Dispose()
                    } // Auto command.Dispose();
                } // Auto  conn.Dispose() =>conn.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void flowLayoutPanel3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void flowLayoutPanel3_DragDrop(object sender, DragEventArgs e)
        {
       
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
                InsertPictureToDB(filenames);
              
            }
        }

        private void InsertPictureToDB(string[] filenames)
        {
            for (int i = 0; i <= filenames.Length - 1; i++)
                {     
                    bool IsErrorImage = false;
                    PictureBox p = new PictureBox();
                    p.BorderStyle = BorderStyle.Fixed3D;
                    p.BackColor = Color.White;
                    p.Width = 200;
                    p.Height = 150;
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    p.Padding = new System.Windows.Forms.Padding(6);
                    p.Margin = new System.Windows.Forms.Padding(6);
                    try
                    {
                        //using (FileStream fs = new FileStream(filenames[i], FileMode.Open)) //Note: 拒絕存取路徑
                        using (FileStream fs = new FileStream(filenames[i], FileMode.Open, FileAccess.Read))
                        {
                            p.Image = Image.FromStream(fs);
                       
                        }

                    }

                    catch (Exception ex)
                    {
                        //p.Image = p.ErrorImage;
                         ShowErrorImageAndText(p, ex.Message);
                         IsErrorImage = true;
                    }
                  
                  
                    p.MouseEnter += p_MouseEnter;
                    p.MouseLeave += p_MouseLeave;
                    p.Click += p_Click;
                    this.flowLayoutPanel3.Controls.Add(p);
                    Application.DoEvents();

                    //========================
                   if (! IsErrorImage)
                   {
                         int categoryID = ((MyPhotoCategory)this.comboBox1.SelectedItem).CategoryID;
                        byte[] bytes = File.ReadAllBytes(filenames[i]);
                        this.photosTableAdapter1.Insert(categoryID, "", bytes, "", DateTime.Now);
                   }
           

                }
        }

        private void ShowErrorImageAndText(PictureBox pb, string s)
        {
            Font font1 = new System.Drawing.Font("Arial", 10, FontStyle.Bold| FontStyle.Italic);
         
            Bitmap map = new Bitmap(pb.Width, pb.Height);
            Graphics g = Graphics.FromImage(map);
           
            g.DrawImage(pb.ErrorImage, 0, 0, pb.Width, pb.Height);
            g.DrawString(s, font1, Brushes.Black, 0, pb.Height/2);
            pb.Image = map;

           
            font1.Dispose();
            g.Dispose();


        }

        private void button1_Click(object sender, EventArgs e)
        {
           if ( this.folderBrowserDialog1.ShowDialog()== System.Windows.Forms.DialogResult.OK)
           {
               this.InsertPictureToDB(Directory.GetFiles( this.folderBrowserDialog1.SelectedPath));
           }

        }
    }
}
