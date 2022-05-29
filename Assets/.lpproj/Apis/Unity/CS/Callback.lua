---@class CS.Callback : CS.System.MulticastDelegate
CS.Callback = {}

---@param object : CS.System.Object
---@param method : CS.System.IntPtr
---@return CS.Callback
function CS.Callback(object, method)
end

function CS.Callback:Invoke()
end

---@param callback : CS.System.AsyncCallback
---@param object : CS.System.Object
---@return CS.System.IAsyncResult
function CS.Callback:BeginInvoke(callback, object)
end

---@param result : CS.System.IAsyncResult
function CS.Callback:EndInvoke(result)
end