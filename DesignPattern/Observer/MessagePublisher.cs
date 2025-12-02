namespace Observer
{
    public class MessagePublisher
    {
        private readonly List<IMessageSubscriber> _subscribers = new();
        public void Subscribe(IMessageSubscriber subscriber) { _subscribers.Add(subscriber); }
        public void Unsubscribe(IMessageSubscriber subscriber) { _subscribers.Remove(subscriber); }
        public void Notify(string message)
        {
            foreach (var s in _subscribers) s.Update(message);
        }
    }
}