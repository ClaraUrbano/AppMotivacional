using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("School To Learn.ttf", Alias = "fonte1")]
[assembly: ExportFont("Valentine Cute.ttf", Alias = "fonte2")]

namespace AppMotivacional
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
