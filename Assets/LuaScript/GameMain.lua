---------------------------------------------------------------------
-- MMORpgDemo (C) CompanyName, All Rights Reserved
-- Created by: AuthorName
-- Date: 2022-05-24 12:24:14
---------------------------------------------------------------------

-- To edit this template in: Data/Config/Template.lua
-- To disable this template, check off menuitem: Options-Enable Template File


require "Common.Common"
---@class GameMain
GameMain = {};
print("GameMin ing ....")
local function OnInit()
	print("初始化所有")
   
end

local function Start()
	print("初始化所有 start")
end
GameMain.OnInit=OnInit
GameMain.Start=Start

return GameMain