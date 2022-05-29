---@class CS.Framework.AssetBundle.AsyncOperation.ResourceAsyncOperation : CS.System.Object
CS.Framework.AssetBundle.AsyncOperation.ResourceAsyncOperation = {}

---@property readonly CS.Framework.AssetBundle.AsyncOperation.ResourceAsyncOperation.Current : CS.System.Object
CS.Framework.AssetBundle.AsyncOperation.ResourceAsyncOperation.Current = nil

---@property readonly CS.Framework.AssetBundle.AsyncOperation.ResourceAsyncOperation.isDone : CS.System.Boolean
CS.Framework.AssetBundle.AsyncOperation.ResourceAsyncOperation.isDone = nil

---@property readonly CS.Framework.AssetBundle.AsyncOperation.ResourceAsyncOperation.progress : CS.System.Single
CS.Framework.AssetBundle.AsyncOperation.ResourceAsyncOperation.progress = nil

function CS.Framework.AssetBundle.AsyncOperation.ResourceAsyncOperation:Update()
end

---@return CS.System.Boolean
function CS.Framework.AssetBundle.AsyncOperation.ResourceAsyncOperation:MoveNext()
end

function CS.Framework.AssetBundle.AsyncOperation.ResourceAsyncOperation:Reset()
end

---@return CS.System.Boolean
function CS.Framework.AssetBundle.AsyncOperation.ResourceAsyncOperation:IsDone()
end

---@return CS.System.Single
function CS.Framework.AssetBundle.AsyncOperation.ResourceAsyncOperation:Progress()
end

function CS.Framework.AssetBundle.AsyncOperation.ResourceAsyncOperation:Dispose()
end