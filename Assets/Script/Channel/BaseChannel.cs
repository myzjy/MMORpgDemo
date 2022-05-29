namespace Common.GameChannel
{
    public abstract class BaseChannel
    {
        //基础
        public abstract void Init();

        public abstract void DownloadGame(params object[] paramList);
        /// <summary>
        /// 安装apk
        /// 这个地方需要调用原生代码去安装，目前来说
        /// 不去做，有能力的可以去做 安卓 ios的原生代码
        /// </summary>
        public abstract void InstallApk();
        public abstract string GetProductName();

        public virtual bool IsInternalChannel()
        {
            return false;
        }
    }
}