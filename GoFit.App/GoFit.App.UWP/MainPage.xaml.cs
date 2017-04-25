namespace GoFit.App.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            LoadApplication(new GoFit.App.App());
        }
    }
}