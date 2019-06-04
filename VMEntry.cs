using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IncExpTracker
{
    class VMEntry : INotifyPropertyChanged
    {
        private int _id;
        private DateTime _date;
        private double _amount;
        private string _descr;
        private double _total;
        private string _strAmount;
        private string _dateToString;
        private double _incomeTotal;
        private double _expTotal;
        private bool _isBusy = false;
        private bool _isNotBusy = true;
        private bool _isPayDay;
        private string _hoursToString;
        private string _overTimeToString;

        public int Id { get; set; }
        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
                OnPropertyChanged("Date");
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
                if (_descr == "PayDay")
                {
                    IsPayDay = true;
                }
                else { IsPayDay = false; }
            }
        }
        public string StrAmount
        {
            get{
                return _strAmount;
            }
            set
            {
                _strAmount = value;
                OnPropertyChanged("StrAmount");
            }
        }
        public string DateToString
        {
            get
            {
                return _dateToString;
            }
            set
            {
                _dateToString = value;
                OnPropertyChanged("DateToString");
            }
        }
        public double Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
                OnPropertyChanged("Total");
            }
        }

        public double IncomeTotal
        {
            get
            {
                return _incomeTotal;
            }
            set
            {
                _incomeTotal = value;
                OnPropertyChanged("IncomeTotal");
            }
        }

        public double ExpTotal
        {
            get
            {
                return _expTotal;
            }
            set
            {
                _expTotal = value;
                OnPropertyChanged("ExpTotal");
            }
        }

        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged("IsBusy");
                if (_isBusy == true) IsNotBusy = false;
                else IsNotBusy = true;
            }
        }

        public bool IsNotBusy
        {
            get { return _isNotBusy; }
            set
            {
                _isNotBusy = value;
                OnPropertyChanged("IsNotBusy");
            }
        }
        
        public bool IsPayDay
        {
            get { return _isPayDay; }
            set
            {
                _isPayDay = value;
                OnPropertyChanged("IsPayDay");
            }
        }

        public string HoursToString
        {
            get { return _hoursToString; }
            set
            {
                _hoursToString = value;
                OnPropertyChanged("HoursToString");
            }
        }

        public string OverTimeToString
        {
            get { return _overTimeToString; }
            set
            {
                _overTimeToString = value;
                OnPropertyChanged("OverTimeToString");
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
