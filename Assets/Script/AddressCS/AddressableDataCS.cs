using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.Initialization;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;
using System.IO;
using System.Collections.Generic;

public class AddressableDataCS : MonoBehaviour
{
    public Text Lable;
    public string newLocalPath;
    public string A;
    string dataass = "BuildTargetNameN";

    public void Data_BTN()
    {
        ReadAddressableBuildTarget();
    }

    void ReadAddressableBuildTarget()
    {
        Addressables.LoadAssetAsync<TextAsset>(dataass).Completed += handle =>
        {
            if (handle.Status == AsyncOperationStatus.Succeeded)
            {
                // ����奻���e�A�YbuildTarget�W��
                //string buildTargetName = handle.Result.text;
                //Debug.Log("Current Build Target: " + buildTargetName);
                Debug.Log("A");
            }
        };
        //Addressables.LoadResourceLocationsAsync(dataass).Completed += handle =>
        //{
        //    if (handle.Status == AsyncOperationStatus.Succeeded)
        //    {
        //        // �[�����\�A�B�z�귽��m
        //        var locations = handle.Result;
        //        foreach (var location in locations)
        //        {
        //            Debug.Log($"���귽: {location.PrimaryKey}");
        //        }
        //    }
        //    else
        //    {
        //        // �[�����ѡA�B�z���~
        //        Debug.LogError("�L�k�[���귽��m�C");
        //    }
        //};
    }

    /* ////string buildTargetValue = AddressableRuntimeProperties.GetPropertyValue("BuildTargetValue");
     ////AddressablesRuntimeProperties.SetPropertyValue("BuildTragetValue", "ScencePrfab2");
     /////*string buildTargetValue = //AddressablesRuntimeProperties.SetPropertyValue("BuildTarget","VV");
     ////print(buildTargetValue);
     //string runtimePath = Addressables.RuntimePath;
     //string buildTargetName = AddressablesRuntimeProperties.EvaluateProperty("BuildTarget");
     //string fullPath = $"{runtimePath}/{buildTargetName}";
     //string buildTarget = AddressablesRuntimeProperties.EvaluateProperty("[BuildTarget]");
     //ResourceManagerRuntimeData runtimeData = new ResourceManagerRuntimeData();

     //Addressables.InitializeAsync().Completed += OnAddressablesInitialized;*/

    //void LoadActiveProfileId()
    //{
    //    // ��?�z�w?�b�۫�?�{��?�ؤF�@?�]�tProfile ID���奻���A�}?���bResources���?��
    //    TextAsset profileIdText = Resources.Load<TextAsset>("ProfileID");
    //    if (profileIdText != null)
    //    {
    //        newLocalPath = profileIdText.text;
    //    }
    //    else
    //    {
    //        Debug.LogError("����[?Profile ID!");
    //    }
    //}

    /*void OnAddressablesInitialized(AsyncOperationHandle<IResourceLocator> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {
            // �T�O�s���|�O���Ī��A�M���s Addressables �����a�[�����|
            Addressables.InternalIdTransformFunc = (location) =>
            {
                if (location.InternalId.StartsWith("file://"))
                {
                    return newLocalPath + location.InternalId.Substring(7);
                }
                return location.InternalId;
            };
        }
    }*/
}




