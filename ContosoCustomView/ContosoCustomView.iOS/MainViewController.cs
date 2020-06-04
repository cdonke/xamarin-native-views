using System;
using Foundation;
using UIKit;
using Xamarin.Forms;


namespace ContosoCustomView.iOS
{
    [Register("MainViewController")]
    public partial class MainViewController : UIViewController
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
