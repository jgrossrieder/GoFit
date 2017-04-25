using System;

using GoFit.App.Models;

using Xamarin.Forms;

namespace GoFit.App.Views
{
    public partial class EditTrainingPage : ContentPage
    {
        public Training Training { get; set; }

        public EditTrainingPage()
        {
            InitializeComponent();

            Training = new Training
            {
                Name = "Training name",
                LastUsage =  DateTime.Now
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "TrainingEdited", Training);
            await Navigation.PopToRootAsync();
        }
    }
}