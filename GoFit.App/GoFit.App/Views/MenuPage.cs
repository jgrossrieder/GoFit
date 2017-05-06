using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using GoFit.App.Controls;
using Xamarin.Forms;

namespace GoFit.App.Views
{
    public class MenuPage : ContentPage
    {
        public MenuPage()
        {
            Content = new StackLayout
            {
                Padding = new Thickness(0, Device.OnPlatform<int>(20, 0, 0), 0, 0),
                Children = {
                    new MainLink("Page A"),
                    new MainLink("Sessions"),
                    new MainLink("Statistiques"),
                    new MainLink("Paramètres"),
                }
            };
            Title = "Master";
            BackgroundColor = Color.Gray.WithLuminosity(0.9);
            //Icon = Device.OS == TargetPlatform.iOS ? "menu.png" : null;
        }
    }
}
