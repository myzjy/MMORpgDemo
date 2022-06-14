using Script.Framework.UI.FrameworkUI;
using UnityEngine;
using XLua;

namespace Framework.UI.FrameworkUI
{
    [Hotfix]
    [LuaCallCSharp]
    public class UIView : SerializableKeyObject
    {
        private int instanceID;
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
            //GameMain.Instance?.GetBFWSystem<IUISystem>()?.OnHide(instanceID);
        }

        private void BeforeDestroy()
        {
            // GameMain.Instance?.GetBFWSystem<IUISystem>()?.BeforeDestroy(instanceID);
        }
    }
}