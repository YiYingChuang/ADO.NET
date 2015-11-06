using ADO0NET.Properties;
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

namespace ADO0NET._3._connected
{
    public partial class FrmGroupby : Form
    {
        public FrmGroupby()
        {
            InitializeComponent();
            AddCountryToCombobox();
            AddTableToDataGriview();
            AddcolumnsToListview();
            
        }
        bool b = false;
        List<string> country = new List<string>();
        private void AddcolumnsToListview()
        {
            this.listView1.View = View.Details;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Settings.Default.northwindConnectionString;
                    using (SqlCommand comm = new SqlCommand("select * from Customers", conn))
                    {
                        conn.Open();
                        using (SqlDataReader DataReader = comm.ExecuteReader())
                        {
                            DataTable datatable = DataReader.GetSchemaTable();
                            for(int row = 0; row <datatable.Rows.Count; row++)
                            {
                                this.listView1.Columns.Add(datatable.Rows[row][0].ToString());
                            }
                            this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                        }//auto DataReader.dispose();
                    }//auto comm.dispose();
                }//auto conn.close();auto conn.dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void AddTableToDataGriview()
        {
             try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Settings.Default.northwindConnectionString;
                    using (SqlCommand comm = new SqlCommand("select * from Customers", conn))
                    {
                        conn.Open();
                        using (SqlDataReader DataReader = comm.ExecuteReader())
                        {
                            DataTable datatable = DataReader.GetSchemaTable();
                            this.dataGridView1.DataSource = datatable;
                        }//auto DataReader.dispose();
                    }//auto comm.dispose();
                }//auto conn.close();auto conn.dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
       
