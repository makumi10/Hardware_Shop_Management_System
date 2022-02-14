
namespace SemProject
{
    partial class ucOrderInsert
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
            this.labOrderID = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.panOrderDetails = new System.Windows.Forms.Panel();
            this.labOrderDetails = new System.Windows.Forms.Label();
            this.panCustomDetails = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.labDate = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.labAddress = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.labPhoneNum = new System.Windows.Forms.Label();
            this.txtEmailID = new System.Windows.Forms.TextBox();
            this.labEmailID = new System.Windows.Forms.Label();
            this.txtCustomName = new System.Windows.Forms.TextBox();
            this.labCustomName = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.labSearch = new System.Windows.Forms.Label();
            this.labCustomDetails = new System.Windows.Forms.Label();
            this.labOrderInsert = new System.Windows.Forms.Label();
            this.panProductDetails = new System.Windows.Forms.Panel();
            this.butAdd = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.labQuantity = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.labAmount = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.labProductID = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.labProductName = new System.Windows.Forms.Label();
            this.labProductDetails = new System.Windows.Forms.Label();
            this.txtSearch1 = new System.Windows.Forms.TextBox();
            this.labSearch1 = new System.Windows.Forms.Label();
            this.panCalcDetails = new System.Windows.Forms.Panel();
            this.butSave = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.txtRetAmount = new System.Windows.Forms.TextBox();
            this.labRetAmount = new System.Windows.Forms.Label();
            this.labCalcDetails = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.labPaidAmount = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.labTotal = new System.Windows.Forms.Label();
            this.txtGST = new System.Windows.Forms.TextBox();
            this.labGST = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.labDiscout = new System.Windows.Forms.Label();
            this.txtSubTot = new System.Windows.Forms.TextBox();
            this.labSubTot = new System.Windows.Forms.Label();
            this.panAddProduct = new System.Windows.Forms.Panel();
            this.dGAddedProducts = new System.Windows.Forms.DataGridView();
            this.labAddProduct = new System.Windows.Forms.Label();
            this.panOrderDetails.SuspendLayout();
            this.panCustomDetails.SuspendLayout();
            this.panProductDetails.SuspendLayout();
            this.panCalcDetails.SuspendLayout();
            this.panAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGAddedProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // labOrderID
            // 
            this.labOrderID.AutoSize = true;
            this.labOrderID.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOrderID.Location = new System.Drawing.Point(13, 38);
            this.labOrderID.Name = "labOrderID";
            this.labOrderID.Size = new System.Drawing.Size(49, 14);
            this.labOrderID.TabIndex = 2;
            this.labOrderID.Text = "Order ID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrderID.Location = new System.Drawing.Point(70, 38);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(137, 13);
            this.txtOrderID.TabIndex = 3;
            // 
            // panOrderDetails
            // 
            this.panOrderDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panOrderDetails.Controls.Add(this.labOrderDetails);
            this.panOrderDetails.Controls.Add(this.txtOrderID);
            this.panOrderDetails.Controls.Add(this.labOrderID);
            this.panOrderDetails.Location = new System.Drawing.Point(30, 13);
            this.panOrderDetails.Name = "panOrderDetails";
            this.panOrderDetails.Size = new System.Drawing.Size(229, 74);
            this.panOrderDetails.TabIndex = 4;
            // 
            // labOrderDetails
            // 
            this.labOrderDetails.AutoSize = true;
            this.labOrderDetails.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labOrderDetails.Location = new System.Drawing.Point(62, 9);
            this.labOrderDetails.Name = "labOrderDetails";
            this.labOrderDetails.Size = new System.Drawing.Size(94, 16);
            this.labOrderDetails.TabIndex = 4;
            this.labOrderDetails.Text = "Order Details";
            // 
            // panCustomDetails
            // 
            this.panCustomDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panCustomDetails.Controls.Add(this.date);
            this.panCustomDetails.Controls.Add(this.labDate);
            this.panCustomDetails.Controls.Add(this.txtAddress);
            this.panCustomDetails.Controls.Add(this.labAddress);
            this.panCustomDetails.Controls.Add(this.txtPhoneNum);
            this.panCustomDetails.Controls.Add(this.labPhoneNum);
            this.panCustomDetails.Controls.Add(this.txtEmailID);
            this.panCustomDetails.Controls.Add(this.labEmailID);
            this.panCustomDetails.Controls.Add(this.txtCustomName);
            this.panCustomDetails.Controls.Add(this.labCustomName);
            this.panCustomDetails.Controls.Add(this.txtSearch);
            this.panCustomDetails.Controls.Add(this.labSearch);
            this.panCustomDetails.Controls.Add(this.labCustomDetails);
            this.panCustomDetails.Location = new System.Drawing.Point(30, 104);
            this.panCustomDetails.Name = "panCustomDetails";
            this.panCustomDetails.Size = new System.Drawing.Size(263, 210);
            this.panCustomDetails.TabIndex = 5;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(101, 165);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(137, 20);
            this.date.TabIndex = 17;
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Font = new System.Drawing.Font("Corbel", 9F);
            this.labDate.Location = new System.Drawing.Point(14, 165);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(31, 14);
            this.labDate.TabIndex = 6;
            this.labDate.Text = "Date";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Location = new System.Drawing.Point(102, 140);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(137, 13);
            this.txtAddress.TabIndex = 16;
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddress.Location = new System.Drawing.Point(14, 140);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(47, 14);
            this.labAddress.TabIndex = 15;
            this.labAddress.Text = "Address";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNum.Location = new System.Drawing.Point(102, 115);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(137, 13);
            this.txtPhoneNum.TabIndex = 14;
            // 
            // labPhoneNum
            // 
            this.labPhoneNum.AutoSize = true;
            this.labPhoneNum.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPhoneNum.Location = new System.Drawing.Point(14, 115);
            this.labPhoneNum.Name = "labPhoneNum";
            this.labPhoneNum.Size = new System.Drawing.Size(80, 14);
            this.labPhoneNum.TabIndex = 13;
            this.labPhoneNum.Text = "Phone Number";
            // 
            // txtEmailID
            // 
            this.txtEmailID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailID.Location = new System.Drawing.Point(102, 90);
            this.txtEmailID.Name = "txtEmailID";
            this.txtEmailID.Size = new System.Drawing.Size(137, 13);
            this.txtEmailID.TabIndex = 12;
            // 
            // labEmailID
            // 
            this.labEmailID.AutoSize = true;
            this.labEmailID.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmailID.Location = new System.Drawing.Point(14, 90);
            this.labEmailID.Name = "labEmailID";
            this.labEmailID.Size = new System.Drawing.Size(49, 14);
            this.labEmailID.TabIndex = 11;
            this.labEmailID.Text = "Email ID";
            // 
            // txtCustomName
            // 
            this.txtCustomName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomName.Location = new System.Drawing.Point(102, 64);
            this.txtCustomName.Name = "txtCustomName";
            this.txtCustomName.Size = new System.Drawing.Size(137, 13);
            this.txtCustomName.TabIndex = 10;
            // 
            // labCustomName
            // 
            this.labCustomName.AutoSize = true;
            this.labCustomName.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCustomName.Location = new System.Drawing.Point(13, 64);
            this.labCustomName.Name = "labCustomName";
            this.labCustomName.Size = new System.Drawing.Size(87, 14);
            this.labCustomName.TabIndex = 9;
            this.labCustomName.Text = "Customer Name";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(102, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(137, 13);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSearch.Location = new System.Drawing.Point(14, 38);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(41, 14);
            this.labSearch.TabIndex = 7;
            this.labSearch.Text = "Search";
            // 
            // labCustomDetails
            // 
            this.labCustomDetails.AutoSize = true;
            this.labCustomDetails.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labCustomDetails.Location = new System.Drawing.Point(63, 9);
            this.labCustomDetails.Name = "labCustomDetails";
            this.labCustomDetails.Size = new System.Drawing.Size(117, 16);
            this.labCustomDetails.TabIndex = 6;
            this.labCustomDetails.Text = "Customer Details";
            // 
            // labOrderInsert
            // 
            this.labOrderInsert.AutoSize = true;
            this.labOrderInsert.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOrderInsert.Location = new System.Drawing.Point(379, 17);
            this.labOrderInsert.Name = "labOrderInsert";
            this.labOrderInsert.Size = new System.Drawing.Size(169, 32);
            this.labOrderInsert.TabIndex = 6;
            this.labOrderInsert.Text = "Order Insert";
            // 
            // panProductDetails
            // 
            this.panProductDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panProductDetails.Controls.Add(this.butAdd);
            this.panProductDetails.Controls.Add(this.txtQuantity);
            this.panProductDetails.Controls.Add(this.labQuantity);
            this.panProductDetails.Controls.Add(this.txtAmount);
            this.panProductDetails.Controls.Add(this.labAmount);
            this.panProductDetails.Controls.Add(this.txtProductID);
            this.panProductDetails.Controls.Add(this.labProductID);
            this.panProductDetails.Controls.Add(this.txtProductName);
            this.panProductDetails.Controls.Add(this.labProductName);
            this.panProductDetails.Controls.Add(this.labProductDetails);
            this.panProductDetails.Controls.Add(this.txtSearch1);
            this.panProductDetails.Controls.Add(this.labSearch1);
            this.panProductDetails.Location = new System.Drawing.Point(313, 104);
            this.panProductDetails.Name = "panProductDetails";
            this.panProductDetails.Size = new System.Drawing.Size(263, 210);
            this.panProductDetails.TabIndex = 7;
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.Green;
            this.butAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAdd.ForeColor = System.Drawing.Color.Black;
            this.butAdd.Location = new System.Drawing.Point(85, 164);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 8;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Location = new System.Drawing.Point(102, 140);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(137, 13);
            this.txtQuantity.TabIndex = 18;
            // 
            // labQuantity
            // 
            this.labQuantity.AutoSize = true;
            this.labQuantity.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQuantity.Location = new System.Drawing.Point(14, 140);
            this.labQuantity.Name = "labQuantity";
            this.labQuantity.Size = new System.Drawing.Size(51, 14);
            this.labQuantity.TabIndex = 17;
            this.labQuantity.Text = "Quantity";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Location = new System.Drawing.Point(102, 114);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(137, 13);
            this.txtAmount.TabIndex = 16;
            // 
            // labAmount
            // 
            this.labAmount.AutoSize = true;
            this.labAmount.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAmount.Location = new System.Drawing.Point(14, 114);
            this.labAmount.Name = "labAmount";
            this.labAmount.Size = new System.Drawing.Size(47, 14);
            this.labAmount.TabIndex = 15;
            this.labAmount.Text = "Amount";
            // 
            // txtProductID
            // 
            this.txtProductID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductID.Location = new System.Drawing.Point(102, 89);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(137, 13);
            this.txtProductID.TabIndex = 14;
            // 
            // labProductID
            // 
            this.labProductID.AutoSize = true;
            this.labProductID.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProductID.Location = new System.Drawing.Point(14, 89);
            this.labProductID.Name = "labProductID";
            this.labProductID.Size = new System.Drawing.Size(58, 14);
            this.labProductID.TabIndex = 13;
            this.labProductID.Text = "Product ID";
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductName.Location = new System.Drawing.Point(102, 64);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(137, 13);
            this.txtProductName.TabIndex = 12;
            // 
            // labProductName
            // 
            this.labProductName.AutoSize = true;
            this.labProductName.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProductName.Location = new System.Drawing.Point(14, 64);
            this.labProductName.Name = "labProductName";
            this.labProductName.Size = new System.Drawing.Size(77, 14);
            this.labProductName.TabIndex = 11;
            this.labProductName.Text = "Product Name";
            // 
            // labProductDetails
            // 
            this.labProductDetails.AutoSize = true;
            this.labProductDetails.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labProductDetails.Location = new System.Drawing.Point(75, 9);
            this.labProductDetails.Name = "labProductDetails";
            this.labProductDetails.Size = new System.Drawing.Size(105, 16);
            this.labProductDetails.TabIndex = 8;
            this.labProductDetails.Text = "Product Details";
            // 
            // txtSearch1
            // 
            this.txtSearch1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch1.Location = new System.Drawing.Point(101, 38);
            this.txtSearch1.Name = "txtSearch1";
            this.txtSearch1.Size = new System.Drawing.Size(137, 13);
            this.txtSearch1.TabIndex = 10;
            this.txtSearch1.TextChanged += new System.EventHandler(this.txtSearch1_TextChanged);
            // 
            // labSearch1
            // 
            this.labSearch1.AutoSize = true;
            this.labSearch1.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSearch1.Location = new System.Drawing.Point(14, 38);
            this.labSearch1.Name = "labSearch1";
            this.labSearch1.Size = new System.Drawing.Size(41, 14);
            this.labSearch1.TabIndex = 9;
            this.labSearch1.Text = "Search";
            // 
            // panCalcDetails
            // 
            this.panCalcDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panCalcDetails.Controls.Add(this.butSave);
            this.panCalcDetails.Controls.Add(this.butClear);
            this.panCalcDetails.Controls.Add(this.txtRetAmount);
            this.panCalcDetails.Controls.Add(this.labRetAmount);
            this.panCalcDetails.Controls.Add(this.labCalcDetails);
            this.panCalcDetails.Controls.Add(this.txtPaidAmount);
            this.panCalcDetails.Controls.Add(this.labPaidAmount);
            this.panCalcDetails.Controls.Add(this.txtTotal);
            this.panCalcDetails.Controls.Add(this.labTotal);
            this.panCalcDetails.Controls.Add(this.txtGST);
            this.panCalcDetails.Controls.Add(this.labGST);
            this.panCalcDetails.Controls.Add(this.txtDiscount);
            this.panCalcDetails.Controls.Add(this.labDiscout);
            this.panCalcDetails.Controls.Add(this.txtSubTot);
            this.panCalcDetails.Controls.Add(this.labSubTot);
            this.panCalcDetails.Location = new System.Drawing.Point(597, 104);
            this.panCalcDetails.Name = "panCalcDetails";
            this.panCalcDetails.Size = new System.Drawing.Size(276, 240);
            this.panCalcDetails.TabIndex = 8;
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.Green;
            this.butSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSave.Location = new System.Drawing.Point(153, 195);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 33;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butClear
            // 
            this.butClear.BackColor = System.Drawing.Color.Red;
            this.butClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClear.Location = new System.Drawing.Point(44, 195);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 23);
            this.butClear.TabIndex = 32;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = false;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // txtRetAmount
            // 
            this.txtRetAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRetAmount.Location = new System.Drawing.Point(113, 164);
            this.txtRetAmount.Name = "txtRetAmount";
            this.txtRetAmount.Size = new System.Drawing.Size(137, 13);
            this.txtRetAmount.TabIndex = 31;
            // 
            // labRetAmount
            // 
            this.labRetAmount.AutoSize = true;
            this.labRetAmount.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRetAmount.Location = new System.Drawing.Point(25, 164);
            this.labRetAmount.Name = "labRetAmount";
            this.labRetAmount.Size = new System.Drawing.Size(81, 14);
            this.labRetAmount.TabIndex = 30;
            this.labRetAmount.Text = "Return Amount";
            // 
            // labCalcDetails
            // 
            this.labCalcDetails.AutoSize = true;
            this.labCalcDetails.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labCalcDetails.Location = new System.Drawing.Point(85, 9);
            this.labCalcDetails.Name = "labCalcDetails";
            this.labCalcDetails.Size = new System.Drawing.Size(132, 16);
            this.labCalcDetails.TabIndex = 29;
            this.labCalcDetails.Text = "Calculation Details";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaidAmount.Location = new System.Drawing.Point(113, 139);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(137, 13);
            this.txtPaidAmount.TabIndex = 28;
            this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            // 
            // labPaidAmount
            // 
            this.labPaidAmount.AutoSize = true;
            this.labPaidAmount.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPaidAmount.Location = new System.Drawing.Point(25, 139);
            this.labPaidAmount.Name = "labPaidAmount";
            this.labPaidAmount.Size = new System.Drawing.Size(70, 14);
            this.labPaidAmount.TabIndex = 27;
            this.labPaidAmount.Text = "Paid Amount";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Location = new System.Drawing.Point(113, 113);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(137, 13);
            this.txtTotal.TabIndex = 26;
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotal.Location = new System.Drawing.Point(25, 113);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(32, 14);
            this.labTotal.TabIndex = 25;
            this.labTotal.Text = "Total";
            // 
            // txtGST
            // 
            this.txtGST.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGST.Location = new System.Drawing.Point(113, 88);
            this.txtGST.Name = "txtGST";
            this.txtGST.Size = new System.Drawing.Size(137, 13);
            this.txtGST.TabIndex = 24;
            this.txtGST.TextChanged += new System.EventHandler(this.txtGST_TextChanged);
            // 
            // labGST
            // 
            this.labGST.AutoSize = true;
            this.labGST.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGST.Location = new System.Drawing.Point(25, 88);
            this.labGST.Name = "labGST";
            this.labGST.Size = new System.Drawing.Size(49, 14);
            this.labGST.TabIndex = 23;
            this.labGST.Text = "GST (%)";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiscount.Location = new System.Drawing.Point(113, 63);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(137, 13);
            this.txtDiscount.TabIndex = 22;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // labDiscout
            // 
            this.labDiscout.AutoSize = true;
            this.labDiscout.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDiscout.Location = new System.Drawing.Point(25, 63);
            this.labDiscout.Name = "labDiscout";
            this.labDiscout.Size = new System.Drawing.Size(70, 14);
            this.labDiscout.TabIndex = 21;
            this.labDiscout.Text = "Discount (%)";
            // 
            // txtSubTot
            // 
            this.txtSubTot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubTot.Location = new System.Drawing.Point(112, 37);
            this.txtSubTot.Name = "txtSubTot";
            this.txtSubTot.Size = new System.Drawing.Size(137, 13);
            this.txtSubTot.TabIndex = 20;
            // 
            // labSubTot
            // 
            this.labSubTot.AutoSize = true;
            this.labSubTot.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSubTot.Location = new System.Drawing.Point(25, 37);
            this.labSubTot.Name = "labSubTot";
            this.labSubTot.Size = new System.Drawing.Size(52, 14);
            this.labSubTot.TabIndex = 19;
            this.labSubTot.Text = "Sub Total";
            // 
            // panAddProduct
            // 
            this.panAddProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panAddProduct.Controls.Add(this.dGAddedProducts);
            this.panAddProduct.Controls.Add(this.labAddProduct);
            this.panAddProduct.Location = new System.Drawing.Point(30, 334);
            this.panAddProduct.Name = "panAddProduct";
            this.panAddProduct.Size = new System.Drawing.Size(546, 210);
            this.panAddProduct.TabIndex = 9;
            // 
            // dGAddedProducts
            // 
            this.dGAddedProducts.BackgroundColor = System.Drawing.Color.White;
            this.dGAddedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGAddedProducts.Location = new System.Drawing.Point(11, 30);
            this.dGAddedProducts.Name = "dGAddedProducts";
            this.dGAddedProducts.Size = new System.Drawing.Size(520, 165);
            this.dGAddedProducts.TabIndex = 1;
            // 
            // labAddProduct
            // 
            this.labAddProduct.AutoSize = true;
            this.labAddProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labAddProduct.Location = new System.Drawing.Point(224, 2);
            this.labAddProduct.Name = "labAddProduct";
            this.labAddProduct.Size = new System.Drawing.Size(112, 16);
            this.labAddProduct.TabIndex = 0;
            this.labAddProduct.Text = "Added Products";
            // 
            // ucOrderInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panAddProduct);
            this.Controls.Add(this.panCalcDetails);
            this.Controls.Add(this.panProductDetails);
            this.Controls.Add(this.labOrderInsert);
            this.Controls.Add(this.panCustomDetails);
            this.Controls.Add(this.panOrderDetails);
            this.Name = "ucOrderInsert";
            this.Size = new System.Drawing.Size(894, 550);
            this.Load += new System.EventHandler(this.ucOrderInsert_Load);
            this.panOrderDetails.ResumeLayout(false);
            this.panOrderDetails.PerformLayout();
            this.panCustomDetails.ResumeLayout(false);
            this.panCustomDetails.PerformLayout();
            this.panProductDetails.ResumeLayout(false);
            this.panProductDetails.PerformLayout();
            this.panCalcDetails.ResumeLayout(false);
            this.panCalcDetails.PerformLayout();
            this.panAddProduct.ResumeLayout(false);
            this.panAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGAddedProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labOrderID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Panel panOrderDetails;
        private System.Windows.Forms.Label labOrderDetails;
        private System.Windows.Forms.Panel panCustomDetails;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label labPhoneNum;
        private System.Windows.Forms.TextBox txtEmailID;
        private System.Windows.Forms.Label labEmailID;
        private System.Windows.Forms.TextBox txtCustomName;
        private System.Windows.Forms.Label labCustomName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.Label labCustomDetails;
        private System.Windows.Forms.Label labOrderInsert;
        private System.Windows.Forms.Panel panProductDetails;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label labAmount;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label labProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label labProductName;
        private System.Windows.Forms.Label labProductDetails;
        private System.Windows.Forms.TextBox txtSearch1;
        private System.Windows.Forms.Label labSearch1;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label labQuantity;
        private System.Windows.Forms.Panel panCalcDetails;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.TextBox txtRetAmount;
        private System.Windows.Forms.Label labRetAmount;
        private System.Windows.Forms.Label labCalcDetails;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.Label labPaidAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.TextBox txtGST;
        private System.Windows.Forms.Label labGST;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label labDiscout;
        private System.Windows.Forms.TextBox txtSubTot;
        private System.Windows.Forms.Label labSubTot;
        private System.Windows.Forms.Panel panAddProduct;
        private System.Windows.Forms.Label labAddProduct;
        private System.Windows.Forms.DataGridView dGAddedProducts;
    }
}
