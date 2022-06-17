using Framework.UI.FrameworkUI;
using Script.Framework.UI.FrameworkUI;

namespace Script.Framework.UI.PanelView
{
    public class LoadingPanelViews : UIBaseView
    {
        public override void OnHide()
        {
            base.OnHide();
        }

        public override void OnInit()
        {
            base.OnInit();
        }

        public override void OnShow()
        {
            base.OnShow();
        }

        public override void OnDestroy()
        {
            base.OnDestroy();
        }
        /// <summary>
        /// 找到panel view
        /// </summary>
        /// <returns></returns>
        private LoadingPanelView GetSelfView()
        {
            return GetView() as LoadingPanelView;
        }
        
        /// <summary>
        /// 初始化 UIView
        /// </summary>
        /// <param name="uiView">生成</param>
        protected override void OnInitView(UIView uiView)
        {
            var views = new LoadingPanelView();
            views.Init(uiView);
            OnInitScript(views);
        }
    }
}