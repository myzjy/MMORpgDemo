#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class ScriptFrameworkUITipUINoticeTipWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Script.Framework.UI.Tip.UINoticeTip);
			Utils.BeginObjectRegister(type, L, translator, 0, 5, 4, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ShowOneButtonTip", _m_ShowOneButtonTip);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ShowTwoButtonTip", _m_ShowTwoButtonTip);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ShowThreeButtonTip", _m_ShowThreeButtonTip);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HideTip", _m_HideTip);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsShowing", _g_get_IsShowing);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UIGameObject", _g_get_UIGameObject);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "progress", _g_get_progress);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isDone", _g_get_isDone);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "UIGameObject", _s_set_UIGameObject);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					Script.Framework.UI.Tip.UINoticeTip __cl_gen_ret = new Script.Framework.UI.Tip.UINoticeTip();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Script.Framework.UI.Tip.UINoticeTip constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ShowOneButtonTip(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.UI.Tip.UINoticeTip __cl_gen_to_be_invoked = (Script.Framework.UI.Tip.UINoticeTip)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string title = LuaAPI.lua_tostring(L, 2);
                    string content = LuaAPI.lua_tostring(L, 3);
                    string btnText = LuaAPI.lua_tostring(L, 4);
                    System.Action callback = translator.GetDelegate<System.Action>(L, 5);
                    
                    __cl_gen_to_be_invoked.ShowOneButtonTip( title, content, btnText, callback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ShowTwoButtonTip(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.UI.Tip.UINoticeTip __cl_gen_to_be_invoked = (Script.Framework.UI.Tip.UINoticeTip)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string title = LuaAPI.lua_tostring(L, 2);
                    string content = LuaAPI.lua_tostring(L, 3);
                    string btnText1 = LuaAPI.lua_tostring(L, 4);
                    string btnText2 = LuaAPI.lua_tostring(L, 5);
                    System.Action callback1 = translator.GetDelegate<System.Action>(L, 6);
                    System.Action callback2 = translator.GetDelegate<System.Action>(L, 7);
                    
                    __cl_gen_to_be_invoked.ShowTwoButtonTip( title, content, btnText1, btnText2, callback1, callback2 );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ShowThreeButtonTip(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.UI.Tip.UINoticeTip __cl_gen_to_be_invoked = (Script.Framework.UI.Tip.UINoticeTip)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string title = LuaAPI.lua_tostring(L, 2);
                    string content = LuaAPI.lua_tostring(L, 3);
                    string btnText1 = LuaAPI.lua_tostring(L, 4);
                    string btnText2 = LuaAPI.lua_tostring(L, 5);
                    string btnText3 = LuaAPI.lua_tostring(L, 6);
                    System.Action callback1 = translator.GetDelegate<System.Action>(L, 7);
                    System.Action callback2 = translator.GetDelegate<System.Action>(L, 8);
                    System.Action callback3 = translator.GetDelegate<System.Action>(L, 9);
                    
                    __cl_gen_to_be_invoked.ShowThreeButtonTip( title, content, btnText1, btnText2, btnText3, callback1, callback2, callback3 );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HideTip(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.UI.Tip.UINoticeTip __cl_gen_to_be_invoked = (Script.Framework.UI.Tip.UINoticeTip)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.HideTip(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.UI.Tip.UINoticeTip __cl_gen_to_be_invoked = (Script.Framework.UI.Tip.UINoticeTip)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsShowing(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Script.Framework.UI.Tip.UINoticeTip __cl_gen_to_be_invoked = (Script.Framework.UI.Tip.UINoticeTip)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.IsShowing);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UIGameObject(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Script.Framework.UI.Tip.UINoticeTip __cl_gen_to_be_invoked = (Script.Framework.UI.Tip.UINoticeTip)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.UIGameObject);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_progress(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Script.Framework.UI.Tip.UINoticeTip __cl_gen_to_be_invoked = (Script.Framework.UI.Tip.UINoticeTip)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.progress);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isDone(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Script.Framework.UI.Tip.UINoticeTip __cl_gen_to_be_invoked = (Script.Framework.UI.Tip.UINoticeTip)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isDone);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_UIGameObject(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Script.Framework.UI.Tip.UINoticeTip __cl_gen_to_be_invoked = (Script.Framework.UI.Tip.UINoticeTip)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.UIGameObject = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
