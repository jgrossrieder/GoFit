using GoFit.App.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace GoFit.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            SetMainPage();
        }

        public static void SetMainPage()
        {
            Current.MainPage = new TabbedPage
            {
                Children =
                {
                    new NavigationPage(new TrainingsPage())
                    {
                        Title = "Trainings",
                        Icon = Device.OnPlatform("tab_feed.png",null,null)
                    }
                }
            };
        }
    }
}
