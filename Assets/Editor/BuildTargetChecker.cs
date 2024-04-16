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
        //Debug.Log("��e��BuildTarget�O�G" + activeTarget.ToString());

        //var settings = AddressableAssetSettingsDefaultObject.Settings;
        //var path = AddressableAssetSettings.kRemoteBuildPathValue;
        //Debug.Log(path);
        //// �ˬdbuildTarget
        ////var buildTarget = settings.activeProfileSettings.GetBuildTarget(settings.activeProfileId);
        //var buildTarget = settings.activeProfileId;

        //// ��X��e��buildTarget
        //Debug.Log("��e��Build Target�O: " + buildTarget);

        // �����e���ʪ� Profile ID
        string activeProfileId = AddressableAssetSettingsDefaultObject.Settings.activeProfileId;

        // �ϥ� Profile ID ����� BuildTarget �W��
        string buildTargetName = AddressableAssetSettingsDefaultObject.Settings.profileSettings.GetValueByName(activeProfileId, "BuildTarget");
        Debug.Log(buildTargetName);

    }

    [MenuItem("Build/Perform Build")]
    public static void PerformBuild()
    {
        // �����e��BuildTarget
        //string buildTargetName = EditorUserBuildSettings.activeBuildTarget.ToString();

        // �����e���ʪ� Profile ID
        string activeProfileId = AddressableAssetSettingsDefaultObject.Settings.activeProfileId;

        // �ϥ� Profile ID ����� BuildTarget �W��
        string buildTargetName = AddressableAssetSettingsDefaultObject.Settings.profileSettings.GetValueByName(activeProfileId, "BuildTarget");
        // �NBuildTarget�W�٫O�s��@�Ӥ奻���
        File.WriteAllText("Assets/StreamingAssets/BuildTargetName.txt", buildTargetName);

        // ��L�c�ؾާ@...
    }
}
