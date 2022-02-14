using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SemProject
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        private static int sign_up = 1;

        public Form1()
        {
            InitializeComponent();
        }
        private void butSignIn_Click(object sender, EventArgs e)
        {
            /* This method is called on click on login button */
            if (txtUser1.Text == "" || this.txtPass1.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = txtUser1.Text;
            string password = this.txtPass1.Text;

            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();

                SqlCommand cmd = new SqlCommand("Select * from Login where UserName=@username and Password=@password", con);

                cmd.Parameters.AddWithValue("@username", txtUser1.Text);
                cmd.Parameters.AddWithValue("@password", this.txtPass1.Text);

                SqlDataAdapter adapt = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adapt.Fill(ds);

                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form

                if (count == 1)
                {
                    MessageBox.Show("Login Successful! Welcome Admin", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form2 newform = new Form2();
                    this.Hide();
                    _ = newform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid UserName or Password", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void linkLabSignIn_Click(object sender, EventArgs e)
        {
            panSignUp.Visible = false;
            panSignIn.Visible = true;
        }

        private void linkLabSignUp_Click(object sender, EventArgs e)
        {
            panSignUp.Visible = true;
            panSignIn.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panSignUp.Visible = false;
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
        }

        private void txtUser1_Click(object sender, EventArgs e)
        {
            txtUser1.Clear();
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
            txtPass.PasswordChar = '•';
        }

        private void txtPass1_Click(object sender, EventArgs e)
        {
            txtPass1.Clear();
            txtPass.PasswordChar = '•';
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '•';
        }

        private void txtPass1_TextChanged(object sender, EventArgs e)
        {
            txtPass1.PasswordChar = '•';
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butSignUp_Click(object sender, EventArgs e)
        {
            /* This method is called on click on login button */
            if (txtUser.Text == "" || this.txtPass.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = txtUser.Text;
            string password = this.txtPass.Text;

            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();
                SqlCommand cmd = new SqlCommand("sign_up", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", txtUser.Text);
                cmd.Parameters.AddWithValue("@password", this.txtPass.Text);
                sign_up += 1;

                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Sign Up Successful! You Are now an Admin", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    panSignUp.Visible = false;
                    panSignIn.Visible = true;
                }
                else
                {
                    MessageBox.Show("Sign Up Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
    }
}
