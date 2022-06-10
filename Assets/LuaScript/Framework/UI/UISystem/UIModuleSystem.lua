---------------------------------------------------------------------
-- MMORpgDemo (C) CompanyName, All Rights Reserved
-- Created by: AuthorName
-- Date: 2022-06-04 23:28:50
---------------------------------------------------------------------

-- To edit this template in: Data/Config/Template.lua
-- To disable this template, check off menuitem: Options-Enable Template File

---@class UIModuleSystem
 UIModuleSystem = {}

moduleNotify={}


-- 初始化
 local function __init( ... )
 	-- body

 end

local function RegisterEvent(view,func)
	-- body
	assert(view~=nil and typeof(view)=='string',"..")
	local it= moduleNotify[view]
	if it==nil then
	--不存在
	moduleNotify[view]=func
	elseif it~=nil then
		moduleNotify[view]=moduleNotify[view]+func
	end
end

local function DispatchEvent(name,boby)
	-- body

end

UIModuleSystem.DispatchEvent=DispatchEvent

return UIModuleSystem