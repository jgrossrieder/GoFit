using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFit.App.Models
{
    public class WorkSession:BaseDataObject
    {
        public DateTime TrainingDay
        {
            get => GetProperty<DateTime>();
            set => SetProperty(value);
        }

        public ObservableCollection<WorkStation> UsedWorkStations
        {
            get => GetProperty<ObservableCollection<WorkStation>>();
            set => SetProperty(value);
        }


        public WorkSession()
        {
            UsedWorkStations = new ObservableCollection<WorkStation>();
        }
    }
}
