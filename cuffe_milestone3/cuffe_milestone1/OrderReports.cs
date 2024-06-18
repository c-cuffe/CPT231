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
    public partial class OrderReports : Form
    {
        public OrderReports()
        {
            InitializeComponent();
        }

        private void orderDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.golfCourseDataSet1);

        }

        private void OrderReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'golfCourseDataSet1.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.golfCourseDataSet1.Orders);
            // TODO: This line of code loads data into the 'golfCourseDataSet1.OrderDetails' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter.Fill(this.golfCourseDataSet1.OrderDetails);

        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int searchOrderId = int.Parse(txtOrder.Text);
                string itemsCount = (this.orderDetailsTableAdapter.ItemsReport(searchOrderId)).ToString();
                lblItems.Text = itemsCount;

                double total = double.Parse((this.orderDetailsTableAdapter.TotalReport(searchOrderId)).ToString());
                string totalString = total.ToString("c");
                lblTotal.Text = totalString;
            }
            catch
            {
                MessageBox.Show("Must enter a valid order number.");
            }
            
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            string searchOrderDate = (dtpOrderDate.Value).ToString();
            string orderCount = (this.ordersTableAdapter.DateReport(searchOrderDate)).ToString();
            lblOrderCount.Text = orderCount;
        }
    }
}
