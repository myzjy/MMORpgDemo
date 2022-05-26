using System.IO;
using Common.Utility;
using Framework.AssetBundles.Config;
using UnityEditor;
using UnityEngine;

namespace AddressableE
{
    public class LuaFileBytes
    {
        [MenuItem("XLua/Copy Lua Files To AssetsPackage", false, 51)]
        public static void CopyLuaFilesToAssetsPackage()
        {
            string destination = Path.Combine(Application.dataPath, AssetBundleConfig.AssetsFolderName);
            destination = Path.Combine(destination, XluaManager.luaAssetbundleAssetName);
            string source = Path.Combine(Application.dataPath, XluaManager.luaScriptsFolder);
            GameUtility.LuaSafeDeleteDir(destination);

            FileUtil.CopyFileOrDirectoryFollowSymlinks(source, destination);

            var notLuaFiles = GameUtility.GetSpecifyFilesInFolder(destination, new string[] { ".lua" }, true);
            if (notLuaFiles != null && notLuaFiles.Length > 0)
            {
                for (int i = 0; i < notLuaFiles.Length; i++)
                {
                    GameUtility.LuaSafeDeleteFile(notLuaFiles[i]);
                }
            }

            var luaFiles = GameUtility.GetSpecifyFilesInFolder(destination, new string[] { ".lua" }, false);
            if (luaFiles != null && luaFiles.Length > 0)
            {
                for (int i = 0; i < luaFiles.Length; i++)
                {
                    GameUtility.LuaRenameFile(luaFiles[i], luaFiles[i] + ".bytes");
                }
            }

            AssetDatabase.Refresh();
            Debug.Log("Copy lua files over");
        }
    }
}