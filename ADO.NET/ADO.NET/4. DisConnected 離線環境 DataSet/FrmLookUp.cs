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
    public partial class FrmLookUp : Form
    {
        public FrmLookUp()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();

            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void FrmLookUp_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'northwindDataSet.Products' 資料表。您可以視需要進行移動或移除。

            this.categoriesTableAdapter1.Fill(this.northwindDataSet.Categories);
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.productsBindingSource.EndEdit();
        }
    }
}
