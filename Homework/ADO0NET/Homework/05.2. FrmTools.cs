﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO0NET.Homework
{
    public partial class FrmTools : Form
    {
        public FrmTools()
        {
            InitializeComponent();
        }

        private void photoCategoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.photoCategoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myAlbumDataSet);

        }

        private void FrmTools_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'myAlbumDataSet.Photos' 資料表。您可以視需要進行移動或移除。
            this.photosTableAdapter.Fill(this.myAlbumDataSet.Photos);
            // TODO:  這行程式碼會將資料載入 'myAlbumDataSet.PhotoCategory' 資料表。您可以視需要進行移動或移除。
            this.photoCategoryTableAdapter.Fill(this.myAlbumDataSet.PhotoCategory);

        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.picturePictureBox.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }
    }
}
