using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using XLua;

public class GameLaunch : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
 
        //初始化版本号
        /**
         * 此处的时间是向服务器请求的，不能用本机时间
         */
        var start = DateTime.Now;
        
        
        
        yield break;
    }

    public void OnInit()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}