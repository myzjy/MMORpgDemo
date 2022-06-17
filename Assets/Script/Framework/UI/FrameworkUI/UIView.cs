using Script.Framework.UI.FrameworkUI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Framework.UI.FrameworkUI
{
    [Hotfix]
    [LuaCallCSharp]
    public class UIView : SerializableKeyObject
    {
        private int instanceID;
        public Canvas _canvs;
        public CanvasGroup _canvasGroup;
        public GraphicRaycaster _graphicRaycaster;
        public GameObject mGO;
        public Transform mTF;

        public int InstanceID()
        {
            return instanceID;
        }

        private void Reset()
        {
            mGO = gameObject;
            mTF = transform;
            _canvs = GetComponent<Canvas>();
            _canvasGroup = GetComponent<CanvasGroup>();
            _graphicRaycaster = GetComponent<GraphicRaycaster>();
        }

        public void OnClose()
        {
            //不要直接隐藏物体，不然打开物体，会重新刷ui
            _canvs.enabled = false;
            _canvasGroup.alpha = 0;
            _graphicRaycaster.enabled = false;
        }

        public void OnOpen()
        {
            //不要直接隐藏物体，不然打开物体，会重新刷ui
            _canvs.enabled = true;
            _canvasGroup.alpha = 1;
            _graphicRaycaster.enabled = true;
        }

        void Awake()
        {
            instanceID = gameObject.GetInstanceID();
        }

        void OnEnable()
        {
            this.OnShow();
        }

        void OnDisable()
        {
            this.OnHide();
        }

        void OnDestroy()
        {
            this.BeforeDestroy();
        }

        private void OnShow()
        {
            //GameMain.Instance?.GetBFWSystem<IUISystem>()?.OnShow(instanceID);
        }

        private void OnHide()
        {
            OnClose();
            //GameMain.Instance?.GetBFWSystem<IUISystem>()?.OnHide(instanceID);
        }

        private void BeforeDestroy()
        {
            // GameMain.Instance?.GetBFWSystem<IUISystem>()?.BeforeDestroy(instanceID);
        }
    }
}