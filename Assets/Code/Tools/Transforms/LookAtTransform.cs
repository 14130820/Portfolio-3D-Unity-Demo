using Sirenix.OdinInspector;
using UnityEngine;

namespace DSwieringa.Portfolio {
	/// <summary>
	/// Moves the transform up and down depending on mouse Y input.
	/// </summary>
	[HideMonoScript]
	public class LookAtTransform : MonoBehaviour {
		[BoxGroup("Depencencies")]
		[SerializeField, Required]
		private Transform targetTransform = null;

		public void LateUpdate() {
			this.transform.LookAt(targetTransform, Vector3.up);
		}
	}
}
