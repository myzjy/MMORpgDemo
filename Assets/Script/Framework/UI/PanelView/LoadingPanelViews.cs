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

        private LoadingPanelView GetSelfView()
        {
            return GetView() as LoadingPanelView;
        }

        protected override void OnInitView(UIView uiView)
        {
            var sli = GetSelfView().leftSlider;
            var views = new LoadingPanelView();
            views.Init(uiView);
            OnInitScript(views);
        }
    }
}