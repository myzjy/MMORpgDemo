---@class CS.XluaManager : CS.GameTools.Singletons.MMOSingletonDontDestroy
CS.XluaManager = {}

---@field public CS.XluaManager.luaScriptsFolder : CS.System.String
CS.XluaManager.luaScriptsFolder = nil

---@field public CS.XluaManager.luaAssetbundleAssetName : CS.System.String
CS.XluaManager.luaAssetbundleAssetName = nil

---@property readwrite CS.XluaManager.AssetbundleName : CS.System.String
CS.XluaManager.AssetbundleName = nil

---@property readwrite CS.XluaManager.HasGameStart : CS.System.Boolean
CS.XluaManager.HasGameStart = nil

---@return CS.XluaManager
function CS.XluaManager()
end

function CS.XluaManager:Startup()
end

function CS.XluaManager:OnAwake()
end

function CS.XluaManager:StartGame()
end

---@param filepath : CS.System.String
---@return CS.System.Byte[]
function CS.XluaManager.CustomLoader(filepath)
end

function CS.XluaManager:OnInit()
end

function CS.XluaManager:ReStart()
end

---@param scriptContent : CS.System.String
---@param chunkName : CS.System.String
function CS.XluaManager:SafeDoString(scriptContent, chunkName)
end

---@param restart : CS.System.Boolean
function CS.XluaManager:StartHotfix(restart)
end

---@param scriptName : CS.System.String
function CS.XluaManager:ReloadScript(scriptName)
end

---@param scriptName : CS.System.String
function CS.XluaManager:LoadScript(scriptName)
end

function CS.XluaManager:Disable()
end

function CS.XluaManager:Restart()
end

function CS.XluaManager:Dispose()
end