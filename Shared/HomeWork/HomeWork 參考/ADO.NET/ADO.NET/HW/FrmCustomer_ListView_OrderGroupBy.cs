using ADO.NET.HW;
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


namespace ADO.NET.Lab_03_Connected_連線環境
{
    public partial class FrmCustomers_ListView : Form
    {
        public FrmCustomers_ListView()
        {
            this.Load += FrmCustomers_ListView_Load;
       
            InitializeComponent();

        }

        void FrmCustomers_ListView_Load(object sender, EventArgs e)
        {
            //FrmLogOn f = new FrmLogOn();
            //if (f.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            //{
            //    this.Close();
            //    return;
            //}
 
            LoadCountryToComboBox();
            CreateListViewColumns();
        }


        private void CreateListViewColumns()
        {
            this.listView1.View = View.Details;
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("Select * from  customers", conn))
                    {
                        conn.Open();
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {

                            DataTable table = dataReader.GetSchemaTable();
                            this.dataGridView1.DataSource = table;

                            for (int row = 0; row <= table.Rows.Count - 1; row++)
                            {
                                this.listView1.Columns.Add(table.Rows[row][0].ToString());
                            }

                            this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                        }//Auto dataReader.Dispose()
                    } // Auto command.Dispose();
                } // Auto  conn.Dispose() =>conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void LoadCountryToComboBox()
        { 

            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("Select distinct Country from  customers", conn))
                    {
                        conn.Open();
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            this.comboBox1.Items.Clear();

                            //TODO : All Countries
                            this.comboBox1.Items.Add("All Countries");
                
                            while (dataReader.Read())
                            {
                                this.comboBox1.Items.Add( dataReader["Country"] );
                            }
                            this.comboBox1.SelectedIndex = 0;

                        }//Auto dataReader.Dispose()
                    } // Auto command.Dispose();
                } // Auto  conn.Dispose() =>conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }


        #region orderGroup

        string commandFormat = "select * from customers  {0}  {1}";

        string commandWhere = "";
        string commandOrder = "";
      
        bool isGroup = false;

        private void customerIDAscToolStripMenuItem_Click(object sender, EventArgs e)
        {  
         
            commandOrder = " Order by CustomerID asc";
            this.LoadCustomerToListView();

        }
        private void customerIDDescToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandOrder = " Order by CustomerID desc";
            this.LoadCustomerToListView();

        }
        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            isGroup = true;
            this.LoadCustomerToListView();
        }


        private void 無ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isGroup = false;
            this.LoadCustomerToListView();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 0)
            {
                commandWhere = "";
            }
            else
            {
                commandWhere = " where country='" + this.comboBox1.Text + "'";
            }

            LoadCustomerToListView();


        }


        private void LoadCustomerToListView()
        {

            this.listView1.Visible = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    using (SqlCommand command = new SqlCommand())
                    {

                        string commandText = string.Format(commandFormat, commandWhere, commandOrder);
                        command.CommandText = commandText;
                        command.Connection = conn;

                        conn.Open();
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {

                            this.listView1.Items.Clear();
                            this.listView1.Groups.Clear();
                            bool flag = true;
                            Random r = new Random();
                            
                           while (dataReader.Read())
                            {
                                ListViewItem listViewItem = this.listView1.Items.Add(dataReader[0].ToString());

                            
                                if (isGroup)
                                {
                                    string GroupKey = dataReader["Country"].ToString();
                               
                                   
                                    string countryKey =dataReader["Country"].ToString();
                                    string city = dataReader["City"].ToString();

                
                                    if (this.listView1.Groups[countryKey] == null)
                                    {
                                        ListViewGroup group = this.listView1.Groups.Add(countryKey, countryKey);
                                        group.Tag = 0;
                                        group.Items.Add(listViewItem);
                                    }
                                    else
                                    {
                                        this.listView1.Groups[countryKey].Items.Add(listViewItem);
                                    }

                                    this.listView1.Groups[countryKey].Tag = (int)this.listView1.Groups[countryKey].Tag + 1;
                                    this.listView1.Groups[countryKey].Header = string.Format("{0} ({1})", countryKey, this.listView1.Groups[countryKey].Tag);
                                    //====================================
                                }
                                //=======================

                                listViewItem.ImageIndex = r.Next(0, this.ImageList1.Images.Count);
                                if (!isGroup)
                                {
                                    if (flag)
                                    {
                                        listViewItem.BackColor = Color.Orange;
                                    }
                                    else
                                    {
                                        listViewItem.BackColor = Color.White;
                                    }
                                    flag = !flag;
                                }

                                for (int i = 1; i <= dataReader.FieldCount - 1; i++)
                                {
                                    if (dataReader.IsDBNull(i))
                                    {
                                        listViewItem.SubItems.Add("空值");
                                    }
                                    else
                                    {
                                        listViewItem.SubItems.Add(dataReader[i].ToString());
                                    }
                                }
                            }
                            this.listView1.Visible = true;
        
                        } 
                    }
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        #endregion
       

  
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

   
    }
}
