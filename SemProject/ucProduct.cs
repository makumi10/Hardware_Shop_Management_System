using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SemProject
{
    public partial class ucProduct : UserControl
    {
        //Code to make ucProduct Visible
        private static ucProduct _instance;
        public static ucProduct Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucProduct();
                return _instance;
            }
        }

        SqlConnection con;

        public ucProduct()
        {
            InitializeComponent();
        }

        //Product Insert
        //Method for Inserting Data on the Table Products On The DB

        private void butSubmit_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" || txtSupplierID.Text == "" || txtAmount.Text == "" || txtProductID.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();

                SqlCommand cmd = new SqlCommand("Insert into Product (Product_ID,Product_Name,Amount,Supplier_ID) values(@product_id,@product_name,@amount,@supplier_id);", con);

                cmd.Parameters.AddWithValue("@product_id", txtProductID.Text);
                cmd.Parameters.AddWithValue("@product_name", txtProductName.Text);

                cmd.Parameters.AddWithValue("@supplier_id", txtSupplierID.Text);
                cmd.Parameters.AddWithValue("@amount", txtAmount.Text);

                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Product Insertion Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Product Insertion Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                con.Close();

                txtProductName.Clear();
                txtSupplierID.Clear();
                txtAmount.Clear();
                txtProductID.Clear();
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
        }
        //Method to Clear Details Typed On The TextBox
        private void butClear_Click(object sender, EventArgs e)
        {
            txtProductName.Clear();
            txtSupplierID.Clear();
            txtAmount.Clear();
            txtProductID.Clear();
        }

        //Product Update
        //Method for Updating Data on the Table Products On The DB

        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (txtProductName1.Text == "" || txtProductID1.Text == "" || txtSupplierID1.Text == "" || txtAmount1.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Connect conObj = new Connect();
                con = conObj.connect();
                SqlCommand cmd = new SqlCommand("UPDATE Product SET Product_Name = @product_name,Amount = @amount,Supplier_ID = @supplier_id WHERE Product_ID = @product_id;", con);

                cmd.Parameters.AddWithValue("@product_id", txtProductID1.Text);
                cmd.Parameters.AddWithValue("@product_name", txtProductName1.Text);
                cmd.Parameters.AddWithValue("@supplier_id", txtSupplierID1.Text);
                cmd.Parameters.AddWithValue("@amount", txtAmount1.Text);
                //cid += 1;
                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Product Updation Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Product Updation Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            txtProductName1.Clear();
            txtProductID1.Clear();
            txtSupplierID1.Clear();
            txtAmount1.Clear();
        }
        //Method to Clear Details Typed On The TextBox
        private void butClear2_Click(object sender, EventArgs e)
        {
            txtProductName1.Clear();
            txtProductID1.Clear();
            txtSupplierID1.Clear();
            txtAmount1.Clear();
        }

        //Product Details
        //Method for Viewing Data on the Table Products On The DB

        private void butSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();

                using (con = connectObj.connect())
                {

                    using (SqlCommand cmd = new SqlCommand("SELECT Product_ID,Product_Name,Amount,Supplier_ID FROM Product WHERE Product_Name = @product_name"))
                    {
                        cmd.Parameters.AddWithValue("@product_name", txtProductName2.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            txtProductName3.Text = sdr["Product_Name"].ToString();
                            txtSupplierID2.Text = sdr["Supplier_ID"].ToString();
                            txtAmount2.Text = sdr["Amount"].ToString();
                            txtProductID2.Text = sdr["Product_ID"].ToString();
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product not found!!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        //Method to Clear the Output Details On The TextBox
        private void butClear1_Click(object sender, EventArgs e)
        {
            txtProductName2.Clear();
            txtProductName3.Clear();
            txtProductID2.Clear();
            txtSupplierID2.Clear();
            txtAmount2.Clear();
        }

        //Product Details
        //Method for Searching Data on the Table Products On The  DB
        //
        private void butSearch1_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();

                using (con = connectObj.connect())
                {

                    using (SqlCommand cmd = new SqlCommand("SELECT Product_ID FROM Product WHERE Product_Name = @product_name;"))
                    {
                        cmd.Parameters.AddWithValue("@product_name", txtProductName4.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            txtProductID3.Text = sdr["Product_ID"].ToString();
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product not found", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Method To Delete Details From Table Product In the DB

        private void butDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();
                SqlCommand cmd = new SqlCommand("DELETE FROM Product WHERE Product_ID = @product_id", con);
                cmd.Parameters.AddWithValue("@product_id", txtProductID3.Text);
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i != 0)
                {
                    MessageBox.Show("Product Deletion Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Product Deletion Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtProductName4.Clear();
                txtProductID3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Product Not found", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void butView_Click(object sender, EventArgs e)
        {
            try
            {
                var select = "SELECT * FROM Product_View";
                Connect connectObj = new Connect();
                con = connectObj.connect();

                var dataAdapter = new SqlDataAdapter(select, con);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dGProductReports.ReadOnly = true;
                dGProductReports.DataSource = ds.Tables[0];
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
        }
    }
}
