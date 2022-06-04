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
    public class ToolsDebugWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ToolsDebug);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 13, 1, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawLine", _m_DrawLine_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Log", _m_Log_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LogFormat", _m_LogFormat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LogError", _m_LogError_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LogErrorFormat", _m_LogErrorFormat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ClearDeveloperConsole", _m_ClearDeveloperConsole_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LogWarning", _m_LogWarning_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LogWarningFormat", _m_LogWarningFormat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Assert", _m_Assert_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AssertFormat", _m_AssertFormat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LogAssertion", _m_LogAssertion_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LogAssertionFormat", _m_LogAssertionFormat_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "isDebugBuild", _g_get_isDebugBuild);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					ToolsDebug __cl_gen_ret = new ToolsDebug();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ToolsDebug constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawLine_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector3 end;translator.Get(L, 2, out end);
                    UnityEngine.Color color;translator.Get(L, 3, out color);
                    float duration = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    ToolsDebug.DrawLine( start, end, color, duration );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Log_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& translator.Assignable<object>(L, 1)) 
                {
                    object message = translator.GetObject(L, 1, typeof(object));
                    
                    ToolsDebug.Log( message );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<object>(L, 1)&& translator.Assignable<UnityEngine.Object>(L, 2)) 
                {
                    object message = translator.GetObject(L, 1, typeof(object));
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
                    
                    ToolsDebug.Log( message, context );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ToolsDebug.Log!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LogFormat_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<object>(L, 2))) 
                {
                    string format = LuaAPI.lua_tostring(L, 1);
                    object[] args = translator.GetParams<object>(L, 2);
                    
                    ToolsDebug.LogFormat( format, args );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<object>(L, 3))) 
                {
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string format = LuaAPI.lua_tostring(L, 2);
                    object[] args = translator.GetParams<object>(L, 3);
                    
                    ToolsDebug.LogFormat( context, format, args );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 4&& translator.Assignable<UnityEngine.LogType>(L, 1)&& translator.Assignable<UnityEngine.LogOption>(L, 2)&& translator.Assignable<UnityEngine.Object>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<object>(L, 5))) 
                {
                    UnityEngine.LogType logType;translator.Get(L, 1, out logType);
                    UnityEngine.LogOption logOptions;translator.Get(L, 2, out logOptions);
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 3, typeof(UnityEngine.Object));
                    string format = LuaAPI.lua_tostring(L, 4);
                    object[] args = translator.GetParams<object>(L, 5);
                    
                    ToolsDebug.LogFormat( logType, logOptions, context, format, args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ToolsDebug.LogFormat!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LogError_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& translator.Assignable<object>(L, 1)) 
                {
                    object message = translator.GetObject(L, 1, typeof(object));
                    
                    ToolsDebug.LogError( message );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<object>(L, 1)&& translator.Assignable<UnityEngine.Object>(L, 2)) 
                {
                    object message = translator.GetObject(L, 1, typeof(object));
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
                    
                    ToolsDebug.LogError( message, context );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<object>(L, 2))) 
                {
                    string s = LuaAPI.lua_tostring(L, 1);
                    object[] p = translator.GetParams<object>(L, 2);
                    
                    ToolsDebug.LogError( s, p );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ToolsDebug.LogError!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LogErrorFormat_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<object>(L, 2))) 
                {
                    string format = LuaAPI.lua_tostring(L, 1);
                    object[] args = translator.GetParams<object>(L, 2);
                    
                    ToolsDebug.LogErrorFormat( format, args );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<object>(L, 3))) 
                {
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string format = LuaAPI.lua_tostring(L, 2);
                    object[] args = translator.GetParams<object>(L, 3);
                    
                    ToolsDebug.LogErrorFormat( context, format, args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ToolsDebug.LogErrorFormat!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearDeveloperConsole_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    ToolsDebug.ClearDeveloperConsole(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LogWarning_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& translator.Assignable<object>(L, 1)) 
                {
                    object message = translator.GetObject(L, 1, typeof(object));
                    
                    ToolsDebug.LogWarning( message );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<object>(L, 1)&& translator.Assignable<UnityEngine.Object>(L, 2)) 
                {
                    object message = translator.GetObject(L, 1, typeof(object));
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
                    
                    ToolsDebug.LogWarning( message, context );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ToolsDebug.LogWarning!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LogWarningFormat_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<object>(L, 2))) 
                {
                    string format = LuaAPI.lua_tostring(L, 1);
                    object[] args = translator.GetParams<object>(L, 2);
                    
                    ToolsDebug.LogWarningFormat( format, args );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<object>(L, 3))) 
                {
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string format = LuaAPI.lua_tostring(L, 2);
                    object[] args = translator.GetParams<object>(L, 3);
                    
                    ToolsDebug.LogWarningFormat( context, format, args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ToolsDebug.LogWarningFormat!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Assert_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)) 
                {
                    bool condition = LuaAPI.lua_toboolean(L, 1);
                    
                    ToolsDebug.Assert( condition );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Object>(L, 2)) 
                {
                    bool condition = LuaAPI.lua_toboolean(L, 1);
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
                    
                    ToolsDebug.Assert( condition, context );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& translator.Assignable<object>(L, 2)) 
                {
                    bool condition = LuaAPI.lua_toboolean(L, 1);
                    object message = translator.GetObject(L, 2, typeof(object));
                    
                    ToolsDebug.Assert( condition, message );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    bool condition = LuaAPI.lua_toboolean(L, 1);
                    string message = LuaAPI.lua_tostring(L, 2);
                    
                    ToolsDebug.Assert( condition, message );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& translator.Assignable<object>(L, 2)&& translator.Assignable<UnityEngine.Object>(L, 3)) 
                {
                    bool condition = LuaAPI.lua_toboolean(L, 1);
                    object message = translator.GetObject(L, 2, typeof(object));
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 3, typeof(UnityEngine.Object));
                    
                    ToolsDebug.Assert( condition, message, context );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Object>(L, 3)) 
                {
                    bool condition = LuaAPI.lua_toboolean(L, 1);
                    string message = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 3, typeof(UnityEngine.Object));
                    
                    ToolsDebug.Assert( condition, message, context );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ToolsDebug.Assert!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AssertFormat_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count >= 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<object>(L, 3))) 
                {
                    bool condition = LuaAPI.lua_toboolean(L, 1);
                    string format = LuaAPI.lua_tostring(L, 2);
                    object[] args = translator.GetParams<object>(L, 3);
                    
                    ToolsDebug.AssertFormat( condition, format, args );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Object>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<object>(L, 4))) 
                {
                    bool condition = LuaAPI.lua_toboolean(L, 1);
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
                    string format = LuaAPI.lua_tostring(L, 3);
                    object[] args = translator.GetParams<object>(L, 4);
                    
                    ToolsDebug.AssertFormat( condition, context, format, args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ToolsDebug.AssertFormat!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LogAssertion_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& translator.Assignable<object>(L, 1)) 
                {
                    object message = translator.GetObject(L, 1, typeof(object));
                    
                    ToolsDebug.LogAssertion( message );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<object>(L, 1)&& translator.Assignable<UnityEngine.Object>(L, 2)) 
                {
                    object message = translator.GetObject(L, 1, typeof(object));
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
                    
                    ToolsDebug.LogAssertion( message, context );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ToolsDebug.LogAssertion!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LogAssertionFormat_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<object>(L, 2))) 
                {
                    string format = LuaAPI.lua_tostring(L, 1);
                    object[] args = translator.GetParams<object>(L, 2);
                    
                    ToolsDebug.LogAssertionFormat( format, args );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<object>(L, 3))) 
                {
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string format = LuaAPI.lua_tostring(L, 2);
                    object[] args = translator.GetParams<object>(L, 3);
                    
                    ToolsDebug.LogAssertionFormat( context, format, args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ToolsDebug.LogAssertionFormat!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isDebugBuild(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, ToolsDebug.isDebugBuild);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
