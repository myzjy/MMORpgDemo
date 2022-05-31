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
    public class AssetBundlesConfigManifestWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(AssetBundles.Config.Manifest);
			Utils.BeginObjectRegister(type, L, translator, 0, 9, 3, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadFromAssetBundle", _m_LoadFromAssetBundle);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SaveBytes", _m_SaveBytes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SaveToDiskCahce", _m_SaveToDiskCahce);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAssetBundleHash", _m_GetAssetBundleHash);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllAssetBundleNames", _m_GetAllAssetBundleNames);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllAssetBundlesWithVariant", _m_GetAllAssetBundlesWithVariant);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllDependencies", _m_GetAllDependencies);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDirectDependencies", _m_GetDirectDependencies);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CompareTo", _m_CompareTo);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "assetbundleManifest", _g_get_assetbundleManifest);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AssetbundleName", _g_get_AssetbundleName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Length", _g_get_Length);
            
			
			
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
					
					AssetBundles.Config.Manifest __cl_gen_ret = new AssetBundles.Config.Manifest();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to AssetBundles.Config.Manifest constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadFromAssetBundle(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.Config.Manifest __cl_gen_to_be_invoked = (AssetBundles.Config.Manifest)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.AssetBundle assetBundle = (UnityEngine.AssetBundle)translator.GetObject(L, 2, typeof(UnityEngine.AssetBundle));
                    
                    __cl_gen_to_be_invoked.LoadFromAssetBundle( assetBundle );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SaveBytes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.Config.Manifest __cl_gen_to_be_invoked = (AssetBundles.Config.Manifest)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    byte[] bytes = LuaAPI.lua_tobytes(L, 2);
                    
                    __cl_gen_to_be_invoked.SaveBytes( bytes );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SaveToDiskCahce(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.Config.Manifest __cl_gen_to_be_invoked = (AssetBundles.Config.Manifest)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.SaveToDiskCahce(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAssetBundleHash(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.Config.Manifest __cl_gen_to_be_invoked = (AssetBundles.Config.Manifest)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.Hash128 __cl_gen_ret = __cl_gen_to_be_invoked.GetAssetBundleHash( name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllAssetBundleNames(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.Config.Manifest __cl_gen_to_be_invoked = (AssetBundles.Config.Manifest)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string[] __cl_gen_ret = __cl_gen_to_be_invoked.GetAllAssetBundleNames(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllAssetBundlesWithVariant(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.Config.Manifest __cl_gen_to_be_invoked = (AssetBundles.Config.Manifest)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string[] __cl_gen_ret = __cl_gen_to_be_invoked.GetAllAssetBundlesWithVariant(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllDependencies(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.Config.Manifest __cl_gen_to_be_invoked = (AssetBundles.Config.Manifest)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string assetbundleName = LuaAPI.lua_tostring(L, 2);
                    
                        string[] __cl_gen_ret = __cl_gen_to_be_invoked.GetAllDependencies( assetbundleName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDirectDependencies(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.Config.Manifest __cl_gen_to_be_invoked = (AssetBundles.Config.Manifest)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string assetbundleName = LuaAPI.lua_tostring(L, 2);
                    
                        string[] __cl_gen_ret = __cl_gen_to_be_invoked.GetDirectDependencies( assetbundleName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CompareTo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.Config.Manifest __cl_gen_to_be_invoked = (AssetBundles.Config.Manifest)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    AssetBundles.Config.Manifest otherManifest = (AssetBundles.Config.Manifest)translator.GetObject(L, 2, typeof(AssetBundles.Config.Manifest));
                    
                        System.Collections.Generic.List<string> __cl_gen_ret = __cl_gen_to_be_invoked.CompareTo( otherManifest );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_assetbundleManifest(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                AssetBundles.Config.Manifest __cl_gen_to_be_invoked = (AssetBundles.Config.Manifest)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.assetbundleManifest);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AssetbundleName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                AssetBundles.Config.Manifest __cl_gen_to_be_invoked = (AssetBundles.Config.Manifest)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.AssetbundleName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Length(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                AssetBundles.Config.Manifest __cl_gen_to_be_invoked = (AssetBundles.Config.Manifest)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.Length);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
