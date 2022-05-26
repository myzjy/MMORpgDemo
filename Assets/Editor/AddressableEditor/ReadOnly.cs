﻿using UnityEditor;
using UnityEngine;

namespace ReadOnlyN
{


    public class ReadOnlyAttribute : PropertyAttribute
    {

    }
    [CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
    class ReadonlyDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, true);
        }
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            GUI.enabled = false;

            EditorGUI.PropertyField(position, property, label, true);

            GUI.enabled = true;
        }
    }
}

