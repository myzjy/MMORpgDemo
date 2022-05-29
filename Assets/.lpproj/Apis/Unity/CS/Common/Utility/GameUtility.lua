---@class CS.Common.Utility.GameUtility : CS.System.Object
CS.Common.Utility.GameUtility = {}

---@field public CS.Common.Utility.GameUtility.AssetsFolderName : CS.System.String
CS.Common.Utility.GameUtility.AssetsFolderName = nil

---@return CS.Common.Utility.GameUtility
function CS.Common.Utility.GameUtility()
end

---@param inFile : CS.System.String
---@return CS.System.Byte[]
function CS.Common.Utility.GameUtility.SafeReadAllBytes(inFile)
end

---@param folderPath : CS.System.String
---@return CS.System.Boolean
function CS.Common.Utility.GameUtility.LuaSafeDeleteDir(folderPath)
end

---@param folderPath : CS.System.String
---@return CS.System.Boolean
function CS.Common.Utility.GameUtility.SafeClearDir(folderPath)
end

---@param path : CS.System.String
---@return CS.System.String
function CS.Common.Utility.GameUtility.FormatToSysFilePath(path)
end

---@param path : CS.System.String
---@param extensions : CS.System.String[]
---@param exclude : CS.System.Boolean
---@return CS.System.String[]
function CS.Common.Utility.GameUtility.GetSpecifyFilesInFolder(path, extensions, exclude)
end

---@param filePath : CS.System.String
---@return CS.System.Boolean
function CS.Common.Utility.GameUtility.LuaSafeDeleteFile(filePath)
end

---@param sourceFileName : CS.System.String
---@param destFileName : CS.System.String
---@return CS.System.Boolean
function CS.Common.Utility.GameUtility.LuaRenameFile(sourceFileName, destFileName)
end

---@param outFile : CS.System.String
---@param outBytes : CS.System.Byte[]
---@return CS.System.Boolean
function CS.Common.Utility.GameUtility.SafeWriteAllBytes(outFile, outBytes)
end

---@param inFile : CS.System.String
---@return CS.System.String
function CS.Common.Utility.GameUtility.SafeReadAllText(inFile)
end

---@param folderPath : CS.System.String
---@return CS.System.Boolean
function CS.Common.Utility.GameUtility.SafeDeleteDir(folderPath)
end

---@param outFile : CS.System.String
---@param text : CS.System.String
---@return CS.System.Boolean
function CS.Common.Utility.GameUtility.SafeWriteAllText(outFile, text)
end

---@param outFile : CS.System.String
---@param outLines : CS.System.String[]
---@return CS.System.Boolean
function CS.Common.Utility.GameUtility.SafeWriteAllLines(outFile, outLines)
end

---@param path : CS.System.String
---@return CS.System.String
function CS.Common.Utility.GameUtility.FormatToUnityPath(path)
end

---@param full_path : CS.System.String
---@return CS.System.String
function CS.Common.Utility.GameUtility.FullPathToAssetPath(full_path)
end

---@param folderPath : CS.System.String
function CS.Common.Utility.GameUtility.CheckDirAndCreateWhenNeeded(folderPath)
end

---@param filePath : CS.System.String
---@return CS.System.Boolean
function CS.Common.Utility.GameUtility.SafeDeleteFile(filePath)
end

---@param sourceFileName : CS.System.String
---@param destFileName : CS.System.String
---@return CS.System.Boolean
function CS.Common.Utility.GameUtility.SafeRenameFile(sourceFileName, destFileName)
end