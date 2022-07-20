---------------------------------------------------------------------
-- MMORpgDemo (C) CompanyName, All Rights Reserved
-- Created by: AuthorName
-- Date: 2022-05-31 20:36:41
---------------------------------------------------------------------

-- To edit this template in: Data/Config/Template.lua
-- To disable this template, check off menuitem: Options-Enable Template File

---@class UIRootS
UIRootS = {}
local UIRootObjCS = CS.UIRoot

debug=CS.ToolsDebug

local function StartRoot(self)
	-- Debug
	CS.ToolsDebug.Log(" UIRoot StartRoot")
	
	-- 不让物体被删除
	CS.UnityEngine.GameObject.DontDestroyOnLoad(self.gameObject)
	
end


UIRootS.StartRoot=StartRoot;
return UIRootS
