using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPositionNode : MonoBehaviour
{
	public Vector3 Position => tf.position;

	private Transform tf;

	private void Start() {
		tf = this.transform;
	}
}
