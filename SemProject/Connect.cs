using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SemProject
{
    public class Connect
    {
        SqlConnection con = new SqlConnection(SemProject.Properties.Settings.Default.SemProjectConnectionString);

        public static string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SemProject.mdf;Integrated Security=True";
        public  SqlConnection connect()
        {
            try
            {
                con = new SqlConnection(cs);
                con.Open();
                return con;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void closeConnection()
        {
            if(con != null)
            {
                con.Close();
            }
        }

        /*internal void Connect()
        {
            throw new NotImplementedException();
        }*/
    }
}
