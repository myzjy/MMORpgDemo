---@class CS.UnityEngine.Windows.WebCam.OnVideoModeStoppedCallback : CS.System.MulticastDelegate
CS.UnityEngine.Windows.WebCam.OnVideoModeStoppedCallback = {}

---@param object : CS.System.Object
---@param method : CS.System.IntPtr
---@return CS.UnityEngine.Windows.WebCam.OnVideoModeStoppedCallback
function CS.UnityEngine.Windows.WebCam.OnVideoModeStoppedCallback(object, method)
end

---@param result : CS.UnityEngine.Windows.WebCam.VideoCaptureResult
function CS.UnityEngine.Windows.WebCam.OnVideoModeStoppedCallback:Invoke(result)
end

---@param result : CS.UnityEngine.Windows.WebCam.VideoCaptureResult
---@param callback : CS.System.AsyncCallback
---@param object : CS.System.Object
---@return CS.System.IAsyncResult
function CS.UnityEngine.Windows.WebCam.OnVideoModeStoppedCallback:BeginInvoke(result, callback, object)
end

---@param result : CS.System.IAsyncResult
function CS.UnityEngine.Windows.WebCam.OnVideoModeStoppedCallback:EndInvoke(result)
end