#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter((luaenv, translator) => {
			    
				translator.DelayWrapLoader(typeof(LoginUIBase), LoginUIBaseWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIRoot), UIRootWrap.__Register);
				
				translator.DelayWrapLoader(typeof(AssetBundleUpdater), AssetBundleUpdaterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameMain), GameMainWrap.__Register);
				
				translator.DelayWrapLoader(typeof(LuaPerfect.ObjectRef), LuaPerfectObjectRefWrap.__Register);
				
				translator.DelayWrapLoader(typeof(LuaPerfect.ObjectItem), LuaPerfectObjectItemWrap.__Register);
				
				translator.DelayWrapLoader(typeof(LuaPerfect.ObjectFormater), LuaPerfectObjectFormaterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(AssetBundles.Config.Manifest), AssetBundlesConfigManifestWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Framework.AssetBundles.Utilty.AssetBundleUtility), FrameworkAssetBundlesUtiltyAssetBundleUtilityWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Framework.AssetBundle.Config.AssetsPathMapping), FrameworkAssetBundleConfigAssetsPathMappingWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Framework.AssetBundle.AsyncOperation.AssetAsyncLoader), FrameworkAssetBundleAsyncOperationAssetAsyncLoaderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Framework.AssetBundle.AsyncOperation.AssetBundleAsyncLoader), FrameworkAssetBundleAsyncOperationAssetBundleAsyncLoaderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Framework.AssetBundle.AsyncOperation.ResourceWebRequester), FrameworkAssetBundleAsyncOperationResourceWebRequesterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Script.Framework.UI.Tip.UINoticeTip), ScriptFrameworkUITipUINoticeTipWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Script.Framework.AssetBundle.AssetBundleManager), ScriptFrameworkAssetBundleAssetBundleManagerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Common.GameChannel.ChannelManager), CommonGameChannelChannelManagerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(object), SystemObjectWrap.__Register);
				
				
				
				translator.AddInterfaceBridgeCreator(typeof(System.Collections.IEnumerator), SystemCollectionsIEnumeratorBridge.__Create);
				
			});
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	internal partial class InternalGlobals
    {
	    
	    static InternalGlobals()
		{
		    extensionMethodMap = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
			};
			
			genTryArrayGetPtr = StaticLuaCallbacks.__tryArrayGet;
            genTryArraySetPtr = StaticLuaCallbacks.__tryArraySet;
		}
	}
}
