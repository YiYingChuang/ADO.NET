using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET.HW
{

    public partial class FrmAdventureWorksProduct : Form
    {
        public FrmAdventureWorksProduct()
        {
            InitializeComponent();
        }

        private void productPhotoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productPhotoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adventureWorksDataSet);

        }

        private void FrmAdventureWorksProduct_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'adventureWorksDataSet.ProductPhoto' 資料表。您可以視需要進行移動或移除。
            this.productPhotoTableAdapter.Fill(this.adventureWorksDataSet.ProductPhoto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.productPhotoTableAdapter.FillByModifiedDate(this.adventureWorksDataSet.ProductPhoto, this.dateTimePicker1.Value, this.dateTimePicker2.Value);
            this.productPhotoTableAdapter.FillByModifiedDate(this.adventureWorksDataSet.ProductPhoto, this.dateTimePicker1.Value, this.dateTimePicker2.Value);
          
            this.productPhotoDataGridView.DataSource = this.adventureWorksDataSet.ProductPhoto;

        }
    }
}
