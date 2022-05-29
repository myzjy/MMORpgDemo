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
    public class CommonGameChannelChannelManagerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Common.GameChannel.ChannelManager);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 5, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Init", _m_Init);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsInternalVersion", _m_IsInternalVersion);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CreateChannel", _m_CreateChannel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StartDownloadGame", _m_StartDownloadGame);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetProductName", _m_GetProductName);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InstallGame", _m_InstallGame);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "channelName", _g_get_channelName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "noticeVersion", _g_get_noticeVersion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "resVersion", _g_get_resVersion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "appVersion", _g_get_appVersion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "svnVersion", _g_get_svnVersion);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "noticeVersion", _s_set_noticeVersion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "resVersion", _s_set_resVersion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "appVersion", _s_set_appVersion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "svnVersion", _s_set_svnVersion);
            
			
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
					
					Common.GameChannel.ChannelManager __cl_gen_ret = new Common.GameChannel.ChannelManager();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Common.GameChannel.ChannelManager constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Init(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Common.GameChannel.ChannelManager __cl_gen_to_be_invoked = (Common.GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string channelName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.Init( channelName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsInternalVersion(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Common.GameChannel.ChannelManager __cl_gen_to_be_invoked = (Common.GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsInternalVersion(  );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateChannel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Common.GameChannel.ChannelManager __cl_gen_to_be_invoked = (Common.GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string channelName = LuaAPI.lua_tostring(L, 2);
                    
                        Common.GameChannel.BaseChannel __cl_gen_ret = __cl_gen_to_be_invoked.CreateChannel( channelName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StartDownloadGame(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Common.GameChannel.ChannelManager __cl_gen_to_be_invoked = (Common.GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 6&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action>(L, 3)&& translator.Assignable<System.Action>(L, 4)&& translator.Assignable<System.Action<int>>(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TSTRING)) 
                {
                    string url = LuaAPI.lua_tostring(L, 2);
                    System.Action succeed = translator.GetDelegate<System.Action>(L, 3);
                    System.Action fail = translator.GetDelegate<System.Action>(L, 4);
                    System.Action<int> progress = translator.GetDelegate<System.Action<int>>(L, 5);
                    string saveName = LuaAPI.lua_tostring(L, 6);
                    
                    __cl_gen_to_be_invoked.StartDownloadGame( url, succeed, fail, progress, saveName );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action>(L, 3)&& translator.Assignable<System.Action>(L, 4)&& translator.Assignable<System.Action<int>>(L, 5)) 
                {
                    string url = LuaAPI.lua_tostring(L, 2);
                    System.Action succeed = translator.GetDelegate<System.Action>(L, 3);
                    System.Action fail = translator.GetDelegate<System.Action>(L, 4);
                    System.Action<int> progress = translator.GetDelegate<System.Action<int>>(L, 5);
                    
                    __cl_gen_to_be_invoked.StartDownloadGame( url, succeed, fail, progress );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action>(L, 3)&& translator.Assignable<System.Action>(L, 4)) 
                {
                    string url = LuaAPI.lua_tostring(L, 2);
                    System.Action succeed = translator.GetDelegate<System.Action>(L, 3);
                    System.Action fail = translator.GetDelegate<System.Action>(L, 4);
                    
                    __cl_gen_to_be_invoked.StartDownloadGame( url, succeed, fail );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action>(L, 3)) 
                {
                    string url = LuaAPI.lua_tostring(L, 2);
                    System.Action succeed = translator.GetDelegate<System.Action>(L, 3);
                    
                    __cl_gen_to_be_invoked.StartDownloadGame( url, succeed );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string url = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.StartDownloadGame( url );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Common.GameChannel.ChannelManager.StartDownloadGame!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetProductName(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Common.GameChannel.ChannelManager __cl_gen_to_be_invoked = (Common.GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.GetProductName(  );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InstallGame(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Common.GameChannel.ChannelManager __cl_gen_to_be_invoked = (Common.GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Action succeed = translator.GetDelegate<System.Action>(L, 2);
                    System.Action fail = translator.GetDelegate<System.Action>(L, 3);
                    
                    __cl_gen_to_be_invoked.InstallGame( succeed, fail );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_channelName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Common.GameChannel.ChannelManager __cl_gen_to_be_invoked = (Common.GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.channelName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_noticeVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Common.GameChannel.ChannelManager __cl_gen_to_be_invoked = (Common.GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.noticeVersion);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_resVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Common.GameChannel.ChannelManager __cl_gen_to_be_invoked = (Common.GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.resVersion);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_appVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Common.GameChannel.ChannelManager __cl_gen_to_be_invoked = (Common.GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.appVersion);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_svnVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Common.GameChannel.ChannelManager __cl_gen_to_be_invoked = (Common.GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.svnVersion);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_noticeVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Common.GameChannel.ChannelManager __cl_gen_to_be_invoked = (Common.GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.noticeVersion = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_resVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Common.GameChannel.ChannelManager __cl_gen_to_be_invoked = (Common.GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.resVersion = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_appVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Common.GameChannel.ChannelManager __cl_gen_to_be_invoked = (Common.GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.appVersion = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_svnVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Common.GameChannel.ChannelManager __cl_gen_to_be_invoked = (Common.GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.svnVersion = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
