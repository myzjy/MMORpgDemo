---------------------------------------------------------------------
-- MMORpgDemo (C) CompanyName, All Rights Reserved
-- Created by: AuthorName
-- Date: 2022-05-30 23:35:33
---------------------------------------------------------------------

-- To edit this template in: Data/Config/Template.lua
-- To disable this template, check off menuitem: Options-Enable Template File

local unpack = unpack or table.unpack
local move_end = {}

local generator_mt = {
	__index = {
		MoveNext = function(self)
			self.Current = self.co()
			if self.Current == move_end then
				self.Current = nil
				return false
			else
				return true
			end
		end;
		Reset = function(self)
			self.co = coroutine.wrap(self.w_func)
		end
	}
}

local function cs_generator(func)
	local generator = setmetatable({
			w_func = function()
				func()
				return move_end
			end
		}, generator_mt)
	generator:Reset()
	return generator
end

---@class util
local util = {}


local function loadpackage(...)
	for _, loader in ipairs(package.searchers) do
		local func = loader(...)
		if type(func) == 'function' then
			return func
		end
	end
end

local function auto_id_map()
	local hotfix_id_map = require 'hotfix_id_map'
	local org_hotfix = xlua.hotfix
	xlua.hotfix = function(cs, field, func)
		local map_info_of_type = hotfix_id_map[typeof(cs):ToString()]
		if map_info_of_type then
			if func == nil then func = false end
			local tbl = (type(field) == 'table') and field or {[field] = func}
			for k, v in pairs(tbl) do
				local map_info_of_methods = map_info_of_type[k]
				local f = type(v) == 'function' and v or nil
				for _, id in ipairs(map_info_of_methods or {}) do
					CS.XLua.HotfixDelegateBridge.Set(id, f)
				end
				--CS.XLua.HotfixDelegateBridge.Set(
			end
		else
			return org_hotfix(cs, field, func)
		end
	end
end

--和xlua.hotfix的区别是：这个可以调用原来的函数
local function hotfix_ex(cs, field, func)
	assert(type(field) == 'string' and type(func) == 'function', 'invalid argument: #2 string needed, #3 function needed!')
	local function func_after(...)
		xlua.hotfix(cs, field, nil)
		local ret = {func(...)}
		xlua.hotfix(cs, field, func_after)
		return unpack(ret)
	end
	xlua.hotfix(cs, field, func_after)
end

local function bind(func, obj)
	return function(...)
		return func(obj, ...)
	end
end
return {
	cs_generator = cs_generator,
	loadpackage = loadpackage,
	auto_id_map = auto_id_map,
	hotfix_ex = hotfix_ex,
	bind = bind,
}
