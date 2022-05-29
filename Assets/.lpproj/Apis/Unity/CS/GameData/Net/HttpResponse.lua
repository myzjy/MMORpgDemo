---@module CS.GameData.Net
CS.GameData.Net = {}

---@class CS.GameData.Net.HttpResponse : CS.System.Object
CS.GameData.Net.HttpResponse = {}

---@property readonly CS.GameData.Net.HttpResponse.RawData : CS.System.Byte[]
CS.GameData.Net.HttpResponse.RawData = nil

---@property readonly CS.GameData.Net.HttpResponse.StatusCode : CS.System.Int32
CS.GameData.Net.HttpResponse.StatusCode = nil

---@property readonly CS.GameData.Net.HttpResponse.DataAssetText : CS.System.String
CS.GameData.Net.HttpResponse.DataAssetText = nil

---@param _api : CS.GameData.Net.ApiResponseData
---@return CS.GameData.Net.HttpResponse
function CS.GameData.Net.HttpResponse.Create(_api)
end

---@param name : CS.System.String
---@return CS.System.String
function CS.GameData.Net.HttpResponse:FindFirstHeaderValue(name)
end