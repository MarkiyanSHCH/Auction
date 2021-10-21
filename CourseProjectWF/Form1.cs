using DAL.Controller;
using Domain.Models;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace CourseProjectWF
{
    public partial class Form1 : Form
    {
        ProductController pr = new ProductController();
        CategoryController cc = new CategoryController();
        public Form1()
        {
            InitializeComponent();

            foreach (var item in cc.GetAll())
            {
                TabPage myTabPage = new TabPage(item.Name);
                myTabPage.Name = item.Name;
                ProductsTab.TabPages.Add(myTabPage);
            }



            foreach (var item in cc.GetAll())
            {
                DataGridView tmp = new DataGridView();
                tmp.Width = 1589;
                tmp.Height = 730;


                ProductsTab.TabPages[ProductsTab.TabPages.IndexOfKey(item.Name)].Controls.Add(tmp);
                DataTable dt1 = new DataTable();
                var bindingList1 = new BindingList<Product>(pr.GetByCategory(item.Id));
                var source1 = new BindingSource(bindingList1, null);
                tmp.DataSource = source1;
                tmp.ReadOnly = true;
                tmp.Columns["Photo"].Visible = false;
                tmp.Columns["Id"].Visible = false;
                tmp.Columns["UserId"].Visible = false;
                tmp.Columns["CategoryId"].Visible = false;
            }


            DataTable dt = new DataTable();
            var bindingList = new BindingList<Product>(pr.GetAll());
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["Photo"].Visible = false;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["UserId"].Visible = false;
            dataGridView1.Columns["CategoryId"].Visible = false;




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
