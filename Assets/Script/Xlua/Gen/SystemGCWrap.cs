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
    public class SystemGCWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(System.GC);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 17, 1, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "AddMemoryPressure", _m_AddMemoryPressure_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RemoveMemoryPressure", _m_RemoveMemoryPressure_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGeneration", _m_GetGeneration_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Collect", _m_Collect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CollectionCount", _m_CollectionCount_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "KeepAlive", _m_KeepAlive_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WaitForPendingFinalizers", _m_WaitForPendingFinalizers_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SuppressFinalize", _m_SuppressFinalize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReRegisterForFinalize", _m_ReRegisterForFinalize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTotalMemory", _m_GetTotalMemory_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RegisterForFullGCNotification", _m_RegisterForFullGCNotification_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CancelFullGCNotification", _m_CancelFullGCNotification_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WaitForFullGCApproach", _m_WaitForFullGCApproach_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WaitForFullGCComplete", _m_WaitForFullGCComplete_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TryStartNoGCRegion", _m_TryStartNoGCRegion_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EndNoGCRegion", _m_EndNoGCRegion_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MaxGeneration", _g_get_MaxGeneration);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "System.GC does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddMemoryPressure_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    long bytesAllocated = LuaAPI.lua_toint64(L, 1);
                    
                    System.GC.AddMemoryPressure( bytesAllocated );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveMemoryPressure_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    long bytesAllocated = LuaAPI.lua_toint64(L, 1);
                    
                    System.GC.RemoveMemoryPressure( bytesAllocated );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGeneration_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& translator.Assignable<object>(L, 1)) 
                {
                    object obj = translator.GetObject(L, 1, typeof(object));
                    
                        int __cl_gen_ret = System.GC.GetGeneration( obj );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& translator.Assignable<System.WeakReference>(L, 1)) 
                {
                    System.WeakReference wo = (System.WeakReference)translator.GetObject(L, 1, typeof(System.WeakReference));
                    
                        int __cl_gen_ret = System.GC.GetGeneration( wo );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.GC.GetGeneration!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Collect_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 0) 
                {
                    
                    System.GC.Collect(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int generation = LuaAPI.xlua_tointeger(L, 1);
                    
                    System.GC.Collect( generation );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<System.GCCollectionMode>(L, 2)) 
                {
                    int generation = LuaAPI.xlua_tointeger(L, 1);
                    System.GCCollectionMode mode;translator.Get(L, 2, out mode);
                    
                    System.GC.Collect( generation, mode );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<System.GCCollectionMode>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    int generation = LuaAPI.xlua_tointeger(L, 1);
                    System.GCCollectionMode mode;translator.Get(L, 2, out mode);
                    bool blocking = LuaAPI.lua_toboolean(L, 3);
                    
                    System.GC.Collect( generation, mode, blocking );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<System.GCCollectionMode>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    int generation = LuaAPI.xlua_tointeger(L, 1);
                    System.GCCollectionMode mode;translator.Get(L, 2, out mode);
                    bool blocking = LuaAPI.lua_toboolean(L, 3);
                    bool compacting = LuaAPI.lua_toboolean(L, 4);
                    
                    System.GC.Collect( generation, mode, blocking, compacting );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.GC.Collect!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CollectionCount_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int generation = LuaAPI.xlua_tointeger(L, 1);
                    
                        int __cl_gen_ret = System.GC.CollectionCount( generation );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_KeepAlive_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    object obj = translator.GetObject(L, 1, typeof(object));
                    
                    System.GC.KeepAlive( obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WaitForPendingFinalizers_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    System.GC.WaitForPendingFinalizers(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SuppressFinalize_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    object obj = translator.GetObject(L, 1, typeof(object));
                    
                    System.GC.SuppressFinalize( obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReRegisterForFinalize_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    object obj = translator.GetObject(L, 1, typeof(object));
                    
                    System.GC.ReRegisterForFinalize( obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTotalMemory_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    bool forceFullCollection = LuaAPI.lua_toboolean(L, 1);
                    
                        long __cl_gen_ret = System.GC.GetTotalMemory( forceFullCollection );
                        LuaAPI.lua_pushint64(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterForFullGCNotification_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int maxGenerationThreshold = LuaAPI.xlua_tointeger(L, 1);
                    int largeObjectHeapThreshold = LuaAPI.xlua_tointeger(L, 2);
                    
                    System.GC.RegisterForFullGCNotification( maxGenerationThreshold, largeObjectHeapThreshold );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CancelFullGCNotification_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    System.GC.CancelFullGCNotification(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WaitForFullGCApproach_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 0) 
                {
                    
                        System.GCNotificationStatus __cl_gen_ret = System.GC.WaitForFullGCApproach(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int millisecondsTimeout = LuaAPI.xlua_tointeger(L, 1);
                    
                        System.GCNotificationStatus __cl_gen_ret = System.GC.WaitForFullGCApproach( millisecondsTimeout );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.GC.WaitForFullGCApproach!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WaitForFullGCComplete_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 0) 
                {
                    
                        System.GCNotificationStatus __cl_gen_ret = System.GC.WaitForFullGCComplete(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int millisecondsTimeout = LuaAPI.xlua_tointeger(L, 1);
                    
                        System.GCNotificationStatus __cl_gen_ret = System.GC.WaitForFullGCComplete( millisecondsTimeout );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.GC.WaitForFullGCComplete!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryStartNoGCRegion_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isint64(L, 1))) 
                {
                    long totalSize = LuaAPI.lua_toint64(L, 1);
                    
                        bool __cl_gen_ret = System.GC.TryStartNoGCRegion( totalSize );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isint64(L, 1))&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || LuaAPI.lua_isint64(L, 2))) 
                {
                    long totalSize = LuaAPI.lua_toint64(L, 1);
                    long lohSize = LuaAPI.lua_toint64(L, 2);
                    
                        bool __cl_gen_ret = System.GC.TryStartNoGCRegion( totalSize, lohSize );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isint64(L, 1))&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    long totalSize = LuaAPI.lua_toint64(L, 1);
                    bool disallowFullBlockingGC = LuaAPI.lua_toboolean(L, 2);
                    
                        bool __cl_gen_ret = System.GC.TryStartNoGCRegion( totalSize, disallowFullBlockingGC );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isint64(L, 1))&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || LuaAPI.lua_isint64(L, 2))&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    long totalSize = LuaAPI.lua_toint64(L, 1);
                    long lohSize = LuaAPI.lua_toint64(L, 2);
                    bool disallowFullBlockingGC = LuaAPI.lua_toboolean(L, 3);
                    
                        bool __cl_gen_ret = System.GC.TryStartNoGCRegion( totalSize, lohSize, disallowFullBlockingGC );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.GC.TryStartNoGCRegion!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndNoGCRegion_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    System.GC.EndNoGCRegion(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MaxGeneration(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, System.GC.MaxGeneration);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
