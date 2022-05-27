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

		    Utils.BeginClassRegister(type, L, __CreateInstance, 4, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "PackagePathToAssetsPath", _m_PackagePathToAssetsPath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AssetBundlePathToAssetBundleName", _m_AssetBundlePathToAssetBundleName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AssetsPathToPackagePath", _m_AssetsPathToPackagePath_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new Framework.AssetBundles.Utilty.AssetBundleUtility();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Framework.AssetBundles.Utilty.AssetBundleUtility constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PackagePathToAssetsPath_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _assetPath = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = Framework.AssetBundles.Utilty.AssetBundleUtility.PackagePathToAssetsPath( _assetPath );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AssetBundlePathToAssetBundleName_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _assetPath = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = Framework.AssetBundles.Utilty.AssetBundleUtility.AssetBundlePathToAssetBundleName( _assetPath );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AssetsPathToPackagePath_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _assetPath = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = Framework.AssetBundles.Utilty.AssetBundleUtility.AssetsPathToPackagePath( _assetPath );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
