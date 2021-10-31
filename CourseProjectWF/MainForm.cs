using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using BLL.Interface;
using Domain.Models;

namespace CourseProjectWF
{
    public partial class MainForm : Form
    {
        private readonly IProductServices _productServices;
        private readonly ICategoryServices _categoryServices;
        private User _user;
        private int _userId;

        public MainForm(IProductServices productServices, ICategoryServices categoryServices)
        {
            this._productServices = productServices;
            this._categoryServices = categoryServices;

            InitializeComponent();
            this.LoadGrid();
            this.LoadMyGrid();

            CategoryDropBox.Items.Add("All");
            foreach (var category in _categoryServices.GetAllCategory())
                CategoryDropBox.Items.Add(category.Name);
        }

        public void LoadUser(User user)
        {
            _user = user;
            _userId = _user.Id;
            LoginLable.Text = $"{_user.Login}";
        }
        private void LoadGrid()
        {
            DataTable dt = new DataTable();
            var bindingList = new BindingList<Product>(this._productServices.GetAllActiveProduct());
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["Photo"].Visible = false;
            dataGridView1.Columns["RowInsertTime"].Visible = false;
            dataGridView1.Columns["RowUpdateTime"].Visible = false;
            dataGridView1.Columns["Sell"].Visible = false;
            dataGridView1.Columns["UserId"].Visible = false;
            dataGridView1.Columns["CategoryId"].Visible = false;
        }

        private void RefreshGridWithSearch(string name)
        {
            if (name != "All")
                dataGridView1.DataSource = this._productServices.FindProductsByCategory(name);
            else
                dataGridView1.DataSource = this._productServices.GetAllActiveProduct();
            dataGridView1.Refresh();
        }

        int indexRowD;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRowD = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[indexRowD];
                nameAuctionLable.Text = $"{row.Cells[1].Value}";
                bidPriceLable.Text = $"Bid Price: {row.Cells[5].Value}";
                if (this._userId == Convert.ToInt32(row.Cells[10].Value))
                    IsYourBidLable.Text = "Bid: Your";
                else
                    IsYourBidLable.Text = "Bid: Not Your";
            }
        }

        private void BidAuction(object sender, EventArgs e)
        {
            if (indexRowD >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[indexRowD];
                _productServices.MakeBid(_userId, Convert.ToInt32(row.Cells[0].Value), 10.00);
                this.LoadGrid();
            }
        }

        private void Buy(object sender, EventArgs e)
        {
            if (indexRowD >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[indexRowD];
                _productServices.Buy(_userId, Convert.ToInt32(row.Cells[0].Value));
                this.LoadGrid();
            }
        }

        private void SearchButtonByCategory(object sender, EventArgs e)
        {
            this.RefreshGridWithSearch(this.CategoryDropBox.SelectedItem.ToString());
        }

        private void LoadMyGrid()
        {
            DataTable dt = new DataTable();
            var bindingList = new BindingList<Product>(this._productServices.GetAllByUserActive(this._userId));
            var source = new BindingSource(bindingList, null);
            MyDataGrid.DataSource = source;

            MyDataGrid.ReadOnly = true;
            MyDataGrid.Columns["Photo"].Visible = false;
            MyDataGrid.Columns["RowInsertTime"].Visible = false;
            MyDataGrid.Columns["RowUpdateTime"].Visible = false;
            MyDataGrid.Columns["Sell"].Visible = false;
            MyDataGrid.Columns["UserId"].Visible = false;
            MyDataGrid.Columns["CategoryId"].Visible = false;
        }

        private void RefreshMyGrid(bool isTrue)
        {
            if (isTrue)
                MyDataGrid.DataSource = this._productServices.GetAllByUserActive(this._userId);
            else
                MyDataGrid.DataSource = this._productServices.GetAllByUserHistory(this._userId);
            MyDataGrid.Refresh();
        }

        private void GetMyGridActiveBid(object sender, EventArgs e)
        {
            this.RefreshMyGrid(true);
        }

        private void GetMyGridHistoryBid(object sender, EventArgs e)
        {
            this.RefreshMyGrid(false);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
