---@class CS.Common.GameChannel.ChannelManager : CS.GameTools.Singletons.MMOSingleton
CS.Common.GameChannel.ChannelManager = {}

---@property readwrite CS.Common.GameChannel.ChannelManager.channelName : CS.System.String
CS.Common.GameChannel.ChannelManager.channelName = nil

---@property readwrite CS.Common.GameChannel.ChannelManager.noticeVersion : CS.System.String
CS.Common.GameChannel.ChannelManager.noticeVersion = nil

---@property readwrite CS.Common.GameChannel.ChannelManager.resVersion : CS.System.String
CS.Common.GameChannel.ChannelManager.resVersion = nil

---@property readwrite CS.Common.GameChannel.ChannelManager.appVersion : CS.System.String
CS.Common.GameChannel.ChannelManager.appVersion = nil

---@property readwrite CS.Common.GameChannel.ChannelManager.svnVersion : CS.System.String
CS.Common.GameChannel.ChannelManager.svnVersion = nil

---@return CS.Common.GameChannel.ChannelManager
function CS.Common.GameChannel.ChannelManager()
end

---@param channelName : CS.System.String
function CS.Common.GameChannel.ChannelManager:Init(channelName)
end

---@return CS.System.Boolean
function CS.Common.GameChannel.ChannelManager:IsInternalVersion()
end

---@param channelName : CS.System.String
---@return CS.Common.GameChannel.BaseChannel
function CS.Common.GameChannel.ChannelManager:CreateChannel(channelName)
end

---@param url : CS.System.String
---@param succeed : CS.System.Action
---@param fail : CS.System.Action
---@param progress : CS.System.Action
---@param saveName : CS.System.String
function CS.Common.GameChannel.ChannelManager:StartDownloadGame(url, succeed, fail, progress, saveName)
end

---@return CS.System.String
function CS.Common.GameChannel.ChannelManager:GetProductName()
end

---@param succeed : CS.System.Action
---@param fail : CS.System.Action
function CS.Common.GameChannel.ChannelManager:InstallGame(succeed, fail)
end