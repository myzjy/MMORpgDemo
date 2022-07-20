---------------------------------------------------------------------
-- MMORpgDemo (C) CompanyName, All Rights Reserved
-- Created by: AuthorName
-- Date: 2022-06-08 23:46:06
---------------------------------------------------------------------

-- To edit this template in: Data/Config/Template.lua
-- To disable this template, check off menuitem: Options-Enable Template File
--[[
-- UI对象池，专针对ui上面的物体制作池子
--]]

-- UI单例对象池
local GameObjectPoolUI=BaseClass("GameObjectPoolUI",Singleton)

local __cacheTransRoot=nil
-- UI池表
local __goUIPool={}
local function __init(self)
	local rootGo=CS.UnityEngine.GameObject.Find("UIRoot")

	local go=CS.UnityEngine.GameObject.Find("UIRoot/GameObjectCacheRoot")
	if go==nil then
		go=CS.UnityEngine.GameObject("GameObjectCacheRoot")
		go.transform.parent=rootGo		
	end
	__cacheTransRoot=go.transform
end


