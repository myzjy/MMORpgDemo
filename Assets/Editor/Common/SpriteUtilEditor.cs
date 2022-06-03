using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace GameDataEditor.Common
{
    public class SpriteUtilEditor : Editor
    {
        private static readonly string AssetUIDataPath = $"{Application.dataPath}/Game/UI/";
        private static string startWith = "Asset/Game/UI";
        private const string IgnoreDirString = "Editor;Plugins;Android;IOS;Ios";

        private static string extString = "t:Texture";
        private const string SPRITE_SETTINGS_EDITOR = "Tools/GameEditor/SpriteDefault";
        private static int SettedCount = 0;
        [MenuItem(SPRITE_SETTINGS_EDITOR)]
        public static void SpriteEditor()
        {
            var pathList = new List<string>();
            var strs = IgnoreDirString.Split(';');
            GetFiles(strs, ref pathList);
            bool jump = false;
            for (int i = 0; i < pathList.Count; i++)
            {
                if (EditorUtility.DisplayCancelableProgressBar("设置图片", $"第{SettedCount}", 0.5f))
                {
                    jump = true;
                }

                var file = pathList[i];
                bool isChange = false;
            }
        }

        public static void GetFiles(string[] ignores, ref List<string> paths)
        {
            //拿到所有
            string[] guids = AssetDatabase.FindAssets(extString);
            int length = guids.Length;
            for (int i = 0; i < length; i++)
            {
                string filePath = AssetDatabase.GUIDToAssetPath(guids[i]);
                if (!string.IsNullOrEmpty(filePath) && !filePath.StartsWith(startWith))
                {
                    continue;
                }

                bool isgnore = ignores.Any(t => filePath.Contains(ignores[i]));

                if (!isgnore)
                {
                    paths.Add(filePath);
                }
            }
        }
    }
}