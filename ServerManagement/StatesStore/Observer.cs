namespace ServerManagement.StatesStore
{
    public class Observer
    {
        protected Action? _listeners;

        public void AddStateChangeListeners(Action listener)
        {
            _listeners += listener;
        }

        public void RemoveStateChangeListeners(Action listener)
        {
            if (_listeners is not null)
            {
                _listeners -= listener;
            }

        }

        public void BroadcastStateChange()
        {
            _listeners?.Invoke();
        }

    }
}
