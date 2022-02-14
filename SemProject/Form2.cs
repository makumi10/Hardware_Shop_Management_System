using System;
using System.Windows.Forms;

namespace SemProject
{
    public partial class Form2 : Form
    {
        private static Form2 _obj;

        public Form2()
        {
            InitializeComponent();
        }
        //Functions For Log Out  & Closing the Application
        private void picExit_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            this.Hide();
            _ = newForm.ShowDialog();
        }

        private void panExit_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            this.Hide();
            _ = newForm.ShowDialog();
        }

        private void labExit_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            this.Hide();
            _ = newForm.ShowDialog();
        }

        // Method For Terminating The Form Completely
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Methods For Opening ucCustomer user Control

        private void panCustomer_Click(object sender, EventArgs e)
        {
            butOrder2.Visible = false;

            if (!panContainer.Controls.Contains(ucCustomer.Instance))
            {
                panContainer.Controls.Add(ucCustomer.Instance);
                ucCustomer.Instance.Dock = DockStyle.Fill;
                ucCustomer.Instance.BringToFront();
            }
            else
                ucCustomer.Instance.BringToFront();
        }

        private void labCustomer_Click(object sender, EventArgs e)
        {
            butOrder2.Visible = false;

            if (!panContainer.Controls.Contains(ucCustomer.Instance))
            {
                panContainer.Controls.Add(ucCustomer.Instance);
                ucCustomer.Instance.Dock = DockStyle.Fill;
                ucCustomer.Instance.BringToFront();
            }
            else
                ucCustomer.Instance.BringToFront();
        }

        // Methods For Opening ucProduct user Control

        private void panProduct_Click(object sender, EventArgs e)
        {
            butOrder2.Visible = false;

            if (!panContainer.Controls.Contains(ucProduct.Instance))
            {
                panContainer.Controls.Add(ucProduct.Instance);
                ucProduct.Instance.Dock = DockStyle.Fill;
                ucProduct.Instance.BringToFront();
            }
            else
                ucProduct.Instance.BringToFront();
        }

        private void labProduct_Click(object sender, EventArgs e)
        {
            butOrder2.Visible = false;

            if (!panContainer.Controls.Contains(ucProduct.Instance))
            {
                panContainer.Controls.Add(ucProduct.Instance);
                ucProduct.Instance.Dock = DockStyle.Fill;
                ucProduct.Instance.BringToFront();
            }
            else
                ucProduct.Instance.BringToFront();
        }

        // Methods For Opening ucSupplier user Control

        private void labSupplier_Click(object sender, EventArgs e)
        {
            butOrder2.Visible = false;

            if (!panContainer.Controls.Contains(ucSupplier.Instance))
            {
                panContainer.Controls.Add(ucSupplier.Instance);
                ucSupplier.Instance.Dock = DockStyle.Fill;
                ucSupplier.Instance.BringToFront();
            }
            else
                ucSupplier.Instance.BringToFront();
        }

        private void panSupplier_Click(object sender, EventArgs e)
        {
            butOrder2.Visible = false;

            if (!panContainer.Controls.Contains(ucSupplier.Instance))
            {
                panContainer.Controls.Add(ucSupplier.Instance);
                ucSupplier.Instance.Dock = DockStyle.Fill;
                ucSupplier.Instance.BringToFront();
            }
            else
                ucSupplier.Instance.BringToFront();
        }

        // Methods For Opening ucOrderInsert user Control

        private void panOrder_Click(object sender, EventArgs e)
        {
            butOrder2.Visible = true;

            if (!panContainer.Controls.Contains(ucOrderInsert.Instance))
            {
                panContainer.Controls.Add(ucOrderInsert.Instance);
                ucOrderInsert.Instance.Dock = DockStyle.Fill;
                ucOrderInsert.Instance.BringToFront();
            }
            else
                ucOrderInsert.Instance.BringToFront();
        }

        private void labOrder_Click(object sender, EventArgs e)
        {
            butOrder2.Visible = true;

            if (!panContainer.Controls.Contains(ucOrderInsert.Instance))
            {
                panContainer.Controls.Add(ucOrderInsert.Instance);
                ucOrderInsert.Instance.Dock = DockStyle.Fill;
                ucOrderInsert.Instance.BringToFront();
            }
            else
                ucOrderInsert.Instance.BringToFront();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            butOrder2.Visible = false;

            if (!panContainer.Controls.Contains(ucHome.Instance))
            {
                panContainer.Controls.Add(ucHome.Instance);
                ucHome.Instance.Dock = DockStyle.Fill;
                ucHome.Instance.BringToFront();
            }
            else
                ucHome.Instance.BringToFront();
        }

        private void butOrder2_Click(object sender, EventArgs e)
        {
            if (!panContainer.Controls.Contains(ucOrder2.Instance))
            {
                panContainer.Controls.Add(ucOrder2.Instance);
                ucOrder2.Instance.Dock = DockStyle.Fill;
                ucOrder2.Instance.BringToFront();
            }
            else
                ucOrder2.Instance.BringToFront();
        }

        private void labStock_Click(object sender, EventArgs e)
        {
            butOrder2.Visible = false;

            if (!panContainer.Controls.Contains(ucStock.Instance))
            {
                panContainer.Controls.Add(ucStock.Instance);
                ucStock.Instance.Dock = DockStyle.Fill;
                ucStock.Instance.BringToFront();
            }
            else
                ucStock.Instance.BringToFront();
        }

        private void panStock_Click(object sender, EventArgs e)
        {
            butOrder2.Visible = false;

            if (!panContainer.Controls.Contains(ucStock.Instance))
            {
                panContainer.Controls.Add(ucStock.Instance);
                ucStock.Instance.Dock = DockStyle.Fill;
                ucStock.Instance.BringToFront();
            }
            else
                ucStock.Instance.BringToFront();
        }

        private void panHome_Click(object sender, EventArgs e)
        {
            butOrder2.Visible = false;

            if (!panContainer.Controls.Contains(ucHome.Instance))
            {
                panContainer.Controls.Add(ucHome.Instance);
                ucHome.Instance.Dock = DockStyle.Fill;
                ucHome.Instance.BringToFront();
            }
            else
                ucHome.Instance.BringToFront();
        }

        private void labHome_Click(object sender, EventArgs e)
        {
            butOrder2.Visible = false;

            if (!panContainer.Controls.Contains(ucHome.Instance))
            {
                panContainer.Controls.Add(ucHome.Instance);
                ucHome.Instance.Dock = DockStyle.Fill;
                ucHome.Instance.BringToFront();
            }
            else
                ucHome.Instance.BringToFront();
        }
    }
}