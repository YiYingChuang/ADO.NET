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
using ADO0NET.Properties;

namespace ADO0NET.Homework
{
    public partial class FrmCategoryProducts_LinkLabel : Form
    {
        public FrmCategoryProducts_LinkLabel()
        {
            InitializeComponent();
        }

        private void FrmCategoryProducts_LinkLabel_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = Settings.Default.northwindConnectionString;
                SqlDataAdapter dataadapter = new SqlDataAdapter("select * from Products", conn);
                DataSet dataset = new DataSet();
                dataadapter.Fill(dataset);

                this.dataGridView1.DataSource = dataset.Tables[0];
                for (int i = 0; i < dataset.Tables[0].Columns.Count; i++)
                {
                    LinkLabel newlable = new LinkLabel();
                    newlable.Text = dataset.Tables[0].Columns[i].ColumnName;
                    this.flowLayoutPanel1.Controls.Add(newlable);
                    newlable.Click += newlable_Click;
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
    
        }

        void newlable_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = Settings.Default.northwindConnectionString;
                SqlDataAdapter dataadapter = new SqlDataAdapter("select * from Products order by "+((LinkLabel)sender).Text, conn);
                DataSet dataset = new DataSet();
                dataadapter.Fill(dataset);

                this.dataGridView1.DataSource = dataset.Tables[0];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }

}
