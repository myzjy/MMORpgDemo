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
    public class FrameworkAssetBundleConfigAssetsPathMappingWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Framework.AssetBundle.Config.AssetsPathMapping);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 2, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Initialize", _m_Initialize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MapAssetPath", _m_MapAssetPath);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllAssetNames", _m_GetAllAssetNames);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAssetBundleName", _m_GetAssetBundleName);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "AssetbundleName", _g_get_AssetbundleName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AssetName", _g_get_AssetName);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "AssetbundleName", _s_set_AssetbundleName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "AssetName", _s_set_AssetName);
            
			
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
					
					Framework.AssetBundle.Config.AssetsPathMapping __cl_gen_ret = new Framework.AssetBundle.Config.AssetsPathMapping();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Framework.AssetBundle.Config.AssetsPathMapping constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Initialize(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Framework.AssetBundle.Config.AssetsPathMapping __cl_gen_to_be_invoked = (Framework.AssetBundle.Config.AssetsPathMapping)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string content = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.Initialize( content );
                    
                    
                    
                    return 0;
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
            
            
                Framework.AssetBundle.Config.AssetsPathMapping __cl_gen_to_be_invoked = (Framework.AssetBundle.Config.AssetsPathMapping)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_GetAllAssetNames(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Framework.AssetBundle.Config.AssetsPathMapping __cl_gen_to_be_invoked = (Framework.AssetBundle.Config.AssetsPathMapping)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string assetbundleName = LuaAPI.lua_tostring(L, 2);
                    
                        System.Collections.Generic.List<string> __cl_gen_ret = __cl_gen_to_be_invoked.GetAllAssetNames( assetbundleName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAssetBundleName(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Framework.AssetBundle.Config.AssetsPathMapping __cl_gen_to_be_invoked = (Framework.AssetBundle.Config.AssetsPathMapping)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.GetAssetBundleName( assetName );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AssetbundleName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Framework.AssetBundle.Config.AssetsPathMapping __cl_gen_to_be_invoked = (Framework.AssetBundle.Config.AssetsPathMapping)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.AssetbundleName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AssetName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Framework.AssetBundle.Config.AssetsPathMapping __cl_gen_to_be_invoked = (Framework.AssetBundle.Config.AssetsPathMapping)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.AssetName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AssetbundleName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Framework.AssetBundle.Config.AssetsPathMapping __cl_gen_to_be_invoked = (Framework.AssetBundle.Config.AssetsPathMapping)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.AssetbundleName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AssetName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Framework.AssetBundle.Config.AssetsPathMapping __cl_gen_to_be_invoked = (Framework.AssetBundle.Config.AssetsPathMapping)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.AssetName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
