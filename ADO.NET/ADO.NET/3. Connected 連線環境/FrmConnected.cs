using ADO.NET.Properties;
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
using System.Transactions;
using System.Web.Security;
using System.Windows.Forms;

namespace ADO.NET._3._Connected_連線環境
{
  
    public partial class FrmConnected : Form
    {
        public FrmConnected()
        {
            InitializeComponent();
            LoadCountryToComboBox();
            CreateListViewColumns();

            this.tabControl2.SelectedIndex = 3;
            this.tabControl1.SelectedIndex = 1;

            this.pictureBox1.AllowDrop = true;
            this.pictureBox1.DragEnter += pictureBox1_DragEnter;
            this.pictureBox1.DragDrop += pictureBox1_DragDrop;

            this.listBox4.DrawMode = DrawMode.OwnerDrawVariable;
            this.listBox4.DrawItem += listBox4_DrawItem;
            this.listBox4.MeasureItem += listBox4_MeasureItem;

        }

        void listBox4_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 80;

        }

        void listBox4_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            e.DrawBackground();
            e.DrawFocusRectangle();

            MyImage x = (MyImage) this.listBox4.Items[e.Index];
            g.DrawImage(x.ImagePicture, e.Bounds.Left, e.Bounds.Top, 100, 70);
       
