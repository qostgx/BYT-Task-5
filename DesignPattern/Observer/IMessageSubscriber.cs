namespace Observer
{
    public interface IMessageSubscriber
    {
        void Update(string message);
    }
}