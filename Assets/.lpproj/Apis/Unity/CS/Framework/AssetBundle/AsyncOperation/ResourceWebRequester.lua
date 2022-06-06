---@class CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester : CS.Framework.AssetBundle.AsyncOperation.ResourceAsyncOperation
CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester = {}

---@property readwrite CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester.Sequence : CS.System.Int32
CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester.Sequence = nil

---@property readwrite CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester.noCache : CS.System.Boolean
CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester.noCache = nil

---@property readwrite CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester.assetbundleName : CS.System.String
CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester.assetbundleName = nil

---@property readwrite CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester.url : CS.System.String
CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester.url = nil

---@property readonly CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester.assetbundle : CS.UnityEngine.AssetBundle
CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester.assetbundle = nil

---@property readonly CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester.bytes : CS.System.Byte[]
CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester.bytes = nil

---@property readonly CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester.text : CS.System.String
CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester.text = nil

---@property readonly CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester.getSendWebRequest : CS.System.Boolean
CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester.getSendWebRequest = nil

---@property readonly CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester.error : CS.System.String
CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester.error = nil

---@param sequence : CS.System.Int32
---@return CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester
function CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester(sequence)
end

---@return CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester
function CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester.Get()
end

---@param name : CS.System.String
---@param url : CS.System.String
---@param noCache : CS.System.Boolean
function CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester:Init(name, url, noCache)
end

---@return CS.System.Boolean
function CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester:IsDone()
end

function CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester:Start()
end

---@return CS.System.Single
function CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester:Progress()
end

function CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester:Update()
end

function CS.Framework.AssetBundle.AsyncOperation.ResourceWebRequester:Dispose()
end