---@class CS.GameData.Net.RequestOperationBase : CS.System.Object
CS.GameData.Net.RequestOperationBase = {}

---@property readwrite CS.GameData.Net.RequestOperationBase.RequestPath : CS.System.String
CS.GameData.Net.RequestOperationBase.RequestPath = nil

---@property readwrite CS.GameData.Net.RequestOperationBase.Payload : CS.System.Collections.Generic.Dictionary
CS.GameData.Net.RequestOperationBase.Payload = nil

---@property readwrite CS.GameData.Net.RequestOperationBase.QueryParam : CS.System.Collections.Generic.Dictionary
CS.GameData.Net.RequestOperationBase.QueryParam = nil

---@property readwrite CS.GameData.Net.RequestOperationBase.OptionalHeaders : CS.System.Collections.Generic.Dictionary
CS.GameData.Net.RequestOperationBase.OptionalHeaders = nil

---@property readwrite CS.GameData.Net.RequestOperationBase._SuccessCallBack : CS.System.Action
CS.GameData.Net.RequestOperationBase._SuccessCallBack = nil

---@property readwrite CS.GameData.Net.RequestOperationBase._FailureCallBack : CS.System.Action
CS.GameData.Net.RequestOperationBase._FailureCallBack = nil

---@property readwrite CS.GameData.Net.RequestOperationBase._ApiRequestData : CS.GameData.Net.ApiRequestData
CS.GameData.Net.RequestOperationBase._ApiRequestData = nil

---@property readwrite CS.GameData.Net.RequestOperationBase.NeedsToMiniJsonParser : CS.System.Boolean
CS.GameData.Net.RequestOperationBase.NeedsToMiniJsonParser = nil

---@property readwrite CS.GameData.Net.RequestOperationBase.PayloadStr : CS.System.String
CS.GameData.Net.RequestOperationBase.PayloadStr = nil

---@param methods : CS.GameData.Net.HttpMethods
---@param requestPath : CS.System.String
---@return CS.GameData.Net.RequestOperationBase
function CS.GameData.Net.RequestOperationBase(methods, requestPath)
end

function CS.GameData.Net.RequestOperationBase:Send()
end

---@param bytes : CS.System.Byte[]
---@param timeout : CS.System.Int32
function CS.GameData.Net.RequestOperationBase:Send(bytes, timeout)
end