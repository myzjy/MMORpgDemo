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
list _list;
local function __init()
	_list.New()
	_list:push()

end


--注册消息
local function registerModule()
	-- body
	for k,v in pairs(modules) do
		for ks,vs in pairs(v.Notification) do
			print(k,v)
		end
	end
end
