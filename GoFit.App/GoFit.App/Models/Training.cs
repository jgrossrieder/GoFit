using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFit.App.Models
{
    public class Training:BaseDataObject
    {
        public String Name
        {
            get => GetProperty<String>();
            set => SetProperty(value);
        }
        public DateTime LastUsage
        {
            get => GetProperty<DateTime>();
            set => SetProperty(value);
        }


        public ObservableCollection<WorkStation> WorkStations
        {
            get => GetProperty<ObservableCollection<WorkStation>>();
            set => SetProperty(value);
        }

        public ObservableCollection<WorkSession> WorkSessions
        {
            get => GetProperty<ObservableCollection<WorkSession>>();
            set => SetProperty(value);
        }

        public Training()
        {
            WorkStations= new ObservableCollection<WorkStation>();
            WorkSessions = new ObservableCollection<WorkSession>();
        }
    }
}
