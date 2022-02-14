using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SemProject
{
    public partial class ucOrder2 : UserControl
    {
        //Code to make ucOrderInsert Visible
        private static ucOrder2 _instance;
        public static ucOrder2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucOrder2();
                return _instance;
            }
        }

        SqlConnection con;
            
        public ucOrder2()
        {
            InitializeComponent();
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var select = "SELECT * FROM Order_View WHERE Order_ID = " + txtOrderID.Text + ";";
                Connect connectObj = new Connect();
                con = connectObj.connect();

                var dataAdapter = new SqlDataAdapter(select, con);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dgViewOrders.ReadOnly = true;
                dgViewOrders.DataSource = ds.Tables[0];
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
        //Order Delete
        //
        private void butDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();
                SqlCommand cmd = new SqlCommand("DELETE FROM MyOrder WHERE Order_ID = @order_id", con);
                cmd.Parameters.AddWithValue("@order_id", txtOrderID1.Text);
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i != 0)
                {
                    MessageBox.Show("Order Deletion Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Order Deletion Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtOrderID1.Clear();
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
            txtOrderID1.Clear();
        }

        private void butView_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();
                var select = "SELECT * FROM Order_View WHERE Date BETWEEN @start AND @end ;";

                var dataAdapter = new SqlDataAdapter(select, con);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@start", FromDate.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@end", Todate.Text);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dgViewOrders.ReadOnly = true;
                dgViewOrders.DataSource = ds.Tables[0];
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
