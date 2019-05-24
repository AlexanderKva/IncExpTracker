using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IncExpTracker
{
    class VMOverallDetailsList : INotifyPropertyChanged
    {
        private List<VMOveralDetails> _entryList = new List<VMOveralDetails>();
        private double _overall_sum;
        private double _overall_inc;
        private double _overall_exp;



        public List<VMOveralDetails> EntryList
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

        public double OverallSum
        {
            get
            {
                return _overall_sum;
            }
            set
            {
                _overall_sum = value;
                OnPropertyChanged("OverallSum");
            }
        }
        public double OverallInc
        {
            get
            {
                return _overall_inc;
            }
            set
            {
                _overall_inc = value;
                OnPropertyChanged("OverallInc");
            }
        }
        public double OverallExp
        {
            get
            {
                return _overall_exp;
            }
            set
            {
                _overall_exp = value;
                OnPropertyChanged("OverallExp");
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
