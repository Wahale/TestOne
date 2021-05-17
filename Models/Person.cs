using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TestOne.Models
{
    class Person : INotifyPropertyChanged
    {
        public DateTime CreationDate { get; set; }
        public DateTime Goden { get; set; }
        private string _text,_register,_current,_phone,_email;
        private int _age;

        public  string Text
        {
            get { return _text; }
            set 
            {
                if (_text == value)
                    return;
                _text = value;
                OnPropertyChanged("Text");
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (_age == value)
                    return;
                _age = value;
                OnPropertyChanged("Age");
            }
        }

        public string Register
        {
            get { return _register; }
            set
            {
                if (_register == value)
                    return;
                _register = value;
                OnPropertyChanged("Register");
            }
        }

        public string Current
        {
            get { return _current; }
            set
            {
                if (_current == value)
                    return;
                _current = value;
                OnPropertyChanged("Current");
            }
        }

        public string Phone
        {
            get { return _phone; }
            set
            {
                if (_phone == value)
                    return;
                _phone = value;
                OnPropertyChanged("Phone");
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (_email == value)
                    return;
                _email = value;
                OnPropertyChanged("Email");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
