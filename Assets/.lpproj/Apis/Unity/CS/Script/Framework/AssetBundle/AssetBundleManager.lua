---@module CS.Script.Framework.AssetBundle
CS.Script.Framework.AssetBundle = {}

---@class CS.Script.Framework.AssetBundle.AssetBundleManager : CS.GameTools.Singletons.MMOSingletonDontDestroy
CS.Script.Framework.AssetBundle.AssetBundleManager = {}

---@property readonly CS.Script.Framework.AssetBundle.AssetBundleManager.ManifestBundleName : CS.System.String
CS.Script.Framework.AssetBundle.AssetBundleManager.ManifestBundleName = nil

---@property readonly CS.Script.Framework.AssetBundle.AssetBundleManager.curManifest : CS.AssetBundles.Config.Manifest
CS.Script.Framework.AssetBundle.AssetBundleManager.curManifest = nil

---@property readonly CS.Script.Framework.AssetBundle.AssetBundleManager.IsProsessRunning : CS.System.Boolean
CS.Script.Framework.AssetBundle.AssetBundleManager.IsProsessRunning = nil

---@property readonly CS.Script.Framework.AssetBundle.AssetBundleManager.DownloadUrl : CS.System.String
CS.Script.Framework.AssetBundle.AssetBundleManager.DownloadUrl = nil

---@return CS.Script.Framework.AssetBundle.AssetBundleManager
function CS.Script.Framework.AssetBundle.AssetBundleManager()
end

function CS.Script.Framework.AssetBundle.AssetBundleManager:OnAwake()
end

---@return CS.System.Collections.IEnumerator
function CS.Script.Framework.AssetBundle.AssetBundleManager:Initialize()
end

---@return CS.System.Collections.IEnumerator
function CS.Script.Framework.AssetBundle.AssetBundleManager:Cleanup()
end

function CS.Script.Framework.AssetBundle.AssetBundleManager:ClearAssetsCache()
end

function CS.Script.Framework.AssetBundle.AssetBundleManager:Disable()
end

---@param assetbundleName : CS.System.String
---@return CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester
function CS.Script.Framework.AssetBundle.AssetBundleManager:RequestAssetBundleAsync(assetbundleName)
end

---@param assetbundleName : CS.System.String
---@param resident : CS.System.Boolean
function CS.Script.Framework.AssetBundle.AssetBundleManager:SetAssetBundleResident(assetbundleName, resident)
end

---@param assetbundleName : CS.System.String
---@return CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester
function CS.Script.Framework.AssetBundle.AssetBundleManager:GetAssetBundleAsyncCreater(assetbundleName)
end

---@param assetbundleName : CS.System.String
---@return CS.UnityEngine.AssetBundle
function CS.Script.Framework.AssetBundle.AssetBundleManager:GetAssetBundleCache(assetbundleName)
end

---@param assetName : CS.System.String
---@param asset : CS.UnityEngine.Object
function CS.Script.Framework.AssetBundle.AssetBundleManager:AddAssetCache(assetName, asset)
end

---@param assetName : CS.System.String
---@return CS.UnityEngine.Object
function CS.Script.Framework.AssetBundle.AssetBundleManager:GetAssetCache(assetName)
end

---@param assetName : CS.System.String
---@return CS.System.Boolean
function CS.Script.Framework.AssetBundle.AssetBundleManager:IsAssetLoaded(assetName)
end

---@param assetbundleName : CS.System.String
---@return CS.System.Boolean
function CS.Script.Framework.AssetBundle.AssetBundleManager:IsAssetBundleLoaded(assetbundleName)
end

---@param assetbundleName : CS.System.String
---@param postfix : CS.System.String
function CS.Script.Framework.AssetBundle.AssetBundleManager:AddAssetbundleAssetsCache(assetbundleName, postfix)
end

---@param filePath : CS.System.String
---@return CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester
function CS.Script.Framework.AssetBundle.AssetBundleManager:DownloadAssetBundleAsync(filePath)
end

---@param filePath : CS.System.String
---@return CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester
function CS.Script.Framework.AssetBundle.AssetBundleManager:DownloadAssetFileAsync(filePath)
end

