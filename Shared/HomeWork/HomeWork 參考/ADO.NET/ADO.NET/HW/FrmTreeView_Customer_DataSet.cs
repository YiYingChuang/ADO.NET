using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET.HW
{
    public partial class FrmTreeView_Customer_DataSet : Form
    {
        public FrmTreeView_Customer_DataSet()
        {
            InitializeComponent();
        }

        private void FrmTreeView_Customer_DataSet_Load(object sender, EventArgs e)
        {
            FrmLogOn f = new FrmLogOn();
            if (f.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                return;
            }
            // TODO:  這行程式碼會將資料載入 'northwindDataSet.Customers' 資料表。您可以視需要進行移動或移除。
          
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

        }
        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }


        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i <= this.northwindDataSet.Customers.Rows.Count - 1; i++)
            {
                string countryKey = northwindDataSet.Customers[i].Country;
                string cityKey = northwindDataSet.Customers[i].City;

                 //if ( ! this.treeView1.Nodes.ContainsKey(countryKey))
                TreeNode parentNode=this.treeView1.Nodes[countryKey];
                if (parentNode == null)
                {
                    parentNode = this.treeView1.Nodes.Add(countryKey, countryKey);
                    parentNode.Tag = 0;
                }
                
                // if (! this.treeView1.Nodes[countryKey].Nodes.ContainsKey(city))
                TreeNode childNode = this.treeView1.Nodes[countryKey].Nodes[cityKey];          
                 if (childNode== null)
                {
                    childNode =parentNode.Nodes.Add(cityKey, cityKey);
                    childNode.Tag = 0;
                   
                }
               
                parentNode.Tag = (int)parentNode.Tag + 1;
                parentNode.Text = string.Format("{0} ({1} customers)", countryKey, parentNode.Tag);

            }
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.listView1.Visible = false;

            for (int i = 0; i <= this.northwindDataSet.Customers.Rows.Count - 1; i++)
            {
                string countryKey = northwindDataSet.Customers[i].Country;
                string city = northwindDataSet.Customers[i].City;

                ListViewItem x = new ListViewItem(northwindDataSet.Customers[i].CustomerID);
                this.listView1.Items.Add(x);

                //=============================
                if (this.listView1.Groups[countryKey] == null)
                {
                    ListViewGroup group = this.listView1.Groups.Add(countryKey, northwindDataSet.Customers[i].Country);
                    group.Tag = 0;
                    group.Items.Add(x);
                }
                else
                {
                    this.listView1.Groups[countryKey].Items.Add(x);
                }

                this.listView1.Groups[countryKey].Tag = (int)this.listView1.Groups[countryKey].Tag + 1;
                this.listView1.Groups[countryKey].Header = string.Format("{0} ({1})", countryKey, this.listView1.Groups[countryKey].Tag);

            }
            this.listView1.Visible = true;
            this.Cursor = Cursors.Default;

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {          
            
            if (e.Node.Level == 0) return;
  
            string search = e.Node.Text;
            this.customersBindingSource.Filter = "City='" + search + "'";
            this.label1.Text = string.Format("Customers({0}) Count : {1}", search, this.customersBindingSource.Count);

        }
    }
}
