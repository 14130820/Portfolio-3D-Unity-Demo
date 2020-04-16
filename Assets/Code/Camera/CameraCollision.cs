using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[HideMonoScript]
public class CameraCollision : MonoBehaviour {
	[BoxGroup("Depencencies")]
	[SerializeField, Required]
	private Transform targetTransform = null;

	[SerializeField]
	private float localGroundDistance = 0;

	private void LateUpdate() {
		var parentY = transform.parent.localPosition.y;
		if (parentY <= localGroundDistance) {
			var distance = Mathf.Abs(parentY - localGroundDistance);
			var localPos = transform.localPosition;

			var directionToTarget = targetTransform.position - transform.position;
			directionToTarget.y = localGroundDistance;

			transform.position = targetTransform.TransformPoint(new Vector3(distance, 0, 0));
		} else {

		}
	}
}
