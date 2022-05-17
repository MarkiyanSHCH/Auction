using BLL.Interface;
using BLL.Services;
using courseProjectWPF.Commands;
using CourseProjectWPF.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace CourseProjectWPF.ViewModels
{
    public class MainWindowViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private string _loggedUserName = null;
        private bool _authViewIsVisible = false;
        private BaseViewModel _authViewModel;
        private BaseViewModel _selectedViewModel;
        private ICategoryServices _categoryService;
        private IProductServices _productService;
        private IUserServices _userService;

        public MainWindowViewModel(ICategoryServices categoryService, IProductServices productService, IUserServices userService)
        {
           
            this._categoryService = categoryService;
            this._productService = productService;
            this._userService = userService;
            this._selectedViewModel = new ProductViewModel(this._productService,this._categoryService,this);
            this.AuthViewModel = new AuthViewModel(this._userService,this);
            MenuButtonsCommand = new MenuButtonCommand(this);
            AuthViewHide = new AuthLogOutCommand(this);
        }
        public BaseViewModel AuthViewModel 
        { 
            get => this._authViewModel;
            set
            {
                this._authViewModel = value;
                OnPropertyChanged(nameof(AuthViewModel));
            }
        }
        public BaseViewModel SelectedViewModel 
        { 
            get => this._selectedViewModel;
            set
            {
                this._selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }
        public bool AuthViewIsVisible
        {
            get => this._authViewIsVisible;
            set
            {
                this._authViewIsVisible = value;
                OnPropertyChanged("AuthViewIsVisible");
            }
        }
        public string LoggedUserName
        {
            get => this._loggedUserName;
            set
            {
                this._loggedUserName = value;
                OnPropertyChanged("LoggedUserName");
            }
        }

        public ICommand MenuButtonsCommand { get; set; }
        public ICommand AuthViewHide { get; set; }
        public ICategoryServices CategoryService { get => _categoryService; set => _categoryService = value; }
        public IProductServices ProductService { get => _productService; set => _productService = value; }
        public IUserServices UserService { get => _userService; set => _userService = value; }

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
