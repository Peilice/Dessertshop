using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Dessertshop
{
    public partial class Order_management : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBcon = "";
        string productname = ""; //dic商品名稱用
        int productid = 0;  //dic商品名稱用
        string ordernumber = ""; //listview搜尋結果
        int orderitem = 0; //listview訂單細項
        List<string> list訂單狀態 = new List<string>();
        //key-ID、Value-商品名稱
        Dictionary<int, string> dic商品名稱 = new Dictionary<int, string>();
        List<string> listordernumber = new List<string>();
        List<int> listorderitem = new List<int>(); //顯示Listview訂單細項用
        string Name = "";
        int limits = 0;

        public Order_management()
        {
            InitializeComponent();
        }

        private void Order_management_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"Alice\MSSQLSERVER01";
            scsb.InitialCatalog = "Dessert Shop";
            scsb.IntegratedSecurity = true;
            scsb.Encrypt = false;
            strDBcon = scsb.ConnectionString;

            欄位清空();
            listView搜尋結果清空();
            listView訂單細項清空();

            list訂單狀態.Add("已成立");
            list訂單狀態.Add("已出貨");
            list訂單狀態.Add("已取消");
            foreach(string item in list訂單狀態)
            {
                comboBox搜尋訂單狀態.Items.Add(item);
                comboBox修改訂單狀態.Items.Add(item);
            }
            讀取姓名及權限();

            //SqlConnection con = new SqlConnection(strDBcon);
            //con.Open();
            //string strSQLcmd = "select*from Product";
            //SqlCommand cmd = new SqlCommand(strSQLcmd, con);
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    productname = (string)reader["ProductName"];
            //    productid = (int)reader["ID"];
            //    dic商品名稱.Add(productid, productname);
            //}
            //reader.Close();
            //con.Close();
            //foreach (KeyValuePair<int,string> item in dic商品名稱)
            //{
            //    Console.WriteLine($"key:{item.Key} value:{item.Value}");
            //    comboBox商品名稱.Items.Add(item.Value);
            //    Console.WriteLine($"value:{item.Value}");
            //}


        }


        void 讀取姓名及權限()
        {

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
                        btn整筆刪除.Enabled = true;
                    }
                    else if (limits == 2)
                    {
                        btn儲存修改.Enabled = false;
                        btn整筆刪除.Enabled = false;
                    }
                    else if (limits == 100)
                    {
                        btn儲存修改.Visible = false;
                        btn整筆刪除.Enabled = true;
                        comboBox修改訂單狀態.Enabled=false;
                    }
                    reader.Close();
                }
                lbl使用者名稱.Text = $"{Name}，您好";

            }
            con.Close();
        }

        void 欄位清空()
        {
            comboBox修改訂單狀態.Items.Clear();
            dateTimePicker訂購日期.Value = DateTime.Now;
            //comboBox商品名稱.Items.Clear();
            //txt數量.Clear();

        }

        void listView訂單細項清空()
        {
            listView訂單細項.Items.Clear();
            listView訂單細項.Columns.Clear();
            listView訂單細項.View = View.Details;
            listView訂單細項.Columns.Add("商品品項", 150);
            listView訂單細項.Columns.Add("數量", 100);
            listView訂單細項.GridLines = false;
            listView訂單細項.FullRowSelect = true;
        }

        void 顯示listView訂單細項()
        {
            for (int i = 0; i<listorderitem.Count; i++)
            {
                SqlConnection con = new SqlConnection(strDBcon);
                con.Open();
                string strSQLcmd = "select * from OrderDetail join Product on Order_Item = Product.ID join OrderList on OrderNumber = Order_number where Order_Item = @orderitem and OrderNumber =@ordernumber;";
                SqlCommand cmd = new SqlCommand(strSQLcmd, con);
                cmd.Parameters.AddWithValue("@ordernumber", ordernumber);
                cmd.Parameters.AddWithValue("@orderitem", listorderitem[i]);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                    item.Text = (string)reader["ProductName"];
                    item.SubItems.Add(Convert.ToString(reader["Quantity"]));
                    listView訂單細項.Items.Add(item);
                }
                reader.Close();
                con.Close();
            }
            

        }

        void listView搜尋結果清空()
        {
            listView搜尋結果.Items.Clear();
            listView搜尋結果.Columns.Clear();
            listView搜尋結果.View = View.Details;
            listView搜尋結果.Columns.Add("訂單編號", 250);
            listView搜尋結果.Columns.Add("訂單狀態", 150);
            listView搜尋結果.GridLines = false;
            listView搜尋結果.FullRowSelect = true;
        }


        private void btn搜尋_Click(object sender, EventArgs e)
        {
            if(comboBox搜尋訂單狀態.SelectedIndex != -1)
            {
                listView搜尋結果清空();
                SqlConnection con = new SqlConnection(strDBcon);
                con.Open();
                if(limits == 100)
                {
                    string strSQLcmd2 = "select* from OrderList join[Customer] on Phone = Customer_phone where CustomerName = @name and (OrderDate between @startime and @endtime) and Summary =@summary;";
                    SqlCommand cmd2 = new SqlCommand(strSQLcmd2, con);
                    cmd2.Parameters.AddWithValue("@name", Name);
                    cmd2.Parameters.AddWithValue("@startime", dateTimePicker開始時間.Value);
                    cmd2.Parameters.AddWithValue("@endtime", dateTimePicker結束時間.Value);
                    cmd2.Parameters.AddWithValue("@summary", comboBox搜尋訂單狀態.Text);
                    SqlDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                        item.Text = (string)reader2["OrderNumber"];
                        item.SubItems.Add((string)reader2["Summary"]);
                        item.Tag = (string)reader2["OrderNumber"];
                        string ordernumber = "";
                        ordernumber = (string)reader2["OrderNumber"];
                        listordernumber.Add(ordernumber);
                        listView搜尋結果.Items.Add(item);
                    }
                    reader2.Close();
                }
                else
                {
                    string strSQLcmd = "select * from OrderList where (OrderDate between @startime and @endtime) and Summary =@summary;";
                    SqlCommand cmd = new SqlCommand(strSQLcmd, con);
                    cmd.Parameters.AddWithValue("@startime", dateTimePicker開始時間.Value);
                    cmd.Parameters.AddWithValue("@endtime", dateTimePicker結束時間.Value);
                    cmd.Parameters.AddWithValue("@summary", comboBox搜尋訂單狀態.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                        item.Text = (string)reader["OrderNumber"];
                        item.SubItems.Add((string)reader["Summary"]);
                        item.Tag = (string)reader["OrderNumber"];
                        string ordernumber = "";
                        ordernumber = (string)reader["OrderNumber"];
                        listordernumber.Add(ordernumber);
                        listView搜尋結果.Items.Add(item);
                    }
                    reader.Close();
                }
                //string strSQLcmd = "select * from OrderList where (OrderDate between @startime and @endtime) and Summary =@summary;";
                //SqlCommand cmd = new SqlCommand(strSQLcmd, con);
                //cmd.Parameters.AddWithValue("@startime", dateTimePicker開始時間.Value);
                //cmd.Parameters.AddWithValue("@endtime", dateTimePicker結束時間.Value);
                //cmd.Parameters.AddWithValue("@summary", comboBox搜尋訂單狀態.Text);
                //SqlDataReader reader = cmd.ExecuteReader();
                //while (reader.Read())
                //{
                //    ListViewItem item = new ListViewItem();
                //    item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                //    item.Text = (string)reader["OrderNumber"];
                //    item.SubItems.Add((string)reader["Summary"]);
                //    item.Tag = (string)reader["OrderNumber"];
                //    string ordernumber = "";
                //    ordernumber= (string)reader["OrderNumber"];
                //    listordernumber.Add(ordernumber);
                //    listView搜尋結果.Items.Add(item);
                //}
                //reader.Close();
                con.Close();

            }
            else
            {
                MessageBox.Show("請選擇訂單狀態");
            }
        }

        private void btn整筆刪除_Click(object sender, EventArgs e)
        {
            //將訂單狀態改為"已取消"
            SqlConnection con = new SqlConnection(strDBcon);
            con.Open();
            string strSQLcmd = "update OrderList set Summary ='已刪除' where OrderNumber =@number ;";
            SqlCommand cmd = new SqlCommand(strSQLcmd, con);
            cmd.Parameters.AddWithValue("@number", ordernumber);
            DialogResult Result = MessageBox.Show("是否刪除訂單?", "刪除", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("訂單刪除成功");
            }
            comboBox修改訂單狀態.SelectedIndex = 2;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {
            //修改OrderList出貨狀態，已成立、已出貨、已取消
            //已成立
            ordernumber = (string)listView搜尋結果.SelectedItems[0].Tag;
            SqlConnection con = new SqlConnection(strDBcon);
            con.Open();
            string cmobox訂單狀態 = "";
            string strSQLcmd = "update OrderList set ShipDate=@shipdate, Summary =@Summy where OrderNumber =@number ;";
            cmobox訂單狀態 = comboBox修改訂單狀態.SelectedItem.ToString();
            SqlCommand cmd = new SqlCommand(strSQLcmd, con);
            cmd.Parameters.AddWithValue("@number", ordernumber);

            if (cmobox訂單狀態 == "已出貨")
            {
              DateTime time = DateTime.Now.Date;
              cmd.Parameters.AddWithValue("@shipdate", time);
              cmd.Parameters.AddWithValue("@Summy", "已出貨");
            }
            else
            {
                cmd.Parameters.AddWithValue("@shipdate", 1800-01-01);
                cmd.Parameters.AddWithValue("@Summy", cmobox訂單狀態);
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("訂單狀態修改成功");
        }

        private void btn離開_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView搜尋結果_ItemActivate(object sender, EventArgs e)
        {
            listView訂單細項清空();
            ordernumber = (string)listView搜尋結果.SelectedItems[0].Tag;
            SqlConnection con = new SqlConnection(strDBcon);
            con.Open();
            //select* from OrderDetail join Product on Order_Item = [dbo].[Product].ID;
            string strSQLcmd = "select * from OrderDetail join Product on Order_Item = Product.ID join OrderList on OrderNumber = Order_number where Order_Number = @ordernumber;";
            SqlCommand cmd = new SqlCommand(strSQLcmd, con);
            cmd.Parameters.AddWithValue("@ordernumber", ordernumber);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                item.Text = (string)reader["ProductName"];
                item.SubItems.Add(Convert.ToString(reader["Quantity"]));
                item.Tag = (int)reader["Order_Item"];
                string summary = (string)reader["Summary"];
                switch (summary)
                {
                    case "已成立":
                        comboBox修改訂單狀態.SelectedIndex = 0;
                        break;
                    case "已出貨":
                        comboBox修改訂單狀態.SelectedIndex = 1;
                        break;
                    case "已刪除":
                        comboBox修改訂單狀態.SelectedIndex = 2;
                        break;
                }
                dateTimePicker訂購日期.Value = (DateTime)reader["OrderDate"];
                listView訂單細項.Items.Add(item);
                int itenid = (int)reader["Order_Item"];
                listorderitem.Add(itenid);

            }
            reader.Close();
            con.Close();
            if(listView搜尋結果.SelectedItems.Count ==0)
            {
                MessageBox.Show("查無訂單");

            }
        }

        private void btn刪除單項_Click(object sender, EventArgs e)
        {
            ////刪除Orderdetail
            //ordernumber = (string)listView搜尋結果.SelectedItems[0].Tag;
            //orderitem = (int)listView訂單細項.SelectedItems[0].Tag;
            //SqlConnection con = new SqlConnection(strDBcon);
            //con.Open();
            //string strSQLcmd = "delete from OrderDetail where Order_Item =@item and Order_number = @number;";
            //SqlCommand cmd = new SqlCommand(strSQLcmd, con);
            //cmd.Parameters.AddWithValue("@item", orderitem);
            //cmd.Parameters.AddWithValue("@number", ordernumber);
            //cmd.ExecuteNonQuery();
            //con.Close();
            //MessageBox.Show("品項刪除成功");
            ////txt數量.Clear();
            ////comboBox商品名稱.SelectedItem = null;
            //listView訂單細項清空();
            //顯示listView訂單細項();

        }

        private void listView訂單細項_ItemActivate(object sender, EventArgs e)
        {

            //orderitem = (int)listView訂單細項.SelectedItems[0].Tag;
            //SqlConnection con = new SqlConnection(strDBcon);
            //con.Open();
            //string strSQLcmd = "select * from OrderDetail join Product on Order_Item = Product.ID join OrderList on OrderNumber = Order_number where Order_Item = @orderitem and OrderNumber =@ordernumber;";
            //SqlCommand cmd = new SqlCommand(strSQLcmd, con);
            //cmd.Parameters.AddWithValue("@ordernumber", ordernumber);
            //cmd.Parameters.AddWithValue("@orderitem", orderitem);

            //SqlDataReader reader = cmd.ExecuteReader();


            //while (reader.Read())
            //{
            //    lbl數量.Text = Convert.ToString(reader["Quantity"]);
            //    comboBox商品名稱.SelectedItem = (string)reader["ProductName"];

            //}
            //reader.Close();
            //con.Close();
        }
    }
}
