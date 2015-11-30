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

namespace ADO0NET.Homework
{
    public partial class FrmTreeview : Form
    {
        public FrmTreeview()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void FrmTreeview_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'northwindDataSet.Customers' 資料表。您可以視需要進行移動或移除。
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

            FrmUser f = new FrmUser();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
            

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.listView1.Visible = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.northwindConnectionString))
                {
                    using (SqlCommand comm = new SqlCommand("select * from Customers", conn))
                    {
                        conn.Open();
                        using (SqlDataReader DataReader = comm.ExecuteReader())
                        {
                            DataTable datatable = DataReader.GetSchemaTable();
                            for (int row = 0; row < datatable.Rows.Count; row++)
                            {
                                this.listView1.Columns.Add(datatable.Rows[row][0].ToString());
                            }
                            this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                            while (DataReader.Read())
                            {
                                ListViewItem viewitem = this.listView1.Items.Add(DataReader[0].ToString());
                                for (int i = 1; i < DataReader.FieldCount; i++)
                                {
                                    if (DataReader.IsDBNull(i)) 
                                    {
                                        viewitem.SubItems.Add("空值");
                                    }
                                    else
                                    {
                                        viewitem.SubItems.Add(DataReader[i].ToString());
                                    }
                                }
                                string s =viewitem.SubItems[8].Text;
                                if (this.listView1.Groups[s] == null)
                                    {
                                        this.listView1.Groups.Add(s, s);
                                        viewitem.Group = this.listView1.Groups[s];
                                        this.listView1.Groups[s].Header = string.Format("{0}{1}", s, this.listView1.Groups[s].Items.Count);
                                    }
                                    else
                                    {
                                        foreach (ListViewGroup item in this.listView1.Groups)
                                        {
                                            if (s == item.Name)
                                            {
                                                viewitem.Group = this.listView1.Groups[item.Name];
                                                this.listView1.Groups[item.Name].Header = string.Format("{0} ({1})", item.Name, this.listView1.Groups[item.Name].Items.Count);
                                            }
                                        }
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
            this.listView1.Visible = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (DataRow item in this.northwindDataSet.Customers.Rows)
            {
                string country = "";
                string city = "";

                country = Convert.ToString(item["Country"]);
                city = Convert.ToString(item["City"]);

                TreeNode fathernode = this.treeView1.Nodes[country];

                if (fathernode == null)
                {
                    fathernode = this.treeView1.Nodes.Add(country, country);
                }
                TreeNode child_t = fathernode.Nodes[city];

                if (child_t == null)
                {
                    child_t = fathernode.Nodes.Add(city, city);
                }
                
                child_t.Nodes.Add(Convert.ToString(item["CustomerID"]));
                fathernode.Text = string.Format("{0} ({1})", country, fathernode.Nodes.Count);
                child_t.Text = string.Format("{0} ({1})", city, child_t.Nodes.Count);
            }
        }
    }
}
