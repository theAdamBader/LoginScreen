using LoginScreen.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginScreen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainLogin();
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
