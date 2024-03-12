using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class addressableCS : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    string AddressNameStr;
    GameObject assetObj;

    public InputField pra;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //Addressables.LoadAssetAsync<GameObject>(AddressNameStr).Completed += OnAssetObjLoaded;
            //Instantiate(assetObj);
        }

        if (Input.GetKeyUp(KeyCode.Z))
        {
            //AddressNameStr = pra.text;
            Addressables.LoadAssetAsync<GameObject>(AddressNameStr).Completed += OnAssetObjLoaded;
        }
    }

    void OnAssetObjLoaded(AsyncOperationHandle<GameObject> asyncOperationHandle)
    {
        assetObj = asyncOperationHandle.Result;
    }
}
