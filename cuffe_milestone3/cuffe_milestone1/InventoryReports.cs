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
    public partial class InventoryReports : Form
    {
        public InventoryReports()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.golfCourseDataSet1);

        }

        private void InventoryReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'golfCourseDataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.golfCourseDataSet1.Product);

        }

        private void lblInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchCount_Click(object sender, EventArgs e)
        {
            int searchCount = int.Parse(txtCount.Text);
            this.productTableAdapter.CountReport(this.golfCourseDataSet1.Product, searchCount);
        }

        private void btnSearchPrice_Click(object sender, EventArgs e)
        {
            decimal searchPrice = decimal.Parse(txtPrice.Text);
            this.productTableAdapter.PriceReport(this.golfCourseDataSet1.Product, searchPrice);
        }
    }
}
