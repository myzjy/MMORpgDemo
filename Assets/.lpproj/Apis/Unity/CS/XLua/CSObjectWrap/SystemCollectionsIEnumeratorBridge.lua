---@class CS.XLua.CSObjectWrap.SystemCollectionsIEnumeratorBridge : CS.XLua.LuaBase
CS.XLua.CSObjectWrap.SystemCollectionsIEnumeratorBridge = {}

---@property readonly CS.XLua.CSObjectWrap.SystemCollectionsIEnumeratorBridge.Current : CS.System.Object
CS.XLua.CSObjectWrap.SystemCollectionsIEnumeratorBridge.Current = nil

---@param reference : CS.System.Int32
---@param luaenv : CS.XLua.LuaEnv
---@return CS.XLua.CSObjectWrap.SystemCollectionsIEnumeratorBridge
function CS.XLua.CSObjectWrap.SystemCollectionsIEnumeratorBridge(reference, luaenv)
end

---@param reference : CS.System.Int32
---@param luaenv : CS.XLua.LuaEnv
---@return CS.XLua.LuaBase
function CS.XLua.CSObjectWrap.SystemCollectionsIEnumeratorBridge.__Create(reference, luaenv)
end

---@return CS.System.Boolean
function CS.XLua.CSObjectWrap.SystemCollectionsIEnumeratorBridge:MoveNext()
end

function CS.XLua.CSObjectWrap.SystemCollectionsIEnumeratorBridge:Reset()
end