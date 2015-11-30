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
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.northwindConnectionString))
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = "select * from [dbo].[User] where UserName = @UserName";
                        //comm.CommandText = "select * from User where UserName = @UserName";
                        comm.Connection = conn;
                        string UserName = this.UserNametextBox.Text;
                        string Password = this.PasswordtextBox.Text;

                        comm.Parameters.Add("@UserName", SqlDbType.NVarChar, 20).Value = UserName;
                        conn.Open();

                        using (SqlDataReader dataread = comm.ExecuteReader())
                        { 
                            dataread.Read();
                            if (dataread.HasRows)
                            {
                                if (Password == dataread["Password"].ToString())
                                {
                                    MessageBox.Show("OK!");
                                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                                }
                                else
                                {
                                    MessageBox.Show("Wrong Password!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Creat a New UserName!");
                            }
                        
                        }
                        
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void CreatUser_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.northwindConnectionString))
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = "Insert into [dbo].[User](UserName,Password) values (@UserName,@Password)";
                        comm.Connection = conn;
                        string UserName = this.UserNametextBox.Text;
                        string Password = this.PasswordtextBox.Text;

                        comm.Parameters.Add("@UserName", SqlDbType.NVarChar, 20).Value = UserName;
                        comm.Parameters.Add("@Password", SqlDbType.NVarChar, 20).Value = Password;
                        conn.Open();
                        comm.ExecuteNonQuery();
                        MessageBox.Show("Creat Successfully!");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message)
                    ;
            }
            
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
