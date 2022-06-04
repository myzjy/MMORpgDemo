// using System.Collections.Generic;
// using System.Collections.Specialized;
// using System.Linq;
// #if UNITY_EDITOR
// using System.IO;
// using UnityEditor;
// using UnityEditorInternal;
// #endif
// using UnityEngine;
//
// //绘制
// [CustomPropertyDrawer(typeof(AssetStringPath))]
// public class AssetStringPathDrawer : PropertyDrawer
// {
//     public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
//     {
//         using (new EditorGUI.PropertyScope(totalPosition: position, label: label, property: property))
//         {
//             EditorGUIUtility.labelWidth = 60;
//
//             position.height = EditorGUIUtility.singleLineHeight;
//             var nameRect = new Rect(position)
//             {
//                 width = position.width / 3,
//                 height = 20
//             };
//             var postRect = new Rect(nameRect)
//             {
//                 width = position.width / 3,
//                 x = position.x + nameRect.width
//             };
//             var postStrRect = new Rect(postRect)
//             {
//                 width = position.width / 3,
//                 x = postRect.x + nameRect.width
//             };
//             var namePro = property.FindPropertyRelative("name");
//             var assetUITypePro = property.FindPropertyRelative("uiName");
//             var pathListPro = property.FindPropertyRelative("pathList");
//
//             namePro.objectReferenceValue =
//                 EditorGUI.ObjectField(nameRect, namePro.objectReferenceValue, typeof(Object), true);
//             string onePath = AssetDatabase.GetAssetOrScenePath(namePro.objectReferenceValue);
//             pathListPro.stringValue = onePath;
//             pathListPro.stringValue = EditorGUI.TextField(postRect, pathListPro.displayName, pathListPro.stringValue);
//             assetUITypePro.stringValue =
//                 EditorGUI.TextField(postStrRect, assetUITypePro.displayName, assetUITypePro.stringValue);
//         }
//     }
// }
//
//
// public class AddressablesEditorp : EditorWindow
// {
//     [SerializeField] List<AssetStringPath> _addressableAssetStringListDict = new List<AssetStringPath>();
//     //序列化对象
//     //protected SerializedObject _serializedObject;
//
//     //序列化属性
//     protected SerializedProperty _assetLstProperty;
//
//     //资源配置
//     Dictionary<string, AddressableAssetGroup> groupDict = new Dictionary<string, AddressableAssetGroup>();
//     static EditorWindow editorWindow;
//
//     [MenuItem("Tool/Addressable/BuildAssert")]
//     public static void Init()
//     {
//        // var i= Addressables.LoadAssetAsync<object>("Assets/AddressablePaker/Lua");
//         editorWindow = EditorWindow.GetWindow(typeof(AddressablesEditorp));
//     }
//
//     SerializedObject _addressableAssetStringListDictObj;
//     SerializedProperty prop;
//     Rect _posRect;
//
//     private void OnEnable()
//     {
//         _addressableAssetStringListDictObj = new SerializedObject(this);
//     }
//
//     //列表显示
//     private ReorderableList _assetListShow;
//     AddressableAssetString addressableAssetObj;
//     Vector2 scrollPos;
//     Vector2 tr = Vector2.zero;
//
//     private void OnGUI()
//     {
//         EditorGUI.BeginChangeCheck();
//         var addressableAsset =
//             AssetDatabase.LoadAssetAtPath<AddressableAssetString>("Assets/AddressablePaker/AddressableAssetStringer.Asset");
//         addressableAssetObj = addressableAsset;
//         addressableAssetObj = (AddressableAssetString) EditorGUILayout.ObjectField("资源文件夹Asset数据:", addressableAssetObj,
//             typeof(AddressableAssetString), true);
//         _addressableAssetStringListDictObj.Update();
//
//         //GUILayout.Label("资源文件显示", EditorStyles.boldLabel);
//
//         if (addressableAssetObj != null)
//         {
//             AssetStringPath[] assetStringPaths = addressableAssetObj.GetAll();
//             _addressableAssetStringListDict = assetStringPaths.ToList();
//         }
//
//         _addressableAssetStringListDictObj.ApplyModifiedProperties();
//
//         prop = _addressableAssetStringListDictObj.FindProperty("_addressableAssetStringListDict");
//
//         scrollPos = EditorGUILayout.BeginScrollView(scrollPos, GUILayout.Width(position.width));
//
//         if (addressableAssetObj != null)
//         {
//             _assetListShow = new ReorderableList(_addressableAssetStringListDict, typeof(AssetStringPath), true, true,
//                 false, false);
//             _assetListShow.elementHeight = 20;
//             _assetListShow.drawElementCallback = (Rect rect, int index, bool isActive, bool isFocused) =>
//             {
//                 //var ele = _addressableAssetStringListDict[index];
//                 if (prop.arraySize > index)
//                 {
//                     var element = prop.GetArrayElementAtIndex(index);
//                     rect.height = 20;
//                     rect.y += 1;
//
//                     EditorGUI.PropertyField(position: rect, property: element);
//                     GUI.backgroundColor = Color.white;
//                 }
//             };
//             _assetListShow.drawElementBackgroundCallback = (rect, index, isActive, isFocused) =>
//             {
//                 //GUI.backgroundColor = Color.red;
//             };
//             _assetListShow.drawHeaderCallback = (rect) => { EditorGUI.LabelField(rect, "资源文件夹"); };
//         }
//
//         if (_assetListShow != null)
//         {
//             _assetListShow.DoLayoutList();
//         }
//
//         BuildAssert();
//         //GUILayout.EndHorizontal();
//         if (GUILayout.Button("刷新资源", GUILayout.Width(100)))
//         {
//             var setting = AddressableAssetSettingsDefaultObject.Settings;
//             for (int i = 0; i < _addressableAssetStringListDict.Count; i++)
//             {
//                 var item = _addressableAssetStringListDict[i];
//                 string fullpath = string.Format("{0}/", item.pathList);
//                 var aGroup = groupDict[item.uiName];
//                 if (Directory.Exists(fullpath))
//                 {
//                     DirectoryInfo directoryInfo = new DirectoryInfo(fullpath);
//                     FileInfo[] fileInfos = directoryInfo.GetFiles("*", SearchOption.AllDirectories);
//                     string[] fullPath = fileInfos.Where(a => !(a.Name.EndsWith(".meta"))).Select(a =>
//                     {
//                         string tip = a.FullName;
//                         tip = tip.Replace("\\", "/");
//                         int index = tip.IndexOf(fullpath);
//
//                         string tipsRemove = tip.Remove(0, index);
//                         return tipsRemove;
//                     }).ToArray();
//                     for (int k = 0; k < fullPath.Length; k++)
//                     {
//                         var pathGUID = AssetDatabase.AssetPathToGUID(fullPath[k]);
//                         AddressableAssetEntry addressableAssetEntry = aGroup.GetAssetEntry(pathGUID);
//                         if (addressableAssetEntry == null)
//                         {
//                             addressableAssetEntry = setting.CreateOrMoveEntry(pathGUID, aGroup);
//                         }
//
//                         string name = Path.GetFileNameWithoutExtension(addressableAssetEntry.AssetPath);
//                         if (name != addressableAssetEntry.address)
//                         {
//                             addressableAssetEntry.SetAddress(name, false);
//                         }
//                     }
//                 }
//             }
//
//             AssetDatabase.Refresh();
//         }
//
//         EditorGUILayout.EndScrollView();
//     }
//     //FileInfo[] files = direction.GetFiles("*", SearchOption.AllDirectories);
//
//     //Debug.Log(files.Length);
//
//     //        for (int i = 0; i<files.Length; i++)
//     //        {
//     //            if (files[i].Name.EndsWith(".asset"))//.asset
//     //            {
//     //                continue;
//     //            }
//     //            Debug.Log("Name:" + files[i].Name);  //打印出来这个文件架下的所有文件
//     //            //Debug.Log( "FullName:" + files[i].FullName );  
//     //            //Debug.Log( "DirectoryName:" + files[i].DirectoryName );  
//     //        }
//
//     //public void findFiles001()
//     //{
//     //    //获得 工程文件的路径，以及要 加载的目标文件夹下面的 文件路径，存放在一个字符串数组中
//     //    string[] arrStrAudioPath = Directory.GetFiles(Application.dataPath + "/123/asset/", "*", SearchOption.AllDirectories);//using System.IO;
//     //    //循环遍历每一个路径，单独加载
//     //    foreach (string strAudioPath in arrStrAudioPath)
//     //    {
//     //        //替换路径中的反斜杠为正斜杠       
//     //        string strTempPath = strAudioPath.Replace(@"\", "/");
//     //        //截取我们需要的路径
//     //        strTempPath = strTempPath.Substring(strTempPath.IndexOf("Assets"));
//     //        //根据路径加载资源
//     //        Object objAudio = AssetDatabase.LoadAssetAtPath(@strTempPath, typeof(Object));//using UnityEditor;
//     //        //objAudio.GetType();
//     //        if (objAudio != null)
//     //        {
//     //            Debug.Log("  objName: " + objAudio.GetType());//获得 目标文件 的物体类型
//     //            objects.Add(objAudio);
//     //        }
//     //    }
//     //}
//     public void BuildAssert()
//     {
//         //EditorGUIUtility.labelWidth = 60;
//         var nameRect = new Rect(_posRect)
//         {
//             width = position.width / 2,
//             height = 20,
//             x = scrollPos.x,
//             y = position.y
//         };
//         EditorGUILayout.ObjectField("AddressableAssetSettings", AddressableAssetSettingsDefaultObject.Settings,
//             typeof(AddressableAssetSettings), true);
//
//         var setting = AddressableAssetSettingsDefaultObject.Settings;
//         if (setting == null)
//         {
//             Debug.Log("未配置");
//             return;
//         }
//
//         //AssetDatabase.LoadAssetAtPath
//         //将配置文件存储在配置字典中
//         AddressableAssetGroupDict();
//     }
//
//     public void AddressableAssetGroupDict()
//     {
//         try
//         {
//             var setting = AddressableAssetSettingsDefaultObject.Settings;
//             foreach (var item in setting.groups)
//             {
//                 if (groupDict.ContainsKey(item.name))
//                 {
//                     groupDict[item.name] = item;
//                 }
//                 else
//                 {
//                     groupDict.Add(item.name, item);
//                 }
//             }
//         }
//         catch (System.Exception)
//         {
//             var setting = AddressableAssetSettingsDefaultObject.Settings;
//             //setting.groups=setting.groups.Where(a => a != null).ToList();
//         }
//     }
// }