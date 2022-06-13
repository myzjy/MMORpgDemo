using Framework.UI.FrameworkUI;

namespace Script.Framework.UI
{
    public class UIBaseView
    {
        private UIView UIV_View;
        /// <summary>
        /// 初始化
        /// </summary>
        public virtual void OnInit()
        {
        }

        //显示
        public virtual void OnShow()
        {
        }

        //当隐藏时调用
        public virtual void OnHide()
        {
        }

        //移除物体
        public virtual void OnDestroy()
        {
        }

        /// <summary>
        /// 复用
        /// </summary>
        public void Reuse()
        {
            OnShow();
        }
    }
}