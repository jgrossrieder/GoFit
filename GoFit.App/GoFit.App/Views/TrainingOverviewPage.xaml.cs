using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoFit.App.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoFit.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrainingOverviewPage : ContentPage
    {
        public TrainingOverviewPage()
        {
            InitializeComponent();
            BindingContext = new TrainingOverviewViewModel();
        }
    }
}
