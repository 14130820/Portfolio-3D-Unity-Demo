using Sirenix.OdinInspector;
using UnityEngine;

namespace DSwieringa.Portfolio {
	[HideMonoScript]
	public class LockOnTransformPosition : MonoBehaviour {

		[BoxGroup("Depencencies")]
		[SerializeField, Required]
		private Transform targetTransform = null;

		[SerializeField]
		private Vector3 positionOffset = Vector3.zero;

		private void LateUpdate() {
			transform.position = targetTransform.position + positionOffset;
		}
	}
}