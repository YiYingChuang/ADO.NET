using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Web.Security;
using System.Windows.Forms;
using ADO.NET.Properties;

namespace ADO.NET.HW
{
    public partial class FrmLogOn : Form
    {
        public FrmLogOn()
        {
            InitializeComponent();
        }

        int tryCount = 0;
        private void OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.None;
  
            tryCount += 1;
            if (tryCount > 3)
            {
                this.Close();
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        string userName = this.UsernameTextBox.Text;
                        string password = this.PasswordTextBox.Text;
                        command.CommandText = "select * from  Member  where UserName=@UserName";
                        command.Connection = conn;

                        command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = userName;

                        conn.Open();
                        this.errorProvider1.Clear();
                        SqlDataReader dataReader = command.ExecuteReader();
                        dataReader.Read();
                        if (dataReader.HasRows)
                        {
                            if (FormsAuthentication.HashPasswordForStoringInConfigFile(password, "sha1") == dataReader["Password"].ToString())
                            {
                                MessageBox.Show("LogON successfully");
                                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                                this.Close();
        
                            }
                            else
                            {

                                MessageBox.Show("Wrong Password");
                                this.errorProvider1.SetError(this.PasswordTextBox, "Wrong Password");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Wrong UserName ");
                            this.errorProvider1.SetError(this.UsernameTextBox, "Wrong UserName");
                      
                        }
                        
                    } 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        string userName = this.UsernameTextBox.Text;
                        string password = this.PasswordTextBox.Text;
                        password = FormsAuthentication.HashPasswordForStoringInConfigFile(password, FormsAuthPasswordFormat.SHA1.ToString());  //this.textBox2.Text;
                        //string password = GetSwcSH1(this.textBox2.Text);

                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "InsertMember";
                        command.Connection = conn;

                        command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = userName;
                        command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = password;

                        //===============
                        SqlParameter p1 = new SqlParameter();
                        p1.ParameterName = "@Return_Value";
                        p1.Direction = ParameterDirection.ReturnValue;
                        command.Parameters.Add(p1);

                        //===============

                        conn.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show(p1.Value + "  Insert Member successfully");

                    } //command.Dispose();

                } //auto   conn.Close(); conn.Dispose()

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
