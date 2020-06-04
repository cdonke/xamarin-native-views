using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ContosoCustomView.CustomPage), typeof(ContosoCustomView.iOS.CustomPageRenderer))]
namespace ContosoCustomView.iOS
{
    public class CustomPageRenderer : PageRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
            {
                return;
            }

            SetupUserInterface();
        }


        private void SetupUserInterface()
        {
            var board = UIStoryboard.FromName("Main", null);
            var viewController = board.InstantiateInitialViewController();

            ViewController.AddChildViewController(viewController);
            ViewController.View.Add(viewController.View);
        }
    }
}
