using CourseProjectWPF.ViewModels;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CourseProjectWPF.Commands
{
    internal class MyBidProductsCommand : ICommand
    {
        private MyBidViewModel _myBidViewModel;

        public MyBidProductsCommand(MyBidViewModel myBidViewModel)
        {
            this._myBidViewModel = myBidViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            User user = this._myBidViewModel.MainViewModel.UserService.GetUserByLogin(this._myBidViewModel.MainViewModel.LoggedUserName);

            if (parameter.ToString() == "AllActive")
            {
                this._myBidViewModel.UserProducts = this._myBidViewModel.ProductServices.GetAllByUserActive(user.Id);
            }
            else if(parameter.ToString() == "History")
            {
                this._myBidViewModel.UserProducts = this._myBidViewModel.ProductServices.GetAllByUserHistory(user.Id);
            }
        }
    }
}
