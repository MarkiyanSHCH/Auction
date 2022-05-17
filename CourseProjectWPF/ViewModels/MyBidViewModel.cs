using BLL.Interface;
using CourseProjectWPF.Commands;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace CourseProjectWPF.ViewModels
{
    public class MyBidViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private IProductServices _productServices;
        private IEnumerable<Product> _products;
        private MainWindowViewModel _mainViewModel;
        public MyBidViewModel(IProductServices productServices,MainWindowViewModel mainViewModel)
        {
            this._productServices = productServices;
            this._mainViewModel = mainViewModel;
            ProductsGet = new MyBidProductsCommand(this);
        }
        public IEnumerable<Product> UserProducts
        {
            get => this._products;
            set
            {
                this._products = value;
                OnPropertyChanged("UserProducts");
            }
        }

        public ICommand ProductsGet { get; set; }
        public IProductServices ProductServices { get => _productServices; set => _productServices = value; }
        public MainWindowViewModel MainViewModel { get => _mainViewModel; set => _mainViewModel = value; }

        #region INotify
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
