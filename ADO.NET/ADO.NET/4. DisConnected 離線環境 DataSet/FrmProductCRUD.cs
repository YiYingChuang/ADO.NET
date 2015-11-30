using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADO.NET._4._DisConnected_離線環境_DataSet;

namespace ADO.NET
{
    public partial class FrmProductCRUD : Form
    {
        public FrmProductCRUD()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void FrmProductManagement_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'northwindDataSet.Products' 資料表。您可以視需要進行移動或移除。
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);

        }

        private void Button15_Click(object sender, EventArgs e)
        {
            this.productsBindingSource.MoveNext();

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            this.productsBindingSource.Position -= 1;
        }

        bool flag = true;
        private void Button23_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                 this.productsBindingSource.Sort = "ProductName asc";
            }
            else
            {
                this.productsBindingSource.Sort = "ProductName desc";

            }
            flag = !flag;
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            int position = this.productsBindingSource.Find("ProductID", 11);
            this.productsBindingSource.Position = position;

        }

        private void Button21_Click(object sender, EventArgs e)
        {
            this.productsBindingSource.Filter = "UnitPrice>30";

        }

        private void Button20_Click(object sender, EventArgs e)
        {
            this.productsBindingSource.AddNew();

        }

        private void Button19_Click(object sender, EventArgs e)
        {
            this.productsBindingSource.RemoveAt(this.productsBindingSource.Position);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            FrmAddProduct f = new FrmAddProduct();

            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //MessageBox.Show("OK");

                //DataRow dr = this.northwindDataSet.Products.NewRow();
                //dr["ProductNamex"] = f.ProductName; // f.textBox1.Text;
                //dr["Discontinued"] = f.Discontinued; //f.checkBox1.Checked;    // f.ProductName = "xxx";
                //this.northwindDataSet.Products.Rows.Add(dr);


                //Strong type
                NorthwindDataSet.ProductsRow  dr=  this.northwindDataSet.Products.NewProductsRow();
                dr.ProductName = f.ProductName;
                dr.Discontinued = f.Discontinued;

                this.northwindDataSet.Products.AddProductsRow(dr);
                this.productsBindingSource.MoveLast();

            }
            else
                MessageBox.Show("Cancel");
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            DataView dv1 = new DataView(this.northwindDataSet.Products);
            dv1.RowFilter = "UnitPrice > 30";
            this.dataGridView1.DataSource = dv1;


            DataView dv2 = new DataView(this.northwindDataSet.Products);
            dv2.RowFilter = "ProductName like 'C%'";
            this.dataGridView2.DataSource = dv2;

        }

        private void Button18_Click(object sender, EventArgs e)
        {
            NorthwindDataSet.ProductsRow dr = (NorthwindDataSet.ProductsRow)((DataRowView)this.productsBindingSource.Current).Row;
            dr.ProductName += "@@@";
        }
    }
}
