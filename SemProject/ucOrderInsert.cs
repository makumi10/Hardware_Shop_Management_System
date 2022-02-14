using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SemProject
{
    public partial class ucOrderInsert : UserControl
    {
        //Code to make ucOrderInsert Visible
        private static ucOrderInsert _instance;
        public static ucOrderInsert Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucOrderInsert();
                return _instance;
            }
        }

        SqlConnection con;
        DataTable transactionDT = new DataTable();
        String customer_id = "";

        public ucOrderInsert()
        {
            InitializeComponent();
        }

        //Customer Details
        //Method To Search for Customer Details On The DB

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String keyword = txtSearch.Text;
            if (keyword == "")
            {
                txtSearch.Clear();
                txtCustomName.Clear();
                txtPhoneNum.Clear();
                txtAddress.Clear();
                txtEmailID.Clear();
                return;
            }

            Connect connectObj = new Connect();
            con = connectObj.connect();
            DataTable dt = new DataTable();

            try
            {
                String sql = "SELECT Customer_Name,Address,Phone_Number,Email,Customer_ID FROM Customer WHERE Customer_ID LIKE '%" + keyword + "%' OR Customer_Name LIKE '%" + keyword + "%';";
                SqlDataAdapter adpt = new SqlDataAdapter(sql, con);

                adpt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtCustomName.Text = dt.Rows[0]["Customer_Name"].ToString();
                    txtPhoneNum.Text = dt.Rows[0]["Phone_Number"].ToString();
                    txtAddress.Text = dt.Rows[0]["Address"].ToString();
                    txtEmailID.Text = dt.Rows[0]["Email"].ToString();
                    customer_id = dt.Rows[0]["Customer_ID"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Product Details
        //Method to Search Product Details for The DB

        private void txtSearch1_TextChanged(object sender, EventArgs e)
        {
            String keyword = txtSearch1.Text;
            if (keyword == "")
            {
                return;
            }
            Connect connectObj = new Connect();
            con = connectObj.connect();

            DataTable dt = new DataTable();

            try
            {
                String sql = "SELECT Product_ID,Product_Name,Amount FROM Product WHERE Product_ID LIKE '%" + keyword + "%' OR Product_Name LIKE '%" + keyword + "%';";
                SqlDataAdapter adpt = new SqlDataAdapter(sql, con);

                adpt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtProductName.Text = dt.Rows[0]["Product_Name"].ToString();
                    txtProductID.Text = dt.Rows[0]["Product_ID"].ToString();
                    txtAmount.Text = dt.Rows[0]["Amount"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            String PNAME = txtProductName.Text;
            String PID = txtProductID.Text;
            if (txtQuantity.Text == "" || txtProductName.Text == "" || txtProductID.Text == "")
            {
                MessageBox.Show("Enter the Quantity!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();
                SqlCommand cmd = new SqlCommand("Select * from Stock where Product_ID =@product_id and Quantity >= @quantity", con);

                cmd.Parameters.AddWithValue("@product_id", txtProductID.Text);
                cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;

                if (count != 1)
                {
                    MessageBox.Show("Check stock!!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            decimal quantity = decimal.Parse(txtQuantity.Text);
            decimal amount = decimal.Parse(txtAmount.Text);
            decimal total = amount * quantity;
            decimal subtotal = decimal.Parse(txtSubTot.Text);

            subtotal += total;

            if (PNAME == "")
            {
                MessageBox.Show("select a product and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                transactionDT.Rows.Add(PNAME, PID, quantity, amount, total);
                dGAddedProducts.DataSource = transactionDT;
                txtSubTot.Text = subtotal.ToString();

                if (txtProductID.Text == "" || txtOrderID.Text == "")
                {
                    MessageBox.Show("Please provide all the details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txtProductName.Clear();
                txtProductID.Clear();
                txtQuantity.Text = "0";
                txtAmount.Text = "0";

            }
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            //Create the orders 
            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();
                SqlCommand cmd = new SqlCommand("Insert into MyOrder (Order_ID,Customer_ID,Date,Amount) values(@order_id,@customer_id,@date,@amount);", con);

                cmd.Parameters.AddWithValue("@order_id", txtOrderID.Text);
                cmd.Parameters.AddWithValue("@customer_id", customer_id);
                cmd.Parameters.AddWithValue("@date", date.Text);
                cmd.Parameters.AddWithValue("@amount", txtTotal.Text);

                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Order Insertion Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Order Insertion Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            //Insert into orderDetails 
            try
            {
                int j;

                Connect connectObj = new Connect();
                con = connectObj.connect();

                for (int i = 0; i < transactionDT.Rows.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand("Insert into Order_Details (Order_ID,Product_ID,Quantity) values(@order_id,@product_id,@quantity);", con);

                    cmd.Parameters.AddWithValue("@order_id", txtOrderID.Text);
                    cmd.Parameters.AddWithValue("@product_id", transactionDT.Rows[i]["Product_ID"].ToString());
                    cmd.Parameters.AddWithValue("@quantity", transactionDT.Rows[i]["Quantity"].ToString());

                    j = cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            //Update stock table after creating order
            try
            {
                int j;
                Connect connectObj = new Connect();
                con = connectObj.connect();

                for (int i = 0; i < transactionDT.Rows.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Stock SET Quantity = Quantity - @quantity WHERE Product_ID = @product_id;", con);

                    cmd.Parameters.AddWithValue("@product_id", transactionDT.Rows[i]["Product_ID"].ToString());
                    cmd.Parameters.AddWithValue("@quantity", transactionDT.Rows[i]["Quantity"].ToString());

                    j = cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

            //Clear all the fields.
            txtSearch.Clear();
            txtCustomName.Clear();
            txtPhoneNum.Clear();
            txtAddress.Clear();
            txtEmailID.Clear();
            txtSearch1.Clear();
            txtProductName.Clear();
            txtProductID.Clear();
            txtTotal.Text = "0";
            txtSubTot.Clear();
            txtDiscount.Text = "0";
            txtGST.Clear();
            txtPaidAmount.Clear();
            txtRetAmount.Clear();
            txtQuantity.Text = "0";
            txtAmount.Text = "0";
            dGAddedProducts.DataSource = null;
        }

        private void ucOrderInsert_Load(object sender, EventArgs e)
        {
            transactionDT.Columns.Add("Product_Name");
            transactionDT.Columns.Add("Product_ID");
            transactionDT.Columns.Add("Quantity");
            transactionDT.Columns.Add("Amount");
            transactionDT.Columns.Add("Total");
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtSubTot.Text == "")
            {
                return;
            }
            if (txtDiscount.Text == "")
            {
                MessageBox.Show("Add value of Discount first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal discount = decimal.Parse(txtDiscount.Text);
                decimal subtotal = decimal.Parse(txtSubTot.Text);
                decimal grandTotal = ((100 - discount) / 100) * subtotal;
                txtTotal.Text = grandTotal.ToString();
            }
        }

        private void txtGST_TextChanged(object sender, EventArgs e)
        {
            if (txtTotal.Text == "")
            {
                MessageBox.Show("Calcuate Grand total after discount", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtTotal.Text == "" || txtGST.Text == "")
                {
                    return;
                }
                decimal previousGT = decimal.Parse(txtTotal.Text);
                decimal gst = decimal.Parse(txtGST.Text);
                decimal GTwithGst = ((100 + gst) / 100) * previousGT;
                txtTotal.Text = GTwithGst.ToString();
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtPaidAmount.Text == "" || txtTotal.Text == "")
            {
                return;
            }
            decimal paidamt = decimal.Parse(txtPaidAmount.Text);
            decimal gtamt = decimal.Parse(txtTotal.Text);

            if (paidamt < gtamt)
            {
                //MessageBox.Show("Please check the total amount again");
                return;
            }
            decimal retamt = paidamt - gtamt;
            txtRetAmount.Text = retamt.ToString();
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            //Clear all the fields.
            txtSearch.Clear();
            txtCustomName.Clear();
            txtPhoneNum.Clear();
            txtAddress.Clear();
            txtEmailID.Clear();
            txtSearch1.Clear();
            txtProductName.Clear();
            txtProductID.Clear();
            txtTotal.Text = "0";
            txtSubTot.Clear();
            txtDiscount.Text = "0";
            txtGST.Clear();
            txtPaidAmount.Clear();
            txtRetAmount.Clear();
            txtQuantity.Text = "0";
            txtAmount.Text = "0";
            dGAddedProducts.DataSource = null;
        }
    }
}
