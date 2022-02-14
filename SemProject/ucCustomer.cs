using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SemProject
{
    public partial class ucCustomer : UserControl
    {
        //Code to make ucCustomer Visible
        private static ucCustomer _instance;
        public static ucCustomer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucCustomer();
                return _instance;
            }
        }

        private SqlConnection con;
        private static int customer_id = 1;

        public ucCustomer()
        {
            InitializeComponent();
        }

        //Customer Insert Panel
        //Method For Input Details On Table Customer on the DB

        private void butSubmit_Click(object sender, EventArgs e)
        {
            if (txtCustomName.Text == "" || txtPhoneNum.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtPhoneNum.Text.Length != 10)
            {
                MessageBox.Show("Enter valid Phone number", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();

                SqlCommand cmd = new SqlCommand("customer_in", con);

                //To execute a stored procedure

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@customer_id", txtCustomID.Text);
                cmd.Parameters.AddWithValue("@customer_name", txtCustomName.Text);
                cmd.Parameters.AddWithValue("@phone_number", Convert.ToInt64(txtPhoneNum.Text));
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                customer_id += 1;

                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Customer Insertion Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Customer Insertion Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();

                //Clear all the textboxes.

                txtCustomName.Clear();
                txtPhoneNum.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtCustomID.Clear();
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
        //Method to Clear Details on the Textboxes
        private void butClear_Click(object sender, EventArgs e)
        {
            txtCustomName.Clear();
            txtPhoneNum.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtCustomID.Clear();
        }

        //Customer Update Panel
        //Method to Update Details on Table Customer on the DB

        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (txtCustomName3.Text == "" || txtPhoneNum2.Text == "" || txtAddress2.Text == "" || txtEmail2.Text == "" || txtCustomID2.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();

                SqlCommand cmd = new SqlCommand("UPDATE CUSTOMER SET customer_name = @customer_name,address = @address,phone_number = @phone_number,email = @email WHERE customer_id = @customer_id;", con);

                cmd.Parameters.AddWithValue("@customer_id", txtCustomID2.Text);
                cmd.Parameters.AddWithValue("@customer_name", txtCustomName3.Text);
                cmd.Parameters.AddWithValue("@phone_number", Convert.ToInt64(txtPhoneNum2.Text));
                cmd.Parameters.AddWithValue("@address", txtAddress2.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail2.Text);

                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Customer Updating Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Customer Updating Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    con.Close();
            }
            //Clear the texboxes after inserting
            txtCustomName3.Clear();
            txtPhoneNum2.Clear();
            txtAddress2.Clear();
            txtEmail2.Clear();
            txtCustomID2.Clear();
        }
        //Method to Delete Details Typed on  the Textboxes
        private void butClear2_Click(object sender, EventArgs e)
        {
            //Clear the texboxes
            txtCustomName3.Clear();
            txtPhoneNum2.Clear();
            txtAddress2.Clear();
            txtEmail2.Clear();
            txtCustomID2.Clear();
        }

        //Customer Details Panel
        //Method for Searching Customer Details from The Database

        private void butSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();

                using (con = connectObj.connect())
                {

                    using (SqlCommand cmd = new SqlCommand("SELECT Customer_ID,Customer_Name,Phone_Number,Address,Email FROM Customer WHERE Customer_Name = @customer_name"))
                    {
                        cmd.Parameters.AddWithValue("@customer_name", txtCustomName2.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            txtCustomName1.Text = sdr["Customer_Name"].ToString();
                            txtPhoneNum1.Text = sdr["Phone_Number"].ToString();
                            txtAddress1.Text = sdr["Address"].ToString();
                            txtEmail1.Text = sdr["Email"].ToString();
                            txtCustomID1.Text = sdr["Customer_ID"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer Not found!!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Close the connection
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        //Method for Clearing Details Inserted on The Textboxes in Customer Search Panel
        private void butClear1_Click(object sender, EventArgs e)
        {
            //Clear all the textboxes
            txtPhoneNum1.Clear();
            txtAddress1.Clear();
            txtEmail1.Clear();
            txtCustomName1.Clear();
            txtCustomName2.Clear();
            txtCustomID1.Clear();
        }

        //Customer Delete Panel
        //Method for searching For Customer on the Database

        private void butSearch1_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();
                using (con = connectObj.connect())
                {

                    using (SqlCommand cmd = new SqlCommand("SELECT Customer_ID FROM Customer WHERE Customer_Name = @customer_name"))
                    {
                        cmd.Parameters.AddWithValue("@customer_name", txtCustomName4.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            txtCustomID3.Text = sdr["Customer_ID"].ToString();
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer not found", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        //Method for Deleting Details From the Database
        private void butDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();

                SqlCommand cmd = new SqlCommand("DELETE FROM Customer WHERE Customer_ID = @customer_id", con);
                cmd.Parameters.AddWithValue("@customer_id", txtCustomID3.Text);
                int i = cmd.ExecuteNonQuery();

                //If count is equal to 1, than show frmMain form
                if (i != 0)
                {
                    MessageBox.Show("Customer Deletion Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Customer Deletion Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtCustomName4.Clear();
                txtCustomID3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer Not found", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Close the connection to the DataBase
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
                Connect connectObj = new Connect();
                con = connectObj.connect();
                var select = "SELECT * FROM Customer";

                var dataAdapter = new SqlDataAdapter(select, con);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dGCustomReports.ReadOnly = true;
                dGCustomReports.DataSource = ds.Tables[0];
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
