using System;
using CoreGraphics;
using CoreImage;
using Foundation;
using UIKit;

namespace QRCodeGenerator {
	public partial class ViewController : UIViewController {
		protected ViewController (IntPtr handle) : base (handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void GenerateQRCodeButton_TouchUpInside (UIButton sender)
		{
			var filter = new CIQRCodeGenerator {
				Message = NSData.FromString (InputTextField.Text, NSStringEncoding.ISOLatin1),
				CorrectionLevel = "Q"
			};

			// The QR code needs to be scaled up to fit the UIImage size.
			var transformedImage = filter.OutputImage.ImageByApplyingTransform (CGAffineTransform.MakeScale (QRCodeImage.Frame.Size.Width, QRCodeImage.Frame.Size.Height));
			QRCodeImage.Image = new UIImage (transformedImage);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
