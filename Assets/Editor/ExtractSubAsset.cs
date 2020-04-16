#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

namespace DSwieringa.Portfolio {
	public static class ExtractSubAsset {

		[MenuItem("Assets/Sub Assets/Extract Sub Asset", true)]
		private static bool ExtractSubAssetContextMenuValidation() {

			return AssetDatabase.IsSubAsset(Selection.activeObject.GetInstanceID());
		}

		[MenuItem("Assets/Sub Assets/Extract Sub Asset", false)]
		private static void ExtractSubAssetContextMenu() {
			var asset = Selection.activeObject;
			var path = AssetDatabase.GetAssetPath(asset);

			var savePath = EditorUtility.SaveFilePanelInProject("Save As", asset.name, string.Empty, string.Empty, path);

			if (!string.IsNullOrWhiteSpace(path)) {
				var error = AssetDatabase.ExtractAsset(asset, savePath);

				if (!string.IsNullOrEmpty(error)) {
					Debug.LogError(error);
				}

				AssetDatabase.WriteImportSettingsIfDirty(path);
				AssetDatabase.ImportAsset(path, ImportAssetOptions.ForceUpdate);
			}
		}
	}
}
#endif