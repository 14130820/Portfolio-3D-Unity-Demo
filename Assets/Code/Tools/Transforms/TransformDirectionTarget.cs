using Sirenix.OdinInspector;
using UnityEngine;

namespace DSwieringa.Portfolio {
	/// <summary>
	/// Smoothly rotates this transform around a target transform based on the target's direction and a positional offset.
	/// </summary>
	[HideMonoScript]
	public class TransformDirectionTarget : MonoBehaviour {

		[BoxGroup("Depencencies")]
		[SerializeField, Required]
		private Transform targetTransform = null;

		[SerializeField]
		private Vector3 positionOffset = Vector3.zero;
		[SerializeField]
		private float smoothSpeed = 0.15f;

		private Vector3 cachedSmoothDampPos;

		private void LateUpdate() {
			transform.position = Vector3.SmoothDamp(
				transform.position, 
				targetTransform.position + targetTransform.TransformDirection(positionOffset), 
				ref cachedSmoothDampPos, 
				smoothSpeed);
		}
	}
}