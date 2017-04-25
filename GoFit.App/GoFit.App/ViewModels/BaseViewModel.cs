using GoFit.App.Helpers;
using GoFit.App.Models;
using GoFit.App.Services;

using Xamarin.Forms;

namespace GoFit.App.ViewModels
{
    public class BaseViewModel : ObservableObject
    {
        /// <summary>
        /// Get the azure service instance
        /// </summary>
        public IDataStore<Training> TrainingStore => DependencyService.Get<IDataStore<Training>>();
        
        public bool IsBusy
        {
            get => GetProperty<bool>();
            set => SetProperty(value);
        }
        /// <summary>
        /// Public property to set and get the title of the item
        /// </summary>
        public string Title
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }
    }
}

