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
using ADO0NET.Properties;

namespace ADO0NET.Homework
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Settings.Default.northwindConnectionString))
            {
                using (SqlCommand comm = new SqlCommand()) 
                {
                    comm.CommandText = "select * from User where UserName = @UserName";
                    comm.Connection = conn;
                    string UserName = this.UserNametextBox.Text;
                    string Password = this.UserNametextBox.Text;

                    comm.Parameters.Add("@UserName", SqlDbType.NVarChar, 20).Value = UserName;
                    SqlDataReader dataread = comm.ExecuteReader();
                    dataread.Read();
                    if (dataread.HasRows)
                    { 
                    
                    }
                }
            }
        }

        private void CreatUser_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Settings.Default.northwindConnectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "select * from User where UserName = @UserName";
                    comm.Connection = conn;
                    string UserName = this.UserNametextBox.Text;
                    string Password = this.UserNametextBox.Text;

                    comm.Parameters.Add("@UserName", SqlDbType.NVarChar, 20).Value = UserName;
                    SqlDataReader dataread = comm.ExecuteReader();
                    dataread.Read();
                    if (dataread.HasRows)
                    {

                    }
                }
            }
        }
    }
}
