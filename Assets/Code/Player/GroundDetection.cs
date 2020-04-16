using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DSwieringa.Portfolio {
	[HideMonoScript]
	public class GroundDetection : MonoBehaviour {

		public bool IsGrounded { get; private set; }

		private void OnCollisionEnter(Collision collision) {
			if (collision.collider.GetComponent<GroundDetection>() != null) {
				IsGrounded = true;
			}
		}

		private void OnCollisionExit(Collision collision) {
			if (collision.collider.GetComponent<GroundDetection>() != null) {
				IsGrounded = false;
			}
		}
	}
}