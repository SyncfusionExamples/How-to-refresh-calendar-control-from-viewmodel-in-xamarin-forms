using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SfCalendarSample
{
   public  class ViewModel :INotifyPropertyChanged
    {
        private ICommand _refersh;

        public ICommand Refersh
        {
            get
            {
                return _refersh;
            }
            set
            {
                _refersh = value;
                RaisePropertyChanged("Refersh");
            }
        }

        public ViewModel()
        {
            Refersh = new Command(ExecuteRefersh);
        }

        // Refresh Calendar from ViewModel
        private void ExecuteRefersh(object obj)
        {
            if (obj is SfCalendar)
            {
                (obj as SfCalendar).Refresh();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
