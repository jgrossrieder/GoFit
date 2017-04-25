
using GoFit.App.Models;
using GoFit.App.ViewModels;

using Xamarin.Forms;

namespace GoFit.App.Views
{
    public partial class TrainingDetailPage : ContentPage
    {
        TrainingDetailViewModel _training;

        // Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
        public TrainingDetailPage()
        {
            InitializeComponent();
        }

        public TrainingDetailPage(TrainingDetailViewModel training)
        {
            InitializeComponent();

            BindingContext = _training = training;
        }
    }
}
