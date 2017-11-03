using System;
using ARKit;
using SceneKit;

namespace ARKitFaceExample {
	public class GlassesOverlay : SCNNode, IVirtualFaceContent {
		SCNNode occlusionNode;

		public GlassesOverlay (ARSCNFaceGeometry geometry)
		{
			if (geometry.FirstMaterial != null)
				geometry.FirstMaterial.ColorBufferWriteMask = SCNColorMask.All;

			occlusionNode = new SCNNode (geometry) {
				RenderingOrder = -1
			};
			AddChildNode (occlusionNode);

			//var faceOverlayContent = Load
			//AddChildNode (faceOverlayContent);
		}

		public void Update (ARFaceAnchor anchor)
		{
			if (Geometry is ARSCNFaceGeometry faceGeometry)
				faceGeometry.Update (anchor.Geometry);
		}
	}
}
