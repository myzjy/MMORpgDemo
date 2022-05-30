# MMORpgDemo
 MMORpgDemo

框架基于 xluaframerwork 制作

lua代码 制作 UI模块 lua代码需要根据需求修改制作

战斗方面采用c#层调用lua层的ui显示

战斗技能方面全部放服务端

人物移动交互相关全部都要与服务器交互

服务器方面 c++ drogon框架制作，预计分布式形式 在linux平台写
(https://github.com/myzjy/GameAndServerProject)

以上是目前计划

准备游戏类型为act或者mmo类型

项目并未完善 计划比较大

qq 2910553808

流程在陆续完善
[项目整体流程](https://www.processon.com/view/link/629385ac7d9c085adb740a1c)

项目asset文件夹 整体树
````
├─AssetBundles                  ---打包文件之后存放文件夹位置
│  ├─Android                    ---打包选择的平台
│  │  ├─Android                 ---平台文件夹
│  │  │  └─AssetBundles         ---打包文件
│  │  └─Test                    ---测试
│  │      └─AssetBundles        ---打包文件夹
│  └─StandaloneWindows          ---pc平台
├─Assets                        ---项目
│  ├─AddressableAssetsData
│  │  ├─AssetGroups
│  │  │  └─Schemas
│  │  ├─AssetGroupTemplates
│  │  └─DataBuilders
│  ├─AddressablePaker
│  │  ├─Channel
│  │  ├─Lua
│  │  │  ├─Common
│  │  │  │  └─Tools
│  │  │  │      └─ToolsObj
│  │  │  ├─Config
│  │  │  ├─Global
│  │  │  ├─UI
│  │  │  │  ├─Config
│  │  │  │  └─Login
│  │  │  └─XLua
│  │  │      └─Hotfix
│  │  └─UI
│  │      └─Prefab
│  ├─Editor
│  │  ├─AddressableEditor
│  │  ├─AssetBundle
│  │  │  ├─Build
│  │  │  ├─Database
│  │  │  │  ├─AddressablePaker
│  │  │  │  └─AssetsPackage
│  │  │  │      └─UI
│  │  │  ├─Dispatcher
│  │  │  ├─Inspector
│  │  │  ├─LocalServer
│  │  │  └─Tools
│  │  ├─Common
│  │  │  ├─EditorCoroutines
│  │  │  └─Inspector
│  │  ├─GameTools
│  │  ├─PackageBuild
│  │  │  └─Image
│  │  ├─UniversalRenderPipeline
│  │  └─XLua
│  │      ├─LinkXmlGen
│  │      └─Template
│  ├─Game
│  │  └─Sprite
│  │      ├─GameBg
│  │      └─LoginSprite
│  │          └─touxiang
│  ├─LuaScript
│  │  ├─Common
│  │  │  └─Tools
│  │  │      └─ToolsObj
│  │  ├─Config
│  │  ├─Global
│  │  ├─UI
│  │  │  ├─Config
│  │  │  └─Login
│  │  └─XLua
│  │      └─Hotfix
│  ├─Plugins
│  │  ├─Android
│  │  │  └─libs
│  │  │      ├─arm64-v8a
│  │  │      ├─armeabi-v7a
│  │  │      └─x86
│  │  ├─iOS
│  │  ├─UniRx
│  │  │  ├─Examples
│  │  │  └─Scripts
│  │  │      ├─Asynchronous
│  │  │      ├─Disposables
│  │  │      ├─InternalUtil
│  │  │      ├─Notifiers
│  │  │      ├─Operators
│  │  │      ├─Schedulers
│  │  │      ├─Subjects
│  │  │      ├─System
│  │  │      ├─Tasks
│  │  │      ├─UnityEngineBridge
│  │  │      │  ├─Diagnostics
│  │  │      │  ├─Operators
│  │  │      │  ├─Toolkit
│  │  │      │  └─Triggers
│  │  │      └─UnityWinRTBridge
│  │  ├─WebGL
│  │  ├─WSA
│  │  │  ├─ARM
│  │  │  ├─ARM64
│  │  │  ├─x64
│  │  │  └─x86
│  │  ├─x86
│  │  ├─x86_64
│  │  └─xlua.bundle
│  │      └─Contents
│  │          └─MacOS
│  ├─Scenes
│  ├─Script
│  │  ├─Channel
│  │  │  └─Implement
│  │  ├─Common
│  │  │  ├─Http
│  │  │  │  └─Net
│  │  │  │      └─ModelNext
│  │  │  ├─Tools
│  │  │  ├─UI
│  │  │  └─Utility
│  │  ├─Config
│  │  ├─Framework
│  │  │  ├─Addressables
│  │  │  │  └─Config
│  │  │  ├─AssetBundle
│  │  │  │  ├─AsyncOperation
│  │  │  │  ├─Config
│  │  │  │  └─Utilty
│  │  │  └─UI
│  │  │      ├─Login
│  │  │      └─Tip
│  │  ├─GamLaunch
│  │  ├─Tools
│  │  │  └─Util
│  │  └─Xlua
│  │      ├─Gen
│  │      ├─Script
│  │      │  └─TemplateEngine
│  │      ├─Support
│  │      └─XLua
│  ├─Sprite_Atlas
│  ├─StreamingAssets
│  │  └─AssetBundles
│  └─ThirdParty
│      └─LuaPerfect
│          └─Editor
├─Library
│  ├─APIUpdater
│  ├─Artifacts
│  ├─com.unity.addressables
│  ├─PackageCache
│  │  ├─com.unity.addressables@1.16.19
│  │  ├─com.unity.assetbundlebrowser@1.7.0
│  │  ├─com.unity.collab-proxy@1.2.16
│  │  ├─com.unity.ext.nunit@1.0.6
│  │  ├─com.unity.ide.rider@1.2.1
│  │  ├─com.unity.ide.visualstudio@2.0.8
│  │  ├─com.unity.modules.ai@1.0.0
│  │  ├─com.unity.modules.androidjni@1.0.0
│  │  ├─com.unity.modules.animation@1.0.0
│  │  ├─com.unity.modules.assetbundle@1.0.0
│  │  ├─com.unity.modules.audio@1.0.0
│  │  ├─com.unity.modules.cloth@1.0.0
│  │  ├─com.unity.modules.director@1.0.0
│  │  ├─com.unity.modules.imageconversion@1.0.0
│  │  ├─com.unity.modules.imgui@1.0.0
│  │  ├─com.unity.modules.jsonserialize@1.0.0
│  │  ├─com.unity.modules.particlesystem@1.0.0
│  │  ├─com.unity.modules.physics2d@1.0.0
│  │  ├─com.unity.modules.physics@1.0.0
│  │  ├─com.unity.modules.screencapture@1.0.0
│  │  ├─com.unity.modules.subsystems@1.0.0
│  │  ├─com.unity.modules.terrain@1.0.0
│  │  ├─com.unity.modules.terrainphysics@1.0.0
│  │  ├─com.unity.modules.tilemap@1.0.0
│  │  ├─com.unity.modules.ui@1.0.0
│  │  ├─com.unity.modules.uielements@1.0.0
│  │  ├─com.unity.modules.umbra@1.0.0
│  │  ├─com.unity.modules.unityanalytics@1.0.0
│  │  ├─com.unity.modules.unitywebrequest@1.0.0
│  │  ├─com.unity.modules.unitywebrequestassetbundle@1.0.0
│  │  ├─com.unity.modules.unitywebrequestaudio@1.0.0
│  │  ├─com.unity.modules.unitywebrequesttexture@1.0.0
│  │  ├─com.unity.modules.unitywebrequestwww@1.0.0
│  │  ├─com.unity.modules.vehicles@1.0.0
│  │  ├─com.unity.modules.video@1.0.0
│  │  ├─com.unity.modules.vr@1.0.0
│  │  ├─com.unity.modules.wind@1.0.0
│  │  ├─com.unity.modules.xr@1.0.0
│  │  ├─com.unity.render-pipelines.core@7.6.0
│  │  ├─com.unity.render-pipelines.universal@7.6.0
│  │  ├─com.unity.scriptablebuildpipeline@1.15.2
│  │  ├─com.unity.shadergraph@7.6.0
│  │  ├─com.unity.test-framework@1.1.24
│  │  ├─com.unity.textmeshpro@2.1.6
│  │  ├─com.unity.timeline@1.2.18
│  │  └─com.unity.ugui@1.0.0
│  ├─ScriptAssemblies
│  ├─ShaderCache
│  ├─StateCache
│  │  ├─Hierarchy
│  │  ├─LayerSettings
│  │  └─SceneView
│  ├─TempArtifacts
│  │  ├─Extra
│  │  └─Primary
│  └─UIElements
│      └─EditorWindows
├─Logs
├─obj
│  └─Debug
│      └─TempPE
├─Packages
├─ProjectSettings
├─Temp
│  ├─bin
│  │  └─Debug
│  └─ProcessJobs
└─Tools
````

