using ARKit;
using SceneKit;
using UIKit;

namespace ARKitFaceExample {
	public class Mask : SCNNode, IVirtualFaceContent {
		public Mask (ARSCNFaceGeometry geometry)
		{
			var material = geometry.FirstMaterial;

			material.Diffuse.Contents = UIColor.LightGray;
			material.LightingModelName = SCNLightingModel.PhysicallyBased;

			Geometry = geometry;
		}

		public void Update (ARFaceAnchor anchor)
		{
			if (Geometry is ARSCNFaceGeometry faceGeometry)
				faceGeometry.Update (anchor.Geometry);
		}
	}
}
