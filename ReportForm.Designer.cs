namespace InventoryManagementSystem
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTodaySales = new Button();
            btnMonthlySales = new Button();
            btnTopProducts = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btnTodaySales
            // 
            btnTodaySales.Location = new Point(12, 61);
            btnTodaySales.Name = "btnTodaySales";
            btnTodaySales.Size = new Size(117, 35);
            btnTodaySales.TabIndex = 0;
            btnTodaySales.Text = "Today Sales";
            btnTodaySales.UseVisualStyleBackColor = true;
            btnTodaySales.Click += btnTodaySales_Click;
            // 
            // btnMonthlySales
            // 
            btnMonthlySales.Location = new Point(145, 61);
            btnMonthlySales.Name = "btnMonthlySales";
            btnMonthlySales.Size = new Size(117, 35);
            btnMonthlySales.TabIndex = 1;
            btnMonthlySales.Text = "Monthly Sales";
            btnMonthlySales.UseVisualStyleBackColor = true;
            btnMonthlySales.Click += btnMonthlySales_Click;
            // 
            // btnTopProducts
            // 
            btnTopProducts.Location = new Point(277, 62);
            btnTopProducts.Name = "btnTopProducts";
            btnTopProducts.Size = new Size(117, 34);
            btnTopProducts.TabIndex = 2;
            btnTopProducts.Text = "Top Products";
            btnTopProducts.UseVisualStyleBackColor = true;
            btnTopProducts.Click += btnTopProducts_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 126);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(382, 201);
            dataGridView2.TabIndex = 3;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(422, 358);
            Controls.Add(dataGridView2);
            Controls.Add(btnTopProducts);
            Controls.Add(btnMonthlySales);
            Controls.Add(btnTodaySales);
            Name = "ReportForm";
            Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTodaySales;
        private Button btnMonthlySales;
        private Button btnTopProducts;
        private DataGridView dataGridView2;
    }
}