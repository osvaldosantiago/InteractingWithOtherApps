using System;
using System.Diagnostics;
using appa.iOS;
using Foundation;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(OpenAnotherApp))]
namespace appa.iOS
{
    public class OpenAnotherApp: IOpenAnotherApp
    {
        public OpenAnotherApp()
        {
        }

        /// <summary>
        /// https://www.appcoda.com/working-url-schemes-ios/
        /// public void OpenApplicationB()
        /// https://xamarinhelp.com/uri-scheme/
        /// </summary>
        public void OpenApplicationB()
        {
            NSUrl request = new NSUrl("appb://&johndoe&Bank1234");

            try
            {
                bool isOpened = UIApplication.SharedApplication.OpenUrl(request);

                if (isOpened == false)
                {
                    UIApplication.SharedApplication.OpenUrl(new NSUrl("yourappurlfromappstore"));
                }
                    
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Cannot open url: {0}, Error: {1}", request.AbsoluteString, ex.Message);
                var alertView = new UIAlertView("Error", ex.Message, null, "OK", null);

                alertView.Show();
            }
        }
    }
}
