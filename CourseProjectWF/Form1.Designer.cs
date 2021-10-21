
namespace CourseProjectWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Products = new System.Windows.Forms.TabPage();
            this.ProductsTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Bid = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Products.SuspendLayout();
            this.ProductsTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1589, 730);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Products);
            this.tabControl1.Controls.Add(this.Bid);
            this.tabControl1.Location = new System.Drawing.Point(25, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1626, 820);
            this.tabControl1.TabIndex = 1;
            // 
            // Products
            // 
            this.Products.Controls.Add(this.ProductsTab);
            this.Products.Location = new System.Drawing.Point(4, 34);
            this.Products.Name = "Products";
            this.Products.Padding = new System.Windows.Forms.Padding(3);
            this.Products.Size = new System.Drawing.Size(1618, 782);
            this.Products.TabIndex = 0;
            this.Products.Text = "Products";
            this.Products.UseVisualStyleBackColor = true;
            // 
            // ProductsTab
            // 
            this.ProductsTab.Controls.Add(this.tabPage1);
            this.ProductsTab.Location = new System.Drawing.Point(6, 6);
            this.ProductsTab.Name = "ProductsTab";
            this.ProductsTab.SelectedIndex = 0;
            this.ProductsTab.Size = new System.Drawing.Size(1606, 828);
            this.ProductsTab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1598, 790);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ALL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Bid
            // 
            this.Bid.Location = new System.Drawing.Point(4, 34);
            this.Bid.Name = "Bid";
            this.Bid.Padding = new System.Windows.Forms.Padding(3);
            this.Bid.Size = new System.Drawing.Size(1618, 840);
            this.Bid.TabIndex = 1;
            this.Bid.Text = "My Bid";
            this.Bid.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1663, 902);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Products.ResumeLayout(false);
            this.ProductsTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Products;
        private System.Windows.Forms.TabPage Bid;
        private System.Windows.Forms.TabControl ProductsTab;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

