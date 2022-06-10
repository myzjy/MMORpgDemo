namespace Script.Framework.UI
{
    public class UINotification
    {
        public UINotification(string name, object body)
        {
            this._name = name;
            this.body = body;
        }

        public void SetBase(string name, object body)
        {
            this._name = name;
            this.body = body;
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
        }
        private object body;

        public T GetParms<T>()
        {
            return (T)this.body;
        }
        public object Get()
        {
            return this.body;
        }
    }
}