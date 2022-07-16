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
    public class FrameworkUIFrameworkUIUIViewWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Framework.UI.FrameworkUI.UIView);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 5, 5);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InstanceID", _m_InstanceID);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnClose", _m_OnClose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnOpen", _m_OnOpen);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "_canvs", _g_get__canvs);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "_canvasGroup", _g_get__canvasGroup);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "_graphicRaycaster", _g_get__graphicRaycaster);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mGO", _g_get_mGO);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mTF", _g_get_mTF);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "_canvs", _s_set__canvs);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "_canvasGroup", _s_set__canvasGroup);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "_graphicRaycaster", _s_set__graphicRaycaster);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mGO", _s_set_mGO);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mTF", _s_set_mTF);
            
			
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
					
					Framework.UI.FrameworkUI.UIView __cl_gen_ret = new Framework.UI.FrameworkUI.UIView();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Framework.UI.FrameworkUI.UIView constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InstanceID(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Framework.UI.FrameworkUI.UIView __cl_gen_to_be_invoked = (Framework.UI.FrameworkUI.UIView)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.InstanceID(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnClose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Framework.UI.FrameworkUI.UIView __cl_gen_to_be_invoked = (Framework.UI.FrameworkUI.UIView)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.OnClose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnOpen(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Framework.UI.FrameworkUI.UIView __cl_gen_to_be_invoked = (Framework.UI.FrameworkUI.UIView)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.OnOpen(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get__canvs(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Framework.UI.FrameworkUI.UIView __cl_gen_to_be_invoked = (Framework.UI.FrameworkUI.UIView)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked._canvs);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get__canvasGroup(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Framework.UI.FrameworkUI.UIView __cl_gen_to_be_invoked = (Framework.UI.FrameworkUI.UIView)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked._canvasGroup);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get__graphicRaycaster(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Framework.UI.FrameworkUI.UIView __cl_gen_to_be_invoked = (Framework.UI.FrameworkUI.UIView)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked._graphicRaycaster);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mGO(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Framework.UI.FrameworkUI.UIView __cl_gen_to_be_invoked = (Framework.UI.FrameworkUI.UIView)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.mGO);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mTF(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Framework.UI.FrameworkUI.UIView __cl_gen_to_be_invoked = (Framework.UI.FrameworkUI.UIView)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.mTF);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set__canvs(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Framework.UI.FrameworkUI.UIView __cl_gen_to_be_invoked = (Framework.UI.FrameworkUI.UIView)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked._canvs = (UnityEngine.Canvas)translator.GetObject(L, 2, typeof(UnityEngine.Canvas));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set__canvasGroup(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Framework.UI.FrameworkUI.UIView __cl_gen_to_be_invoked = (Framework.UI.FrameworkUI.UIView)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked._canvasGroup = (UnityEngine.CanvasGroup)translator.GetObject(L, 2, typeof(UnityEngine.CanvasGroup));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set__graphicRaycaster(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Framework.UI.FrameworkUI.UIView __cl_gen_to_be_invoked = (Framework.UI.FrameworkUI.UIView)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked._graphicRaycaster = (UnityEngine.UI.GraphicRaycaster)translator.GetObject(L, 2, typeof(UnityEngine.UI.GraphicRaycaster));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mGO(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Framework.UI.FrameworkUI.UIView __cl_gen_to_be_invoked = (Framework.UI.FrameworkUI.UIView)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.mGO = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mTF(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Framework.UI.FrameworkUI.UIView __cl_gen_to_be_invoked = (Framework.UI.FrameworkUI.UIView)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.mTF = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
