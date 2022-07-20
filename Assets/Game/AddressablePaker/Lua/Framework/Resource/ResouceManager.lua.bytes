--[[
-- Resouce管理类 调用生成从这里调用
--]]

-- 注入单例模式
local ResourcesManager=BaseClass("ResourcesManager",Singleton)

local AssetBundleManager = CS.Script.Framework.AssetBundle.AssetBundleManager
local AssetBundleUtility = CS.Framework.AssetBundles.Utilty.AssetBundleUtility

-- 是否有加载
local function IsProsessRuning(self)
	return AssetBundleManager.IsProsessRunning
end

--异步加载
local function LoadAssetBundleAsync(self,path,callback,...)
	assert(path~=nil and type(path)=="string" and #path>0,"Path string err"..path)
	assert(callback~=nil and type(callback)=="function","Need to function as callback")
	local args=SafePack(...)
	coroutine.start(function()
		-- 起协程
		local assetbundle=self:CoLoadAssetBundleAsync(path,nil)
			callback(SafeUnpack(args))
	end)
end


-- 异步加载采用协程
local function CoLoadAssetBundleAsync(self,path,progress_callback)
 	-- body
 	assert(path~=nil and type(path)=="string" and #path>0,"Path string err"..path)
	-- 资源物体AB名
 	local assetbundleName=AssetBundleUtility.AssetbundlePathToAssetBundleName
	-- 读取到ab资源
 	local assetLoader=AssetBundleManager:LoadAssetBundleAsync(assetbundleName)
	--等待读取到资源
	coroutine.waitforasyncop(assetLoader,progress_callback)
	-- 卸载
	assetLoader:Dispose()
end

-- 异步加载 asset
local function LoadAssetAsync()
	assert(path ~= nil and type(path) == "string" and #path > 0, "path err : "..path)
	assert(callback ~= nil and type(callback) == "function", "Need to provide a function as callback")
	local args = SafePack(nil, ...)
	coroutine.start(function()
			local asset = self:CoLoadAsync(path, res_type, nil)
			args[1] = asset
			callback(SafeUnpack(args))
		end)
end
-- 异步加载Asset：协程形式
local function CoLoadAsync(self, path, res_type, progress_callback)
	assert(path ~= nil and type(path) == "string" and #path > 0, "path err : "..path)
	local loader = AssetBundleManager:LoadAssetAsync(path, res_type)
	coroutine.waitforasyncop(loader, progress_callback)
	local asset = loader.asset
	loader:Dispose()
	if IsNull(asset) then
		Logger.LogError("Asset load err : "..path)
	end
	return asset
end

-- 清理资源：切换场景时调用
local function Cleanup(self)
	AssetBundleManager:ClearAssetsCache()
	AssetBundleManager:UnloadAllUnusedResidentAssetBundles()

	-- TODO：Lua脚本要重新加载，暂时吧，后面缓缓策略
	local luaAssetbundleName = CS.XLuaManager.Instance.AssetbundleName
	AssetBundleManager:AddAssetbundleAssetsCache(luaAssetbundleName)
end

ResourcesManager.IsProsessRunning = IsProsessRunning
ResourcesManager.SetAssetBundleResident = SetAssetBundleResident
ResourcesManager.LoadAssetBundleAsync = LoadAssetBundleAsync
ResourcesManager.CoLoadAssetBundleAsync = CoLoadAssetBundleAsync
ResourcesManager.LoadAsync = LoadAsync
ResourcesManager.CoLoadAsync = CoLoadAsync
ResourcesManager.Cleanup = Cleanup

return ResourcesManager