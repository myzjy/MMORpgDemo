---------------------------------------------------------------------
-- MMORpgDemo (C) CompanyName, All Rights Reserved
-- Created by: AuthorName
-- Date: 2022-06-04 23:29:30
---------------------------------------------------------------------

-- To edit this template in: Data/Config/Template.lua
-- To disable this template, check off menuitem: Options-Enable Template File
--[[
-- UI控制器，由uimanager管理器调度
--]]


require "Common.Tools.list"
---@class UIModuleController
local UIModuleController = {}

-- 控制器合集
local modules={}
local function __init()
	local index=1
	modules[index]=nil
	index=index+1
	modules[index]=nil

end


--注册消息
local function registerModule()
	-- body
	for i,v in ipairs(modules) do
		print(i,v)
	end
end