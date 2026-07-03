namespace InventoryManagementSystem
{
    partial class MainForm
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
            btnproducts = new Button();
            btnsales = new Button();
            btnInventory = new Button();
            btnreports = new Button();
            btnlogout = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnproducts
            // 
            btnproducts.Location = new Point(170, 53);
            btnproducts.Name = "btnproducts";
            btnproducts.Size = new Size(85, 32);
            btnproducts.TabIndex = 0;
            btnproducts.Text = "Products";
            btnproducts.UseVisualStyleBackColor = true;
            btnproducts.Click += btnproducts_Click;
            // 
            // btnsales
            // 
            btnsales.Location = new Point(170, 106);
            btnsales.Name = "btnsales";
            btnsales.Size = new Size(85, 32);
            btnsales.TabIndex = 1;
            btnsales.Text = "Sales";
            btnsales.UseVisualStyleBackColor = true;
            btnsales.Click += btnsales_Click;
            // 
            // btnInventory
            // 
            btnInventory.Location = new Point(170, 160);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(85, 32);
            btnInventory.TabIndex = 2;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnreports
            // 
            btnreports.Location = new Point(170, 214);
            btnreports.Name = "btnreports";
            btnreports.Size = new Size(85, 32);
            btnreports.TabIndex = 3;
            btnreports.Text = "Reports";
            btnreports.UseVisualStyleBackColor = true;
            btnreports.Click += btnreports_Click;
            // 
            // btnlogout
            // 
            btnlogout.Location = new Point(170, 265);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(85, 32);
            btnlogout.TabIndex = 4;
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 26);
            textBox1.TabIndex = 5;
            textBox1.Text = "DASHBOARD\r\n\r\n";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(404, 332);
            Controls.Add(textBox1);
            Controls.Add(btnlogout);
            Controls.Add(btnreports);
            Controls.Add(btnInventory);
            Controls.Add(btnsales);
            Controls.Add(btnproducts);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnproducts;
        private Button btnsales;
        private Button btnInventory;
        private Button btnreports;
        private Button btnlogout;
        private TextBox textBox1;
    }
}