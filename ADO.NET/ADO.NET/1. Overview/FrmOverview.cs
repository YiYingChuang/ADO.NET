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


namespace ADO.NET._1._Overview
{
    public partial class FrmOverview : Form
    {
        public FrmOverview()
        {
            InitializeComponent();

            this.tabControl1.SelectedIndex = 4;
        }


        #region Connected

     
        string connString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            //Connected 連線環境

            //Step 1:SqlConnection
            //Step 2: SqlCommand
            //Step 3: SqlDataReader
            //Step 4: Control

            SqlConnection conn = null;
            SqlCommand command = null;
            SqlDataReader dataReader = null;
            try
            {
               conn = new SqlConnection(connString);
                conn.Open();

                 command= new SqlCommand("select * from Categories", conn);
               
                 dataReader=  command.ExecuteReader();
                //dataReader.Read();
                //string s =  dataReader["CategoryName"].ToString();
                //MessageBox.Show(s);

               
                this.listBox1.Items.Clear();
                while( dataReader.Read())
                {
                    string s = string.Format("{0} - {1}", dataReader["CategoryID"], dataReader["CategoryName"]);
                    this.listBox1.Items.Add(s);
                }

                //conn.Close();
               // MessageBox.Show("successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                if (dataReader != null)
                {
                    dataReader.Dispose();
                }

                if (command != null)
                {
                    command.Dispose();
                }

                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();   // 釋放 System.ComponentModel.Component 所使用的所有資源。

                }
              
               
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlDataReader dataReader = new SqlDataReader();
            //Graphics g = new Graphics();

