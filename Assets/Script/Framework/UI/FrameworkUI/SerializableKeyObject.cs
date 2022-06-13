using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Script.Framework.UI.FrameworkUI
{
    [Serializable]
    public class KeyObjectData
    {
        public string key;
        public Object obj;
    }

    public class SerializableKeyObject : MonoBehaviour, ISerializationCallbackReceiver
    {
        [HideInInspector] public List<KeyObjectData> data = new List<KeyObjectData>();
        private readonly Dictionary<string, Object> dict = new Dictionary<string, Object>();

        /// <summary>
        /// Ons the after deserialize.
        /// 反序列化后触发方法
        /// </summary>
        public void OnAfterDeserialize()
        {
            //Logger.Log("OnAfterDeserialize");
            dict.Clear();
            foreach (var item in data.Where(item => !dict.ContainsKey(item.key)))
            {
                dict.Add(item.key, item.obj);
            }
        }

        /// <summary>
        /// Ons the before serialize.
        /// 序列化前触发方法
        /// </summary>
        public void OnBeforeSerialize()
        {
            //Logger.Log("OnBeforeSerialize");

            foreach (var item in data.Where(item => item.obj != null & string.IsNullOrEmpty(item.key)))
            {
                item.key = item.obj.name;
            }
        }

        public T Get<T>(string key) where T : class
        {
            if (!dict.TryGetValue(key, out var dictGo))
            {
                return null;
            }

            return dictGo as T;
        }

        public Object GetObject(string key)
        {
            return !dict.TryGetValue(key, out var dictGo) ? null : dictGo;
        }

#if UNITY_EDITOR

        public void FlushData()
        {
            var list = new List<SignSerializableUI>();
            var ssu = GetComponent<SignSerializableUI>();
            if (ssu != null)
            {
                list.Add(ssu);
            }

            var transform1 = transform;
            var tf = transform1;

            FindAllChild(ref list, transform1);

            data.Clear();
            foreach (var _ssu in list)
            {
                data.AddRange(_ssu.coms);
            }


            //string path = Application.dataPath + "/Resources/UI/" + gameObject.name+".prefab";

            //string path = UnityEditor.PrefabUtility.GetPrefabAssetPathOfNearestInstanceRoot(gameObject);


            //if (System.IO.File.Exists(path))
            //{
            //    UnityEditor.PrefabUtility.SaveAsPrefabAsset(gameObject, path);

            //}
        }


        private void FindAllChild(ref List<SignSerializableUI> list, Transform selfTF)
        {
            int childCount = selfTF.childCount;
            for (int i = 0; i < childCount; i++)
            {
                var childTF = selfTF.GetChild(i);
                if (childTF.GetComponent<SerializableKeyObject>() == null)
                {
                    var child = childTF.GetComponent<SignSerializableUI>();
                    if (child != null) list.Add(child);

                    FindAllChild(ref list, childTF);
                }

                if (childTF.GetComponent<SerializableKeyObject>() == null) continue;
                {
                    var child = childTF.GetComponent<SignSerializableUI>();
                    if (child != null) list.Add(child);
                }
            }
        }
#endif
    }
}