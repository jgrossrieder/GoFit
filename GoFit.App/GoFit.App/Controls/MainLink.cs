using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoFit.App.Views;
using Xamarin.Forms;

namespace GoFit.App.Controls
{
    public class MainLink:Button
    {
        public MainLink(string name)
        {
            Text = name;
            Command = new Command(o => {
                App.MasterDetailPage.Detail = new NavigationPage(new TrainingDetailPage());
                App.MasterDetailPage.IsPresented = false;
            });
        }
    }
}
