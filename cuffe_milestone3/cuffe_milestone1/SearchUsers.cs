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
    public partial class SearchUsers : Form
    {
        public SearchUsers()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.golfCourseDataSet1);

        }

        private void SearchUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'golfCourseDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.golfCourseDataSet1.Users);

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int searchId = int.Parse(txtSearchUser.Text);
                this.usersTableAdapter.SearchUser(this.golfCourseDataSet1.Users, searchId);
            }
            catch
            {
                MessageBox.Show("Error. Must enter an integer");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'golfCourseDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.golfCourseDataSet1.Users);
        }
    }
}
