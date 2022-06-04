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
				
				translator.DelayWrapLoader(typeof(UnityEngine.Object), UnityEngineObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Ray2D), UnityEngineRay2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GameObject), UnityEngineGameObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Component), UnityEngineComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Behaviour), UnityEngineBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Transform), UnityEngineTransformWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Resources), UnityEngineResourcesWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.TextAsset), UnityEngineTextAssetWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Keyframe), UnityEngineKeyframeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimationCurve), UnityEngineAnimationCurveWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimationClip), UnityEngineAnimationClipWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.MonoBehaviour), UnityEngineMonoBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem), UnityEngineParticleSystemWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SkinnedMeshRenderer), UnityEngineSkinnedMeshRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Renderer), UnityEngineRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Networking.UnityWebRequest), UnityEngineNetworkingUnityWebRequestWrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Collections.Generic.List<int>), SystemCollectionsGenericList_1_SystemInt32_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(ToolsDebug), ToolsDebugWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Events.UnityEvent), UnityEngineEventsUnityEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Bounds), UnityEngineBoundsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Color), UnityEngineColorWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.LayerMask), UnityEngineLayerMaskWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Mathf), UnityEngineMathfWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Plane), UnityEnginePlaneWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Quaternion), UnityEngineQuaternionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Ray), UnityEngineRayWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RaycastHit), UnityEngineRaycastHitWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Time), UnityEngineTimeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector2), UnityEngineVector2Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector3), UnityEngineVector3Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector4), UnityEngineVector4Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RenderMode), UnityEngineRenderModeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Canvas), UnityEngineCanvasWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Rect), UnityEngineRectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RectTransform), UnityEngineRectTransformWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RectOffset), UnityEngineRectOffsetWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Sprite), UnityEngineSpriteWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.CanvasScaler), UnityEngineUICanvasScalerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), UnityEngineUICanvasScalerScaleModeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), UnityEngineUICanvasScalerScreenMatchModeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.GraphicRaycaster), UnityEngineUIGraphicRaycasterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Text), UnityEngineUITextWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.InputField), UnityEngineUIInputFieldWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Button), UnityEngineUIButtonWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Image), UnityEngineUIImageWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.ScrollRect), UnityEngineUIScrollRectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Scrollbar), UnityEngineUIScrollbarWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Toggle), UnityEngineUIToggleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.ToggleGroup), UnityEngineUIToggleGroupWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Button.ButtonClickedEvent), UnityEngineUIButtonButtonClickedEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.ScrollRect.ScrollRectEvent), UnityEngineUIScrollRectScrollRectEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.GridLayoutGroup), UnityEngineUIGridLayoutGroupWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.ContentSizeFitter), UnityEngineUIContentSizeFitterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Slider), UnityEngineUISliderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ResourceRequest), UnityEngineResourceRequestWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SceneManagement.SceneManager), UnityEngineSceneManagementSceneManagerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.GC), SystemGCWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AsyncOperation), UnityEngineAsyncOperationWrap.__Register);
				
				
				
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
