namespace Common.GameChannel.Implement
{
    public class TestChannel: BaseChannel
    {
        public override void Init()
        {
            
        }

        public override void DownloadGame(params object[] paramList)
        {
            string url = paramList[0] as string;
            string saveName = paramList[1] as string;
        }

        public override void InstallApk()
        {
            throw new System.NotImplementedException();
        }

        public override string GetProductName()
        {
            return "xluaframework";
        }
    }
}