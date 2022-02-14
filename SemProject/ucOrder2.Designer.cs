
namespace SemProject
{
    partial class ucOrder2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panOrderView = new System.Windows.Forms.Panel();
            this.dgViewOrders = new System.Windows.Forms.DataGridView();
            this.butSearch = new System.Windows.Forms.Button();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.labOrderID = new System.Windows.Forms.Label();
            this.labOrderDetails = new System.Windows.Forms.Label();
            this.panDeleteOrder = new System.Windows.Forms.Panel();
            this.butDelete = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.txtOrderID1 = new System.Windows.Forms.TextBox();
            this.labOrderId1 = new System.Windows.Forms.Label();
            this.labDeleteOrder = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butView = new System.Windows.Forms.Button();
            this.dGOrderReports = new System.Windows.Forms.DataGridView();
            this.labOrderReport = new System.Windows.Forms.Label();
            this.Todate = new System.Windows.Forms.DateTimePicker();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.labToDate = new System.Windows.Forms.Label();
            this.labFromDate = new System.Windows.Forms.Label();
            this.panOrderView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewOrders)).BeginInit();
            this.panDeleteOrder.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGOrderReports)).BeginInit();
            this.SuspendLayout();
            // 
            // panOrderView
            // 
            this.panOrderView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panOrderView.Controls.Add(this.dgViewOrders);
            this.panOrderView.Controls.Add(this.butSearch);
            this.panOrderView.Controls.Add(this.txtOrderID);
            this.panOrderView.Controls.Add(this.labOrderID);
            this.panOrderView.Controls.Add(this.labOrderDetails);
            this.panOrderView.Location = new System.Drawing.Point(16, 18);
            this.panOrderView.Name = "panOrderView";
            this.panOrderView.Size = new System.Drawing.Size(541, 222);
            this.panOrderView.TabIndex = 0;
            // 
            // dgViewOrders
            // 
            this.dgViewOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewOrders.GridColor = System.Drawing.Color.White;
            this.dgViewOrders.Location = new System.Drawing.Point(12, 77);
            this.dgViewOrders.Name = "dgViewOrders";
            this.dgViewOrders.Size = new System.Drawing.Size(513, 131);
            this.dgViewOrders.TabIndex = 4;
            // 
            // butSearch
            // 
            this.butSearch.BackColor = System.Drawing.Color.Green;
            this.butSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSearch.Location = new System.Drawing.Point(254, 34);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(75, 23);
            this.butSearch.TabIndex = 3;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = false;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // txtOrderID
            // 
            this.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrderID.Location = new System.Drawing.Point(73, 43);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(162, 13);
            this.txtOrderID.TabIndex = 2;
            // 
            // labOrderID
            // 
            this.labOrderID.AutoSize = true;
            this.labOrderID.Font = new System.Drawing.Font("Corbel", 9F);
            this.labOrderID.Location = new System.Drawing.Point(20, 43);
            this.labOrderID.Name = "labOrderID";
            this.labOrderID.Size = new System.Drawing.Size(49, 14);
            this.labOrderID.TabIndex = 1;
            this.labOrderID.Text = "Order ID";
            // 
            // labOrderDetails
            // 
            this.labOrderDetails.AutoSize = true;
            this.labOrderDetails.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labOrderDetails.Location = new System.Drawing.Point(223, 11);
            this.labOrderDetails.Name = "labOrderDetails";
            this.labOrderDetails.Size = new System.Drawing.Size(81, 16);
            this.labOrderDetails.TabIndex = 0;
            this.labOrderDetails.Text = "View Odrer";
            // 
            // panDeleteOrder
            // 
            this.panDeleteOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panDeleteOrder.Controls.Add(this.butDelete);
            this.panDeleteOrder.Controls.Add(this.butClear);
            this.panDeleteOrder.Controls.Add(this.txtOrderID1);
            this.panDeleteOrder.Controls.Add(this.labOrderId1);
            this.panDeleteOrder.Controls.Add(this.labDeleteOrder);
            this.panDeleteOrder.Location = new System.Drawing.Point(580, 18);
            this.panDeleteOrder.Name = "panDeleteOrder";
            this.panDeleteOrder.Size = new System.Drawing.Size(283, 125);
            this.panDeleteOrder.TabIndex = 1;
            // 
            // butDelete
            // 
            this.butDelete.BackColor = System.Drawing.Color.Green;
            this.butDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDelete.Location = new System.Drawing.Point(150, 78);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 6;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = false;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butClear
            // 
            this.butClear.BackColor = System.Drawing.Color.Red;
            this.butClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClear.Location = new System.Drawing.Point(52, 78);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 23);
            this.butClear.TabIndex = 5;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = false;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // txtOrderID1
            // 
            this.txtOrderID1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrderID1.Location = new System.Drawing.Point(82, 44);
            this.txtOrderID1.Name = "txtOrderID1";
            this.txtOrderID1.Size = new System.Drawing.Size(162, 13);
            this.txtOrderID1.TabIndex = 4;
            // 
            // labOrderId1
            // 
            this.labOrderId1.AutoSize = true;
            this.labOrderId1.Font = new System.Drawing.Font("Corbel", 9F);
            this.labOrderId1.Location = new System.Drawing.Point(29, 44);
            this.labOrderId1.Name = "labOrderId1";
            this.labOrderId1.Size = new System.Drawing.Size(49, 14);
            this.labOrderId1.TabIndex = 3;
            this.labOrderId1.Text = "Order ID";
            // 
            // labDeleteOrder
            // 
            this.labDeleteOrder.AutoSize = true;
            this.labDeleteOrder.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labDeleteOrder.Location = new System.Drawing.Point(98, 11);
            this.labDeleteOrder.Name = "labDeleteOrder";
            this.labDeleteOrder.Size = new System.Drawing.Size(91, 16);
            this.labDeleteOrder.TabIndex = 1;
            this.labDeleteOrder.Text = "Delete Order";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Todate);
            this.panel1.Controls.Add(this.butView);
            this.panel1.Controls.Add(this.labToDate);
            this.panel1.Controls.Add(this.FromDate);
            this.panel1.Controls.Add(this.dGOrderReports);
            this.panel1.Controls.Add(this.labOrderReport);
            this.panel1.Controls.Add(this.labFromDate);
            this.panel1.Location = new System.Drawing.Point(16, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 259);
            this.panel1.TabIndex = 5;
            // 
            // butView
            // 
            this.butView.BackColor = System.Drawing.Color.Green;
            this.butView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butView.Location = new System.Drawing.Point(646, 204);
            this.butView.Name = "butView";
            this.butView.Size = new System.Drawing.Size(90, 39);
            this.butView.TabIndex = 4;
            this.butView.Text = "View Report";
            this.butView.UseVisualStyleBackColor = false;
            this.butView.Click += new System.EventHandler(this.butView_Click);
            // 
            // dGOrderReports
            // 
            this.dGOrderReports.BackgroundColor = System.Drawing.Color.White;
            this.dGOrderReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGOrderReports.GridColor = System.Drawing.Color.Gray;
            this.dGOrderReports.Location = new System.Drawing.Point(12, 30);
            this.dGOrderReports.Name = "dGOrderReports";
            this.dGOrderReports.Size = new System.Drawing.Size(812, 160);
            this.dGOrderReports.TabIndex = 3;
            // 
            // labOrderReport
            // 
            this.labOrderReport.AutoSize = true;
            this.labOrderReport.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOrderReport.Location = new System.Drawing.Point(377, 3);
            this.labOrderReport.Name = "labOrderReport";
            this.labOrderReport.Size = new System.Drawing.Size(92, 16);
            this.labOrderReport.TabIndex = 2;
            this.labOrderReport.Text = "Order Report";
            // 
            // Todate
            // 
            this.Todate.Location = new System.Drawing.Point(449, 223);
            this.Todate.Margin = new System.Windows.Forms.Padding(2);
            this.Todate.Name = "Todate";
            this.Todate.Size = new System.Drawing.Size(151, 20);
            this.Todate.TabIndex = 32;
            // 
            // FromDate
            // 
            this.FromDate.Location = new System.Drawing.Point(180, 222);
            this.FromDate.Margin = new System.Windows.Forms.Padding(2);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(151, 20);
            this.FromDate.TabIndex = 31;
            // 
            // labToDate
            // 
            this.labToDate.AutoSize = true;
            this.labToDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labToDate.Location = new System.Drawing.Point(376, 223);
            this.labToDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labToDate.Name = "labToDate";
            this.labToDate.Size = new System.Drawing.Size(69, 16);
            this.labToDate.TabIndex = 30;
            this.labToDate.Text = "TO DATE :";
            // 
            // labFromDate
            // 
            this.labFromDate.AutoSize = true;
            this.labFromDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labFromDate.Location = new System.Drawing.Point(87, 223);
            this.labFromDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labFromDate.Name = "labFromDate";
            this.labFromDate.Size = new System.Drawing.Size(89, 16);
            this.labFromDate.TabIndex = 29;
            this.labFromDate.Text = "FROM DATE :";
            // 
            // ucOrder2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panDeleteOrder);
            this.Controls.Add(this.panOrderView);
            this.Name = "ucOrder2";
            this.Size = new System.Drawing.Size(894, 550);
            this.panOrderView.ResumeLayout(false);
            this.panOrderView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewOrders)).EndInit();
            this.panDeleteOrder.ResumeLayout(false);
            this.panDeleteOrder.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGOrderReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panOrderView;
        private System.Windows.Forms.Label labOrderDetails;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label labOrderID;
        private System.Windows.Forms.Panel panDeleteOrder;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.TextBox txtOrderID1;
        private System.Windows.Forms.Label labOrderId1;
        private System.Windows.Forms.Label labDeleteOrder;
        private System.Windows.Forms.DataGridView dgViewOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butView;
        private System.Windows.Forms.DataGridView dGOrderReports;
        private System.Windows.Forms.Label labOrderReport;
        private System.Windows.Forms.DateTimePicker Todate;
        private System.Windows.Forms.Label labToDate;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.Label labFromDate;
    }
}
