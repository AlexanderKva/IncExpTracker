using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IncExpTracker
{
    class VMOveralDetails : INotifyPropertyChanged
    {

        private int _id;
        private string _month;
        private int _monthToInt;
        private int _year;
        private double _incThisMonth;
        private double _expThisMonth;
        private double _summary;
        

        public int Id { get; set;}

        public string Month
        {
            get
            {
                return _month;
            }
            set
            {
                _month = value;
                OnPropertyChanged("Month");
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
                OnPropertyChanged("Year");
            }
        }

        public int MonthToInt
        {
            get
            {
                return _monthToInt;
            }
            set
            {
                _monthToInt = value;
                OnPropertyChanged("MonthToInt");
            }
        }
        public double IncThisMonth
        {
            get
            {
                return _incThisMonth;
            }
            set
            {
                _incThisMonth = value;
                OnPropertyChanged("IncThisMonth");
            }
        }
        public double ExpThisMonth
        {
            get
            {
                return _expThisMonth;
            }
            set
            {
                _expThisMonth = value;
                OnPropertyChanged("ExpThisMonth");
            }
        }
        public double Summary
        {
            get
            {
                return _summary;
            }
            set
            {
                _summary = value;
                OnPropertyChanged("Summary");
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
