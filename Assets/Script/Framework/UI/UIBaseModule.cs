namespace Script.Framework.UI
{
    public class UIBaseModule
    {
        private UIBaseView selfBaseView;

        public virtual string[] Notification()
        {
            return null;
        }

        public virtual void NotificationHandler(UINotification notification)
        {
            
        }
    }
}