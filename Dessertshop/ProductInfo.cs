using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dessertshop
{
    public partial class ProductInfo : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBcon = "";
        public int loadID = 0;

        public ProductInfo()
        {
            InitializeComponent();
        }

        private void ProductInfo_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"Alice\MSSQLSERVER01";
            scsb.InitialCatalog = "Dessert Shop";
            scsb.IntegratedSecurity = true;
            scsb.Encrypt = false;
            strDBcon = scsb.ConnectionString;
            商品顯示();

        }

        void 商品顯示()
        {
            SqlConnection con = new SqlConnection(strDBcon);
            con.Open();
            string strSQLcmd = "select * from Product　where ID=@id;";
            SqlCommand cmd = new SqlCommand(strSQLcmd, con);
            cmd.Parameters.AddWithValue("@id", loadID);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read() == true)
            {
                lbl商品名稱.Text = (string)reader["ProductName"];
                lbl價格.Text = reader["Unitprice"].ToString();
                lbl規格.Text = (string)reader["Size"];
                string str圖片名稱 = (string)reader["Pimage"];
                string strImagepath = $@"E:\\全端\\個人專題\\商品圖片\\{str圖片名稱}";
                System.IO.FileStream filestream = System.IO.File.OpenRead(strImagepath);
                Image image = Image.FromStream(filestream);
                pictureBox商品照.Image = image;
                filestream.Close();
            }
            con.Close();
        }

        private void btn加入購物車_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show($"loadID:{ loadID}");
            if (txt數量.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBcon);
                con.Open();
                string strSQLcmd = "select * from Product　where ID=@id;";
                SqlCommand cmd = new SqlCommand(strSQLcmd, con);
                cmd.Parameters.AddWithValue("@id", loadID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    int productID = (int)reader["ID"];
                    int quantity = Convert.ToInt32(txt數量.Text);
                    if (GlobalVar.shoppinglist.Count > 0)
                    {
                        bool found = false;
                        foreach (KeyValuePair<int, int> item in GlobalVar.shoppinglist)
                        {
                            if (productID == item.Key)
                            {
                                GlobalVar.shoppinglist[item.Key] = quantity;
                                found = true;
                                break;
                            }
                        }
                        if (found ==false)
                        {
                            GlobalVar.shoppinglist.Add(productID, quantity);
                        }
                      
                    }
                    else
                    {
                        GlobalVar.shoppinglist.Add((int)reader["ID"], Convert.ToInt32(txt數量.Text));
                    }                     

                }

                //if (reader.Read() == true)
                //{
                //    GlobalVar.shoppinglist.Add((int)reader["ID"], Convert.ToInt32(txt數量.Text));
                //}
                con.Close();
                MessageBox.Show("成功加入購物車!");
                Close();
            }
            else
            {
                MessageBox.Show("訂購數量不可為空白");
            }

        }

        private void btn離開_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt數量_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
