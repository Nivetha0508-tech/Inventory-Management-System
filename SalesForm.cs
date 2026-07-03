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
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con =
                new(Properties.Settings.Default.ConString);

            con.Open();

            SqlCommand cmd =
                new SqlCommand(
                    "SELECT Price FROM Products WHERE ProductName=@name",
                    con);

            cmd.Parameters.AddWithValue("@name", cmbProduct.Text);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtPrice.Text = dr["Price"].ToString();
            }

            con.Close();
        }


        private void SalesForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadSales();
        }

        private void LoadProducts()
        {
            SqlConnection con =
                new(Properties.Settings.Default.ConString);

            con.Open();

            SqlCommand cmd =
                new SqlCommand("SELECT ProductName FROM Products", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbProduct.Items.Add(dr["ProductName"]?.ToString() ??"");
            }

            con.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal price = Convert.ToDecimal(txtPrice.Text);

            int qty = Convert.ToInt32(txtQuantity.Text);

            txtTotal.Text = (price * qty).ToString();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            SqlConnection con =
                new(Properties.Settings.Default.ConString);

            con.Open();

            // STEP 1: CHECK STOCK HERE

            SqlCommand checkStock = new SqlCommand(
                "SELECT Quantity FROM Products WHERE ProductName=@name",
                con);

            checkStock.Parameters.AddWithValue("@name", cmbProduct.Text);

            int availableStock =
                Convert.ToInt32(checkStock.ExecuteScalar());

            int requestedQty =
                Convert.ToInt32(txtQuantity.Text);

            if (requestedQty > availableStock)
            {
                MessageBox.Show("Insufficient Stock");
                con.Close();
                return;
            }

            // STEP 2: INSERT SALE

            SqlCommand cmd =
                new SqlCommand(
                @"INSERT INTO Sales
        (ProductName,Price,Quantity,TotalAmount,SaleDate)
        VALUES
        (@name,@price,@qty,@total,@date)", con);

            cmd.Parameters.AddWithValue("@name", cmbProduct.Text);
            cmd.Parameters.AddWithValue("@price", txtPrice.Text);
            cmd.Parameters.AddWithValue("@qty", txtQuantity.Text);
            cmd.Parameters.AddWithValue("@total", txtTotal.Text);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);

            cmd.ExecuteNonQuery();

            // STEP 3: REDUCE STOCK

            SqlCommand updateStock = new SqlCommand(
                @"UPDATE Products
          SET Quantity = Quantity - @qty
          WHERE ProductName = @name", con);

            updateStock.Parameters.AddWithValue("@qty", txtQuantity.Text);
            updateStock.Parameters.AddWithValue("@name", cmbProduct.Text);

            updateStock.ExecuteNonQuery();

            MessageBox.Show("Bill Generated");
            LoadSales();

            con.Close();
        }

        private void LoadSales()
        {
            try
            {
                SqlConnection con =
                    new(Properties.Settings.Default.ConString);

                con.Open();

                SqlDataAdapter da =
                    new SqlDataAdapter("SELECT * FROM Sales", con);

                DataTable dt = new();

                da.Fill(dt);

                dataGridView2.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
    

}
