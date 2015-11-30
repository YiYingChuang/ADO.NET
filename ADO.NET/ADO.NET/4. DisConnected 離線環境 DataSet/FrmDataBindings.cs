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
    public partial class FrmDataBindings : Form
    {
        public FrmDataBindings()
        {
            InitializeComponent();
        }

        private void myImageTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.myImageTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void FrmDataBindings_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'northwindDataSet.MyImageTable' 資料表。您可以視需要進行移動或移除。
            this.myImageTableTableAdapter.Fill(this.northwindDataSet.MyImageTable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.DataBindings.Add("Image", this.myImageTableBindingSource, "Image", true);
            this.textBox1.DataBindings.Add("Text", this.myImageTableBindingSource, "Description");

            //======================================
            this.dataGridView1.DataSource = this.northwindDataSet.MyImageTable;

            this.dataGridView2.DataSource = this.northwindDataSet;
            this.dataGridView2.DataMember = "MyImageTable";

            this.dataGridView3.DataSource = this.myImageTableBindingSource;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BindingContext[this.northwindDataSet.MyImageTable].Position += 1;
            this.BindingContext[this.northwindDataSet, "MyImageTable"].Position += 1;

        }
    }
}
