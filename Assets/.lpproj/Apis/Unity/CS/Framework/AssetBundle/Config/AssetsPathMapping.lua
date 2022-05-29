---@class CS.Framework.AssetBundle.Config.AssetsPathMapping : CS.System.Object
CS.Framework.AssetBundle.Config.AssetsPathMapping = {}

---@property readwrite CS.Framework.AssetBundle.Config.AssetsPathMapping.AssetbundleName : CS.System.String
CS.Framework.AssetBundle.Config.AssetsPathMapping.AssetbundleName = nil

---@property readwrite CS.Framework.AssetBundle.Config.AssetsPathMapping.AssetName : CS.System.String
CS.Framework.AssetBundle.Config.AssetsPathMapping.AssetName = nil

---@return CS.Framework.AssetBundle.Config.AssetsPathMapping
function CS.Framework.AssetBundle.Config.AssetsPathMapping()
end

---@param content : CS.System.String
function CS.Framework.AssetBundle.Config.AssetsPathMapping:Initialize(content)
end

---@param assetPath : CS.System.String
---@param assetbundleName : CS.System.String
---@param assetName : CS.System.String
---@return CS.System.Boolean
function CS.Framework.AssetBundle.Config.AssetsPathMapping:MapAssetPath(assetPath, assetbundleName, assetName)
end

---@param assetbundleName : CS.System.String
---@return CS.System.Collections.Generic.List
function CS.Framework.AssetBundle.Config.AssetsPathMapping:GetAllAssetNames(assetbundleName)
end

---@param assetName : CS.System.String
---@return CS.System.String
function CS.Framework.AssetBundle.Config.AssetsPathMapping:GetAssetBundleName(assetName)
end