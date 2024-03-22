using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

public class PrefabChange : MonoBehaviour
{
    GameObject assetObj;
    [SerializeField]
    Text ChangePrefab;
    [SerializeField]
    Text ListPrefab;
    [SerializeField]
    List<GameObject> A1;

    int i = 0;

    public AssetLabelReference assetLabel;

    // Start is called before the first frame update
    void Start()
    {
        Addressables.LoadAssetAsync<GameObject>("A_Scence").Completed += OnAssetObjLoaded;
        //StartCoroutine(PrefabList());

        OnAssetObjLoaded2();
        //Addressables.LoadAssetAsync<GameObject>("TestScencePrefab").Completed += OnAssetObjLoaded2;
        //Addressables.LoadResourceLocationsAsync(assetLabel, null).Completed += LoadResourceAsync;
    }


    // Update is called once per frame
    void Update()
    {
        //ChangePrefab.text = A1[i].name + i;
    }

    public void A_BTN()
    {
        if (i == A1.Count - 1)
        {
            i = 0;
        }
        else
        {
            i++;
        }
        ChangePrefab.text = A1[i].name + i;
        //Addressables.LoadAssetAsync<GameObject>("A_Scence").Completed += OnAssetObjLoaded;
        //Instantiate(assetObj);
    }

    public void B_BTN()
    {
        if (i <= 0)
        {
            i = A1.Count - 1;
        }
        else
        {
            i--;
        }
        ChangePrefab.text = A1[i].name + i;
        //Addressables.LoadAssetAsync<IList<GameObject>>("TestScencePrefab").Completed += OnAssetObjLoaded2;
    }

    public void C_BTN()
    {
        //ChangePrefab.text += "C";
        //Addressables.LoadAssetAsync<IList<GameObject>>("TestScencePrefab").Completed += OnAssetObjLoaded2;
        ListPrefab.text = A1.Count.ToString();
        Instantiate(A1[i]);
    }

    void OnAssetObjLoaded(AsyncOperationHandle<GameObject> asyncOperationHandle)
    {
        assetObj = asyncOperationHandle.Result;
    }
    void OnAssetObjLoaded2(/*AsyncOperationHandle<List<GameObject>> asyncOperationHandle*/)
    {
        AsyncOperationHandle<IList<GameObject>> loadWithSingleKeyHandle = Addressables.LoadAssetsAsync<GameObject>(assetLabel, obj =>
        {
            //Gets called for every loaded asset
            A1.Add(obj);
            ListPrefab.text += obj.name + A1.Count + "\n";
        });
    }
    void LoadResourceAsync(AsyncOperationHandle<IList<IResourceLocation>> obj)
    {
        foreach (var resource in obj.Result)
        {
            //A1.Add(GameObject.Destroy(resource));
            print(resource.ToString());

        }
        //ListPrefab.text = Addressables.RuntimePath;
    }

    /*IEnumerator PrefabList()
    {
        A = Addressables.LoadAssetsAsync<GameObject>("TestScencePrefab", obj =>
        {
            Debug.Log(obj.name);
        });
        yield return A;
    }*/
}
