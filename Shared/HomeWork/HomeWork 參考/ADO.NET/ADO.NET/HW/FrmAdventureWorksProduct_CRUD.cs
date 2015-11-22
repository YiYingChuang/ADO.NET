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

namespace ADO.NET.HW
{
    public partial class FrmAdventureWorksProduct_CRUD : Form
    {
        public FrmAdventureWorksProduct_CRUD()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'adventureWorksDataSet.ProductProductPhoto' 資料表。您可以視需要進行移動或移除。
            this.productProductPhotoTableAdapter.Fill(this.adventureWorksDataSet.ProductProductPhoto);
            // TODO:  這行程式碼會將資料載入 'adventureWorksDataSet.Product' 資料表。您可以視需要進行移動或移除。
            this.productTableAdapter.Fill(this.adventureWorksDataSet.Product);
            // TODO:  這行程式碼會將資料載入 'adventureWorksDataSet.ProductPhotoInfo' 資料表。您可以視需要進行移動或移除。
            this.productPhotoInfoTableAdapter.Fill(this.adventureWorksDataSet.ProductPhotoInfo);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var q = from p in this.adventureWorksDataSet.ProductPhotoInfo
                    group p by p.ProductID into g
                    select new { key = string.Format("產品 {0} ({1})", g.Key, g.Count()), count=g.Count(), g };
         
            this.treeView1.Nodes.Clear();
      
            foreach (var group in q)
            {
                TreeNode node = this.treeView1.Nodes.Add(group.key.ToString());
                foreach (var item in group.g)
                {
                    node.Nodes.Add(string.Format("{0} - {1}", item.ProductID , item.ModifiedDate));
                }
            }

            this.dataGridView1.DataSource = q.ToList();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var q = from p in this.adventureWorksDataSet.ProductPhotoInfo
                    group p by p.ModifiedDate.Year into g
                    select new { key = string.Format("{0} 年 ({1})", g.Key, g.Count()), count=g.Count(),  g };
            this.treeView1.Nodes.Clear();
            foreach (var group in q)
            {
                TreeNode node = this.treeView1.Nodes.Add(group.key.ToString());
                foreach (var item in group.g)
                {
                    node.Nodes.Add(string.Format("{0} - {1}", item.ProductID, item.ModifiedDate));
                }
            }

             this.dataGridView1.DataSource = q.ToList();


        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void productPhotoInfoBindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            this.label3.Text = "count = " + this.productPhotoInfoBindingSource1.Count;
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.productPhotoInfoTableAdapter.FillByDate(this.adventureWorksDataSet.ProductPhotoInfo, this.dateTimePicker1.Value, this.dateTimePicker2.Value);

        }

        bool Flag = true;
        private void button2_Click(object sender, EventArgs e)
        {
            if (Flag)
               this.productPhotoInfoTableAdapter.FillByAscendingDate(this.adventureWorksDataSet.ProductPhotoInfo);
            else
                this.productPhotoInfoTableAdapter.FillByDescendingDate(this.adventureWorksDataSet.ProductPhotoInfo);

            Flag = !Flag;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.adventureWorksDataSet.EnforceConstraints = false;

            this.productPhotoInfoTableAdapter.FillGoupByYear(this.adventureWorksDataSet.ProductPhotoInfo);
            this.dataGridView1.DataSource = this.adventureWorksDataSet.ProductPhotoInfo;
        
          
            this.comboBox1.DataSource = this.adventureWorksDataSet.ProductPhotoInfo;
            this.comboBox1.DisplayMember = "Year";

      
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "All Years")
            {
                this.productPhotoInfoTableAdapter.Fill(this.adventureWorksDataSet.ProductPhotoInfo);
            }
            else
            {
                DateTime startDate = DateTime.Parse(string.Format("{0}/1/1", comboBox1.Text));

                DateTime endDate = DateTime.Parse(string.Format("{0}/12/31", comboBox1.Text));

                this.productPhotoInfoTableAdapter.FillByDate(this.adventureWorksDataSet.ProductPhotoInfo, startDate, endDate);

            }
      

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.dataTable1TableAdapter1.Fill(this.adventureWorksDataSet.DataTable1);
            this.dataGridView1.DataSource = this.adventureWorksDataSet.DataTable1;
        
            //this.comboBox1.DataSource = this.adventureWorksDataSet.DataTable1;
            //this.comboBox1.DisplayMember = "Year";

            this.comboBox1.Items.Clear();
            this.comboBox1.Items.Add("All Years");
            for(int i=0; i<= this.adventureWorksDataSet.DataTable1.Rows.Count-1; i++)
            {
                this.comboBox1.Items.Add(this.adventureWorksDataSet.DataTable1[i].Year);
            }
            this.comboBox1.SelectedIndex = 0;
            this.label4.Text = string.Format("Groupy by Year ({0})", this.adventureWorksDataSet.DataTable1.Rows.Count);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var q = from p in this.adventureWorksDataSet.ProductPhotoInfo
                    group p by new { p.ModifiedDate.Year, p.ModifiedDate.Month } into g
                    select new { key = string.Format("{0}  ({1})", g.Key, g.Count()), count = g.Count(), g };
            this.treeView1.Nodes.Clear();
            foreach (var group in q)
            {
                TreeNode node = this.treeView1.Nodes.Add(group.key.ToString());
                foreach (var item in group.g)
                {
                    node.Nodes.Add(string.Format("{0} - {1}", item.ProductID, item.ModifiedDate));
                }
            }

            this.dataGridView1.DataSource = q.ToList();

        }

        private void button8_Click(object sender, EventArgs e)
        {
          


            this.productPhotoTableAdapter1.SelectCommand = new SqlCommand("select * from Production.ProductPhoto Order by ProductPhotoID Desc", this.productPhotoTableAdapter1.Connection);
          
            this.productPhotoTableAdapter1.Fill(this.adventureWorksDataSet.ProductPhoto);
 
            this.dataGridView1.DataSource = this.adventureWorksDataSet.ProductPhoto;
        }

      
    }
}
