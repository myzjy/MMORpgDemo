---@class CS.XluaManager : CS.GameTools.Singletons.MMOSingletonDontDestroy
CS.XluaManager = {}

---@field public CS.XluaManager.luaScriptsFolder : CS.System.String
CS.XluaManager.luaScriptsFolder = nil

---@field public CS.XluaManager.luaAssetbundleAssetName : CS.System.String
CS.XluaManager.luaAssetbundleAssetName = nil

---@property readwrite CS.XluaManager.AssetbundleName : CS.System.String
CS.XluaManager.AssetbundleName = nil

---@return CS.XluaManager
function CS.XluaManager()
end

function CS.XluaManager:OnAwake()
end

---@param filepath : CS.System.String
---@return CS.System.Byte[]
function CS.XluaManager.CustomLoader(filepath)
end

function CS.XluaManager:ReStart()
end

---@param scriptContent : CS.System.String
function CS.XluaManager:SafeDoString(scriptContent)
end

function CS.XluaManager:Disable()
end