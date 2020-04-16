using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DSwieringa.Portfolio {
	[HideMonoScript]
	public class CameraYLook : MonoBehaviour {

		[SerializeField]
		private float mouseYSensitivity = 25f;

		private float offset;

		private void LateUpdate() {
			offset = -1f * InputAccessor.DefaultPlayer.GetAxis(InputAccessor.YLook) * mouseYSensitivity * Time.deltaTime;

			transform.Rotate(new Vector3(
				offset,
				0,
				0
				));
		}
	}
}