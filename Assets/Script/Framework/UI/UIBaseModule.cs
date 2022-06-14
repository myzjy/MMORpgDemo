using System.Collections;
using Script.Framework.AssetBundle;
using UnityEngine;

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
            var load = AssetBundleManager.Instance.LoadAssetAsync(PrefabName(), typeof(GameObject));
            yield return load;

        }
    }
}