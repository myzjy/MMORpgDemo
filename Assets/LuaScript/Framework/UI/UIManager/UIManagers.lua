
local UIManager = BaseClass("UIManagers",Singleton)

local Messenger = require "Framework.Common.Messenger"
-- UIRoot路径
local UIRootPath = "UIRoot"
-- EventSystem路径
local EventSystemPath = "EventSystem"

-- UIManager构造函数
local function __init(self)
	-- body
	--UI管理器的消息中心
	self.ui_message_center=Messenger.New()
	self.gameObject = CS.UnityEngine.GameObject.Find(UIRootPath)
	self.transform = self.gameObject.transform
	local event_system = CS.UnityEngine.GameObject.Find(EventSystemPath)
	CS.UnityEngine.Object.DontDestroyOnLoad(event_system)
	-- 初始化UImanager 时找没找到UIRoot
	assert(not IsNull(self.transform))
end





return UIManager