using UnityEditor;
using UnityEngine;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Settings;

public class BuildTargetChecker
{
    [MenuItem("Build/Check Active Build Target")]
    public static void CheckActiveBuildTarget()
    {
        //BuildTarget activeTarget = EditorUserBuildSettings.activeBuildTarget;
        //Debug.Log("當前的BuildTarget是：" + activeTarget.ToString());

        var settings = AddressableAssetSettingsDefaultObject.Settings;

        // 檢查buildTarget
        //var buildTarget = settings.activeProfileSettings.GetBuildTarget(settings.activeProfileId);
        var buildTarget = settings.activeProfileId;
       
        // 輸出當前的buildTarget
        Debug.Log("當前的Build Target是: " + buildTarget);
    }
}
