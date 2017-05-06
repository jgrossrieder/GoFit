using GoFit.App.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace GoFit.App
{
    public partial class App : Application
    {
        public static MasterDetailPage MasterDetailsPage { get; set; }

        public App()
        {                                                                             
            InitializeComponent();

            SetMainPage();
        }

        public static void SetMainPage()
        {
            MasterDetailsPage = new MasterDetailPage()
            {
                MasterBehavior = MasterBehavior.Popover,
                Master = new MenuPage(),
                Detail = new NavigationPage(new TrainingOverviewPage())
            };
            Current.MainPage = MasterDetailsPage;/*new TabbedPage
            {
                Children =
                {
                    new NavigationPage(new TrainingOverviewPage())
                    {
                        Title = "Trainings",
                        Icon = Device.OnPlatform("tab_feed.png",null,null)
                    }
                }
            };*/
        }
    }
}
