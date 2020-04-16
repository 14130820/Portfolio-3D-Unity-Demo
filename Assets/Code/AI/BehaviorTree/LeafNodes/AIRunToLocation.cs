using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NodeCanvas.BehaviourTrees;
using TreeEditor;
using NodeCanvas.Framework;

/// <summary>
/// Movement Behaviors animate the lower body movement and transform physics.
/// </summary>
public class AIRunToLocation : ActionTask {

	public AIPositionNode nodeToRunTo;

	// Start Animation
	protected override void OnExecute() {

	}

	// Physically Lerp towards position
	// Access Pathing.
	// Notify on arrival
	protected override void OnUpdate() {

	}
}