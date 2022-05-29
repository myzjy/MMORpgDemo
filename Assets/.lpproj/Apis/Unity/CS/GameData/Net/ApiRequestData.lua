---@class CS.GameData.Net.ApiRequestData : CS.System.Object
CS.GameData.Net.ApiRequestData = {}

---@property readwrite CS.GameData.Net.ApiRequestData.WebRequest : CS.UnityEngine.Networking.UnityWebRequest
CS.GameData.Net.ApiRequestData.WebRequest = nil

---@param _uri : CS.System.Uri
---@param method : CS.System.String
---@param timeOut : CS.System.Int32
---@return CS.GameData.Net.ApiRequestData
function CS.GameData.Net.ApiRequestData(_uri, method, timeOut)
end

---@param _uri : CS.System.Uri
---@param method : CS.System.String
---@param timeOut : CS.System.Int32
---@param post : CS.System.Byte[]
---@return CS.GameData.Net.ApiRequestData
function CS.GameData.Net.ApiRequestData(_uri, method, timeOut, post)
end

---@param key : CS.System.String
---@param value : CS.System.String
function CS.GameData.Net.ApiRequestData:AddHeader(key, value)
end

---@return CS.System.Collections.Generic.Dictionary
function CS.GameData.Net.ApiRequestData:GetHeader()
end

---@param body : CS.System.Byte[]
function CS.GameData.Net.ApiRequestData:SetBody(body)
end