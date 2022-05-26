using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using XLua;

public class GameLaunch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Addressables.LoadAssetAsync<TextAsset>("GameMain.lua").Completed += (item) =>
        // {
        //     var luaStr = item.Result.text;
        //     Debug.Log(item.Result.text);
        //     Debug.Log(XluaManager.Instance.AssetbundleName);
        //     XluaManager.Instance.SafeDoString(item.Result.text);
        //     // XluaManager.Instance.SafeDoString("GameMain.OnInit()");
        //     OnInit();
        // };
    }
    
    public void OnInit()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}