using CourseProjectWPF.ViewModels;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CourseProjectWPF.Commands
{
    internal class MakeBidCommand : ICommand
    {
        private ProductViewModel _productViewModel;

        public MakeBidCommand(ProductViewModel productViewModel)
        {
            this._productViewModel = productViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {     
            User user = this._productViewModel.MainViewModel.UserService.GetUserByLogin(this._productViewModel.MainViewModel.LoggedUserName);
            this._productViewModel.ProductServices.MakeBid(user.Id,this._productViewModel.SelectedProduct.Id,10.00);
            this._productViewModel.Products = this._productViewModel.ProductServices.GetAllActiveProduct();
        }
    }
}