            if (e.Index % 2==0)
            {
                g.DrawString(x.ImageDesc, e.Font, Brushes.Red, e.Bounds.Left+100, e.Bounds.Top);

            }
            else
            {
                g.DrawString(x.ImageDesc, e.Font, Brushes.Blue, e.Bounds.Left+100, e.Bounds.Top);

            }

            
        
        }

    

        void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {

            string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);

            this.pictureBox1.Image = Image.FromFile(filenames[0]) ;

        }

        void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {

            e.Effect = DragDropEffects.Copy;
        }

        private void CreateListViewColumns()
        {
             //Connected
            this.listView1.View = View.Details;
            try
            {
               using(  SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
               {
             
                   using (SqlCommand command = new SqlCommand("select * from customers", conn))
                   {   
                        conn.Open();
                       using (SqlDataReader datareader = command.ExecuteReader())
                       {
                           DataTable table = datareader.GetSchemaTable();

                           this.dataGridView1.DataSource = table;

                           for (int row=0; row<=table.Rows.Count-1; row++)
                           {
                               this.listView1.Columns.Add(table.Rows[row][0].ToString());
                           }

                           this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                        } //dataReader.Dispose(); dataReader.Close()

                    } //command.Dispose();

                } // auto   conn.Dispose()=>conn.Close()
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LoadCountryToComboBox()
        {
            //Connected
            try
            {
               using(  SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
               {
             
                   using (SqlCommand command = new SqlCommand("select distinct Country from customers", conn))
                   {   
                        conn.Open();
                       using (SqlDataReader datareader = command.ExecuteReader())
                       {
                           this.comboBox1.Items.Clear();
                           while (datareader.Read())
                           {
                               this.comboBox1.Items.Add(datareader["Country"]);
                           }
                           this.comboBox1.SelectedIndex = 0;
     
                        } //dataReader.Dispose(); dataReader.Close()

                    } //command.Dispose();

                } // auto   conn.Dispose()=>conn.Close()
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {  //Connected
            try
            {
               using(  SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
               {
             
                   using (SqlCommand command = new SqlCommand("select * from customers where country='" + this.comboBox1.Text  +"'", conn))
                   {   
                        conn.Open();
                       using (SqlDataReader datareader = command.ExecuteReader())
                       {

                           this.listView1.Items.Clear();
                           Random r = new Random();
                           while (datareader.Read())
                           {
                               ListViewItem x=  this.listView1.Items.Add(datareader[0].ToString());
                               x.ImageIndex = r.Next(0, this.ImageList1.Images.Count);
                        
                               if ( x.Index %2==0)
                               {
                                   x.BackColor = Color.Orange;
                               }
                               else
                               {
                                   x.BackColor = Color.White;
                               }
                             
                               for (int i=1; i<=datareader.FieldCount-1;i++)
                               {
                                   if (datareader.IsDBNull(i))
                                   {
                                       x.SubItems.Add("空值");
                                   }
                                   else
                                   {
                                        x.SubItems.Add(datareader[i].ToString());
                                   }
                            
                               }
                             
                           }
                          
                        } //dataReader.Dispose(); dataReader.Close()

                    } //command.Dispose();

                } // auto   conn.Dispose()=>conn.Close()
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.SmallIcon;
     
        }

        private void detailViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Details;
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               using(  SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
               {

                   using (SqlCommand command = new SqlCommand())
                   {
                       string UserName = this.textBox1.Text;
                       string Password = this.textBox2.Text;

                       command.CommandText = "Insert into Member (UserName, Password) Values ('" +UserName+"', '" + Password+ "')";
                       command.Connection = conn;
                       conn.Open();

                       command.ExecuteNonQuery();
                       MessageBox.Show("insert member successfully");

                    } //command.Dispose();

                } // auto conn.Dispose()=>conn.Close()
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        string UserName = this.textBox1.Text;
                        string Password = this.textBox2.Text;
                        
                        //command.CommandText = "select * from Member where UserName='" +UserName+"' and Password = '" + Password+"'";
                   
                        command.CommandText = "select * from Member where UserName='" + UserName + "' and Password = '" + Password + "'" ;
                        MessageBox.Show(command.CommandText);

                        command.Connection = conn;
                        conn.Open();

                        using(SqlDataReader dataReader =  command.ExecuteReader())
                        {
                            if (dataReader.HasRows)
                            {
                                MessageBox.Show("Logon successfully");
                            }
                            else
                            {
                                MessageBox.Show("Logon failed");
                            }
                        }
                      
                    } //command.Dispose();

                } // auto conn.Dispose()=>conn.Close()

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        string UserName = this.textBox1.Text;
                        string Password = this.textBox2.Text;

                        command.CommandText = "Insert into Member (UserName, Password) Values (@UserName, @Password)";
                        //command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = UserName;

                        SqlParameter p1 = new SqlParameter();
                        p1.ParameterName = "@UserName";
                        p1.SqlDbType = SqlDbType.NVarChar;
                        p1.Size = 16;
                        p1.Value = UserName;
                        //p1.Direction = ParameterDirection.Input;

                        command.Parameters.Add(p1);
                        command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = Password;

                        command.Connection = conn;
                        conn.Open();

                        command.ExecuteNonQuery();
                        MessageBox.Show("insert member successfully");

                    } //command.Dispose();

                } // auto conn.Dispose()=>conn.Close()

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        string UserName = this.textBox1.Text;
                        string Password = this.textBox2.Text;

                        command.CommandText = "InsertMember";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = UserName;
                        command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = Password;

                        //=========================
                        SqlParameter p1 = new SqlParameter();
                        p1.ParameterName = "@Return_Value";
                        p1.Direction = ParameterDirection.ReturnValue;
                        command.Parameters.Add(p1);
                        //==========================

                        command.Connection = conn;
                        conn.Open();


                        command.ExecuteNonQuery();
                        MessageBox.Show("Member ID = " + p1.Value + " insert member successfully");

                    } //command.Dispose();

                } // auto conn.Dispose()=>conn.Close()

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        string UserName = this.textBox1.Text;
                        string Password = this.textBox2.Text;

                        Password = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(Password, "sha1");
                        command.CommandText = "Insert into Member (UserName, Password) Values (@UserName, @Password)";
                 
                        command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = UserName;
                        command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = Password;

                        command.Connection = conn;
                        conn.Open();

                        command.ExecuteNonQuery();
                        MessageBox.Show("insert member successfully");

                    } //command.Dispose();

                } // auto conn.Dispose()=>conn.Close()

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        string UserName = textBox1.Text;
                        string Password = textBox2.Text;

                        //=====================
                        System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
                        byte[] buf = new byte[15];
                        rng.GetBytes(buf); //要將在密碼編譯方面強式的隨機位元組填入的陣列。 
                        string salt = Convert.ToBase64String(buf);

                        Password = FormsAuthentication.HashPasswordForStoringInConfigFile(Password + salt, "sha1");
                        //======================


                        command.CommandText = "Insert into Member (UserName, Password, Salt) values (@UserName, @Password, @Salt)";
                        command.Connection = conn;

                        command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = UserName;
                        command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = Password;
                        command.Parameters.Add("@Salt", SqlDbType.NVarChar).Value = salt;



                        conn.Open();

                        command.ExecuteNonQuery();

                        MessageBox.Show("Insert successfully");


                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.memberTableAdapter1.InsertMember(this.textBox1.Text, this.textBox2.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {

                MembershipCreateStatus Status;
                System.Web.Security.Membership.CreateUser(this.textBox1.Text, "@1234567", "fionwang@iii.org.tw", "color", "black", true, out Status);
                MessageBox.Show(Status.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Membership.ValidateUser(this.textBox1.Text, "@1234567").ToString());
     
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
               using(  SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
               {

                   using (SqlCommand command = new SqlCommand("select Avg(UnitPrice) from products", conn))
                   {   
                       conn.Open();

                       command.CommandText = "select count(*) from products";
                       MessageBox.Show(command.ExecuteScalar().ToString());
                    
                    } //command.Dispose();

                } // auto   conn.Dispose()=>conn.Close()
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {

                    using (SqlCommand command = new SqlCommand("select Avg(UnitPrice) from products", conn))
                    {
                        conn.Open();

                        command.CommandText = "select count(*) from products";
                        MessageBox.Show(command.ExecuteScalar().ToString());

                    } //command.Dispose();

                } // auto   conn.Dispose()=>conn.Close()

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {

            string commandText =
                        "CREATE TABLE [dbo].[MyImageTable](" +
                        "[ImageID] [int] IDENTITY(1,1) NOT NULL," +
                        "[Description] [text] NULL," +
                        "[Image] [image] NULL," +
                        "CONSTRAINT [PK_MyImageTable] PRIMARY KEY CLUSTERED " +
                        "(" +
                        "	[ImageID] ASC" +
                        ")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]" +
                        ") ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]";

            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        conn.Open();

                        command.CommandText = commandText;
                        command.Connection = conn;

                        command.ExecuteNonQuery();

                    } //command.Dispose();

                } // auto   conn.Dispose()=>conn.Close()

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               this.pictureBox1.Image =  Image.FromFile(this.openFileDialog1.FileName);
               this.textBox4.Text = this.openFileDialog1.FileName;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        //==================
                        byte[] bytes ;//= {1,3 };
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        this.pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                        bytes= ms.GetBuffer();
                        //=================
                
                        command.CommandText = "Insert into MyImageTable (Description, Image) Values (@Desc, @Image)";

                        command.Parameters.Add("@Desc", SqlDbType.Text).Value = this.textBox4.Text;
                        command.Parameters.Add("@Image", SqlDbType.VarBinary).Value = bytes;

                        command.Connection = conn;
                        conn.Open();

                        command.ExecuteNonQuery();
                        MessageBox.Show("insert successfully");

                    } //command.Dispose();

                } // auto conn.Dispose()=>conn.Close()

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ImageID =(int) this.listBox2.Items[this.listBox1.SelectedIndex];
            ShowImage(ImageID);
        }

        private void ShowImage(int ImageID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {

                    using (SqlCommand command = new SqlCommand())
                    {

                        command.CommandText = "select * from MyImageTable where ImageID=" + ImageID;
                        command.Connection = conn;

                        conn.Open();
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {

                            dataReader.Read();
                            //===================
                            byte[] bytes = (byte[])dataReader["Image"];
                            MemoryStream ms = new MemoryStream(bytes);
                            this.pictureBox2.Image = Image.FromStream(ms);
                            //=============================
                        }


                    } //command.Dispose();

                } // auto   conn.Dispose()=>conn.Close()

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                this.pictureBox2.Image = this.pictureBox2.ErrorImage;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                      
                        command.CommandText = "select * from MyImageTable";
                        command.Connection = conn;
 
                        conn.Open();
                        using (SqlDataReader dataReader= command.ExecuteReader())
                        {
                            this.listBox1.Items.Clear();
                            this.listBox2.Items.Clear();
                            this.listBox3.Items.Clear();

                            while (dataReader.Read())
                            {
                                //string s = string.Format("{0} - {1}", dataReader["ImageID"], dataReader["Description"]);
                                //this.listBox1.Items.Add(s);

                                this.listBox1.Items.Add(dataReader["Description"]);
                                this.listBox2.Items.Add(dataReader["ImageID"]); //List<int> IDList

                                MyImage x = new MyImage();
                                x.ImageID = (int) dataReader["ImageID"];
                                x.ImageDesc = dataReader["Description"].ToString();
                               
                                //===========================
                                byte[] bytes = (byte[])dataReader["Image"];
                                System.IO.MemoryStream ms = new MemoryStream(bytes);
                                x.ImagePicture = Image.FromStream(ms);
                                //===========================
                                
                           
                                this.listBox3.Items.Add(x); //call ToString()
                                this.listBox4.Items.Add(x);
                            }
                            
                        }
                       
                    } //command.Dispose();

                } // auto   conn.Dispose()=>conn.Close()

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyImage x= (MyImage)  this.listBox3.Items[this.listBox3.SelectedIndex];
            this.ShowImage( x.ImageID);
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyImage x = (MyImage)this.listBox4.Items[this.listBox4.SelectedIndex];
            this.ShowImage(x.ImageID);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {

                    using (SqlCommand command = new SqlCommand("select * from Categories;select * from products", conn))
                    {
                        conn.Open();

                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                this.listBox5.Items.Add(dataReader["CategoryName"]);
                            }
                            //======================
                            this.listBox5.Items.Add("=============================");
                            dataReader.NextResult();

                            while (dataReader.Read())
                            {
                                this.listBox5.Items.Add(dataReader["ProductName"]);
                            }
                        }
                     

                    } //command.Dispose();

                } // auto   conn.Dispose()=>conn.Close()

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {

                    using (SqlCommand command = new SqlCommand("select * from Categories", conn))
                    {
                        conn.Open();

                        SqlDataReader dataReader = command.ExecuteReader();


                        this.listBox5.Items.Clear();
                            while (dataReader.Read())
                            {
                                this.listBox5.Items.Add(dataReader["CategoryName"]);
                            }
                            //=========================================================
                        //錯誤	4	無法指派給 'command'，因為它是 '使用變數'	E:\ADO.NET\ADO.NET\ADO.NET\3. Connected 連線環境\FrmConnected.cs	824	29	ADO.NET

                        //    command = new SqlCommand();
                          
                        this.listBox5.Items.Add("=============================");
                            command.CommandText = "select * from products";
                           
                        
                            //=====================
                        
                            // problem: "已經開啟一個與這個 Command 相關的 DataReader，必須先將它關閉。"	string
                            //每一次的連接 (connection) 只能給一個 dataReader 使用

                            dataReader= command.ExecuteReader();
                            while(dataReader.Read())
                            {
                                this.listBox5.Items.Add(dataReader["ProductName"]);
                            }
                     

                    } //command.Dispose();

                } // auto   conn.Dispose()=>conn.Close()

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {

                    using (SqlCommand command = new SqlCommand("select * from Categories", conn))
                    {
                        conn.Open();

                        SqlDataReader dataReader = command.ExecuteReader();


                        while (dataReader.Read())
                        {
                            this.listBox5.Items.Add(dataReader["CategoryName"]);
                        }
                        //=========================================================
                        //錯誤	4	無法指派給 'command'，因為它是 '使用變數'	E:\ADO.NET\ADO.NET\ADO.NET\3. Connected 連線環境\FrmConnected.cs	824	29	ADO.NET

                        //    command = new SqlCommand();

                        this.listBox5.Items.Add("=============================");
                        command.CommandText = "select * from products";


                        //=====================

                        // problem: "已經開啟一個與這個 Command 相關的 DataReader，必須先將它關閉。"	string
                        //每一次的連接 (connection) 只能給一個 dataReader 使用

                        dataReader.Close();

                        dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                            this.listBox5.Items.Add(dataReader["ProductName"]);
                        }




                    } //command.Dispose();

                } // auto   conn.Dispose()=>conn.Close()

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {

                    using (SqlCommand command = new SqlCommand("select * from Categories", conn))
                    {
                        conn.Open();

                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {

                            while (dataReader.Read())
                            {
                                this.listBox5.Items.Add(dataReader["CategoryName"]);
                            }

                           

                        } //dataReader.Close(); dataReader.Dispose()

                    }
                    this.listBox5.Items.Add("=============================");
                    using (SqlCommand command = new SqlCommand("select * from Products", conn))
                    {
                      
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {

                            while (dataReader.Read())
                            {
                                this.listBox5.Items.Add(dataReader["ProductName"]);
                            }

                  
                        } //dataReader.Close(); dataReader.Dispose()

                    }
                      
                    } //command.Dispose();

                } // auto   conn.Dispose()=>conn.Close()

            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void myImageTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.myImageTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void FrmConnected_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'northwindDataSet.MyImageTable' 資料表。您可以視需要進行移動或移除。
            this.myImageTableTableAdapter.Fill(this.northwindDataSet.MyImageTable);

        }

        private void button24_Click(object sender, EventArgs e)
        {
          
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            //SqlCommand command = new SqlCommand();


            //Thread
            //command.ExecuteReaderAsync();
            //command.BeginExecuteReader();
            //command.EndExecuteReader();


            long sum = 0;

            for (long i=1; i<= int.MaxValue; i++)
            {
                sum += i;
            }

            MessageBox.Show("sum = " + sum);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToLongTimeString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {

                    using (SqlCommand command = new SqlCommand())
                    {

                         command.Connection = conn;

                         conn.Open();
                
                        command.CommandText = "Insert into Region(RegionID, RegionDescription) values (100, 'xxxx')";
                        command.ExecuteNonQuery();

                        //exception
                        command.CommandText = "Insert into Region(RegionID, RegionDescription) values (100, 'xxxx')";
                        command.ExecuteNonQuery();

                        command.CommandText = "Insert into Region(RegionID, RegionDescription) values (101, 'yyyy')";
                        command.ExecuteNonQuery();

                      
                        MessageBox.Show("succssfully");
                    } //command.Dispose();

                } // auto conn.Dispose()=>conn.Close()

            }
            catch (Exception ex)
            {
              
                MessageBox.Show(ex.Message);
            }

        }

        private void button26_Click(object sender, EventArgs e)
        {
            SqlTransaction txn = null;
            try
            {
                SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString);
                

                    using (SqlCommand command = new SqlCommand())
                    {

                        command.Connection = conn;

                        conn.Open();
                        txn=  conn.BeginTransaction();
                        command.Transaction = txn;

                        command.CommandText = "Insert into Region(RegionID, RegionDescription) values (100, 'xxxx')";
                        command.ExecuteNonQuery();

                        //exception
                        command.CommandText = "Insert into Region(RegionID, RegionDescription) values (100, 'xxxx')";
                        command.ExecuteNonQuery();

                        command.CommandText = "Insert into Region(RegionID, RegionDescription) values (101, 'yyyy')";
                        command.ExecuteNonQuery();

                        txn.Commit(); //認可資料庫交易。
                        MessageBox.Show("succssfully");
                    } //command.Dispose();

                

            }
            catch (Exception ex)
            {
                txn.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //if (dataReader != null)
                //{
                //    dataReader.Dispose();
                //}

                //if (command != null)
                //{
                //    command.Dispose();
                //}

                //if (conn != null)
                //{
                //    conn.Close();
                //    conn.Dispose();   // 釋放 System.ComponentModel.Component 所使用的所有資源。

                //}
              
            }

        }

       

        #region 分散式交易
        private void button33_Click(object sender, EventArgs e)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {

                    using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                    {

                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = conn;
                            conn.Open();

                            command.CommandText = "Delete from Region where RegionID=100 or RegionID = 101";
                            command.ExecuteNonQuery();

                            command.CommandText = "Insert into Region (RegionID, RegionDescription) Values (100, 'xxx')";
                            command.ExecuteNonQuery();


                            //Exception
                            //===================
                            command.CommandText = "Insert into Region (RegionID, RegionDescription) Values (100, 'xxx')";
                            command.ExecuteNonQuery();
                            //===================

                            command.CommandText = "Insert into Region (RegionID, RegionDescription) Values (101, 'xxx')";
                            command.ExecuteNonQuery();

                        }

                    }

                    scope.Complete();

                } //scope.Dispose() 則由交易管理員認可交易的實際作業，
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button84_Click(object sender, EventArgs e)
        {
            CommittableTransaction tx = null;
            try
            {

                using (tx = new CommittableTransaction())
                {
                    using (SqlConnection conn1 = new SqlConnection(Properties.Settings.Default.NorthwindConnectionString))
                    {

                        using (SqlCommand myCommand = new SqlCommand())
                        {

                            myCommand.Connection = conn1;

                            conn1.Open();
                            conn1.EnlistTransaction(tx);


                            //Restore database to near it's original condition so sample will work correctly.
                            myCommand.CommandText = "DELETE FROM Region WHERE (RegionID = 100) OR (RegionID = 101)";
                            myCommand.ExecuteNonQuery();

                            //Insert the first record.
                            myCommand.CommandText = "Insert into Region (RegionID, RegionDescription) VALUES (100, 'MidWestern')";
                            myCommand.ExecuteNonQuery();


                            //測試交易失敗用
                            //Insert the first record.
                            myCommand.CommandText = "Insert into Region (RegionID, RegionDescription) VALUES (100, 'MidWestern')";
                            myCommand.ExecuteNonQuery();


                            //Insert the second record.
                            myCommand.CommandText = "Insert into Region (RegionID, RegionDescription) VALUES (101, 'MidEastern')";
                            myCommand.ExecuteNonQuery();


                            tx.Commit();

                            MessageBox.Show("trans. Successfully");
                        }
                    }
                }

            }


            catch (TransactionException ex)
            {
                MessageBox.Show(ex.Message);
                tx.Rollback();
            }
            catch (Exception ex)
            {

                MessageBox.Show("trans. roll back " + ex.Message);
            }
        }

        private void button82_Click(object sender, EventArgs e)
        {
            //以前 分散式交易用 COM+
            //現在用  TransactionScope
            try
            {

                using (TransactionScope scope = new TransactionScope())
                {

                    //'測試不同DB　DTC 用
                    //'觀察　Transaction.Current.TransactionInformation.DistributedIdentifier　變化

                    using (global::System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection(Settings.Default.NorthwindConnectionString))
                    {
                        conn1.Open();


                        ShowCurrentTransaction();

                        SqlCommand command1 = new SqlCommand();
                        command1.Connection = conn1;
                        command1.CommandText = "DELETE FROM Products WHERE (ProductID=78)";

                        command1.ExecuteNonQuery();

                        conn1.Close();


                    }



                    //'測試不同DB　DTC 用
                    //'觀察　Transaction.Current.TransactionInformation.DistributedIdentifier　變化

                    using (SqlConnection conn1 = new SqlConnection(Settings.Default.DBFile))
                    {
                        using (SqlCommand myCommand = new SqlCommand())
                        {
                            myCommand.Connection = conn1;

                            conn1.Open();

                            ShowCurrentTransaction();

                            //Restore database to near it's original condition so sample will work correctly.
                            myCommand.CommandText = "DELETE FROM Region WHERE (RegionID = 100) OR (RegionID = 101)";
                            myCommand.ExecuteNonQuery();

                            //Insert the first record.
                            myCommand.CommandText = "Insert into Region (RegionID, RegionDescription) VALUES (100, 'MidWestern')";
                            myCommand.ExecuteNonQuery();


                            myCommand.CommandText = "Insert into Region (RegionID, RegionDescription) VALUES (100, 'MidWestern')";
                            myCommand.ExecuteNonQuery();

                            //Insert the second record.
                            myCommand.CommandText = "Insert into Region (RegionID, RegionDescription) VALUES (101, 'MidEastern')";
                            myCommand.ExecuteNonQuery();

                        }
                    }
                    MessageBox.Show("trans. Successfully");

                    scope.Complete();

                }   // call TransactionScope.Dispose()  //如果 TransactionScope 物件一開始就建立了交易，則由交易管理員認可交易的實際作業，

            }

            catch (TransactionException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show("trans. roll back " + ex.Message);
            }
        }
        private void ShowCurrentTransaction()
        {

            //Transaction.Current
            string s = "transaction.Current.IsolationLevel: " + Transaction.Current.IsolationLevel.ToString() + Environment.NewLine +
                    "TransactionInformation.CreationTime: " + Transaction.Current.TransactionInformation.CreationTime + Environment.NewLine +
                    "TransactionInformation.Status: " + Transaction.Current.TransactionInformation.Status.ToString() + Environment.NewLine +
                    "TransactionInformation.DistributedIdentifier: " + Transaction.Current.TransactionInformation.DistributedIdentifier.ToString() + Environment.NewLine +
                    "TransactionInformation.LocalIdentifier: " + Transaction.Current.TransactionInformation.LocalIdentifier.ToString();
            MessageBox.Show(s);


        }
        #endregion

    
    }

}

public class MyImage: Object
{
    //field
    public int ImageID;
    public string ImageDesc;
    public Image ImagePicture;

   //.....
    //Property

    public override string ToString()
    {
        return string.Format("{0} - {1}", this.ImageID, this.ImageDesc);
    }


}

