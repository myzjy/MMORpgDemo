using System;
using System.Collections.Generic;

namespace Script.Framework.UI.SystemModel
{
    public class UIModelSystem
    {
        public Dictionary<string, Action<string>> models = new Dictionary<string, Action<string>>();
        //注册
        public void RegisterEvent(string view)
        {
            
        }

        public void DispatchEvent()
        {
            
        }
    }
}