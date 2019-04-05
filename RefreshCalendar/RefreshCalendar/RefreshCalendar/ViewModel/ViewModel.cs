using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RefreshCalendar
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ICommand _refresh;

        public ICommand Refresh
        {
            get
            {
                return _refresh;
            }
            set
            {
                _refresh = value;
                RaisePropertyChanged("Refresh");
            }
        }

        public ViewModel()
        {
            Refresh = new Command(ExecuteRefresh);
        }

        // Refresh Calendar from ViewModel
        private void ExecuteRefresh(object obj)
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
