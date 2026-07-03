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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void btnTodaySales_Click(object sender, EventArgs e)
        {
            SqlConnection con =
                new(Properties.Settings.Default.ConString);

            con.Open();

            SqlDataAdapter da =
                new SqlDataAdapter(
                @"SELECT *
          FROM Sales
          WHERE CAST(SaleDate AS DATE)
          = CAST(GETDATE() AS DATE)",
                con);

            DataTable dt = new();

            da.Fill(dt);

            dataGridView2.DataSource = dt;

            con.Close();
        }

        private void btnMonthlySales_Click(object sender, EventArgs e)
        {
            SqlConnection con =
                new(Properties.Settings.Default.ConString);

            con.Open();

            SqlDataAdapter da =
                new SqlDataAdapter(
                @"SELECT *
          FROM Sales
          WHERE MONTH(SaleDate)=MONTH(GETDATE())
          AND YEAR(SaleDate)=YEAR(GETDATE())",
                con);

            DataTable dt = new();

            da.Fill(dt);

            dataGridView2.DataSource = dt;

            con.Close();
        }

        private void btnTopProducts_Click(object sender, EventArgs e)
        {
            SqlConnection con =
                new(Properties.Settings.Default.ConString);

            con.Open();

            SqlDataAdapter da =
                new SqlDataAdapter(
                @"SELECT ProductName,
                 SUM(Quantity) AS TotalSold
          FROM Sales
          GROUP BY ProductName
          ORDER BY TotalSold DESC",
                con);

            DataTable dt = new();

            da.Fill(dt);

            dataGridView2.DataSource = dt;

            con.Close();
        }
    }

}

