using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace iOSDummyAppBehavior
{
	// @interface MainViewBehavior : UIViewController
	[BaseType (typeof(UIViewController))]
	interface MainViewBehavior
	{
		// @property (nonatomic, weak) UILabel * _Null_unspecified lblCounter __attribute__((iboutlet));
		[Export ("lblCounter", ArgumentSemantic.Weak)]
		UILabel LblCounter { get; set; }

		// -(void)btnIncrement_OnClickWithSender:(UIButton * _Nonnull)sender __attribute__((ibaction));
		[Export ("btnIncrement_OnClickWithSender:")]
		void BtnIncrement_OnClickWithSender (UIButton sender);

		// -(void)viewDidLoad;
		[Export ("viewDidLoad")]
		void ViewDidLoad ();

		// -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
		//[Export ("initWithNibName:bundle:")]
		//[DesignatedInitializer]
		//IntPtr Constructor ([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		//[Export ("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor (NSCoder coder);
	}
}
