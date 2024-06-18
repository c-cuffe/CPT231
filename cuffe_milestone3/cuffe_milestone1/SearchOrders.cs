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
    public partial class SearchOrders : Form
    {
        public SearchOrders()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.golfCourseDataSet);

        }

        private void SearchOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'golfCourseDataSet1.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter1.Fill(this.golfCourseDataSet1.Orders);
            // TODO: This line of code loads data into the 'golfCourseDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.golfCourseDataSet.Orders);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int searchUser = int.Parse(txtUser.Text);
                this.ordersTableAdapter1.SearchOrder(this.golfCourseDataSet1.Orders, searchUser);
            }
            catch
            {
                MessageBox.Show("Error. Must enter integer.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'golfCourseDataSet1.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter1.Fill(this.golfCourseDataSet1.Orders);
            // TODO: This line of code loads data into the 'golfCourseDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.golfCourseDataSet.Orders);
        }
    }
}
