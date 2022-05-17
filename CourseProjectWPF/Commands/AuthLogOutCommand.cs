using CourseProjectWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CourseProjectWPF.Commands
{
    internal class AuthLogOutCommand:ICommand
    {
        private MainWindowViewModel _mainViewModel;

        public AuthLogOutCommand(MainWindowViewModel mainViewModel)
        {
            this._mainViewModel = mainViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

            this._mainViewModel.AuthViewModel = new AuthViewModel(this._mainViewModel.UserService, this._mainViewModel);
            this._mainViewModel.AuthViewIsVisible = false;
            this._mainViewModel.LoggedUserName = null;
            this._mainViewModel.SelectedViewModel = new ProductViewModel(this._mainViewModel.ProductService, this._mainViewModel.CategoryService, this._mainViewModel);

        }
    }
}
