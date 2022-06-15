using Framework.UI.FrameworkUI;
using Script.Framework.UI.FrameworkUI;

namespace Script.Framework.UI
{
    public class UIBaseView
    {
        protected UIView UIV_View;

        protected  void OnInitScript(UIInitView _viewInit)
        {
            viewInit = _viewInit;
        }

        protected virtual void OnInitView(UIView uiView)
        {
            
        }

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
        /// 判断显示
        /// </summary>
        public virtual bool IsActive => (UIV_View != null ? UIV_View.mGO : null) != null && UIV_View.mGO.activeSelf;

        public void SetUIView(UIView _view)
        {
            UIV_View = _view;
            OnInitView(UIV_View);
        }
        //Panel View保存
        public  UIInitView viewInit;

        public virtual UIInitView GetView()
        {
            return viewInit;
        }
        public UIView GetUIView => UIV_View;
        
        
        /// <summary>
        /// 复用
        /// </summary>
        public void Reuse()
        {
            OnShow();
        }
    }
}