        private void AddCountryToCombobox()
        {
             try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Settings.Default.northwindConnectionString;
                    using (SqlCommand comm = new SqlCommand("select Distinct Country from Customers", conn))
                    {
                        conn.Open();
                        using (SqlDataReader DataReader = comm.ExecuteReader())
                        {
                            this.comboBox1.Items.Clear();
                            this.country.Add("AllCountry");
                            while (DataReader.Read())
                            {
                                this.country.Add(DataReader["Country"].ToString());
                            }
                            foreach (var item in this.country)
                            {
                             this.comboBox1.Items.Add(item);   
                            }
                            //設定combobox的起始位置在...(開始)
                            this.comboBox1.SelectedIndex = 0;
                            //設定combobox的起始位置在...(結束)

                        }//auto DataReader.dispose();
                    }//auto comm.dispose();
                }//auto conn.close();auto conn.dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.CreatGroups();

                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Settings.Default.northwindConnectionString;
                    using (SqlCommand comm = new SqlCommand(this.combobox_selectedtext() , conn))
                    {
                        conn.Open();
                        using (SqlDataReader DataReader = comm.ExecuteReader())
                        {
                            this.listView1.Items.Clear();
                            Random r =new Random();
                            while (DataReader.Read())
                            {
                                //加入 Item 到 Items 集合, 每Read一次讀一行

                                //DataReader[0], 取得指定行的值(開始)
                                ListViewItem viewitem = this.listView1.Items.Add(DataReader[0].ToString());
                                //取得指定行的值(結束)

                                #region//設定指定行的屬性(開始)
                                viewitem.ImageIndex = r.Next(0, this.ImageList1.Images.Count);
                                if (viewitem.Index % 2 == 0)
                                {
                                    viewitem.BackColor = Color.Salmon;
                                }
                                else
                                {
                                    viewitem.BackColor = Color.SeaShell;
                                }
                                //設定指定行的屬性(結束)
                                #endregion

                                #region//設定該 Item 的 Subitem, 並加入到 Subitems 集合(開始)
                                for (int i = 1; i < DataReader.FieldCount; i++)
                                {
                                    if (DataReader.IsDBNull(i))//     取得值，指出資料行是否含有不存在或遺漏的值。
                                    {
                                        viewitem.SubItems.Add("空值");
                                    }
                                    else
                                    {
                                     viewitem.SubItems.Add(DataReader[i].ToString());
                                    }
                                }
                                //設定該 Item 的 Subitem, 並加入到 Subitems 集合(結束)
                                #endregion

                                #region//如果Groupby啟動,執行Groupby(開始)
                                if (b)
                                {
                                    this.groupby(viewitem);
                                }
                                else
                                {
                                    this.listView1.Groups.Clear();
                                }
                                #endregion//Group by(結束)
                            }
                            #region//如果Groupby啟動, Group by加上統計數字(開始)
                            foreach (ListViewGroup item in this.listView1.Groups)
                            {
                                string s = string.Format(" ({0})", item.Items.Count);
                                item.Header += s;
                            }
                            #endregion//Group by加上統計數字(結束)

                        }//auto DataReader.dispose();
                    }//auto comm.dispose();
                }//auto conn.close();auto conn.dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        string combobox_selectedtext()
        { 
            string s = "";
            if (this.comboBox1.SelectedIndex != 0)
            {

                s = string.Format("{0}{1}{2}", "select * from Customers where Country ='", this.comboBox1.Text, "' order by CustomerID");
                return s;
            }
            else
            {
                s = "select * from Customers order by CustomerID";
               return s;
            }
        }
        string orderbyDESC()
        {
            string s = "";
            if (this.comboBox1.SelectedIndex != 0)
            {

                s = string.Format("{0}{1}{2}", "select * from Customers where Country ='", this.comboBox1.Text, "' order by CustomerID desc");
                return s;
            }
            else
            {
                s = "select * from Customers order by CustomerID desc";
                return s;
            }
        }
        void CreatGroups()//產生Groupby集合
        {
            this.listView1.Groups.Clear();
            if (b == true)
            {
                for (int i = 1; i < this.country.Count; i++)
                {
                    this.listView1.Groups.Add(this.country[i], this.country[i]);
                }
            }
        }
        void groupby(ListViewItem viewitem)
        {
            foreach (var item in this.listView1.Groups)
            {
                string s = "";
                s = viewitem.SubItems[8].Text;
                if (s == item.ToString())
                {
                    viewitem.Group = this.listView1.Groups[item.ToString()];
                }
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

        private void customerIDDESCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Settings.Default.northwindConnectionString;
                    using (SqlCommand comm = new SqlCommand(this.orderbyDESC(), conn))
                    {
                        conn.Open();
                        using (SqlDataReader DataReader = comm.ExecuteReader())
                        {
                            this.listView1.Items.Clear();
                            Random r = new Random();
                            while (DataReader.Read())
                            {
                                ListViewItem viewitem = this.listView1.Items.Add(DataReader[0].ToString());
                                viewitem.ImageIndex = r.Next(0, this.ImageList1.Images.Count);
                                if (viewitem.Index % 2 == 0)
                                {
                                    viewitem.BackColor = Color.Salmon;
                                }
                                else
                                {
                                    viewitem.BackColor = Color.SeaShell;
                                }

                                for (int i = 1; i < DataReader.FieldCount; i++)
                                {
                                    if (DataReader.IsDBNull(i))//     取得值，指出資料行是否含有不存在或遺漏的值。
                                    {
                                        viewitem.SubItems.Add("空值");
                                    }
                                    else
                                    {
                                        viewitem.SubItems.Add(DataReader[i].ToString());
                                    }

                                }
                                if (b)
                                {
                                    this.groupby(viewitem);
                                }
                                else
                                {
                                    this.listView1.Groups.Clear();
                                }
                            }
                        }//auto DataReader.dispose();
                    }//auto comm.dispose();
                }//auto conn.close();auto conn.dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Groupby旗標變數
            b = true;

            try
            {
                //產生Groups集合
                this.CreatGroups();

                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Settings.Default.northwindConnectionString;
                    using (SqlCommand comm = new SqlCommand(this.combobox_selectedtext(), conn))
                    {
                        conn.Open();
                        using (SqlDataReader DataReader = comm.ExecuteReader())
                        {
                            this.listView1.Items.Clear();
                            Random r = new Random();
                            while (DataReader.Read())
                            {
                                ListViewItem viewitem = this.listView1.Items.Add(DataReader[0].ToString());
                                viewitem.ImageIndex = r.Next(0, this.ImageList1.Images.Count);
                                #region //將null的空格填上"空值"
                                for (int i = 1; i < DataReader.FieldCount; i++)
                                {
                                    if (DataReader.IsDBNull(i))//     取得值，指出資料行是否含有不存在或遺漏的值。
                                    {
                                        viewitem.SubItems.Add("空值");
                                    }
                                    else
                                    {
                                        viewitem.SubItems.Add(DataReader[i].ToString());
                                    }
                                }
                                #endregion

                                #region//Groupby啟動,執行Groupby(開始)
                                if (b)
                                {
                                    this.groupby(viewitem);
                                }
                                else
                                {
                                    
                                }
                                #endregion//執行Groupby(結束)
                            }
                            #region//Group by加上統計數字(開始)
                            foreach (ListViewGroup item in this.listView1.Groups)
                            {
                                string s = string.Format(" ({0})", item.Items.Count);
                                item.Header += s;
                            }
                            //Group by加上統計數字(結束)
                            #endregion
                        }//auto DataReader.dispose();
                    }//auto comm.dispose();
                }//auto conn.close();auto conn.dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       
    
    }
}
