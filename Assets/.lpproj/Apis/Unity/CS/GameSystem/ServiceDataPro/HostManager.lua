---@class CS.GameSystem.ServiceDataPro.HostManager : CS.System.Object
CS.GameSystem.ServiceDataPro.HostManager = {}

---@property readwrite CS.GameSystem.ServiceDataPro.HostManager.baseUri : CS.System.Uri
CS.GameSystem.ServiceDataPro.HostManager.baseUri = nil

---@property readonly CS.GameSystem.ServiceDataPro.HostManager.Instance : CS.GameSystem.ServiceDataPro.HostManager
CS.GameSystem.ServiceDataPro.HostManager.Instance = nil

---@param host : CS.System.String
---@param port : CS.System.Int32
function CS.GameSystem.ServiceDataPro.HostManager:SetURLs(host, port)
end

---@param urlString : CS.System.String
function CS.GameSystem.ServiceDataPro.HostManager:SetURLs(urlString)
end

---@param relativePath : CS.System.String
---@return CS.System.Uri
function CS.GameSystem.ServiceDataPro.HostManager:GetUri(relativePath)
end