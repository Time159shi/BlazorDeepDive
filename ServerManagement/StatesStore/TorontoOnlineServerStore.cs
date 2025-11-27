namespace ServerManagement.StatesStore
{
    public class TorontoOnlineServerStore : Observer
    {
        private int _numServersOnline;

        public int GetNumberServerOnline() { return _numServersOnline; }

        public void SetNumberServerOnline(int number)
        {
            _numServersOnline = number;
            base.BroadcastStateChange();
        }
    }
}
