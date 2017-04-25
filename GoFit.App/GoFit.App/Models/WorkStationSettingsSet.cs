using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFit.App.Models
{
    public class WorkStationSettingsSet<T>:BaseDataObject 
        where T:struct 
    {
        public WorkStationSetting<T> CurrentSettings
        {
            get => GetProperty<WorkStationSetting<T>>();
            set => SetProperty(value);
        }
        public ObservableCollection<WorkStationSetting<T>> SettingsHistory
        {
            get => GetProperty<ObservableCollection<WorkStationSetting<T>>>();
            set => SetProperty(value);
        }

        public WorkStationSettingsSet()
        {
            SettingsHistory = new ObservableCollection<WorkStationSetting<T>>();
        }
    }
}
