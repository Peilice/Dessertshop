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

namespace Dessertshop
{
    public partial class Login : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBconing = "";


        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"Alice\MSSQLSERVER01";
            scsb.InitialCatalog = "Dessert Shop";
            scsb.IntegratedSecurity = true;
            scsb.Encrypt = false;
            strDBconing = scsb.ConnectionString;
        }

        private void btn離開_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn會員申請_Click(object sender, EventArgs e)
        {
            NewMember mynewmem = new NewMember();
            mynewmem.ShowDialog();
            Close();
        }

        private void btn登入_Click(object sender, EventArgs e)
        {

            if ((txt電話.Text !="") && (txt密碼.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBconing);
                con.Open();
                string strSQLcom = "select* from CPassword where Customer_Phone = @Phone and CPassword = @Password";
                SqlCommand cmd = new SqlCommand(strSQLcom, con);
                cmd.Parameters.AddWithValue("@Phone", txt電話.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txt密碼.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    GlobalVar.islogin = true;
                    MessageBox.Show("登入成功");
                    reader.Close();
                    string strSQLcmd2 = "select* from Customer where Phone = @phone;";
                    SqlCommand cmd2 = new SqlCommand(strSQLcmd2, con);
                    cmd2.Parameters.AddWithValue("@phone", txt電話.Text);
                    SqlDataReader reader2 = cmd2.ExecuteReader();
                    if (reader2.Read())
                    {
                        string Name = (string)reader2["CustomerName"];
                        GlobalVar.Customerinfo.Add(txt電話.Text, Name);
                        reader2.Close();
                    }

                    con.Close();
                    Close();
                }
                else
                {
                    txt密碼.Clear();
                    MessageBox.Show("帳號或密碼有誤，請確認!");
                }
                reader.Close();
                con.Close();
                

            }
            else
            {
                MessageBox.Show("帳號與密碼不可為空白");
            }

        }
    }
}
