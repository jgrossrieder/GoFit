using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoFit.App.Helpers;
using GoFit.App.Models;
using Xamarin.Forms;

namespace GoFit.App.ViewModels
{
    public class TrainingOverviewViewModel: BaseViewModel
    {

        public Command StartSessionCommand { get; set; }
        public NotifyTaskCompletion<Training> TrainingTask { get; private set; }


        public TrainingOverviewViewModel()
        {
            StartSessionCommand = new Command(async () => await ExecuteStartSessionCommand());
            TrainingTask = new NotifyTaskCompletion<Training>(TrainingStore.GetCurrentTrainingAsync());
        }

        private async Task ExecuteStartSessionCommand()
        {
            
        }
    }
}
