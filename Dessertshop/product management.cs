using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Dessertshop
{
    public partial class product_management : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBcon = "";
        int productid = 0;
        string str圖片檔名修改 = "";
        bool is修改圖片 = false;
        List<int> listproductid = new List<int>();
        string str照片檔名 = "";


        List<string> list搜尋分類 = new List<string>();
        List<string> list產品類別 = new List<string>();


        public product_management()
        {
            InitializeComponent();
        }

        private void product_management_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"Alice\MSSQLSERVER01";
            scsb.InitialCatalog = "Dessert Shop";
            scsb.IntegratedSecurity = true;
            scsb.Encrypt = false;
            strDBcon = scsb.ConnectionString;
            讀取姓名及權限();

            list搜尋分類.Add("商品名稱");
            list搜尋分類.Add("商品單價");
            list搜尋分類.Add("商品類別");
            foreach (string i  in list搜尋分類)
            {
                comboBox搜尋類別.Items.Add(i);
            }
            

            list產品類別.Add("常溫點心");
            list產品類別.Add("冷藏點心");
            list產品類別.Add("季節點心");
            foreach(string i in list產品類別)
            {
                combobox商品類別.Items.Add(i);
            }

            清空內容();

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
                        btn選取照片.Enabled = true;
                        btn儲存修改.Enabled = true;
                        btn新增商品.Enabled = true ;
                        btn刪除商品.Enabled = true ;
                    }
                    else if(limits == 2)
                    {
                        btn選取照片.Enabled = false;
                        btn儲存修改.Enabled = false;
                        btn新增商品.Enabled = false;
                        btn刪除商品.Enabled = false;
                    }
                    reader.Close();
                }
                lbl使用者名稱.Text = $"{Name}，您好";

            }
            con.Close();

        }


        private void btn選取照片_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "檔案類型(JPEG, JPG, PNG) | *.jpeg; *.jpg; *.png";
            DialogResult R = fileDialog.ShowDialog();
            if(R == DialogResult.OK)
            {
                try
                {
                    System.IO.FileStream fs = System.IO.File.OpenRead(fileDialog.FileName);
                    pictureBox商品照片.Image = Image.FromStream(fs);
                    fs.Close();
                    pictureBox商品照片.Tag = fileDialog.FileName;
                    str照片檔名 = System.IO.Path.GetFileName(fileDialog.SafeFileName).ToLower();
                    str圖片檔名修改 = DateTime.Now.ToString("yyMMddHHmmss") + str照片檔名;
                    is修改圖片 = true;
                }
                catch
                {
                    MessageBox.Show("圖片選取失敗");
                }
            }
        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品單價.Text != "") && (txt商品成本.Text != "") && (txt商品規格.Text != ""))
            {
                try
                {
                    productid = (int)listView搜尋結果.SelectedItems[0].Tag;


                    SqlConnection con = new SqlConnection(strDBcon);
                    con.Open();
                    string strSQLcmd = "update Product set ProductName =@name ,Unitprice=@unitprice ,Cost=@cost ,Size=@size, Type=@type, Pimage=@pimage where ID =@id;";

                    SqlCommand cmd = new SqlCommand(strSQLcmd, con);
                    cmd.Parameters.AddWithValue("@name", txt商品名稱.Text);
                    cmd.Parameters.AddWithValue("@unitprice", Convert.ToInt32(txt商品單價.Text));
                    cmd.Parameters.AddWithValue("@cost", Convert.ToInt32(txt商品成本.Text));
                    cmd.Parameters.AddWithValue("@size", txt商品規格.Text);
                    int index = combobox商品類別.SelectedIndex + 1;
                    cmd.Parameters.AddWithValue("@type", index);

                    cmd.Parameters.AddWithValue("@pimage", str圖片檔名修改);

                    if (is修改圖片 == true)
                    {
                        string 完整修改圖檔 = $@"E:\\全端\\個人專題\\商品圖片\\{str圖片檔名修改}";
                        pictureBox商品照片.Image.Save(完整修改圖檔);
                        is修改圖片 = false;
                    }
                    cmd.Parameters.AddWithValue("@id", productid);
                    cmd.ExecuteNonQuery();
                    DialogResult Result = MessageBox.Show("是否儲存修改?", "儲存", MessageBoxButtons.YesNo);
                    if (Result == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("資料儲存成功");
                    }
                    con.Close();
                }
                catch 
                {
                    MessageBox.Show("請先選取欲修改資料");
                }

            }
            else
            {
                MessageBox.Show("空格欄位請輸入資料");
            }
            
        }

        private void btn刪除商品_Click(object sender, EventArgs e)
        {
            productid = (int)listView搜尋結果.SelectedItems[0].Tag;
            if (productid != 0)
            {
                if (txt商品名稱.Text != "")
                {
                    SqlConnection con = new SqlConnection(strDBcon);
                    con.Open();
                    string strSQLcmd = "delete from Product where ProductName = @name;";
                    SqlCommand cmd = new SqlCommand(strSQLcmd, con);
                    cmd.Parameters.AddWithValue("@name", txt商品名稱.Text);
                    DialogResult result = MessageBox.Show("是否確認刪除?", "刪除", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("資料已刪除");
                        清空內容();
                        清空欄位();
                    }
                }
                else
                {
                    MessageBox.Show("產品名稱錯誤");
                }
            }
            else
            {
                MessageBox.Show("請先搜尋產品");
            }
            
            
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
            清空內容();
        }


        void 清空欄位()
        {
            txt商品名稱.Clear();
            txt商品單價.Clear();
            txt商品成本.Clear();
            txt商品規格.Clear();
            txt搜尋.Clear();
            pictureBox商品照片.Image = null;
            combobox商品類別.SelectedItem = null;
            comboBox搜尋類別.SelectedItem = null;
        }

        void 清空內容()
        {
            listView搜尋結果.Items.Clear();
            listView搜尋結果.LargeImageList = null;
            listView搜尋結果.Columns.Clear();
            listView搜尋結果.SmallImageList = null;
            listView搜尋結果.View = View.Details;
            listView搜尋結果.Columns.Add("品項", 300);
            listView搜尋結果.GridLines = false;
            listView搜尋結果.FullRowSelect = true;
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            清空內容() ;
            if(txt搜尋.Text != "")
            {
                //價格和商品類別不能用模糊搜尋?
                if(comboBox搜尋類別.SelectedIndex >= 0)
                {
                    string str欄位名稱 = "";
                    switch (comboBox搜尋類別.SelectedItem.ToString())
                    {
                        case "商品名稱":
                            str欄位名稱 = "ProductName";
                            break;
                        case "商品單價":
                            str欄位名稱 = "Unitprice";
                            break;
                        case "商品類別":
                            str欄位名稱 = "Type";
                            break;
                    }
                    SqlConnection con = new SqlConnection(strDBcon);
                    con.Open();
                    string strSQLcmd = $"select* from Product where {str欄位名稱} like @name;";
                    SqlCommand cmd = new SqlCommand(strSQLcmd, con);
                    cmd.Parameters.AddWithValue("@name", $"%{txt搜尋.Text.Trim()}%");
                    SqlDataReader reader = cmd.ExecuteReader();
                    if(reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                            item.Text = (string)reader["ProductName"];
                            item.Tag = (int)reader["ID"];
                            listView搜尋結果.Items.Add(item);
                        }

                    }
                    else
                    {
                        MessageBox.Show("查無相關商品");
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

        private void btn離開_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView搜尋結果_ItemActivate(object sender, EventArgs e)
        {

                int productid = (int)listView搜尋結果.SelectedItems[0].Tag;
                SqlConnection con = new SqlConnection(strDBcon);
                con.Open();
                string strSQLcmd = "select* from Product where ID =@id";
                SqlCommand cmd = new SqlCommand(strSQLcmd, con);
                cmd.Parameters.AddWithValue("@id", productid);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    txt商品名稱.Text = (string)reader["ProductName"];
                    txt商品單價.Text = reader["Unitprice"].ToString();
                    txt商品成本.Text = reader["Cost"].ToString();
                    txt商品規格.Text = (string)reader["Size"];
                    int type = (int)reader["Type"];
                    if (type == 1)
                    {
                        combobox商品類別.SelectedIndex = 0;
                    }
                    else if (type == 2)
                    {
                        combobox商品類別.SelectedIndex = 1;
                    }
                    else if (type == 3)
                    {
                        combobox商品類別.SelectedIndex = 2;
                    }


                    string str圖片名稱 = (string)reader["Pimage"];
                    string strImagepath = $@"E:\\全端\\個人專題\\商品圖片\\{str圖片名稱}";
                    System.IO.FileStream filestream = System.IO.File.OpenRead(strImagepath);
                    Image image = Image.FromStream(filestream);
                    pictureBox商品照片.Image = image;
                    filestream.Close();
                }
                reader.Close();
                con.Close();


        }

        private void btn新增商品_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品單價.Text != "") && (txt商品成本.Text != "") && (txt商品規格.Text != "") && (combobox商品類別.SelectedIndex != 0))
            {
                SqlConnection con = new SqlConnection(strDBcon);
                con.Open();
                string strSQLcmd = "insert into Product values (@name, @unitprice,@cost,@size,@type,@pimage);";
                SqlCommand cmd = new SqlCommand(strSQLcmd, con);
                cmd.Parameters.AddWithValue("@name", txt商品名稱.Text);
                cmd.Parameters.AddWithValue("@unitprice", Convert.ToInt32(txt商品單價.Text));
                cmd.Parameters.AddWithValue("@cost", Convert.ToInt32(txt商品成本.Text));
                cmd.Parameters.AddWithValue("@size", txt商品規格.Text);
                int type = combobox商品類別.SelectedIndex + 1;
                cmd.Parameters.AddWithValue("@type", type);

                if (is修改圖片 == false)
                {
                    OpenFileDialog fileDialog = new OpenFileDialog();
                    fileDialog.Filter = "檔案類型(JPEG, JPG, PNG) | *.jpeg; *.jpg; *.png";
                    DialogResult R = fileDialog.ShowDialog();
                    if (R == DialogResult.OK)
                    {
                        System.IO.FileStream fs = System.IO.File.OpenRead(fileDialog.FileName);
                        pictureBox商品照片.Image = Image.FromStream(fs);
                        fs.Close();
                        pictureBox商品照片.Tag = fileDialog.FileName;
                        str照片檔名 = System.IO.Path.GetFileName(fileDialog.SafeFileName).ToLower();

                    }
                    else
                    {
                        MessageBox.Show("請選擇商品照片");
                    }

                }
                cmd.Parameters.AddWithValue("@pimage", str照片檔名);
                cmd.ExecuteNonQuery();
                MessageBox.Show("商品新增成功");
                con.Close();

            }
            else
            {
                MessageBox.Show("空白欄位請輸入資料");
            }
        }
    }
}
