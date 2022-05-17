
using CourseProjectWPF.ViewModels;
using System;
using System.Windows.Input;

namespace courseProjectWPF.Commands
{
    internal class MenuButtonCommand : ICommand
    {
        private MainWindowViewModel _mainViewModel;

        public MenuButtonCommand(MainWindowViewModel mainViewModel)
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
            if (parameter.ToString() == "MyBid")
            {
                this._mainViewModel.SelectedViewModel = new MyBidViewModel(this._mainViewModel.ProductService, this._mainViewModel);
            }
            else if (parameter.ToString() == "Products")
            {
                this._mainViewModel.SelectedViewModel = new ProductViewModel(this._mainViewModel.ProductService,this._mainViewModel.CategoryService,this._mainViewModel);
            }

        }
    }
}