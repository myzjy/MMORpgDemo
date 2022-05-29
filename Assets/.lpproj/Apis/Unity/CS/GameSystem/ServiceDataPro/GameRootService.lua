---@class CS.GameSystem.ServiceDataPro.GameRootService : CS.System.Object
CS.GameSystem.ServiceDataPro.GameRootService = {}

---@property readonly CS.GameSystem.ServiceDataPro.GameRootService.ServicePro : CS.GameSystem.ServiceDataPro.GameRootServicePro
CS.GameSystem.ServiceDataPro.GameRootService.ServicePro = nil

---@return CS.GameSystem.ServiceDataPro.GameRootService
function CS.GameSystem.ServiceDataPro.GameRootService.CreateRoot()
end

---@param formData : CS.System.Collections.Generic.Dictionary
---@param byteData : CS.System.Byte[]
---@param call : CS.System.Action
---@param timeOUt : CS.System.Int32
function CS.GameSystem.ServiceDataPro.GameRootService:HttpsPost(formData, byteData, call, timeOUt)
end