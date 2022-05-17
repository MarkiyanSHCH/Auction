using CourseProjectWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CourseProjectWPF.Commands
{
    internal class LogInButtonCommand : ICommand
    {
        private MainWindowViewModel _mainViewModel;
        private AuthViewModel _authViewModel;
        public LogInButtonCommand(MainWindowViewModel mainViewModel, AuthViewModel authViewModel)
        {
            this._mainViewModel = mainViewModel;
            this._authViewModel = authViewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (this._authViewModel.UserServices.Login(this._authViewModel.UserNameInput, this._authViewModel.UserPasswordInput))
            {
                this._mainViewModel.LoggedUserName = this._authViewModel.UserNameInput;
                this._mainViewModel.AuthViewIsVisible = true;
                this._mainViewModel.SelectedViewModel = new ProductViewModel(this._mainViewModel.ProductService, this._mainViewModel.CategoryService, this._mainViewModel);
                this._mainViewModel.AuthViewModel = new AuthHideViewModel();
            }
            else
            {
                this._authViewModel.WrongData();
            }
        }
    }
}
