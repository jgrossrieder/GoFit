using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoFit.App.Models;

namespace GoFit.App.Services
{
    public interface ITrainingStore
    {
        Task<Training> GetCurrentTrainingAsync();
    }
}
