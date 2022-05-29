---@module CS.GameSystem.ServiceDataPro
CS.GameSystem.ServiceDataPro = {}

---@class CS.GameSystem.ServiceDataPro.BaseServiceData : CS.System.Object
CS.GameSystem.ServiceDataPro.BaseServiceData = {}

---@return CS.GameSystem.ServiceDataPro.BaseServiceData
function CS.GameSystem.ServiceDataPro.BaseServiceData()
end

---@param serviceLoad : CS.GameData.Net.ServiceLoad
function CS.GameSystem.ServiceDataPro.BaseServiceData:SetServiceLoad(serviceLoad)
end

---@param urlName : CS.System.String
---@param formData : CS.System.Collections.Generic.Dictionary
---@param byteData : CS.System.Byte[]
---@param call : CS.System.Action
---@param timsout : CS.System.Int32
function CS.GameSystem.ServiceDataPro.BaseServiceData:RequestSeverPost(urlName, formData, byteData, call, timsout)
end