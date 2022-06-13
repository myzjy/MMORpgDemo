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

        /// <summary>
        /// 行为事件回调
        /// </summary>
        /// <param name="notification"></param>
        public virtual void NotificationHandler(UINotification notification)
        {
        }
    }
}