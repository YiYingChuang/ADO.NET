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
    public partial class Frm_Adventureworks : Form
    {
        public Frm_Adventureworks()
        {
            InitializeComponent();

            SqlConnection conn = new SqlConnection(Settings.Default.AdventureWorksConnectionString);
            SqlDataAdapter Ada = new SqlDataAdapter("SELECT DISTINCT Year(ModifiedDate) FROM  Production.ProductPhoto order by Year(ModifiedDate)", conn);
            DataSet DS = new DataSet();
            Ada.Fill(DS);
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                this.comboBox1.Items.Add(DS.Tables[0].Rows[i][0]);
            }
            
        }

        private void productPhotoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productPhotoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adventureWorksDataSet);

        }

        private void Frm_Adventureworks_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'adventureWorksDataSet.ProductPhoto' 資料表。您可以視需要進行移動或移除。
            this.productPhotoTableAdapter.Fill(this.adventureWorksDataSet.ProductPhoto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.largePhotoPictureBox.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.productPhotoTableAdapter.FillBy_ModifiedDate(this.adventureWorksDataSet.ProductPhoto, this.dateTimePicker1.Value, this.dateTimePicker2.Value);
            this.productPhotoDataGridView.DataSource = this.adventureWorksDataSet.ProductPhoto;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.productPhotoTableAdapter.Fill(this.adventureWorksDataSet.ProductPhoto);
            this.productPhotoDataGridView.DataSource = this.adventureWorksDataSet.ProductPhoto;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.productPhotoTableAdapter.FillByModifiedDate(this.adventureWorksDataSet.ProductPhoto, int.Parse(this.comboBox1.Text));
           
        }
       
    }
}
