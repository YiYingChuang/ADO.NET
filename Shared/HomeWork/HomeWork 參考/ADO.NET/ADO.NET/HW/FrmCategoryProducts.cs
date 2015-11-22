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


namespace ADO.NET.HW
{
    public partial class FrmCategoryProducts : Form
    {
        public FrmCategoryProducts()
        {
            InitializeComponent();
            this.listBox1.Font = new Font("Courier new", 11, FontStyle.Bold | FontStyle.Italic);
          
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True"))
                {
                    using (SqlCommand command = new SqlCommand("select * from categories", conn))
                    {
                        conn.Open();
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            this.comboBox1.Items.Clear();
                            this.comboBox2.Items.Clear();
                            while (dataReader.Read())
                            {
                                this.comboBox1.Items.Add(dataReader["CategoryName"]);
                                this.comboBox2.Items.Add(new MyCategory { CategoryID= (int)dataReader["CategoryID"], CategoryName=dataReader["CategoryName"].ToString()});

                            }

                        } 
                    } 
                }
                this.comboBox1.SelectedIndex = 0;
                this.comboBox2.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO : 某分類的所有產品
            try
            {     
                string CommandText = " SELECT Categories.CategoryName, Products.*" +
                                             " FROM Categories INNER JOIN " +
                                             " Products ON Categories.CategoryID = Products.CategoryID " +
                                             " WHERE (Categories.CategoryName = '" + this.comboBox1.Text + "')";

                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(CommandText, conn))
                    {
                        conn.Open();
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            this.listBox1.Items.Clear();
                            while (dataReader.Read())
                            {
                                this.listBox1.Items.Add(string.Format("{4}\t{0}\t{2,10:0.00}\t{3,10}\t{1}", dataReader["ProductID"], dataReader["ProductName"], dataReader["UnitPrice"], dataReader["UnitsInStock"], dataReader["CategoryName"]));
                            }
                        } 
                    } 
                } 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO : 某分類的所有產品
            try
            {
                int CategoryID= ((MyCategory) this.comboBox2.SelectedItem).CategoryID;
                string CategoryName = ((MyCategory)this.comboBox2.SelectedItem).CategoryName;
                string CommandText = " SELECT  * from  Products where CategoryID=" + CategoryID;

                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(CommandText, conn))
                    {
                        conn.Open();
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            this.listBox1.Items.Clear();
                            while (dataReader.Read())
                            {
                                this.listBox1.Items.Add(string.Format("{4}\t{0}\t{2,10:0.00}\t{3,10}\t{1}", dataReader["ProductID"], dataReader["ProductName"], dataReader["UnitPrice"], dataReader["UnitsInStock"], CategoryName));
                            }

                        }
                    } 
                } 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    class MyCategory
    {
        public int CategoryID;
        public string CategoryName;
        public override string ToString()
        {
            return string.Format("{0}-{1}", this.CategoryID, this.CategoryName);
        }
    }
}
