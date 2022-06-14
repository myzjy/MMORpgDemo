using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
using Framework.UI.FrameworkUI;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;
using UnityEditor;

public class GenerateUIScriptEditor
{
    /// <summary>
    /// 从UIView自动生成 HotFix项目组件脚本
    /// </summary>
    [MenuItem("Tools/UI/GenerateUIScript", false, 50)]
    static void GenerateUIScript()
    {

        var targetUIPath = Application.dataPath + "/AddressablePaker/UI/Prefab/";
        var templateFile = Application.dataPath + "/../GenerateAutoUIScripts/GenerateTemplate.cs";
        var outputPath = Application.dataPath + "/Script/Common/_GenerateUIScript/";
        var outputProCSProj = Application.dataPath + "/../Assembly-CSharp.csproj";

        var uis = new DirectoryInfo(targetUIPath);
        var uiInfos = uis.GetFiles("*.*", SearchOption.AllDirectories);

        //输出VS项目引用配置
        var csprojStr = "";
        if (File.Exists(outputProCSProj))
        {
            csprojStr = File.ReadAllText(outputProCSProj);
        }
        else
        {
            Debug.LogError("csproj文件未找到，生成引用失败！");
        }

        //读取导出代码模板
        var classStrPre = "";

        if (File.Exists(templateFile))
        {
            classStrPre = File.ReadAllText(templateFile);
        }
        else
        {
            Debug.LogError("生成失败：模板文件不存在！");
            return;
        }

        foreach (FileInfo file in uiInfos)
        {
            if (file.Extension.Contains("meta"))
                continue;

            var classStr = classStrPre;

            //构造成员变量 和 初始化代码
            var path = file.FullName.Replace("\\", "/");
            path = path.Replace(Application.dataPath, "Assets");

            if (file.Extension.Contains("prefab"))
            {
                var uiGO = AssetDatabase.LoadAssetAtPath<GameObject>(path);
                var uiView = uiGO.GetComponent<UIView>();

                if (uiView == null)
                {
                    Debug.LogError(uiGO + "没有挂载ui view 脚本");
                    return;
                }
                var uiDataList = uiView.data;


                var className = Path.GetFileNameWithoutExtension(file.Name) + "View";//类名
                var memberStr = "";//成员变量构造
                var initStr = "";//初始化变量

                uiDataList.ForEach(t =>
                {
                    var memberName = t.key;
                    var typeStr = t.obj.GetType();

                    memberStr += string.Format("public {0} {1} = null;\r\n\t\t", typeStr, memberName);
                    initStr += string.Format("{0} = selfUIView.Get<{1}>(\"{2}\");\r\n\t\t\t", memberName, typeStr, memberName);
                });

                classStr = classStr.Replace("${ClassName}", className);
                classStr = classStr.Replace("${MemberVariables}", memberStr);
                classStr = classStr.Replace("${Init}", initStr);

                //写入.cs文件
                var outputFileFullPath = string.Format(outputPath + "{0}.cs", className);
                FileStream stream = new FileStream(outputFileFullPath, FileMode.Create, FileAccess.Write);

                StreamWriter fileW = new StreamWriter(stream, System.Text.Encoding.UTF8);
                fileW.Write(classStr);
                fileW.Flush();
                fileW.Close();
                stream.Close();
                Debug.Log("创建脚本 " + outputFileFullPath + "成功！");

                //生成csproj配置文件引用
                if (!string.IsNullOrEmpty(csprojStr))
                {
                    if (!Regex.IsMatch(csprojStr, className + ".cs"))
                    {
                        var compileStr = string.Format("<!--UIView-->\r\n\t<Compile Include=\"Game\\UI\\_GenerateUIScript\\{0}\" />", className + ".cs");
                        stream = new FileStream(outputProCSProj, FileMode.Open, FileAccess.Write);
                        csprojStr = csprojStr.Replace("<!--UIView-->", compileStr);

                        fileW = new StreamWriter(stream);
                        fileW.Write(csprojStr);
                        fileW.Flush();
                        fileW.Close();
                        stream.Close();
                        Debug.Log("生成csproj配置文件引用成功！");
                    }
                }
            }
        }
    }
}
