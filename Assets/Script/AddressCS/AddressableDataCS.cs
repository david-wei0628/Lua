using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.Initialization;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AddressableDataCS : MonoBehaviour
{
    public Text Lable;
    public string newLocalPath;
    public void Data_BTN()
    {
        //string buildTargetValue = AddressableRuntimeProperties.GetPropertyValue("BuildTargetValue");
        //AddressablesRuntimeProperties.SetPropertyValue("BuildTragetValue", "ScencePrfab2");
        ///*string buildTargetValue = */AddressablesRuntimeProperties.SetPropertyValue("BuildTarget","VV");
        //print(buildTargetValue);
        string runtimePath = Addressables.RuntimePath;
        string buildTargetName = AddressablesRuntimeProperties.EvaluateProperty("BuildTarget");
        string fullPath = $"{runtimePath}/{buildTargetName}";
        Debug.Log(buildTargetName);
        ResourceManagerRuntimeData runtimeData = new ResourceManagerRuntimeData();
        string A = runtimeData.BuildTarget;
        print(A);
        //Addressables.InitializeAsync().Completed += OnAddressablesInitialized;
    }


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




