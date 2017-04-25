using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using GoFit.App.Helpers;
using GoFit.App.Models;
using GoFit.App.Views;

using Xamarin.Forms;

namespace GoFit.App.ViewModels
{
    public class TrainingsViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Training> Trainings { get; set; }
        public Command LoadTrainingsCommand { get; set; }

        public TrainingsViewModel()
        {
            Title = "Trainings";
            Trainings = new ObservableRangeCollection<Training>();
            LoadTrainingsCommand = new Command(async () => await ExecuteLoadTrainingsCommand());

            MessagingCenter.Subscribe<EditTrainingPage, Training>(this, "TrainingEdited", async (obj, training) =>
            {
                Trainings.Add(training);
                await TrainingStore.AddItemAsync(training);
            });
        }

        async Task ExecuteLoadTrainingsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Trainings.Clear();
                IEnumerable<Training> trainings = await TrainingStore.GetItemsAsync(true);

                Trainings.ReplaceRange(trainings.OrderByDescending(i=>i.LastUsage));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessagingCenter.Send(new MessagingCenterAlert
                {
                    Title = "Error",
                    Message = "Unable to load items.",
                    Cancel = "OK"
                }, "message");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}