---@param assetbundleName : CS.System.String
---@return CS.Framework.AssetBundle.AsyncOperation.BaseAssetBundleAsyncLoader
function CS.Script.Framework.AssetBundle.AssetBundleManager:LoadAssetBundleAsync(assetbundleName)
end

---@param assebundleName : CS.System.String
---@return CS.System.Boolean
function CS.Script.Framework.AssetBundle.AssetBundleManager:IsAssetBundleResident(assebundleName)
end

---@param assetPath : CS.System.String
---@param assetbundleName : CS.System.String
---@param assetName : CS.System.String
---@return CS.System.Boolean
function CS.Script.Framework.AssetBundle.AssetBundleManager:MapAssetPath(assetPath, assetbundleName, assetName)
end

---@param assetPath : CS.System.String
---@param assetType : CS.System.Type
---@return CS.Framework.AssetBundle.AsyncOperation.BaseAssetAsyncLoader
function CS.Script.Framework.AssetBundle.AssetBundleManager:LoadAssetAsync(assetPath, assetType)
end

---@param filePath : CS.System.String
---@param streamingAssetsOnly : CS.System.Boolean
---@return CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester
function CS.Script.Framework.AssetBundle.AssetBundleManager:RequestAssetFileAsync(filePath, streamingAssetsOnly)
end

function CS.Script.Framework.AssetBundle.AssetBundleManager:TestHotfix()
end

---@param url : CS.System.String
---@return CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester
function CS.Script.Framework.AssetBundle.AssetBundleManager:DownloadWebResourceAsync(url)
end

---@return CS.System.Collections.Generic.HashSet
function CS.Script.Framework.AssetBundle.AssetBundleManager:GetAssetbundleResident()
end

---@return CS.System.Collections.Generic.ICollection
function CS.Script.Framework.AssetBundle.AssetBundleManager:GetAssetbundleCaching()
end

---@return CS.System.Collections.Generic.Dictionary
function CS.Script.Framework.AssetBundle.AssetBundleManager:GetWebRequesting()
end

---@return CS.System.Collections.Generic.Queue
function CS.Script.Framework.AssetBundle.AssetBundleManager:GetWebRequestQueue()
end

---@return CS.System.Collections.Generic.List
function CS.Script.Framework.AssetBundle.AssetBundleManager:GetProsessingWebRequester()
end

---@return CS.System.Collections.Generic.List
function CS.Script.Framework.AssetBundle.AssetBundleManager:GetProsessingAssetBundleAsyncLoader()
end

---@return CS.System.Collections.Generic.List
function CS.Script.Framework.AssetBundle.AssetBundleManager:GetProsessingAssetAsyncLoader()
end

---@param assetName : CS.System.String
---@return CS.System.String
function CS.Script.Framework.AssetBundle.AssetBundleManager:GetAssetBundleName(assetName)
end

---@return CS.System.Int32
function CS.Script.Framework.AssetBundle.AssetBundleManager:GetAssetCachingCount()
end

---@return CS.System.Collections.Generic.Dictionary
function CS.Script.Framework.AssetBundle.AssetBundleManager:GetAssetCaching()
end

---@param assetbundleName : CS.System.String
---@return CS.System.Int32
function CS.Script.Framework.AssetBundle.AssetBundleManager:GetAssetbundleRefrenceCount(assetbundleName)
end

---@param assetbundleName : CS.System.String
---@return CS.System.Int32
function CS.Script.Framework.AssetBundle.AssetBundleManager:GetAssetbundleDependenciesCount(assetbundleName)
end

---@param assetbundleName : CS.System.String
---@return CS.System.Collections.Generic.List
function CS.Script.Framework.AssetBundle.AssetBundleManager:GetAssetBundleRefrences(assetbundleName)
end

---@param assetbundleName : CS.System.String
---@return CS.System.Collections.Generic.List
function CS.Script.Framework.AssetBundle.AssetBundleManager:GetWebRequesterRefrences(assetbundleName)
end

---@param assetbundleName : CS.System.String
---@return CS.System.Collections.Generic.List
function CS.Script.Framework.AssetBundle.AssetBundleManager:GetAssetBundleLoaderRefrences(assetbundleName)
end