using System;

using GoFit.App.Models;
using GoFit.App.ViewModels;

using Xamarin.Forms;

namespace GoFit.App.Views
{
    public partial class TrainingsPage : ContentPage
    {
        TrainingsViewModel viewModel;

        public TrainingsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new TrainingsViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            Training item = args.SelectedItem as Training;
            if (item == null)
                return;

             await Navigation.PushAsync(new TrainingDetailPage(new TrainingDetailViewModel(item)));

             // Manually deselect item
             ItemsListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditTrainingPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            /*
            if (viewModel.Trainings.Count == 0)
                viewModel.LoadTrainingsCommand.Execute(null);*/
        }
    }
}
