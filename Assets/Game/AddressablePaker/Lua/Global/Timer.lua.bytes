---------------------------------------------------------------------
-- MMORpgDemo (C) CompanyName, All Rights Reserved
-- Created by: AuthorName
-- Date: 2022-06-24 16:19:34
---------------------------------------------------------------------

-- To edit this template in: Data/Config/Template.lua
-- To disable this template, check off menuitem: Options-Enable Template File

---@class Timer
local Timer = {}
Timer.TimerName=""
Timer.Duration =nil
function Timer:new(name,duration)
	local o={}
	setmetatable(o,self)
	self.__index=self
	self.TimerName=name
	self.Duration=duration
	return o
end
return Timer