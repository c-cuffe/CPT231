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
    public partial class SearchOrderDetails : Form
    {
        public SearchOrderDetails()
        {
            InitializeComponent();
        }

        private void orderDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.golfCourseDataSet);

        }

        private void SearchOrderDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'golfCourseDataSet1.OrderDetails' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter1.Fill(this.golfCourseDataSet1.OrderDetails);
            // TODO: This line of code loads data into the 'golfCourseDataSet.OrderDetails' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter.Fill(this.golfCourseDataSet.OrderDetails);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int searchOrderId = int.Parse(txtSearchOrderId.Text);
                this.orderDetailsTableAdapter1.SearchOrderDetails(this.golfCourseDataSet1.OrderDetails, searchOrderId);

            }
            catch
            {
                MessageBox.Show("Must enter an integer value.");
            }
   
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'golfCourseDataSet1.OrderDetails' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter1.Fill(this.golfCourseDataSet1.OrderDetails);
            // TODO: This line of code loads data into the 'golfCourseDataSet.OrderDetails' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter.Fill(this.golfCourseDataSet.OrderDetails);
        }
    }
}
