using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ADO.NET._4._DisConnected_離線環境_DataSet;
using ADO.NET;

namespace Starter
{
    public partial class FrmDisconnected_離線環境_Solution : Form
    {
        public FrmDisconnected_離線環境_Solution()
        {
            InitializeComponent();
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            this.categoriesTableAdapter1.Fill(this.northwindDataSet1.Categories);

            this.productsTableAdapter1.Fill(this.northwindDataSet1.Products);

            //this.dataGridView1.DataSource = this.northwindDataSet1.Categories;

            this.dataGridView1.DataSource = this.northwindDataSet1;
            this.dataGridView1.DataMember = "Categories";

            this.dataGridView7.DataSource = this.northwindDataSet1.Products;

        }

        private void Button29_Click(object sender, EventArgs e)
        {
            this.dataGridView1.AllowUserToAddRows = false;
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            this.dataGridView7.Columns[2].Frozen = true;
            this.dataGridView7.Rows[2].Frozen = true;
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.dataGridView7.CurrentCell.Value.ToString());

        }

        private void Button27_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.dataGridView7.CurrentRow.Cells[1].Value.ToString());
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            DataGridViewLinkColumn x = new DataGridViewLinkColumn();
            x.HeaderText = "xxx";
            x.Text = "xxx";
            x.UseColumnTextForLinkValue = true;

            this.dataGridView7.Columns.Add(x);

            //======================

            DataGridViewTextBoxColumn y = new DataGridViewTextBoxColumn();
            y.HeaderText = "ProductName";
            y.DataPropertyName = "ProductName";
            this.dataGridView7.Columns.Add(y);


        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (  e.ColumnIndex == 0)
            {
                int ProductID = (int)this.dataGridView7.CurrentRow.Cells["productIDDataGridViewTextBoxColumn"].Value;

                //MessageBox.Show("ProductID = " + ProductID);
                FrmProductDetails f = new FrmProductDetails();
                f.ProductID = ProductID;

                f.Show();

            }
        }

        private void dataGridView7_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
         
            if (this.dataGridView7.Columns[  e.ColumnIndex].Name == "unitPriceDataGridViewTextBoxColumn")


            {
                if ( e.Value is DBNull || e.Value == null) return;

                decimal unitPrice = (decimal)e.Value;
                if (unitPrice >30)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Green;
                }

                e.CellStyle.Format = "c2";

            }
        }
      DataTable empTable = new DataTable("Employee");
        private void button32_Click(object sender, EventArgs e)
        {
      

            DataColumn column1 =  empTable.Columns.Add("EmpID", typeof(int));
            column1.AutoIncrementSeed = 1;
            column1.AutoIncrementStep = 1;
            column1.AutoIncrement = true;

            empTable.Columns.Add("EmpName", typeof(string));
            empTable.Columns.Add("HireDate", typeof(DateTime));
            empTable.Columns.Add("Salary", typeof(decimal));
            empTable.Columns.Add("+Salary", typeof(decimal)).Expression = "Salary * 1.1";

            //=========================
            DataRow dr = empTable.NewRow();
            dr["EmpName"] = "xxx";
            dr["HireDate"] = DateTime.Now;
            dr["Salary"] = 40000;

            empTable.Rows.Add(dr);
            //=========================

            this.dataGridView9.DataSource = empTable;



        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.northwindDataSet1.Products);
            this.dataGridView8.DataSource = this.northwindDataSet1.Products;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.northwindDataSet1.Products.Columns.Add("TotalPrice", typeof(decimal)).Expression = "UnitPrice * UnitsInStock";

            //====================================
            this.dataGridView8.Columns["TotalPrice"].DefaultCellStyle.ForeColor = Color.Green;

        }

        private void button31_Click(object sender, EventArgs e)
        {
            empTable.WriteXml("employees.xml", XmlWriteMode.WriteSchema);
        }

        
           
        
        #region "Update (處理資料衝突)"



        string CreateMessage(NorthwindDataSet.ProductsRow cr)
        {

            return
                 "Database: " + GetRowData(GetCurrentRowInDB(cr), DataRowVersion.Default) + Environment.NewLine +
                 "Original: " + GetRowData(cr, DataRowVersion.Original) + Environment.NewLine +
                 "Proposed: " + GetRowData(cr, DataRowVersion.Current) + Environment.NewLine +
                 "Do you still want to update the database with the proposed value?";

        }

        //'--------------------------------------------------------------------------
        //' This method loads a temporary table with current records from the database
        //' and returns the current values from the row that caused the exception.
        //'--------------------------------------------------------------------------
        private NorthwindDataSet.ProductsDataTable TempProductsDataTable;

        NorthwindDataSet.ProductsRow GetCurrentRowInDB(NorthwindDataSet.ProductsRow RowWithError)
        {

            TempProductsDataTable = new NorthwindDataSet.ProductsDataTable();
            this.productsTableAdapter1.Fill(TempProductsDataTable);

            NorthwindDataSet.ProductsRow currentRowInDb =
                 TempProductsDataTable.FindByProductID(RowWithError.ProductID);

            return currentRowInDb;

        }


        //    //'--------------------------------------------------------------------------
        //    //' This method takes a productsRow and RowVersion 
        //    //' and returns a string of column values to display to the user.
        //    //'--------------------------------------------------------------------------
        string GetRowData(NorthwindDataSet.ProductsRow custRow, DataRowVersion RowVersion)
        {

            string rowData = "";

            for (int i = 0; i <= custRow.ItemArray.Length - 1; i++)
            {
                rowData += custRow[i, RowVersion].ToString() + " ";
            }


            return rowData;
        }

        //    //' This method takes the DialogResult selected by the user and updates the database 
        //    //' with the new values or cancels the update and resets the Customers table 
        //    //' (in the dataset) with the values currently in the database.


        void ProcessDialogResult(DialogResult response)
        {
            switch (response)
            {

                //yes
                case DialogResult.Yes:
                    this.northwindDataSet1.Products.Merge(TempProductsDataTable, true);
                    UpdateDatabase();
                    break;


                //no
                case DialogResult.No:
                    this.northwindDataSet1.Products.Merge(TempProductsDataTable);
                    MessageBox.Show("Update cancelled");
                    break;
            }

        }

        void UpdateDatabase()
        {
            try
            {
                this.productsTableAdapter1.Update(this.northwindDataSet1.Products);
                MessageBox.Show("Update successful");

            }

            catch (DBConcurrencyException dbcx)
            {
                DialogResult response;

                response = MessageBox.Show(CreateMessage((NorthwindDataSet.ProductsRow)dbcx.Row), "Concurrency Exception", MessageBoxButtons.YesNo);

                ProcessDialogResult(response);
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error was thrown while attempting to update the database.");

            }

        }
        #endregion


        private void Button8_Click(object sender, EventArgs e)
        {
            this.UpdateDatabase();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.northwindDataSet1.Products);
            this.DataGridView6.DataSource = this.northwindDataSet1.Products;

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Update(this.northwindDataSet1.Products);
          
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.DataGridView5.DataSource= this.northwindDataSet1.Products.GetChanges(DataRowState.Added);
            this.DataGridView3.DataSource = this.northwindDataSet1.Products.GetChanges(DataRowState.Modified);

        }

        private void Button6_Click(object sender, EventArgs e)
        {


            try
            {
                this.productsTableAdapter1.Update(this.northwindDataSet1.Products);

            }
            catch (DBConcurrencyException ex)
            {
                //...........
                MessageBox.Show("........." + ex.Message);
            }
            catch (Exception ex)
            {

            }
         
        }


      


     
    }
}