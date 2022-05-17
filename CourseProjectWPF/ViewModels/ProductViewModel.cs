using BLL.Interface;
using CourseProjectWPF.Commands;
using Domain.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace CourseProjectWPF.ViewModels
{
    public class ProductViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private bool _isButtonsActive;
        private IProductServices _productServices;
        private ICategoryServices _categoryServices;
        private IEnumerable<Product> _products;
        private MainWindowViewModel _mainViewModel;
        private Product _selectedProduct;
        private int _selectedProductIndex;
        private string _isBidYours = "";
        public ProductViewModel(IProductServices productServices, ICategoryServices categoryServices, MainWindowViewModel mainViewModel)
        {
            this._productServices = productServices;
            this._categoryServices = categoryServices;
            this._mainViewModel = mainViewModel;
            Products = this._productServices.GetAllActiveProduct();
            if (this._mainViewModel.LoggedUserName != null)
                IsButtonsActive = true;
            else
                IsButtonsActive = false;
            MakeBid = new MakeBidCommand(this);
            Buy = new BuyCommand(this);
            IsYourBid = new IsYourBidCommand(this);
        }
        public IEnumerable<Product> Products
        {
            get => this._products;
            set
            {
                this._products = value;
                OnPropertyChanged("Products");
            }
        }

        public Product SelectedProduct
        {
            get => this._selectedProduct;
            set
            {
                this._selectedProduct = value;
                OnPropertyChanged("SelectedProduct");

            }
        }
        public int SelectedProductIndex
        {
            get => this._selectedProductIndex;
            set
            {
                this._selectedProductIndex = value;
                OnPropertyChanged("SelectedProductIndex");
                
            }
        }

        public bool IsButtonsActive
        {
            get => this._isButtonsActive;
            set
            {
                this._isButtonsActive = value;
                OnPropertyChanged("IsButtonsActive");
            }
        }
        public string IsBidYourString
        {
            get => this._isBidYours;
            set
            {
                this._isBidYours = value;
                OnPropertyChanged("IsBidYourString");
            }
        }
        public ICommand MakeBid { get; set; }
        public ICommand Buy { get; set; }
        public ICommand IsYourBid { get; set; }
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
