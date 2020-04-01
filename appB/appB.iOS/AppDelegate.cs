using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace appB.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }

        public override bool OpenUrl(UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
        {

            var dataFromUrl = url.AbsoluteString;
            if(!string.IsNullOrEmpty(dataFromUrl))
            {
                string[] data = dataFromUrl.Split('&');

                System.Diagnostics.Debug.WriteLine("==================First Parameter=========================");
                System.Diagnostics.Debug.WriteLine(data[1]);
                System.Diagnostics.Debug.WriteLine("==================Second Parameter=========================");
                System.Diagnostics.Debug.WriteLine(data[2]);
                Xamarin.Forms.Application.Current.Properties["data1"] = data[1];

            }

            return true;
            //return base.OpenUrl(application, url, sourceApplication, annotation);

        }
    }
}
