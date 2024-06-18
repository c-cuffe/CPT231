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
    public partial class InsertUsers : Form
    {
        public InsertUsers()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.golfCourseDataSet);

        }

        private void InsertUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'golfCourseDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.golfCourseDataSet.Users);

        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
