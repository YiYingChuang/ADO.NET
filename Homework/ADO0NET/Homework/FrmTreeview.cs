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

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
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
                                     if (DataReader.IsDBNull(i))  // 取得值，指出資料行是否含有不存在或遺漏的值。
                                    {
                                        viewitem.SubItems.Add("空值");
                                    }
                                    else
                                    {
                                     viewitem.SubItems.Add(DataReader[i].ToString());
                                    }

                                    if(this.listView1.Groups.Count==0)
                                    {
                                    this.listView1.Groups.Add(DataReader[8].ToString());
                                    }
                                    foreach(var item in this.listView1.Groups)
                                    {
                                    
                                    }
                                    if(this.listView1.Groups[].Name ==null )
                                    DataReader[8].ToString()
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
    }
}
