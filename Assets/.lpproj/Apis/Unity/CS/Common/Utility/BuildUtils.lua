---@module CS.Common.Utility
CS.Common.Utility = {}

---@class CS.Common.Utility.BuildUtils : CS.System.Object
CS.Common.Utility.BuildUtils = {}

---@field public CS.Common.Utility.BuildUtils.ManifestBundleName : CS.System.String
CS.Common.Utility.BuildUtils.ManifestBundleName = nil

---@field public CS.Common.Utility.BuildUtils.ChannelNameFileName : CS.System.String
CS.Common.Utility.BuildUtils.ChannelNameFileName = nil

---@field public CS.Common.Utility.BuildUtils.AppVersionFileName : CS.System.String
CS.Common.Utility.BuildUtils.AppVersionFileName = nil

---@field public CS.Common.Utility.BuildUtils.ResVersionFileName : CS.System.String
CS.Common.Utility.BuildUtils.ResVersionFileName = nil

---@field public CS.Common.Utility.BuildUtils.NoticeVersionFileName : CS.System.String
CS.Common.Utility.BuildUtils.NoticeVersionFileName = nil

---@field public CS.Common.Utility.BuildUtils.AssetBundlesSizeFileName : CS.System.String
CS.Common.Utility.BuildUtils.AssetBundlesSizeFileName = nil

---@field public CS.Common.Utility.BuildUtils.UpdateNoticeFileName : CS.System.String
CS.Common.Utility.BuildUtils.UpdateNoticeFileName = nil

---@return CS.Common.Utility.BuildUtils
function CS.Common.Utility.BuildUtils()
end

---@param sourceVersion : CS.System.String
---@param targetVersion : CS.System.String
---@return CS.System.Boolean
function CS.Common.Utility.BuildUtils.CheckIsNewVersion(sourceVersion, targetVersion)
end