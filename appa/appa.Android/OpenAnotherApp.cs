using System;
using Android.Content;
using Android.Content.PM;
using appa.Droid;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(OpenAnotherApp))]
namespace appa.Droid
{
    public class OpenAnotherApp : IOpenAnotherApp
    {
        public OpenAnotherApp()
        {
        }

        public void OpenApplicationB()
        {
            var intent = Forms.Context.PackageManager.GetLaunchIntentForPackage("com.poc.app.appb");

            if (intent != null)
            {
                // We found the activity now start the activity
                intent.AddFlags(ActivityFlags.NewTask);
                intent.PutExtra("data1", "johndoe");
                intent.PutExtra("data2", "Bank1234#");
                Forms.Context.StartActivity(intent);
            }
            else
            {
                // Bring user to the market or let them choose an app?
                
            }

        }
    }
}
