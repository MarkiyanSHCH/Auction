using BLL.Interface;
using CourseProjectWPF.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace CourseProjectWPF.ViewModels
{
    public class AuthViewModel : BaseViewModel, INotifyPropertyChanged, IDataErrorInfo
    {
        private string _username;
        private string _password;
        private MainWindowViewModel _mainViewModel;
        private IUserServices _userServices;
        public AuthViewModel(IUserServices userServices, MainWindowViewModel mainViewModel)
        {
            this._userServices = userServices;
            this._mainViewModel = mainViewModel;
            LogInCommand = new LogInButtonCommand(this._mainViewModel,this);
        }
        public string UserNameInput
        { 
            get => this._username;
            set
            {
                this._username = value;
                OnPropertyChanged("UserNameInput");
            }
        }
        public string UserPasswordInput
        {
            get => this._password;
            set
            {
                this._password = value;
                OnPropertyChanged("UserPasswordInput");
            }
        }

        public IUserServices UserServices { get => _userServices; set => _userServices = value; }
        public ICommand LogInCommand { get; set; }
        internal void WrongData()
        {
            MessageBox.Show("Wrong username or password", "Error");
        }


        #region Validation
        private bool _isValidPass;
        private bool _isValidUserName;
        private bool _buttonLogInIsEnable;
        public bool ButtonLogInIsEnable
        {
            get => this._buttonLogInIsEnable;
            set
            {
                this._buttonLogInIsEnable = value;
                OnPropertyChanged("ButtonLogInIsEnable");
            }
        }
        public bool IsValidUserName
        {
            get => this._isValidUserName;
            set
            {
                if (this._isValidUserName != value)
                    this._isValidUserName = value;
            }
        }
        public bool IsValidPass
        {
            get => this._isValidPass;
            set
            {
                if (this._isValidPass != value)
                    this._isValidPass = value;
            }
        }
        public string Error { get { return null; } }
        public Dictionary<string, string> ErrorCollection { get; private set; } = new Dictionary<string, string>();
        public string this[string name]
        {
            get
            {
                string _result = null;
                switch (name)
                {
                    case "UserPasswordInput":
                        if (string.IsNullOrWhiteSpace(UserPasswordInput))
                        {
                            _result = "Password cannot be empty";
                            IsValidPass = false;
                        }
                        else if (UserPasswordInput.Contains(" "))
                        {
                            _result = "Using space is not allowed";
                            IsValidPass = false;
                        }
                        else
                        {
                            IsValidPass = true;
                        }
                        break;
                    case "UserNameInput":
                        if (string.IsNullOrWhiteSpace(UserNameInput))
                        {
                            _result = "UserName cannot be empty";
                            IsValidUserName = false;
                        }
                        else if (UserNameInput.Contains(" "))
                        {
                            _result = "Using space is not allowed";
                            IsValidUserName = false;
                        }
                        else
                        {
                            IsValidUserName = true;
                        }
                        break;
                }

                if (ErrorCollection.ContainsKey(name))
                    ErrorCollection[name] = _result;
                else if (_result != null)
                    ErrorCollection.Add(name, _result);
                if (IsValidUserName && IsValidPass)
                    ButtonLogInIsEnable = true;
                else
                    ButtonLogInIsEnable = false;

                OnPropertyChanged("ErrorCollection");
                return _result;
            }
        }

        #endregion

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
