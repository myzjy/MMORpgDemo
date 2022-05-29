---@class CS.Common.Http.SimpleHttp : CS.GameTools.Singletons.MMOSingletonDontDestroy
CS.Common.Http.SimpleHttp = {}

---@return CS.Common.Http.SimpleHttp
function CS.Common.Http.SimpleHttp()
end

function CS.Common.Http.SimpleHttp:OnAwake()
end

---@param url : CS.System.String
---@param formData : CS.System.Collections.Generic.Dictionary
---@param byteData : CS.System.Byte[]
---@param callback : CS.System.Action
---@param timeOut : CS.System.Int32
function CS.Common.Http.SimpleHttp.HttpPost(url, formData, byteData, callback, timeOut)
end

---@param info : CS.Common.Http.HttpInfo
function CS.Common.Http.SimpleHttp:StartHttp(info)
end