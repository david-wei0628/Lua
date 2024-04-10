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
        //Debug.Log("��e��BuildTarget�O�G" + activeTarget.ToString());

        var settings = AddressableAssetSettingsDefaultObject.Settings;

        // �ˬdbuildTarget
        //var buildTarget = settings.activeProfileSettings.GetBuildTarget(settings.activeProfileId);
        var buildTarget = settings.activeProfileId;
       
        // ��X��e��buildTarget
        Debug.Log("��e��Build Target�O: " + buildTarget);
    }
}
