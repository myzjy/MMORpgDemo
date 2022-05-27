using System.IO;
using System.Text;
using Common.Utility;
using Framework.AssetBundles.Config;
using UnityEngine;
using XLua;

namespace Framework.AssetBundles.Utilty
{
    [Hotfix]
    [LuaCallCSharp]
    public class AssetBundleUtility
    {
        private static string GetPlatformName(RuntimePlatform platform)
        {
            switch (platform)
            {
                case RuntimePlatform.Android:
                    return "Android";
                case RuntimePlatform.IPhonePlayer:
                    return "iOS";
                default:
                    Debug.LogError("Error platform!!!");
                    return null;
            }
        }
        /// <summary>
        /// 包路径到资产路径
        /// </summary>
        /// <param name="assetPath">资产路径</param>
        /// <returns></returns>
        public static string PackagePathToAssetsPath(string assetPath)
        {
            var sb = new StringBuilder();
            sb.Append("Assets/");
            sb.Append(AssetBundleConfig.AssetsFolderName);
            sb.Append($"/{assetPath}");
            return  sb.ToString();
        }
        /// <summary>
        /// 资产包路径到资产包名称
        /// </summary>
        /// <param name="assetPath">资产包路径</param>
        /// <returns></returns>
        public static string AssetBundlePathToAssetBundleName(string assetPath)
        {
            var ab = new StringBuilder();
            if (string.IsNullOrEmpty(assetPath)) return null;
            if (assetPath.StartsWith("Assets/"))
            {
                assetPath = AssetsPathToPackagePath(assetPath);
            }
            //no " "
            assetPath = assetPath.Replace(" ", "");
            //there should not be any '.' in the assetbundle name
            //otherwise the variant handling in client may go wrong
            assetPath = assetPath.Replace(".", "_");
            //add after suffix ".assetbundle" to the end
            ab.Append(assetPath);
            ab.Append(AssetBundleConfig.AssetBundleSuffix);
            return ab.ToString().ToLower();
        }
        /// <summary>
        /// 资产路径到包路径
        /// </summary>
        /// <param name="assetPath">资产包路径</param>
        /// <returns></returns>
        public static string AssetsPathToPackagePath(string assetPath)
        {
            string path = $"Assets/{AssetBundleConfig.AssetsFolderName}/";
            if (assetPath.StartsWith(path))
            {
                return assetPath.Substring(path.Length);
            }
            else
            {
                Debug.LogError("Asset path is not a package path!");
                return assetPath;
            }
        }
        /// <summary>
        /// 获取到对应路径
        /// </summary>
        /// <param name="assetPath">资源路径</param>
        /// <returns></returns>
        public static string GetPersistentDataPath(string assetPath = null)
        {
            //根据参数返回上一级目录
            string outputPath = Path.Combine(Application.persistentDataPath, AssetBundleConfig.AssetBundlesFolderName);
            if (!string.IsNullOrEmpty(assetPath))
            {
                //根据参数返回上一级目录
                outputPath = Path.Combine(outputPath, assetPath);
            }
#if UNITY_EDITOR_WIN
            // 路径替换
            return GameUtility.FormatToSysFilePath(outputPath);
#else
            return outputPath;
#endif
        }
        /// <summary>
        /// 检查持久文件是否存在
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <returns></returns>
        public static bool CheckPersistentFileExsits(string filePath)
        {
            //获取到对应路径 检查对应文件
            var path = GetPersistentDataPath(filePath);
            return File.Exists(path);
        }
    }
}