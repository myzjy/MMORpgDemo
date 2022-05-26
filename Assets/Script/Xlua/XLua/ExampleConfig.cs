/*
 * Tencent is pleased to support the open source community by making xLua available.
 * Copyright (C) 2016 THL A29 Limited, a Tencent company. All rights reserved.
 * Licensed under the MIT License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
 * http://opensource.org/licenses/MIT
 * Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
*/

using System.Collections.Generic;
using System;
using XLua;
using System.Reflection;
using System.Linq;
using UnityEngine;

//配置的详细介绍请看Doc下《XLua的配置.doc》
public static class ExampleConfig
{
    //lua中要使用到C#库的配置，比如C#标准库，或者Unity API，第三方库等。
    [LuaCallCSharp] public static List<Type> LuaCallCSharp = new List<Type>()
    {
        // unity
        typeof(System.Object),
        typeof(UnityEngine.Object),
        typeof(Ray2D),
        typeof(GameObject),
        typeof(Component),
        typeof(Behaviour),
        typeof(Transform),
        typeof(Resources),
        // typeof(TextAsset),
        // typeof(Keyframe),
        // typeof(AnimationCurve),
        // typeof(AnimationClip),
        // typeof(MonoBehaviour),
        // typeof(ParticleSystem),
        // typeof(SkinnedMeshRenderer),
        // typeof(Renderer),
        // typeof(WWW),
        // typeof(List<int>),
        // typeof(Action<string>),
        typeof(ToolsDebug),
        /* UnityEngine.Debug 可能根据版本，生成版本代码，有问题，所以需要自己依据UnityEngine.Debug 源代码，实现一个新的Debug*/
        // typeof(Debug),
        // typeof(Delegate),
        // typeof(Dictionary<string, GameObject>),
        // typeof(UnityEngine.Events.UnityEvent),
        //
        // // unity结合lua，这部分导出很多功能在lua侧重新实现，没有实现的功能才会跑到cs侧
        // typeof(Bounds),
        // typeof(Color),
        // typeof(LayerMask),
        // typeof(Mathf),
        // typeof(Plane),
        // typeof(Quaternion),
        // typeof(Ray),
        // typeof(RaycastHit),
        // typeof(Time),
        // typeof(Touch),
        // typeof(TouchPhase),
        // typeof(Vector2),
        // typeof(Vector3),
        // typeof(Vector4),
        //
        // // 渲染
        // typeof(RenderMode),
        //
        // // UGUI  
        // typeof(UnityEngine.Canvas),
        // typeof(UnityEngine.Rect),
        // typeof(UnityEngine.RectTransform),
        // typeof(UnityEngine.RectOffset),
        // typeof(UnityEngine.Sprite),
        // typeof(UnityEngine.UI.CanvasScaler),
        // typeof(UnityEngine.UI.CanvasScaler.ScaleMode),
        // typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode),
        // typeof(UnityEngine.UI.GraphicRaycaster),
        // typeof(UnityEngine.UI.Text),
        // typeof(UnityEngine.UI.InputField),
        // typeof(UnityEngine.UI.Button),
        // typeof(UnityEngine.UI.Image),
        // typeof(UnityEngine.UI.ScrollRect),
        // typeof(UnityEngine.UI.Scrollbar),
        // typeof(UnityEngine.UI.Toggle),
        // typeof(UnityEngine.UI.ToggleGroup),
        // typeof(UnityEngine.UI.Button.ButtonClickedEvent),
        // typeof(UnityEngine.UI.ScrollRect.ScrollRectEvent),
        // typeof(UnityEngine.UI.GridLayoutGroup),
        // typeof(UnityEngine.UI.ContentSizeFitter),
        // typeof(UnityEngine.UI.Slider),
        //
        //
        // // 场景、资源加载
        // typeof(UnityEngine.Resources),
        // typeof(UnityEngine.ResourceRequest),
        // typeof(UnityEngine.SceneManagement.SceneManager),
        //
        // // 其它
        // typeof(PlayerPrefs),
        // typeof(System.GC),
        // typeof(AsyncOperation),
    };

