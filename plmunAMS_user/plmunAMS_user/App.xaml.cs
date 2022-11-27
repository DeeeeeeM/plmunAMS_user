using plmunAMS_user.Services;
using plmunAMS_user.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("Nunito-Black.ttf")]
[assembly: ExportFont("Nunito-BlackItalic.ttf")]
[assembly: ExportFont("Nunito-Bold.ttf")]
[assembly: ExportFont("Nunito-BoldItalic.ttf")]
[assembly: ExportFont("Nunito-ExtraBold.ttf")]
[assembly: ExportFont("Nunito-ExtraBoldItalic.ttf")]
[assembly: ExportFont("Nunito-ExtraLight.ttf")]
[assembly: ExportFont("Nunito-ExtraLightItalic.ttf")]
[assembly: ExportFont("Nunito-Italic.ttf")]
[assembly: ExportFont("Nunito-Light.ttf")]
[assembly: ExportFont("Nunito-LightItalic.ttf")]
[assembly: ExportFont("Nunito-Medium.ttf")]
[assembly: ExportFont("Nunito-MediumItalic.ttf")]
[assembly: ExportFont("Nunito-Regular.ttf")]
[assembly: ExportFont("Nunito-SemiBold.ttf")]
[assembly: ExportFont("Nunito-SemiBoldItalic.ttf")]

namespace plmunAMS_user
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new LoginPage());

            bool isLoggedIn = Current.Properties.ContainsKey("IsLoggedIn") ? Convert.ToBoolean(Current.Properties["IsLoggedIn"]) : false;
            
            if (isLoggedIn)
            {
                //Load if Not Logged In
                MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                //Load if Logged In
                MainPage = new NavigationPage(new DashboardPage());
            }
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
