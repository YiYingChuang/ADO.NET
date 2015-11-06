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
using ADO.NET.Properties;
using System.Configuration;
using System.Threading;

namespace ADO.NET._2._SqlConnection_連接水管
{
    public partial class FrmSqlConnection : Form
    {
        public FrmSqlConnection()
        {
            InitializeComponent();
            this.label1.Text = this.performanceCounter1.NextValue().ToString();


        }


        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.; Initial Catalog=Northwind; Integrated Security=true";

            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = connectionString;
                conn.Open();
                MessageBox.Show("successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.; Initial Catalog=Northwind; User ID=sa; Password=sa";

            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = connectionString;
                conn.Open();
                MessageBox.Show("successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\sqlExpress; Initial Catalog=Northwind; Integrated Security=true";

            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = connectionString;
                conn.Open();
                MessageBox.Show("successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
  
            //...... 
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\test\DB\NORTHWND.MDF;Integrated Security=True;Connect Timeout=30";
            try
            {
               using(  SqlConnection conn = new SqlConnection())
               {

                   using (SqlCommand command = new SqlCommand("select * from products", conn))
                   {   
                       conn.ConnectionString = connectionString;
                       conn.Open();
                       using (SqlDataReader datareader = command.ExecuteReader())
                       {
                           this.listBox1.Items.Clear();
                           while (datareader.Read())
                           {
                               this.listBox1.Items.Add(datareader["ProductName"]);
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

        private void button5_Click(object sender, EventArgs e)
        {
            //...... 
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\DB\NORTHWND.MDF;Integrated Security=True;Connect Timeout=30";
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {

                    using (SqlCommand command = new SqlCommand("select * from products", conn))
                    {
                        conn.ConnectionString = connectionString;
                        conn.Open();
                        using (SqlDataReader datareader = command.ExecuteReader())
                        {
                            this.listBox1.Items.Clear();
                            while (datareader.Read())
                            {
                                this.listBox1.Items.Add(datareader["ProductName"]);
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

        private void button6_Click(object sender, EventArgs e)
        {
            //...... 
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=xxx..;Integrated Security=True;Connect Timeout=30";
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    //===============================
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
                    builder.AttachDBFilename = Application.StartupPath + @"\DB\Northwnd.mdf";
                    //===============================

                    using (SqlCommand command = new SqlCommand("select * from products", conn))
                    {
                        conn.ConnectionString = builder.ConnectionString;
                        conn.Open();
                        using (SqlDataReader datareader = command.ExecuteReader())
                        {
                            this.listBox1.Items.Clear();
                            while (datareader.Read())
                            {
                                this.listBox1.Items.Add(datareader["ProductName"]);
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

        private void button9_Click(object sender, EventArgs e)
        {
            //connected
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {

                    using (SqlCommand command = new SqlCommand("select * from products", conn))
                    {
                        conn.ConnectionString = Settings.Default.xxxConnectionString;
                        conn.Open();
                        using (SqlDataReader datareader = command.ExecuteReader())
                        {
                            this.listBox1.Items.Clear();
                            while (datareader.Read())
                            {
                                this.listBox1.Items.Add(datareader["ProductName"]);
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

        private void button58_Click(object sender, EventArgs e)
        {
            try
            {
                //加密
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ConfigurationSection section = config.Sections["connectionStrings"];
                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                config.Save();
                MessageBox.Show("加密成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
        }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            try
            {
                //解密
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ConfigurationSection section = config.Sections["connectionStrings"];
                section.SectionInformation.UnprotectSection();
                config.Save();

                MessageBox.Show("解密成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            //connected
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.StateChange += conn_StateChange;
                    using (SqlCommand command = new SqlCommand("select * from products", conn))
                    {
                        conn.Open();
                        using (SqlDataReader datareader = command.ExecuteReader())
                        {
                            this.listBox2.Items.Clear();
                            while (datareader.Read())
                            {
                                this.listBox2.Items.Add(datareader["ProductName"]);
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

        void conn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.toolStripStatusLabel1.Text = e.CurrentState.ToString();
 Application.DoEvents(); 
         Thread.Sleep(1000);

            
 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Connection.StateChange += conn_StateChange;
            this.productsTableAdapter1.Fill(this.northwindDataSet1.Products);
            this.dataGridView1.DataSource = this.northwindDataSet1.Products;

        }

       

        private void button13_Click(object sender, EventArgs e)
        {
            SqlConnection[] conns = new SqlConnection[100];

            for (int i = 0; i <= conns.Length - 1; i++)
            {
                conns[i] = new SqlConnection();
                conns[i].ConnectionString = Settings.Default.NorthwindConnectionString;
                conns[i].Open();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            const int MAX = 200;

         

            SqlConnection[] conns = new SqlConnection[MAX];

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(Settings.Default.AdventureWorksConnectionString);
            builder.MaxPoolSize = MAX;
            builder.ConnectTimeout = 1;


            for (int i = 0; i <= conns.Length - 1; i++)
            {
                conns[i] = new SqlConnection();
                conns[i].ConnectionString = builder.ConnectionString;
                conns[i].Open();

                this.label1.Text= this.performanceCounter1.NextValue().ToString();

                Application.DoEvents();
               // Thread.Sleep(100);

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            const int MAX = 100;

            SqlConnection[] conns = new SqlConnection[MAX];
            SqlDataReader[] dataReaders = new SqlDataReader[MAX];

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(Settings.Default.AdventureWorksConnectionString);
            builder.MaxPoolSize = MAX;
            builder.ConnectTimeout = 1;
            builder.Pooling = true;

            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            for (int i = 0; i <= conns.Length - 1; i++)
            {
                conns[i] = new SqlConnection();
                conns[i].ConnectionString = builder.ConnectionString;
                conns[i].Open();


                SqlCommand command = new SqlCommand("select * from Production.Product", conns[i]);
                dataReaders[i] =  command.ExecuteReader();

                this.listBox3.Items.Clear();
                while (dataReaders[i].Read())
                {
                    this.listBox3.Items.Add(dataReaders[i]["Name"]);
                }

                conns[i].Close(); //可用的連接 conn =>Return to Pool
            }
            watch.Stop();
            this.label2.Text= watch.Elapsed.TotalSeconds.ToString();
        }

      
        private void button23_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=Northwindxxx;Integrated Security=True";
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connString);

            SqlCommand command = new SqlCommand("Select * from Products", conn);
            SqlDataReader dr = null;

            try
            {
                conn.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    this.comboBox2.Items.Add(dr["ProductName"]);
                }

                this.comboBox2.SelectedIndex = 0;
            }
            catch (SqlException ex)
            {
                //ex.Number
                string s = "";
                for (int i = 0; i <= ex.Errors.Count - 1; i++)
                {
                    s += string.Format("{0} : {1}", ex.Errors[i].Number, ex.Errors[i].Message) + Environment.NewLine;
                }
                MessageBox.Show("error count:" + ex.Errors.Count + Environment.NewLine + s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {


                if (dr != null) dr.Close();
                if (command != null) command.Dispose();

                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=Northwindxx;Integrated Security=True";
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connString);

            SqlCommand command = new SqlCommand("Select * from Products", conn);
            SqlDataReader dr = null;

            try
            {
                conn.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    this.comboBox2.Items.Add(dr["ProductName"]);
                }

                this.comboBox2.SelectedIndex = 0;
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 17:
                        MessageBox.Show("Wrong Server");
                        break;
                    case 4060:
                        MessageBox.Show("Wrong DataBase");
                        break;
                    case 18456:
                        MessageBox.Show("Wrong User");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {


                if (dr != null) dr.Close();
                if (command != null) command.Dispose();

                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            const int MAX = 100;

            SqlConnection[] conns = new SqlConnection[MAX];
            SqlDataReader[] dataReaders = new SqlDataReader[MAX];

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(Settings.Default.AdventureWorksConnectionString);
            builder.MaxPoolSize = MAX;
            builder.ConnectTimeout = 1;
            builder.Pooling = false;

            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            for (int i = 0; i <= conns.Length - 1; i++)
            {
                conns[i] = new SqlConnection();
                conns[i].ConnectionString = builder.ConnectionString;
                conns[i].Open();


                SqlCommand command = new SqlCommand("select * from Production.Product", conns[i]);
                dataReaders[i] = command.ExecuteReader();

                this.listBox3.Items.Clear();
                while (dataReaders[i].Read())
                {
                    this.listBox3.Items.Add(dataReaders[i]["Name"]);
                }

                conns[i].Close(); //NOT  Return to Pool
            }
            watch.Stop();
            this.label3.Text = watch.Elapsed.TotalSeconds.ToString();
        }
    }
}
