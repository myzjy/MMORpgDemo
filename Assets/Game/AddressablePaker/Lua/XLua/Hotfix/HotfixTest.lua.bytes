---------------------------------------------------------------------
-- MMORpgDemo (C) CompanyName, All Rights Reserved
-- Created by: AuthorName
-- Date: 2022-05-27 01:57:00
---------------------------------------------------------------------

-- To edit this template in: Data/Config/Template.lua
-- To disable this template, check off menuitem: Options-Enable Template File
local util=require "XLua.Common.util"
local AssetbundleUpdater = CS.AssetBundleUpdater
local AssetBundleManager = CS.Script.Framework.AssetBundle.AssetBundleManager

xlua.private_accessible(AssetbundleUpdater)
xlua.private_accessible(AssetBundleManager)

local function AssetbundleUpdaterTestHotfix(self)
	print("********** AssetbundleUpdater : Call TestHotfix in lua...<<<")
end

local function AssetBundleManagerTestHotfix(self)
	print("********** AssetBundleManager : Call TestHotfix in lua...<<<")
	AssetBundleManager.Instance:TestHotfix()
end

local function Register()
	xlua.hotfix(AssetbundleUpdater, "TestHotfix", AssetbundleUpdaterTestHotfix)
	util.hotfix_ex(AssetBundleManager, "TestHotfix", AssetBundleManagerTestHotfix)
end

local function Unregister()
	xlua.hotfix(AssetbundleUpdater, "TestHotfix", nil)
	xlua.hotfix(AssetBundleManager, "TestHotfix", nil)
end

return {
	Register=Register,
	Unregister=Unregister
}
