---------------------------------------------------------------------
-- MMORpgDemo (C) CompanyName, All Rights Reserved
-- Created by: AuthorName
-- Date: 2022-05-31 20:38:16
---------------------------------------------------------------------

-- To edit this template in: Data/Config/Template.lua
-- To disable this template, check off menuitem: Options-Enable Template File

local UIRootH = CS.UIRoot
---@class Hotfix
UIRootHotfix = {}

function Awake()
	print("UIRoot .....")
end
xlua.hotfix(UIRootH, "Awake", Awake)