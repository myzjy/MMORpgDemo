using System;
using System.Collections.Generic;

namespace Script.Framework.UI.SystemModel
{
    public class UIModelSystem
    {
        public Dictionary<string, Action<UIBaseModule>> models = new Dictionary<string, Action<UIBaseModule>>();
        //注册
        public void RegisterEvent(string view)
        {
            
        }
        /// <summary>
        /// 调度事件
        /// </summary>
        public void DispatchEvent()
        {
            
        }
    }
}