using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckLowStock();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnproducts_Click(object sender, EventArgs e)
        {
            ProductForm frm = new ProductForm();
            frm.Show();
        }

        private void btnsales_Click(object sender, EventArgs e)
        {
            SalesForm frm = new SalesForm();
            frm.Show();
        }

        private void CheckLowStock()
        {
            try
            {
                SqlConnection con =
                    new(Properties.Settings.Default.ConString);

                con.Open();

                SqlCommand cmd =
                    new SqlCommand(
                    "SELECT COUNT(*) FROM Products WHERE Quantity < 10",
                    con);

                int count =
                    Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show(
                        "Warning! Some products are low in stock.");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvLowStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ProductForm frm = new ProductForm();
            frm.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.Show();

            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Form1 frm = new Form1();

                frm.Show();

                this.Close();
            }
        }
    }
}
