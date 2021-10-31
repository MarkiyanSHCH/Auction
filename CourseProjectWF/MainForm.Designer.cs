namespace CourseProjectWF
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
            this.MainControl = new System.Windows.Forms.TabControl();
            this.Product = new System.Windows.Forms.TabPage();
            this.CategoryDropBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.IsYourBidLable = new System.Windows.Forms.Label();
            this.BuyProductButton = new System.Windows.Forms.Button();
            this.BidAuctionButton = new System.Windows.Forms.Button();
            this.nameAuctionLable = new System.Windows.Forms.Label();
            this.bidPriceLable = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myBid = new System.Windows.Forms.TabPage();
            this.MyActiveBidButton = new System.Windows.Forms.Button();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.MyDataGrid = new System.Windows.Forms.DataGridView();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.LoginLable = new System.Windows.Forms.Label();
            this.MainControl.SuspendLayout();
            this.Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.myBid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainControl
            // 
            this.MainControl.Controls.Add(this.Product);
            this.MainControl.Controls.Add(this.myBid);
            this.MainControl.Location = new System.Drawing.Point(12, 52);
            this.MainControl.Name = "MainControl";
            this.MainControl.SelectedIndex = 0;
            this.MainControl.Size = new System.Drawing.Size(1640, 876);
            this.MainControl.TabIndex = 0;
            // 
            // Product
            // 
            this.Product.Controls.Add(this.CategoryDropBox);
            this.Product.Controls.Add(this.SearchButton);
            this.Product.Controls.Add(this.IsYourBidLable);
            this.Product.Controls.Add(this.BuyProductButton);
            this.Product.Controls.Add(this.BidAuctionButton);
            this.Product.Controls.Add(this.nameAuctionLable);
            this.Product.Controls.Add(this.bidPriceLable);
            this.Product.Controls.Add(this.dataGridView1);
            this.Product.Location = new System.Drawing.Point(4, 34);
            this.Product.Name = "Product";
            this.Product.Padding = new System.Windows.Forms.Padding(3);
            this.Product.Size = new System.Drawing.Size(1632, 838);
            this.Product.TabIndex = 0;
            this.Product.Text = "Product";
            this.Product.UseVisualStyleBackColor = true;
            // 
            // CategoryDropBox
            // 
            this.CategoryDropBox.FormattingEnabled = true;
            this.CategoryDropBox.Location = new System.Drawing.Point(1426, 727);
            this.CategoryDropBox.Name = "CategoryDropBox";
            this.CategoryDropBox.Size = new System.Drawing.Size(182, 33);
            this.CategoryDropBox.TabIndex = 7;
            this.CategoryDropBox.Text = "Category";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(1456, 778);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(112, 34);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButtonByCategory);
            // 
            // IsYourBidLable
            // 
            this.IsYourBidLable.AutoSize = true;
            this.IsYourBidLable.Location = new System.Drawing.Point(1426, 264);
            this.IsYourBidLable.Name = "IsYourBidLable";
            this.IsYourBidLable.Size = new System.Drawing.Size(46, 25);
            this.IsYourBidLable.TabIndex = 5;
            this.IsYourBidLable.Text = "Bid: ";
            // 
            // BuyProductButton
            // 
            this.BuyProductButton.Location = new System.Drawing.Point(1456, 186);
            this.BuyProductButton.Name = "BuyProductButton";
            this.BuyProductButton.Size = new System.Drawing.Size(112, 34);
            this.BuyProductButton.TabIndex = 4;
            this.BuyProductButton.Text = "Buy now";
            this.BuyProductButton.UseVisualStyleBackColor = true;
            this.BuyProductButton.Click += new System.EventHandler(this.Buy);
            // 
            // BidAuctionButton
            // 
            this.BidAuctionButton.Location = new System.Drawing.Point(1456, 131);
            this.BidAuctionButton.Name = "BidAuctionButton";
            this.BidAuctionButton.Size = new System.Drawing.Size(112, 34);
            this.BidAuctionButton.TabIndex = 3;
            this.BidAuctionButton.Text = "Bid";
            this.BidAuctionButton.UseVisualStyleBackColor = true;
            this.BidAuctionButton.Click += new System.EventHandler(this.BidAuction);
            // 
            // nameAuctionLable
            // 
            this.nameAuctionLable.AutoSize = true;
            this.nameAuctionLable.Location = new System.Drawing.Point(1478, 21);
            this.nameAuctionLable.Name = "nameAuctionLable";
            this.nameAuctionLable.Size = new System.Drawing.Size(59, 25);
            this.nameAuctionLable.TabIndex = 2;
            this.nameAuctionLable.Text = "Name";
            // 
            // bidPriceLable
            // 
            this.bidPriceLable.AutoSize = true;
            this.bidPriceLable.Location = new System.Drawing.Point(1426, 58);
            this.bidPriceLable.Name = "bidPriceLable";
            this.bidPriceLable.Size = new System.Drawing.Size(88, 25);
            this.bidPriceLable.TabIndex = 1;
            this.bidPriceLable.Text = "Bid Price: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1388, 826);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // myBid
            // 
            this.myBid.Controls.Add(this.MyActiveBidButton);
            this.myBid.Controls.Add(this.HistoryButton);
            this.myBid.Controls.Add(this.MyDataGrid);
            this.myBid.Location = new System.Drawing.Point(4, 34);
            this.myBid.Name = "myBid";
            this.myBid.Padding = new System.Windows.Forms.Padding(3);
            this.myBid.Size = new System.Drawing.Size(1632, 838);
            this.myBid.TabIndex = 1;
            this.myBid.Text = "My Bid";
            this.myBid.UseVisualStyleBackColor = true;
            // 
            // MyActiveBidButton
            // 
            this.MyActiveBidButton.Location = new System.Drawing.Point(1453, 719);
            this.MyActiveBidButton.Name = "MyActiveBidButton";
            this.MyActiveBidButton.Size = new System.Drawing.Size(112, 34);
            this.MyActiveBidButton.TabIndex = 2;
            this.MyActiveBidButton.Text = "My Active Bid";
            this.MyActiveBidButton.UseVisualStyleBackColor = true;
            this.MyActiveBidButton.Click += new System.EventHandler(this.GetMyGridActiveBid);
            // 
            // HistoryButton
            // 
            this.HistoryButton.Location = new System.Drawing.Point(1453, 772);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(112, 34);
            this.HistoryButton.TabIndex = 1;
            this.HistoryButton.Text = "History";
            this.HistoryButton.UseVisualStyleBackColor = true;
            this.HistoryButton.Click += new System.EventHandler(this.GetMyGridHistoryBid);
            // 
            // MyDataGrid
            // 
            this.MyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyDataGrid.Location = new System.Drawing.Point(6, 6);
            this.MyDataGrid.Name = "MyDataGrid";
            this.MyDataGrid.RowHeadersWidth = 62;
            this.MyDataGrid.RowTemplate.Height = 33;
            this.MyDataGrid.Size = new System.Drawing.Size(1375, 826);
            this.MyDataGrid.TabIndex = 0;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(1533, 25);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(112, 34);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // LoginLable
            // 
            this.LoginLable.AutoSize = true;
            this.LoginLable.Location = new System.Drawing.Point(1351, 30);
            this.LoginLable.Name = "LoginLable";
            this.LoginLable.Size = new System.Drawing.Size(60, 25);
            this.LoginLable.TabIndex = 2;
            this.LoginLable.Text = "Login:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 940);
            this.Controls.Add(this.LoginLable);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.MainControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MainControl.ResumeLayout(false);
            this.Product.ResumeLayout(false);
            this.Product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.myBid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainControl;
        private System.Windows.Forms.TabPage Product;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage myBid;
        private System.Windows.Forms.Label bidPriceLable;
        private System.Windows.Forms.Label nameAuctionLable;
        private System.Windows.Forms.Button BidAuctionButton;
        private System.Windows.Forms.Button BuyProductButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label IsYourBidLable;
        private System.Windows.Forms.Button MyActiveBidButton;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.DataGridView MyDataGrid;
        private System.Windows.Forms.ComboBox CategoryDropBox;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label LoginLable;
    }
}