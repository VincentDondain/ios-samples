using System;
using System.IO;
using ARKit;
using Foundation;
using SceneKit;

namespace ARKitFaceExample {
	public class RobotHead : SCNReferenceNode, IVirtualFaceContent {

		float originalJawY = 0;

		SCNNode JawNode { get; set; }
		SCNNode EyeLeftNode { get; set; }
		SCNNode EyeRightNode { get; set; }

		float JawHeight {
			get {
				SCNVector3 min = new SCNVector3 ();
				SCNVector3 max = new SCNVector3 ();
				//TODO: this API needs to return a tuple
				JawNode.GetBoundingBox (ref min, ref max);
				return max.Y - min.Y;
			}
		}

		public RobotHead (NSUrl url) : base (url)
		{
			JawNode = FindChildNode ("jaw", true);
			EyeLeftNode = FindChildNode ("eyeLeft", true);
			EyeRightNode = FindChildNode ("eyeRight", true);

			//var url = NSBundle.MainBundle.GetUrlForResource ("robotHead", "scn", "Models.scnassets");
			//if (url == null)
				//throw new FileNotFoundException ("missing expected bundle resource");

			Load ();
			originalJawY = JawNode.Position.Y;
		}

		public void Update (ARFaceAnchor anchor)
		{
			throw new NotImplementedException ();
		}
	}
}
