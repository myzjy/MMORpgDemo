---@class CS.GameData.Net.ServiceLoad : CS.System.Object
CS.GameData.Net.ServiceLoad = {}

---@return CS.GameData.Net.ServiceLoad
function CS.GameData.Net.ServiceLoad()
end

---@param apiHost : CS.System.String
---@param portNo : CS.System.Int32
function CS.GameData.Net.ServiceLoad:SetURLs(apiHost, portNo)
end

---@param apiHost : CS.System.String
function CS.GameData.Net.ServiceLoad:SetURLs(apiHost)
end

---@param urlName : CS.System.String
---@param _SiBase : CS.GameData.Net.ServericeBase
---@param _succes : CS.System.Action
---@param finish : CS.System.Action
---@param isAbort : CS.System.Action
---@param bytes : CS.System.Byte[]
---@param timeOut : CS.System.Int32
function CS.GameData.Net.ServiceLoad:ServiceLoadJsonBgThread(urlName, _SiBase, _succes, finish, isAbort, bytes, timeOut)
end