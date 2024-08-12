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
    public partial class Staff_management : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBcon = "";
        int staffid = 0;

        List<string> list權限 = new List<string>();
        List<string> list搜尋 = new List<string>();

        public Staff_management()
        {
            InitializeComponent();
        }

        private void Staff_management_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"Alice\MSSQLSERVER01";
            scsb.InitialCatalog= "Dessert Shop";
            scsb.IntegratedSecurity = true;
            scsb.Encrypt = false;
            strDBcon = scsb.ConnectionString;

            list搜尋.Add("姓名");
            list搜尋.Add("電話");
            foreach(string item in list搜尋)
            {
                comboBox搜尋類別.Items.Add(item);
            }

            list權限.Add("管理職");
            list權限.Add("員工");
            foreach(string item in list權限)
            {
                combobox權限.Items.Add(item);
            }

            清空欄位();
            清空listview內容();
            讀取姓名及權限();



        }

        void 讀取姓名及權限()
        {
            string Name = "";
            int limits = 0;
            SqlConnection con = new SqlConnection(strDBcon);
            con.Open();
            for (int i = 0; i < GlobalVar.Customerinfo.Count; i++)
            {
                string strSQLcmd = "select* from Customer where Phone = @phone;";
                SqlCommand cmd = new SqlCommand(strSQLcmd, con);
                cmd.Parameters.Add("@phone", GlobalVar.Customerinfo.ElementAt(i).Key);
                SqlDataReader reader = cmd.ExecuteReader();
                Name = GlobalVar.Customerinfo.ElementAt(i).Value;
                if (reader.Read())
                {
                    limits = (int)reader["Limits"];
                    if (limits == 1)
                    {
                        btn儲存修改.Enabled = true;
                        btn新增員工.Enabled = true;
                    }
                    else if(limits == 2)
                    {
                        btn儲存修改.Enabled = false;
                        btn新增員工.Enabled = false;
                    }
                    reader.Close();
                }
                lbl使用者名稱.Text = $"{Name}，您好";

            }
            con.Close();
        }


        void 清空欄位()
        {
            txtEmail.Clear();
            txt地址.Clear();
            txt姓名.Clear();
            txt搜尋.Clear();
            txt職稱.Clear();
            txt薪資.Clear();
            txt電話.Clear();
            dateTimePicker入職.Value = DateTime.Now;
            dateTimePicker生日.Value = DateTime.Now;
            combobox權限.SelectedItem = null;
            comboBox搜尋類別.SelectedItem = null;
            radio在職.Checked = false;
            radio離職.Checked = false;
        }

        void 清空listview內容()
        {
            listView搜尋結果.Items.Clear();
            listView搜尋結果.LargeImageList = null;
            listView搜尋結果.Columns.Clear();
            listView搜尋結果.SmallImageList = null;
            listView搜尋結果.View = View.Details;
            listView搜尋結果.Columns.Add("姓名", 250);
            listView搜尋結果.Columns.Add("職稱", 250);
            listView搜尋結果.GridLines = false;
            listView搜尋結果.FullRowSelect = true;
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            清空listview內容();
            if (txt搜尋.Text != "")
            {
                if(comboBox搜尋類別.SelectedIndex != -1)
                {
                    string str搜尋欄位 = "";
                    switch (comboBox搜尋類別.SelectedItem.ToString())
                    {
                        case "姓名":
                            str搜尋欄位 = "EmployeeName";
                            break;
                        case "電話":
                            str搜尋欄位 = "Phone";
                            break;
                    }
                    SqlConnection con = new SqlConnection(strDBcon);
                    con.Open();
                    string strSQLcmd = $"select* from Employee where {str搜尋欄位} like @name;";
                    SqlCommand cmd = new SqlCommand(strSQLcmd, con);
                    cmd.Parameters.AddWithValue("@name", $"%{txt搜尋.Text.Trim()}%");
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                            item.Text = (string)reader["EmployeeName"];
                            item.SubItems.Add((string)reader["JobTitle"]);
                            item.Tag = (int)reader["ID"];
                            listView搜尋結果.Items.Add(item);
                        }

                    }
                    else
                    {
                        MessageBox.Show("查無此人");
                    }
                    reader.Close();
                    con.Close();

                }
                else
                {
                    MessageBox.Show("請選擇搜尋類別");
                }
            }
            else
            {
                MessageBox.Show("請輸入搜尋關鍵字");
            }
        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txt電話.Text != "") && (txt地址.Text != "") && (txtEmail.Text != "") && (txt職稱.Text != "") && (txt薪資.Text != ""))
            {
                staffid = (int)listView搜尋結果.SelectedItems[0].Tag;
                SqlConnection con = new SqlConnection(strDBcon);
                con.Open();
                string strSQLcmd = "update Employee set EmployeeName = @name, Phone=@phone, EmployeeAddress = @address, Birthday=@birthday, email=@email, JobTitle=@jobtitle, Limits=@Limits, Salary=@Salary where ID=@id;";
                SqlCommand cmd = new SqlCommand(strSQLcmd, con);
                cmd.Parameters.AddWithValue("@name", txt姓名.Text);
                cmd.Parameters.AddWithValue("@phone", txt電話.Text);
                cmd.Parameters.AddWithValue("@address", txt地址.Text);
                cmd.Parameters.AddWithValue("@birthday", dateTimePicker生日.Value);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@jobtitle", txt職稱.Text);
                int limits = combobox權限.SelectedIndex + 1;
                cmd.Parameters.AddWithValue("@Limits", limits);
                cmd.Parameters.AddWithValue("@Salary", txt薪資.Text);
                cmd.Parameters.AddWithValue("@id", staffid);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料修改成功");

            }
            else
            {
                MessageBox.Show("*號欄位請勿空白");
            }
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
            清空listview內容();
        }

        private void btn新增員工_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txt電話.Text != "") && (txt地址.Text != "") && (txtEmail.Text != "") && (txt職稱.Text != "") && (txt薪資.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBcon);
                con.Open();
                string strSQLcmd = "insert into Employee values (@name, @phone, @address, @birthday, @email, @hiredate, @quitdate, @jobtitle, @Limits, @Salary); insert into Customer(CustomerName, Phone,Address,Birthday,Email,Limits) values (@name, @phone, @address,@birthday,@email, @Limits); insert into CPassword values (@phone, @password);";
                SqlCommand cmd = new SqlCommand(strSQLcmd, con);
                cmd.Parameters.AddWithValue("@name", txt姓名.Text); 
                cmd.Parameters.AddWithValue("@phone",txt電話.Text);
                cmd.Parameters.AddWithValue("@address",txt地址.Text);
                cmd.Parameters.AddWithValue("@birthday",dateTimePicker生日.Value);
                cmd.Parameters.AddWithValue("@email",txtEmail.Text);
                cmd.Parameters.AddWithValue("@hiredate",dateTimePicker入職.Value);
                cmd.Parameters.AddWithValue("@quitdate","1800-01-01");
                cmd.Parameters.AddWithValue("@jobtitle",txt職稱.Text);
                int limits = combobox權限.SelectedIndex + 1;
                cmd.Parameters.AddWithValue("@Limits",limits);
                cmd.Parameters.AddWithValue("@Salary",txt薪資.Text);
                cmd.Parameters.AddWithValue("@password", txt電話.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("員工新增成功");
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

        private void listView搜尋結果_ItemActivate(object sender, EventArgs e)
        {
            staffid = (int)listView搜尋結果.SelectedItems[0].Tag;

                SqlConnection con = new SqlConnection(strDBcon);
                con.Open();
                string strSQLcmd = "select* from Employee where ID = @id;";
                SqlCommand cmd = new SqlCommand(strSQLcmd, con);
                cmd.Parameters.AddWithValue("@id", staffid);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txt姓名.Text = (string)reader["EmployeeName"];
                    txt電話.Text = (string)reader["Phone"];
                    txt地址.Text = (string)reader["EmployeeAddress"];
                    txtEmail.Text = (string)reader["email"];
                    dateTimePicker生日.Value = (DateTime)reader["Birthday"];
                    dateTimePicker入職.Value = (DateTime)reader["HireDate"];
                    txt職稱.Text = (string)reader["JobTitle"];
                    txt薪資.Text = reader["Salary"].ToString();
                    string strdate = string.Format("{0:yyyyMMdd}", reader["QuitDate"]);
                    if (strdate == "18000101")
                    {
                        radio在職.Checked = true;
                        radio離職.Checked = false;
                    
                    }
                    else
                    {
                        radio在職.Checked = false;
                        radio離職.Checked = true;
                    }
                    int int權限 = (int)reader["Limits"] - 1;
                    combobox權限.SelectedIndex = int權限;
                }
                reader.Close();
                con.Close();

        }
    }
}
