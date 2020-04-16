using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace DSwieringa.Portfolio {
	public class GameManager : Manager<GameManager> {

		protected new void Awake() {
			base.Awake();
			DontDestroyOnLoad(this);
		}
	}
}