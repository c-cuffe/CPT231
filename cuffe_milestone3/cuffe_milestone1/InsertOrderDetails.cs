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
    public partial class InsertOrderDetails : Form
    {
        public InsertOrderDetails()
        {
            InitializeComponent();
        }

        private void orderDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.golfCourseDataSet);

        }
    
        private void InsertOrderDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'golfCourseDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.golfCourseDataSet.Product);
            // TODO: This line of code loads data into the 'golfCourseDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.golfCourseDataSet.Orders);
            // TODO: This line of code loads data into the 'golfCourseDataSet.OrderDetails' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter.Fill(this.golfCourseDataSet.OrderDetails);

        }

        private void orderDetailsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
