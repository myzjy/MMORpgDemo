using System.IO;
using System.Linq;
using UnityEngine;
using UnityEditor;

// [CreateAssetMenu(fileName = "Message.asset", menuName = "Message/MessageData/messageData", order = 1)]
public class ToolsUnitMenu
{
    protected const string ASSET_LUAASSET_DATA_PATH = "Assets/GameDataScriptObj/MessageObj/";
    protected static readonly string ASSET_MESSAGE_DATA_PATH = "Assets/Game/Manager/Message/";

    /// <summary>
    /// 文字中文
    /// </summary>
    // [MenuItem("Tool/Messag/MessageInstance")]
    // public static void _MessageDataSc()
    // {
    //     ReadValue readValue = new ReadValue();
    //     if (readValue.GetMaoGuo.Values.Count < 1)
    //     {
    //         return;
    //     }
    //
    //     var va = readValue.GetMaoGuo.Values.ToArray();
    //
    //     string scriptText = "";
    //     scriptText += "namespace Game.Manager.Message\n{\n";
    //     scriptText += "\tpublic enum Message\n\t{\n";
    //     foreach (var item in va)
    //     {
    //         scriptText += "\t\t/// <summary>\n";
    //         scriptText += string.Format($"\t\t/// ");
    //         scriptText += item.CnText;
    //         scriptText += "\n";
    //         scriptText += "\t\t/// </summary>\n";
    //         scriptText += string.Format($"\t\t{item.TextMu.ToUpper()},\n");
    //     }
    //
    //     scriptText += "\t}";
    //
    //     scriptText += "\n}";
    //     var fi = new FileInfo(Application.dataPath + "/Script/Game/Manager/Message/Message.cs");
    //     var sw = fi.CreateText();
    //     sw.WriteLine(scriptText);
    //     sw.Flush();
    //     sw.Close();
    //
    //     string script = ASSET_LUAASSET_DATA_PATH + "Message.asset";
    //     var data = AssetDatabase.LoadAssetAtPath<Game.Manager.Message.MessageData>(script);
    //     if (data == null)
    //     {
    //         //没有读取到对应的资源
    //         Debug.Log("未读取到对应资源");
    //         data = ScriptableObject.CreateInstance<Game.Manager.Message.MessageData>();
    //         //创建
    //         Debug.Log("开始创建:");
    //         data.MessageDataStrings = va.Select(a => a.CnText).ToArray();
    //         data.hideFlags = HideFlags.NotEditable;
    //         AssetDatabase.CreateAsset(data, script);
    //     }
    //     else
    //     {
    //         data.hideFlags = HideFlags.NotEditable;
    //
    //         data.MessageDataStrings = va.Select(a => a.CnText).ToArray();
    //         EditorUtility.SetDirty(data);
    //         AssetDatabase.SaveAssets();
    //     }
    //
    //     AssetDatabase.Refresh();
    // }
}