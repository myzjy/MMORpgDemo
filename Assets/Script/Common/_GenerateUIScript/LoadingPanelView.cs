using  Framework.UI.FrameworkUI;
using Script.Framework.UI.FrameworkUI;

namespace  Framework.UI.FrameworkUI
{
    public class LoadingPanelView : UIInitView
    {
		public UnityEngine.UI.Slider leftSlider = null;
		public UnityEngine.UI.Slider rightSlider = null;


		public override void Init(UIView selfUIView)
		{
			leftSlider = selfUIView.Get<UnityEngine.UI.Slider>("leftSlider");
			rightSlider = selfUIView.Get<UnityEngine.UI.Slider>("rightSlider");
		}

    }
}