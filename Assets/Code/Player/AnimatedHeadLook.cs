using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DSwieringa.Portfolio {
	public class AnimatedHeadLook : MonoBehaviour {
		[SerializeField]
		private Transform cameraTarget;

		private Animator anim;

		private void Start() {
			anim = GetComponent<Animator>();
		}

		private void OnAnimatorIK(int layerIndex) {
			anim.SetBoneLocalRotation(HumanBodyBones.Head, cameraTarget.localRotation);
		}
	}
}