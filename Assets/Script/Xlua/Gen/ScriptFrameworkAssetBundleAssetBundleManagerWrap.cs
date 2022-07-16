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
    public class ScriptFrameworkAssetBundleAssetBundleManagerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Script.Framework.AssetBundle.AssetBundleManager);
			Utils.BeginObjectRegister(type, L, translator, 0, 23, 3, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnAwake", _m_OnAwake);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Initialize", _m_Initialize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Cleanup", _m_Cleanup);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearAssetsCache", _m_ClearAssetsCache);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Disable", _m_Disable);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RequestAssetBundleAsync", _m_RequestAssetBundleAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetAssetBundleResident", _m_SetAssetBundleResident);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAssetBundleAsyncCreater", _m_GetAssetBundleAsyncCreater);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAssetBundleCache", _m_GetAssetBundleCache);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddAssetCache", _m_AddAssetCache);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAssetCache", _m_GetAssetCache);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsAssetLoaded", _m_IsAssetLoaded);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsAssetBundleLoaded", _m_IsAssetBundleLoaded);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddAssetbundleAssetsCache", _m_AddAssetbundleAssetsCache);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DownloadAssetBundleAsync", _m_DownloadAssetBundleAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DownloadAssetFileAsync", _m_DownloadAssetFileAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAssetBundleAsync", _m_LoadAssetBundleAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsAssetBundleResident", _m_IsAssetBundleResident);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MapAssetPath", _m_MapAssetPath);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAssetAsync", _m_LoadAssetAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RequestAssetFileAsync", _m_RequestAssetFileAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TestHotfix", _m_TestHotfix);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DownloadWebResourceAsync", _m_DownloadWebResourceAsync);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "curManifest", _g_get_curManifest);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsProsessRunning", _g_get_IsProsessRunning);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DownloadUrl", _g_get_DownloadUrl);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 0);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ManifestBundleName", _g_get_ManifestBundleName);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					Script.Framework.AssetBundle.AssetBundleManager __cl_gen_ret = new Script.Framework.AssetBundle.AssetBundleManager();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Script.Framework.AssetBundle.AssetBundleManager constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnAwake(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.OnAwake(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Initialize(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Collections.IEnumerator __cl_gen_ret = __cl_gen_to_be_invoked.Initialize(  );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Cleanup(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Collections.IEnumerator __cl_gen_ret = __cl_gen_to_be_invoked.Cleanup(  );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearAssetsCache(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.ClearAssetsCache(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Disable(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Disable(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RequestAssetBundleAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string assetbundleName = LuaAPI.lua_tostring(L, 2);
                    
                        Framework.AssetBundle.AsyncOperation.ResourceWebRequester __cl_gen_ret = __cl_gen_to_be_invoked.RequestAssetBundleAsync( assetbundleName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAssetBundleResident(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string assetbundleName = LuaAPI.lua_tostring(L, 2);
                    bool resident = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.SetAssetBundleResident( assetbundleName, resident );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAssetBundleAsyncCreater(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string assetbundleName = LuaAPI.lua_tostring(L, 2);
                    
                        Framework.AssetBundle.AsyncOperation.ResourceWebRequester __cl_gen_ret = __cl_gen_to_be_invoked.GetAssetBundleAsyncCreater( assetbundleName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAssetBundleCache(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string assetbundleName = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.AssetBundle __cl_gen_ret = __cl_gen_to_be_invoked.GetAssetBundleCache( assetbundleName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddAssetCache(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Object asset = (UnityEngine.Object)translator.GetObject(L, 3, typeof(UnityEngine.Object));
                    
                    __cl_gen_to_be_invoked.AddAssetCache( assetName, asset );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAssetCache(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.Object __cl_gen_ret = __cl_gen_to_be_invoked.GetAssetCache( assetName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsAssetLoaded(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsAssetLoaded( assetName );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsAssetBundleLoaded(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string assetbundleName = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsAssetBundleLoaded( assetbundleName );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddAssetbundleAssetsCache(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    string assetbundleName = LuaAPI.lua_tostring(L, 2);
                    string postfix = LuaAPI.lua_tostring(L, 3);
                    
                    __cl_gen_to_be_invoked.AddAssetbundleAssetsCache( assetbundleName, postfix );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string assetbundleName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.AddAssetbundleAssetsCache( assetbundleName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Script.Framework.AssetBundle.AssetBundleManager.AddAssetbundleAssetsCache!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DownloadAssetBundleAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string filePath = LuaAPI.lua_tostring(L, 2);
                    
                        Framework.AssetBundle.AsyncOperation.ResourceWebRequester __cl_gen_ret = __cl_gen_to_be_invoked.DownloadAssetBundleAsync( filePath );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DownloadAssetFileAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string filePath = LuaAPI.lua_tostring(L, 2);
                    
                        Framework.AssetBundle.AsyncOperation.ResourceWebRequester __cl_gen_ret = __cl_gen_to_be_invoked.DownloadAssetFileAsync( filePath );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAssetBundleAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string assetbundleName = LuaAPI.lua_tostring(L, 2);
                    
                        Framework.AssetBundle.AsyncOperation.BaseAssetBundleAsyncLoader __cl_gen_ret = __cl_gen_to_be_invoked.LoadAssetBundleAsync( assetbundleName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsAssetBundleResident(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string assebundleName = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsAssetBundleResident( assebundleName );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MapAssetPath(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string assetPath = LuaAPI.lua_tostring(L, 2);
                    string assetBundleName = LuaAPI.lua_tostring(L, 3);
                    string assetbundleName;
                    string assetName;
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.MapAssetPath( assetPath, assetBundleName, out assetbundleName, out assetName );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    LuaAPI.lua_pushstring(L, assetbundleName);
                        
                    LuaAPI.lua_pushstring(L, assetName);
                        
                    
                    
                    
                    return 3;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAssetAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string assetPath = LuaAPI.lua_tostring(L, 2);
                    System.Type assetType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    
                        Framework.AssetBundle.AsyncOperation.BaseAssetAsyncLoader __cl_gen_ret = __cl_gen_to_be_invoked.LoadAssetAsync( assetPath, assetType );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RequestAssetFileAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    string filePath = LuaAPI.lua_tostring(L, 2);
                    bool streamingAssetsOnly = LuaAPI.lua_toboolean(L, 3);
                    
                        Framework.AssetBundle.AsyncOperation.ResourceWebRequester __cl_gen_ret = __cl_gen_to_be_invoked.RequestAssetFileAsync( filePath, streamingAssetsOnly );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string filePath = LuaAPI.lua_tostring(L, 2);
                    
                        Framework.AssetBundle.AsyncOperation.ResourceWebRequester __cl_gen_ret = __cl_gen_to_be_invoked.RequestAssetFileAsync( filePath );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Script.Framework.AssetBundle.AssetBundleManager.RequestAssetFileAsync!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TestHotfix(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.TestHotfix(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DownloadWebResourceAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string url = LuaAPI.lua_tostring(L, 2);
                    
                        Framework.AssetBundle.AsyncOperation.ResourceWebRequester __cl_gen_ret = __cl_gen_to_be_invoked.DownloadWebResourceAsync( url );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ManifestBundleName(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, Script.Framework.AssetBundle.AssetBundleManager.ManifestBundleName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_curManifest(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.curManifest);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsProsessRunning(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.IsProsessRunning);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DownloadUrl(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Script.Framework.AssetBundle.AssetBundleManager __cl_gen_to_be_invoked = (Script.Framework.AssetBundle.AssetBundleManager)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.DownloadUrl);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
