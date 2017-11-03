using System;
using ARKit;
using SceneKit;

namespace ARKitFaceExample {
	public interface IVirtualFaceContent {
		void Update (ARFaceAnchor anchor);
	}
}
