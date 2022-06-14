using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Script.Framework.UI.FrameworkUI
{
 [DisallowMultipleComponent]
public class SignSerializableUI : MonoBehaviour
{
#if UNITY_EDITOR
    [HideInInspector]
    public List<KeyObjectData> coms = new List<KeyObjectData>();
    private readonly Dictionary<string, Object> dict = new Dictionary<string, Object>();
    [HideInInspector]
    public int maskindex = 0;

    /// <summary>
    /// 刷新根节点
    /// </summary>
    public void RootFlush()
    {

        Transform parent = transform.parent;
        SerializableKeyObject sko = null;
        while (parent != null)
        {
            sko = parent.GetComponent<SerializableKeyObject>();
            if(sko != null)
            {

                break;
            }
            else
            {
                parent = parent.parent;
            }
        }
        if(sko != null)
        {
            sko.FlushData();
            Debug.Log("刷新根节点");

        }
        else
        {
            Debug.LogError("这个SignSerializableUI 没有根节点");
        }
    }

    public bool Contains(Object obj)
    {
        
        foreach (var item in coms)
        {
            if(item.obj == obj)
            {
                return true;
            }
        }
        return false;
    }
    public void Delete(Object obj)
    {
        int deleteIndex = -1;
        for (int i = 0; i < coms.Count; i++)
        //foreach (var item in coms)
        {
            var item = coms[i];
            if (item.obj == obj)
            {
                deleteIndex = i;
            }
        }
        if(deleteIndex >= 0)
        {
            coms.RemoveAt(deleteIndex);
        }
    }
    public static string GetPath(Component com)
    {
        return GetPath(com.gameObject) + "_" + com.GetType().Name;
    }

    public static string GetPath(GameObject go)
    {
        var sko = go.GetComponent<SerializableKeyObject>();
        var parent = go.transform.parent;
        var sb = new StringBuilder(20);
        var paths = new Stack<string>();
        paths.Push(go.name);
        while (sko == null && parent != null)
        {

            sko = parent.gameObject.GetComponent<SerializableKeyObject>();
            if (sko == null)
            {
                paths.Push(parent.name + "_");
                parent = parent.parent;

            }
            else
            {
                break;
            }
        }
        foreach (var item in paths)
        {
            sb.Append(item);
        }
        return sb.ToString();
    }
#endif
}
}