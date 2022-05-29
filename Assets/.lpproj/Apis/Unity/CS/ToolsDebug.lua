---@class CS.ToolsDebug : CS.System.Object
CS.ToolsDebug = {}

---@property readonly CS.ToolsDebug.isDebugBuild : CS.System.Boolean
CS.ToolsDebug.isDebugBuild = nil

---@return CS.ToolsDebug
function CS.ToolsDebug()
end

---@param start : CS.UnityEngine.Vector3
---@param end_ : CS.UnityEngine.Vector3
---@param color : CS.UnityEngine.Color
---@param duration : CS.System.Single
function CS.ToolsDebug.DrawLine(start, end_, color, duration)
end

---@param message : CS.System.Object
function CS.ToolsDebug.Log(message)
end

---@param message : CS.System.Object
---@param context : CS.UnityEngine.Object
function CS.ToolsDebug.Log(message, context)
end

---@param format : CS.System.String
---@param args : CS.System.Object[]
function CS.ToolsDebug.LogFormat(format, args)
end

---@param context : CS.UnityEngine.Object
---@param format : CS.System.String
---@param args : CS.System.Object[]
function CS.ToolsDebug.LogFormat(context, format, args)
end

---@param logType : CS.UnityEngine.LogType
---@param logOptions : CS.UnityEngine.LogOption
---@param context : CS.UnityEngine.Object
---@param format : CS.System.String
---@param args : CS.System.Object[]
function CS.ToolsDebug.LogFormat(logType, logOptions, context, format, args)
end

---@param message : CS.System.Object
function CS.ToolsDebug.LogError(message)
end

---@param message : CS.System.Object
---@param context : CS.UnityEngine.Object
function CS.ToolsDebug.LogError(message, context)
end

---@param format : CS.System.String
---@param args : CS.System.Object[]
function CS.ToolsDebug.LogErrorFormat(format, args)
end

---@param context : CS.UnityEngine.Object
---@param format : CS.System.String
---@param args : CS.System.Object[]
function CS.ToolsDebug.LogErrorFormat(context, format, args)
end

function CS.ToolsDebug.ClearDeveloperConsole()
end

---@param message : CS.System.Object
function CS.ToolsDebug.LogWarning(message)
end

---@param message : CS.System.Object
---@param context : CS.UnityEngine.Object
function CS.ToolsDebug.LogWarning(message, context)
end

---@param format : CS.System.String
---@param args : CS.System.Object[]
function CS.ToolsDebug.LogWarningFormat(format, args)
end

---@param context : CS.UnityEngine.Object
---@param format : CS.System.String
---@param args : CS.System.Object[]
function CS.ToolsDebug.LogWarningFormat(context, format, args)
end

---@param condition : CS.System.Boolean
function CS.ToolsDebug.Assert(condition)
end

---@param condition : CS.System.Boolean
---@param context : CS.UnityEngine.Object
function CS.ToolsDebug.Assert(condition, context)
end

---@param condition : CS.System.Boolean
---@param message : CS.System.Object
function CS.ToolsDebug.Assert(condition, message)
end

---@param condition : CS.System.Boolean
---@param message : CS.System.String
function CS.ToolsDebug.Assert(condition, message)
end

---@param condition : CS.System.Boolean
---@param message : CS.System.Object
---@param context : CS.UnityEngine.Object
function CS.ToolsDebug.Assert(condition, message, context)
end

---@param condition : CS.System.Boolean
---@param message : CS.System.String
---@param context : CS.UnityEngine.Object
function CS.ToolsDebug.Assert(condition, message, context)
end

---@param condition : CS.System.Boolean
---@param format : CS.System.String
---@param args : CS.System.Object[]
function CS.ToolsDebug.AssertFormat(condition, format, args)
end

---@param condition : CS.System.Boolean
---@param context : CS.UnityEngine.Object
---@param format : CS.System.String
---@param args : CS.System.Object[]
function CS.ToolsDebug.AssertFormat(condition, context, format, args)
end

---@param message : CS.System.Object
function CS.ToolsDebug.LogAssertion(message)
end

---@param message : CS.System.Object
---@param context : CS.UnityEngine.Object
function CS.ToolsDebug.LogAssertion(message, context)
end

---@param format : CS.System.String
---@param args : CS.System.Object[]
function CS.ToolsDebug.LogAssertionFormat(format, args)
end

---@param context : CS.UnityEngine.Object
---@param format : CS.System.String
---@param args : CS.System.Object[]
function CS.ToolsDebug.LogAssertionFormat(context, format, args)
end

---@param s : CS.System.String
---@param p : CS.System.Object[]
function CS.ToolsDebug.LogError(s, p)
end