            Graphics g1=  this.CreateGraphics();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand command = new SqlCommand("select * from Categories", conn))
                    {

                        conn.Open();

                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            this.listBox1.Items.Clear();

                            while (dataReader.Read())
                            {
                                string s = string.Format("{0} - {1}", dataReader["CategoryID"], dataReader["CategoryName"]);
                                this.listBox1.Items.Add(s);
                            }

                        }//auto call  dataReader.Dispose()

                    } //auto call command.Dispose();

                } // auto conn.close()=>conn.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
 
            try
            {
                SqlConnection conn= null;
                using ( conn= new SqlConnection(connString))
                {
                    using (SqlCommand command = new SqlCommand("select * from Categories", conn))
                    {
                        conn.Disposed += conn_Disposed;
                        command.Disposed += command_Disposed;
                        conn.Open();
                        MessageBox.Show(conn.State.ToString());

                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            this.listBox1.Items.Clear();

                            while (dataReader.Read())
                            {
                                string s = string.Format("{0} - {1}", dataReader["CategoryID"], dataReader["CategoryName"]);
                                this.listBox1.Items.Add(s);
                            }

                        }//auto call  dataReader.Dispose()

                    } //auto call command.Dispose();

                } // auto conn.close()=>conn.Dispose() => Disposed event;
                MessageBox.Show(conn.State.ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        void command_Disposed(object sender, EventArgs e)
        {
            MessageBox.Show("command Disposed");
        }

        void conn_Disposed(object sender, EventArgs e)
        {
            MessageBox.Show("conn Disposed");
        }
        #endregion


        #region Disconnected DataSet
        private void button5_Click(object sender, EventArgs e)
        {
            //Step 1: sqlConnection
            //Step 2: sqlDataAdapter
            //Step 3: DataSet
            //Step 4:Control (DataGridView)

            try
            {
                SqlConnection conn = new SqlConnection(connString);
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Categories", conn);
                DataSet ds = new DataSet();

                //Auto Connected :conn.open()=> command.executeReader()=>sqlDataReader()=>..conn.Close();
                adapter.Fill(ds);

                //binding
                this.dataGridView1.DataSource = ds.Tables[0];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
        #endregion

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Products where UnitPrice>30", conn);
                DataSet ds = new DataSet();

                //Auto Connected :conn.open()=> execute SelectCommand => sqlDataReader()=>..conn.Close();
                adapter.Fill(ds);

                //binding
                this.dataGridView1.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Auto Connected :conn.open()=> execute SelectCommand => sqlDataReader()=>..conn.Close();
             
          this.categoriesTableAdapter1.Fill(this.northwindDataSet1.Categories);
            this.dataGridView2.DataSource = this.northwindDataSet1.Categories;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.productsTableAdapter1.FillByUnitPrice(this.northwindDataSet1.Products,30);
            this.dataGridView2.DataSource = this.northwindDataSet1.Products;
        }


        private void button9_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.InsertProduct(DateTime.Now.ToLongTimeString(), true);

            this.productsTableAdapter1.Fill(this.northwindDataSet1.Products);
            this.dataGridView2.DataSource = this.northwindDataSet1.Products;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //SqlConnection

            this.customersTableAdapter1.Fill(this.northwindDataSet1.Customers);
            this.dataGridView2.DataSource = this.northwindDataSet1.Customers;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.customersTableAdapter1.Update(this.northwindDataSet1.Customers);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.categoriesTableAdapter1.Fill(this.northwindDataSet1.Categories);

            this.bindingSource1.DataSource = this.northwindDataSet1.Categories;
            
            this.dataGridView3.DataSource = this.bindingSource1;
            this.textBox1.DataBindings.Add("Text", this.bindingSource1, "CategoryName");
            this.pictureBox1.DataBindings.Add("Image", this.bindingSource1, "Picture", true);



            this.bindingNavigator1.BindingSource = this.bindingSource1;


        }

        private void button17_Click(object sender, EventArgs e)
        {
       
           // this.bindingSource1.MoveNext();
            this.bindingSource1.Position += 1;
           // this.label4.Text = string.Format("{0} / {1}", this.bindingSource1.Position + 1, this.bindingSource1.Count);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //this.bindingSource1.MoveLast();
            this.bindingSource1.Position = this.bindingSource1.Count - 1;
            //this.label4.Text = string.Format("{0} / {1}", this.bindingSource1.Position + 1, this.bindingSource1.Count);
   
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //this.bindingSource1.MovePrevious();
            this.bindingSource1.Position -= 1;
           // this.label4.Text = string.Format("{0} / {1}", this.bindingSource1.Position + 1, this.bindingSource1.Count);
   
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //this.bindingSource1.MoveFirst();
            this.bindingSource1.Position = 0;
            //this.label4.Text = string.Format("{0} / {1}", this.bindingSource1.Position + 1, this.bindingSource1.Count);
   
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            this.label4.Text = string.Format("{0} / {1}", this.bindingSource1.Position + 1, this.bindingSource1.Count);
   
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (sender == button22)
            {
                this.bindingSource1.MoveFirst();
            }
            else if (sender == button21)
            {
                //....
            }
            //...

        }

        private void button18_Click(object sender, EventArgs e)
        {
            FrmTool f = new FrmTool();
            f.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {


            this.categoriesTableAdapter1.Fill(this.northwindDataSet1.Categories);
            this.productsTableAdapter1.Fill(this.northwindDataSet1.Products);
            this.customersTableAdapter1.Fill(this.northwindDataSet1.Customers);


            this.dataGridView4.DataSource = this.northwindDataSet1.Categories;
            this.dataGridView5.DataSource = this.northwindDataSet1.Products;
            this.dataGridView6.DataSource = this.northwindDataSet1.Customers;

            //MessageBox.Show(this.northwindDataSet1.Tables.Count.ToString());


            this.listBox2.Font = new Font("標楷體", 10, FontStyle.Bold);
            for (int i = 0; i <= this.northwindDataSet1.Tables.Count - 1; i++)
            {
                DataTable table = this.northwindDataSet1.Tables[i];
                this.listBox2.Items.Add(table.TableName);


                //DataColumn
                string s = "";
                for (int column = 0; column <= table.Columns.Count - 1; column++)
                {
                    s += string.Format("{0, -40}", table.Columns[column].ColumnName);
                }
                this.listBox2.Items.Add(s);


                //DataRow
                for (int row = 0; row <= table.Rows.Count - 1; row++)
                {
                    s = "";
                    for (int column = 0; column <= table.Columns.Count - 1; column++)
                    {
                        s += string.Format("{0, -40}", table.Rows[row][column]);
                    }
                    this.listBox2.Items.Add(s);
                }

                this.listBox2.Items.Add("=========================================================================");
            }

        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2Collapsed = !this.splitContainer2.Panel2Collapsed;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.northwindDataSet1.Products);
            this.dataGridView7.DataSource = this.northwindDataSet1.Products;

            //compiler error
            //MessageBox.Show(this.northwindDataSet1.Products[0].ProductNam);
            MessageBox.Show(this.northwindDataSet1.Products[0].ProductName);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Products", conn);
            adapter.Fill(this.dataSet1);

            this.dataGridView8.DataSource = this.dataSet1.Tables[0];

            //compiler ok, run time error
            //MessageBox.Show(this.dataSet1.Tables[0].Rows[0]["ProductNamex"].ToString());
            MessageBox.Show(this.dataSet1.Tables[0].Rows[0]["ProductName"].ToString());

        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.northwindDataSet1.Products.WriteXml("Products.xml", XmlWriteMode.WriteSchema);

        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.dataSet1.Tables[0].WriteXml("unTyped.xml", XmlWriteMode.WriteSchema);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.northwindDataSet1.Products.ReadXml("Products.xml");
            this.dataGridView7.DataSource = this.northwindDataSet1.Products;
        }


     
     
    }
}
