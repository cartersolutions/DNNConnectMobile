using Xamarin.Forms;

using DNNConnect.Views;

namespace DNNConnect
{
    public class App : Application
    {
        public static string BEARER_TOKEN = string.Empty;

        public App()
        {
            // The root page of your application
            MainPage = new Login();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        #region Methods

        public static void SetMainPage(Page page, bool isNavigationPage)
        {
            if (isNavigationPage)
            {
                var navPage = new NavigationPage(page);
                navPage.BarBackgroundColor = Color.FromHex("6D9DBD");
                navPage.BarTextColor = Color.White;
                App.Current.MainPage = navPage;
            }
            else
            {
                App.Current.MainPage = page;
            }
        }

        #endregion
    }
}
