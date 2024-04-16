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
                // 獲取文本內容，即buildTarget名稱
                //string buildTargetName = handle.Result.text;
                //Debug.Log("Current Build Target: " + buildTargetName);
                Debug.Log("A");
            }
        };
        //Addressables.LoadResourceLocationsAsync(dataass).Completed += handle =>
        //{
        //    if (handle.Status == AsyncOperationStatus.Succeeded)
        //    {
        //        // 加載成功，處理資源位置
        //        var locations = handle.Result;
        //        foreach (var location in locations)
        //        {
        //            Debug.Log($"找到資源: {location.PrimaryKey}");
        //        }
        //    }
        //    else
        //    {
        //        // 加載失敗，處理錯誤
        //        Debug.LogError("無法加載資源位置。");
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
    //    // 假?您已?在构建?程中?建了一?包含Profile ID的文本文件，并?其放在Resources文件?中
    //    TextAsset profileIdText = Resources.Load<TextAsset>("ProfileID");
    //    if (profileIdText != null)
    //    {
    //        newLocalPath = profileIdText.text;
    //    }
    //    else
    //    {
    //        Debug.LogError("未能加?Profile ID!");
    //    }
    //}

    /*void OnAddressablesInitialized(AsyncOperationHandle<IResourceLocator> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {
            // 確保新路徑是有效的，然後更新 Addressables 的本地加載路徑
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




