using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Common.Utility;
using Framework.AssetBundles.Config;
using Framework.AssetBundles.Utilty;
using GameTools.Singletons;
using UnityEngine;
using XLua;

public class XluaManager : MMOSingletonDontDestroy<XluaManager>
{
    public const string luaScriptsFolder = "LuaScript";
    public const string luaAssetbundleAssetName = "Lua";

    /// <summary>
    /// 全局lua虚拟机
    /// </summary>
    private LuaEnv luaEnv = null;

    public override void OnAwake()
    {
        string path = AssetBundleUtility.PackagePathToAssetsPath(luaAssetbundleAssetName);
        AssetbundleName = AssetBundleUtility.AssetBundlePathToAssetBundleName(path);
        InitLuaEnv();
    }
    public string AssetbundleName
    {
        get;
        protected set;
    }
    public static byte[] CustomLoader(ref string filepath)
    {
        string scriptPath = string.Empty;
        filepath =$"{filepath.Replace(".", "/")}.lua";
#if UNITY_EDITOR
        if (AssetBundleConfig.IsEditorMode)
        {
            scriptPath = Path.Combine(Application.dataPath, luaScriptsFolder);
            scriptPath = Path.Combine(scriptPath, filepath);
            return GameUtility.SafeReadAllBytes(scriptPath);
        }
#endif

        scriptPath = $"{luaAssetbundleAssetName}/{filepath}.bytes";
        string assetbundleName = null;
        string assetName = null;
        bool status = false;
        if (!status)
        {
            Debug.LogError("MapAssetPath failed : " + scriptPath);
            return null;
        }

        var asset = false;
        if (asset != null)
        {
            //Logger.Log("Load lua script : " + scriptPath);
            // return asset;
        }
        Debug.LogError("Load lua script failed : " + scriptPath + ", You should preload lua assetbundle first!!!");
        return null;
    }
    /// <summary>
    /// 初始化lua虚拟机
    /// </summary>
    private void InitLuaEnv()
    {
        luaEnv = new LuaEnv();
        if (luaEnv != null)
        {
            luaEnv.AddLoader(CustomLoader);
            // luaEnv.AddBuildin("pb", XLua.LuaDLL.Lua.LoadPb);
        }
        else
        {
            Debug.LogError("InitLuaEnv null!!!");
        }
    }
    

    public void ReStart()
    {
        Disable();
        InitLuaEnv();
        OnAwake();
    }
    /// <summary>
    /// 采用安全模式读取lua代码
    /// </summary>
    /// <param name="scriptContent"></param>
    public void SafeDoString(string scriptContent)
    {
        if (luaEnv == null) return;
        try
        {
            luaEnv.DoString(@scriptContent);
        }
        catch (System.Exception ex)
        {
            string msg = $"xLua exception : {ex.Message}\n {ex.StackTrace}";
            Debug.LogError(msg, null);
        }
    }
    
    
    public override void Disable()
    {
        if (luaEnv == null) return;
        try
        {
            luaEnv.Dispose();
            luaEnv = null;
        }
        catch (Exception ex)
        {
            string msg = $"xLua exception : {ex.Message}\n {ex.StackTrace}";
            Debug.LogError(msg, null);
        }
    }

   
}