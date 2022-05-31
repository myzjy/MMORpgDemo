---------------------------------------------------------------------
-- MMORpgDemo (C) CompanyName, All Rights Reserved
-- Created by: AuthorName
-- Date: 2022-05-27 01:38:25
---------------------------------------------------------------------

-- To edit this template in: Data/Config/Template.lua
-- To disable this template, check off menuitem: Options-Enable Template File

-- [[
-- 热修复模块
-- ]]

HotfixMain={}

local modules={
	"XLua.Hotfix.HotfixTest"
} 
print("加载")
local function Start()
	print("HotfixMain Start")
	for _,v in ipairs(modules) do
		local hotfixMainModules=require(v)
		hotfixMainModules.Register()
	end
end

local function Stop()
	print("HotfixMain Stop")
	for _,v in ipairs(modules) do
		local hotfixMainModules=require(v)
		hotfixMainModules.Unregister()
	end
end

HotfixMain.modules=modules
HotfixMain.Start=Start
HotfixMain.Stop=Stop

return HotfixMain