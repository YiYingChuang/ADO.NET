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
    public partial class FrmAddProduct : Form
    {
        public FrmAddProduct()
        {
            InitializeComponent();
        }

        
        public string ProductName
        {
            get
            {
                //.......
                return this.textBox1.Text;
            }

        }

        public bool Discontinued
        {
            get
            {
                //.....
                return this.checkBox1.Checked;
            }
        }

    }
}
