using System.Windows.Forms;

namespace SemProject
{
    //Code to make ucHome Visible
    
    
    public partial class ucHome : UserControl
    {
        private static ucHome _instance;
        public static ucHome Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucHome();
                return _instance;
            }
        }
        public ucHome()
        {
            InitializeComponent();
        }

        private void picBackground_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, System.EventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void label3_Click(object sender, System.EventArgs e)
        {

        }
    }
}
