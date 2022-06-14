using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Script.Framework.UI.FrameworkUI
{
#if UNITY_EDITOR

    [CustomEditor(typeof(SignSerializableUI))]
    public class SignSerializableUI_Editor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            SignSerializableUI gizmos = target as SignSerializableUI;


            EditorGUI.BeginChangeCheck();
            var go = Selection.activeGameObject;
            var coms = go.GetComponents(typeof(Component));

            coms = coms.Where(item => !(gizmos is null) && item.GetType() != gizmos.GetType()).ToArray();

            string[] names = new string[coms.Length + 1];
            for (int i = 0; i < coms.Length; i++)
            {
                names[i] = coms[i].GetType().Name;
            }

            names[coms.Length] = "GameObject";
            if (gizmos is null) return;
            {
                gizmos.maskindex = EditorGUILayout.MaskField("选择组件", gizmos.maskindex, names);
                //Logger.Log(maskindex);
                //gizmos.coms.Clear();

                bool isChange = false;

                for (int i = 0; i < coms.Length; i++)
                {
                    if (0 == (1 << i & gizmos.maskindex))
                    {
                        if (gizmos.Contains(coms[i]))
                        {
                            gizmos.Delete(coms[i]);
                            isChange = true;
                        }
                    }
                    else
                    {
                        if (!gizmos.Contains(coms[i]))
                        {
                            gizmos.coms.Add(new KeyObjectData()
                                {key = SignSerializableUI.GetPath(coms[i]), obj = coms[i]});
                            isChange = true;
                        }
                    }
                }

                foreach (var item in gizmos.coms)
                {
                    using (var hs = new EditorGUILayout.HorizontalScope())
                    {
                        EditorGUILayout.LabelField("key:", GUILayout.Width(30));
                        string newKey = EditorGUILayout.TextField(item.key);
                        if (newKey != item.key)
                        {
                            item.key = newKey;

                            isChange = true;
                        }

                        EditorGUILayout.LabelField("obj:", GUILayout.Width(30));

                        EditorGUILayout.ObjectField(item.obj, typeof(Component), false);
                    }
                }

                if (0 != (1 << (names.Length - 1) & gizmos.maskindex))
                {
                    //GameObject go = gizmos.gameObject;
                    if (!gizmos.Contains(go))
                    {
                        gizmos.coms.Add(new KeyObjectData() {key = SignSerializableUI.GetPath(go), obj = go});
                        isChange = true;
                    }
                }
                else
                {
                    if (gizmos.Contains(go))
                    {
                        gizmos.Delete(go);
                        isChange = true;
                    }
                }

                if (isChange)
                {
                    gizmos.RootFlush();
                }
            }
        }
    }
#endif
}