using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFit.App.Models
{
    public class WorkStationSetting<T>: BaseDataObject
        where T : struct
    {
        public DateTime FirstUsageDate { get; set; }
        public T Value { get => GetProperty<T>(); set => SetProperty(value);}
    }
}
