using ADO.NET.Properties;
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
    public partial class FrmMyAlbumManagement : Form
    {
        public FrmMyAlbumManagement()
        {
            InitializeComponent();

            //fionwang
            this.photosTableAdapter.Connection.ConnectionString = Settings.Default.MyAlbumConnectionString;
            this.photoCategoryTableAdapter.Connection.ConnectionString = Settings.Default.MyAlbumConnectionString;

        }

        private void photosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.photosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myAlbum);

        }

        private void FrmMyAlbumManagement_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'myAlbum.Photos' 資料表。您可以視需要進行移動或移除。
            this.photosTableAdapter.Fill(this.myAlbum.Photos);
            // TODO: 這行程式碼會將資料載入 'myAlbum.PhotoCategory' 資料表。您可以視需要進行移動或移除。
            this.photoCategoryTableAdapter.Fill(this.myAlbum.PhotoCategory);
            // TODO: 這行程式碼會將資料載入 'myAlbum.Photos' 資料表。您可以視需要進行移動或移除。
            this.photosTableAdapter.Fill(this.myAlbum.Photos);

        }

        private void photoCategoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.photoCategoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myAlbum);

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
