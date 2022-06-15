using System;
using System.Collections;
using Framework.UI.FrameworkUI;
using Script.Framework.AssetBundle;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Script.Framework.UI
{
    /// <summary>
    /// UI基础模型
    /// </summary>
    public class UIBaseModule
    {
        /// <summary>
        /// UI基础View
        /// </summary>
        private UIBaseView selfBaseView;

        /// <summary>
        /// 行为定义 
        /// </summary>
        /// <returns></returns>
        public virtual string[] Notification()
        {
            return null;
        }

        public virtual string PrefabName()
        {
            return "";
        }

        /// <summary>
        /// 行为事件回调
        /// </summary>
        /// <param name="notification"></param>
        public virtual void NotificationHandler(UINotification notification)
        {
        }

        public IEnumerator LoadAsset()
        {
            var start = DateTime.Now;
            var load = AssetBundleManager.Instance.LoadAssetAsync(PrefabName(), typeof(GameObject));
            yield return load;
            var assetObj = load.asset as GameObject;
            //读到
            ToolsDebug.Log($"Load Prefab use {(DateTime.Now - start).Milliseconds}ms");
            var item = GameObject.Find("UIRoot/LuanchLayer");
            var instance = Object.Instantiate(assetObj, item.transform, true);
            if (instance != null)
            {
                var rf = instance.GetComponent<RectTransform>();
                rf.offsetMin=Vector2.zero;
                rf.offsetMax=Vector2.zero;
            }

            var uiview = instance.GetComponent<UIView>();
            
        }
    }
}