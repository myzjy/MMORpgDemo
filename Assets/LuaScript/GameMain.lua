---------------------------------------------------------------------
-- MMORpgDemo (C) CompanyName, All Rights Reserved
-- Created by: AuthorName
-- Date: 2022-05-24 12:24:14
---------------------------------------------------------------------

-- To edit this template in: Data/Config/Template.lua
-- To disable this template, check off menuitem: Options-Enable Template File



require "Global.Global"
require "Global.Timer"

local Times1=Timer:new("222",4)
print(Times1.TimerName,Times1.Duration)
---@class GameMain
GameMain = {};
print("GameMin ing ....")
 function OnInit()
	print("初始化所有")
   
end

function Update(self)
	print("Update...")
end

 function Start()
	print("初始化所有 start")
	-- 模块启动
	UpdateManager:GetInstance():Startup()
end
GameMain.OnInit=OnInit
GameMain.Start=Start

return GameMain