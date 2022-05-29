---@module CS.Tools.Util
CS.Tools.Util = {}

---@class CS.Tools.Util.Util : CS.System.Object
CS.Tools.Util.Util = {}

---@param _action : CS.System.Action
function CS.Tools.Util.Util.Execute(_action)
end

---@param _gameObject : CS.UnityEngine.GameObject
function CS.Tools.Util.Util.InstanceObj(_gameObject)
end

---@param m_obj : CS.UnityEngine.GameObject
---@param m_tr : CS.UnityEngine.Transform
---@param isActive : CS.System.Boolean
---@return CS.UnityEngine.GameObject
function CS.Tools.Util.Util.InstantiateGameObject(m_obj, m_tr, isActive)
end

---@param onComplte : CS.System.Action
---@param finish : CS.System.Action
function CS.Tools.Util.Util.PerformOnBgThread(onComplte, finish)
end