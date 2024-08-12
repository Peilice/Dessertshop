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
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBconing = "";
        List<string> listProductname = new List<string>();
        List<int> listProductprice = new List<int>();
        List<int> listProductid = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //登出功能
            
            scsb.DataSource = @"Alice\MSSQLSERVER01";
            scsb.InitialCatalog = "Dessert Shop";
            scsb.IntegratedSecurity = true;
            scsb.Encrypt = false;
            strDBconing=scsb.ConnectionString;
            //GlobalVar.islogin = false;

            常溫點心();
            listView常溫點心顯示();
            冷藏點心();
            listview冷藏點心顯示();
            季節點心();
            listview季節點心顯示();


            //需要讀取會員的姓名
            讀取姓名及權限();



        }

        void 讀取姓名及權限()
        {
            string Name = "";
            int limits = 0;
            SqlConnection con = new SqlConnection(strDBconing);
            con.Open();
            for(int i =0; i< GlobalVar.Customerinfo.Count; i++)
            {
                string strSQLcmd = "select* from Customer where Phone = @phone;";
                SqlCommand cmd = new SqlCommand(strSQLcmd, con);
                cmd.Parameters.Add("@phone", GlobalVar.Customerinfo.ElementAt(i).Key);
                SqlDataReader reader = cmd.ExecuteReader();
                Name = GlobalVar.Customerinfo.ElementAt(i).Value;
                if (reader.Read())
                {
                    limits = (int)reader["Limits"];
                    if (limits == 100)
                    {
                        btn系統管理.Visible = false;
                        btn歷史訂單.Visible = true;
                    }
                    else
                    {
                        btn系統管理.Visible = true;
                        btn歷史訂單.Visible = true;
                    }
                    reader.Close();
                }
                lbl使用者名稱.Text = $"{Name}，您好";
                
            }
            con.Close();

        }


        void 常溫點心()
        {
            SqlConnection con = new SqlConnection(strDBconing);
            con.Open();
            string strSQLcom = "select* from Product where Type = 1";  
            //1=常溫、2=冷藏、3=季節
            SqlCommand com = new SqlCommand(strSQLcom, con);
            SqlDataReader reader = com.ExecuteReader();
            listProductid.Clear();
            listProductname.Clear();
            listProductprice.Clear();

            while (reader.Read())
            {
                listProductid.Add((int)reader["ID"]);
                listProductname.Add((string)reader["ProductName"]);
                listProductprice.Add((int)reader["Unitprice"]);
                string image_name = (string)reader["Pimage"];
                string image_path = $@"E:\\全端\\個人專題\\商品圖片\\{image_name}";
                System.IO.FileStream fileStream = System.IO.File.OpenRead(image_path);
                Image image = Image.FromStream(fileStream);
                fileStream.Close();
                imageList常溫點心.Images.Add(image);

            }

            reader.Close();
            con.Close();
        }

        void listView常溫點心顯示()
        {
            listView常溫點心.Clear();
            listView常溫點心.View = View.LargeIcon;
            imageList常溫點心.ImageSize = new Size(180, 180);
            listView常溫點心.LargeImageList = imageList常溫點心;
            listView常溫點心.SmallImageList = imageList常溫點心;

            for (int i = 0; i < listProductid.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = $"{listProductname[i]} {listProductprice[i]}元";
                item.Tag = listProductid[i];
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                listView常溫點心.Items.Add(item);
            }

        }

        void 冷藏點心()
        {
            SqlConnection con = new SqlConnection(strDBconing);
            con.Open();
            string strSQLcom = "select* from Product where Type = 2";
            SqlCommand com = new SqlCommand(strSQLcom, con);
            SqlDataReader reader = com.ExecuteReader();
            listProductid.Clear();
            listProductname.Clear();
            listProductprice.Clear();

            while (reader.Read())
            {
                listProductid.Add((int)reader["ID"]);
                listProductname.Add((string)reader["ProductName"]);
                listProductprice.Add((int)reader["Unitprice"]);
                string image_name = ((string)reader["Pimage"]);
                string image_path = $@"E:\\全端\\個人專題\\商品圖片\\{image_name}";
                System.IO.FileStream filestream = System.IO.File.OpenRead(image_path);
                Image image = Image.FromStream(filestream);
                filestream.Close();
                imageList冷藏點心.Images.Add(image);
            }
            reader.Close();
            con.Close();
        }

        void listview冷藏點心顯示()
        {
            listView冷藏點心.Clear();
            listView冷藏點心.View= View.LargeIcon;
            imageList冷藏點心.ImageSize = new Size(180, 180);
            listView冷藏點心.LargeImageList = imageList冷藏點心 ;
            listView冷藏點心.SmallImageList = imageList冷藏點心 ;

            for(int i = 0; i < listProductid.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = $"{listProductname[i]} {listProductprice[i]}元";
                item.Tag = listProductid[i];
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                listView冷藏點心.Items.Add(item);
            }
        }

        void 季節點心()
        {
            SqlConnection con = new SqlConnection(strDBconing);
            con.Open();
            string strSQLcom = "select* from Product where Type = 3";
            SqlCommand cmd = new SqlCommand(strSQLcom, con);
            SqlDataReader reader = cmd.ExecuteReader();
            listProductid.Clear();
            listProductname.Clear();
            listProductprice.Clear();

            while (reader.Read())
            {
                listProductid.Add((int)reader["ID"]);
                listProductname.Add((string)reader["ProductName"]);
                listProductprice.Add((int)reader["Unitprice"]);
                string image_name = (string)reader["Pimage"];
                string image_path = $@"E:\\全端\\個人專題\\商品圖片\\{image_name}";
                System.IO.FileStream filestream = System.IO.File.OpenRead(image_path);
                Image image = Image.FromStream(filestream);
                filestream.Close();
                imageList季節點心.Images.Add(image);
            }
            reader.Close ();
            con.Close();

        }

        void listview季節點心顯示()
        {
            listView季節點心.Clear ();
            listView季節點心.View = View.LargeIcon;
            imageList季節點心.ImageSize = new Size(180, 180);
            listView季節點心.LargeImageList = imageList季節點心;
            listView季節點心.SmallImageList = imageList季節點心;

            for (int i = 0; i < listProductid.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = $"{listProductname[i]} {listProductprice[i]}元";
                item.Tag = listProductid[i];
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                listView季節點心.Items.Add(item);
            }
        }
        

        private void btn登入_Click(object sender, EventArgs e)
        {
            Login mylogin = new Login();
            if (GlobalVar.Customerinfo.Count > 0)
            {
                GlobalVar.Customerinfo.Clear();
                GlobalVar.shoppinglist.Clear();
                btn登入.Text = "登入";
                MessageBox.Show("登出成功");
                lbl使用者名稱.Text = "歡迎使用";
                btn系統管理.Visible = false;
            }
            else
            {
                mylogin.ShowDialog();
                btn登入.Text = "登出";
            }
            
        }

        private void btn購物車_Click(object sender, EventArgs e)
        {
            Shoppingcart myshocart = new Shoppingcart();
            myshocart.ShowDialog();
        }

        private void btn個人資料_Click(object sender, EventArgs e)
        {
            MemberInfo mymeminfo = new MemberInfo();
            mymeminfo.ShowDialog();
        }

        private void btn系統管理_Click(object sender, EventArgs e)
        {
            SysManagement mysysinfo = new SysManagement();
            mysysinfo.ShowDialog();
        }

        private void btn加入會員_Click(object sender, EventArgs e)
        {
            NewMember mynewmem = new NewMember();
            mynewmem.ShowDialog();
        }

        private void listView常溫點心_ItemActivate(object sender, EventArgs e)
        {
            ProductInfo productinfo = new ProductInfo();
            productinfo.loadID = (int)listView常溫點心.SelectedItems[0].Tag;
            productinfo.ShowDialog();

        }

        private void listView冷藏點心_ItemActivate(object sender, EventArgs e)
        {
            ProductInfo productinfo = new ProductInfo();
            productinfo.loadID = (int)listView冷藏點心.SelectedItems[0].Tag;
            productinfo.ShowDialog();
        }

        private void listView季節點心_ItemActivate(object sender, EventArgs e)
        {
            ProductInfo productinfo = new ProductInfo();
            productinfo.loadID = (int)listView季節點心.SelectedItems[0].Tag;
            productinfo.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            常溫點心();
            listView常溫點心顯示();
            冷藏點心();
            listview冷藏點心顯示();
            季節點心();
            listview季節點心顯示();
            讀取姓名及權限();
        }

        private void btn歷史訂單_Click(object sender, EventArgs e)
        {
            Order_management myorder = new Order_management();
            myorder.ShowDialog();
        }
    }
}
