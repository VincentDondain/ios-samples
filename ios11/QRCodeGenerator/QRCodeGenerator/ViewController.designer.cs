// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace QRCodeGenerator
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton GenerateQRCodeButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField InputTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView QRCodeImage { get; set; }

        [Action ("GenerateQRCodeButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void GenerateQRCodeButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (GenerateQRCodeButton != null) {
                GenerateQRCodeButton.Dispose ();
                GenerateQRCodeButton = null;
            }

            if (InputTextField != null) {
                InputTextField.Dispose ();
                InputTextField = null;
            }

            if (QRCodeImage != null) {
                QRCodeImage.Dispose ();
                QRCodeImage = null;
            }
        }
    }
}