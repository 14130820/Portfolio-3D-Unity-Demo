using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DSwieringa.Portfolio {
	public abstract class Manager<T> : MonoBehaviour where T : MonoBehaviour {
		private static T instance;
		public static T Instance => instance;

		protected void Awake() {
			if (instance == null) {
				instance = this as T;
			} else {
				Destroy(this);
			}
		}
	}
}