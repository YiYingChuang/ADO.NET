using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET._1._Overview
{
    public partial class FrmTool : Form
    {
        public FrmTool()
        {
            InitializeComponent();
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void FrmTool_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'northwindDataSet.Categories' 資料表。您可以視需要進行移動或移除。
            this.categoriesTableAdapter.Fill(this.northwindDataSet.Categories);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.picturePictureBox.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }
    }
}
