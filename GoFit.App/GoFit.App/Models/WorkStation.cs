using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFit.App.Models
{
    public class WorkStation:BaseDataObject
    {
        public String Name
        {
            get => GetProperty<String>();
            set => SetProperty(value);
        }

        public WorkStationSettingsSet<int> WeightSettings
        {
            get => GetProperty<WorkStationSettingsSet<int>>();
            set => SetProperty(value);
        }

        public WorkStationSettingsSet<ushort> SeriesCount
        {
            get => GetProperty<WorkStationSettingsSet<ushort>>();
            set => SetProperty(value);
        }
        public WorkStationSettingsSet<ushort> RepetitionPerSerie
        {
            get => GetProperty<WorkStationSettingsSet<ushort>>();
            set => SetProperty(value);
        }
    }
}
