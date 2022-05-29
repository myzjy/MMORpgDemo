---@module CS.Script.Framework.UI.Tip
CS.Script.Framework.UI.Tip = {}

---@class CS.Script.Framework.UI.Tip.UINoticeTip : CS.GameTools.Singletons.MMOSingleton
CS.Script.Framework.UI.Tip.UINoticeTip = {}

---@property readwrite CS.Script.Framework.UI.Tip.UINoticeTip.IsShowing : CS.System.Boolean
CS.Script.Framework.UI.Tip.UINoticeTip.IsShowing = nil

---@property readwrite CS.Script.Framework.UI.Tip.UINoticeTip.UIGameObject : CS.UnityEngine.GameObject
CS.Script.Framework.UI.Tip.UINoticeTip.UIGameObject = nil

---@property readonly CS.Script.Framework.UI.Tip.UINoticeTip.progress : CS.System.Single
CS.Script.Framework.UI.Tip.UINoticeTip.progress = nil

---@property readonly CS.Script.Framework.UI.Tip.UINoticeTip.isDone : CS.System.Boolean
CS.Script.Framework.UI.Tip.UINoticeTip.isDone = nil

---@return CS.Script.Framework.UI.Tip.UINoticeTip
function CS.Script.Framework.UI.Tip.UINoticeTip()
end

---@param title : CS.System.String
---@param content : CS.System.String
---@param btnText : CS.System.String
---@param callback : CS.System.Action
function CS.Script.Framework.UI.Tip.UINoticeTip:ShowOneButtonTip(title, content, btnText, callback)
end

---@param title : CS.System.String
---@param content : CS.System.String
---@param btnText1 : CS.System.String
---@param btnText2 : CS.System.String
---@param callback1 : CS.System.Action
---@param callback2 : CS.System.Action
function CS.Script.Framework.UI.Tip.UINoticeTip:ShowTwoButtonTip(title, content, btnText1, btnText2, callback1, callback2)
end

---@param title : CS.System.String
---@param content : CS.System.String
---@param btnText1 : CS.System.String
---@param btnText2 : CS.System.String
---@param btnText3 : CS.System.String
---@param callback1 : CS.System.Action
---@param callback2 : CS.System.Action
---@param callback3 : CS.System.Action
function CS.Script.Framework.UI.Tip.UINoticeTip:ShowThreeButtonTip(title, content, btnText1, btnText2, btnText3, callback1, callback2, callback3)
end

function CS.Script.Framework.UI.Tip.UINoticeTip:HideTip()
end

---@return CS.System.Collections.IEnumerator
function CS.Script.Framework.UI.Tip.UINoticeTip:WaitForResponse()
end

function CS.Script.Framework.UI.Tip.UINoticeTip:Dispose()
end