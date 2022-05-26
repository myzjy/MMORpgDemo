using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using XLua;

[LuaCallCSharp]
[Hotfix]
public class GameMain : MonoBehaviour
{
    void Start()
    {
        Addressables.LoadAssetAsync<TextAsset>("GameMain.lua").Completed += (item) =>
        {
            var luaStr = item.Result.text;
            Debug.Log(item.Result.text);
            Debug.Log(XluaManager.Instance.AssetbundleName);
            XluaManager.Instance.SafeDoString(item.Result.text);
            // XluaManager.Instance.SafeDoString("GameMain.OnInit()");
            OnInit();
        };
    }
    [Hotfix]
    public void OnInit()
    {
        
    }
}
