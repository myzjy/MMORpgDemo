---@class CS.GameData.Net.ServericeBase : CS.System.Object
CS.GameData.Net.ServericeBase = {}

---@field public CS.GameData.Net.ServericeBase._playdict : CS.System.Collections.Generic.Dictionary
CS.GameData.Net.ServericeBase._playdict = nil

---@field public CS.GameData.Net.ServericeBase._querydict : CS.System.Collections.Generic.Dictionary
CS.GameData.Net.ServericeBase._querydict = nil

---@property readonly CS.GameData.Net.ServericeBase.Methods : CS.GameData.Net.HttpMethods
CS.GameData.Net.ServericeBase.Methods = nil

---@property readonly CS.GameData.Net.ServericeBase.NeedsRetry : CS.System.Boolean
CS.GameData.Net.ServericeBase.NeedsRetry = nil

---@param methods : CS.GameData.Net.HttpMethods
---@return CS.GameData.Net.ServericeBase
function CS.GameData.Net.ServericeBase(methods)
end

---@return CS.GameData.Net.ServericeBase
function CS.GameData.Net.ServericeBase.ServericeBaseGet()
end

---@return CS.GameData.Net.ServericeBase
function CS.GameData.Net.ServericeBase.ServericeBasePost()
end

---@param strV : CS.System.String
---@param value : CS.System.Object
function CS.GameData.Net.ServericeBase:AddPayload(strV, value)
end

---@param v : CS.System.Collections.Generic.Dictionary
function CS.GameData.Net.ServericeBase:SetPayload(v)
end

---@param request : CS.GameData.Net.RequestOperationBase
function CS.GameData.Net.ServericeBase:SetupRequestOperation(request)
end