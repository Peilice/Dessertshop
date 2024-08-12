using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dessertshop
{
    public partial class Shoppingcart : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBcon = "";
        List<int> list總額 = new List<int>();


        public Shoppingcart()
        {
            InitializeComponent();
        }

        private void Shoppingcart_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"Alice\MSSQLSERVER01";
            scsb.InitialCatalog = "Dessert Shop";
            scsb.IntegratedSecurity = true;
            scsb.Encrypt = false;
            strDBcon = scsb.ConnectionString;
            清空內容();
            顯示購物車內容();
            計算總額();
            讀取姓名();
        }

        void 讀取姓名()
        {
            string Name = "";
            SqlConnection con = new SqlConnection(strDBcon);
            con.Open();
            for (int i = 0; i < GlobalVar.Customerinfo.Count; i++)
            {
                string strSQLcmd = "select* from Customer where Phone = @phone;";
                SqlCommand cmd = new SqlCommand(strSQLcmd, con);
                cmd.Parameters.Add("@phone", GlobalVar.Customerinfo.ElementAt(i).Key);
                Name = GlobalVar.Customerinfo.ElementAt(i).Value;
                lbl使用者名稱.Text = $"{Name}，您好";

            }
            con.Close();

        }

        void 計算總額()
        {
            int int單價 = 0;
            int int數量 = 0;
            int int單品總價 = 0;
            int int整筆總額 = 0;
            list總額.Clear();
            SqlConnection con = new SqlConnection(strDBcon);
            con.Open();
            foreach (KeyValuePair<int, int> i in GlobalVar.shoppinglist)
            {
                 string strSQLcmd = $"select * from Product　where ID={i.Key};";
                 SqlCommand cmd = new SqlCommand(strSQLcmd, con);
                 SqlDataReader reader = cmd.ExecuteReader();
                 while (reader.Read())
                 {
                   int單價 = (int)reader["Unitprice"];
                   int數量 = i.Value;
                    
                 }
                int單品總價 = int單價 * int數量;
                list總額.Add(int單品總價);
                reader.Close();
            }

            int整筆總額 = list總額.Sum();
            lbl總金額.Text = $"{Convert.ToString(int整筆總額)}元";
            con.Close();

        }

        void 清空內容()
        {
            listView購物清單.Items.Clear();
            listView購物清單.LargeImageList = null;
            listView購物清單.Columns.Clear();
            listView購物清單.SmallImageList = null;
            listView購物清單.View = View.Details;
            listView購物清單.Columns.Add("品項", 300);
            listView購物清單.Columns.Add("單價", 120);
            listView購物清單.Columns.Add("數量", 120);
            listView購物清單.GridLines = false;
            listView購物清單.FullRowSelect = true;

        }


        void 顯示購物車內容()
        {
            for (int i = 0; i < GlobalVar.shoppinglist.Count; i++)
            {
                SqlConnection con = new SqlConnection(strDBcon);
                con.Open();
                string strSQLcmd = "select * from Product　where ID=@id;";
                SqlCommand cmd = new SqlCommand(strSQLcmd, con);
                cmd.Parameters.AddWithValue("@id", GlobalVar.shoppinglist.ElementAt(i).Key);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read() == true)
                {
                    ListViewItem item = new ListViewItem();
                    item.Font = new Font("微軟正黑體", 16, FontStyle.Bold);
                    item.Text = (string)reader["ProductName"];
                    item.SubItems.Add(reader["Unitprice"].ToString());
                    item.SubItems.Add(Convert.ToString(GlobalVar.shoppinglist.ElementAt(i).Value));
                    item.Tag = (int)reader["ID"];
                    listView購物清單.Items.Add(item);
                }
                con.Close();
            }

        }

        private void btn取消單項_Click(object sender, EventArgs e)
        {

            int count = listView購物清單.Items.Count;
            if(count > 0)
            {
                int selectedid = (int)listView購物清單.SelectedItems[0].Tag;
                GlobalVar.shoppinglist.Remove(selectedid);
                listView購物清單.SelectedItems.Clear();
                清空內容();
                顯示購物車內容();
                計算總額();

            }
            else
            {
                MessageBox.Show("購物車無商品");
            }

        }

        private void btn取消整筆_Click(object sender, EventArgs e)
        {
            int count = listView購物清單.Items.Count;
            if (count > 0)
            {
                GlobalVar.shoppinglist.Clear();
                
                清空內容();
                顯示購物車內容();
                計算總額();
            }
            else
            {
                MessageBox.Show("購物車無商品");
            }

        }

        private void btn確認訂購_Click(object sender, EventArgs e)
        {
            //加入到DB中，同時輸出訂單內容
            //輸入資料庫
            int count = GlobalVar.shoppinglist.Count;
            if (count > 0)
            {
                SqlConnection con = new SqlConnection(strDBcon);
                con.Open();
                string strSQLcom = "insert into OrderList(OrderNumber, Customer_phone) values(@ordernumber, @phone);";
                SqlCommand cmd = new SqlCommand(strSQLcom, con);
                Random myRnd = new Random();
                int numRnd = myRnd.Next(1, 1000);
                string ordernumber = DateTime.Now.ToString("yyMMddHHmmss") + numRnd;
                cmd.Parameters.AddWithValue("@ordernumber", ordernumber);
                if (GlobalVar.Customerinfo.Count > 0)
                {
                    for (int a = 0; a < GlobalVar.Customerinfo.Count; a++)
                    {
                        cmd.Parameters.AddWithValue("@phone", GlobalVar.Customerinfo.ElementAt(a).Key);
                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@phone", "0900");
                }
                cmd.ExecuteNonQuery();
                
                               
                for (int i = 0; i < GlobalVar.shoppinglist.Count; i++)
                {
                    string strSQLcom3 = "insert into OrderDetail(Order_number,Order_Item,Quantity) values (@ordernumber, @productid1, @number);";
                    SqlCommand cmd3 = new SqlCommand(strSQLcom3, con);
                    cmd3.Parameters.AddWithValue("@ordernumber", ordernumber);
                    cmd3.Parameters.AddWithValue("@productid1", GlobalVar.shoppinglist.ElementAt(i).Key);
                    cmd3.Parameters.AddWithValue("@number", GlobalVar.shoppinglist.ElementAt(i).Value);
                    cmd3.ExecuteNonQuery();
                }
                
                con.Close();


                //輸出訂單
                string str輸出檔案儲存路徑 = @"C:\Users\feath\Desktop\蛋糕訂單";
                string str訂單號碼檔名 = DateTime.Now.ToString("yymmddHHmmss") + "訂單號碼.txt";
                string str完整路徑檔名 = str輸出檔案儲存路徑 + @"\" + str訂單號碼檔名;
                SaveFileDialog 存檔 = new SaveFileDialog();
                存檔.InitialDirectory = str輸出檔案儲存路徑;
                存檔.FileName = str訂單號碼檔名;
                存檔.Filter = " 文字檔案類型 |*.txt";
                DialogResult 確認 = 存檔.ShowDialog();

                if (確認 == DialogResult.OK)
                {
                    str完整路徑檔名 = 存檔.FileName;
                }
                else
                {
                    return;
                }
                List<string> 訂單內容 = new List<string>();
                訂單內容.Add("=====Dessert Shop 訂單內容=====");
                訂單內容.Add(" ");
                訂單內容.Add($"下單時間：{DateTime.Now}");
                訂單內容.Add(" ");
                訂單內容.Add(" ");
                訂單內容.Add("------- 訂購品項 -------");

                for (int i = 0; i < GlobalVar.shoppinglist.Count; i++)
                {
                    SqlConnection con2 = new SqlConnection(strDBcon);
                    con2.Open();
                    string strSQLcmd2 = "select * from Product where ID=@productid";
                    SqlCommand cmd2 = new SqlCommand(strSQLcmd2, con2);
                    cmd2.Parameters.AddWithValue("@productid", GlobalVar.shoppinglist.ElementAt(i).Key);
                    SqlDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read() == true)
                    {
                        string 訂購品項 = $"品項：{(string)reader2["ProductName"]}";
                        string 訂購數量 = $"數量：{GlobalVar.shoppinglist.ElementAt(i).Value}";
                        訂單內容.Add($"{訂購品項} 、 {訂購數量}");
                    }
                    reader2.Close();
                }
                訂單內容.Add("");
                訂單內容.Add("-----------------------");
                訂單內容.Add("感謝您的訂購，歡迎再次光臨!");
                System.IO.File.WriteAllLines(str完整路徑檔名, 訂單內容, Encoding.UTF8);

                MessageBox.Show("訂購成功");
                GlobalVar.shoppinglist.Clear();
            }
            else
            {
                MessageBox.Show("購物車無商品");
            }

        }





        private void btn離開_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
