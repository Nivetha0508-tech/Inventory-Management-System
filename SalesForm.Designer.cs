namespace InventoryManagementSystem
{
    partial class SalesForm
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
            lblProduct = new Label();
            cmbProduct = new ComboBox();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblTotal = new Label();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            btnBill = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(72, 42);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(57, 19);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Product";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(160, 39);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(121, 27);
            cmbProduct.TabIndex = 1;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(72, 91);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(38, 19);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(72, 143);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(63, 19);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity";
            lblQuantity.Click += lblQuantity_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(72, 196);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 19);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total";
            lblTotal.Click += lblTotal_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(160, 91);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 26);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(160, 143);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 26);
            txtQuantity.TabIndex = 6;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(160, 196);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 26);
            txtTotal.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(69, 273);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(79, 36);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnBill
            // 
            btnBill.Location = new Point(173, 273);
            btnBill.Name = "btnBill";
            btnBill.Size = new Size(108, 36);
            btnBill.TabIndex = 9;
            btnBill.Text = "Generate Bill";
            btnBill.UseVisualStyleBackColor = true;
            btnBill.Click += btnBill_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(312, 39);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(339, 270);
            dataGridView2.TabIndex = 10;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(684, 356);
            Controls.Add(dataGridView2);
            Controls.Add(btnBill);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotal);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(lblTotal);
            Controls.Add(lblQuantity);
            Controls.Add(lblPrice);
            Controls.Add(cmbProduct);
            Controls.Add(lblProduct);
            Name = "SalesForm";
            Text = "SalesForm";
            Load += SalesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduct;
        private ComboBox cmbProduct;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblTotal;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtTotal;
        private Button btnCalculate;
        private Button btnBill;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dataGridView2;
    }
}