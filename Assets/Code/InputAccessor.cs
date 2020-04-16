using Rewired;

namespace DSwieringa.Portfolio {

	/// <summary>
	/// Provides easy access to all input.
	/// </summary>
	public static class InputAccessor {

		public static Player DefaultPlayer => defaultPlayer == null ? defaultPlayer = ReInput.players.GetSystemPlayer() : defaultPlayer;

		public static int XMovement => ReInput.mapping.GetActionId("XMovement");
		public static int YMovement => ReInput.mapping.GetActionId("YMovement");

		public static int XLook => ReInput.mapping.GetActionId("XLook");
		public static int YLook => ReInput.mapping.GetActionId("YLook");

		public static int Jump => ReInput.mapping.GetActionId("Jump");
		public static int Interact => ReInput.mapping.GetActionId("Interact");
		public static int Attack1 => ReInput.mapping.GetActionId("Attack1");
		public static int Attack2 => ReInput.mapping.GetActionId("Attack2");
		public static int Special => ReInput.mapping.GetActionId("Special");
		public static int Dash => ReInput.mapping.GetActionId("Dash");

		private static Player defaultPlayer;
	}
}