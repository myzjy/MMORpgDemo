---@module CS.Framework.AssetBundle.AsyncOperation
CS.Framework.AssetBundle.AsyncOperation = {}

---@class CS.Framework.AssetBundle.AsyncOperation.AssetAsyncLoader : CS.Framework.AssetBundle.AsyncOperation.BaseAssetAsyncLoader
CS.Framework.AssetBundle.AsyncOperation.AssetAsyncLoader = {}

---@property readwrite CS.Framework.AssetBundle.AsyncOperation.AssetAsyncLoader.Sequence : CS.System.Int32
CS.Framework.AssetBundle.AsyncOperation.AssetAsyncLoader.Sequence = nil

---@property readwrite CS.Framework.AssetBundle.AsyncOperation.AssetAsyncLoader.AssetName : CS.System.String
CS.Framework.AssetBundle.AsyncOperation.AssetAsyncLoader.AssetName = nil

---@param sequence : CS.System.Int32
---@return CS.Framework.AssetBundle.AsyncOperation.AssetAsyncLoader
function CS.Framework.AssetBundle.AsyncOperation.AssetAsyncLoader(sequence)
end

---@return CS.Framework.AssetBundle.AsyncOperation.AssetAsyncLoader
function CS.Framework.AssetBundle.AsyncOperation.AssetAsyncLoader.Get()
end

---@param creater : CS.Framework.AssetBundle.AsyncOperation.AssetAsyncLoader
function CS.Framework.AssetBundle.AsyncOperation.AssetAsyncLoader.Recycle(creater)
end

---@param assetName : CS.System.String
---@param asset : CS.UnityEngine.Object
function CS.Framework.AssetBundle.AsyncOperation.AssetAsyncLoader:Init(assetName, asset)
end

---@param assetName : CS.System.String
---@param loader : CS.Framework.AssetBundle.AsyncOperation.BaseAssetBundleAsyncLoader
function CS.Framework.AssetBundle.AsyncOperation.AssetAsyncLoader:Init(assetName, loader)
end

---@return CS.System.Boolean
function CS.Framework.AssetBundle.AsyncOperation.AssetAsyncLoader:IsDone()
end

---@return CS.System.Single
function CS.Framework.AssetBundle.AsyncOperation.AssetAsyncLoader:Progress()
end

function CS.Framework.AssetBundle.AsyncOperation.AssetAsyncLoader:Update()
end

function CS.Framework.AssetBundle.AsyncOperation.AssetAsyncLoader:Dispose()
end