using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IncExpTracker
{
    class VMFixedCostsList : INotifyPropertyChanged
    {
        private List<VMFixedCosts> _entryList;

        public List<VMFixedCosts> EntryList
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
