---@module CS.Common.GameChannel
CS.Common.GameChannel = {}

---@class CS.Common.GameChannel.BaseChannel : CS.System.Object
CS.Common.GameChannel.BaseChannel = {}

function CS.Common.GameChannel.BaseChannel:Init()
end

---@param paramList : CS.System.Object[]
function CS.Common.GameChannel.BaseChannel:DownloadGame(paramList)
end

---@return CS.System.Boolean
function CS.Common.GameChannel.BaseChannel:IsGooglePlay()
end

---@return CS.System.String
function CS.Common.GameChannel.BaseChannel:GetBundleID()
end

function CS.Common.GameChannel.BaseChannel:InstallApk()
end

---@return CS.System.String
function CS.Common.GameChannel.BaseChannel:GetProductName()
end

function CS.Common.GameChannel.BaseChannel:DataTrackInit()
end

---@return CS.System.String
function CS.Common.GameChannel.BaseChannel:GetCompanyName()
end

---@return CS.System.Boolean
function CS.Common.GameChannel.BaseChannel:IsInternalChannel()
end

function CS.Common.GameChannel.BaseChannel:Login()
end

function CS.Common.GameChannel.BaseChannel:Logout()
end

---@param paramList : CS.System.Object[]
function CS.Common.GameChannel.BaseChannel:Pay(paramList)
end