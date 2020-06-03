using Foundation;
using ObjCRuntime;
using UIKit;

namespace iOSDummyAppBehavior
{
	// @interface MainViewBehavior : NSObject
	[BaseType (typeof(NSObject))]
	interface MainViewBehavior
	{
		// @property (nonatomic, weak) UILabel * _Null_unspecified lblCounter __attribute__((iboutlet));
		[Export ("lblCounter", ArgumentSemantic.Weak)]
		UILabel LblCounter { get; set; }

		// -(void)btnIncrement_OnClickWithSender:(UIButton * _Nonnull)sender __attribute__((ibaction));
		[Export ("btnIncrement_OnClickWithSender:")]
		void BtnIncrement_OnClickWithSender (UIButton sender);
	}
}
