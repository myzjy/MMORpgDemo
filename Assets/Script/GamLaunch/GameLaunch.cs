using System;
using System.Collections;
using System.Collections.Generic;
using Common.Utility;
using Framework.AssetBundles.Utilty;
using Script.Framework.AssetBundle;
using UnityEngine;
using UnityEngine.AddressableAssets;
using XLua;

public class GameLaunch : MonoBehaviour
{
    AssetBundleUpdater updater;

    // Start is called before the first frame update
    IEnumerator Start()
    {
 
        //初始化版本号
        /**
         * 此处的时间是向服务器请求的，不能用本机时间
         */
        var startTime = DateTime.Now;
        yield return InitAppVersion();
        ToolsDebug.Log($"InitAppVersion use {(DateTime.Now - startTime).Milliseconds}ms");
        if (updater != null)
        {
            updater.StartCheckUpdate();
        }
        
    }
    private IEnumerator InitAppVersion()
    {
        var appVersionRequest = AssetBundleManager.Instance.RequestAssetFileAsync(BuildUtils.AppVersionFileName);
        yield return appVersionRequest;
        var streamingAppVersion = appVersionRequest.text;
        appVersionRequest.Dispose();

        var appVersionPath = AssetBundleUtility.GetPersistentDataPath(BuildUtils.AppVersionFileName);
        var persistentAppVersion = GameUtility.SafeReadAllText(appVersionPath);
        ToolsDebug.Log($"streamingAppVersion = {streamingAppVersion}, persistentAppVersion = {persistentAppVersion}");

        // 如果persistent目录版本比streamingAssets目录app版本低，说明是大版本覆盖安装，清理过时的缓存
        if (!string.IsNullOrEmpty(persistentAppVersion) && BuildUtils.CheckIsNewVersion(persistentAppVersion, streamingAppVersion))
        {
            var path = AssetBundleUtility.GetPersistentDataPath();
            GameUtility.SafeDeleteDir(path);
        }
        GameUtility.SafeWriteAllText(appVersionPath, streamingAppVersion);
        // ChannelManager.instance.appVersion = streamingAppVersion;

    }
}