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
    public class LuaPerfectObjectFormaterWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(LuaPerfect.ObjectFormater);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 11, 1, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "IsBasicType", _m_IsBasicType_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAllFields", _m_GetAllFields_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindProperty", _m_FindProperty_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAllProperties", _m_GetAllProperties_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetClassFullName", _m_GetClassFullName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetClassInfo", _m_GetClassInfo_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetChildrenGameObjects", _m_GetChildrenGameObjects_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FormatObject", _m_FormatObject_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "InnerFormatObject", _m_InnerFormatObject_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ClearObjectCache", _m_ClearObjectCache_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "s_classInfoDirectionary", _g_get_s_classInfoDirectionary);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "s_classInfoDirectionary", _s_set_s_classInfoDirectionary);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					LuaPerfect.ObjectFormater __cl_gen_ret = new LuaPerfect.ObjectFormater();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to LuaPerfect.ObjectFormater constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsBasicType_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    
                        bool __cl_gen_ret = LuaPerfect.ObjectFormater.IsBasicType( type );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllFields_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    
                        System.Collections.Generic.List<System.Reflection.FieldInfo> __cl_gen_ret = LuaPerfect.ObjectFormater.GetAllFields( type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindProperty_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Collections.Generic.List<System.Reflection.PropertyInfo> allProperties = (System.Collections.Generic.List<System.Reflection.PropertyInfo>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<System.Reflection.PropertyInfo>));
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = LuaPerfect.ObjectFormater.FindProperty( allProperties, name );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllProperties_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    
                        System.Collections.Generic.List<System.Reflection.PropertyInfo> __cl_gen_ret = LuaPerfect.ObjectFormater.GetAllProperties( type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetClassFullName_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    
                        string __cl_gen_ret = LuaPerfect.ObjectFormater.GetClassFullName( type );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetClassInfo_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    
                        LuaPerfect.ClassInfoItem __cl_gen_ret = LuaPerfect.ObjectFormater.GetClassInfo( type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetChildrenGameObjects_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.GameObject gameObject = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                        System.Collections.Generic.List<UnityEngine.GameObject> __cl_gen_ret = LuaPerfect.ObjectFormater.GetChildrenGameObjects( gameObject );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FormatObject_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    object obj = translator.GetObject(L, 1, typeof(object));
                    bool collectChildren = LuaAPI.lua_toboolean(L, 2);
                    
                        LuaPerfect.ObjectItem __cl_gen_ret = LuaPerfect.ObjectFormater.FormatObject( obj, collectChildren );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InnerFormatObject_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    object obj = translator.GetObject(L, 1, typeof(object));
                    bool collectChildren = LuaAPI.lua_toboolean(L, 2);
                    
                        LuaPerfect.ObjectItem __cl_gen_ret = LuaPerfect.ObjectFormater.InnerFormatObject( obj, collectChildren );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearObjectCache_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    LuaPerfect.ObjectFormater.ClearObjectCache(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_s_classInfoDirectionary(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, LuaPerfect.ObjectFormater.s_classInfoDirectionary);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_s_classInfoDirectionary(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    LuaPerfect.ObjectFormater.s_classInfoDirectionary = (System.Collections.Generic.Dictionary<System.Type, LuaPerfect.ClassInfoItem>)translator.GetObject(L, 1, typeof(System.Collections.Generic.Dictionary<System.Type, LuaPerfect.ClassInfoItem>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
