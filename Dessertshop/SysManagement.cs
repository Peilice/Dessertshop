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
    public partial class SysManagement : Form
    {
        public SysManagement()
        {
            InitializeComponent();
        }



        private void SysManagement_Load(object sender, EventArgs e)
        {

        }


        private void btn離開_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn會員管理_Click(object sender, EventArgs e)
        {

        }

        private void btn商品管理_Click(object sender, EventArgs e)
        {
            product_management myproduct = new product_management();
            myproduct.ShowDialog();
            Close();
        }

        private void btn訂單管理_Click(object sender, EventArgs e)
        {
            Order_management myordermanagement = new Order_management();
            myordermanagement.ShowDialog();
            Close();
        }

        private void btn人員管理_Click(object sender, EventArgs e)
        {
            Staff_management mystaffmanage = new Staff_management();
            mystaffmanage.ShowDialog();
            Close();
        }
    }
}
