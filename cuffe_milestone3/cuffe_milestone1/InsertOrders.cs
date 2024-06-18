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
    public partial class InsertOrders : Form
    {
        public InsertOrders()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.golfCourseDataSet);

        }

        private void InsertOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'golfCourseDataSet._Tables' table. You can move, or remove it, as needed.
            this.tablesTableAdapter.Fill(this.golfCourseDataSet._Tables);
            // TODO: This line of code loads data into the 'golfCourseDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.golfCourseDataSet.Users);
            // TODO: This line of code loads data into the 'golfCourseDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.golfCourseDataSet.Product);
            // TODO: This line of code loads data into the 'golfCourseDataSet.OrderDetails' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter.Fill(this.golfCourseDataSet.OrderDetails);
            // TODO: This line of code loads data into the 'golfCourseDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.golfCourseDataSet.Orders);

        }
        private void ordersDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
