using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET._4._DisConnected_離線環境_DataSet
{
    public partial class FrmRelation : Form
    {
        public FrmRelation()
        {
            InitializeComponent();
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void FrmRelation_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'northwindDataSet.Products' 資料表。您可以視需要進行移動或移除。
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);
             // TODO:  這行程式碼會將資料載入 'northwindDataSet.Categories' 資料表。您可以視需要進行移動或移除。
            this.categoriesTableAdapter.Fill(this.northwindDataSet.Categories);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = this.categoriesBindingSource;
            this.dataGridView1.DataMember = "FK_Products_Categories";
    
            //GetChildRows
        }

        private void categoriesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
           NorthwindDataSet.CategoriesRow row = this.northwindDataSet.Categories[ this.categoriesBindingSource.Position];
          
        

            //DataRow[] ChildRows = row.GetChildRows("FK_Products_Categories");

            //this.listBox1.Items.Clear();
            //foreach (DataRow dr in ChildRows)
            //{
            //    this.listBox1.Items.Add(dr["CategoryID"] + "-" + dr["ProductName"]);
            //}

           
           NorthwindDataSet.ProductsRow[] ChildRows = row.GetProductsRows();

           this.listBox1.Items.Clear();
           foreach (NorthwindDataSet.ProductsRow dr in ChildRows)
           {
               this.listBox1.Items.Add( dr.CategoryID+ "-" + dr.ProductName);
           }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //GetParentRow
            DataRow dr = this.northwindDataSet.Products[0].GetParentRow("FK_Products_Categories");

             MessageBox.Show(dr["CategoryName"].ToString());

            MessageBox.Show(this.northwindDataSet.Products[0].CategoriesRow.CategoryName);
        }
    }
}