    //C#静态调用Lua的配置（包括事件的原型），仅可以配delegate，interface
    [CSharpCallLua] public static List<Type> CSharpCallLua = new List<Type>()
    {
        // unity
        typeof(Action),
        // typeof(Action<int>),
        // typeof(Action<WWW>),
        // typeof(Callback),
        // typeof(UnityEngine.Event),
        // typeof(UnityEngine.Events.UnityAction),
        // typeof(System.Collections.IEnumerator),
        // typeof(UnityEngine.Events.UnityAction<Vector2>),
    };

    // 避免在IL2CPP下被裁剪
    [ReflectionUse] public static List<Type> ReflectionUse = new List<Type>()
    {
        typeof(AsyncOperation),
    };

    //黑名单
    [BlackList] public static List<List<string>> BlackList = new List<List<string>>()
    {
        // new List<string>() {"UnityEngine.Debug", "ExtractStackTraceNoAlloc"},
        new List<string>() {"System.Xml.XmlNodeList", "ItemOf"},
        new List<string>() {"UnityEngine.WWW", "movie"},
#if UNITY_WEBGL
                new List<string>(){"UnityEngine.WWW", "threadPriority"},
#endif
        new List<string>() {"UnityEngine.Texture2D", "alphaIsTransparency"},
        new List<string>() {"UnityEngine.Security", "GetChainOfTrustValue"},
        new List<string>() {"UnityEngine.CanvasRenderer", "onRequestRebuild"},
        new List<string>() {"UnityEngine.Light", "areaSize"},
        new List<string>() {"UnityEngine.Light", "lightmapBakeType"},
        new List<string>() {"UnityEngine.WWW", "MovieTexture"},
        new List<string>() {"UnityEngine.WWW", "GetMovieTexture"},
        new List<string>() {"UnityEngine.AnimatorOverrideController", "PerformOverrideClipListCleanup"},
#if !UNITY_WEBPLAYER
        new List<string>() {"UnityEngine.Application", "ExternalEval"},
#endif
        new List<string>() {"UnityEngine.GameObject", "networkView"}, //4.6.2 not support
        new List<string>() {"UnityEngine.Component", "networkView"}, //4.6.2 not support
        new List<string>()
            {"System.IO.FileInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
        new List<string>() {"System.IO.FileInfo", "SetAccessControl", "System.Security.AccessControl.FileSecurity"},
        new List<string>()
            {"System.IO.DirectoryInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
        new List<string>()
            {"System.IO.DirectoryInfo", "SetAccessControl", "System.Security.AccessControl.DirectorySecurity"},
        new List<string>()
        {
            "System.IO.DirectoryInfo", "CreateSubdirectory", "System.String",
            "System.Security.AccessControl.DirectorySecurity"
        },
        new List<string>() {"System.IO.DirectoryInfo", "Create", "System.Security.AccessControl.DirectorySecurity"},
        new List<string>() {"UnityEngine.MonoBehaviour", "runInEditMode"},
    };

#if UNITY_2018_1_OR_NEWER
    [BlackList] public static Func<MemberInfo, bool> MethodFilter = (memberInfo) =>
    {
        if (memberInfo.DeclaringType.IsGenericType &&
            memberInfo.DeclaringType.GetGenericTypeDefinition() == typeof(Dictionary<,>))
        {
            if (memberInfo.MemberType == MemberTypes.Constructor)
            {
                ConstructorInfo constructorInfo = memberInfo as ConstructorInfo;
                var parameterInfos = constructorInfo.GetParameters();
                if (parameterInfos.Length > 0)
                {
                    if (typeof(System.Collections.IEnumerable).IsAssignableFrom(parameterInfos[0].ParameterType))
                    {
                        return true;
                    }
                }
            }
            else if (memberInfo.MemberType == MemberTypes.Method)
            {
                var methodInfo = memberInfo as MethodInfo;
                if (methodInfo.Name == "TryAdd" ||
                    methodInfo.Name == "Remove" && methodInfo.GetParameters().Length == 2)
                {
                    return true;
                }
            }
        }

        return false;
    };
#endif
}