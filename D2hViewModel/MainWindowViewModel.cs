using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace D2hViewModel
{

    public class BaseButtonCommand : ICommand
    {
        Action action;
        public BaseButtonCommand(Action action)
        {
            this.action = action;
        }
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            action();
        }
    }


    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChange(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

    }

    public class MainWindowViewModel : BaseViewModel
    {

        private string _username;
        public string Username
        {
            get { return _username; }
            set { _username = value; OnPropertyChange(nameof(Username)); }
        }


        private ObservableCollection<int> _numbers;
        public ObservableCollection<int> Numbers
        {
            get { return _numbers; }
            set { _numbers = value; OnPropertyChange(nameof(Numbers)); }
        }

        public ICommand LoginCommand { get; set; }
        public ICommand SignupCommand { get; set; }
        public ICommand GetUsersCommand { get; set; }
        public MainWindowViewModel()
        {
            LoginCommand = new BaseButtonCommand(Login);
            SignupCommand = new BaseButtonCommand(SignUp);
            GetUsersCommand = new BaseButtonCommand(GetUsers);
        }
        public void Login()
        {
            Numbers.Add(12);

            MessageBox.Show("Login");
        }

        public void SignUp()
        {
            MessageBox.Show("Login");
        }

        public void GetUsers()
        {

        }




    }
}
