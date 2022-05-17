using CourseProjectWPF.ViewModels;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CourseProjectWPF.Commands
{
    internal class IsYourBidCommand : ICommand
    {
        private ProductViewModel _productViewModel;

        public IsYourBidCommand(ProductViewModel productViewModel)
        {
            this._productViewModel = productViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
            => true;

        public void Execute(object parameter)
        {
            User user = this._productViewModel.MainViewModel.UserService.GetUserByLogin(this._productViewModel.MainViewModel.LoggedUserName);
            if (user.Id == this._productViewModel.SelectedProduct.UserId)
                this._productViewModel.IsBidYourString = "your";
            else
                this._productViewModel.IsBidYourString = "not your";
        }
    }
}
