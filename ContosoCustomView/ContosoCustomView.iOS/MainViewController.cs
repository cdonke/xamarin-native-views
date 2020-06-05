using System;
using Foundation;
using UIKit;
using Xamarin.Forms;


namespace ContosoCustomView.iOS
{
    [Register("MainViewController")]
    public partial class MainViewController : iOSDummyAppBehavior.MainViewBehavior
    {
        public MainViewController(IntPtr handle):base(handle)
        {
        }

        public MainViewController(NSCoder coder) : base(coder)
        {
        }

        protected MainViewController(NSObjectFlag t) : base(t)
        {
        }
    }
}
