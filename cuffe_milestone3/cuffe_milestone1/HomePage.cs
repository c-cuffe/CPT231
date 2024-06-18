using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuffe_milestone1
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnInsertUsers_Click(object sender, EventArgs e)
        {
            InsertUsers insertU = new InsertUsers();
            insertU.Show();
        }

        private void btnSearchUsers_Click(object sender, EventArgs e)
        {
            SearchUsers searchU = new SearchUsers();
            searchU.Show();
        }


        private void btnInsertInventory_Click(object sender, EventArgs e)
        {
            InsertProducts insertP = new InsertProducts();
            insertP.Show();
        }

        private void btnSearchInventory_Click(object sender, EventArgs e)
        {
            SearchProducts searchP = new SearchProducts();
            searchP.Show();
        }

        private void btnInventoryReports_Click(object sender, EventArgs e)
        {
            InventoryReports inventoryR = new InventoryReports();
            inventoryR.Show();
        }

        private void btnInsertOrders_Click(object sender, EventArgs e)
        {
            InsertOrders insertO = new InsertOrders();
            insertO.Show();
        }

        private void btnSearchOrders_Click(object sender, EventArgs e)
        {
            SearchOrders searchO = new SearchOrders();
            searchO.Show();
        }

        private void btnUpdateOrders_Click(object sender, EventArgs e)
        {
            UpdateOrders updateO = new UpdateOrders();
            updateO.Show();
        }

        private void btnOrdersReports_Click(object sender, EventArgs e)
        {
            OrderReports orderR = new OrderReports();
            orderR.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InsertOrderDetails insertOrderDetails = new InsertOrderDetails();
            insertOrderDetails.Show();
        }

        private void btnSearchOrderDetails_Click(object sender, EventArgs e)
        {
            SearchOrderDetails searchOrderDetails = new SearchOrderDetails();
            searchOrderDetails.Show();
        }

        private void btnUpdateOrderDetails_Click(object sender, EventArgs e)
        {
            UpdateOrderDetails updateOrderDetails = new UpdateOrderDetails();
            updateOrderDetails.Show();
        }
    }
}
