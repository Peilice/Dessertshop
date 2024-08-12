using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dessertshop
{
    public partial class NewMember : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBcon = "";

        public NewMember()
        {
            InitializeComponent();
        }

        private void NewMember_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"Alice\MSSQLSERVER01";
            scsb.InitialCatalog = "Dessert Shop";
            scsb.IntegratedSecurity = true;
            scsb.Encrypt = false;
            strDBcon = scsb.ConnectionString;
            頁面清空();

        }

        void 頁面清空()
        {
            txt姓名.Clear();
            txt電話.Clear();
            txt地址.Clear();
            dateTimePicker生日.Value = DateTime.Now;
            txt信箱.Clear();
            txt密碼.Clear();
            txt密碼確認.Clear();
        }

        private void btn會員申請_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txt電話.Text != "") && (txt信箱.Text != "") && (txt密碼.Text != "") && (txt密碼確認.Text != ""))
                {
                    if (txt密碼.Text == txt密碼確認.Text)
                    {
                        SqlConnection con = new SqlConnection(strDBcon);
                        string strSQLcom = "insert into Customer(CustomerName,Phone,Address,Birthday,email) values (@Name, @Phone, @Address, @Birthday, @Email);";
                        string strSQLcom2 = "insert into CPassword values (@Phone,@Password);";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(strSQLcom, con);
                        SqlCommand cmd2 = new SqlCommand(strSQLcom2, con);
                        cmd.Parameters.AddWithValue("@Name", txt姓名.Text);
                        cmd.Parameters.AddWithValue("@Phone", txt電話.Text);
                        cmd.Parameters.AddWithValue("@Address", txt地址.Text);
                        cmd.Parameters.AddWithValue("@Birthday", dateTimePicker生日.Value);
                        cmd.Parameters.AddWithValue("@Email", txt信箱.Text);
                        cmd2.Parameters.AddWithValue("@Phone", txt電話.Text);
                        cmd2.Parameters.AddWithValue("@Password", txt密碼.Text);
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("會員申請成功!");
                        頁面清空();

                    }
                    else
                    {
                        MessageBox.Show("請輸入相同密碼");
                    }

            }
            else
            {
                    MessageBox.Show("*號欄位請勿空白");
            }
            
        }

        private void btn離開_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
