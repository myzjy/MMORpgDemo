---@class CS.Model : CS.System.Object
CS.Model = {}

---@param isPretty : CS.System.Boolean
---@return CS.System.String
function CS.Model:ToJson(isPretty)
end

---@return CS.System.String
function CS.Model:ToString()
end

---@param bytes : CS.System.Byte[]
function CS.Model:Unpack(bytes)
end

---@return CS.System.Byte[]
function CS.Model:Pack()
end

---@return CS.System.String
function CS.Model:BuildQuery()
end