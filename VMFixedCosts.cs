using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IncExpTracker
{
    class VMFixedCosts : INotifyPropertyChanged
    {
        private int _id;
        private DateTime _nextUpd;
        private DateTime _lastUpd;

        private string _nextUpdToString;
        private string _lastUpdToString;

        private int _updEvery;
        private double _amount;
        private string _amountToString;
        private string _descr;
        private string _isEnabled;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }
        public DateTime NextUpd
        {
            get
            {
                return _nextUpd;
            }
            set
            {
                _nextUpd = value;
                OnPropertyChanged("NextUpd");
            }
        }
        public DateTime LastUpd
        {
            get
            {
                return _lastUpd;
            }
            set
            {
                _lastUpd = value;
                OnPropertyChanged("LastUpd");
            }
        }

        public string NextUpdToString
        {
            get
            {
                return _nextUpdToString;
            }
            set
            {
                _nextUpdToString = value;
                OnPropertyChanged("NextUpdToString");
            }
        }

        public string LastUpdToString
        {
            get
            {
                return _lastUpdToString;
            }
            set
            {
                _lastUpdToString = value;
                OnPropertyChanged("LastUpdToString");
            }
        }

        public int UpdEvery
        {
            get
            {
                return _updEvery;
            }
            set
            {
                _updEvery = value;
                OnPropertyChanged("UpdEvery");
            }
        }

        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
                OnPropertyChanged("Amount");
            }
        }
        public string AmountToString
        {
            get
            {
                return _amountToString;
            }
            set
            {
                _amountToString = value;
                OnPropertyChanged("AmountToString");
            }
        }
        public string Descr
        {
            get
            {
                return _descr;
            }
            set
            {
                _descr = value;
                OnPropertyChanged("Descr");
            }
        }
        public string IsEnabled
        {
            get
            {
                return _isEnabled;
            }
            set
            {
                _isEnabled = value;
                OnPropertyChanged("IsEnabled");
            }
        }





        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
