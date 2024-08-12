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
    public partial class MemberInfo : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBcon = "";

        public MemberInfo()
        {
            InitializeComponent();
        }

        private void MemberInfo_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"Alice\MSSQLSERVER01";
            scsb.InitialCatalog = "Dessert Shop";
            scsb.IntegratedSecurity = true;
            scsb.Encrypt = false;
            strDBcon = scsb.ConnectionString;
            讀取會員資料();


        }



        void 讀取會員資料()
        {
            if(GlobalVar.Customerinfo.Count != 0)
            {
                SqlConnection con = new SqlConnection(strDBcon);
                con.Open();
                string strSQLcmd = "select * from Customer where Phone = @phone;";
                SqlCommand cmd = new SqlCommand(strSQLcmd, con);
                for (int i = 0; i < GlobalVar.Customerinfo.Count; i++)
                {
                    cmd.Parameters.AddWithValue("@phone", GlobalVar.Customerinfo.ElementAt(i).Key);
                }
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    txtID.Text = reader["ID"].ToString();
                    txt姓名.Text = (string)reader["CustomerName"];
                    txt電話.Text = (string)reader["Phone"];
                    txt地址.Text = (string)reader["Address"];
                    txt信箱.Text = (string)reader["Email"];
                    dateTimePicker生日.Value = (DateTime)reader["Birthday"];
                    reader.Close();
                }
                string strSQLcmd2 = "select * from CPassword where Customer_Phone = @phone;";
                SqlCommand cmd2 = new SqlCommand(strSQLcmd2, con);
                for (int i = 0; i < GlobalVar.Customerinfo.Count; i++)
                {
                    cmd2.Parameters.AddWithValue("@phone", GlobalVar.Customerinfo.ElementAt(i).Key);
                }
                SqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.Read() == true)
                {
                    txt密碼.Text = (string)reader2["CPassword"];
                    txt密碼確認.Text = (string)reader2["CPassword"];
                    reader2.Close();
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("請先登入");
                Close();
            }

        }
            


        private void btn離開_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "")&& (txt信箱.Text != "") && (txt密碼.Text != "") && (txt密碼確認.Text != ""))
            {
                if (txt密碼.Text == txt密碼確認.Text)
                {
                    SqlConnection con = new SqlConnection(strDBcon);
                    con.Open();
                    string strSQLcom = "Update Customer set CustomerName=@name,Address=@address,Birthday=@birthday, email=@mail where Phone=@phone;";
                    string strSQLcom2 = "Update CPassword set CPassword=@password where Customer_Phone=@phone";
                    SqlCommand cmd = new SqlCommand(strSQLcom, con);
                    SqlCommand cmd2 = new SqlCommand(strSQLcom2, con);
                    cmd.Parameters.AddWithValue("@name", txt姓名.Text);
                    cmd.Parameters.AddWithValue("@phone", txt電話.Text);
                    cmd.Parameters.AddWithValue("@address", txt地址.Text);
                    cmd.Parameters.AddWithValue("@birthday", dateTimePicker生日.Value);
                    cmd.Parameters.AddWithValue("@mail", txt信箱.Text);
                    cmd2.Parameters.AddWithValue("@phone", txt電話.Text);
                    cmd2.Parameters.AddWithValue("@password", txt密碼.Text);
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("儲存成功!");
                }
                else
                {
                    MessageBox.Show("請輸入一致密碼");
                }
            }
            else
            {
                MessageBox.Show("*號資料不可為空白!");
            }
            
        }
    }
}
