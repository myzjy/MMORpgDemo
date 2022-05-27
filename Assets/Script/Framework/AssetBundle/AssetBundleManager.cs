using System.Collections.Generic;
using AssetBundles.Config;
using Common.Utility;
using Framework.AssetBundle.AsyncOperation;
using Framework.AssetBundle.Config;
using Framework.AssetBundles.Config;
using Framework.AssetBundles.Utilty;
using GameTools.Singletons;
using UnityEngine;
using XLua;

namespace Script.Framework.AssetBundle
{
    [LuaCallCSharp]
    [Hotfix]
    public class AssetBundleManager : MMOSingletonDontDestroy<AssetBundleManager>
    {
        /// <summary>
        /// 最大同时进行的ab创建数量
        /// </summary>
        private const int MAX_ASSETBUNDLE_CREATE_NUM = 5;

        /// <summary>
        /// manifest 用于提供依赖关系连
        /// </summary>
        private Manifest manifest = null;

        /// <summary>
        ///资源路径映射表
        /// </summary>
        private AssetsPathMapping assetsPathMapping = null;

        // 常驻ab包：需要手动添加公共ab包进来，常驻包不会自动卸载（即使引用计数为0），引用计数为0时可以手动卸载
        HashSet<string> assetbundleResident = new HashSet<string>();

        // ab缓存包：所有目前已经加载的ab包，包括临时ab包与公共ab包
        Dictionary<string, UnityEngine.AssetBundle> assetbundlesCaching =
            new Dictionary<string, UnityEngine.AssetBundle>();

        // ab缓存包引用计数：卸载ab包时只有引用计数为0时才会真正执行卸载
        Dictionary<string, int> assetbundleRefCount = new Dictionary<string, int>();

        // asset缓存：给非公共ab包的asset提供逻辑层的复用
        Dictionary<string, UnityEngine.Object> assetsCaching = new Dictionary<string, UnityEngine.Object>();

        // 加载数据请求：正在prosessing或者等待prosessing的资源请求
        Dictionary<string, ResourceWebRequester> webRequesting = new Dictionary<string, ResourceWebRequester>();

        // 等待处理的资源请求
        Queue<ResourceWebRequester> webRequesterQueue = new Queue<ResourceWebRequester>();

        // 正在处理的资源请求
        List<ResourceWebRequester> prosessingWebRequester = new List<ResourceWebRequester>();

        // 逻辑层正在等待的ab加载异步句柄
        List<AssetBundleAsyncLoader> prosessingAssetBundleAsyncLoader = new List<AssetBundleAsyncLoader>();

        // 逻辑层正在等待的asset加载异步句柄
        List<AssetAsyncLoader> prosessingAssetAsyncLoader = new List<AssetAsyncLoader>();

        // 为了消除GC
        List<string> tmpStringList = new List<string>(8);

        /// <summary>
        /// 资产包名称
        /// </summary>
        public static string ManifestBundleName
        {
            get { return BuildUtils.ManifestBundleName; }
        }

        public override void OnAwake()
        {
            throw new System.NotImplementedException();
        }

        public override void Disable()
        {
            throw new System.NotImplementedException();
        }

        public ResourceWebRequester GetAssetBundleAsyncCreater(string assetbundleName)
        {
            webRequesting.TryGetValue(assetbundleName, out var creater);
            return creater;
        }

        /// <summary>
        /// 获取到资源包缓存
        /// </summary>
        /// <param name="assetbundleName"></param>
        /// <returns></returns>
        public UnityEngine.AssetBundle GetAssetBundleCache(string assetbundleName)
        {
            assetbundlesCaching.TryGetValue(assetbundleName, out var target);
            return target;
        }

        /// <summary>
        /// 添加资源缓存
        /// </summary>
        /// <param name="assetName"></param>
        /// <param name="asset"></param>
        public void AddAssetCache(string assetName, UnityEngine.Object asset)
        {
            assetsCaching[assetName] = asset;
        }

        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="assetName"></param>
        /// <returns></returns>
        public UnityEngine.Object GetAssetCache(string assetName)
        {
            assetsCaching.TryGetValue(assetName, out var target);
            return target;
        }

        public bool IsAssetLoaded(string assetName)
        {
            return assetsCaching.ContainsKey(assetName);
        }

        public bool IsAssetBundleLoaded(string assetbundleName)
        {
            return assetbundlesCaching.ContainsKey(assetbundleName);
        }

        public void AddAssetbundleAssetsCache(string assetbundleName, string postfix = null)
        {
#if UNITY_EDITOR
            if (AssetBundleConfig.IsEditorMode)
            {
                return;
            }
#endif

            if (!IsAssetBundleLoaded(assetbundleName))
            {
                ToolsDebug.LogError($"Try to add assets cache from unloaded assetbundle :  {assetbundleName}");
                return;
            }

            var curAssetbundle = GetAssetBundleCache(assetbundleName);
            var allAssetNames = assetsPathMapping.GetAllAssetNames(assetbundleName);
            foreach (var assetName in allAssetNames)
            {
                if (IsAssetLoaded(assetName))
                {
                    continue;
                }

                if (!string.IsNullOrEmpty(postfix) && !assetName.EndsWith(postfix))
                {
                    continue;
                }

                var assetPath = AssetBundleUtility.PackagePathToAssetsPath(assetName);
                var asset = curAssetbundle == null ? null : curAssetbundle.LoadAsset(assetPath);
                AddAssetCache(assetName, asset);

#if UNITY_EDITOR
                // 说明：在Editor模拟时，Shader要重新指定
                var go = asset as GameObject;
                if (go == null) continue;
                var renderers = go.GetComponentsInChildren<Renderer>();
                foreach (var t in renderers)
                {
                    var mat = t.sharedMaterial;
                    if (mat == null)
                    {
                        continue;
                    }

                    var shader = mat.shader;
                    if (shader == null) continue;
                    var shaderName = shader.name;
                    mat.shader = Shader.Find(shaderName);
                }
#endif
            }
        }
    }
}
