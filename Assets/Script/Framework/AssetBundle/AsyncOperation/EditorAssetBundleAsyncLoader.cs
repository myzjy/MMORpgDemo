﻿/// <summary>
/// added by wsh @ 2017.12.22
/// 2022.5.28
/// 功能：assetbundle在simulate模式下的Asset模拟异步加载器 
/// </summary>

namespace Framework.AssetBundle.AsyncOperation
{
    public class EditorAssetBundleAsyncLoader : BaseAssetBundleAsyncLoader
    {
        public EditorAssetBundleAsyncLoader(string assetbundleName)
        {
            this.assetbundleName = assetbundleName;
        }

        public override bool IsDone()
        {
            return true;
        }

        public override float Progress()
        {
            return 1.0f;
        }

        public override void Update()
        {
        }

        public override void Dispose()
        {
        }
    }
}