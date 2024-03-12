using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class PrefabChange : MonoBehaviour
{
    GameObject assetObj;
    [SerializeField]
    Text ChangePrefab;

    List<GameObject> A1;
    // Start is called before the first frame update
    void Start()
    {
        Addressables.LoadAssetAsync<GameObject>("A_Scence").Completed += OnAssetObjLoaded;

        Addressables.LoadAssetAsync<List<GameObject>>("TestScencePrefab").Completed += OnAssetObjLoaded2;
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void A_BTN()
    {
        ChangePrefab.text += "A";
        //Addressables.LoadAssetAsync<GameObject>("A_Scence").Completed += OnAssetObjLoaded;
        Instantiate(assetObj);
    }

    public void B_BTN()
    {
        ChangePrefab.text += "B";
        //Addressables.LoadAssetAsync<IList<GameObject>>("TestScencePrefab").Completed += OnAssetObjLoaded2;
    }

    public void C_BTN()
    {
        ChangePrefab.text += "C";
        //Addressables.LoadAssetAsync<IList<GameObject>>("TestScencePrefab").Completed += OnAssetObjLoaded2;
    }

    void OnAssetObjLoaded(AsyncOperationHandle<GameObject> asyncOperationHandle)
    {
        assetObj = asyncOperationHandle.Result;
    }
    void OnAssetObjLoaded2(AsyncOperationHandle<List<GameObject>> asyncOperationHandle)
    {
        var v = asyncOperationHandle.ToString();
        print(v);
    }

   
}
