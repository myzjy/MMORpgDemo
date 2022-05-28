﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Common.Utility;
using Framework.AssetBundles.Config;
using Framework.AssetBundles.Utilty;
using GameTools.Singletons;
using Script.Framework.AssetBundle;
using UnityEngine;
using XLua;

public class XluaManager : MMOSingletonDontDestroy<XluaManager>
{
    public const string luaScriptsFolder = "LuaScript";

    public const string luaAssetbundleAssetName = "Lua";

    //热修复的lua逻辑脚步
    const string hotfixMainScriptName = "XLua.HotfixMain";

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

    public string AssetbundleName { get; protected set; }

    public static byte[] CustomLoader(ref string filepath)
    {
        string scriptPath = string.Empty;
        filepath = $"{filepath.Replace(".", "/")}.lua";
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
        bool status = AssetBundleManager.Instance.MapAssetPath(scriptPath, out assetbundleName, out assetName);
        if (!status)
        {
            ToolsDebug.LogError($"MapAssetPath failed : {scriptPath}");
            return null;
        }

        var asset = AssetBundleManager.Instance.GetAssetCache(assetName) as TextAsset;
        if (asset != null)
        {
            //Logger.Log("Load lua script : " + scriptPath);
            return asset.bytes;
        }

        ToolsDebug.LogError($"Load lua script failed : {scriptPath}, You should preload lua assetbundle first!!!");
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

    private void Update()
    {
        if (luaEnv == null) return;
        luaEnv.Tick();

        if (Time.frameCount % 100 == 0)
        {
            luaEnv.FullGc();
        }
    }

    public void OnInit()
    {
        if (luaEnv != null)
        {
            // LoadScript(commonMainScriptName);
            // luaUpdater = gameObject.GetComponent<LuaUpdater>();
            // if (luaUpdater == null)
            // {
            //     luaUpdater = gameObject.AddComponent<LuaUpdater>();
            // }
            // luaUpdater.OnInit(luaEnv);
            var luaUpdate = luaEnv.Global.Get<Action<float, float>>("Update");
            var luaLateUpdate = luaEnv.Global.Get<Action>("LateUpdate");
            var luaFixedUpdate = luaEnv.Global.Get<Action<float>>("FixedUpdate");
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
    public void SafeDoString(string scriptContent, string chunkName = "chunk")
    {
        if (luaEnv == null) return;
        try
        {
            luaEnv.DoString(scriptContent, chunkName);
        }
        catch (System.Exception ex)
        {
            string msg = $"xLua exception : {ex.Message}\n {ex.StackTrace}";
            Debug.LogError(msg, null);
        }
    }

    private void StopHotfix()
    {
        SafeDoString("HotfixMain.Stop()");
    }

    public void StartHotfix(bool restart = false)
    {
        if (luaEnv == null)
        {
            return;
        }

        if (restart)
        {
            StopHotfix();
            ReloadScript(hotfixMainScriptName);
        }
        else
        {
            LoadScript(hotfixMainScriptName);
        }

        SafeDoString("HotfixMain.Start()");
    }

    public void ReloadScript(string scriptName)
    {
        SafeDoString($"package.loaded['{scriptName}'] = nil");
        LoadScript(scriptName);
    }

    public void LoadScript(string scriptName)
    {
        SafeDoString($"require('{scriptName}')");
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

    public void Restart()
    {
        StopHotfix();
        Dispose();
        InitLuaEnv();
        OnInit();
    }

    public override void Dispose()
    {
        // if ( != null)
        // {
        //     OnDispose();
        // }
        if (luaEnv == null) return;
        try
        {
            luaEnv.Dispose();
            luaEnv = null;
        }
        catch (System.Exception ex)
        {
            string msg = $"xLua exception : {ex.Message}\n {ex.StackTrace}";
            ToolsDebug.LogError(msg, null);
        }
    }
}
#if UNITY_EDITOR
public static class LuaUpdaterExporter
{
    [CSharpCallLua] public static List<Type> CSharpCallLua = new List<Type>()
    {
        typeof(Action),
        typeof(Action<float>),
        typeof(Action<float, float>),
    };
}
#endif