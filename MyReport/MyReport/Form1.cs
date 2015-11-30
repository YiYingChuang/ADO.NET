﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.categoryProductTableAdapter1.Fill(this.reportDataSet1.CategoryProduct);
            this.dataGridView1.DataSource = this.reportDataSet1.CategoryProduct;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'ReportDataSet.CategoryProduct' 資料表。您可以視需要進行移動或移除。
            this.CategoryProductTableAdapter.Fill(this.ReportDataSet.CategoryProduct);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int categoryID = int.Parse(this.textBox1.Text);
            this.categoryProductTableAdapter1.FillByCategoryID(this.ReportDataSet.CategoryProduct, categoryID);
            this.reportViewer1.RefreshReport();

        }
    }
}
