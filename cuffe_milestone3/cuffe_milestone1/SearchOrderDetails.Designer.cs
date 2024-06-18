namespace cuffe_milestone1
{
    partial class SearchOrderDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.golfCourseDataSet = new cuffe_milestone1.GolfCourseDataSet();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailsTableAdapter = new cuffe_milestone1.GolfCourseDataSetTableAdapters.OrderDetailsTableAdapter();
            this.tableAdapterManager = new cuffe_milestone1.GolfCourseDataSetTableAdapters.TableAdapterManager();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchOrderId = new System.Windows.Forms.Label();
            this.txtSearchOrderId = new System.Windows.Forms.TextBox();
            this.orderDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.orderDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.golfCourseDataSet1 = new cuffe_milestone1.GolfCourseDataSet1();
            this.orderDetailsTableAdapter1 = new cuffe_milestone1.GolfCourseDataSet1TableAdapters.OrderDetailsTableAdapter();
            this.tableAdapterManager1 = new cuffe_milestone1.GolfCourseDataSet1TableAdapters.TableAdapterManager();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.golfCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.golfCourseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // golfCourseDataSet
            // 
            this.golfCourseDataSet.DataSetName = "GolfCourseDataSet";
            this.golfCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            this.orderDetailsBindingSource.DataSource = this.golfCourseDataSet;
            // 
            // orderDetailsTableAdapter
            // 
            this.orderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrderDetailsTableAdapter = this.orderDetailsTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.TablesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = cuffe_milestone1.GolfCourseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(263, 60);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchOrderId
            // 
            this.lblSearchOrderId.AutoSize = true;
            this.lblSearchOrderId.Location = new System.Drawing.Point(138, 25);
            this.lblSearchOrderId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchOrderId.Name = "lblSearchOrderId";
            this.lblSearchOrderId.Size = new System.Drawing.Size(93, 13);
            this.lblSearchOrderId.TabIndex = 3;
            this.lblSearchOrderId.Text = "Enter Order ID:";
            // 
            // txtSearchOrderId
            // 
            this.txtSearchOrderId.Location = new System.Drawing.Point(235, 25);
            this.txtSearchOrderId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchOrderId.Name = "txtSearchOrderId";
            this.txtSearchOrderId.Size = new System.Drawing.Size(116, 20);
            this.txtSearchOrderId.TabIndex = 4;
            // 
            // orderDetailsDataGridView
            // 
            this.orderDetailsDataGridView.AllowUserToAddRows = false;
            this.orderDetailsDataGridView.AllowUserToDeleteRows = false;
            this.orderDetailsDataGridView.AutoGenerateColumns = false;
            this.orderDetailsDataGridView.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.orderDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.orderDetailsDataGridView.DataSource = this.orderDetailsBindingSource1;
            this.orderDetailsDataGridView.GridColor = System.Drawing.Color.Maroon;
            this.orderDetailsDataGridView.Location = new System.Drawing.Point(13, 101);
            this.orderDetailsDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.orderDetailsDataGridView.Name = "orderDetailsDataGridView";
            this.orderDetailsDataGridView.ReadOnly = true;
            this.orderDetailsDataGridView.Size = new System.Drawing.Size(470, 220);
            this.orderDetailsDataGridView.TabIndex = 4;
            // 
            // orderDetailsBindingSource1
            // 
            this.orderDetailsBindingSource1.DataMember = "OrderDetails";
            this.orderDetailsBindingSource1.DataSource = this.golfCourseDataSet1;
            // 
            // golfCourseDataSet1
            // 
            this.golfCourseDataSet1.DataSetName = "GolfCourseDataSet1";
            this.golfCourseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderDetailsTableAdapter1
            // 
            this.orderDetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.OrderDetailsTableAdapter = this.orderDetailsTableAdapter1;
            this.tableAdapterManager1.OrdersTableAdapter = null;
            this.tableAdapterManager1.ProductTableAdapter = null;
            this.tableAdapterManager1.TablesTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = cuffe_milestone1.GolfCourseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsersTableAdapter = null;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(146, 60);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(88, 23);
            this.btnShowAll.TabIndex = 5;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "orderdetailkey";
            this.dataGridViewTextBoxColumn1.HeaderText = "Order Detail Key";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "orderid";
            this.dataGridViewTextBoxColumn2.HeaderText = "Order ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "productid";
            this.dataGridViewTextBoxColumn3.HeaderText = "Product ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "orderdetailproductcount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Product Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // SearchOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(499, 367);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.orderDetailsDataGridView);
            this.Controls.Add(this.txtSearchOrderId);
            this.Controls.Add(this.lblSearchOrderId);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SearchOrderDetails";
            this.Text = "SearchOrderDetails";
            this.Load += new System.EventHandler(this.SearchOrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.golfCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.golfCourseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GolfCourseDataSet golfCourseDataSet;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private GolfCourseDataSetTableAdapters.OrderDetailsTableAdapter orderDetailsTableAdapter;
        private GolfCourseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchOrderId;
        private System.Windows.Forms.TextBox txtSearchOrderId;
        private GolfCourseDataSet1 golfCourseDataSet1;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource1;
        private GolfCourseDataSet1TableAdapters.OrderDetailsTableAdapter orderDetailsTableAdapter1;
        private GolfCourseDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView orderDetailsDataGridView;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}