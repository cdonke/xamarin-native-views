using System;
using Foundation;
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


            try
            {
                ViewController.AddChildViewController(viewController);
                ViewController.View.Add(viewController.View);
            }
            catch (Exception e)
            {

            }
        }
    }

    [Register("MainViewController")]
    public partial class MainViewController: UIViewController
    {
        private readonly iOSDummyAppBehavior.MainViewBehavior _mainViewBehavior;

        [Outlet]
        private UILabel lblCounter { get; set; }

        public MainViewController(IntPtr handle) : base(handle)
        {
            _mainViewBehavior = new iOSDummyAppBehavior.MainViewBehavior();
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            _mainViewBehavior.LblCounter = lblCounter;
        }

        [Action("btnIncrement_OnClick:")]
        public void btnIncrement_OnClick(UIButton sender)
        {
            _mainViewBehavior.BtnIncrement_OnClickWithSender(sender);
        }
    }
}
