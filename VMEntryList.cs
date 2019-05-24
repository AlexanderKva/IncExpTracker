using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IncExpTracker
{
    class VMEntryList : INotifyPropertyChanged
    {
        private List<VMEntry> _entryList = new List<VMEntry>();
        private double _summary;
        private string _dateToString;
        private bool _isBusy = false;
        private bool _isNotBusy = true;


        public List<VMEntry> EntryList
        {
            get
            {
                return _entryList;
            }

            set
            {
                _entryList = value;
                OnPropertyChanged("EntryList");
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
