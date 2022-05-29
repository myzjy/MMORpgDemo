---@module CS.Common.Http
CS.Common.Http = {}

---@class CS.Common.Http.HttpInfo : CS.System.Object
CS.Common.Http.HttpInfo = {}

---@field public CS.Common.Http.HttpInfo.url : CS.System.String
CS.Common.Http.HttpInfo.url = nil

---@field public CS.Common.Http.HttpInfo.type : CS.Common.Http.HTTP_TYPE
CS.Common.Http.HttpInfo.type = nil

---@field public CS.Common.Http.HttpInfo.formData : CS.System.Collections.Generic.Dictionary
CS.Common.Http.HttpInfo.formData = nil

---@field public CS.Common.Http.HttpInfo.byteData : CS.System.Byte[]
CS.Common.Http.HttpInfo.byteData = nil

---@field public CS.Common.Http.HttpInfo.timeOut : CS.System.Single
CS.Common.Http.HttpInfo.timeOut = nil

---@field public CS.Common.Http.HttpInfo.callbackDel : CS.System.Action
CS.Common.Http.HttpInfo.callbackDel = nil

---@return CS.Common.Http.HttpInfo
function CS.Common.Http.HttpInfo()
end