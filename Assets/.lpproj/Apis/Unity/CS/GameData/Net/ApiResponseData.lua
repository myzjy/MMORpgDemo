---@class CS.GameData.Net.ApiResponseData : CS.System.Object
CS.GameData.Net.ApiResponseData = {}

---@property readwrite CS.GameData.Net.ApiResponseData.IsDone : CS.System.Boolean
CS.GameData.Net.ApiResponseData.IsDone = nil

---@property readwrite CS.GameData.Net.ApiResponseData.ErrorStrMessage : CS.System.String
CS.GameData.Net.ApiResponseData.ErrorStrMessage = nil

---@property readwrite CS.GameData.Net.ApiResponseData.IsError : CS.System.Boolean
CS.GameData.Net.ApiResponseData.IsError = nil

---@property readwrite CS.GameData.Net.ApiResponseData.Code : CS.System.Int64
CS.GameData.Net.ApiResponseData.Code = nil

---@property readwrite CS.GameData.Net.ApiResponseData.RawData : CS.System.Byte[]
CS.GameData.Net.ApiResponseData.RawData = nil

---@property readwrite CS.GameData.Net.ApiResponseData.Headers : CS.System.Collections.Generic.Dictionary
CS.GameData.Net.ApiResponseData.Headers = nil

---@param request : CS.UnityEngine.Networking.UnityWebRequest
---@return CS.GameData.Net.ApiResponseData
function CS.GameData.Net.ApiResponseData(request)
end