---@class CS.Framework.AssetBundle.AsyncOperation.AssetBundleAsyncLoader : CS.Framework.AssetBundle.AsyncOperation.BaseAssetBundleAsyncLoader
CS.Framework.AssetBundle.AsyncOperation.AssetBundleAsyncLoader = {}

---@property readwrite CS.Framework.AssetBundle.AsyncOperation.AssetBundleAsyncLoader.Sequence : CS.System.Int32
CS.Framework.AssetBundle.AsyncOperation.AssetBundleAsyncLoader.Sequence = nil

---@param sequence : CS.System.Int32
---@return CS.Framework.AssetBundle.AsyncOperation.AssetBundleAsyncLoader
function CS.Framework.AssetBundle.AsyncOperation.AssetBundleAsyncLoader(sequence)
end

---@return CS.Framework.AssetBundle.AsyncOperation.AssetBundleAsyncLoader
function CS.Framework.AssetBundle.AsyncOperation.AssetBundleAsyncLoader.Get()
end

---@param loader : CS.Framework.AssetBundle.AsyncOperation.AssetBundleAsyncLoader
function CS.Framework.AssetBundle.AsyncOperation.AssetBundleAsyncLoader.Recycle(loader)
end

---@param name : CS.System.String
---@param dependances : CS.System.String[]
function CS.Framework.AssetBundle.AsyncOperation.AssetBundleAsyncLoader:Init(name, dependances)
end

---@return CS.System.Boolean
function CS.Framework.AssetBundle.AsyncOperation.AssetBundleAsyncLoader:IsDone()
end

---@return CS.System.Single
function CS.Framework.AssetBundle.AsyncOperation.AssetBundleAsyncLoader:Progress()
end

function CS.Framework.AssetBundle.AsyncOperation.AssetBundleAsyncLoader:Update()
end

function CS.Framework.AssetBundle.AsyncOperation.AssetBundleAsyncLoader:Dispose()
end