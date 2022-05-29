---@module CS.AssetBundles.Config
CS.AssetBundles.Config = {}

---@class CS.AssetBundles.Config.Manifest : CS.System.Object
CS.AssetBundles.Config.Manifest = {}

---@property readonly CS.AssetBundles.Config.Manifest.assetbundleManifest : CS.UnityEngine.AssetBundleManifest
CS.AssetBundles.Config.Manifest.assetbundleManifest = nil

---@property readwrite CS.AssetBundles.Config.Manifest.AssetbundleName : CS.System.String
CS.AssetBundles.Config.Manifest.AssetbundleName = nil

---@property readonly CS.AssetBundles.Config.Manifest.Length : CS.System.Int32
CS.AssetBundles.Config.Manifest.Length = nil

---@return CS.AssetBundles.Config.Manifest
function CS.AssetBundles.Config.Manifest()
end

---@param assetBundle : CS.UnityEngine.AssetBundle
function CS.AssetBundles.Config.Manifest:LoadFromAssetBundle(assetBundle)
end

---@param bytes : CS.System.Byte[]
function CS.AssetBundles.Config.Manifest:SaveBytes(bytes)
end

function CS.AssetBundles.Config.Manifest:SaveToDiskCahce()
end

---@param name : CS.System.String
---@return CS.UnityEngine.Hash128
function CS.AssetBundles.Config.Manifest:GetAssetBundleHash(name)
end

---@return CS.System.String[]
function CS.AssetBundles.Config.Manifest:GetAllAssetBundleNames()
end

---@return CS.System.String[]
function CS.AssetBundles.Config.Manifest:GetAllAssetBundlesWithVariant()
end

---@param assetbundleName : CS.System.String
---@return CS.System.String[]
function CS.AssetBundles.Config.Manifest:GetAllDependencies(assetbundleName)
end

---@param assetbundleName : CS.System.String
---@return CS.System.String[]
function CS.AssetBundles.Config.Manifest:GetDirectDependencies(assetbundleName)
end

---@param otherManifest : CS.AssetBundles.Config.Manifest
---@return CS.System.Collections.Generic.List
function CS.AssetBundles.Config.Manifest:CompareTo(otherManifest)
end