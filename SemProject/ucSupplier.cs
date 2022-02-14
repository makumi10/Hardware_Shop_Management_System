using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SemProject
{
    public partial class ucSupplier : UserControl
    {
        //Code to make ucSupply Visible
        private static ucSupplier _instance;
        public static ucSupplier Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSupplier();
                return _instance;
            }
        }
        
        SqlConnection con;

        public ucSupplier()
        {
            InitializeComponent();
        }

        //Supplier Insert
        //Method for Inserting Data on the Table Supplier On The DB

        private void butSubmit_Click(object sender, EventArgs e)
        {
            if (txtSupplierName.Text == "" || txtAddress.Text == "" || txtPhoneNum.Text == "" || txtEmail.Text == "" || txtSupplierID.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPhoneNum.Text.Length != 10)
            {
                MessageBox.Show("Enter valid Phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();

                SqlCommand cmd = new SqlCommand("Insert into Supplier (Supplier_ID,Supplier_Name,Address,Phone_Number,Email) values(@supplier_id,@supplier_name,@address,@phone_number,@email);", con);

                cmd.Parameters.AddWithValue("@supplier_id", txtSupplierID.Text);
                cmd.Parameters.AddWithValue("@supplier_name", txtSupplierName.Text);
                cmd.Parameters.AddWithValue("@phone_number", Convert.ToInt64(txtPhoneNum.Text));
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Supplier Inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Supplier Insertion Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();

                //Clear all the fields.
                txtSupplierName.Clear();
                txtAddress.Clear();
                txtPhoneNum.Clear();
                txtEmail.Clear();
                txtSupplierID.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed!! Try with Different ID!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        //Method To Delete Inputs On The Textbox
        private void butClear_Click(object sender, EventArgs e)
        {
            txtSupplierName.Clear();
            txtAddress.Clear();
            txtPhoneNum.Clear();
            txtEmail.Clear();
            txtSupplierID.Clear();
        }

        //Supplier Update
        //Method for Updating Data on the Table Supplier On The DB

        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (txtSupplierName1.Text == "" || txtAddress1.Text == "" || txtPhoneNum1.Text == "" || txtEmail1.Text == "" || txtSupplierID1.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();

                SqlCommand cmd = new SqlCommand("UPDATE Supplier SET Supplier_Name = @supplier_name,Address = @address,Phone_Number = @phone_number,Email = @email WHERE supplier_id = @supplier_id;", con);

                cmd.Parameters.AddWithValue("@supplier_id", txtSupplierID1.Text);
                cmd.Parameters.AddWithValue("@supplier_name", txtSupplierName1.Text);
                cmd.Parameters.AddWithValue("@phone_number", Convert.ToInt64(txtPhoneNum1.Text));
                cmd.Parameters.AddWithValue("@address", txtAddress1.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail1.Text);

                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Supplier Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Supplier Update Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Supplier not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            txtSupplierName1.Clear();
            txtAddress1.Clear();
            txtPhoneNum1.Clear();
            txtEmail1.Clear();
            txtSupplierID1.Clear();
        }
        //Method To Delete Inputs On The Textbox
        private void butClear2_Click(object sender, EventArgs e)
        {
            txtSupplierName1.Clear();
            txtAddress1.Clear();
            txtPhoneNum1.Clear();
            txtEmail1.Clear();
            txtSupplierID1.Clear();
        }

        //Supplier Details
        //Method for Searching & Viewing Data on the Table Supplier On The DB

        private void butSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();

                using (con = connectObj.connect())
                {

                    using (SqlCommand cmd = new SqlCommand("SELECT Supplier_ID,Supplier_Name,Phone_Number,Address,Email FROM Supplier WHERE Supplier_Name = @supplier_name"))
                    {
                        cmd.Parameters.AddWithValue("@supplier_name", txtSupplierName2.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            txtSupplierID2.Text = sdr["Supplier_ID"].ToString();
                            txtSupplierName3.Text = sdr["Supplier_Name"].ToString();
                            txtPhoneNum2.Text = sdr["Phone_Number"].ToString();
                            txtAddress2.Text = sdr["Address"].ToString();
                            txtEmail2.Text = sdr["Email"].ToString();
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Supplier not Found!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        //Method To Delete Output On The Textbox
        private void butClear1_Click(object sender, EventArgs e)
        {
            txtSupplierName2.Clear();
            txtSupplierName3.Clear();
            txtAddress2.Clear();
            txtPhoneNum2.Clear();
            txtEmail2.Clear();
            txtSupplierID2.Clear();
        }

        //Supplier Details
        //Method for Searching for Data on the Table Supplier On The DB

        private void butSearch1_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();

                using (con = connectObj.connect())
                {

                    using (SqlCommand cmd = new SqlCommand("SELECT Supplier_ID FROM Supplier WHERE Supplier_Name = @supplier_name"))
                    {
                        cmd.Parameters.AddWithValue("@supplier_name", txtSupplierName4.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            txtSupplierID3.Text = sdr["Supplier_ID"].ToString();
                        }

                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Supplier not found");
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
                var select = "SELECT * FROM Supplier";
                Connect connectObj = new Connect();
                con = connectObj.connect();
                var dataAdapter = new SqlDataAdapter(select, con);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dGSupplierReports.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
                dataAdapter.Fill(ds);
                dGSupplierReports.ReadOnly = true;
                dGSupplierReports.DataSource = ds.Tables[0];
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
