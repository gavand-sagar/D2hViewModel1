using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2hViewModel
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private string _username; // field
        public string Username  //Property
        {
            get { return _username; }
            set
            {
                _username = value;
                if (Username.Contains("u"))
                {
                    Validation = "Conains U";
                }
                ProperteryUpdated("Username");
            }
        }


        private string _Validation;
        public string Validation
        {
            get { return _Validation; }
            set { _Validation = value; ProperteryUpdated("Validation"); }
        }



        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; ProperteryUpdated("Password"); }
        }


        public MainWindowViewModel()
        {
            this.Username = "Sagar";
        }


        void ProperteryUpdated(string ProperyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(ProperyName));
            }
        }



    }
}
