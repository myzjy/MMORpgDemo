using System.Collections.Generic;
using System.IO;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditorInternal;

#endif

using UnityEngine;



[CustomEditor(typeof(AddressableAssetString))]
public class AddressableAssetStringTools : Editor
{
        ReorderableList reorderableList;
        public void OnEnable()
        {
                reorderableList = new ReorderableList(serializedObject: serializedObject,
                      elements: serializedObject.FindProperty("assetStringPathsList"),
                      true, true, true, true);
                reorderableList.drawElementCallback = (rect, index, isActive, isFocused) =>
                {
                        var element = reorderableList.serializedProperty.GetArrayElementAtIndex(index);

                        rect.height -= 4;
                        rect.y -= 2;

                        EditorGUI.PropertyField(rect, element, new GUIContent("Index" + index));
                        GUI.backgroundColor = Color.white;
                };
                reorderableList.drawElementBackgroundCallback = (rect, index, isActive, isFocused) =>
                {
                //GUI.backgroundColor = Color.red;

        };
                reorderableList.drawHeaderCallback = (rect) =>
                {
                        EditorGUI.LabelField(rect, "资源文件夹");
                };
                reorderableList.onRemoveCallback = (list) =>
                {
                        ReorderableList.defaultBehaviours.DoRemoveButton(list);
                };
                reorderableList.onSelectCallback = (list) =>
                {
                        GUI.backgroundColor = Color.red;
                        Debug.Log(list.index);
                };
        }
        public override void OnInspectorGUI()
        {
                //base.OnInspectorGUI();
                //EditorGUI.BeginChangeCheck();
                serializedObject.Update();
                AddressableAssetString assetString = this.target as AddressableAssetString;
                EditorGUILayout.LabelField("资源文件");
                if (reorderableList != null)
                {
                        reorderableList.DoLayoutList();
                }
                //if (EditorGUI.EndChangeCheck())
                //{
                serializedObject.ApplyModifiedProperties();
                //}
                //serializedObject.ApplyModifiedProperties();

        }
        private bool IsDirOrW(string filePath)
        {
                if (string.IsNullOrEmpty(filePath))
                {
                        return false;
                }
                try
                {
                        FileInfo fileInfo = new FileInfo(filePath);
                        if ((fileInfo.Attributes & FileAttributes.Directory) != 0) return true;
                        else return false;
                }
                catch (System.Exception)
                {
                        return false;
                }
        }
}