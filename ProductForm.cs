using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.ConString);
            LoadProducts();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con =
                    new(Properties.Settings.Default.ConString);

                con.Open();

                MessageBox.Show("Connected Successfully");

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con =
                    new(Properties.Settings.Default.ConString);

                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Products(ProductName,Category,Price,Quantity) VALUES (@name,@cat,@price,@qty)",
                    con);

                cmd.Parameters.AddWithValue("@name", txtProdName.Text);
                cmd.Parameters.AddWithValue("@cat", txtCategory.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@qty", txtQuantity.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Product Added Successfully!");
                LoadProducts();
                ClearFields();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadProducts()
        {
            try
            {
                SqlConnection con =
                    new(Properties.Settings.Default.ConString);

                con.Open();

                SqlDataAdapter da =
                    new SqlDataAdapter("SELECT * FROM Products", con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dataGridView1.Rows[e.RowIndex];

                txtProductid.Text =
                    row.Cells["ProductID"].Value.ToString();

                txtProdName.Text =
                    row.Cells["ProductName"].Value.ToString();

                txtCategory.Text =
                    row.Cells["Category"].Value.ToString();

                txtPrice.Text =
                    row.Cells["Price"].Value.ToString();

                txtQuantity.Text =
                    row.Cells["Quantity"].Value.ToString();
            }
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con =
                    new(Properties.Settings.Default.ConString);

                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE Products SET ProductName=@name, Category=@cat, Price=@price, Quantity=@qty WHERE ProductID=@id",
                    con);

                cmd.Parameters.AddWithValue("@id", txtProductid.Text);
                cmd.Parameters.AddWithValue("@name", txtProdName.Text);
                cmd.Parameters.AddWithValue("@cat", txtCategory.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@qty", txtQuantity.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Product Updated Successfully");

                con.Close();

                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con =
                    new(Properties.Settings.Default.ConString);

                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Products WHERE ProductID=@id",
                    con);

                cmd.Parameters.AddWithValue("@id", txtProductid.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Product Deleted Successfully");

                con.Close();

                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con =
                    new(Properties.Settings.Default.ConString);

                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Products WHERE ProductID=@id",
                    con);

                cmd.Parameters.AddWithValue("@id", txtProductid.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtProdName.Text = dr["ProductName"].ToString();
                    txtCategory.Text = dr["Category"].ToString();
                    txtPrice.Text = dr["Price"].ToString();
                    txtQuantity.Text = dr["Quantity"].ToString();
                }
                else
                {
                    MessageBox.Show("Product Not Found");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductid.Clear();
            txtProdName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();

            txtProdName.Focus();
        }

        private void ClearFields()
        {
            txtProductid.Clear();
            txtProdName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();

            txtProdName.Focus();
        }
    }
    
}




