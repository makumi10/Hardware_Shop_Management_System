using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SemProject
{
    public partial class ucStock : UserControl
    {
        //Code to make ucStock Visible
        private static ucStock _instance;
        public static ucStock Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucStock();
                return _instance;
            }
        }

        public ucStock()
        {
            InitializeComponent();
        }

        SqlConnection con;

        //Stock Insert
        //Method to Search For Products in Product Table

        private void butSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();

                using (con = connectObj.connect())
                {

                    using (SqlCommand cmd = new SqlCommand("SELECT Product_Name FROM Product WHERE Product_ID = @product_id"))
                    {
                        cmd.Parameters.AddWithValue("@product_id", txtProductID.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            txtProductName.Text = sdr["Product_Name"].ToString();
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        //Method that Inputs Data Into The Stock Table On the DB
        private void butAdd_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "" || txtQuantity.Text == "" || txtProductName.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Connect connectObj = new Connect();

                con = connectObj.connect();

                SqlCommand cmd = new SqlCommand("Insert into Stock (Product_ID,Quantity) values(@product_id,@quantity);", con);

                cmd.Parameters.AddWithValue("@product_id", txtProductID.Text);
                cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Stock Insertion Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Stock Insertion Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
                //Clear all the fields
                txtProductID.Clear();
                txtQuantity.Clear();
                txtProductName.Clear();
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

        private void butClear_Click(object sender, EventArgs e)
        {
            //Clear all the fields
            txtProductID.Clear();
            txtQuantity.Clear();
            txtProductName.Clear();
        }

        //Stock Update
        //Method to Search For Products in Product Table

        private void butSearch1_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();
                using (con = connectObj.connect())
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Product_Name FROM Product WHERE Product_ID = @product_id"))
                    {
                        cmd.Parameters.AddWithValue("@product_id", txtProductID1.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            txtProductName1.Text = sdr["Product_Name"].ToString();
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        //Method that Inputs Data Into The Stock Table On the DB

        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (txtProductID1.Text == "" || txtQuantity1.Text == "" || txtProductName1.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();

                SqlCommand cmd = new SqlCommand("UPDATE Stock SET Quantity = @quantity WHERE Product_ID = @product_id", con);

                cmd.Parameters.AddWithValue("@product_id", txtProductID1.Text);
                cmd.Parameters.AddWithValue("@quantity", txtQuantity1.Text);
                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Stock Update Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Stock Update Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                txtProductID1.Clear();
                txtQuantity1.Clear();
                txtProductName1.Clear();
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
        }

        private void butClear1_Click(object sender, EventArgs e)
        {
            txtProductID1.Clear();
            txtQuantity1.Clear();
            txtProductName1.Clear();
        }

        //Stock View
        //Method to Search For Products in Product Table from The DB

        private void butSearch2_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();

                using (con = connectObj.connect())
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Product_Name FROM Product WHERE Product_ID = @product_id"))
                    {
                        cmd.Parameters.AddWithValue("@product_id", txtProductID2.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            txtProductName2.Text = sdr["Product_Name"].ToString();
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Quantity FROM Stock WHERE Product_ID = @product_id"))
                    {
                        cmd.Parameters.AddWithValue("@product_id", txtProductID2.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            txtQuantity2.Text = sdr["Quantity"].ToString();
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stock not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void butClear2_Click(object sender, EventArgs e)
        {
            txtProductID2.Clear();
            txtProductName2.Clear();
            txtQuantity2.Clear();
        }

        private void butSearch3_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();
                using (con = connectObj.connect())
                {

                    using (SqlCommand cmd = new SqlCommand("SELECT Product_Name FROM Product WHERE Product_ID = @product_id"))
                    {
                        cmd.Parameters.AddWithValue("@product_id", txtProductID3.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            txtProductName3.Text = sdr["Product_Name"].ToString();
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();

                con = connectObj.connect();

                SqlCommand cmd = new SqlCommand("DELETE FROM Stock WHERE Product_ID = @product_id", con);
                cmd.Parameters.AddWithValue("@product_id", txtProductID3.Text);
                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Stock Deletion Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Stock Deletion Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
                txtProductID3.Clear();
                txtProductName3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product Not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void butClear3_Click(object sender, EventArgs e)
        {
            txtProductID3.Clear();
            txtProductName3.Clear();
        }

        private void butView_Click(object sender, EventArgs e)
        {
            try
            {
                var select = "SELECT * FROM Currently_Available_Stock;";
                Connect connectObj = new Connect();
                con = connectObj.connect();
                var dataAdapter = new SqlDataAdapter(select, con);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dGStockReports.ReadOnly = true;
                dGStockReports.DataSource = ds.Tables[0];
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
