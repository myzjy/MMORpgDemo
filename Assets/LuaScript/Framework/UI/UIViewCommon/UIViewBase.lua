---------------------------------------------------------------------
-- MMORpgDemo (C) CompanyName, All Rights Reserved
-- Created by: AuthorName
-- Date: 2022-07-18 23:19:38
---------------------------------------------------------------------

-- To edit this template in: Data/Config/Template.lua
-- To disable this template, check off menuitem: Options-Enable Template File
--- UIViewBase 这个内部集成View调度
---@class UIViewBase
UIViewBase = {}
local UIPanelView=BaseClass("UIPanelView",UIViewInterface)
local base = UIViewInterface

local viewPaenl;

local selfView;
function SetView(view,PanelView)
	self.selfView=view
	if type(viewPaenl)=="UIViewInterface" then
		
	end
	viewPaenl=PanelView
	viewPaenl.Init(self.selfView)
end




UIViewBase.SelfView=selfView
