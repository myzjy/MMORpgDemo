---------------------------------------------------------------------
-- MMORpgDemo (C) CompanyName, All Rights Reserved
-- Created by: AuthorName
-- Date: 2022-05-24 19:48:07
---------------------------------------------------------------------

-- To edit this template in: Data/Config/Template.lua
-- To disable this template, check off menuitem: Options-Enable Template File

---@class ToolsCommons
 ToolsCommons = {}

local function ToolsCommons.printTool(string tips)
	
	if tips==nil then
		print("string nil user string")
	end
	
	print(tips);
end





return ToolsCommons;