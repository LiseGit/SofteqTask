using SofteqTaskAndroid.IocContainer;
using Xamarin.Forms;

namespace SofteqTaskAndroid
{
    public partial class App : Application
    {
        public App()
        {
            var builder = new IocContainerBuilder();
            builder.RegisterDependencies();

            InitializeComponent();

            var navContainer = new MenuNavigationContainer("MenuContainer");
            MainPage = navContainer;
        }

        protected override void OnStart() { }

        protected override void OnSleep() { }

        protected override void OnResume() { }
    }
}
