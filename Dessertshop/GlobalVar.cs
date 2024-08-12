using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dessertshop
{
    public class GlobalVar
    {
        public static string str使用者名稱 = "";
        public static string strPhone = "";
        public static int limit = 0;
        public static int productid = 0;
        public static bool islogin = false;

        //key-商品ID、value-數量
        public static Dictionary<int, int> shoppinglist = new Dictionary<int, int>();
        //key-電話、value-姓名
        public static Dictionary<string, string> Customerinfo = new Dictionary<string, string>();


        //public static List<int> listShoppingcart = new List<int>();
    }
}
