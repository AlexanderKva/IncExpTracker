using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IncExpTracker
{
    class VMOverallGroupedBy : INotifyPropertyChanged
    {

        private List<VMOveralDetails> _overAllDet;
        



        public List<VMOveralDetails> OverAllDet
        {
            get
            {
                return _overAllDet;
            }
            set
            {
                _overAllDet = value;
                OnPropertyChanged("OverAllDet");
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
