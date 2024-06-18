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
    public partial class SearchProducts : Form
    {
        public SearchProducts()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.golfCourseDataSet1);

        }

        private void SearchProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'golfCourseDataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.golfCourseDataSet1.Product);

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var searchName = txtName.Text;
                this.productTableAdapter.SearchProduct(this.golfCourseDataSet1.Product, searchName);
            }
            catch
            {
                MessageBox.Show("Error. Invalid entry.");
            }
        }
    }
}
