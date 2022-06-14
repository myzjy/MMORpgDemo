using Script.Framework.UI.FrameworkUI;
using UnityEditor;
using UnityEngine;

namespace Editors.Common
{
    [CustomEditor(typeof(SerializableKeyObject), true)]

    public class SerializableKeyObject_Editor:Editor
    {
        public override void OnInspectorGUI()
        {
        
            base.OnInspectorGUI();
            SerializableKeyObject gizmos = target as SerializableKeyObject;
            EditorGUI.BeginChangeCheck();
            var go = Selection.activeGameObject;
            var coms = go.GetComponents(typeof(Component));
            string[] names = new string[coms.Length];
            for (int i = 0; i < coms.Length; i++)
            {
                names[i] = coms[i].GetType().FullName;
            }
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("保存的UI:");



            foreach (var item in gizmos.data)
            {
                using (new EditorGUILayout.HorizontalScope())
                {
                    EditorGUILayout.LabelField("key:", GUILayout.Width(30));
                    EditorGUILayout.SelectableLabel(item.key ,GUILayout.Height(20));

                    EditorGUILayout.LabelField("obj:", GUILayout.Width(30));

                    EditorGUILayout.ObjectField(item.obj, typeof(Component), false);
                }
            }

        }
    }
}