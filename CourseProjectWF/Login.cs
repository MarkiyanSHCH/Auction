using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using BLL.Interface;
using Domain.Models;

namespace CourseProjectWF
{
    public partial class Login : Form
    {
        private readonly IUserServices _userServices;
        private MainForm _mainForm;
        public Login(IUserServices userServices, MainForm mainForm)
        {
            this._userServices = userServices;
            this._mainForm = mainForm;
            InitializeComponent();
        }
        private void LoginButtonClick(object sender, EventArgs e)
        {
            if (this._userServices.Login(LoginTextBox.Text, PasswordTextBox.Text))
            {
                this._mainForm.LoadUser(this._userServices.GetUserByLogin(LoginTextBox.Text));
                this._mainForm.ShowDialog();

                LoginTextBox.Text = "";
                PasswordTextBox.Text = "";
            }
            else
                MessageBox.Show("Invalid Login or Password");
        }
    }
}
