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
    public class FrameworkAssetBundlesUtiltyAssetBundleUtilityWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Framework.AssetBundles.Utilty.AssetBundleUtility);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 11, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "PackagePathToAssetsPath", _m_PackagePathToAssetsPath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AssetBundlePathToAssetBundleName", _m_AssetBundlePathToAssetBundleName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AssetsPathToPackagePath", _m_AssetsPathToPackagePath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetPersistentDataPath", _m_GetPersistentDataPath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CheckPersistentFileExsits", _m_CheckPersistentFileExsits_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetPersistentFilePath", _m_GetPersistentFilePath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStreamingAssetsFilePath", _m_GetStreamingAssetsFilePath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAssetBundleFileUrl", _m_GetAssetBundleFileUrl_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStreamingAssetsDataPath", _m_GetStreamingAssetsDataPath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsPackagePath", _m_IsPackagePath_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					Framework.AssetBundles.Utilty.AssetBundleUtility __cl_gen_ret = new Framework.AssetBundles.Utilty.AssetBundleUtility();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Framework.AssetBundles.Utilty.AssetBundleUtility constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PackagePathToAssetsPath_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string assetPath = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = Framework.AssetBundles.Utilty.AssetBundleUtility.PackagePathToAssetsPath( assetPath );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AssetBundlePathToAssetBundleName_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string assetPath = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = Framework.AssetBundles.Utilty.AssetBundleUtility.AssetBundlePathToAssetBundleName( assetPath );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AssetsPathToPackagePath_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string assetPath = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = Framework.AssetBundles.Utilty.AssetBundleUtility.AssetsPathToPackagePath( assetPath );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPersistentDataPath_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string assetPath = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = Framework.AssetBundles.Utilty.AssetBundleUtility.GetPersistentDataPath( assetPath );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 0) 
                {
                    
                        string __cl_gen_ret = Framework.AssetBundles.Utilty.AssetBundleUtility.GetPersistentDataPath(  );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Framework.AssetBundles.Utilty.AssetBundleUtility.GetPersistentDataPath!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CheckPersistentFileExsits_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string filePath = LuaAPI.lua_tostring(L, 1);
                    
                        bool __cl_gen_ret = Framework.AssetBundles.Utilty.AssetBundleUtility.CheckPersistentFileExsits( filePath );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPersistentFilePath_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string assetPath = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = Framework.AssetBundles.Utilty.AssetBundleUtility.GetPersistentFilePath( assetPath );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 0) 
                {
                    
                        string __cl_gen_ret = Framework.AssetBundles.Utilty.AssetBundleUtility.GetPersistentFilePath(  );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Framework.AssetBundles.Utilty.AssetBundleUtility.GetPersistentFilePath!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStreamingAssetsFilePath_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string assetPath = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = Framework.AssetBundles.Utilty.AssetBundleUtility.GetStreamingAssetsFilePath( assetPath );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 0) 
                {
                    
                        string __cl_gen_ret = Framework.AssetBundles.Utilty.AssetBundleUtility.GetStreamingAssetsFilePath(  );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Framework.AssetBundles.Utilty.AssetBundleUtility.GetStreamingAssetsFilePath!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAssetBundleFileUrl_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string filePath = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = Framework.AssetBundles.Utilty.AssetBundleUtility.GetAssetBundleFileUrl( filePath );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStreamingAssetsDataPath_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string assetPath = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = Framework.AssetBundles.Utilty.AssetBundleUtility.GetStreamingAssetsDataPath( assetPath );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 0) 
                {
                    
                        string __cl_gen_ret = Framework.AssetBundles.Utilty.AssetBundleUtility.GetStreamingAssetsDataPath(  );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Framework.AssetBundles.Utilty.AssetBundleUtility.GetStreamingAssetsDataPath!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsPackagePath_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string assetPath = LuaAPI.lua_tostring(L, 1);
                    
                        bool __cl_gen_ret = Framework.AssetBundles.Utilty.AssetBundleUtility.IsPackagePath( assetPath );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
