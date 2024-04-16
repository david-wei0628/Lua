using UnityEditor;
using UnityEngine;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Settings;
using System.IO;

public class BuildTargetChecker
{
    [MenuItem("Build/Check Active Build Target")]
    public static void CheckActiveBuildTarget()
    {
        //BuildTarget activeTarget = EditorUserBuildSettings.activeBuildTarget;
        //Debug.Log("當前的BuildTarget是：" + activeTarget.ToString());

        //var settings = AddressableAssetSettingsDefaultObject.Settings;
        //var path = AddressableAssetSettings.kRemoteBuildPathValue;
        //Debug.Log(path);
        //// 檢查buildTarget
        ////var buildTarget = settings.activeProfileSettings.GetBuildTarget(settings.activeProfileId);
        //var buildTarget = settings.activeProfileId;

        //// 輸出當前的buildTarget
        //Debug.Log("當前的Build Target是: " + buildTarget);

        // 獲取當前活動的 Profile ID
        string activeProfileId = AddressableAssetSettingsDefaultObject.Settings.activeProfileId;

        // 使用 Profile ID 來獲取 BuildTarget 名稱
        string buildTargetName = AddressableAssetSettingsDefaultObject.Settings.profileSettings.GetValueByName(activeProfileId, "BuildTarget");
        Debug.Log(buildTargetName);

    }

    [MenuItem("Build/Perform Build")]
    public static void PerformBuild()
    {
        // 獲取當前的BuildTarget
        //string buildTargetName = EditorUserBuildSettings.activeBuildTarget.ToString();

        // 獲取當前活動的 Profile ID
        string activeProfileId = AddressableAssetSettingsDefaultObject.Settings.activeProfileId;

        // 使用 Profile ID 來獲取 BuildTarget 名稱
        string buildTargetName = AddressableAssetSettingsDefaultObject.Settings.profileSettings.GetValueByName(activeProfileId, "BuildTarget");
        // 將BuildTarget名稱保存到一個文本文件中
        File.WriteAllText("Assets/StreamingAssets/BuildTargetName.txt", buildTargetName);

        // 其他構建操作...
    }
}
