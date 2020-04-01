using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appB
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
            if (Application.Current.Properties.ContainsKey("data1"))
            {
                var data1 = Application.Current.Properties["data1"].ToString();
                App.Current.MainPage.DisplayAlert("The app enter here", " "+data1, "ok");
            }

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
