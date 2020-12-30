using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SofteqTaskAndroid
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var navContainer = new MenuNavigationContainer("MenuContainer");
            MainPage = navContainer;
            //MainPage = new MainPage();
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
