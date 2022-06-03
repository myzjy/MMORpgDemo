---------------------------------------------------------------------
-- MMORpgDemo (C) CompanyName, All Rights Reserved
-- Created by: AuthorName
-- Date: 2022-05-31 20:38:16
---------------------------------------------------------------------

-- To edit this template in: Data/Config/Template.lua
-- To disable this template, check off menuitem: Options-Enable Template File
local util=require "XLua.Common.util"
local UIRoot=require "UI.UIRoot.UIRoot"

local UIRootH = CS.UIRoot
---@class Hotfix
UIRootHotfix = {}

xlua.private_accessible(UIRootH)
local function Register()
	xlua.hotfix(UIRootH, "Awake", UIRoot.Awake)
end

local function Unregister()
	xlua.hotfix(UIRootH, "Awake", nil)
end

return {
	Register=Register,
	Unregister=Unregister
}