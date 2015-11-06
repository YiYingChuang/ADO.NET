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

namespace ADO0NET
{
    public partial class Frm_Connected : Form
    {
        public Frm_Connected()
        {
            InitializeComponent();
            this.write();

        }
        string ConnString = "Data Source=.;Initial Catalog=northwind;Integrated Security=True";
         
        private void button1_Click(object sender, EventArgs e)
        {
            this.comboBox1.Enabled = true;
            try
            {
                SqlConnection conn = null;
                using (conn = new SqlConnection(this.ConnString))
                {
                    using (SqlCommand comm = new SqlCommand("select * from Categories", conn))
                    {
                        conn.Open();
                        using (SqlDataReader DataReader = comm.ExecuteReader())
                        {
                            while (DataReader.Read())
                            {
                                
                                string s = DataReader["CategoryName"].ToString();
                                this.comboBox1.Items.Add(s);
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

        //private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        this.listBox1.Items.Clear();
        //        this.write();
        //        string name = comboBox1.SelectedText;
        //        using (SqlConnection conn = new SqlConnection(this.ConnString))
        //        {
        //            using (SqlCommand comm = new SqlCommand("select * from Products as p inner join Categories as c  on p.CategoryID = c.CategoryID where c.CategoryName="+this.Codding(name), conn))
        //            {
        //                conn.Open();
        //                using (SqlDataReader DataReader = comm.ExecuteReader())
        //                {
        //                    while (DataReader.Read())
        //                    {
        //                        string s1 = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}",
        //                                                  DataReader[0].ToString().PadRight(40 - DataReader[0].ToString().Length) + "\t",
        //                                                  DataReader[1].ToString().PadRight(40 - DataReader[1].ToString().Length) + "\t",
        //                                                  DataReader[2].ToString().PadRight(40 - DataReader[2].ToString().Length) + "\t",
        //                                                  DataReader[3].ToString().PadRight(40 - DataReader[3].ToString().Length) + "\t",
        //                                                  DataReader[4].ToString().PadRight(40 - DataReader[4].ToString().Length) + "\t",
        //                                                  DataReader[5].ToString().PadRight(40 - DataReader[5].ToString().Length) + "\t",
        //                                                  DataReader[6].ToString().PadRight(40 - DataReader[6].ToString().Length) + "\t",
        //                                                  DataReader[7].ToString().PadRight(40 - DataReader[7].ToString().Length) + "\t",
        //                                                  DataReader[8].ToString().PadRight(40 - DataReader[8].ToString().Length) + "\t",
        //                                                  DataReader[9].ToString().PadRight(40 - DataReader[9].ToString().Length) + "\t");
        //                        this.listBox1.Items.Add(s1);
        //                    }   
        //                }
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}
        string Codding(string name)
        {
            string s = string.Format("{0}{1}{2}", "'", name, "'");
            return s;
        }
        void write()
        {
            string s = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}",
                                       "ProductID".PadRight(60 - "ProductID".Length) + "\t",
                                       "ProductName".PadRight(60 - "ProductName".Length) + "\t",
                                       "SupplierID".PadRight(60 - "SupplierID".Length) + "\t",
                                       "CategoryID".PadRight(60 - "CategoryID".Length) + "\t",
                                       "QuantityPerUnit".PadRight(60 - "QuantityPerUnit".Length) + "\t",
                                       "UnitPrice".PadRight(60 - "UnitPrice".Length) + "\t",
                                       "UnitsInStock".PadRight(60 - "UnitsInStock".Length) + "\t",
                                       "UnitsOnOrder".PadRight(60 - "UnitsOnOrder".Length) + "\t",
                                       "ReorderLevel".PadRight(60 - "ReorderLevel".Length) + "\t",
                                       "Discontinued".PadRight(60 - "Discontinued".Length) + "\t");
            string s1 = "======================================================================================================================================================================";
            this.listBox1.Items.Add(s);
            this.listBox1.Items.Add(s1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.listBox1.Items.Clear();
                this.write();
                string name = comboBox1.Text;
                using (SqlConnection conn = new SqlConnection(this.ConnString))
                {
                    using (SqlCommand comm = new SqlCommand("select * from Products as p inner join Categories as c  on p.CategoryID = c.CategoryID where c.CategoryName=" + this.Codding(name), conn))
                    {
                        conn.Open();
                        using (SqlDataReader DataReader = comm.ExecuteReader())
                        {
                            while (DataReader.Read())
                            {
                                string s1 = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}",
                                                          DataReader[0].ToString().PadRight(60 - DataReader[0].ToString().Length) + "\t",
                                                          DataReader[1].ToString().PadRight(60 - DataReader[1].ToString().Length) + "\t",
                                                          DataReader[2].ToString().PadRight(60 - DataReader[2].ToString().Length) + "\t",
                                                          DataReader[3].ToString().PadRight(60 - DataReader[3].ToString().Length) + "\t",
                                                          DataReader[4].ToString().PadRight(60 - DataReader[4].ToString().Length) + "\t",
                                                          DataReader[5].ToString().PadRight(60 - DataReader[5].ToString().Length) + "\t",
                                                          DataReader[6].ToString().PadRight(60 - DataReader[6].ToString().Length) + "\t",
                                                          DataReader[7].ToString().PadRight(60 - DataReader[7].ToString().Length) + "\t",
                                                          DataReader[8].ToString().PadRight(60 - DataReader[8].ToString().Length) + "\t",
                                                          DataReader[9].ToString().PadRight(60 - DataReader[9].ToString().Length) + "\t");
                                this.listBox1.Items.Add(s1);
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
}
